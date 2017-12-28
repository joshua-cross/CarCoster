using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCoster
{
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
        }
        /*Function that sets the setting FuelPrice when the confirm button is clicked
         the function checks if what the user has typed is valid ie. Not negative
         and rounds the number up to the second decimal point if the user has typed something such as
         3.456434*/
        private void ConfirmFuelPriceButton_Click(object sender, EventArgs e)
        {

            /*If what the user has typed is less than or equal to 0
             then this is not a valid fuel price so we will display
             an error message to the user.*/
            if (FuelUpDown.Value <= 0)
            {
                ConfirmError.SetError(FuelUpDown, "Invalid Fuel Price");
            }

            decimal fuelCost = Math.Round(FuelUpDown.Value, 2);

            Properties.Settings.Default.PetrolPrice = fuelCost;

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Init_Load(object sender, EventArgs e)
        {
            /*when the page is loaded ensure that we're displayed the saved
            fuel price.*/
            FuelUpDown.Value = Properties.Settings.Default.PetrolPrice;
            DieselUpDown.Value = Properties.Settings.Default.DieselPrice;
        }
    }
}
