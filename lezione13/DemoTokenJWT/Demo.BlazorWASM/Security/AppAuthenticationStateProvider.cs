using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Demo.BlazorWASM.Security
{
    public class AppAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService localStorageService;
        private readonly JwtSecurityTokenHandler jwtSecurityTokenHandler = new();

        public AppAuthenticationStateProvider(ILocalStorageService localStorageService)
        {
            this.localStorageService = localStorageService;
        }

        public async Task SignIn()
        {
            string jwtToken = await localStorageService.GetItemAsync<string>("bearerToken");
            JwtSecurityToken jwtSecurityToken = jwtSecurityTokenHandler.ReadJwtToken(jwtToken);
            IList<Claim> claims = jwtSecurityToken.Claims.ToList();
            claims.Add(new Claim(ClaimTypes.Name, jwtSecurityToken.Subject));
            var user = new ClaimsPrincipal(new ClaimsIdentity(claims, "jwt"));
            Task<AuthenticationState> authentication =
                 Task.FromResult(new AuthenticationState(user));
            NotifyAuthenticationStateChanged(authentication);
        }

        public void SignOut()
        {
            ClaimsPrincipal utenteUscito = new ClaimsPrincipal(new ClaimsIdentity());
            Task<AuthenticationState> authentication =
                 Task.FromResult(new AuthenticationState(utenteUscito));
            NotifyAuthenticationStateChanged(authentication);
        }


        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                string jwtToken = await localStorageService.GetItemAsStringAsync("bearerToken");

                if(string.IsNullOrWhiteSpace(jwtToken))
                {
                    return new AuthenticationState(
                        new ClaimsPrincipal(new ClaimsIdentity { }));
                }

                JwtSecurityToken jwtSecurityToken = jwtSecurityTokenHandler.ReadJwtToken(jwtToken);
                DateTime expires = jwtSecurityToken.ValidTo;
                if(expires < DateTime.UtcNow)
                {
                    await localStorageService.RemoveItemAsync("bearerToken");
                    return new AuthenticationState(
                        new ClaimsPrincipal(new ClaimsIdentity { }));
                }

                IList<Claim> claims = jwtSecurityToken.Claims.ToList();
                claims.Add(new Claim(ClaimTypes.Name, jwtSecurityToken.Subject));
                var user = new ClaimsPrincipal(new ClaimsIdentity(claims, "jwt"));
                return new AuthenticationState(user);

            }
            catch (Exception)
            {

               return new AuthenticationState(
                   new ClaimsPrincipal(new ClaimsIdentity { }));
            }
        }
    }
}
