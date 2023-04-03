using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Bank");
            account.state = new SilverState(0.0,account);
            account.Deposit(500);
            Console.WriteLine("----------");
            account.Deposit(300);
            Console.WriteLine("----------");
            account.PayInterest();
            Console.WriteLine("----------");
            account.Withdraw(500);
            Console.WriteLine("----------");
            account.Withdraw(400);
            Console.WriteLine("----------");
            account.Deposit(1000);
            Console.WriteLine("----------");
            account.Deposit(100000);
            Console.WriteLine("----------");
            account.PayInterest();

        }
    }
}
