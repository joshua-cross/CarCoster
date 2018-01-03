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
                //JsonReader json = new JsonReader();
                List<Car> cars = new List<Car>();
               // cars = json.getCars();


                //creating a list of cars which will be displayed to the users.
                List<Car> usersCars = new List<Car>();
                CarListReader reader = new CarListReader();
                
                /*Getting each of the years that we saved so we know
                 which one of the JSON files we should open to find the specific saved car.*/
                 
                 for(int i = 0; i < Properties.Settings.Default.Years.Count; i++)
                {
                    string year = Properties.Settings.Default.Years[i];

                    //Loading the JSON reader for the given year.
                    JsonReader json = new JsonReader(year);

                    //Getting the list of cars for this year.
                    List<Car> theCars = new List<Car>();
                    theCars = json.getCars();

                    //searching for the car based on the same properties.
                    Car car = reader.findCar(Properties.Settings.Default.Models[i],
                                             Properties.Settings.Default.Manufacturers[i],
                                             Properties.Settings.Default.Descriptions[i], theCars);
                    //adding the car that we've just found to the list of cars.
                    usersCars.Add(car);
                }
                 


                 
                //Going around a loop for as many cars the user has saved (maximum 5.)
                /*
                for (int i = 0; i < Properties.Settings.Default.Models.Count; i++)
                {
                    //searching for the car based on the same properties.
                    Car car = reader.findCar(Properties.Settings.Default.Models[i],
                                             Properties.Settings.Default.Manufacturers[i],
                                             Properties.Settings.Default.Descriptions[i], cars);

                    //adding the car that we've just found to the list of cars.
                    usersCars.Add(car);

                }
                */
                



                return usersCars;
            }
            //else return null as there is no saved car.
            else
            {
                return null;
            }

            
        }

        /*Function that gets the car that has been selected (Car that user
         * has pressed select on) and returns the Car object for this.*/
        public Car LoadSelectedCar()
        {
            Car car;

            //if a saved car already exists.
            if ((Properties.Settings.Default.Manufacturer != null && Properties.Settings.Default.Manufacturer != "") &&
                (Properties.Settings.Default.Model != null && Properties.Settings.Default.Model != "") &&
                (Properties.Settings.Default.Description != null && Properties.Settings.Default.Description != "") &&
                (Properties.Settings.Default.Year != null && Properties.Settings.Default.Year != ""))
            {
                //getting the list of cars from the Json file.
                JsonReader json = new JsonReader(Properties.Settings.Default.Year);
                List<Car> cars = new List<Car>();
                cars = json.getCars();


                //creating a list of cars which will be displayed to the users.
                List<Car> usersCars = new List<Car>();
                CarListReader reader = new CarListReader();

                //getting the car.
                car = reader.findCar(Properties.Settings.Default.Model,
                                    Properties.Settings.Default.Manufacturer,
                                    Properties.Settings.Default.Description, cars);


            }
            //else there is no car so null car and return.
            else
            {
                car = null;
            }


            return car;
        }
    }
}
