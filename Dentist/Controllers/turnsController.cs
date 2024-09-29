using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dentist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class turnsController : ControllerBase
    {
        private static new List<turn> turns = new List<turn> {
                new turn { Code = 1, IdPatient = "323658036", IdDentist = "320658036" ,Date = new DateTime(),Hour = new DateTime()},
            };

        // GET: api/<turnsController>
        [HttpGet]
        public IEnumerable<turn> Get()
        {
            return turns;
        }

        // GET api/<turnsController>/5
        [HttpGet("{Code}")]
        public turn Get(string Code)
        {
            var index = turns.FindIndex(e => e.Code.Equals(Code));
            return turns[index];
        }

        // POST api/<turnsController>
        [HttpPost]
        public turn Post([FromBody] turn value)
        {
            turns.Add(value);
            return value;
        }

        // PUT api/<turnsController>/5
        [HttpPut("{Code}")]
        public turn Put(string Code, [FromBody] turn value)
        {
            var index = turns.FindIndex(e => e.Code.Equals(Code));
            turns[index] .IdPatient= value.IdPatient;
            turns[index].IdDentist = value.IdDentist;
            turns[index].Hour = value.Hour;
            turns[index].Date = value.Date;
            return turns[index];
        }

        // DELETE api/<turnsController>/5
        [HttpDelete("{Code}")]
        public void Delete(string Code)
        {
            var index = turns.FindIndex(e => e.Code.Equals(Code));
            turns.Remove(turns[index]);
        }
    }
}
