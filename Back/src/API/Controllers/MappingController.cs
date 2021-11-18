using API.Data;
using API.DTOs;
using API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MappingController : ControllerBase
    {
        private readonly IMapper _mapper;

        public MappingController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post(Evento evento)
        {
            var eventoDto = _mapper.Map<EventoDTO>(evento);
            return Ok(eventoDto);

        }


    }

}
