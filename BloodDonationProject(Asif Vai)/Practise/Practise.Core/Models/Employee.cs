using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise.Core.Models
{
    public partial class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
