using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCoster
{
    /*Class that contains properties for the car that needs to be displayed
     (the image for the cars label if it exists, and the string from the 
     car printer.)*/
    public class CarToBeDisplayed
    {
        //all the details about the car.
        public string carDetails { get; set; }
        //the model,manufacturer and description of the car.
        public string carHeader { get; set; }
        //the URL for the manufacturers badge.
        public string imageURL { get; set; }
    }

    class CarOverview
    {

        /*Function that's called by The AddCar button which launches
         the car Details form with all the information from the car.*/
         public void OpenCarDetails(Car car)
        {
            CarToBeDisplayed displayed = detailsToBeDisplayed(car);
            CarDetails details = new CarDetails(displayed);
            details.Show();
        }

        /*Function that gets all the details for the car, including the
         image for the car, and all the cars details.*/
         public CarToBeDisplayed detailsToBeDisplayed(Car car)
        {
            //The information that we will return to the user,
            CarToBeDisplayed displayed = new CarToBeDisplayed();

            //getting the car printer so we can get the cars that need printing.
            CarPrinter printer = new CarPrinter();
            /*Setting the header and details to be the printers equivelent.*/
            displayed.carDetails = printer.printcar(car, Properties.Settings.Default.ImperialOrMetric);
            displayed.carHeader = printer.carHeader(car);

            //Getting the carbadge class so we send the image url to the class.
            CarBadge badge = new CarBadge();
            displayed.imageURL = badge.getBadge(car.Manufacturer);

            return displayed;
        }
    }
}
