using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany
{
    class Course
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public double Credit { get; set; }

        public string GetInfo()
        {
            return "Course Code : " + Code + "Title" + Title + "Credit : " + Credit;
        }

        public int GetResult()
        {
            int mid = 20;
            int final = 40;
            Calculator calculator = new Calculator();

            int result = calculator.Add(mid, final);
            return result;
        }
    }
}
