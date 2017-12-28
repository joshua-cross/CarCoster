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
         the fuel type of the vehicle to find the tax cost of the vehicle.*/
        public float? CalculateTax(Car car)
        {
            /*The 3 strings for alternativly fueled cars.*/
            string[] fuelTypes = new string[3];
            fuelTypes[0] = "Hybrid";
            fuelTypes[1] = "Electricity";
            fuelTypes[2] = "Electricity /";

            //float where the tax value will be stored.
            float fuelCost = 0.0f;

            /*If the car has a CO2 value then the car is valid.*/
            if(car.CO2gramsPerKilometer != null)
            {

                //the CO2 emissions of the vehicle
                float CO2 = (float) car.CO2gramsPerKilometer;

                /*If the cars fuel type is not one of the alternative fuel types
                 then we can calculate the tax like a normal car, else we need to do the
                 alterate fuel tax costing.*/
                if (!car.FuelType.Equals(fuelTypes[0]) &&
                   !car.FuelType.Equals(fuelTypes[1]) &&
                   !car.FuelType.Contains(fuelTypes[2]))
                {
                    /*If the CO2 is 0 then the tax payable is 0.*/
                    if (CO2 == 0)
                    {
                        fuelCost = 0.0f;
                    }
                    /*If the CO2 emissions are between 1 and 50 then the tax cost is £10*/
                    else if (CO2 >= 1 && CO2 <= 50)
                    {
                        fuelCost = 10.0f;
                    }
                    /*Else if the CO2 emissions are between 51 and 75 then the tax cost is 25*/
                    else if (CO2 >= 51 && CO2 <= 75)
                    {
                        fuelCost = 25.0f;
                    }
                    /*Else if the CO2 emissions are between 76 and 90 then the tax cost is 100*/
                    else if (CO2 >= 76 && CO2 <= 90)
                    {
                        fuelCost = 100.0f;
                    }
                    /*Else if the CO2 emissions are between 91 and 100 then the tax cost is 120*/
                    else if (CO2 >= 91 && CO2 <= 100)
                    {
                        fuelCost = 120.0f;
                    }
                    /*Else if the CO2 emissions are between 101 and 110 then the tax cost is 140*/
                    else if (CO2 >= 101 && CO2 <= 110)
                    {
                        fuelCost = 140.0f;
                    }
                    /*Else if the CO2 emissions are between 111 and 130 then the tax cost is 160*/
                    else if (CO2 >= 111 && CO2 <= 130)
                    {
                        fuelCost = 160.0f;
                    }
                    /*Else if the CO2 emissions are between 131 and 150 then the tax cost is 200*/
                    else if (CO2 >= 131 && CO2 <= 150)
                    {
                        fuelCost = 200.0f;
                    }
                    /*Else if the CO2 emissions are between 151 and 170 then the tax cost is 500*/
                    else if (CO2 >= 151 && CO2 <= 170)
                    {
                        fuelCost = 500.0f;
                    }
                    /*Else if the CO2 emissions are between 171 and 190 then the tax cost is 800*/
                    else if (CO2 >= 171 && CO2 <= 190)
                    {
                        fuelCost = 800.0f;
                    }
                    /*Else if the CO2 emissions are between 191 and 225 then the tax cost is 1200*/
                    else if (CO2 >= 191 && CO2 <= 225)
                    {
                        fuelCost = 1200.0f;
                    }
                    /*Else if the CO2 emissions are between 226 and 255 then the tax cost is 1700*/
                    else if (CO2 >= 226 && CO2 <= 255)
                    {
                        fuelCost = 1700.0f;
                    }
                    /*Else if the CO2 emissions are more then 255 then the tax cost is 2000*/
                    else if (CO2 > 255)
                    {
                        fuelCost = 2000.0f;
                    }
                    /*Else the CO2 is something invalid e.g. -5 therefore we will return -1.*/
                    else
                    {
                        fuelCost = -1.0f;
                    }
                }
                /*Else we are an alternate fuel so the alternate fuel calculations
                 will take place.*/
                else
                {
                    /*If the CO2 is 0 then the tax payable is 0.*/
                    if (CO2 == 0)
                    {
                        fuelCost = 0.0f;
                    }
                    /*If the CO2 emissions are between 1 and 50 then the tax cost is £0*/
                    else if (CO2 >= 1 && CO2 <= 50)
                    {
                        fuelCost = 0.0f;
                    }
                    /*Else if the CO2 emissions are between 51 and 75 then the tax cost is 15*/
                    else if (CO2 >= 51 && CO2 <= 75)
                    {
                        fuelCost = 15.0f;
                    }
                    /*Else if the CO2 emissions are between 76 and 90 then the tax cost is 90*/
                    else if (CO2 >= 76 && CO2 <= 90)
                    {
                        fuelCost = 90.0f;
                    }
                    /*Else if the CO2 emissions are between 91 and 100 then the tax cost is 110*/
                    else if (CO2 >= 91 && CO2 <= 100)
                    {
                        fuelCost = 110.0f;
                    }
                    /*Else if the CO2 emissions are between 101 and 110 then the tax cost is 130*/
                    else if (CO2 >= 101 && CO2 <= 110)
                    {
                        fuelCost = 130.0f;
                    }
                    /*Else if the CO2 emissions are between 111 and 130 then the tax cost is 150*/
                    else if (CO2 >= 111 && CO2 <= 130)
                    {
                        fuelCost = 150.0f;
                    }
                    /*Else if the CO2 emissions are between 131 and 150 then the tax cost is 190*/
                    else if (CO2 >= 131 && CO2 <= 150)
                    {
                        fuelCost = 190.0f;
                    }
                    /*Else if the CO2 emissions are between 151 and 170 then the tax cost is 490*/
                    else if (CO2 >= 151 && CO2 <= 170)
                    {
                        fuelCost = 490.0f;
                    }
                    /*Else if the CO2 emissions are between 171 and 190 then the tax cost is 790*/
                    else if (CO2 >= 171 && CO2 <= 190)
                    {
                        fuelCost = 790.0f;
                    }
                    /*Else if the CO2 emissions are between 191 and 225 then the tax cost is 1190*/
                    else if (CO2 >= 191 && CO2 <= 225)
                    {
                        fuelCost = 1190.0f;
                    }
                    /*Else if the CO2 emissions are between 226 and 255 then the tax cost is 1690*/
                    else if (CO2 >= 226 && CO2 <= 255)
                    {
                        fuelCost = 1690.0f;
                    }
                    /*Else if the CO2 emissions are more then 255 then the tax cost is 1990*/
                    else if (CO2 > 255)
                    {
                        fuelCost = 1990.0f;
                    }
                    /*Else the CO2 is something invalid e.g. -5 therefore we will return -1.*/
                    else
                    {
                        fuelCost = -1.0f;
                    }

                    
                }

                car.TaxBand = fuelCost;
            }

            return fuelCost;
        }
    }
}
