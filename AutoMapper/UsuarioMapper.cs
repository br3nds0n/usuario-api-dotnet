using AutoMapper;
using usuario_net.DTOs;
using usuario_net.Models;

namespace usuario_net.AutoMapper
{
    public class UsuarioMapper : Profile
    {
        public UsuarioMapper()
        {
            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<UsuarioDTO, Usuario>();
        }
    }
}