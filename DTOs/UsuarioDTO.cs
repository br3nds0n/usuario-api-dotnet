namespace usuario_net.DTOs
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }

        public UsuarioDTO(string nome, string email, string senha, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            DataNascimento = dataNascimento;
        }
    }
}