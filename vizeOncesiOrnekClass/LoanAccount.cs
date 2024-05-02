using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizeOncesiOrnekClass
{
    public class LoanAccount : BankAccount , ILoanAccount
    {
        public decimal InterestRate { get; set; }
        public LoanAccount(string accountNumber, decimal initBalance , decimal interestRate ) : base(accountNumber, initBalance)
        {
            InterestRate = initBalance;
        }
       public  void CalculateInterest()
        {
            var interest = Balance * InterestRate/100;
            Balance += interest;
            Console.WriteLine($"interest {interest} added to the loan. New balance is {Balance}");
        }

        public void MakePayment(decimal amount)
        {
            Withdraw(amount);
        }
    }
}
