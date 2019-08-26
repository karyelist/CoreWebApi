using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_Api;

namespace Web_Api.Models
{
    [Route("v2/[controller]")]
    [ApiController]
    public class TsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public TsController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Ts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestTable>>> GetTestTable()
        {
            return await _context.TestTable.ToListAsync();
        }

        // GET: api/Ts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TestTable>> GetTestTable(int id)
        {
            var testTable = await _context.TestTable.FindAsync(id);

            if (testTable == null)
            {
                return NotFound();
            }

            return testTable;
        }

        // PUT: api/Ts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestTable(int id, TestTable testTable)
        {
            if (id != testTable.Id)
            {
                return BadRequest();
            }

            _context.Entry(testTable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestTableExists(id))
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

        // POST: api/Ts
        [HttpPost]
        public async Task<ActionResult<TestTable>> PostTestTable(TestTable testTable)
        {
            _context.TestTable.Add(testTable);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTestTable", new { id = testTable.Id }, testTable);
        }

        // DELETE: api/Ts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TestTable>> DeleteTestTable(int id)
        {
            var testTable = await _context.TestTable.FindAsync(id);
            if (testTable == null)
            {
                return NotFound();
            }

            _context.TestTable.Remove(testTable);
            await _context.SaveChangesAsync();

            return testTable;
        }

        private bool TestTableExists(int id)
        {
            return _context.TestTable.Any(e => e.Id == id);
        }
    }
}
