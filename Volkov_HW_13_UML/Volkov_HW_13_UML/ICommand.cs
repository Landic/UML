using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Volkov_HW_13_UML
{
    internal interface ICommand
    {
        void Excute();
        void Undo();
    }


    internal class Notebook
    {
        public void On()
        {
            Console.WriteLine("Notebook ON");
        }

        public void Off()
        {
            Console.WriteLine("Notebook OFF");
        }
    }

    internal class TV
    {
        public void On()
        {
            Console.WriteLine("TV ON");
        }

        public void Off()
        {
            Console.WriteLine("TV OFF");
        }
    }

    internal class Microwave
    {
        public void Start(int time)
        {
            Console.WriteLine("Warming up food");
            Thread.Sleep(time);
        }

        public void Stop()
        {
            Console.WriteLine("The food is warmed up");
        }
    }


    internal class TVOnCommand : ICommand
    {
        TV tv;

        public TVOnCommand(TV tv)
        {
            this.tv = tv;
        }

        public void Excute()
        {
            tv.On();
        }

        public void Undo()
        {
            tv.Off();
        }
    }


    internal class MicrowaveCommand : ICommand
    {
        Microwave microwave;
        int time;

        public MicrowaveCommand(Microwave microwave, int time)
        {
            this.microwave = microwave;
            this.time = time;
        }

        public void Excute()
        {
            microwave.Start(time);
            microwave.Stop();
        }

        public void Undo()
        {
            microwave.Stop();
        }
    }

    internal class NotebookCommand : ICommand
    {
        Notebook note;
        int time;

        public NotebookCommand(Notebook note)
        {
            this.note = note;
        }

        public void Excute()
        {
            note.On();
        }

        public void Undo()
        {
            note.Off();
        }
    }


    internal class Controller
    {
        public ICommand cmd { get; set; }

        public void PressButton()
        {
            if (cmd != null)
            {
                cmd.Excute();
            }
        }

        public void PressUndo()
        {
            if (cmd != null)
            {
                cmd.Undo();
            }
        }
    }
}
