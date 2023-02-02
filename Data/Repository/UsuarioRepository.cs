using usuario_net.Data.Context;
using usuario_net.Models;

namespace usuario_net.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioContext _context;

        public UsuarioRepository(UsuarioContext context)
        {
            _context = context;
        }

        public void AtualizaUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> BuscarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> BuscarUsuarios()
        {
            throw new NotImplementedException();
        }

        public void CriarUsuario(Usuario usuario)
        {
            _context.Add(usuario);
        }

        public void DeletarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}