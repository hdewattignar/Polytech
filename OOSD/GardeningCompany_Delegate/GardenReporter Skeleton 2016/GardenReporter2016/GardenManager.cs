using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenReporter2016
{
    public delegate String DisplayDelegate(Garden garden); 
    public class GardenManager
    {
        private List<Garden> gardens;
        private ListBox displayBox;
        public GardenManager(ListBox displayBox)
        {
            gardens = new List<Garden>();
            this.displayBox = displayBox;
        }

        public void AddGarden(Garden newGarden)
        {
            gardens.Add(newGarden);
        }

        public void ProcessGardens(DisplayDelegate displayData)
        {
            for(int i = 0; i < gardens.Count; i++)
            {
                displayBox.Items.Add(displayData(gardens[i]));
            }

        }

        public String DisplayGardenArea(Garden garden)
        {
            String reportString = String.Format("{0,-14}:{1,8:f2}", garden.OwnerName, garden.GetArea());

            return reportString;
        }

        public String DisplayCustomerBalance(Garden garden)
        {
            String reportString = String.Format("{0,-14}:{1,8:f2}", garden.OwnerName, garden.GetAccountBalance());

            return reportString;
        }
    }
}
