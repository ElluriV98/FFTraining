using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameWrokCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameWrokCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        EntityFrameWorkContext entity = new EntityFrameWorkContext();
        [Route("LoginUser")]
        [HttpPost]
        public IActionResult LoginUser([FromBody] TblLogin userLogin)
        {
            var userLogged = entity.TblLogin.Where(ad => ad.Name == userLogin.Name && ad.Passcode == userLogin.Passcode).FirstOrDefault();
            if (userLogged != null)
            {   
                return Ok(new { Message = "Logged In Successfully", User = userLogged });
            }
            else
            {
                return Ok(new
                {
                    Message = "Invalid Credentials"
                });
            }
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(entity.TblLogin);
        }
    }
}
