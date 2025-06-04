using SPA.Models;
using SPA.Models.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

namespace SPA.Controllers.Api
{
    public class PeopleController : ApiController
    {
        private readonly SPAContext _context;

        public PeopleController()
        {
            _context = new SPAContext();
        }

        [HttpGet]
        public IEnumerable<Person> GetPeople()
        {
            return _context.people.OrderBy(c => c.PersonName).ToList();
        }

        [HttpGet]
        public Person GetPerson(int id)
        {
            return _context.people.Find(id);
        }

        [HttpPost]
        public void AddNewPerson(Person person)
        {
            _context.people.Add(person);
            _context.SaveChanges();
        }

        [HttpPut]
        public void UpdatePerson(int id, Person person)
        {
            if (id == person.PersonID)
            {
                _context.Entry(person).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        [HttpDelete]
        public void DeletePerson(int id)
        {
            if (id != null)
            {
                Person person = GetPerson(id);
                _context.Entry(person).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

    }

}

