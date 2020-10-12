using ContactAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactAPI.Data
{
    public class MockContactRepo : IPersonRepository
    {
        
        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<Person> SelectPersonbyId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Person> UpdatePerson(int id, Person newPerson)
        {
            throw new NotImplementedException();
        }
        public Task DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public async  Task CreatePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public async Task< bool> PersonExist(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<List<Person>>  GetPeople()
        {
            var people = new List<Person>
            {

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
            return Task.Run(() => people);
        }

    }
}
