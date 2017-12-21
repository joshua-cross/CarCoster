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

        List<Car> Car1Models = new List<Car>();
        List<Car> Car2Models = new List<Car>();

        Car userCar;

        JsonReader reader = new JsonReader();
        CarListReader search = new CarListReader();
        CarBadge badge = new CarBadge();
        LoadCar load = new LoadCar();
        CarPrinter print = new CarPrinter();


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
            reader.getCarsYear("2016");
            cars = reader.getCars();
            selectedCars = load.Load();

            userCar = load.LoadSelectedCar();

            /*If the user has a car we will send the loadDefaultComparison the userCar,
             else we will send over the first car in the array, and if this is not possible, then
             the application is not working as intended so we will send an error message
             to the user.*/
            if (userCar == null)
            {
                if (cars != null)
                {
                    loadDefaultComparison(cars.ElementAt(0));
                } else
                {
                    loadDefaultComparison(null);
                }

            }
            else
            {
                loadDefaultComparison(userCar);
            }

            populateManufacturers();
            populateSelectedCars();
        }

        /*Displaying a example comparisson when the form is loaded, by default it will
         be the users main car, or failing this, the first car in the list of cars.
         Failing this we will display an error message.*/
        private void loadDefaultComparison(Car theCar) 
        {
            //if the car is null display an error message.
            if(theCar == null)
            {
                Car1OverviewLabel.Text = "ERROR!";
                Car2OverviewLabel.Text = "ERROR!";
                Car1OverviewLabel.ForeColor = Color.Red;
                Car2OverviewLabel.ForeColor = Color.Red;

                Car1OverviewText.Text = "Something's gone wrong.";
                Car2OverviewText.Text = "Something's gone wrong.";
            } else
            {
                setComparison(theCar, theCar);
            }
        }

        /*Function that takes in the 2 cars the user wants to compare
         and sets the text to be all the details of the car.*/
        private void setComparison(Car car1, Car car2)
        {
            //strings which will be printed in the end.
            string sCar1, sCar2;

            if(car1 != null)
            {
                sCar1 = print.carHeader(car1) + "\n" + print.printcar(car1);
                //loading the car1 badge
                changeImage(Car1Badge, car1.Manufacturer);
            } else
            {
                sCar1 = "ERROR!";
            }

            if(car2 != null)
            {
                sCar2 = print.carHeader(car2) + "\n" + print.printcar(car2);
                changeImage(Car2Badge, car2.Manufacturer);
            }
            else
            {
                sCar2 = "ERROR!";
            }

            Car1OverviewText.Text = sCar1;
            Car2OverviewText.Text = sCar2;


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

 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        /*Allows users to drag and drop by clicking on something.*/
        private void Compare_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /*Changing the selected PictureBox's picture using the given manufactuter.*/
        private void changeImage(PictureBox box, string man)
        {
            string url = badge.getBadge(man);
            box.Image = Image.FromFile(url);
            box.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /*When the Car1ManufacturerList Index is changed a couple of things will happen
         a. The logo at the bottom will change to correlate with the selected manufacturer
         b. We will populate the models with the manufacturers models.*/
        private void Car1ManufacturorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //only change the image when we have something selected(if selected has not been wiped.)
            if (Car1ManufacturorList.SelectedIndex != -1)
            {
                changeImage(Car1LogoPicture, Car1ManufacturorList.SelectedItem.ToString());
                Car1Models.Clear();
                Car1SelectedCarList.ClearSelected();
                Car1Models = populateModels(Car1ManufacturorList.SelectedItem.ToString(), Car1ModelList);
            }
        }

        /*When the Car2ManufacturerList Index is changed a couple of things will happen
         a. The logo at the bottom will change to correlate with the selected manufacturer
         b. We will populate the models with the manufacturers models.*/
        private void Car2ManufacturorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //only change the image when we have something selected(if selected has not been wiped.)
            if (Car2ManufacturorList.SelectedIndex != -1)
            {
                changeImage(Car2LogoPicture, Car2ManufacturorList.SelectedItem.ToString());
                //clearing the models, as we're repopulating
                Car2Models.Clear();
                Car2SelectedCarList.ClearSelected();
                Car2Models = populateModels(Car2ManufacturorList.SelectedItem.ToString(), Car2ModelList);
            }
        }

        /*Using the searchCars function of the CarListReader class to find all the models for the
         given manufacturer then populating the corresponding Model list with these models.*/
        private List<Car> populateModels(string manufacturer, ListBox box)
        {

            //clearing the box.
            box.Items.Clear();

            //getting every car with the manufacturer given.
            IEnumerable<Car> carModels = new List<Car>();
            carModels = search.searchCars(cars, manufacturer);

            List<Car> searchedCars = carModels.ToList();

            foreach(Car theCar in searchedCars)
            {
                string toAdd = theCar.Model + " " + theCar.Description;
                box.Items.Add(toAdd);
            }

            return searchedCars;
            
        }

        /*When the comparrison button is clicked the function checks all combinations of car1 and car2
         comparisson, ie.
         a. Choose car - choose car
         b. Choose car - selected car
         c. selected car - choose car
         d. selected car - selected car*/
        private void CompareButton_Click(object sender, EventArgs e)
        {
            Car car1;
            Car car2;

            /*choose car - choose car*/
            if (Car1ModelList.SelectedIndex != -1 &&
                Car2ModelList.SelectedIndex != -1)
            {
                car1 = Car1Models[Car1ModelList.SelectedIndex];
                car2 = Car2Models[Car2ModelList.SelectedIndex];
                setComparison(car1, car2);
                hasComparedText.Text = "Success";
            }
            /*choose car - selected car*/
            else if (Car1ModelList.SelectedIndex != -1 &&
                     Car2SelectedCarList.SelectedIndex != -1)
            {
                car1 = Car1Models[Car1ModelList.SelectedIndex];
                car2 = selectedCars.ElementAt(Car2SelectedCarList.SelectedIndex);
                setComparison(car1, car2);
                hasComparedText.Text = "Success";
            }
            /*selected car - choose car*/
            else if (Car2ModelList.SelectedIndex != -1 &&
                     Car1SelectedCarList.SelectedIndex != -1)
            {
                car1 = selectedCars.ElementAt(Car1SelectedCarList.SelectedIndex);
                car2 = Car2Models[Car2ModelList.SelectedIndex];
                setComparison(car1, car2);
                hasComparedText.Text = "Success";
            }
            /*selected car - selected car*/
            else if(Car1SelectedCarList.SelectedIndex != -1 &&
                    Car2SelectedCarList.SelectedIndex != -1)
            {
                car1 = selectedCars.ElementAt(Car1SelectedCarList.SelectedIndex);
                car2 = selectedCars.ElementAt(Car2SelectedCarList.SelectedIndex);
                setComparison(car1, car2);
                hasComparedText.Text = "Success";
            }
            //else 1, or no cars have been selected.
            else
            {
                hasComparedText.Text = "Please Select 2 Cars.";
            }
        }

        /*when the selected cars for car 1 is changed the models will be wiped for car 1
         and the manufacturers selected index will be reset.*/
        private void Car1SelectedCarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Car1SelectedCarList.SelectedIndex != -1)
            {
                Car1ModelList.ClearSelected();
                Car1ModelList.Items.Clear();
                Car1Models.Clear();
                Car1ManufacturorList.ClearSelected();
                string manufacturer = selectedCars.ElementAt(Car1SelectedCarList.SelectedIndex).Manufacturer;
                changeImage(Car1LogoPicture, manufacturer);
            }
        }

        /*when the selected cars for car 1 is changed the models will be wiped for car 1
         and the manufacturers selected index will be reset.*/
        private void Car2SelectedCarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Car2SelectedCarList.SelectedIndex != -1)
            {
                Car2ModelList.ClearSelected();
                Car2ModelList.Items.Clear();
                Car2Models.Clear();
                Car2ManufacturorList.ClearSelected();
                string manufacturer = selectedCars.ElementAt(Car2SelectedCarList.SelectedIndex).Manufacturer;
                changeImage(Car2LogoPicture, manufacturer);
            }
        }
    }
}
