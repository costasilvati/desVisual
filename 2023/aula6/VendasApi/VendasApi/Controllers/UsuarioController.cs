using Microsoft.AspNetCore.Mvc;
using VendasApi.Models;

namespace VendasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly List<Usuario> usuarios = new List<Usuario>();

        public void alimentaLista()
        {
            Usuario usr1 = new Usuario();
            usr1.Email = "juju";
            usr1.Password = "password";
            usr1.Id = 1;
            usuarios.Add(usr1);
        }

        [HttpPost]
        public IActionResult AddUsuario([FromBody] Usuario user)
        { 
            if(user == null)
            {
                return BadRequest("Usuário nulo");
            }
            usuarios.Add(user);
            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetUsuarios()
        {
            alimentaLista();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuarioById(int id)
        {
            Usuario? user = usuarios.FirstOrDefault(user => user.Id == id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }
    }
}
