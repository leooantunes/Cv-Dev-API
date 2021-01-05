using Domain.Models;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_cv.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienciaController : ControllerBase
    {
        private readonly IExperienciaService _experienciaService;
        public ExperienciaController(IExperienciaService experienciaService)
        {
            _experienciaService = experienciaService;
        }
        // GET: api/<ExperienciaController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_experienciaService.ObterTodos());
        }

        // GET api/<ExperienciaController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_experienciaService.ObterPorId(id));
        }

        // POST api/<ExperienciaController>
        [HttpPost]
        public IActionResult Post([FromBody] DtoExperiencia experiencia)
        {
            if (_experienciaService.Inserir(experiencia))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/<ExperienciaController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] DtoExperiencia experiencia)
        {
            if (_experienciaService.Atualizar(experiencia))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<ExperienciaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_experienciaService.Excluir(id))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
