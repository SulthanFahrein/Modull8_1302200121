using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modull8_1302200121.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static List<string> Stars1 = new List<string>
        {
            "Tia Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler"
        }
        private static List<string> Stars2 = new List<string>
        {
            "Marlon Brando", "Al Pacino", "James Can", "Diane keaton"
        }
        private static List<string> Stars3 = new List<string>
        {
            "Christian Bale", "Heath Ledger", "Aaronm Eckhart", "Michael Caine"
        }
        private readonly ILogger<MoviesController> _logger;
        List<movies> movie2 = new List<movies>();
        public mov
        // GET: api/<MoviesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/<MoviesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
