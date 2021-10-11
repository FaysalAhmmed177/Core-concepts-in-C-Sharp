using System;
using System.Dynamic;

namespace DynamicTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dynamicVariable = 12;
            Console.WriteLine(dynamicVariable + "Type is : " + dynamicVariable.GetType());
            dynamicVariable = "Faysal";
            Console.WriteLine(dynamicVariable + "Type is : " + dynamicVariable.GetType());
            dynamicVariable = true;
            Console.WriteLine(dynamicVariable + "Type is : " + dynamicVariable.GetType());

            Print("12", 12);

            dynamicVariable = new ExpandoObject();
            dynamicVariable.Name = "Faysal";
            dynamicVariable.Address = "Shonir Akhra";
            dynamicVariable.GetInfo();

        }
        public static void Print(dynamic firstValue, dynamic secondValue)
        {
            Console.WriteLine(firstValue + "-" + secondValue);
        }
    }
}
