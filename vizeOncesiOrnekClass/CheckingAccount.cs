using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizeOncesiOrnekClass
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountNumber, decimal initBalance) : base(accountNumber, initBalance)
        {
        }

        public override bool  Withdraw(decimal amount)
        {
            if (amount + 1.0m <= Balance)
            {
                return base .Withdraw(amount +1.0m );
            }
            Console.WriteLine("yetersiz bakiye");
            return false;
        }
    }
}
