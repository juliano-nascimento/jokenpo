using Jokenpo.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Jokenpo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JogarController : ControllerBase
    {
        private readonly IJogarService _jogarService;

        public JogarController(IJogarService jogarService)
        {
            _jogarService=jogarService;
        }

        /// <summary>
        /// Insira sua escolha.
        /// 1 - Tesoura
        /// 2 - Pedra
        /// 3 - Papel
        /// </summary>
        /// <param name="escolha"></param>
        /// <returns></returns>
        [HttpGet("{escolha}")]        
        public IActionResult Get(int escolha){

            if(escolha == 0)
                return BadRequest("Escolha uma opção válida. 1- Tesoura, 2 - Pedra, 3 - Papel");
            
            var result = _jogarService.NovoJogo(escolha);

            return Ok(result);

        }
    }
}