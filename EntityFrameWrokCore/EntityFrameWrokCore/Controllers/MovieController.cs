using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameWrokCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameWrokCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "MovieDetails")]
    public class MovieController : ControllerBase
    {
        EntityFrameWorkContext entity = new EntityFrameWorkContext();
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(entity.TblMovie);
        }
        [HttpPost]
        public IActionResult Post([FromBody] TblMovie moviedet)
        {
            TblMovie movie = new TblMovie();
            movie.Mid = moviedet.Mid;
            movie.Mname = moviedet.Mname;
            movie.Mtype = moviedet.Mtype;
            movie.Mdate = moviedet.Mdate;
            movie.Mbooking = moviedet.Mbooking;
            entity.TblMovie.Add(movie);
            entity.SaveChanges();
            return Ok(new { Message = "New Movie Added Successfully" });
        }
        [HttpPut("{mid}")]
        public IActionResult Put([FromBody] TblMovie moviedet,int mid)
        {
            TblMovie movie = entity.TblMovie.Where(e=>e.Mid==mid).FirstOrDefault();
            movie.Mname = moviedet.Mname;
            movie.Mtype = moviedet.Mtype;
            movie.Mdate = moviedet.Mdate;
            movie.Mbooking = moviedet.Mbooking;
            entity.SaveChanges();
            return Ok(new { Message = "Updated Successfully" });
        }
        [HttpDelete("{mid}")]
        public IActionResult Delete(int mid)
        {
            TblMovie movie = entity.TblMovie.Where(e => e.Mid == mid).FirstOrDefault();
            entity.TblMovie.Remove(movie);
            entity.SaveChanges();
            return Ok(new { Message = "Deleted Successfully" });
        }
    }
}
