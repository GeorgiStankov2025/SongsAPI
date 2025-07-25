using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SongsAPI.Data;
using System.Linq;
using SongsAPI.Models;
using SongsAPI.Migrations;
using System.Runtime.ExceptionServices;

namespace SongsAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {

        private readonly SongsDbContext _context;

        public SongsController(SongsDbContext context)
        {

            _context = context;

        }


        [HttpGet]
        public async Task<ActionResult<List<Songs>>> GetSongs()
        {

            return Ok(await _context.Songs.ToListAsync());

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Songs>>> GetSongById(int id)
        {

            var song= await _context.Songs.FindAsync(id);

            if (song is null)
            {

                return NotFound();

            }

            else
            {

                return Ok(song);

            }

        }

        [HttpPost]

        public async Task<ActionResult<Songs>> AddNewSong(Songs newsong)
        {

            if(newsong.Name is null||newsong.Singer is null||newsong.Genre is null)
            {

                return BadRequest();

                

            }

            

                _context.Songs.Add(newsong);

                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetSongById), new { id = newsong.Id }, newsong);

            

        }

        [HttpPut]

        public async Task<ActionResult<List<Songs>>> UpdateSongs(int id, Songs updatedSong)
        {

            var song = await _context.Songs.FindAsync(id);

            if (song is null)
            {

                return NotFound();

            }

           
                song.Name = updatedSong.Name;
                song.Genre = updatedSong.Genre;
                song.Singer = updatedSong.Singer;

                await _context.SaveChangesAsync();

                return NoContent();

            

        }
        [HttpDelete]
        public async Task<ActionResult> DeleteSong(int id)
        {

            var song = await _context.Songs.FindAsync(id);
            
            if (song is null)
            {

                return NotFound();

            }

            _context.Songs.Remove(song);

            

            await _context.SaveChangesAsync();

            return NoContent();

        }


    }



}

