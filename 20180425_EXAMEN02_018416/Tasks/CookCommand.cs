using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_EXAMEN02_018416.Tasks
{
    class CookCommand : ICommand
    {
        List<Robot> robots;

        public CookCommand(List<Robot> robots)
        {
            this.robots = robots;
        }
        public void execute(Robot robot)
        {
            robot.Cook();
        }
        
    }
}
