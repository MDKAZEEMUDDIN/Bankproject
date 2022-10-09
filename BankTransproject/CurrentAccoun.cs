using BankAcc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTransproject
{
    class CurrentAccount : ITransferAccount
    {
        private decimal balance;
        public void PayIn(decimal amount)
        {
            balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            Console.WriteLine("Withdraw Attempt Failed");
            return false;
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public bool TransferTo(IBankAccount destination, decimal amount)
        {
            bool result;
            if ((result = Withdraw(amount)) == true)
                destination.PayIn(amount);
            return result;
        }

        public override string ToString()
        {
            return string.Format("Investment Bank Current Account:Balance={0,6:c}", balance);
        }
    }

}
