using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_18
{
    internal class GoldState : IState
    {
        double interest;
        double lowerlimit;
        double upperlimit;

        public double Balance { get; set; }
        public Account account { get; set; }

        void Initialize()
        {
            interest = 0.07;
            lowerlimit = 1000.0;
            upperlimit = 10000000.0;
        }

        void StateChangeCheck()
        {
            if (Balance < 0.0)
            {
                account.state = new RedState(this);
            }
            else if (Balance > upperlimit)
            {
                account.state = new SilverState(this);
            }
        }

        public GoldState(double balance, Account account)
        {
            Balance = balance;
            this.account = account;
            Initialize();
        }

        public GoldState(IState state) : this(state.Balance, state.account) { }

        public void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public bool Withdraw(double amount)
        {
            Balance -= amount;
            StateChangeCheck();
            return true;
        }

        public bool PayInterest()
        {
            Balance += interest * Balance;
            StateChangeCheck();
            return true;
        }
    }
}
