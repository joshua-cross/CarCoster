using System;
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
    public partial class Compare : Form
    {

        /*The PopulateListBox class that will maintain the listboxes, and the Listed objects.*/
        PopulateListBox listBoxes = new PopulateListBox();

        IEnumerable<Car> cars;
        IEnumerable<Car> selectedCars;
        //list of the cars manufacturers.
        List<string> manufacturers = new List<string>();

        List<Car> Car1Models = new List<Car>();
        List<Car> Car2Models = new List<Car>();

        bool measurementSystem = true;

        Car userCar;

        JsonReader reader = new JsonReader();
        CarListReader search = new CarListReader();
        CarBadge badge = new CarBadge();
        LoadCar load = new LoadCar();
        CarPrinter print = new CarPrinter();


        /*Creating listed objects for the cars that we need to compare.*/
        Listed car1List = new Listed();
        Listed car2List = new Listed();

        int minYear = 2000;
        int latestYear = 0;

        /*constructor that takes in 2 Listed objects and sets thhe car1List, and the car2List
         with these inputs.*/
         public Compare(Listed list1, Listed list2)
        {
            car1List = list1;
            car2List = list2;
            InitializeComponent();
        }

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
            //reader.getJsonLocation("2016");
            cars = reader.getCars();
            selectedCars = load.Load();

            userCar = load.LoadSelectedCar();

            string thisDirectory = Directory.GetCurrentDirectory().ToString();
            string fileLoc = thisDirectory + @"\Images\LeafIcon.png";
            pictureBox1.Image = Image.FromFile(fileLoc);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

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

            latestYear = car1List.LatestFileYear;

            populateYears();
            populateManufacturers();
            populateSelectedCars();
        }

        /*Function that draws all the years from the year 2000, to the current latest file
         in the year ListBoxes.*/
         private void populateYears()
        {
            /*If there was a latest year saved.*/
            if(latestYear != 0)
            {
                /*For each year between the minimum year and the maximum year
                 add the year to the listboxes*/
                 for(int i = minYear; i <= latestYear; i = i + 1)
                {
                    SelectCar1Year.Items.Add(i.ToString());
                    SelectCar2Year.Items.Add(i.ToString());
                }

                /*Add the all option to the end.*/
                SelectCar1Year.Items.Add("All");
                SelectCar2Year.Items.Add("All");
            }
        }

        /*Displaying a example comparisson when the form is loaded, by default it will
         be the users main car, or failing this, the first car in the list of cars.
         Failing this we will display an error message.*/
        private void loadDefaultComparison(Car theCar) 
        {
            //if the car is null display an error message.
            if(theCar == null)
            {
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
                sCar1 = print.carHeader(car1) + "\n" + print.printcar(car1, measurementSystem);
                //loading the car1 badge
                changeImage(Car1Badge, car1.Manufacturer);
            } else
            {
                sCar1 = "ERROR!";
            }

            if(car2 != null)
            {
                sCar2 = print.carHeader(car2) + "\n" + print.printcar(car2, measurementSystem);
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
            Car1ManufacturorList.Items.Clear();
            Car2ManufacturorList.Items.Clear();

            listBoxes.PopulateListBoxWithManufacturers(Car1ManufacturorList, car1List.Manufacturers);
            listBoxes.PopulateListBoxWithManufacturers(Car2ManufacturorList, car2List.Manufacturers);

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
                string manufacturer = Car1ManufacturorList.SelectedItem.ToString();
                changeImage(Car1LogoPicture, manufacturer);
                car1List = listBoxes.ManufactuerSelected(Car1ModelList, manufacturer, car1List, Car1LogoPicture);
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
                string manufacturer = Car2ManufacturorList.SelectedItem.ToString();
                changeImage(Car2LogoPicture, manufacturer);
                car2List = listBoxes.ManufactuerSelected(Car2ModelList, manufacturer, car2List, Car2LogoPicture);
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
                car1 = car1List.CurrentCars.ElementAt(Car1ModelList.SelectedIndex);
                car2 = car2List.CurrentCars.ElementAt(Car2ModelList.SelectedIndex);
                setComparison(car1, car2);
                hasComparedText.Text = "Success";
            }
            /*choose car - selected car*/
            else if (Car1ModelList.SelectedIndex != -1 &&
                     Car2SelectedCarList.SelectedIndex != -1)
            {
                car1 = car1List.CurrentCars.ElementAt(Car1ModelList.SelectedIndex);
                car2 = selectedCars.ElementAt(Car2SelectedCarList.SelectedIndex);
                setComparison(car1, car2);
                hasComparedText.Text = "Success";
            }
            /*selected car - choose car*/
            else if (Car2ModelList.SelectedIndex != -1 &&
                     Car1SelectedCarList.SelectedIndex != -1)
            {
                car1 = selectedCars.ElementAt(Car1SelectedCarList.SelectedIndex);
                car2 = car2List.CurrentCars.ElementAt(Car2ModelList.SelectedIndex);
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

        /*When the petrol button is pressed only display petrol cars.*/
        private void Car1PetrolButton_Click(object sender, EventArgs e)
        {
            car1List.CurrentCars = listBoxes.ShowOnlySelectedFuelType("Petrol", Car1ModelList, car1List.CurrentCars);
        }

        private void Car1DieselButton_Click(object sender, EventArgs e)
        {
            car1List.CurrentCars = listBoxes.ShowOnlySelectedFuelType("Diesel", Car1ModelList, car1List.CurrentCars);
        }

        private void Car1HybridButton_Click(object sender, EventArgs e)
        {
            car1List.CurrentCars = listBoxes.ShowOnlySelectedFuelType("Hybrid", Car1ModelList, car1List.CurrentCars);
        }

        private void Car1ElectricButton_Click(object sender, EventArgs e)
        {
            car1List.CurrentCars = listBoxes.ShowOnlySelectedFuelType("Electric", Car1ModelList, car1List.CurrentCars);
        }

        private void Car2PetrolButton_Click(object sender, EventArgs e)
        {
            car2List.CurrentCars = listBoxes.ShowOnlySelectedFuelType("Petrol", Car2ModelList, car2List.CurrentCars);
        }

        private void Car2DieselButton_Click(object sender, EventArgs e)
        {
            car2List.CurrentCars = listBoxes.ShowOnlySelectedFuelType("Diesel", Car2ModelList, car2List.CurrentCars);
        }

        private void Car2HyrbidButton_Click(object sender, EventArgs e)
        {
            car2List.CurrentCars = listBoxes.ShowOnlySelectedFuelType("Hybrid", Car2ModelList, car2List.CurrentCars);
        }

        private void Car2ElectricButton_Click(object sender, EventArgs e)
        {
            car2List.CurrentCars = listBoxes.ShowOnlySelectedFuelType("Electric", Car2ModelList, car2List.CurrentCars);
        }

        /*Function that takes in:
             a. The ListBox of the year that we want to display.
             b. The Listed object we wish to update with the new cars.
             c. The ListBox we wish to update with the new manufacturers.
         and switches the Listed object to display the specific years cars.*/
         private void SwitchingYear(ListBox year, Listed list, ListBox toUpdate)
        {
            //if the user has selected a year.
            if (year.SelectedIndex != -1)
            {

                CarListReader listReader = new CarListReader();

                //the year that the user has selected.
                string selectedYear = year.SelectedItem.ToString();

                JsonReader json = new JsonReader(selectedYear);
                list.Cars = json.getCars();

                list.Manufacturers = listReader.GetManufacturers(list.Cars);

                list.searchedManufacturers = list.Manufacturers;

                listBoxes.PopulateListBoxWithManufacturers(toUpdate, list.Manufacturers);
                //setting the year to be the year that was selected.
                //year = selectedYear;

                //drawListBox(json);

            }
        }

        private void ConfirmYearCar1_Click(object sender, EventArgs e)
        {
            SwitchingYear(SelectCar1Year, car1List, Car1ManufacturorList);
        }

        private void ConfirmYearCar2_Click(object sender, EventArgs e)
        {
            SwitchingYear(SelectCar2Year, car2List, Car2ManufacturorList);
        }

        private void OverviewButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overview overview = new Overview();
            overview.Closed += (s, args) => this.Close();
            overview.Show();
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            Listed list = new Listed();
            list = list.DefaultForm1ToLoad();
            this.Hide();
            Form1 addCar = new Form1(list);
            addCar.Closed += (s, args) => this.Close();
            addCar.Show();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Init init = new Init();
            init.Show();
        }
    }
}
