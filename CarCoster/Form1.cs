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
            clearListBox(ModelBox);
            
            /*The manufactorer that has been selected by the CarBox*/
            string manufactorer = CarBox.SelectedItem.ToString();
            /*Getting the models*/
            //contstructor that takes in a manufactorer and searches the array for cars that match the manufactorer.
            Title.Text = manufactorer;

            carModels = listReader.searchCars(cars, manufactorer);

            Title.Text = carModels.Count().ToString();

            foreach (var car in carModels)
            {
                ModelBox.Items.Add(car.Model.ToString() + " " + car.Description.ToString());
            }

        }

        /*When the user types anything into the textbox repopulate */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(manufactorers.Count() != 0)
            {
                //clearning the modelbox so we can repopulate it.
                clearListBox(CarBox);

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
                }

                //if the user empties the search box then we want to refill the listbox with the array of models.
                if(ModBox.Text.Equals(""))
                {
                    foreach(Car car in carModels)
                    {
                        string toPrint = car.Model.ToString() + " " + car.Description.ToString();
                        ModelBox.Items.Add(toPrint);
                    }
                }
            }
        }
    }
}
