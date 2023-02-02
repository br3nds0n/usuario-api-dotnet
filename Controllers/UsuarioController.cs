using Microsoft.AspNetCore.Mvc;
using usuario_net.Data.Repository;
using usuario_net.Models;

namespace usuario_net.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioController(IUsuarioRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public IActionResult BuscarUsuarios()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CriarUsuario(Usuario usuario)
        {
            _repository.CriarUsuario(usuario);
            return await _repository.SaveChangesAsync() ? Ok(usuario) : BadRequest("Erro ao salvar usuário");
        }
    }
}