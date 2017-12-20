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
    public partial class Compare : Form
    {

        IEnumerable<Car> cars;
        IEnumerable<Car> selectedCars;
        //list of the cars manufacturers.
        List<string> manufacturers = new List<string>();


        JsonReader reader = new JsonReader();
        CarListReader search = new CarListReader();
        CarBadge badge = new CarBadge();
        LoadCar load = new LoadCar();

        public Compare()
        {
            InitializeComponent();
        }

        //when we hover over a button the selecter will go to this location.
        private void SaveButton_MouseHover(object sender, EventArgs e)
        {
            SelectedButton.Visible = true;

            Button button = (Button)sender;
            //OverviewText.Text = button.Text;

            while (SelectedButton.Location.Y != button.Location.Y)
            {

                if (SelectedButton.Location.Y > button.Location.Y)
                    SelectedButton.Location = new Point(SelectedButton.Location.X, SelectedButton.Location.Y - 1);
                else
                    SelectedButton.Location = new Point(SelectedButton.Location.X, SelectedButton.Location.Y + 1);
            }

        }

        private void Compare_Load(object sender, EventArgs e)
        {

            cars = reader.getCars();
            selectedCars = load.Load();

            populateManufacturers();
            populateSelectedCars();
        }

        /*Function that gets all the cars and displays the manufacturers of them.*/
        private void populateManufacturers()
        {
            //do if the cars have loaded successfully.
            if(cars != null)
            {

                /*For each of the cars, we are going to check if we already have the manufacturer
                 present, and if we do not then we're going to add it to both the
                 Car 1 and Car 2 side.*/
                foreach(Car theCar in cars)
                {

                    bool isNew = true;

                    foreach(string manufacturer in manufacturers)
                    {
                        //if the value of the cars manufacturer is already in the array, the it's not a unique
                        //manufactuer so we should not add it to the list.
                        if(manufacturer.Equals(theCar.Manufacturer))
                        {
                            isNew = false;
                            break;
                        }
                    }

                    if(isNew == true)
                    {
                        manufacturers.Add(theCar.Manufacturer);
                        Car1ManufacturorList.Items.Add(theCar.Manufacturer);
                        Car2ManufacturorList.Items.Add(theCar.Manufacturer);
                    }

                }
            }
        }

        /*Adding each of the users selected cars to the listbox so the user can compare there
         selected car rather than 2 searched cars if they wanted.*/
        private void populateSelectedCars()
        {
            if(selectedCars != null)
            {
                /*For each car in selectedCars, we're going to add the model, and manufacturer of the 
                 car to the ListBox.*/
                foreach(Car theCar in selectedCars)
                {
                    string toAdd = theCar.Manufacturer + " " + theCar.Model;
                    Car1SelectedCarList.Items.Add(toAdd);
                    Car2SelectedCarList.Items.Add(toAdd);
                }
            }
        }
    }
}
