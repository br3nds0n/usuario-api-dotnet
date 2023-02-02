using usuario_net.Models;

namespace usuario_net.Data.Repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> BuscarUsuarios();
        Task<IEnumerable<Usuario>> BuscarUsuario(int id);
        void CriarUsuario(Usuario usuario);
        void AtualizaUsuario(Usuario usuario);
        void DeletarUsuario(Usuario usuario);

        Task<bool> SaveChangesAsync();
    }
}