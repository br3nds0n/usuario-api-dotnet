using usuario_net.Models;

namespace usuario_net.Services
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> BuscarUsuarios();
        Task<Usuario> BuscarUsuario(int id);
        void CriarUsuario(Usuario usuario);
        void AtualizaUsuario(Usuario usuario);
        void DeletarUsuario(Usuario usuario);
    }
}