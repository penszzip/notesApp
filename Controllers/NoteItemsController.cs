using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using notesApp.Models;

namespace notesApp.Controllers
{
    [Route("api/notes")]
    [ApiController]
    public class NoteItemsController : ControllerBase
    {
        private readonly NoteDbContext _context;

        public NoteItemsController(NoteDbContext context)
        {
            _context = context;
        }

        // GET: api/notes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NoteItem>>> GetNoteItems()
        {
            return await _context.NoteItems.ToListAsync();
        }

        // GET: api/notes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NoteItem>> GetNoteItem(int id)
        {
            var noteItem = await _context.NoteItems.FindAsync(id);

            if (noteItem == null)
            {
                return NotFound();
            }

            return noteItem;
        }

        // PUT: api/notes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNoteItem(int id, NoteItem noteItem)
        {
            if (id != noteItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(noteItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NoteItemExists(id))
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

        // POST: api/notes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NoteItem>> PostNoteItem(NoteItem noteItem)
        {
            _context.NoteItems.Add(noteItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(PostNoteItem), new { id = noteItem.Id }, noteItem);
        }

        // DELETE: api/notes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNoteItem(int id)
        {
            var noteItem = await _context.NoteItems.FindAsync(id);
            if (noteItem == null)
            {
                return NotFound();
            }

            _context.NoteItems.Remove(noteItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NoteItemExists(int id)
        {
            return _context.NoteItems.Any(e => e.Id == id);
        }
    }
}
