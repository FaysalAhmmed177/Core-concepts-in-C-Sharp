using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany
{
    class Department
    {
        public Department()
        {
            Courses = new List<Course>();
        }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

    }
}
