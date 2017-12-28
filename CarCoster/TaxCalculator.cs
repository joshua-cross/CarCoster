using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCoster
{
    class TaxCalculator
    {
        /*Function that takes in a car, then uses the CO2 emissions, and
         the fuel type of the vehicle to find the tax cost of the vehicle.
         This function is for cars that are registered after the date of 
         March 2017.*/
        public float? CalculateTax(Car car)
        {

            /*The 3 strings for alternativly fueled cars.*/
            string[] fuelTypes = new string[3];
            fuelTypes[0] = "Hybrid";
            fuelTypes[1] = "Electricity";
            fuelTypes[2] = "Electricity /";

            //float where the tax value will be stored.
            float fuelCost = -1.0f;

            /*If the car has a CO2 value then the car is valid.*/
            if(car.CO2gramsPerKilometer != null)
            {

                //the CO2 emissions of the vehicle
                float CO2 = (float) car.CO2gramsPerKilometer;

                //parsing the year of the car added to the database to an integer.
                int carYear = int.Parse(car.carJSONYear);

                List<TaxBrackets> taxBrackets = new List<TaxBrackets>();
                /*If the car is newer than 2017 then we will get the new taxes, else we will
                 use the old taxes.*/
                if(carYear >= 2017)
                {
                    taxBrackets = postMarch2017TaxBrackets();
                }
                /*Else the car is older than 2017 so use the old tax system.*/
                else
                {
                    taxBrackets = preMarch2017TaxBrackets();
                }
                /*If the cars f can calculate the tax like a normal car, else we need to do the
                     alterate fuel tax costing.*/
                if (!car.FuelType.Equals(fuelTypes[0]) &&
                   !car.FuelType.Equals(fuelTypes[1]) &&
                   !car.FuelType.Contains(fuelTypes[2]))
                {
                    foreach(TaxBrackets tax in taxBrackets)
                    {
                        if (CO2 >= tax.MinCO2 && CO2 <= tax.MaxCO2)
                            fuelCost = tax.TaxCost;
                    }
                }
                /*Else we are an alternate fuel so the alternate fuel calculations
                 will take place.*/
                else
                {
                    foreach (TaxBrackets tax in taxBrackets)
                    {
                        if (CO2 >= tax.MinCO2 && CO2 <= tax.MaxCO2)
                            fuelCost = tax.TaxCostAlternate;
                    }
                }


                
                   

                    

                car.TaxBand = fuelCost;
            }

            return fuelCost;
        }

        /*Function that returns the tax brackets for post March 2017*/
        public List<TaxBrackets> postMarch2017TaxBrackets()
        {
            List<TaxBrackets> taxBrackets = new List<TaxBrackets>()
            {
                new TaxBrackets()
                {
                    Id = 'A',
                    MinCO2 = 0,
                    MaxCO2 = 0,
                    TaxCost = 0,
                    TaxCostAlternate = 0
                },

                new TaxBrackets()
                {
                    Id = 'B',
                    MinCO2 = 1,
                    MaxCO2 = 50,
                    TaxCost = 10,
                    TaxCostAlternate = 0
                },

                new TaxBrackets()
                {
                    Id = 'C',
                    MinCO2 = 51,
                    MaxCO2 = 75,
                    TaxCost = 25,
                    TaxCostAlternate = 15
                },

                new TaxBrackets()
                {
                    Id = 'D',
                    MinCO2 = 76,
                    MaxCO2 = 90,
                    TaxCost = 100,
                    TaxCostAlternate = 90
                },

                new TaxBrackets()
                {
                    Id = 'E',
                    MinCO2 = 91,
                    MaxCO2 = 100,
                    TaxCost = 120,
                    TaxCostAlternate = 110
                },

                new TaxBrackets()
                {
                    Id = 'F',
                    MinCO2 = 101,
                    MaxCO2 = 110,
                    TaxCost = 140,
                    TaxCostAlternate = 130
                },

                new TaxBrackets()
                {
                    Id = 'G',
                    MinCO2 = 111,
                    MaxCO2 = 130,
                    TaxCost = 160,
                    TaxCostAlternate = 150
                },

                new TaxBrackets()
                {
                    Id = 'H',
                    MinCO2 = 131,
                    MaxCO2 = 150,
                    TaxCost = 200,
                    TaxCostAlternate = 190
                },

                new TaxBrackets()
                {
                    Id = 'I',
                    MinCO2 = 151,
                    MaxCO2 = 170,
                    TaxCost = 500,
                    TaxCostAlternate = 490
                },

                new TaxBrackets()
                {
                    Id = 'J',
                    MinCO2 = 171,
                    MaxCO2 = 190,
                    TaxCost = 800,
                    TaxCostAlternate = 790
                },

                new TaxBrackets()
                {
                    Id = 'K',
                    MinCO2 = 191,
                    MaxCO2 = 225,
                    TaxCost = 1200,
                    TaxCostAlternate = 1190
                },

                new TaxBrackets()
                {
                    Id = 'L',
                    MinCO2 = 226,
                    MaxCO2 = 255,
                    TaxCost = 1700,
                    TaxCostAlternate = 1690
                },

                new TaxBrackets()
                {
                    Id = 'M',
                    MinCO2 = 256,
                    MaxCO2 = float.MaxValue,
                    TaxCost = 2000,
                    TaxCostAlternate = 1990
                },
            };


            return taxBrackets;
        }

        /*Function that returns the tax brackets for pre March 2017*/
        public List<TaxBrackets> preMarch2017TaxBrackets()
        {
            List<TaxBrackets> taxBrackets = new List<TaxBrackets>()
            {
                new TaxBrackets()
                {
                    Id = 'A',
                    MinCO2 = 0,
                    MaxCO2 = 1000,
                    TaxCost = 0,
                    TaxCostAlternate = 0
                },

                new TaxBrackets()
                {
                    Id = 'B',
                    MinCO2 = 101,
                    MaxCO2 = 110,
                    TaxCost = 20,
                    TaxCostAlternate = 10
                },

                new TaxBrackets()
                {
                    Id = 'C',
                    MinCO2 = 111,
                    MaxCO2 = 120,
                    TaxCost = 30,
                    TaxCostAlternate = 20
                },

                new TaxBrackets()
                {
                    Id = 'D',
                    MinCO2 = 121,
                    MaxCO2 = 130,
                    TaxCost = 115,
                    TaxCostAlternate = 105
                },

                new TaxBrackets()
                {
                    Id = 'E',
                    MinCO2 = 131,
                    MaxCO2 = 140,
                    TaxCost = 115,
                    TaxCostAlternate = 105
                },

                new TaxBrackets()
                {
                    Id = 'F',
                    MinCO2 = 141,
                    MaxCO2 = 150,
                    TaxCost = 135,
                    TaxCostAlternate = 125
                },

                new TaxBrackets()
                {
                    Id = 'G',
                    MinCO2 = 151,
                    MaxCO2 = 165,
                    TaxCost = 190,
                    TaxCostAlternate = 180
                },

                new TaxBrackets()
                {
                    Id = 'H',
                    MinCO2 = 166,
                    MaxCO2 = 175,
                    TaxCost = 220,
                    TaxCostAlternate = 210
                },

                new TaxBrackets()
                {
                    Id = 'I',
                    MinCO2 = 176,
                    MaxCO2 = 185,
                    TaxCost = 240,
                    TaxCostAlternate = 230
                },

                new TaxBrackets()
                {
                    Id = 'J',
                    MinCO2 = 186,
                    MaxCO2 = 200,
                    TaxCost = 280,
                    TaxCostAlternate = 270
                },

                new TaxBrackets()
                {
                    Id = 'K',
                    MinCO2 = 201,
                    MaxCO2 = 225,
                    TaxCost = 305,
                    TaxCostAlternate = 295
                },

                new TaxBrackets()
                {
                    Id = 'L',
                    MinCO2 = 226,
                    MaxCO2 = 255,
                    TaxCost = 520,
                    TaxCostAlternate = 510
                },

                new TaxBrackets()
                {
                    Id = 'M',
                    MinCO2 = 256,
                    MaxCO2 = float.MaxValue,
                    TaxCost = 535,
                    TaxCostAlternate = 525
                },
            };


            return taxBrackets;
        }
    }
}
