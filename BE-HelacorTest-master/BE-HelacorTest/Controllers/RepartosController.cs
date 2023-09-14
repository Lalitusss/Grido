using AutoMapper;
using BE_HelacorTest.Models;
using BE_HelacorTest.Models.dto;
using BE_HelacorTest.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BE_HelacorTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepartosController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRepartoRepository _repartoRepository;

        public RepartosController(IMapper mapper,IRepartoRepository repartoRepository)
        {
            _mapper = mapper; 
            _repartoRepository = repartoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            try 
            {
                var listRepartos = _repartoRepository.GetListRepartos();  
                var listRepartosDto = _mapper.Map<IEnumerable<RepartoDto>>(listRepartos.Result);
                return Ok(listRepartosDto);
            } 
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var reparto = _repartoRepository.GetReparto(id);
                if (reparto == null)
                {
                    return NotFound();
                }
                var repartoDto = _mapper.Map<RepartoDto>(reparto.Result);
                return Ok(repartoDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
