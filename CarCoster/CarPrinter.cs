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
                          "Model: " + car.Model + "/n" +
                          "Description: " + car.Description + "\n";
            return sCar;
        }
    }
}
