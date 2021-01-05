using Domain.Models;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_cv.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedeSocialController : ControllerBase
    {
        private readonly IRedeSocialService _redeSocialService;
        public RedeSocialController(IRedeSocialService redeSocialService)
        {
            _redeSocialService = redeSocialService;
        }
        // GET: api/<RedeSocialController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_redeSocialService.ObterTodos());
        }

        // GET api/<RedeSocialController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_redeSocialService.ObterPorId(id));
        }

        // POST api/<RedeSocialController>
        [HttpPost]
        public IActionResult Post([FromBody] DtoRedeSocial redeSocial)
        {
            if (_redeSocialService.Inserir(redeSocial))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/<RedeSocialController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] DtoRedeSocial redeSocial)
        {
            if (_redeSocialService.Atualizar(redeSocial))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<RedeSocialController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_redeSocialService.Excluir(id))
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
