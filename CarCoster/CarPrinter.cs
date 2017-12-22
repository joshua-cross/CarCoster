using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCoster
{
    class CarPrinter
    {
        public string printcar(Car car)
        {
            string sCar = "";
                          
            if(car.Transmission != null)
            {
                sCar += "Transmission: " + car.Transmission + "\n";
            }

            if(car.EngineCapacity != null)
            {
                sCar += "Engine Capacity: " + car.EngineCapacity + "\n";
            }

            if(car.FuelType != null)
            {
                sCar += "Fuel Type: " + car.FuelType + "\n";

            }

            if(car.ElecricEnergyConsumptionMiles != null)
            {
                sCar += "Electric Energy Consumptions Miles/kWh: " + car.ElecricEnergyConsumptionMiles + "\n";
            }

            if(car.MilesPerKilowatt != null)
            {
                sCar += "wh/km: " + car.MilesPerKilowatt + "\n";
            }

            if (car.MaximumRangeKm != null)
            {
                sCar += "Maximum Range (Km): " + car.MaximumRangeKm + "\n";
            }

            if(car.MaximumRangeMiles != null)
            {
                sCar += "Maximum Range (Miles): " + car.MaximumRangeMiles + "\n";
            }
            if (car.MetricUrbanCold != null)
            {
                sCar += "Fuel Consumption Metric Urban (Cold): " + car.MetricUrbanCold + "\n";

            }

            if(car.MetricExtraUrban != null)
            {
                sCar += "Fuel Consumption Metric Extra-Urban: " + car.MetricExtraUrban + "\n";
            }

            if (car.MetricCombined != null)
            {
                sCar += "Fuel Consumption Metric Combined: " + car.MetricCombined + "\n";
            }

            if (car.ImperialUrbanCold != null)
            {
                sCar += "Fuel Consumption Imperial Urban (Cold): " + car.ImperialUrbanCold + "\n";
            }
            
            if(car.ImperialExtraUrban != null)
            {
                sCar += "Fuel Consumption Imperial Extra-Urban: " + car.ImperialExtraUrban + "\n";

            }

            if(car.ImperialCombined != null)
            {
                sCar += "Fuel Consumption Imperial Combined: " + car.ImperialCombined + "\n";
            }

            if(car.CO2gramsPerKilometer != null)
            {
                sCar += "CO2 g/km: " + car.CO2gramsPerKilometer + "\n";
            }

            if(car.FuelCostPer12000Miles != null)
            {
                sCar += "Fuel Cost per 12000 miles: £" + car.FuelCostPer12000Miles + "\n";
            }

            if(car.FuelCostPer6000Miles != null)
            {
                sCar += "Fuel Cost per 6000 miles: £" + car.FuelCostPer6000Miles.ToString() + "\n";
            }

            if(car.ElectricityCost != null)
            {
                sCar += "Electricity Cost per 12000 miles: £" + car.ElectricityCost + "\n";
            }
            if(car.CostPer12000Miles != null)
            {
                sCar += "Total Cost per 12000 Miles: £" + car.CostPer12000Miles + "\n";
            }

            if(car.EuroStandard != null)
            {
                sCar += "Euro Standard: " + car.EuroStandard + "\n";
            }

            if(car.NoiseLevelDB != null)
            {
                sCar += "Noise Level dB(A): " + car.NoiseLevelDB + "\n";

            }

            if(car.EmissionCO2 != null)
            {
                sCar += "Carbon Monoxide (CO) Emissions: " + car.EmissionCO2 + "\n";

            }

            if(car.THCLevel != null)
            {
                sCar += "THC Emissions (mg/km): " + car.THCLevel + "\n";
            }

            if(car.NOxEmissions != null)
            {
                sCar += "Nitrogen Oxide (NOx) emissions (mg/km): " + car.NOxEmissions + "\n";
            }

            if(car.THCAndNOxEmissions != null)
            {
                sCar += "NOx and THC Emissions (mg/km): " + car.THCAndNOxEmissions + "\n";
            }

            if(car.Particulates != null)
            {
                sCar += "Particulates (mg/km)" + car.Particulates + "\n";
            }

            return sCar;
        }

        /*Function that returns the header for the car ie. the manufactorer, the model and
         the description*/
        public string carHeader(Car car)
        {
            return "Manufactorer: " + car.Manufacturer + "\n" +
                              "Model: " + car.Model + "\n" +
                              "Description: " + car.Description + "\n";
        }

    }

}
