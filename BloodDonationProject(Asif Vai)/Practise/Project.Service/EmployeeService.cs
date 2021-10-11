using Practise.Core.Models;
using Practise.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> repository;

        public EmployeeService(IRepository<Employee> repository)
        {
            this.repository = repository;
        }

        public void CreateEmployee(Employee model)
        {
            repository.Insert(model);
        }

        public List<Employee> GetEmployeeList()
        {
            var emplist = repository.GetAll();
            return emplist;
        }
    }
}
