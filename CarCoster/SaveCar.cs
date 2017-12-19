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
                    //we cannot own more than 5 cars.
                    if(Properties.Settings.Default.Manufacturers.Count > 5
                       && Properties.Settings.Default.Models.Count > 5
                       && Properties.Settings.Default.Descriptions.Count > 5)
                    {
                        /*
                        //the first element in the array (which we want removing.)
                        int oldIndex = 0;

                        Properties.Settings.Default.Manufacturers.RemoveAt(oldIndex);
                        Properties.Settings.Default.Models.RemoveAt(oldIndex);
                        Properties.Settings.Default.Descriptions.RemoveAt(oldIndex);

                        for(int i = 1; i < Properties.Settings.Default.Manufacturers.Count; i = i + 1)
                        {

                            string man = Properties.Settings.Default.Manufacturers[i];
                            string mod = Properties.Settings.Default.Models[i];
                            string desc = Properties.Settings.Default.Descriptions[i];

                            Properties.Settings.Default.Manufacturers.Remove(man);
                            Properties.Settings.Default.Manufacturers.Insert(i - 1, man);
                            Properties.Settings.Default.Models.Remove(mod);
                            Properties.Settings.Default.Models.Insert(i - 1, mod);
                            Properties.Settings.Default.Descriptions.Remove(desc);
                            Properties.Settings.Default.Descriptions.Insert(i - 1, desc);
                        }
                        */
                        return "Cannot have more than 5 cars. Please remove one.";
                    }
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

        /*Function that removes the car at the element given.*/
        public string removeCar(int element)
        {
            Properties.Settings.Default.Manufacturers.RemoveAt(element);
            Properties.Settings.Default.Models.RemoveAt(element);
            Properties.Settings.Default.Descriptions.RemoveAt(element);
            
            /*If we have removed the users selected car then we will remove the selected
             car and return it to null.*/
            if (Properties.Settings.Default.Manufacturers[element] ==
                Properties.Settings.Default.Manufacturer &&
                Properties.Settings.Default.Models[element] ==
                Properties.Settings.Default.Model &&
                Properties.Settings.Default.Descriptions[element] == 
                Properties.Settings.Default.Description)
            {
                Properties.Settings.Default.Manufacturer = null;
                Properties.Settings.Default.Model = null;
                Properties.Settings.Default.Description = null;
            }

            Properties.Settings.Default.Save();
            return "Car removed";
        }


        public void selectedCar(int id)
        {
            Properties.Settings.Default.Manufacturer = Properties.Settings.Default.Manufacturers[id];
            Properties.Settings.Default.Model = Properties.Settings.Default.Models[id];
            Properties.Settings.Default.Description = Properties.Settings.Default.Descriptions[id];
            Properties.Settings.Default.Save();
        }

    }


}
