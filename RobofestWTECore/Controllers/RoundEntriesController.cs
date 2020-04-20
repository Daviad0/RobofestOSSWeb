using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RobofestWTE.Models;
using RobofestWTECore.Data;

namespace RobofestWTECore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoundEntriesController : ControllerBase
    {
        private readonly GameContext _context;

        public RoundEntriesController(GameContext context)
        {
            _context = context;
        }

        // GET: api/RoundEntries
        [HttpGet]
        public IEnumerable<RoundEntry> GetRoundEntries()
        {
            return _context.RoundEntries;
        }

        // GET: api/RoundEntries/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoundEntry([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var roundEntry = await _context.RoundEntries.FindAsync(id);

            if (roundEntry == null)
            {
                return NotFound();
            }

            return Ok(roundEntry);
        }

        // PUT: api/RoundEntries/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoundEntry([FromRoute] int id, [FromBody] RoundEntry roundEntry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != roundEntry.EntryID)
            {
                return BadRequest();
            }

            _context.Entry(roundEntry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoundEntryExists(id))
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

        // POST: api/RoundEntries
        [HttpPost]
        public async Task<IActionResult> PostRoundEntry([FromBody] RoundEntry roundEntry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.RoundEntries.Add(roundEntry);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoundEntry", new { id = roundEntry.EntryID }, roundEntry);
        }

        // DELETE: api/RoundEntries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoundEntry([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var roundEntry = await _context.RoundEntries.FindAsync(id);
            if (roundEntry == null)
            {
                return NotFound();
            }

            _context.RoundEntries.Remove(roundEntry);
            await _context.SaveChangesAsync();

            return Ok(roundEntry);
        }

        private bool RoundEntryExists(int id)
        {
            return _context.RoundEntries.Any(e => e.EntryID == id);
        }
    }
}