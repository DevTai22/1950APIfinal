using API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly DataContext _context;

        public TaskController(DataContext context)
        {
            _context = context;
        }
       
        [HttpGet]
        public async Task<ActionResult<List<Tarea>>> GetTarea()
        {
            return Ok(await _context.Tarea.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tarea>> GetTarea(int id)
        {
            var inspection = await _context.Tarea.FindAsync(id);

            if (inspection == null)
            {
                return NotFound();
            }

            return inspection;
        }


        [HttpPost]
        public async Task<ActionResult<List<Tarea>>> CreateTarea(Tarea tarea) 
        {
            _context.Tarea.Add(tarea);
            await _context.SaveChangesAsync();

            return Ok(await _context.Tarea.ToListAsync());

        }

        [HttpPut]
        public async Task<ActionResult<List<Tarea>>> UpdateTarea(Tarea tarea) 
        { 
            var dbtarea = await _context.Tarea.FindAsync(tarea.Id);
            tarea.Id = 1;
            if (dbtarea == null)
                return BadRequest("no se encuentra esa Tarea");

            dbtarea.Name = tarea.Name;
            dbtarea.Description = tarea.Description;
            dbtarea.Status = tarea.Status;

            await _context.SaveChangesAsync();

            return Ok(await _context.Tarea.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Tarea>>> DeleteTarea(int id) 
        {
            var dbtarea = await _context.Tarea.FindAsync(id);
            if (dbtarea == null)
                return BadRequest("no se encuentra esa Tarea");

            _context.Tarea.Remove(dbtarea);
            await _context.SaveChangesAsync();

            return Ok(await _context.Tarea.ToListAsync());
        }

    }
}



