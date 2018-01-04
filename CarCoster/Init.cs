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
    public partial class Init : Form
    {
        /*The form the created this form.*/
        Form parentForm;
       
        /*Constructor that sends through the form that created it as an object*/
        public Init(Form form)
        {
            parentForm = form;
        }

        public Init()
        {
            InitializeComponent();
        }

        /*function that takes in the listed object and alters 2 arrays:
         1. the cars from the specific manufacturer e.g. Ford as these are the currently
            selected cars that we wish to update
         2. All the cars so when the user swithces manufacturers these also show the corrected
            fuel costs.
         the program also requires the selected car, this is so we can update the current selected car. 
         then calculates the new MPGs using the Recalculate function and returns a ListedToPrint, which is
         a listed object with a printable string*/
        public ListedToPrint RecalculateMPG(Listed cars, Car selectedCar)
        {
            CarPrinter printer = new CarPrinter();

            /*Creating a new ListedToPrint object.*/
            ListedToPrint list = new ListedToPrint();

            /*The current cars we want to recalculate*/
            cars.CurrentCars = RecalculateCarList(cars.CurrentCars);
            cars.Cars = RecalculateCarList(cars.CurrentCars);

            list.ToPrint = "";
            try
            {
                /*Only do the following if the user has selected a car.*/
                if (selectedCar != null)
                {

                    /*Recalculating the cost of a single car.*/
                    selectedCar = RecalculateCar(selectedCar);


                    /*Getting all the cars details into a string*/
                    list.ToPrint = printer.carHeader(selectedCar) + printer.printcar(selectedCar,
                                   Properties.Settings.Default.ImperialOrMetric);

                }
            } catch(Exception error)
            {
                Console.WriteLine(error.ToString());
            } 

            return list;
        }

        /*Function that will be called when the Overview form opens this page
         it will take in the list of the users cars, and then recalculate the mpg for the selected cars
         and returns a CarsToPrint object which is a car list plus a string to print.*/
        public CarsToPrint RecalculateMPGSelected(IEnumerable<Car> selectedCars, Car selectedCar)
        {
            /*class that convers a cars details to a string.*/
            CarPrinter printer = new CarPrinter();

            /*Creating new CarsToPrint object.*/
            CarsToPrint cars = new CarsToPrint();

            selectedCars = RecalculateCarList(selectedCars);

            cars.ToPrint = "";
            try
            {
                /*If the user has a car selected.*/
                if (selectedCar != null)
                {
                    selectedCar = RecalculateCar(selectedCar);

                    /*Getting all the cars details into a string*/
                    cars.ToPrint = printer.carHeader(selectedCar) + printer.printcar(selectedCar,
                                   Properties.Settings.Default.ImperialOrMetric);
                }
            } catch(Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            return cars;
        }

        /*Function that recalculates an entire list full of cars.*/
        public IEnumerable<Car> RecalculateCarList(IEnumerable<Car> cars)
        {
            /*The class that calculates the cost of the car.*/
            _12000MilesCostCalculator cost = new _12000MilesCostCalculator();

            foreach(Car car in cars)
            {
                try
                {
                    car.ActualCostPer12000Miles = cost.CostPer12000Miles(car);
                } catch (Exception error)
                {
                    Console.WriteLine(error.ToString());
                }
            }

            return cars;
        }

        /*Function that recaluclates cost for a single car.*/
        public Car RecalculateCar(Car car)
        {
            /*The class that calculates the cost of the car.*/
            _12000MilesCostCalculator cost = new _12000MilesCostCalculator();

            try
            {
                car.ActualCostPer12000Miles = cost.CostPer12000Miles(car);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }

            return car;
        }

        /*Function that sets the setting FuelPrice when the confirm button is clicked
         the function checks if what the user has typed is valid ie. Not negative
         and rounds the number up to the second decimal point if the user has typed something such as
         3.456434*/
        private void ConfirmFuelPriceButton_Click(object sender, EventArgs e)
        {

            /*If what the user has typed is less than or equal to 0
             then this is not a valid fuel price so we will display
             an error message to the user.*/
            if (FuelUpDown.Value <= 0)
            {
                ConfirmError.SetError(FuelUpDown, "Invalid Fuel Price");
            }

            //decimal fuelCost = Math.Round(FuelUpDown.Value, 2);

            Properties.Settings.Default.PetrolPrice = (double) FuelUpDown.Value;

            /*If what the user has typed is less than or equal to 0
             then this is not a valid fuel price so we will display
             an error message to the user.*/
            if (FuelUpDown.Value <= 0)
            {
                ConfirmError.SetError(DieselUpDown, "Invalid Fuel Price");
            }

            //decimal dieselCost = Math.Round(DieselUpDown.Value, 2);

            Properties.Settings.Default.DieselPrice = (double) DieselUpDown.Value;

            /*The value the user has selected
             0 = Imperial
             1 = Metric
             */
            int value = ImperialOrMetric.Value;
            /*If the value is imperial then we will set the mesurement system
             to be true*/
            if (value == 0)
            {
                Properties.Settings.Default.ImperialOrMetric = true;
            }
            /*Else the value is metric so we will set the measurement system
             to be false.*/
            else
            {
                Properties.Settings.Default.ImperialOrMetric = false;
            }

            Properties.Settings.Default.Save();

            this.Close();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Init_Load(object sender, EventArgs e)
        {
            double petrolPrice = Properties.Settings.Default.PetrolPrice;
            double dieselPrice = Properties.Settings.Default.DieselPrice;
            bool measurementSystem = Properties.Settings.Default.ImperialOrMetric;

            /*when the page is loaded ensure that we're displayed the saved
            fuel price.*/
            FuelUpDown.Value = (decimal) Properties.Settings.Default.PetrolPrice;
            DieselUpDown.Value = (decimal) Properties.Settings.Default.DieselPrice;

            /*If the measurement system is true (imperial) then the value of the up down is 0
             else the measurement system is false (metric) then the value of the up down is 1.*/
             if(measurementSystem)
            {
                ImperialOrMetric.Value = 0;
            } else
            {
                ImperialOrMetric.Value = 1;
            }
        }

        private void ImperialOrMetric_Scroll(object sender, EventArgs e)
        {
            label1.Text = ImperialOrMetric.Value.ToString();
        }
    }

    /*class that will be used by the compare and the addcar form
     that contains the listed object and the string we want to print*/
    public class ListedToPrint
    {
        public Listed CarList { get; set; }
        public string ToPrint { get; set; }
    }

    /*class that will be used by the overview class that contains
     the list of cars and the new string that we wish to print.*/
    public class CarsToPrint
    {
        public IEnumerable<Car> cars { get; set; }
        public string ToPrint { get; set; }
    }
}
