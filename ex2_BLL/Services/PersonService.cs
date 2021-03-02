using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ex2_DAL.Models;
using ex2_DAL.Repository;

namespace ex2_BLL.Services
{
    public class PersonService
    {

        private PersonRepository _personRepository;
        
        public PersonService()
        {
            _personRepository = new PersonRepository();
        }

        public IEnumerable<Person> GetByFirstName(string filter)
        {
            return _personRepository.GetByFirstName(filter);
        }

        public IEnumerable<Person> GetByLastName(string filter)
        {
            return _personRepository.GetByLastName(filter);
        }

        public Person Get(Guid id)
        {
            return _personRepository.Get(id);
        }

        public int Add(Person person)
        {
            return _personRepository.Add(person);
        }

        public int Update(Person person)
        {
            return _personRepository.Update(person);
        }

        public int Delete(Guid id)
        {
            Person p = new Person();
            p.Id = id;
            return _personRepository.Delete(p);
        }
    }
}
