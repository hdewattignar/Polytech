using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    class BusinessMachineMaker : IMachine_Maker
    {
        public Processor makeCPU()
        {
            BusinessProcessor newProcessor = new BusinessProcessor();
            return newProcessor;
        }

        public GraphicsCard makeGraphicsCard()
        {
            BussinessGraphicsCard newGraphicsCard = new BussinessGraphicsCard();
            return newGraphicsCard;
        }

        public Memory makeMemory()
        {
            BussinessMemory newMultiMediaMemory = new BussinessMemory();
            return newMultiMediaMemory;
        }

        public MotherBoard makeMotherBoard()
        {
            BussinessMotherBoard newMotherBoard = new BussinessMotherBoard();
            return newMotherBoard;
        }
    }
}
