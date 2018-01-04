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

            //decimal fuelCost = Math.Round(FuelUpDown.Value, 2);

            Properties.Settings.Default.PetrolPrice = (double) FuelUpDown.Value;

            /*If what the user has typed is less than or equal to 0
             then this is not a valid fuel price so we will display
             an error message to the user.*/
            if (FuelUpDown.Value <= 0)
            {
                ConfirmError.SetError(DieselUpDown, "Invalid Fuel Price");
            }

            //decimal dieselCost = Math.Round(DieselUpDown.Value, 2);

            Properties.Settings.Default.DieselPrice = (double) DieselUpDown.Value;

            /*The value the user has selected
             0 = Imperial
             1 = Metric
             */
            int value = ImperialOrMetric.Value;
            /*If the value is imperial then we will set the mesurement system
             to be true*/
            if (value == 0)
            {
                Properties.Settings.Default.ImperialOrMetric = true;
            }
            /*Else the value is metric so we will set the measurement system
             to be false.*/
            else
            {
                Properties.Settings.Default.ImperialOrMetric = false;
            }

            Properties.Settings.Default.Save();

            this.Close();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Init_Load(object sender, EventArgs e)
        {
            double petrolPrice = Properties.Settings.Default.PetrolPrice;
            double dieselPrice = Properties.Settings.Default.DieselPrice;
            bool measurementSystem = Properties.Settings.Default.ImperialOrMetric;

            /*when the page is loaded ensure that we're displayed the saved
            fuel price.*/
            FuelUpDown.Value = (decimal) Properties.Settings.Default.PetrolPrice;
            DieselUpDown.Value = (decimal) Properties.Settings.Default.DieselPrice;

            /*If the measurement system is true (imperial) then the value of the up down is 0
             else the measurement system is false (metric) then the value of the up down is 1.*/
             if(measurementSystem)
            {
                ImperialOrMetric.Value = 0;
            } else
            {
                ImperialOrMetric.Value = 1;
            }
        }

        private void ImperialOrMetric_Scroll(object sender, EventArgs e)
        {
            label1.Text = ImperialOrMetric.Value.ToString();
        }
    }
}
