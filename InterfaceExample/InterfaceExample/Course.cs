using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Course : IInformation
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Credit { get; set; }

        public string GetBasicInformation()
        {
            return "Code : " + Code + " Name : " + Name + " Credit : " + Credit;
        }
    }
}
