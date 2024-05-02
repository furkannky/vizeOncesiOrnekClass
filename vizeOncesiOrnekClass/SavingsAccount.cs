using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizeOncesiOrnekClass
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate {  get; set; }
        public SavingsAccount(string AccountNumber, decimal initBalance, decimal interestRate) : base(AccountNumber,initBalance)
        {
            //  this.interestRate = interestRate;
            InterestRate = initBalance;
        }

        public void ApplyInterest()
        {
            var interest = Balance * InterestRate / 100;
            Depozit(interest);
        }
    }
     
    
}
