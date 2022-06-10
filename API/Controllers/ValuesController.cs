using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ValuesContext _context;

        public ValuesController(ValuesContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<ActionResult> GetAllValues()
        {
            return Ok(await _context.Values.ToArrayAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProduct(int id)
        {
            var value = await _context.Values.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }
            return Ok(value);
        }

        [HttpPost]
        public async Task<ActionResult<Value>> PostProduct(Value value)
        {
            
            if (!ModelState.IsValid) {
                return BadRequest();
            }
            
            _context.Values.Add(value);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                "GetProduct",
                new { id = value.Id },
                value);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutProduct(int id, Value value)
        {
            if (id != value.Id)
            {
                return BadRequest();
            }

            _context.Entry(value).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Values.Any(p => p.Id == id))
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

        [HttpDelete("{id}")]
        public async Task<ActionResult<Value>> DeleteProduct(int id)
        {
            var value = await _context.Values.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.Values.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }

        [HttpPost]
        [Route("Delete")]
        public async Task<ActionResult> DeleteMultiple([FromQuery] int[] ids)
        {
            var Values = new List<Value>();
            foreach (var id in ids)
            {
                var value = await _context.Values.FindAsync(id);

                if (value == null)
                {
                    return NotFound();
                }

                Values.Add(value);
            }

            _context.Values.RemoveRange(Values);
            await _context.SaveChangesAsync();

            return Ok(Values);
        }
    }
}