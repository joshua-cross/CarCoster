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

        //creating a list for all the car models, and the car descriptions
        List<string> models = new List<string>();
        List<string> descriptions = new List<string>();

        //the final car.
        Car searchedCar;

        public Form1()
        {
            InitializeComponent();
        }

        /*When the program initially loads we want to load an image.*/
        private void Form1_Load(object sender, EventArgs e)
        {
            string thisDirectory = Directory.GetCurrentDirectory().ToString();
            string fileLoc = thisDirectory + @"\Images\LeafIcon.png";

            JsonReader json = new JsonReader();
            drawListBox(json);



            pictureBox1.Image = Image.FromFile(fileLoc);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Title.Text = fileLoc;
        }

        private void drawListBox(JsonReader json)
        {
            cars = json.getCars();
            try
            {
                foreach (Car car in cars)
                {
                    //the manufactorer.
                    string theManufactorer = car.Manufacturer;
                    //boolean that checks if the current manufactorer is unique or not.
                    bool isNew = true;
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
            
            /*The manufactorer that has been selected by the CarBox*/
            string manufactorer = CarBox.SelectedItem.ToString();
            /*Getting the models*/
            //contstructor that takes in a manufactorer and searches the array for cars that match the manufactorer.
            Title.Text = manufactorer;

            carModels = listReader.searchCars(cars, manufactorer);

            Title.Text = carModels.Count().ToString();

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
                descriptions.Add(car.Description.ToString());
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

                //Title.Text = MakeBox.Text.ToLower();
                Title.Text = searchedMakes.Count().ToString();
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
                descriptions.Clear();

                //using the CarListReader to search the Json file for the search result.
                IEnumerable<Car> searchedModels = listReader.searchModels(carModels, ModBox.Text);
                //searching the description for what has been typed.
                IEnumerable<Car> searchedDescription = listReader.searchDescriptions(carModels, ModBox.Text);
                //creating a list that contains both searchModels and searchedDescription
                IEnumerable<Car> allSearches = searchedModels.Concat(searchedDescription);
                Title.Text = ModBox.Text.ToLower();
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
            //getting the manufactorer of the car.
            string manufactorer = CarBox.SelectedItem.ToString();

            searchedCar = listReader.findCar(model, manufactorer, description, cars);

            if (searchedCar == null)
            {

                OverviewText.Text = ModelBox.SelectedIndex.ToString();
                //getting the model based on what was selected.
                OverviewText.Text = model + "\n" + description + "\n" + manufactorer + "\n";
            } else
            {
                CarPrinter printer = new CarPrinter();
                OverviewText.Text = printer.printcar(searchedCar);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveCar save = new SaveCar();
            SaveText.Text = save.Save(searchedCar);
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
    }
}
