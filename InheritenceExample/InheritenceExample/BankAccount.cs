using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceExample
{
    public class BankAccount
    {
        public string AccountNo { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }
        

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposit successfully";
        }
        public string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdrawn successfully";
        }
    }
}
