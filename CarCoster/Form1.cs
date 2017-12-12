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

            /*List of string that will hold each of the unique manufactorers.*/
            List<string> manufactorers = new List<string>();
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

        /*Function for when an item is selected in the CarBox.*/
        private void CarBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelBox.Items.Clear();
            
            /*The manufactorer that has been selected by the CarBox*/
            string manufactorer = CarBox.SelectedItem.ToString();
            /*Getting the models*/
            //contstructor that takes in a manufactorer and searches the array for cars that match the manufactorer.
            Title.Text = manufactorer;

            List<string> models = new List<string>();

            IEnumerable<Car> newCars = cars.Where(car => car.Manufacturer == manufactorer);

            Title.Text = newCars.Count().ToString();

            foreach (var car in newCars)
            {
                ModelBox.Items.Add(car.Model.ToString());
            }

        }

    }
}
