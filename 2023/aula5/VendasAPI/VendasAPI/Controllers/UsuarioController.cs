using Microsoft.AspNetCore.Mvc;
using VendasAPI.Model;

namespace VendasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        List<Usuario> usuarios = new List<Usuario>();

        [HttpPost]
        public void AdidCard([FromBody] Usuario user)
        {
            usuarios.Add(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuarioById(int id) {
            Usuario user = usuarios.FirstOrDefault(user => user.Id == id);
            if(user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        [HttpPost]
        public void AddUsuario([FromBody] Usuario user)
        {
            usuarios.Add(user);
        }
    }
}
