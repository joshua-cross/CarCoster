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
            string sCar = "Manufactorer: " + car.Manufacturer + "\n" +
                          "Model: " + car.Model + "\n" +
                          "Description: " + car.Description + "\n" + 
                          "Transmission: " + car.Transmission + "\n" +
                          "Engine Capacity: " + car.EngineCapacity + "\n" +
                          "Fuel Type: " + car.FuelType + "\n" +
                          "Fuel Consumption Metric Urban (Cold): " + car.MetricUrbanCold + "\n" +
                          "Fuel Consumption Metric Extra-Urban: " + car.MetricExtraUrban + "\n" + 
                          "Fuel Consumption Metric Combined: " + car.MetricCombined + "\n" +
                          "Fuel Consumption Imperial Urban (Cold): " + car.ImperialUrbanCold + "\n" +
                          "Fuel Consumption Imperial Extra-Urban: " + car.ImperialUrbanCold + "\n" +
                          "Fuel Consumption Imperial Combined: " + car.ImperialCombined + "\n";

            return sCar;
        }
    }
}
