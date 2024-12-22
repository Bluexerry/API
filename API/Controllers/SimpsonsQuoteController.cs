using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("quotes")]
    public class SimpsonsQuoteController : ControllerBase
    {
        private readonly ISimpsonsQuoteService _simpsonsQuoteService;

        public SimpsonsQuoteController(ISimpsonsQuoteService simpsonsQuoteService)
        {
            _simpsonsQuoteService = simpsonsQuoteService;
        }

        /// <summary>
        /// Obtiene una frase aleatoria de cada personaje con su imagen.
        /// Ejemplo: GET /quotes
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetRandomQuotes()
        {
            var quotes = await _simpsonsQuoteService.GetRandomQuotesAsync();
            return Ok(quotes);
        }

        /// <summary>
        /// Busca frases por personaje.
        /// Ejemplo: GET /quotes?character=bart
        /// </summary>
        [HttpGet("search")]
        public async Task<IActionResult> GetQuotesByCharacter([FromQuery] string character)
        {
            if (string.IsNullOrWhiteSpace(character))
            {
                return BadRequest("El parámetro 'character' es obligatorio.");
            }

            var quotes = await _simpsonsQuoteService.GetRandomQuotesAsync(null, character);
            return Ok(quotes);
        }

        /// <summary>
        /// Obtiene un número específico de frases aleatorias.
        /// Ejemplo: GET /quotes/count?number=2
        /// </summary>
        [HttpGet("count")]
        public async Task<IActionResult> GetQuotesByCount([FromQuery] int count)
        {
            if (count <= 0)
            {
                return BadRequest("El parámetro 'count' debe ser mayor que 0.");
            }

            var quotes = await _simpsonsQuoteService.GetRandomQuotesAsync(count, null);
            return Ok(quotes);
        }
    }
}