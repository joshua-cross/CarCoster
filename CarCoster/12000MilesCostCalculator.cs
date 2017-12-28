using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCoster
{
    class _12000MilesCostCalculator
    {
        /*Function that will be used to calculate the actual cost to
         run the cars per 12000 miles, as the JSON file given
         goes off the fuel prices at the time. e.g. the file
         2000.json used fuel prices from the year 2000 and are very out
         of date now.*/
        public float? CostPer12000Miles(Car car)
        {
            /*If the car has got a legitimate ImperialCombined MPG then
             we will calculate the cost for 12000 miles.*/
            if (car.ImperialCombined != null)
            {
                double litresInAGallon = GetLitresInAGallon();
                double costOfFuelPerGallonInPence = costPerGallon(litresInAGallon);
                double gallonsNeededFor12000Miles = GallonsNeededPer12000Miles(car.ImperialCombined);

                /*Calculating the cost (in pence) per 12000 miles travelled.*/
                double costPer12000Miles = costOfFuelPerGallonInPence * gallonsNeededFor12000Miles;
                /*converting this to pounds*/
                costPer12000Miles = costPer12000Miles / 100;
                /*Rounding to the nearest 2 decimal places.*/
                costPer12000Miles = Math.Round(costPer12000Miles, 2);

                float? cost = (float?) costPer12000Miles;

                car.ActualCostPer12000Miles = cost;

                return cost;
            }
            /*If the ImperialCombined variable is null this means
             that either the car is not valid, or it's an electric car
             in either case this means we cannot complete the calculation
             so return null so the value is not printed.*/
            else
            {
                return null;
            }
        }

        /*Function that calculates and returns how many litres
         are needed to create 1 gallon.*/
        private double GetLitresInAGallon()
        {

            //how size of 1 gallon.
            double gallon = 1;

            //the size of a litre compared to a gallon.
            double litresToGallons = 0.22;

            //how many litres are in a gallon.
            double litresInAGallon;

            /*dividing the gallon by litresToGallons to provde us with how
             many litres are in a gallon.*/
            litresInAGallon = 1 / 0.22;

            return litresInAGallon;
        }

        /*Returns the cost of fuel per gallon.*/
        private double costPerGallon(double litresInAGallon)
        {
            decimal costOfFuelPerLitre = Properties.Settings.Default.FuelPrice;
            return litresInAGallon * (double) costOfFuelPerLitre;
        }


        private double GallonsNeededPer12000Miles(float? ImperialCombinedMPG)
        {
            int miles = 12000;
            double GallonsNeededPer12000Miles = miles / (float) ImperialCombinedMPG;
            return GallonsNeededPer12000Miles;
        }
    }
}
