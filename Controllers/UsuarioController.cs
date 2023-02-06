using Microsoft.AspNetCore.Mvc;
using usuario_net.Data.Repository;
using usuario_net.Models;
using usuario_net.Services;

namespace usuario_net.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;
        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioRepository repository, IUsuarioService service)
        {
            _repository = repository;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> BuscarUsuarios()
        {
            var usuarios = await _service.BuscarUsuarios();
            return usuarios.Any() ? Ok(usuarios) : NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> CriarUsuario(Usuario usuario)
        {
            _repository.CriarUsuario(usuario);
            return await _repository.SaveChangesAsync() ? Ok(usuario) : BadRequest("Erro ao salvar usuário");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarUsuario(int id)
        {
            var usuario = await _service.BuscarUsuario(id);
            return usuario == null ? NotFound("Usuario não encontrado") : Ok(usuario);
        }
    }
}