using Domain.Models;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_cv.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly ISkillService _skillService;
        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        // GET: api/<SkillController>
        [HttpGet]
        public IActionResult Get() => Ok(_skillService.ObterTodos());

        // GET api/<SkillController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok(_skillService.ObterPorId(id));

        // POST api/<SkillController>
        [HttpPost]
        public IActionResult Post([FromBody] DtoSkill skill)
        {
            if (_skillService.Inserir(skill))
                return Ok();
            else
                return BadRequest();
        }

        // PUT api/<SkillController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] DtoSkill skill)
        {
            if (_skillService.Atualizar(skill))
                return Ok();
            else
                return BadRequest();
        }

        // DELETE api/<SkillController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_skillService.Excluir(id))
                return Ok();
            else
                return BadRequest();
        }
    }
}
