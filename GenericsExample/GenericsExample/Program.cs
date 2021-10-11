using System;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student<int, string> student = new Student<int, string>();
            student.Name = "Faysal";
            student.Success = 1;

            var student1 = new Student<string, int>() { Name = "Asif", Roll = "1", Success = "Pass" , Status=1};
            var student2 = new Student<bool, string>() { Name = "Bappy", Success = true };

            Console.WriteLine(student.Success);
            Console.WriteLine(student1.Success);
            Console.WriteLine(student2.Success);

            Print(student);
            Print(student1);
        }
        public static void Print<T, U>(Student<T, U> student)
        {
            Console.WriteLine("Name: " + student.Name+" " + "Result: " + student.Success);
        }
    }
    public class Student<T, U>
    {
        public string Name { get; set; }
        public T Roll { get; set; }
        public T Success { get; set; }
        public U Status { get; set; }
    }
}
