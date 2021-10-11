using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Gateway;
using WebApplication1.Models;

namespace WebApplication1.Manager
{
    public class StudentManager
    {
        StudentGateway studentGateway = new StudentGateway();

        public List<Student> GetStudents()
        {
            return studentGateway.GetStudents();
        }
        public List<Department> GetDepartments()
        {
            return studentGateway.departments();
        }
    }
}
