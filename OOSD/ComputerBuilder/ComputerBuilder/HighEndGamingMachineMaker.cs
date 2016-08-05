using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    class HighEndGamingMachineMaker : IMachine_Maker
    {        

        public Processor makeCPU()
        {
            HighEndGamingProcessor newProcessor = new HighEndGamingProcessor();
            return newProcessor;
        }

        public GraphicsCard makeGraphicsCard()
        {
            HighEndGamingGraphicsCard newGraphicsCard = new HighEndGamingGraphicsCard();
            return newGraphicsCard;
        }

        public Memory makeMemory()
        {
            HighEndGamingMemory newMultiMediaMemory = new HighEndGamingMemory();
            return newMultiMediaMemory;
        }

        public MotherBoard makeMotherBoard()
        {
            HighEndGamingMotherBoard newMotherBoard = new HighEndGamingMotherBoard();
            return newMotherBoard;
        }
    }
}
