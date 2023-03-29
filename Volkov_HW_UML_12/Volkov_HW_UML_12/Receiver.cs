using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_12
{
    internal class Receiver
    {
        public bool BankTransfer { get; set; }
        public bool MoneyTransfer { get; set; }
        public bool PayPalTransfer { get; set; }

        public Receiver(bool bankTransfer, bool moneyTransfer, bool payPalTransfer)
        {
            BankTransfer = bankTransfer;
            MoneyTransfer = moneyTransfer;
            PayPalTransfer = payPalTransfer;
        }
    }


    internal abstract class Handler
    {
        public Handler handler { get; set; }

        public abstract void Handle(Receiver obj);
    }

    internal class BankPaymentHandler : Handler
    {
        public override void Handle(Receiver obj)
        {
            if (obj.BankTransfer)
            {
                Console.WriteLine("Bank transfer");
            }
            else if (handler != null)
            {
                handler.Handle(obj);
            }
        }
    }

    internal class MoneyPaymentHandler : Handler
    {
        public override void Handle(Receiver obj)
        {
            if (obj.MoneyTransfer)
            {
                Console.WriteLine("Transfer through money transfer systems");
            }
            else if (handler != null)
            {
                handler.Handle(obj);
            }
        }
    }


    internal class PaypalPaymentHandler : Handler
    {
        public override void Handle(Receiver obj)
        {
            if (obj.PayPalTransfer)
            {
                Console.WriteLine("Transfer via paypal");
            }
            else if (handler != null)
            {
                handler.Handle(obj);
            }
        }
    }

    internal class Request
    {
        public void Req(Handler obj1, Receiver obj2)
        {
                obj1.Handle(obj2);
        }
    }
}
