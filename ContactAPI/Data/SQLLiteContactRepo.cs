using ContactAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactAPI.Data
{
    public class SQLLiteContactRepo : IPersonRepository
    {
        private readonly DataContext _data;

        public SQLLiteContactRepo(DataContext data)
        {
            _data = data;
        }
        
        public async Task CreatePerson(Person person)
        {
            if(person == null)
            {
                throw new ArgumentNullException();
            }

            await _data.AddAsync(person);
        }

        public async Task DeletePerson(int id)
        {
            var person = await _data.Person.FirstOrDefaultAsync(p => p.Id == id);
            if (person != null)
            {
                _data.Person.Remove(person);
            }
        }

        public Task<List<Person>> GetPeople()
        {
            
            var people = _data.Person
                    .Include(ad => ad.Address)
                    .Include(ad => ad.Name)
                    .Include(ad => ad.Phone)
                    .ToListAsync();

            return people;
        }

        public async Task <bool> PersonExist(Person person)
        {
            var result =  await _data.Person.AnyAsync(p => p.Email == person.Email);

            return result;
        }

        public bool SaveChanges()
        {
           return (_data.SaveChanges() > 0);
        }

        public async Task<Person> SelectPersonbyId(int id)
        {
            var person = await _data.Person
                        .Include(p => p.Address)
                        .Include(p => p.Name)
                        .Include(p => p.Phone)
                        .FirstOrDefaultAsync(p => p.Id == id);


            if (person == null)
                return null;
            
            return person;

        }

        public Task<Person> UpdatePerson(int id, Person newPerson)
        {
            throw new NotImplementedException();
        }

      
    }
}
