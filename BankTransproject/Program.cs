using BankAcc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTransproject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IBankAccount Azar = new SaverAccount();

            ITransferAccount investacc = new CurrentAccount();
            Azar.PayIn(800);
            investacc.PayIn(500);
            investacc.TransferTo(Azar, 200);
            Console.WriteLine(Azar.ToString());
            Console.WriteLine(investacc.ToString());

            Console.ReadLine();


        }
    }
}
