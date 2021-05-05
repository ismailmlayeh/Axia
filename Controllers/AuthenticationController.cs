using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using webapiworkflow.Authentication;
using webapiworkflow.IService;
using webapiworkflow.Models;

namespace webapiworkflow.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
      //  private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _configuration;
        //private string c;

        //manel

        private readonly IRuserroleService IRuserroleService;
        //

        public AuthenticationController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration
            , 
            //manel
            IRuserroleService ruserrole
            )
        {
            this.userManager = userManager;
            //this.roleManager = roleManager;
            _configuration = configuration;
            //manel
            IRuserroleService = ruserrole;
        }

        
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var userExist = await userManager.FindByNameAsync(model.UserName);
            if (userExist != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = " User Already Exist" });

            ApplicationUser user = new ApplicationUser
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.UserName,
                //role = model.Role,
                idrole = model.Idrole

                };
     

            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                { Status = "Error", Message = "Failed to register new user" });

            //manel
            AspnetusersHasRolelist ruserrolee = new AspnetusersHasRolelist
            {
                AspnetusersId = user.Id,
                RolelistId = model.Idrole,
                Aspnetusers = null,
                Rolelist = null
            };
            IRuserroleService.AddRuserrole(ruserrolee);

            //

            return Ok(new
            {
                Id = user.Id,
                User = user.UserName,
                Email = user.Email,
                Role = user.role,
                IdRole=user.idrole


            });


        }




        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
               // var userRoles = await userManager.GetRolesAsync(user);
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };
                //foreach (var userRole in userRoles)
                //{
                //    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                //}

                //changing the encoding
               // var authSiginKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]));
                var authSiginKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSiginKey, SecurityAlgorithms.HmacSha256Signature)
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    ValidTo = token.ValidTo.ToString("yyyy-MM-ddThh:mm:ss"),
                    User = user.UserName ,
                    Id = user.Id,
                    role = user.role,
                    IdRole = user.idrole

                });
            }
            return Unauthorized();
        }

    }




    
}

