using Domain.Models;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_cv.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoSkillController : ControllerBase
    {
        private readonly ITipoSkillService _tipoSkillService;
        public TipoSkillController(ITipoSkillService tipoSkillService)
        {
            _tipoSkillService = tipoSkillService;
        }
        // GET: api/<TipoSkillController>
        [HttpGet]
        public IActionResult Get() => Ok(_tipoSkillService.ObterTodos());

        // GET api/<TipoSkillController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok(_tipoSkillService.ObterPorId(id));

        // POST api/<TipoSkillController>
        [HttpPost]
        public IActionResult Post([FromBody] DtoTipoSkill tipoSkill)
        {
            if (_tipoSkillService.Inserir(tipoSkill))
                return Ok();
            else
                return BadRequest();
        }

        // PUT api/<TipoSkillController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] DtoTipoSkill tipoSkill)
        {
            if (_tipoSkillService.Atualizar(tipoSkill))
                return Ok();
            else
                return BadRequest();
        }

        // DELETE api/<TipoSkillController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_tipoSkillService.Excluir(id))
                return Ok();
            else
                return BadRequest();
        }
    }
}
