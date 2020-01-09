using OneUselessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OneUselessApp.Controllers
{
    public class PersonController : ApiController
    {
        List<Person> people = new List<Person>();

        public PersonController()
        {
            people.Add(new Person { FirstName = "julius", LastName = "ngwu", Id = 1 });
            people.Add(new Person { FirstName = "mike", LastName = "kesh", Id = 2 });
            people.Add(new Person { FirstName = "peter", LastName = "joe", Id = 3 });
        }
        // GET: api/Person
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/Person/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        [Route("api/People/GetFirstNames")]
        [HttpGet]
        public List<string> GetFirstNames()
        {
            List<string> output = new List<string>();

            foreach(var p in people)
            {
                output.Add(p.FirstName);
            }

            return output;
        }

        // POST: api/Person
        public void Post(Person personValue)
        {
            people.Add(personValue);
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
