using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mvcHostel.Controllers
{
    public class guestController : ApiController
    {
        // GET api/guest
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/guest/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/guest
        public void Post([FromBody]string value)
        {
        }

        // PUT api/guest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/guest/5
        public void Delete(int id)
        {
        }
    }
}
