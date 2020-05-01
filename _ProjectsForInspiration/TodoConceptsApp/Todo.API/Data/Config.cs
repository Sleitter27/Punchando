using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.API.Data
{
    public class Config
    {
        public static List<string> Statues = new List<string>
        {
            "Pending",
            "In Progress",
            "Done",
            "Cancelled"
        };
    }

}
