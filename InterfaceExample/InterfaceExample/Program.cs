using System;
using System.Collections.Generic;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.RegNo = "23232";
            string info = student.GetBasicInformation();

            Department department = new Department();
            department.Code = "CSE";
            string deptInfo = department.GetBasicInformation();

            Course course = new Course();
            string courseInfo = course.GetBasicInformation();

            IInformation information = student;
            information = department;

            IPrinter printer = student;

            List<IInformation>informations = new List<IInformation>();
            informations.Add(student);
            informations.Add(department);
            informations.Add(course);
        }
    }
}
