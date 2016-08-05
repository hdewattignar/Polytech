using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    class MultiMediaMachineMaker : IMachine_Maker
    {
        public Processor makeCPU()
        {
            MultiMediaProcessor newProcessor = new MultiMediaProcessor();
            return newProcessor;
        }

        public GraphicsCard makeGraphicsCard()
        {
            MultiMediaGraphicsCard newGraphicsCard = new MultiMediaGraphicsCard();
            return newGraphicsCard;
        }

        public Memory makeMemory()
        {
            MultiMediaMemory newMultiMediaMemory = new MultiMediaMemory();
            return newMultiMediaMemory;
        }

        public MotherBoard makeMotherBoard()
        {
            MultiMediaMotherBoard newMotherBoard = new MultiMediaMotherBoard();
            return newMotherBoard;
        }
    }
}
