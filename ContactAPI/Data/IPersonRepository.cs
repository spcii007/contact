using ContactAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactAPI.Data
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetPeople ();
        Task<Person> SelectPersonbyId(int id);
        Task<Person> UpdatePerson(int id, Person newPerson);
        bool SaveChanges();
        Task DeletePerson(int id);

        Task CreatePerson(Person person);

        Task<bool> PersonExist(Person person);
     
    }
}
