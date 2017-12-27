using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCoster
{
    class Order
    {
        public List<Car> orderByMPG(List<Car> cars)
        {
            List<Car> orderedCars = new List<Car>();

            orderedCars = cars.OrderBy(d => d.ImperialCombined).ToList();

            return orderedCars;
        }
    }
}
