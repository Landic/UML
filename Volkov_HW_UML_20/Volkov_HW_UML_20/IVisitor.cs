using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_20
{
    internal interface IVisitor
    {
        void VisitHouse(House house);
        void VisitFactory(Factory factory);

        void VisitBank(Bank bank);
    }

    internal interface IElement
    {
        void Accept(IVisitor visitor);
    }

    internal class House : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitHouse(this);
        }
    }

    internal class Factory : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitFactory(this);
        }
    }

    internal class Bank : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitBank(this);
        }
    }

    internal class Agent : IVisitor
    {
        public void VisitBank(Bank bank)
        {
            Console.WriteLine("Предложение оформить страховку от грабежа");
        }

        public void VisitFactory(Factory factory)
        {
            Console.WriteLine("Предложение оформить страховку предприятия от пожара и наводнения");
        }

        public void VisitHouse(House house)
        {
            Console.WriteLine("Предложение оформить медицинскую страховку");
        }
    }


    internal  class Client
    {
        public static void ClientCode(IElement element, IVisitor visitor)
        {
            element.Accept(visitor);
        }
    }
}
