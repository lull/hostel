using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcHostel.Models
{
    interface IRoomRepo
    {
        IEnumerable<room> GetAll();
        room Get(int id);
        room Add(room item);
        void Remove(int id);
        bool Update(room item);
    }
}
