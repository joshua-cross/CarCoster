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
        public List<Car> orderByMPG(List<Car> cars)
        {
            List<Car> orderedCars = cars;

            orderedCars = removeElectricAndInvalidCars(orderedCars);

            orderedCars = orderedCars.OrderBy(d => d.ImperialCombined).ToList();

            return orderedCars;
        }

        /*Function that sorts the given cars by the highest MPG.*/
        public List<Car> orderByMPGDescending(List<Car> cars)
        {
            List<Car> orderedCars = cars;

            orderedCars = removeElectricAndInvalidCars(orderedCars);

            orderedCars = orderedCars.OrderByDescending(d => d.ImperialCombined).ToList();

            return orderedCars;
        }

        /*Function that will remove all cars that are not petrol from the list*/
        public List<Car> RemoveAllButPetrol(List<Car> cars)
        {
            string targetFuel = "Petrol";

            List<Car> newCars = new List<Car>();

            /*Going through all the cars that the user is sent, and adding only
             the petrol cars to the new array.*/
            for (int i = 0; i < cars.Count; i = i + 1) {

                /*If the car is petrol then we will add this to the new array.*/
                if(cars[i].FuelType.Equals(targetFuel))
                {
                    newCars.Add(cars[i]);
                }

            }

            return newCars;
        }

        /*Function that removes cars from the list if they do not contain both a metric
         combined MPG and a imperial combined MPG.*/
        private List<Car> removeElectricAndInvalidCars(List<Car> cars)
        {

            string electric = "Electricity";

            List<Car> newCars = new List<Car>();


            for (int i = 0; i < cars.Count; i = i + 1)
            {


                /*If the car has either a null imperial combined, or
                 null metric combined then remove it from the list.*/
                if (cars[i].ImperialCombined == null
                    || cars[i].MetricCombined == null
                    || cars[i].ImperialCombined == 0
                    || cars[i].MetricCombined == 0
                    || cars[i].FuelType.ToLower().Equals(electric.ToLower()))
                {
                   
                }
                //else add this to a new list so we can return this.
                else
                {
                    newCars.Add(cars[i]);
                }
            }

            //return the completed list.
            return newCars;
        }
    }
}
