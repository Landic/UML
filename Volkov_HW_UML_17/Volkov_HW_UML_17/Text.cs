using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Volkov_HW_UML_17
{
    internal class Text
    {
        private string text;
        private CareTaker obj;

        public Text()
        {
            text= string.Empty;
            obj = new CareTaker();
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public Memento Save()
        {
            return new Memento(text);
        }

        public void Undo(Memento mem)
        {
            if(mem != null)
            {
                text = mem.GetText();
            }
        }

        public void Redo(Memento mem)
        {
            if (mem != null)
            {
                text = mem.GetText();
            }
        }

        public override string ToString()
        {
            return text;
        }
    }

    internal class Memento
    {
        private string text;

        public Memento(string text)
        {
            this.text = text;
        }

        public string GetText()
        {
            return text;
        }
    }


    internal class CareTaker
    {
        private List<Memento> list;
        private int maxsize;

        public CareTaker()
        {
            list = new List<Memento>();
            maxsize = 256;
        }

        public void AddMomento(Memento memento)
        {
            if(list.Count == maxsize)
            {
                list.RemoveAt(0);
            }
            list.Add(memento);
        }

        public void History()
        {
            foreach(var i in list)
            {
                Console.WriteLine(i.GetText());
            }
        }

        public Memento Undo()
        {
            if (list.Count > 0)
            {
                Memento mem = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return mem;
            }
            return null;
        }

        public Memento Redo()
        {
            if (list.Count > 0)
            {
                Memento mem = list[list.Count - 1];

                return mem;
            }
            return null;
        }

        public int Count()
        {
            return list.Count;
        }


        public void RemoveMomento(int index)
        {
            list.RemoveAt(index);
        }


        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public Memento GetMemento(int index)
        {
            return list[index];
        }
    }
}
