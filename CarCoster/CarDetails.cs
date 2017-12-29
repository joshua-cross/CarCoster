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
    public partial class CarDetails : Form
    {
        CarToBeDisplayed displayed = new CarToBeDisplayed();


        /*Constructor that's called from the Form1 (AddCar) that takes
         in the car the user has selected, and opens sends it over to
         this form before opening this form. This constructor will then
         assign the details of the CarToBeDisplayed Object to the UI
         objects of this form such as the picture box.*/
        public CarDetails(CarToBeDisplayed display)
        {
            displayed = display;


            InitializeComponent();
        }

        public CarDetails()
        {
            InitializeComponent();
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarDetails_Load(object sender, EventArgs e)
        {

            try
            {
                logoBox.Image = Image.FromFile(displayed.imageURL);
                logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception error)
            {
                Console.WriteLine("Error, image has not loaded.");
            }

            if (displayed != null)
            {
                HeaderText.Text = displayed.carHeader;
                DetailsText.Text = displayed.carDetails;
            }
        }
    }
}
