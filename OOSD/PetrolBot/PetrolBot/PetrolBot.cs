using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBot
{
    public class PetrolBot
    {
        private Graphics botCanvas;

        private Color botColour;
        private Point botCurrentLocation;
        private Ship botShip;
        private Point botStartingLocation;
        private Point shipLocation;

        public PetrolBot(Graphics botCanvas, Ship botShip, Point botStartingLocation, Random rGen)
        {            
            this.botCanvas = botCanvas;
            this.botShip = botShip;
            this.botStartingLocation = botStartingLocation;
            botColour = Color.FromArgb(rGen.Next(255), rGen.Next(255), rGen.Next(255));
            botCurrentLocation = botStartingLocation;

            Ship.OutOfFuelEventHandler outOfFuelHandler = new Ship.OutOfFuelEventHandler(OutOfFuelEventHandler);
            botShip.OutOfFuelEvent += outOfFuelHandler;

            Ship.FullOfFuelEventHandler fullOfFuelHandler = new Ship.FullOfFuelEventHandler(FullOfFuelEventHandler);
            botShip.FullOfFuelEvent += fullOfFuelHandler;
        }

        public void moveBot()
        {

        }

        public void drawBot()
        {
            SolidBrush botBrush = new SolidBrush(botColour);

            botCanvas.FillEllipse(botBrush, new Rectangle(botCurrentLocation, new Size(20,20)));
        }

        public void FullOfFuelEventHandler(object ship, ShipEventArgs shipArgs)
        {
            botCurrentLocation = botStartingLocation;
        }

        public void OutOfFuelEventHandler(object ship, ShipEventArgs shipArgs)
        {
            shipLocation = botShip.getShipLocation();

            botCurrentLocation = shipLocation;

            botShip.Refuel();
            
        }
    }
}
