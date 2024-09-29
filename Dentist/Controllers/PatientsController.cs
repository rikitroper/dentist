using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dentist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private static new List<Patient> patients = new List<Patient> {
                new Patient { Id = "215112624", Name = "riki",DateBorn = new DateTime(),Age=19,Status=true},
                new Patient { Id = "332109933", Name = "michal", DateBorn = new DateTime(),Age=19,Status=true },
                new Patient { Id = "060169828", Name = "efrat", DateBorn = new DateTime(),Age=20,Status=true }
            };

        // GET: api/<PatientsController>
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
           return patients;
        }

        // GET api/<PatientsController>/5
        //[HttpGet("{id}")]
        //public  Patient Get(string id)
        //{
        //    var index= patients.FindIndex(e=> e.Id == id);
        //    return index;

        //}

        // POST api/<PatientsController>
        [HttpPost]
        public Patient Post([FromBody] Patient value)
        {
            patients.Add(value);
            return value;
        }

        // PUT api/<PatientsController>/5
        [HttpPut("{id}")]
        public Patient Put(string id, [FromBody] Patient value)
        {
            var index = patients.FindIndex(e => e.Id == id);
            patients[index].Id = value.Id;
            patients[index].Name = value.Name;
            patients[index].DateBorn = value.DateBorn;
            patients[index].Age = value.Age;
            return patients[index];
        }


      

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var index = patients.FindIndex(e => e.Id == id);
            patients[index].Status = false;
        }
    }
}
