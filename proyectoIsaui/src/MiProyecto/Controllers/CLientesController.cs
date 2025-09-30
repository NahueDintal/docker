using Microsoft.AspNetCore.Mvc;
using SistemaFact.Clases;
using System.Data;

namespace MiProyecto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var tabla = cDb.Select("SELECT * FROM Clientes");
                return Ok(tabla);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {
            try
            {
                var sql = $"INSERT INTO Clientes (Nombre, Email) VALUES ('{cliente.Nombre}', '{cliente.Email}')";
                cDb.Grabar(sql);
                return Ok("Cliente creado");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }
    }
}
