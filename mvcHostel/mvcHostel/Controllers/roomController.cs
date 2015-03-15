﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using mvcHostel.Models;

namespace mvcHostel.Controllers
{
    public class RoomController : ApiController
    {
        hostelEntities context = new hostelEntities();

        // GET api/room
        public int Get() //IEnumerable<room>
        {
            return context.rooms.ToList().FirstOrDefault().idroom;
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
