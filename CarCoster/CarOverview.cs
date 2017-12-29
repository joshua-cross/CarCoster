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
    class CarToBeDisplayed
    {
        public string carDetails { get; set; }
        public string imageURL { get; set; }
    }

    class CarOverview
    {
        /*Function that's called by The AddCar button which launches
         the car Details form with all the information from the car.*/
         public void OpenCarDetails(Car car)
        {

        }

        /*Function that gets all the details for the car, including the
         image for the car, and all the cars details.*/
         public CarToBeDisplayed detailsToBeDisplayed(Car car)
        {
            
        }
    }
}
