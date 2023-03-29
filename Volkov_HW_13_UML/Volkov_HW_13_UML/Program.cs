using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Volkov_HW_13_UML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Microwave microwave = new Microwave();
            ICommand cmd = new MicrowaveCommand(microwave, 1000);
            Controller control = new Controller();
            control.cmd = cmd;
            control.PressButton();

            TV tv = new TV();
            cmd = new TVOnCommand(tv);
            control.cmd = cmd;
            control.PressButton();
            Thread.Sleep(1000);
            control.PressUndo();

            Notebook note = new Notebook();
            cmd = new NotebookCommand(note);
            control.cmd = cmd;
            control.PressButton();
            Thread.Sleep(1000);
            control.PressUndo();
        }
    }
}
