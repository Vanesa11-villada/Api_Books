using Microsoft.AspNetCore.Mvc;
using LibraryApi.Models;

namespace LibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly LibraryAPIDbContext _context;

        public TestController(LibraryAPIDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult TestDbConnection()
        {
            try
            {
                // Intenta acceder a la base de datos
                var usersCount = _context.Users.Count();
                return Ok($"Conexión exitosa a la base de datos. Usuarios en la tabla: {usersCount}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error conectando a la base de datos: {ex.Message}");
            }
        }
    }
}
