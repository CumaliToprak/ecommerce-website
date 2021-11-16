using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using UzmanMetal.Api.DTO;
using UzmanMetal.Core.Models;

namespace UzmanMetal.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _config;

        public AccountController(UserManager<ApplicationUser> userManager,
                SignInManager<ApplicationUser> signInManager,
                RoleManager<IdentityRole> roleManager,
                IConfiguration config)
        {
            this._signInManager = signInManager;
            this._roleManager = roleManager;
            this._config = config;
            this._userManager = userManager;

        }

        // [AllowAnonymous]
        // [HttpPost("login")]
        // public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        // {
        //     var user = _userManager.Users.FirstOrDefault(u => u.Email == loginDto.Email);


        // }




        [HttpGet("Check")]
        public string IsHealthy()
        {
            return "I am healthy";
        }
    }
}