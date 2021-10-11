using System;
using System.Collections.Generic;

namespace OneToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.Code = "CSE-101";
            course1.Title = "Programming language 1";
            course1.Credit = 3.0;

            Course course2 = new Course();
            course2.Code = "CSE-102";
            course2.Title = "Data Structure";
            course2.Credit = 3.0;

            Course course3 = new Course();
            course3.Code = "CSE-103";
            course3.Title = "Computer Networks";
            course3.Credit = 3.0;

            Department department = new Department();
            department.Code = "CSE";
            department.Name = "Computer Science and Engineering";
            department.Courses = new List<Course>();
            department.Courses.Add(course1);
            department.Courses.Add(course2);
            department.Courses.Add(course3);

            foreach (Course course in department.Courses)
            {
                Console.WriteLine(course.Code);
            }
        }
    }
}
