using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Volkov_HW_UML_18
{
    internal class SilverState : IState
    {
        double interest;
        double lowerlimit;
        double upperlimit;

        public double Balance { get; set; }
        public Account account { get; set; }

        void Initialize()
        {
            interest = 0.01;
            lowerlimit = 0.0;
            upperlimit = 1000.0;
        }

        void StateChangeCheck()
        {
            if(Balance < lowerlimit)
            {
                account.state = new RedState(this);
            }
            else if (Balance > upperlimit)
            {
                account.state = new GoldState(this);
            }
        }

        public SilverState(double balance, Account account)
        {
            Balance = balance;
            this.account = account;
            Initialize();
        }

        public SilverState(IState state) : this(state.Balance, state.account) { }

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
