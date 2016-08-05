using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBot
{
    public enum EShipState { wandering, refueling };
    public class ShipEventArgs : EventArgs
    {
        public EShipState shipState { get; set; }

        public ShipEventArgs(EShipState currentShipState)
        {
            shipState = currentShipState;
        }
    }
}
