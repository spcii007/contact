using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers {
    [Route ("api/contact")]
    [ApiController]
    public class ContactController : ControllerBase {
        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get () {

            var persons = new Person[] {
                new Person {

                Name = new Name {
                first = "Pablo",
                middle = "Andres",
                last = "Cifuentes",
                Id = 1,

                },
                Address = new Address {
                street = "123 Main St",
                city = "Bedford",
                state = "Virginia",
                zip = "24556",
                Id = 1

                },
                Phone = new Phone[] {
                new Phone { number = "555-555-5555", Id = 1, phoneType = phonetype.mobile },
                new Phone { number = "555-555-5544", Id = 2, phoneType = phonetype.work },
                new Phone { number = "555-444-4444", Id = 3, phoneType = phonetype.home }

                },
                Email = "spcii@hotmail.com"
                }

            };

            return Ok (persons);
        }

        [HttpPost]
        public IActionResult InsertPerson (Person person)
        {
            
            
            
            return StatusCode(201);

        }

    }
}