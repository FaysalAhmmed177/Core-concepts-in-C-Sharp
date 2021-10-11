using Practise.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
   public interface IEmployeeService
    {
        List<Employee> GetEmployeeList();
        void CreateEmployee(Employee model);
    }
}
