using Microsoft.EntityFrameworkCore;
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

        public async Task<Usuario> BuscarUsuario(int id)
        {
            return await _context.Usuarios.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Usuario>> BuscarUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
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