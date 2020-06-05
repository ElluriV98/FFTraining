using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace EntityFrameWrokCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        public AuthController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 1)
            {
                return Ok(GenerateToken("MovieDetails"));
            }
            else
            {
                return Ok("Invalid");
            }

        }
        private string GenerateToken(string userRole)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:ServerSecret"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Role,userRole)
            };
            var token = new JwtSecurityToken(issuer: Configuration["JWT:Issuer"], audience: Configuration["JWT:Audience"],
                claims: claims, expires: DateTime.Now.AddMinutes(23), signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);

        }

     
    }
}
