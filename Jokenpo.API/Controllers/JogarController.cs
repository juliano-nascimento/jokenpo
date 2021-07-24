using System;
using Jokenpo.API.Entities;
using Jokenpo.API.Repositories.Interfaces;
using Jokenpo.API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jokenpo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JogarController : ControllerBase
    {
        private readonly IJogarService _jogarService;
        private readonly IJokenpoRepository<Ranking> _repository;

        public JogarController(IJogarService jogarService, IJokenpoRepository<Ranking> repository)
        {
            _jogarService = jogarService;
            _repository = repository;
        }

        [HttpGet("getHistorico")]
        public IActionResult Get(){

            try
            {
                var results = _repository.Lista();
                return Ok(results);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                ex.Message);
            }
        }
        
        [HttpGet("getRanking")]
        public IActionResult GetRanking(){

            try
            {
                var results = _repository.BuscarRanking();
                return Ok(results);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                ex.Message);
            }
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