using System;

namespace EnumExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)OrderStatus.OrderPlace);
            Console.WriteLine((int)OrderStatus.OrderConfirmed);
            Console.WriteLine((int)OrderStatus.Packaging);
            Console.WriteLine((int)OrderStatus.Deliviring);
            Console.WriteLine((int)OrderStatus.Received);

            int productOrderInfo = 1;

            if(productOrderInfo == (int)OrderStatus.OrderPlace)
            {

            }
            else if(productOrderInfo == (int)OrderStatus.OrderConfirmed)
            {

            }
        }
    }
}
