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
        public IEnumerable<Car> Load()
        {

            //if there are properties saved.
            if (Properties.Settings.Default.Models != null &&
               Properties.Settings.Default.Manufacturers != null &&
               Properties.Settings.Default.Descriptions != null)
            {
                //getting the list of cars from the Json file.
                JsonReader json = new JsonReader();
                List<Car> cars = new List<Car>();
                cars = json.getCars();


                //creating a list of cars which will be displayed to the users.
                List<Car> usersCars = new List<Car>();
                CarListReader reader = new CarListReader();

                //Going around a loop for as many cars the user has saved (maximum 5.)
                for (int i = 0; i < Properties.Settings.Default.Models.Count; i++)
                {
                    //searching for the car based on the same properties.
                    Car car = reader.findCar(Properties.Settings.Default.Models[i],
                                             Properties.Settings.Default.Manufacturers[i],
                                             Properties.Settings.Default.Descriptions[i], cars);

                    //adding the car that we've just found to the list of cars.
                    usersCars.Add(car);
                }



                return usersCars;
            }
            //else return null as there is no saved car.
            else
            {
                return null;
            }

            
        }
    }
}
