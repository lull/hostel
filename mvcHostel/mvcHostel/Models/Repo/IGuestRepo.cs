using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcHostel.Models
{
    interface IGuestRepo
    {
        IEnumerable<guest> GetAll();
        guest Get(int id);
        room Add(guest item);
        void Remove(int id);
        bool Update(guest item);
    }
}
