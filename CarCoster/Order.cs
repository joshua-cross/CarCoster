using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCoster
{
    class Order
    {
        /*Function that sorts the given cars by the lowest MPG's*/
        public IEnumerable<Car> orderByMPG(IEnumerable<Car> cars)
        {
            IEnumerable<Car> orderedCars = cars;

            orderedCars = removeElectricAndInvalidCars(orderedCars);

            orderedCars = orderedCars.OrderBy(d => d.ImperialCombined).ToList();

            return orderedCars;
        }

        /*Function that sorts the given cars by the highest MPG.*/
        public IEnumerable<Car> orderByMPGDescending(IEnumerable<Car> cars)
        {
            IEnumerable<Car> orderedCars = cars;

            orderedCars = removeElectricAndInvalidCars(orderedCars);

            orderedCars = orderedCars.OrderByDescending(d => d.ImperialCombined).ToList();

            return orderedCars;
        }

        /*Function that will remove all cars that are not petrol from the IEnumerable*/
        public IEnumerable<Car> RemoveAllButSpecified(IEnumerable<Car> cars, string targetFuel)
        {

            List<Car> newCars = new List<Car>();


            /*Only do the following if the car is not a hybrid
             as hybrids can contain both petrol or diesel which
             would cause issues when checking for just these.*/
            if (!targetFuel.Equals("Hybrid"))
            {
                /*Going through all the cars that the user is sent, and adding only
                 the petrol cars to the new array.*/
                for (int i = 0; i < cars.Count(); i = i + 1)
                {

                    /*If the car is petrol then we will add this to the new array.*/
                    if (cars.ElementAt(i).FuelType.Equals(targetFuel))
                    {
                        newCars.Add(cars.ElementAt(i));
                    }

                }
            } else
            {
                /*Going through all the cars that the user is sent, and adding only
                the petrol cars to the new array.*/
                for (int i = 0; i < cars.Count(); i = i + 1)
                {

                    /*If the car is petrol then we will add this to the new array.*/
                    if (cars.ElementAt(i).FuelType.Contains(targetFuel)
                        || cars.ElementAt(i).FuelType.Contains("Electricity /"))
                    {
                        newCars.Add(cars.ElementAt(i));
                    }

                }
            }

            return newCars;
        }

        /*Function that removes cars from the IEnumerable if they do not contain both a metric
         combined MPG and a imperial combined MPG.*/
        private IEnumerable<Car> removeElectricAndInvalidCars(IEnumerable<Car> cars)
        {

            string electric = "Electricity";

            List<Car> newCars = new List<Car>();


            for (int i = 0; i < cars.Count(); i = i + 1)
            {


                /*If the car has either a null imperial combined, or
                 null metric combined then remove it from the IEnumerable.*/
                if (cars.ElementAt(i).ImperialCombined == null
                    || cars.ElementAt(i).MetricCombined == null
                    || cars.ElementAt(i).ImperialCombined == 0
                    || cars.ElementAt(i).MetricCombined == 0
                    || cars.ElementAt(i).FuelType.ToLower().Equals(electric.ToLower()))
                {
                   
                }
                //else add this to a new IEnumerable so we can return this.
                else
                {
                    newCars.Add(cars.ElementAt(i));
                }
            }

            //return the completed IEnumerable.
            return newCars;
        }
    }
}
