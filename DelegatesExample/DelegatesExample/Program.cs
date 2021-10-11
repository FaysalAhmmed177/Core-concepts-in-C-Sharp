using System;

namespace DelegatesExample
{
    class Program
    {
        public delegate int CalculatorHandler(int firstNumber, int secondNumber);
        static void Main(string[] args)
        {

            CalculatorHandler calculatorHandler = (int firstNumber, int secondNumber) =>
                                                  {
                                                      return firstNumber + secondNumber;
                                                  };
            InvokeDelegates(calculatorHandler, 12, 40);

            CalculatorHandler calculatorHandler1 = Sub;
            InvokeDelegates(calculatorHandler1, 12, 40);
            //int result = calculatorHandler.Invoke(12, 40);
            //Console.WriteLine(result);
        }
        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        static int Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public static void InvokeDelegates(CalculatorHandler calculatorHandler, int fNumber, int sNumber)
        {
            int result = calculatorHandler.Invoke(fNumber, sNumber);
            Console.WriteLine("Result is"+result);
        }
        
    }
}
