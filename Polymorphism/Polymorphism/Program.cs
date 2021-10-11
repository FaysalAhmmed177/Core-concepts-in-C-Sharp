using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sv1 = new SavingAccount();
            sv1.InterestAmount = 500;
            sv1.AccountNo = "SV-101";
            sv1.CustomerName = "Md Ismal";

            Console.WriteLine(sv1.Deposit(5000));
            Console.WriteLine(sv1.Widthdraw(4000));
            double balance = sv1.Balance;

            CheckingAccount chk1 = new CheckingAccount();
            chk1.ServiceCharge = 19000;
            chk1.AccountNo = "CH-1092";
            chk1.CustomerName = "Musa Bin";

            Console.WriteLine(chk1.Deposit(180000));
            Console.WriteLine(chk1.Widthdraw(20000000));

        }
    }
}
