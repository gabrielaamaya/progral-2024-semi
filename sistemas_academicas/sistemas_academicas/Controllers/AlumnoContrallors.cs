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
    public class DocenteController : ControllerBase
    {
        private readonly MyDbContext _context;

        // Constructor del controlador, que debería llamarse DocenteController
        public DocenteController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Docentes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Docente>>> GetDocentes()
        {
            return await _context.Docentes.ToListAsync();
        }

        // GET: api/Docentes/buscar
        [HttpGet("buscar")]
        public async Task<ActionResult<IEnumerable<Docente>>> BuscarDocente([FromQuery] DocenteBusquedaParametros parametros)
        {
            var consulta = _context.Docentes.AsQueryable();

            if (!string.IsNullOrEmpty(parametros.buscar))
            {
                // Primero intenta buscar por nombre
                consulta = consulta.Where(d => d.nombre.Contains(parametros.buscar));
            }

            // Si no se encontró ningún docente por nombre, intenta buscar por código
            if (!string.IsNullOrEmpty(parametros.buscar) && !consulta.Any())
            {
                consulta = _context.Docentes.Where(d => d.codigo.Contains(parametros.buscar));
            }

            return await consulta.ToListAsync();
        }

        // GET: api/Docentes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Docente>> GetDocente(int id)
        {
            var docente = await _context.Docentes.FindAsync(id);

            if (docente == null)
            {
                return NotFound();
            }

            return docente;
        }

        // PUT: api/Docentes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDocente(int id, Docente docente)
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

            return CreatedAtAction("GetDocente", new { id = docente.idDocente }, docente);
        }

        // POST: api/Docentes
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

            return NoContent();
        }

        private bool DocenteExists(int id)
        {
            return _context.Docentes.Any(e => e.idDocente == id);
        }
    }
}
