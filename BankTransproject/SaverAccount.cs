using BankAcc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTransproject
{
    public class SaverAccount : IBankAccount
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
            Console.WriteLine("Withraw Attempt Failed");
            return false;
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public override string ToString()
        {
            return string.Format("L Bank Saver: Balance={0,6:c}", balance);
        }
    }
}

