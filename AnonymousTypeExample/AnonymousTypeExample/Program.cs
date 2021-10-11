using System;
using System.Linq;

namespace AnonymousTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new
            {
                Id = 1,
                Name = "Faysal",
                RegNo = "130",
                Address = "Dhaka",
                Email = "faysalahmmed177@gmail.com"
            };
            Console.WriteLine(student.Name);
            Console.WriteLine(student.GetType());


            var studentList = new[]
            {
                new { Id=1, Name="Faysal", RegNo="120", Email="" },
                new { Id=2, Name="Abullah", RegNo="121", Email=""},
                new { Id=3, Name="Kamal", RegNo="122", Email="" },
                new { Id=4, Name="AKmal", RegNo="123", Email="" }
            };

            var searchList = studentList.Where(c => c.Name.StartsWith('A')).ToList();
            var student2 = studentList.FirstOrDefault(c => c.Id == 2);

            foreach (var student1 in studentList)
            {
                Console.WriteLine(student1.Name);
            }

        }
    }
}
