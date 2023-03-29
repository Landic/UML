using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Handler bank = new BankPaymentHandler();
            Handler money = new MoneyPaymentHandler();
            Handler paypal = new PaypalPaymentHandler();

            bank.handler = paypal;
            bank.handler = money;


            Receiver rec = new Receiver(false, true, false);
            Request obj = new Request();
            obj.Req(bank, rec);
            Receiver rec2 = new Receiver(true, false, false);
            obj.Req(bank, rec2);
            Receiver rec3 = new Receiver(false, false, true);
            obj.Req(bank, rec3);
        }
    }
}
