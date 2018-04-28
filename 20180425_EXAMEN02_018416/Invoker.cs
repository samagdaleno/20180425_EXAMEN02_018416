using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_EXAMEN02_018416
{
    class Invoker
    {
        ICommand[] commands;

        public Invoker()
        {
            this.commands = new ICommand[8];
        }
        public void setCommand(ICommand command, int index)
        {
            this.commands[index] = command;
        }

        public void pressButton(int index, Robot robot)
        {
            commands[index].execute(robot);
        }
        
    }
}
