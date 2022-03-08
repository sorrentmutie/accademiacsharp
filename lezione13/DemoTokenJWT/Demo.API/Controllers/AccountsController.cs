using Demo.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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
                return StatusCode(500);
            }
        }

    }
}
