using System;
using ex2_DAL.Models;
using ex2_DAL.EF;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex2_DAL.Repository
{

    public class PersonRepository
    {
        private DalContext _context;

        public PersonRepository()
        {
            _context = new DalContext();
        }

        public int Add(Person person)
        {
            if ((person.LastName != string.Empty) && (person.FirstName != string.Empty))
            {

                person.Id = Guid.NewGuid();

                using (var context = new DalContext())
                {
                    context.Person.Add(person);
                    return context.SaveChanges();
                }
            }
            else return 0;

        }

        public IEnumerable<Person> GetByLastName(string filter)
        {
            return this._context.Person.Where(x => x.LastName.ToLower().Contains(filter.ToLower()));
        }

        public IEnumerable<Person> GetByFirstName(string filter)
        {
            return this._context.Person.Where(x => x.FirstName.ToLower().Contains(filter.ToLower()));
        }

        public Person Get(Guid id)
        {
            return this._context.Person.Where(x => x.Id == id).SingleOrDefault();
        }

        public int Update(Person person)
        {
            using (var context = new DalContext())
            {
                context.Person.Update(person);
                return context.SaveChanges();
            }
        }

        public int Delete(Person person)
        {
            using (var context = new DalContext())
            {
                context.Person.Remove(person);
                return context.SaveChanges();
            }
        }
    }

}