using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistema_academico.Models;
using sistemas_academicas.models;
using sistemas_academicas.Models;

namespace sistema_academicas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculaController : ControllerBase
    {
        private readonly MyDbContext _context;
        private bool idalumno;

        public MatriculaController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Matricula
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Matricula>>> GetMatricula() =>
            //return await _context.Matricula.ToListAsync();
           await _context.Matricula.Include(idalumno ==> idalumno).TolisAsync();

        // GET: api/Matricula/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Alumno>> GetMatricula(int id)
        {
            var alumno = await _context.Matricula.FindAsync(id);

            if (alumno == null)
            {
                return NotFound();
            }

            return Matricula;
        }
        // PUT: api/Matricula/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlumno(int id, Matricula alumno)
        {
            if (id != alumno.idMatricula)
            {
                return BadRequest();
            }

            _context.Entry(alumno).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlumnoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return CreatedAtAction("GetAlumno", new { id = alumno.idMatricula }, alumno);
            //return NoContent();
        }

        // POST: api/Matricula
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Matricula>> PostAlumno(Matricula alumno)
        {
            _context.Matricula.Add(alumno);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlumno", new { id = alumno.idMatricula}, alumno);
        }

        // DELETE: api/Matricula/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlumno(int id)
        {
            var alumno = await _context.Matricula.FindAsync(id);
            if (alumno == null)
            {
                return NotFound();
            }

            _context.Matricula.Remove(alumno);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlumnoExists(int id)
        {
            return _context.Matricula.Any(e => e.idMatricula == id);
        }
    }
}