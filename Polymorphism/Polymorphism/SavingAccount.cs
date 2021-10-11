using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class SavingAccount: BankAccount
    {
        public double InterestAmount { get; set; }

        public override string Widthdraw(double amount)
        {
           if(Balance >= amount)
            {
                return base.Widthdraw(amount);
            }
            return "Insufficient balance";
        }
    }
}
