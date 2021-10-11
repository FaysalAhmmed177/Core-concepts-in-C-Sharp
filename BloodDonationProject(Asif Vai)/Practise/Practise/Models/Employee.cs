using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practise.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email  { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
