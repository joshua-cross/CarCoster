using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCoster
{
    class CarListReader
    {
        /*Function that searches the array with the parameter given
         and then creates a new list with the results from the search.*/
        public IEnumerable<Car> searchCars(IEnumerable<Car> cars, string searchCriteria)
        {
            IEnumerable<Car> newCars = cars.Where(car => car.Manufacturer == searchCriteria);
            return newCars;
        }

        /*Takes in an array of cars and searches its models then returns the output*/
        public IEnumerable<Car> searchModels(IEnumerable<Car> cars, string searchCriteria)
        {
            IEnumerable<Car> newCars = cars.Where(car => car.Model.ToLower().Contains(searchCriteria.ToLower()));
            return newCars;
        }

        /*Takes in an array of cars and searches its descirption and returns the output*/
        public IEnumerable<Car> searchDescriptions(IEnumerable<Car> cars, string searchCriteria)
        {
            IEnumerable<Car> newCars = cars.Where(car => car.Description.ToLower().Contains(searchCriteria.ToLower()));
            return newCars;
        }

        /*Function that gets each unique manufacturer from the list of cars and returns them*/
        public List<string> GetManufacturers(IEnumerable<Car> cars)
        {
            List<string> manufacturers = new List<string>();

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
                    foreach (string manufactorer in manufacturers)
                    {
                        if (car.Manufacturer.Equals(manufactorer))
                        {
                            //setting is new to false at it already exists in the array.
                            isNew = false;
                            break;
                        }
                    }

                    //if the manufactorer is new then add to the array and the list.
                    if (isNew)
                    {
                        manufacturers.Add(car.Manufacturer);
                    }

                }

                return manufacturers;
            }
            catch (Exception error)
            {

                return null;

            }
        }

        /*Takes in the selected data from the form (manufactorer/model and description) and
         finds the full car from this.*/
        public Car findCar(string model, string manufactorer, string description, IEnumerable<Car> cars)
        {
            try
            {
                Car car = cars.First(c => c.Manufacturer.ToLower().Equals(manufactorer.ToLower())
                                   && c.Model.ToLower().Equals(model.ToLower())
                                   && c.Description.ToLower().Equals(description.ToLower()));

                return car;
            } catch
            {
                return null;
            }

            
        }

        /*Functionm that searches a string array with the paramters given
         then creates a new list with the results from the search*/
        public IEnumerable<string> searchString(IEnumerable<string> model, string searchCriteria)
        {
            List<string> searchResult = new List<string>();

            /*Going through the list sent through the users.*/
            foreach(string currModel in model)
            {
                /*Comparing what the user has typed to the currentModel in the array
                 and setting them both to lower case to avoid errors.*/
                if (currModel.ToLower().Contains(searchCriteria.ToLower()))
                {
                    searchResult.Add(currModel);
                }
            }

            return searchResult;
        }

    }
}
