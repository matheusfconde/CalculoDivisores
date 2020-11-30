using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using CalculoDivisores.Domain.Services.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CalculoDivisores.Api.Controllers
{
    [Route("api/[controller]")]
    public class CalculoDivisoresController : Controller
    {

        // GET: api/CalculoDivisores/numero
        [HttpGet("{numero}")]
        public IActionResult Get(int numero)
        {
            Divisores _divisoresService = new Divisores();
            var divisores = _divisoresService.GetDivisores(numero);
            var primos = _divisoresService.GetDivisoresPrimos(divisores);
            var listDivisores = JsonSerializer.Serialize(divisores);
            var listPrimos = JsonSerializer.Serialize(primos);
            if (divisores.Count > 0)
                return Ok(new { Response = "OK", Divisores = listDivisores, Primos = listPrimos });
            return NotFound();
        }
    }
}
