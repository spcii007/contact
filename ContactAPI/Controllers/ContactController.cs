using ContactAPI.Data;
using ContactAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Controllers
{
    [Route ("api/contact")]
    [ApiController]
    public class ContactController : ControllerBase {
        private readonly IPersonRepository _db;

        public ContactController(IPersonRepository db)
        {
            _db = db;
        }
        
        
        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get () {

            var persons = _db.GetPeople();

            return Ok(persons);
        }

        [HttpGet ("{id}")]
        public ActionResult<Person> Get(int id)
        {
            var person = _db.SelectPersonbyId(id);

            return Ok(person);
        }

        [HttpPost]
        public IActionResult InsertPerson (Person person)
        {
            
            if (person == null)
                return StatusCode(400, "Bad argument exception");
            if (_db.PersonExist(person)
                return StatusCode(401, "Person already exit."); 

            _db.CreatePerson(person);
            if (_db.SaveChanges())
                return CreatedAtRoute(nameof(InsertPerson), new { id = person.Id, person });
            else
                return StatusCode(400, "Bad argument exception");
        }

    }
}