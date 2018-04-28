using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_EXAMEN02_018416
{
    abstract class Robot
    {
        public abstract void Cook();
        public abstract void Run();
        public abstract void Paint();
        public abstract void Repair();
        public abstract void Destroy();
    }
}
