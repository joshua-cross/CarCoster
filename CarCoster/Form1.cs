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
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();
        CarListReader listReader = new CarListReader();
        IEnumerable<Car> carModels = new List<Car>();
        /*List of string that will hold each of the unique manufactorers.*/
        List<string> manufactorers = new List<string>();

        /*List of all the selected cars in the ModelBox.*/
        List<Car> modelCars = new List<Car>();

        //creating a list for all the car models, and the car descriptions
        List<string> models = new List<string>();
        List<string> descriptions = new List<string>();

        List<Car> orderedCars = new List<Car>();

        _12000MilesCostCalculator costPer12000 = new _12000MilesCostCalculator();

        /*bool that's used to decide if we will display metric or imperial
         measurements to the user
         true = imperial
         false = metric.
         */
        bool measurementSystem = true;

        //the final car.
        Car searchedCar;

        //the beginning year for the car json files.
        int beginningYear = 2000;

        int theYear = 2017;

        //setting the year to be this year by default.
        string year = DateTime.Now.Year.ToString();

        public Form1()
        {
            InitializeComponent();
        }

        /*When the program initially loads we want to load an image.*/
        private void Form1_Load(object sender, EventArgs e)
        {
            string thisDirectory = Directory.GetCurrentDirectory().ToString();
            string fileLoc = thisDirectory + @"\Images\LeafIcon.png";

            string year = theYear.ToString();



            JsonReader json = new JsonReader(year);
            drawListBox(json);

            drawYearsBox();

            pictureBox1.Image = Image.FromFile(fileLoc);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /*Drawing all the years between the beginning year and the current latest
         database to the yearBox.*/
        private void drawYearsBox()
        {
            for(int i = beginningYear; i <= theYear; i++)
            {
                YearBox.Items.Add(i.ToString());
            }

            YearBox.Items.Add("All");
        }

        private void drawListBox(JsonReader json)
        {
            //clearing all the items in CarBox/ModelBox. just incase we have some in here already.
            CarBox.Items.Clear();
            ModelBox.Items.Clear();
            manufactorers.Clear();
            models.Clear();
            modelCars.Clear();
            orderedCars.Clear();

            cars = json.getCars();
            //adding an option to select all the manufacturers to the list.
            CarBox.Items.Add("All");
            try
            {
                foreach (Car car in cars)
                {
                    //calculating the cost for each of the cars if it does not have one already.
                    if(car.ActualCostPer12000Miles == null)
                    {
                        float? costOf12000 = costPer12000.CostPer12000Miles(car);
                    }

                    //the manufactorer.
                    string theManufactorer = car.Manufacturer;
                    //boolean that checks if the current manufactorer is unique or not.
                    bool isNew = true;

                    if(YearBox.SelectedIndex != -1)
                    {
                        car.carJSONYear = YearBox.SelectedItem.ToString();
                    } else
                    {
                        //setting the initial year of the car to be the year that we set at the top
                        car.carJSONYear = theYear.ToString();
                    }


                    /*Only add the manufactorer to the list if 
                     it's not already */
                    foreach (string manufactorer in manufactorers)
                    {
                        if(car.Manufacturer.Equals(manufactorer))
                        {
                            //setting is new to false at it already exists in the array.
                            isNew = false;
                            break;
                        }
                    }

                     //if the manufactorer is new then add to the array and the list.
                     if(isNew)
                    {
                        manufactorers.Add(car.Manufacturer);
                        CarBox.Items.Add(car.Manufacturer);

                    }

                }
            }
            catch (Exception error)
            {

                CarBox.Items.Add(error.ToString());

            }
        }

        //function to clear a listBox.
        private void clearListBox(ListBox list)
        {
            list.Items.Clear();
        }

        /*Function for when an item is selected in the CarBox.*/
        private void CarBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           //clearing the model searchbox as we're selecting a different model.
            ModBox.Text = "";

            clearListBox(ModelBox);

            //clearing the models and descriptions, as new items are present.
            models.Clear();
            descriptions.Clear();
            modelCars.Clear();
            orderedCars.Clear();

            /*If the item is not all then do the following*/
            if (!CarBox.SelectedItem.Equals("All"))
            {
                /*The manufactorer that has been selected by the CarBox*/
                string manufactorer = CarBox.SelectedItem.ToString();
                /*Getting the models*/
                //contstructor that takes in a manufactorer and searches the array for cars that match the manufactorer.

                carModels = listReader.searchCars(cars, manufactorer);


                //setting the image in logobox.
                CarBadge badge = new CarBadge();
                string url = badge.getBadge(CarBox.SelectedItem.ToString());
                LogoBox.Image = Image.FromFile(url);
                LogoBox.SizeMode = PictureBoxSizeMode.StretchImage;

                foreach (var car in carModels)
                {
                    ModelBox.Items.Add(car.Model.ToString() + " " + car.Description.ToString());
                    //adding the car model and description to model and description array.
                    models.Add(car.Model.ToString());
                    modelCars.Add(car);
                    descriptions.Add(car.Description.ToString());
                }
            } else
            {
                foreach(Car car in cars)
                {
                    ModelBox.Items.Add(car.Model.ToString() + " " + car.Description.ToString());
                    //adding the car model and description to model and description array.
                    models.Add(car.Model.ToString());
                    modelCars.Add(car);
                    descriptions.Add(car.Description.ToString());
                }
                carModels = modelCars;
            }

        }

        /*When the user types anything into the textbox repopulate */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(manufactorers.Count() != 0)
            {
                //clearning the CarBox so we can repopulate it.
                clearListBox(CarBox);
                
                //clearing the modbox search box as we are no longer on the same manufactorer.
                ModBox.Text = "";

                //clearing the ModelBox as we are not longer on the same manufactorer.
                clearListBox(ModelBox);

                IEnumerable<string> searchedMakes = listReader.searchString(manufactorers, MakeBox.Text);


                //Title.Text = manufactorers.Count().ToString();

                foreach (string car in searchedMakes)
                {
                    CarBox.Items.Add(car);
                }

                /*if the user has reset the search box ie. MakeBox.Text = "" then we will
                 repopulate the listbox with all the makes.*/
                if (MakeBox.Text.Equals(""))
                {
                    foreach(string car in manufactorers)
                    {
                        CarBox.Items.Add(car);
                    }
                }
            }
        }

        private void ModBox_TextChanged(object sender, EventArgs e)
        {
            /*If there are models of cars in the listbox.*/
            if(carModels.Count() != 0)
            {
                //clearing the ModelBox so we can replace it with the searched models.
                clearListBox(ModelBox);

                //clearing the models and descriptions, as new items are present.
                models.Clear();
                modelCars.Clear();
                descriptions.Clear();
                orderedCars.Clear();

                //using the CarListReader to search the Json file for the search result.
                IEnumerable<Car> searchedModels = listReader.searchModels(carModels, ModBox.Text);
                //searching the description for what has been typed.
                IEnumerable<Car> searchedDescription = listReader.searchDescriptions(carModels, ModBox.Text);
                //creating a list that contains both searchModels and searchedDescription
                IEnumerable<Car> allSearches = searchedModels.Concat(searchedDescription);
                //Title.Text = searchedModels.Count().ToString();

                //for each car that contains what we searched we will print the Car and the Description.
                foreach(Car car in allSearches)
                {
                    string toPrint = car.Model.ToString() + " " + car.Description.ToString();
                    ModelBox.Items.Add(toPrint);
                    //adding the car model and description to model and description array.
                    models.Add(car.Model.ToString());
                    descriptions.Add(car.Description.ToString());
                }

                //if the user empties the search box then we want to refill the listbox with the array of models.
                if(ModBox.Text.Equals(""))
                {
                    foreach(Car car in carModels)
                    {
                        string toPrint = car.Model.ToString() + " " + car.Description.ToString();
                        ModelBox.Items.Add(toPrint);
                        //adding the car model and description to model and description array.
                        models.Add(car.Model.ToString());
                        descriptions.Add(car.Description.ToString());
                    }
                }
            }
        }

        private void ModelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //getting the model & description based on what has been selected.
            string model = models[ModelBox.SelectedIndex];
            string description = descriptions[ModelBox.SelectedIndex];
            string manufactorer = "";
            /*If the maufacturer is selected CarBox is null then we have sorted the cars by MPG or
             something similar.*/
            if (CarBox.SelectedIndex != -1)
            {

                //if we;re not using All then get the manufacturer from the elementat
                if (CarBox.SelectedItem.ToString() != "All")
                {
                    //getting the manufactorer of the car.
                    manufactorer = CarBox.SelectedItem.ToString();
                }
                //else the manufacturer will be the Car objects manufactorer.
                else
                {
                    if (orderedCars.Count != 0)
                    {
                        manufactorer = orderedCars.ElementAt(ModelBox.SelectedIndex).Manufacturer;
                    }
                    else
                    {
                        if(modelCars.Count != 0)
                        {
                            manufactorer = modelCars.ElementAt(ModelBox.SelectedIndex).Manufacturer;
                        }
                    }
                }
            }
            /*We have potentially sorted by MPG.*/
            else
            {

                /*If we have sorted by MPG then all cars will be displayed in the ModelBox
                 Drop down menu.*/
                manufactorer = orderedCars.ElementAt(ModelBox.SelectedIndex).Manufacturer;

            }

            searchedCar = listReader.findCar(model, manufactorer, description, cars);

            if (searchedCar == null)
            {
                TaxCalculator tax = new TaxCalculator();
                float? taxCost = tax.CalculateTax(searchedCar);
                OverviewText.Text = ModelBox.SelectedIndex.ToString();
                //getting the model based on what was selected.
                OverviewText.Text = model + "\n" + description + "\n" + manufactorer + "\n";
            } else
            {
                TaxCalculator tax = new TaxCalculator();
                float? taxCost = tax.CalculateTax(searchedCar);
                CarPrinter printer = new CarPrinter();
                OverviewText.Text = printer.printcar(searchedCar, Properties.Settings.Default.ImperialOrMetric);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveCar save = new SaveCar();
            Console.WriteLine(year);
            /*If the all button is not active then use the year that's been selected
             from the drop down menu*/
            if (year != "All")
            {
                SaveText.Text = save.Save(searchedCar, year);
            }
            /*Else the all button has been selected, in this case get the JSON year of the car 
             thats in the Car object, and use this instead*/
            else
            {
                SaveText.Text = save.Save(searchedCar, searchedCar.carJSONYear);
            }
        }

        //when we hover over a button the selecter will go to this location.
        private void SaveButton_MouseHover(object sender, EventArgs e)
        {
            SelectedButton.Visible = true;

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

        //if the users mouse has left the side bar set the users selected button to this activity.
        private void SideBarPanel_MouseLeave(object sender, EventArgs e)
        {
            while (SelectedButton.Location.Y != AddCarButton.Location.Y)
            {

                if (SelectedButton.Location.Y > AddCarButton.Location.Y)
                    SelectedButton.Location = new Point(SelectedButton.Location.X, SelectedButton.Location.Y - 1);
                else
                    SelectedButton.Location = new Point(SelectedButton.Location.X, SelectedButton.Location.Y + 1);
            }
        }

        private void OverviewButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overview overview = new Overview();
            overview.Closed += (s, args) => this.Close();
            overview.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compare compare = new Compare();
            compare.Closed += (s, args) => this.Close();
            compare.Show();
        }

        /*When the Confirm year button is pressed we want to change
         the contents of the boxes to be the cars of the year chosen e.g.
         from 2017 to 2015.*/
        private void ConfirmYearButton_Click(object sender, EventArgs e)
        {
            //if the user has selected a year.
            if(YearBox.SelectedIndex != -1)
            {


                    //the year that the user has selected.
                    string selectedYear = YearBox.SelectedItem.ToString();
                    JsonReader json = new JsonReader(selectedYear);
                    //cars = json.getCars();

                    //setting the year to be the year that was selected.
                    year = selectedYear;

                    drawListBox(json);

            }
        }



        /*When the MPGSort button is clicked we will call the Order class which
         will sort the list by the lowest MPG.*/
        private void MPGSort_Click(object sender, EventArgs e)
        {
            Order order = new Order();

            //CarBox.Items.Clear();
            ModelBox.Items.Clear();
            models.Clear();
            descriptions.Clear();
            orderedCars.Clear();


            orderedCars = order.orderByMPG(modelCars);
            modelCars.Clear();

            foreach (Car car in orderedCars)
            {
                ModelBox.Items.Add(car.Model.ToString() + " " + car.Description.ToString());
                models.Add(car.Model.ToString());
                modelCars.Add(car);
                descriptions.Add(car.Description.ToString());
            }
        }

        /*When the MPGSort button is clicked we will call the Order class which
        will sort the list by the highest MPG.*/
        private void button1_Click_1(object sender, EventArgs e)
        {
            Order order = new Order();

            //CarBox.Items.Clear();
            ModelBox.Items.Clear();
            models.Clear();
            descriptions.Clear();
            orderedCars.Clear();

            orderedCars = order.orderByMPGDescending(modelCars);
            modelCars.Clear();

            foreach (Car car in orderedCars)
            {
                ModelBox.Items.Add(car.Model.ToString() + " " + car.Description.ToString());
                models.Add(car.Model.ToString());
                modelCars.Add(car);
                descriptions.Add(car.Description.ToString());
            }
        }

        /*When the petrol button is clicked a call to the removeallbutpetrol
         function in the Order class will be called which will
         only display the petrol cars to the user.*/
        private void PetrolButton_Click(object sender, EventArgs e)
        {
            Order order = new Order();

            //CarBox.Items.Clear();
            ModelBox.Items.Clear();
            models.Clear();
            descriptions.Clear();

            orderedCars = order.RemoveAllButSpecified(orderedCars, "Petrol");
            //modelCars.Clear();

            foreach (Car car in orderedCars)
            {
                ModelBox.Items.Add(car.Model.ToString() + " " + car.Description.ToString());
                models.Add(car.Model.ToString());
                //modelCars.Add(car);
                descriptions.Add(car.Description.ToString());
            }
        }

        private void HybridButton_Click(object sender, EventArgs e)
        {
            Order order = new Order();

            //CarBox.Items.Clear();
            ModelBox.Items.Clear();
            models.Clear();
            descriptions.Clear();

            orderedCars = order.RemoveAllButSpecified(orderedCars, "Hybrid");
            //modelCars.Clear();

            foreach (Car car in orderedCars)
            {
                ModelBox.Items.Add(car.Model.ToString() + " " + car.Description.ToString());
                models.Add(car.Model.ToString());
                //modelCars.Add(car);
                descriptions.Add(car.Description.ToString());
            }
        }

        private void DieselButton_Click(object sender, EventArgs e)
        {
            Order order = new Order();

            //CarBox.Items.Clear();
            ModelBox.Items.Clear();
            models.Clear();
            descriptions.Clear();

            orderedCars = order.RemoveAllButSpecified(orderedCars, "Diesel");
            //modelCars.Clear();

            foreach (Car car in orderedCars)
            {
                ModelBox.Items.Add(car.Model.ToString() + " " + car.Description.ToString());
                models.Add(car.Model.ToString());
                //modelCars.Add(car);
                descriptions.Add(car.Description.ToString());
            }
        }

        private void ElectricButton_Click(object sender, EventArgs e)
        {
            Order order = new Order();

            //CarBox.Items.Clear();
            ModelBox.Items.Clear();
            models.Clear();
            descriptions.Clear();

            orderedCars = order.RemoveAllButSpecified(orderedCars, "Electricity");
            //modelCars.Clear();

            foreach (Car car in orderedCars)
            {
                ModelBox.Items.Add(car.Model.ToString() + " " + car.Description.ToString());
                models.Add(car.Model.ToString());
                //modelCars.Add(car);
                descriptions.Add(car.Description.ToString());
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Init init = new Init();
            init.Show();
        }

        /*When the load car button is clicked we will send over the selected car
         to the CarDetails form which will display all the cars information.*/
        private void LoadCar_Click(object sender, EventArgs e)
        {
            /*Getting CarOverview, which is a class that specialises in displaying
             all necessary items to be displayed.*/
            CarOverview overview = new CarOverview();
            overview.OpenCarDetails(searchedCar);
        }
    }
}
