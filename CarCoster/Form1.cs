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

        /*a boolean that indicated if we want to sort by ascending or descending order
         true = ascending, false = descending*/
        bool ordering = true;

        /*A Listed object that will contain the current cars and the manifacturers*/
        Listed carList = new Listed();

        PopulateListBox listBoxes = new PopulateListBox();

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Listed theCarList)
        {
            carList = theCarList;
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

            /*Populating the CarBox list box with all the manufacturers.*/
            listBoxes.PopulateListBoxWithManufacturers(CarBox, carList.Manufacturers);
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

            /*Clearing the unecessary lists in the carList.*/
            carList = carList.ClearLists(carList);

            //clearing the models and descriptions, as new items are present.
            models.Clear();
            descriptions.Clear();
            modelCars.Clear();
            orderedCars.Clear();

            /*The manufactorer that has been selected by the CarBox*/
            string manufactorer = CarBox.SelectedItem.ToString();

            listBoxes.ManufactuerSelected(ModelBox, manufactorer, carList, LogoBox);
        }

        /*When the user types something into the manufactuer textbox, then clear the existing
         list of manufacturers and repopulate with the searched manufacturers.*/
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //clearning the CarBox so we can repopulate it.
            clearListBox(CarBox);
            //clearing the modbox search box as we are no longer on the same manufactorer.
            ModBox.Text = "";
            //clearing the ModelBox as we are not longer on the same manufactorer.
            clearListBox(ModelBox);

            /*Searching for manufacturers based on what was typed into the MakeBox TexbBox.*/
            carList = listBoxes.UpdateManufacturersThroughSearch(MakeBox, carList, CarBox);

            
        }

        private void ModBox_TextChanged(object sender, EventArgs e)
        {
            //clearing the ModelBox so we can replace it with the searched models.
            clearListBox(ModelBox);

            //clearing the models and descriptions, as new items are present.
            models.Clear();
            modelCars.Clear();
            descriptions.Clear();
            orderedCars.Clear();

            carList = listBoxes.UpdatedModelsThroughSearch(ModBox, carList, ModelBox);
        }

        private void ModelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            carList = listBoxes.ModelSelected(ModelBox.SelectedIndex, carList);
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
            ordering = true;
            listBoxes.OrderedCars(carList.CurrentCars, ordering, ModelBox);
        }

        /*When the MPGSort button is clicked we will call the Order class which
        will sort the list by the highest MPG.*/
        private void button1_Click_1(object sender, EventArgs e)
        {
            ordering = false;
            listBoxes.OrderedCars(carList.CurrentCars, ordering, ModelBox);
        }

        /*When the petrol button is clicked a call to the removeallbutpetrol
         function in the Order class will be called which will
         only display the petrol cars to the user.*/
        private void PetrolButton_Click(object sender, EventArgs e)
        {
            carList.CurrentCars = listBoxes.ShowOnlySelectedFuelType("Petrol", ModelBox, carList.CurrentCars);
        }

        private void HybridButton_Click(object sender, EventArgs e)
        {
            carList.CurrentCars = listBoxes.ShowOnlySelectedFuelType("Hyrbid", ModelBox, carList.CurrentCars);
        }

        private void DieselButton_Click(object sender, EventArgs e)
        {
            carList.CurrentCars = listBoxes.ShowOnlySelectedFuelType("Diesel", ModelBox, carList.CurrentCars);
        }

        private void ElectricButton_Click(object sender, EventArgs e)
        {
            carList.CurrentCars = listBoxes.ShowOnlySelectedFuelType("Electricity", ModelBox, carList.CurrentCars);
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
            overview.OpenCarDetails(carList.SelectedCar);
        }
    }

    /*Class that contains all the properties that need to be printed.*/
    public class Listed
    {
        /*The complete list of cars that can be displayed.*/
        public IEnumerable<Car> Cars { get; set; }
        /*The cars from the manufacturer*/
        public IEnumerable<Car> CarsFromManufacturer { get; set; }
        /*The current list of cars in the list (after sorting, restrictions etc.)*/
        public IEnumerable<Car> CurrentCars { get; set; }
        /*The list of car manufacturers in a given year.*/
        public IEnumerable<string> Manufacturers { get; set; }
        /*List for the searched manufacturers*/
        public IEnumerable<string> searchedManufacturers { get; set; }
        /*The car that the user has selected.*/
        public Car SelectedCar { get; set; }

        public Listed DefaultForm1ToLoad()
        {
            CarListReader reader = new CarListReader();

            Listed list = new Listed();

            /*Setting the cars in JSON reader to be that of the most recent year.*/
            JsonReader json = new JsonReader();

            /*Getting the list of cars from json.*/
            list.Cars = json.getCars();

            list.Manufacturers = reader.GetManufacturers(list.Cars);

            list.searchedManufacturers = list.Manufacturers;

            return list;

        }

        /*Function that clears all the uncecessary lists when they are not needed.*/
        public Listed ClearLists(Listed list)
        {


            return list;
        }
    }
}
