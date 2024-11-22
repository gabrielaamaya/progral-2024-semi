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
    public class DocentesController : ControllerBase
    {
        private readonly MyDbContext _context;

        public DocentesController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Docentes
        [HttpGet("buscar")]
        public async Task<ActionResult<IEnumerable<Docente>>> GetDocentes()
        {
            return await _context.Docentes.ToListAsync();
        }
        // GET: api/Docentes/buscar
        [HttpGet("{buscar}")]
        public async Task<ActionResult<IEnumerable<Docente>>> BuscarDocentes(string buscar) { 
            var consulta = _context.Docentes.AsQueryable();
            if (!string.IsNullOrEmpty(buscar)){
                consulta = consulta.Where(d => d.nombre.Contains(buscar));
            }
            if (!string.IsNullOrEmpty(buscar) && consulta.Count()<=0   ){
                consulta = _context.Docentes.AsQueryable();
                consulta = consulta.Where(d => d.codigo.Contains(buscar));
            }
            return await consulta.ToListAsync();
        }
        

        // PUT: api/Docentes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putdocentes(int id, Docente docente)
        {
            if (id != docente.idDocente)
            {
                return BadRequest();
            }

            _context.Entry(docente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocenteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            //return CreatedAtAction("GetDocente", new { id = docente.idDocente }, docente);
            return NoContent();
        }
        // GET: api/Docente/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Docente>> GetDocente(int id)
        {
            var Docente = await _context.Docentes.FindAsync(id);

            if (Docente == null)
            {
                return NotFound();
            }

            return Docente;
        }
        // POST: api/Docentes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Docente>> PostDocente(Docente docente)
        {
            _context.Docentes.Add(docente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDocente", new { id = docente.idDocente }, docente);
        }

        // DELETE: api/Docentes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDocente(int id)
        {
            var docente = await _context.Docentes.FindAsync(id);
            if (docente == null)
            {
                return NotFound();
            }

            _context.Docentes.Remove(docente);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetDocente", new { id = docente.idDocente }, docente);
            //return NoContent();
        }

        private bool DocenteExists(int id)
        {
            return _context.Docentes.Any(e => e.idDocente == id);
        }
    }
}
