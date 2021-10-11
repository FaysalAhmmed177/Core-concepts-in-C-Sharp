using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Manager;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentsController : Controller
    {

        public ActionResult SaveStudent()
        {
            StudentManager studentManager = new StudentManager();
            ViewBag.Department = studentManager.GetDepartments();
            ViewBag.Students = studentManager.GetStudents();
            //iewBag.Department = GetDepartments();
            return View();
        }

        [HttpPost]
        public ActionResult SaveStudent(Student student)
        {
            string msg = "";
            StudentManager studentManager = new StudentManager();
            if (ModelState.IsValid)
            {
                SqlConnection con = new SqlConnection("Data Source = DESKTOP-K086K2N;Initial Catalog=Faysal;Integrated Security = true;");
                con.Open();
                string query = "INSERT INTO Student_tb(StudentName, RegNo, Email, Address, DepartmentId) VALUES('" + student.StudentName + "', '" + student.RegNo + "', '" + student.Address + "', '" + student.Email + "', '" + student.DepartmentName + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    msg = "Save Data Successfully";
                }
                else
                {
                    msg = "Save Failed";
                }
            }

            ViewBag.Department = studentManager.GetDepartments();
            ViewBag.Students = studentManager.GetStudents();
            ViewBag.Message = msg;
            return View();
        }

        public ActionResult Index()
        {

            Student student = new Student();
            student.StudentName = "Faysal";
            student.RegNo = "32435";
            student.Email = "faysal@gmail.com";
            student.Address = "Chandpur";
            student.DepartmentName = "CSE";
            ViewBag.Student = student;
            return View();
        }

        public ActionResult GetAll()
        {
            //ViewBag.Students = Students();
            return View(Students());
        }

        //public List<string> GetDepartments()
        //{
        //    return new List<string>(){ "CSE", "EEE", "ENG"};
        //}
        public List<Student> Students()
        {
            return new List<Student>
            {
                new Student{StudentName="Faysal", RegNo="r424dg", Email="faysal@gmail.com", Address="Dhaka", DepartmentName="CSE"},
                new Student{StudentName="Jisan", RegNo="dgfdh", Email="jisan@gmail.com", Address="Chandpur", DepartmentName="CSE"}
            };
        }
    }
}
