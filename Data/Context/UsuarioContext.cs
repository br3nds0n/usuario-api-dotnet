using Microsoft.EntityFrameworkCore;
using usuario_net.Models;

namespace usuario_net.Data.Context
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var usuario = modelBuilder.Entity<Usuario>();

            usuario.ToTable("tb_usuario");

            usuario.HasKey(x => x.Id);
            usuario.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            usuario.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            usuario.Property(x => x.Email).HasColumnName("email").IsRequired();
            usuario.Property(x => x.Senha).HasColumnName("senha").IsRequired();
            usuario.Property(x => x.DataNascimento).HasColumnName("data_nascimento").IsRequired();
        }
    }
}