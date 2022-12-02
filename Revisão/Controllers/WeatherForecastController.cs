using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Nova_pasta.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public Pessoa Post(Pessoa usuario)
        {
            usuario.nasc.AddYears(1);
            return usuario;

            /*
            [HttpGet]
            Pessoa p = new Pessoa();
            p.nome = "Jango";
            //p.nasc = DateTime.Now; //utiliza a data e o horário atual.
            p.nasc = new DateTime(1987,03,30);
            return p;
            */
            
        }
    }
}
