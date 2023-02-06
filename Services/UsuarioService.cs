using usuario_net.Data.Repository;
using usuario_net.Models;

namespace usuario_net.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public void AtualizaUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> BuscarUsuario(int id)
        {
            return await _repository.BuscarUsuario(id);
        }

        public async Task<IEnumerable<Usuario>> BuscarUsuarios()
        {
            return await _repository.BuscarUsuarios();
        }

        public void CriarUsuario(Usuario usuario)
        {
            _repository.CriarUsuario(usuario);
        }

        public void DeletarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}