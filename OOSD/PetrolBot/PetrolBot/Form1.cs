using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolBot
{    
    public partial class Form1 : Form
    {
        const int SHIP_SIZE = 40;
        int numShips;
        List<PetrolBot> botList;
        List<Ship> shipList;
        Random rGen;

        Graphics mainCanvas;
        Bitmap offScreenBitmap;
        Graphics offScreenGraphics;

        SolidBrush mainBrush;
        SolidBrush blackBrush;


        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            mainCanvas = this.CreateGraphics();
            offScreenBitmap = new Bitmap(this.Width, this.Height);
            offScreenGraphics = Graphics.FromImage(offScreenBitmap);

            timer1.Enabled = true;
            shipList = new List<Ship>();
            botList = new List<PetrolBot>();
            numShips = 6;
            rGen = new Random();

            mainBrush = new SolidBrush(Color.LightBlue);
            blackBrush = new SolidBrush(Color.Black);
            

            for (int i = 0; i < numShips; i++ )
            {
                Ship ship = new Ship(offScreenGraphics, SHIP_SIZE, rGen);
                PetrolBot bot = new PetrolBot(offScreenGraphics, ship, new Point(50 * (i + 1), 500), rGen);
                shipList.Add(ship);
                botList.Add(bot);                
            }            
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            offScreenGraphics.FillRectangle(mainBrush, 0, 0, 600, 600);
            offScreenGraphics.FillRectangle(blackBrush, 0, 485, 585, 75);

            for(int i = 0; i < shipList.Count; i++)
            {
                shipList[i].ShipCycle();
                botList[i].drawBot();
            }
            
            mainCanvas.DrawImage(offScreenBitmap, 0, 0);
        }
    }
}
