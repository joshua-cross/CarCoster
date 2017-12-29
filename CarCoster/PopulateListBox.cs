using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCoster
{
    class PopulateListBox
    {
        /*Function that takes in the ListBox and the manufacturers, then
         prints adds these manufactuers to the ListBox.*/
         public void PopulateListBoxWithManufacturers(ListBox list, IEnumerable<string> manufacturers)
        {
            foreach(string manufacturer in manufacturers)
            {
                list.Items.Add(manufacturer);
            }
        }



        /*Function that takes in a list of cars that need printing to a list box,
         then prints the manufacturer, model and description of the car.*/
         public void PopulateListBoxWithCarsDetails(ListBox list, IEnumerable<Car> cars)
        {
            foreach (Car car in cars)
            {
                list.Items.Add(car.Manufacturer.ToString() + car.Model.ToString() + " " + car.Description.ToString());

            }
        }

    }
}
