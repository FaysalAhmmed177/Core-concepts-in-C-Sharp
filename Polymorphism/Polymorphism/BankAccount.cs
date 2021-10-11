using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class BankAccount
    {
        public string AccountNo { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }


        public string Deposit(double balance)
        {
            Balance += balance;
            return "Deposited";
        }
        public virtual string Widthdraw(double amount)
        {

            Balance -= amount;
            return "Withdrawn";

            //if(Balance>=amount)
            //{
            //    Balance -= amount;
            //    return "Withdrawn";
            //}
            //return "Insufficient balance";

        }
    }
}
