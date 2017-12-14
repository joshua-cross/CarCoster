using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCoster
{
    class SaveCar
    {
        /*Function that saves the selected car to the settings.*/
        public string Save(Car car)
        {
            if(car == null)
            {
                return "Please select a car";
            } else
            {
                Properties.Settings.Default.Manufacturer = car.Manufacturer;
                Properties.Settings.Default.Model = car.Model;
                Properties.Settings.Default.Description = car.Description;
                Properties.Settings.Default.Save();
                return "Car: " + Properties.Settings.Default.Model + " Added!";
            }
        }
    }
}
