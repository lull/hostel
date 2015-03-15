using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mvcHostel.Controllers
{
    public class roomController : ApiController
    {
        // GET api/room
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/room/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/room
        public void Post([FromBody]string value)
        {
        }

        // PUT api/room/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/room/5
        public void Delete(int id)
        {
        }
    }
}
