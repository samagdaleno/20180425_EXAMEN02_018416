using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_EXAMEN02_018416
{
    class Program
    {
        static void Main(string[] args)
        {
            Client samClient = new Client();

            RobotBig bigBoi = new RobotBig();
            RobotSmall lilBoi = new RobotSmall();

            samClient.action(0, bigBoi);
            samClient.action(0, lilBoi);

            Console.ReadKey();
        }
    }
}
