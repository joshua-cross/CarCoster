using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
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
                try
                {
                    Properties.Settings.Default.Manufacturers.Add(car.Manufacturer);
                    Properties.Settings.Default.Models.Add(car.Model);
                    Properties.Settings.Default.Descriptions.Add(car.Description);
                    Properties.Settings.Default.Save();
                    return "Car: " + Properties.Settings.Default.Model + " Added!";
                } catch (Exception e)
                {
                    return e.ToString();
                }
            }
        }
    }
}
