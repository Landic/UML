using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_18
{
    internal class Account
    {
        public IState state { get; set; }
        string owner;

        public Account(string owner)
        {
            this.owner = owner;
        }

        public void Deposit(double amount)
        {
            state.Deposit(amount);
            Console.WriteLine("Deposited -> " + amount + "\nBalance -> " + state.Balance + "\nStatus -> " + state.GetType().Name);

        }

        public void Withdraw(double amount)
        {
            if (state.Withdraw(amount))
            {
                Console.WriteLine("Withdraw -> " + amount + "\nBalance -> " + state.Balance + "\nStatus -> " + state.GetType().Name);
            }
        }

        public void PayInterest()
        {
            if (state.PayInterest())
            {
                Console.WriteLine("Interest paid" + "\nBalance -> " + state.Balance + "\nStatus -> " + state.GetType().Name);
            }
        }
    }
}
