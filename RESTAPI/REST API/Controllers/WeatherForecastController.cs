using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contract_Test.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace REST_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase, IAccount 
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

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        public long getBalance()
        {
            throw new NotImplementedException();
        }

        public IBank GetBank()
        {
            throw new NotImplementedException();
        }

        public ICustomer getCustomer()
        {
            throw new NotImplementedException();
        }

        public List<IMovement> getMovements(IAccount withdraw)
        {
            throw new NotImplementedException();
        }

        public string getNumber()
        {
            throw new NotImplementedException();
        }

        public void transfer(long amount, IAccount target)
        {
            throw new NotImplementedException();
        }

        public void transfer(long amount, string targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
