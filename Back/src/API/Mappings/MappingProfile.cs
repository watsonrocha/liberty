using API.DTOs;
using API.Models;
using AutoMapper;

namespace API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Evento, EventoDTO>()
            .ForMember(dest => dest.NomeCompleto, map =>
            map.MapFrom(src => $"{src.Nome} {src.Email}"))
            .ReverseMap();

        }


    }
}