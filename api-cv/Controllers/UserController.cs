using Domain.Models;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_cv.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: api/User
        [HttpGet]
        public IActionResult Get() => Ok(_userService.ObterTodos());

        // GET api/User/{id}
        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok(_userService.ObterPorId(id));

        // POST api/User
        [HttpPost]
        public IActionResult Post([FromBody] DtoUser user)
        {
            if (_userService.Inserir(user))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] DtoUser user)
        {
            if (_userService.Atualizar(user))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_userService.Excluir(id))
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
