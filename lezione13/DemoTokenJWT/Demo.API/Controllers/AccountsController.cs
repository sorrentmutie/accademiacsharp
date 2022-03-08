using Demo.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Demo.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IConfiguration configuration;

        public AccountsController(SignInManager<IdentityUser> signInManager,
             UserManager<IdentityUser> userManager,
             IConfiguration configuration)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.configuration = configuration;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest newUser)
        {
            IdentityUser identityUser = new IdentityUser()
            {
                Email = newUser.Email,
                UserName = newUser.Email
            };
            IdentityResult result = await userManager.CreateAsync(identityUser, newUser.Password);
            if(result.Succeeded)
            {
                return StatusCode(StatusCodes.Status201Created, new { result.Succeeded });
            } else
            {
                var errors = "Registrazione fallita";
                foreach (var error in result.Errors)
                {
                    errors += $"Codice di errore: {error.Code} Descrizione: {error.Description}";
                    errors += Environment.NewLine;
                }
                return StatusCode(StatusCodes.Status500InternalServerError, errors);
            }
        }

        [NonAction]
        [ApiExplorerSettings(IgnoreApi = true)]
        private async Task<string> GeneraJSONWebToken(IdentityUser identityUser)
        {
            var symmetricKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(configuration["Jwt:SecurityKey"]));
            var credentials = new SigningCredentials(symmetricKey, SecurityAlgorithms.HmacSha256);

            IList<string> roleNames = await userManager.GetRolesAsync(identityUser);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, identityUser.Id),
                new Claim(ClaimTypes.Email, identityUser.Email),
                new Claim(ClaimTypes.Name, identityUser.Email),
                new Claim(JwtRegisteredClaimNames.Sub, identityUser.Email ),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            }.Union(roleNames.Select(role => new Claim(ClaimTypes.Role, role)));

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken
                (configuration["Jwt:Issuer"], configuration["Jwt:Audience"],
                claims, DateTime.UtcNow, DateTime.UtcNow.AddMinutes(10),
                credentials);

            return new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        }

        [HttpPost]
        [Route("signin")]
        public async Task<IActionResult> SignIn([FromBody] RegisterRequest user)
        {
            var signInResult = await signInManager.PasswordSignInAsync(
                 user.Email, user.Password, false, false);
            if(signInResult.Succeeded == true)
            {
                IdentityUser identityUser = await userManager.FindByEmailAsync(user.Email);
                var jwtToken = await GeneraJSONWebToken(identityUser);
                return Ok(jwtToken);
            } else
            {
                return Unauthorized(user);
            }
        }


    }
}
