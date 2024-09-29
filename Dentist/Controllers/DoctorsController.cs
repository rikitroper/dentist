using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dentist.Controllers
{
   
        [Route("api/[controller]")]
        [ApiController]
        public class doctorsController : ControllerBase
        {


            private static new List<doctors> d = new List<doctors> {
                new doctors { Id = "1", Name = "jon", Adress = "ashlosha" ,Specialization = "ortodent"},
                new doctors { Id = "2", Name = "dan", Adress = "ashomer",Specialization = "shinanit" }
            };
            // GET: api/<doctorsController>
            [HttpGet]

            public IEnumerable<doctors> Get()
            {
                return d;
            }


            // POST api/<doctorsController>
            [HttpPost]
            public doctors Post([FromBody] doctors value)
            {
                d.Add(value);
                return value;
            }


            // PUT api/<doctorsController>/5
            [HttpPut("{id}")]
            public doctors Put(string id, [FromBody] doctors value)
            {
                var index = d.FindIndex(e => e.Id == id);
                d[index].Name = value.Name;
                d[index].Adress = value.Adress;
                d[index].Specialization = value.Specialization;
                return d[index];
            }

            // DELETE api/<doctorsController>/5
            [HttpDelete("{id}")]
            public void Delete(string id)
            {
                var index = d.FindIndex(e => e.Id == id);
                d.Remove(d[index]);
            }
        }
}
