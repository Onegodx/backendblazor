namespace WebApplication1
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using WebApplication1.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {
        private readonly ModelDB _context;

        public PropertiesController(ModelDB context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Property>>> GetProperties()
        {
            return await _context.Properties.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Property>> GetProperty(int id)
        {
            var property = await _context.Properties.FindAsync(id);
            if (property == null) return NotFound();
            return property;
        }

    }
}
