using System;

namespace MulticastDelegatesExample
{
    class Program
    {
        public delegate void PrintHandler(string name);
        static void Main(string[] args)
        {
            PrintHandler printHandler = Hello;
            PrintHandler printHandler1 = GoodBye;
            PrintHandler printHandler2 = printHandler + printHandler1;
            printHandler2.Invoke("Faysal Ahmmed");
            Console.WriteLine("------");
            printHandler2 -= printHandler1;
            printHandler2.Invoke("Faysal Ahmmed");
            
        }   
        static void Hello(string name)
        {
            Console.WriteLine("Hello "+name);
        }
        static void GoodBye(string name)
        {
            Console.WriteLine("Goodbye "+name);
        }
    }
}
