using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OneUselessApp.Controllers
{
    public class StringController : ApiController
    {
        List<string> strings = new List<string>()
        {
            "value0","value1", "value2"
        };

        // GET: api/String
        public IEnumerable<string> Get()
        {
            return strings;
        }

        // GET: api/String/5
        public string Get(int id)
        {
            return strings[id];
        }

        // POST: api/String
        public void Post([FromBody]string value)
        {
            strings.Add(value);
        }

        // PUT: api/String/5
        public void Put(int id, [FromBody]string value)
        {
            strings[id] = value;
        }

        // DELETE: api/String/5
        public void Delete(int id)
        {
            strings.RemoveAt(id);
        }
    }
}
