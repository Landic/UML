using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_18
{
    internal interface IState
    {
        void Deposit(double amount);
        bool Withdraw(double amount);
        bool PayInterest();

        double Balance { get; set; }

        Account account { get; set; }
    }
}
