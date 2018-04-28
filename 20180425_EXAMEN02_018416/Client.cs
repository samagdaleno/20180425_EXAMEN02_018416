using _20180425_EXAMEN02_018416.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_EXAMEN02_018416
{
    class Client
    {
        Invoker invoker;
        RobotBig bigRob;
        RobotMedium medRob;
        RobotSmall lilRob;

        ICommand cookCommand;

        public Client()
        {
            this.invoker = new Invoker();
            this.bigRob = new RobotBig();
            this.medRob = new RobotMedium();
            this.lilRob = new RobotSmall();
            List<Robot> robList = new List<Robot> { bigRob, medRob, lilRob };
            this.cookCommand = new CookCommand(robList);

            setCommands();
        }

        private void setCommands()
        {
            this.invoker.setCommand(cookCommand, 0);
        }

        public void action(int index, Robot robot)
        {
            invoker.pressButton(index, robot);
        }
    }
}
