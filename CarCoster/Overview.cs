﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CarCoster
{
    public partial class Overview : Form
    {
        IEnumerable<Car> cars;
        //the car the user has previously loaded.
        Car car;

        bool measurementSystem = true;

        public Overview()
        {
            InitializeComponent();
            LoadCar load = new LoadCar();
            cars = load.Load();
            car = load.LoadSelectedCar();

            /*Calculating the tax for each of the cars in car.*/
            try
            {
                foreach(Car theCar in cars)
                {
                    if(theCar.CO2gramsPerKilometer != null &&
                       theCar.CO2gramsPerKilometer != 0)
                    {
                        TaxCalculator tax = new TaxCalculator();
                        float? taxCost = tax.CalculateTax(theCar);
                    }
                }

                if(car.CO2gramsPerKilometer != null && 
                   car.CO2gramsPerKilometer != 0)
                {
                    TaxCalculator tax = new TaxCalculator();
                    float? taxCost = tax.CalculateTax(car);
                }

            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            string thisDirectory = Directory.GetCurrentDirectory().ToString();
            string fileLoc = thisDirectory + @"\Images\LeafIcon.png";
            pictureBox1.Image = Image.FromFile(fileLoc);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            /*If the car is null that means that the user has not
             * yet selected a car to be there main car, in which case we will set the
             first car in the array (if it exists) to be the selected car.*/
            if (car == null)
            {
                /*Checking if the user has added any cars to the list before
                 if they have we will set the first of these cars to be the selected cars, else
                 we will display the user with an error message.*/
                 if(cars != null && cars.Count() > 0)
                 {
                    SaveCar save = new SaveCar();
                    save.selectedCar(0);

                    //printer so we can print information about the car.
                    CarPrinter printer = new CarPrinter();
                    string info = printer.carHeader(cars.ElementAt(0));
                    string details = printer.printcar(cars.ElementAt(0), measurementSystem);
                    CarInfo.Text = info;
                    CarDetails.Text = details;

                    setImage(cars.ElementAt(0).Manufacturer);
                 }
                 /*Else we have no saved cars either so we will
                  display a messaage to the user saying we have no car.*/
                else
                {
                    setImage("error");
                    CarInfo.Text = "Error! Please go to Add Car and add your car/cars.";
                    CarDetails.Text = "Error!";
                }
            }
            //else a saved car does exist so use this instead.
            else
            {
                CarPrinter printer = new CarPrinter();
                string info = printer.carHeader(car);
                string details = printer.printcar(car, measurementSystem);
                CarInfo.Text = info;
                CarDetails.Text = details;

                setImage(car.Manufacturer);
            }

            
        }

        private void SaveButton_Enter(object sender, EventArgs e)
        {
        }

        //when the user hovers over the button a selector shows up next to it.
        private void SaveButton_MouseHover(object sender, EventArgs e)
        {

            Button button = (Button)sender;

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
            Listed list = new Listed();
            list = list.DefaultForm1ToLoad();
            this.Hide();
            Form1 addCar = new Form1(list);
            addCar.Closed += (s, args) => this.Close();
            addCar.Show();
        }

        private void SelectCarButton_Click(object sender, EventArgs e)
        {
            Car theCar = cars.ElementAt(carBox.SelectedIndex);

            //getting the car printer.
            CarPrinter printer = new CarPrinter();
            
            //printing the header for the car ie. manufacturer, model and description.
            string carInfo = printer.carHeader(theCar);

            //getting the rest of the cars details.
            string carDetails = printer.printcar(theCar, measurementSystem);

            CarInfo.Text = carInfo;
            CarDetails.Text = carDetails;

            SaveCar save = new SaveCar();
            save.selectedCar(carBox.SelectedIndex);

            setImage(theCar.Manufacturer);
        }

        /*Fucntion that calls the CarBadge classes getBadge function.*/
        private void setImage(string man)
        {
            //setting the image to be the badge of the car.
            CarBadge badge = new CarBadge();
            string url = badge.getBadge(man);
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            /*Creating a listed object to send to the compare form.*/
            Listed list = new Listed();
            list = list.DefaultForm1ToLoad();
            Listed list2 = new Listed();
            list2 = list.DefaultForm1ToLoad();
            this.Hide();
            Compare compareCar = new Compare(list, list2);
            compareCar.Closed += (s, args) => this.Close();
            compareCar.Show();
        }

        /*function to be called when the settings form that we opened is being closed.
        This function takes in an init form which we will use to calculate the new total costs.*/
        public void SettingsClosed(Init init)
        {
            CarsToPrint newCars = new CarsToPrint();
            LoadCar load = new LoadCar();

            car = load.LoadSelectedCar();

            newCars = init.RecalculateMPGSelected(cars, load.LoadSelectedCar());

            try
            {
                CarInfo.Text = newCars.Header;
                CarDetails.Text = newCars.Body;
            } catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Init init = new Init(this);
            init.Show();
        }
    }
}
