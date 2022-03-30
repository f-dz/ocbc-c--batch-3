using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class MovieController : ControllerBase
    {
        private readonly ApiDbContext _context;
        
        public MovieController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovie()
        {
            var movie = await _context.Movie.ToListAsync();
            return Ok(movie);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(MovieData data)
        {
            if(ModelState.IsValid)
            {
                await _context.Movie.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetMovie", new {data.Id}, data);
            }
            return new JsonResult("Something went wrong") {StatusCode = 500};
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovie(int id)
        {
            var movie= await _context.Movie.FirstOrDefaultAsync(x => x.Id == id);

            if(movie == null) return NotFound();

            return Ok(movie);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, MovieData movie)
        {
            if(id != movie.Id) return BadRequest();

            var existMovie = await _context.Movie.FirstOrDefaultAsync(x => x.Id == id);

            if(existMovie == null) return NotFound();

            existMovie.Name = movie.Name;
            existMovie.Genre = movie.Genre;
            existMovie.Duration = movie.Duration;
            existMovie.ReleaseDate = movie.ReleaseDate;

            //implement the changes on the database level
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var existMovie = await _context.Movie.FirstOrDefaultAsync(x => x.Id == id);

            if(existMovie == null) return NotFound();

            _context.Movie.Remove(existMovie);
            await _context.SaveChangesAsync();

            return Ok(existMovie);
        }
    }
}
