using System;

namespace InheritenceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sv1 = new SavingAccount();
            sv1.InterestAmount = 500;
            sv1.AccountNo = "SV-001";
            sv1.CustomerName = "Md Rashed";
            sv1.Deposit(1000);
            sv1.Withdraw(500);
            double balance = sv1.Balance;

            CheckingAccount chk1 = new CheckingAccount();
            chk1.ServiceCharge = 1000;
            chk1.AccountNo = "CH-001";
            chk1.CustomerName = "Noman";
            chk1.Deposit(2000);
            chk1.Withdraw(300);
            balance = chk1.Balance;

            BankAccount b1 = new BankAccount();

            BankAccount b2 = sv1;

            //SavingAccount sb2 = (SavingAccount)b1;
            double interestAmount = sb2.InterestAmount;
            BankAccount b3 = new CheckingAccount();
            
        }
    }
}
