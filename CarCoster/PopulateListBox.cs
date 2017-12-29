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

        /*Function that takes in:
         a. the textbox which contains the text.
         b. the listed object so we can search through its manufacturers
         c. the ListBox we wish to populate.
         and then returns an updated Listed object that contains the new SearchedManufactuers
         list.*/
        public Listed UpdateManufacturersThroughSearch(TextBox text, Listed carList, ListBox CarBox)
        {
            CarListReader listReader = new CarListReader();

            carList.searchedManufacturers =
                listReader.searchString(carList.Manufacturers, text.Text);

            /*Repopulating the listbox with what was searched rather than all the
             manufacturers.*/
            PopulateListBoxWithManufacturers(CarBox, carList.searchedManufacturers);
     
            /*if the user has reset the search box ie. MakeBox.Text = "" then we will
             repopulate the listbox with all the makes.*/
            if (text.Text.Equals(""))
            {
                carList.searchedManufacturers = carList.Manufacturers;
                PopulateListBoxWithManufacturers(CarBox, carList.searchedManufacturers);
            }

            return carList;

        }

    }
}
