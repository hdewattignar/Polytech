using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBuilder
{
    class MachineSpecPrinter
    {
        private IMachine_Maker machineMaker;
        private ListBox displayBox;

        public MachineSpecPrinter(IMachine_Maker machineMaker, ListBox displayBox)
        {
            this.machineMaker = machineMaker;
            this.displayBox = displayBox;
        }

        public void printSpec()
        {
            Processor currCPU = machineMaker.makeCPU();
            Memory currMemory = machineMaker.makeMemory();
            GraphicsCard currGraphics = machineMaker.makeGraphicsCard();
            MotherBoard currMotherBoard = machineMaker.makeMotherBoard();

            double totalPrice = currCPU.Price + currMemory.Price + currGraphics.Price + currMotherBoard.Price;

            displayBox.Items.Clear();
            displayBox.Items.Add("Price\tComponent");
            displayBox.Items.Add("-----------------------------------------------------");
            displayBox.Items.Add(currCPU.ToString());
            displayBox.Items.Add(currMemory.ToString());
            displayBox.Items.Add(currGraphics.ToString());
            displayBox.Items.Add(currMotherBoard.ToString());
            displayBox.Items.Add("-----------------------------------------------------");
            displayBox.Items.Add("Total Price " + totalPrice.ToString());
        }
    }
}
