using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCoster
{
    class LoadCar
    {
        /*Loading the car from the json file based on the strings that was saved to Settings.*/
        public Car Load()
        {

            //if there are properties saved.
            if (Properties.Settings.Default.Model != null &&
               Properties.Settings.Default.Manufacturer != null &&
               Properties.Settings.Default.Description != null)
            {
                //getting the list of cars from the Json file.
                JsonReader json = new JsonReader();
                List<Car> cars = new List<Car>();
                cars = json.getCars();

                CarListReader reader = new CarListReader();
                //searching for the car based on the same properties.
                Car car = reader.findCar(Properties.Settings.Default.Model,
                                         Properties.Settings.Default.Manufacturer,
                                         Properties.Settings.Default.Description, cars);
                return car;
            }
            //else return null as there is no saved car.
            else
            {
                return null;
            }

            
        }
    }
}
