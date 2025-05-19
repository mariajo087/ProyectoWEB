using Microsoft.AspNetCore.Mvc;
using ProyectoWEB.Data;
using ProyectoWEB.Models;

namespace ProyectoWEB.Controllers
{
    [ApiController]
    public class PrestamoController: ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PrestamoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("api/prestamo/guardar")]
        public IActionResult Guardar([FromBody] Prestamo model)

        {
            try
            {
                _context.Prestamo.Add(model);
                _context.SaveChanges();

                return Ok(new { mensaje = "Formulario guardado exitosamente." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    mensaje = "Error en el servidor: " + ex.Message,
                    detalle = ex.InnerException?.Message
                });
            }
        }
    }
}
