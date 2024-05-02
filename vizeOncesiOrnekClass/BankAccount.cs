using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizeOncesiOrnekClass
{
       public abstract class BankAccount : IAccount  // soyut class
    {
        private decimal initBalance;

        string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        protected BankAccount(string accountNumber, decimal initBalance)
        {
            AccountNumber = accountNumber;
            this.initBalance = initBalance;
        }

        public void Depozit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"depozit : {amount} added new balance is {Balance}.");
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Account {AccountNumber} : Balance is {Balance}");
        }

        public virtual bool Withdraw(decimal amount)
            
        {
            if (amount < Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw: {amount} deducted . New balance is {Balance}");
                return true;
            }
            Console.WriteLine("insufficient funds");
            return false;
        }
    }
}


