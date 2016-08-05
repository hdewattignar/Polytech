using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    class GameMachineMaker : IMachine_Maker
    {

        public Processor makeCPU()
        {
            GameProcessor newProcessor = new GameProcessor();
            return newProcessor;
        }

        public GraphicsCard makeGraphicsCard()
        {
            GameGraphicsCard newGraphicsCard = new GameGraphicsCard();
            return newGraphicsCard;
        }

        public Memory makeMemory()
        {
            GameMemory newMultiMediaMemory = new GameMemory();
            return newMultiMediaMemory;
        }

        public MotherBoard makeMotherBoard()
        {
            GameMotherBoard newMotherBoard = new GameMotherBoard();
            return newMotherBoard;
        }
    }
}
