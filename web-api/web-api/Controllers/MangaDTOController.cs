using System.Xml.Serialization;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Reflection.PortableExecutable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_api.Models;

namespace web_api.Controllers
{
    [Route("api/mangaDTO")]
    [ApiController]
    public class MangaDTOController : ControllerBase
    {
        private readonly MangaContext _context;

        public MangaDTOController(MangaContext context)
        {
            _context = context;
        }

        // GET: api/Manga
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Manga>>> GetManga()
        {
            return await _context.Manga.ToListAsync();
        }

        // GET: api/Manga/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Manga>> GetManga(long id)
        {
            var manga = await _context.Manga.FindAsync(id);

            if (manga == null)
            {
                return NotFound();
            }

            return manga;
        }

        // PUT: api/Manga/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutManga(long id, Manga manga)
        {
            if (id != manga.Id)
            {
                return BadRequest();
            }

            _context.Entry(manga).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MangaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Manga
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Manga>> PostManga(Manga manga)
        {
            _context.Manga.Add(manga);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetManga), new { id = manga.Id}, manga);
            // return CreatedAtAction("GetManga", new { id = manga.Id }, manga);
        }

        // DELETE: api/Manga/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Manga>> DeleteManga(long id)
        {
            var manga = await _context.Manga.FindAsync(id);
            if (manga == null)
            {
                return NotFound();
            }

            _context.Manga.Remove(manga);
            await _context.SaveChangesAsync();

            return manga;
        }

        private bool MangaExists(long id)
        {
            return _context.Manga.Any(e => e.Id == id);
        }

        private static MangaDTO ItemToDTO(Manga manga) {
            new MangaDTO 
            {
                Id = Manga.Id,
                Nom = Manga.Nom,
                Auteur = Manga.Auteur,
                Editeur = Manga.Editeur,
                Description = Manga.Description,
                Etat = Manga.Etat,
                Type = Manga.Type,
                Themes = Manga.Themes,
                Genre = Manga.Genre
            }
        }
    }
}
