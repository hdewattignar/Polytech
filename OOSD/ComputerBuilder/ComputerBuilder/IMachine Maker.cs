using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    interface IMachine_Maker
    {
        Processor makeCPU();
        GraphicsCard makeGraphicsCard();
        Memory makeMemory();
        MotherBoard makeMotherBoard();
    }
}
