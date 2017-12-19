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
    public partial class Overview : Form
    {
        IEnumerable<Car> cars;

        public Overview()
        {
            InitializeComponent();
            LoadCar load = new LoadCar();
            cars = load.Load();
        }

        private void SaveButton_Enter(object sender, EventArgs e)
        {
        }

        //when the user hovers over the button a selector shows up next to it.
        private void SaveButton_MouseHover(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            OverviewText.Text = button.Text;

            while (SelectedButton.Location.Y != button.Location.Y)
            {

                if (SelectedButton.Location.Y > button.Location.Y)
                    SelectedButton.Location = new Point(SelectedButton.Location.X, SelectedButton.Location.Y - 1);
                else
                    SelectedButton.Location = new Point(SelectedButton.Location.X, SelectedButton.Location.Y + 1);
            }

        }

        private void Overview_Load(object sender, EventArgs e)
        {
            if(cars.Count() == 0)
            {
                OverviewText.Text = "There are currently no saved cars :(";
            } else
            {
                OverviewText.Text = cars.ElementAt(0).Model;
            }

            //for each car in cars we're going to add the car to the list box.
            foreach(Car car in cars)
            {
                carBox.Items.Add(car.Manufacturer + " " + car.Model);
            }
        }

        /*When the add car button is pressed we want to close the current form
         and open the add car form (Form1).*/
        private void AddCarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 addCar = new Form1();
            addCar.Closed += (s, args) => this.Close();
            addCar.Show();
        }

        private void SelectCarButton_Click(object sender, EventArgs e)
        {
            Car car = cars.ElementAt(carBox.SelectedIndex);

            //getting the car printer.
            CarPrinter printer = new CarPrinter();
            
            //printing the header for the car ie. manufacturer, model and description.
            string carInfo = printer.carHeader(car);

            //getting the rest of the cars details.
            string carDetails = printer.printcar(car);

            CarInfo.Text = carInfo;
            CarDetails.Text = carDetails;

            //setting the image to be the badge of the car.
            CarBadge badge = new CarBadge();
            string url = badge.getBadge(car.Manufacturer);
            Badge.Image = Image.FromFile(url);
            Badge.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (carBox.SelectedIndex != -1)
            {
                SaveCar save = new SaveCar();
                save.removeCar(carBox.SelectedIndex);
                carBox.Items.RemoveAt(carBox.SelectedIndex);
            }
        }
    }
}
