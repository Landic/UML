using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_18
{
    internal class RedState : IState
    {
        double interest;
        double lowerlimit;
        double upperlimit;

        public double Balance { get; set; }
        public Account account { get; set; }

        void Initialize()
        {
            interest = 0.0;
            lowerlimit = -100;
            upperlimit = 0.0;
        }

        void StateChangeCheck()
        {
            if (Balance > upperlimit)
            {
                account.state = new SilverState(this);
            }
        }

        public RedState(IState state)
        {
            this.Balance = state.Balance;
            this.account = state.account;
            Initialize();
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public bool Withdraw(double amount)
        {
            Console.WriteLine("No funds available for withdrawal!");
            return false;
        }

        public bool PayInterest()
        {
            Console.WriteLine("No interest is paid!");
            return false;
        }
    }
}
