using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Case_Study_3_.Dataa;
using Case_Study_3_.Models;

namespace Case_Study_3_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        private readonly Context _context;

        public SchoolsController(Context context)
        {
            _context = context;
        }

        // GET: api/Schools
        [HttpGet]
        public async Task<ActionResult<IEnumerable<School>>> Getss()
        {
            return await _context.ss.ToListAsync();
        }

        // GET: api/Schools/5
        [HttpGet("{id}")]
        public async Task<ActionResult<School>> GetSchool(int id)
        {
            var school = await _context.ss.FindAsync(id);

            if (school == null)
            {
                return NotFound();
            }

            return school;
        }

       
        // POST: api/Schools
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<School>> PostSchool(School school)
        {
            _context.ss.Add(school);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSchool", new { id = school.Id }, school);
        }

      

        private bool SchoolExists(int id)
        {
            return _context.ss.Any(e => e.Id == id);
        }
    }
}
