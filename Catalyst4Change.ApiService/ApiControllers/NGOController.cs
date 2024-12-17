using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Catalyst4Change.ApiService.Data;

namespace Catalyst4Change.ApiService.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NGOController : ControllerBase
    {
        private readonly Catalyst4ChangeDBContext _context;

        public NGOController(Catalyst4ChangeDBContext context)
        {
            _context = context;
        }

        // GET: api/NGO
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NGO>>> GetNGOList()
        {
            return await _context.NGOList.ToListAsync();
        }

        // GET: api/NGO/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NGO>> GetNGO(int id)
        {
            var nGO = await _context.NGOList.FindAsync(id);

            if (nGO == null)
            {
                return NotFound();
            }

            return nGO;
        }

        // PUT: api/NGO/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNGO(int id, NGO nGO)
        {
            if (id != nGO.Id)
            {
                return BadRequest();
            }

            _context.Entry(nGO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NGOExists(id))
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

        // POST: api/NGO
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NGO>> PostNGO(NGO nGO)
        {
            _context.NGOList.Add(nGO);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNGO", new { id = nGO.Id }, nGO);
        }

        // DELETE: api/NGO/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNGO(int id)
        {
            var nGO = await _context.NGOList.FindAsync(id);
            if (nGO == null)
            {
                return NotFound();
            }

            _context.NGOList.Remove(nGO);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NGOExists(int id)
        {
            return _context.NGOList.Any(e => e.Id == id);
        }
    }
}
