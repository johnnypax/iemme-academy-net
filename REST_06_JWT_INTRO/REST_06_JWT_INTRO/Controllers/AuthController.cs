using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using REST_06_JWT_INTRO.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace REST_06_JWT_INTRO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]         //localhost:1234/api/auth
    public class AuthController : Controller
    {
        [HttpPost("login")]             //localhost:1234/api/auth/login
        public IActionResult Login(UserLogin objLogin)
        {
            if (string.IsNullOrWhiteSpace(objLogin.Username) || string.IsNullOrWhiteSpace(objLogin.Password))
                return BadRequest();

            if(objLogin.Username == "giovanni" && objLogin.Password == "1234")
            {
                objLogin.UserType = "ADMIN";
            }
            if (objLogin.Username == "valeria" && objLogin.Password == "4321")
            {
                objLogin.UserType = "USER";
            }

            if(objLogin.UserType is not null)
            {
                List<Claim> claimsList = new List<Claim>()
                {
                    new Claim(JwtRegisteredClaimNames.Sub, objLogin.Username),
                    new Claim("userType", objLogin.UserType),
                    //new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("giovanni_genio_giovanni_genio_giovanni_genio_giovanni_genio_giovanni_genio"));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "Archety.dev",
                    audience: "Popolo",
                    claims: claimsList,
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: creds
                );

                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
            }

            return NotFound();
        }
    }
}
