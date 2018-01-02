using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CarCoster
{
    class PopulateListBox
    {
        /*Function that takes in the ListBox and the manufacturers, then
         prints adds these manufactuers to the ListBox.*/
         public void PopulateListBoxWithManufacturers(ListBox list, IEnumerable<string> manufacturers)
        {
            list.Items.Clear();
            foreach(string manufacturer in manufacturers)
            {
                list.Items.Add(manufacturer);
            }
        }

        /*Function that takes in a list of cars that need printing to a list box,
         then prints the manufacturer, model and description of the car.*/
         public void PopulateListBoxWithCarsDetails(ListBox list, IEnumerable<Car> cars)
        {
            list.Items.Clear();
            foreach (Car car in cars)
            {
                list.Items.Add(car.Manufacturer.ToString() + " " + car.Model.ToString() + " " + car.Description.ToString());

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

        /*Function that takes in:
         a. the textbox that contains the text.
         b. the listed object so we can search through the manufacturers models
         c. the listbox we wish to populate
         and then returns an updated Listed object that contains the new CurrentCars
         list.*/
         public Listed UpdatedModelsThroughSearch(TextBox text, Listed carList, ListBox ModelBox)
        {
            CarListReader listReader = new CarListReader();

            //using the CarListReader to search the Json file for the search result.
            IEnumerable<Car> searchedModels =
                listReader.searchModels(carList.CarsFromManufacturer, text.Text);
            //searching the description for what has been typed.
            IEnumerable<Car> searchedDescription = 
                listReader.searchDescriptions(carList.CarsFromManufacturer, text.Text);

            //creating a list that contains both searchModels and searchedDescription
            carList.CurrentCars = searchedModels.Concat(searchedDescription);

            //for each car that contains what we searched we will print the Car and the Description.
            PopulateListBoxWithCarsDetails(ModelBox, carList.CurrentCars);

            //if the user empties the search box then we want to refill the listbox with the array of models.
            if (text.Text.Equals(""))
            {
                carList.CurrentCars = carList.CarsFromManufacturer;
                PopulateListBoxWithCarsDetails(ModelBox, carList.CurrentCars);
            }

            return carList;
        }

        /*Function that takes in:
         a. the ListBox for the model.
         b. the manufactuerer selected from the ManufacturerBox.
         c. the current Listed object.
         d. the pictureBox we want to update with the selected manufacturers logo.
         then returns all the cars from this selected manufacturer.*/
        public Listed ManufactuerSelected(ListBox ModelBox, string manufacturer, Listed carList, PictureBox LogoBox)
        {
            CarListReader listReader = new CarListReader();

            /*If the item is not all then do the following*/
            if (!manufacturer.Equals("All"))
            {

                /*Getting the models*/
                //contstructor that takes in a manufactorer and searches the array for cars that match the manufactorer.
                carList.CarsFromManufacturer = listReader.searchCars(carList.Cars, manufacturer);

                /*As we've only just drew the list of models we should assume that
                 the CurrentCars is the CarsFromManufacturer*/
                carList.CurrentCars = carList.CarsFromManufacturer;

                /*Loading the manufacturers logo in the form.*/
                CarBadge badge = new CarBadge();
                string url = badge.getBadge(manufacturer);
                LogoBox.Image = Image.FromFile(url);
                LogoBox.SizeMode = PictureBoxSizeMode.StretchImage;

                PopulateListBoxWithCarsDetails(ModelBox, carList.CarsFromManufacturer);
            }
            else
            {
                /*As we've selected all, just set the manufacturers to each available car in the
                 Listed object.*/
                carList.CarsFromManufacturer = carList.Cars;
                PopulateListBoxWithCarsDetails(ModelBox, carList.CarsFromManufacturer);
            }

            /*Returning the carList after updating the carLists CarsFromManufacturer*/
            return carList;
        }

        /*Function that takes in:
         a. the classes Listed Object.
         b. the element from the ListBox that the user has selected.*/
        public Listed ModelSelected(int element, Listed carList)
        {
            Car car = null;

            /*If the user has selected a legitimate element that's not null.*/
            if(element > -1)
            {
                /*selecting the car at the selected element.*/
                car = carList.CurrentCars.ElementAt(element);
                /*If the car we just got is not null then we will calculate the cost.*/
                if(car != null)
                {
                    TaxCalculator tax = new TaxCalculator();
                    float? taxCost = tax.CalculateTax(car);
                }
            }

            /*setting the carLists selected car to either be the car at the element selected
             or if the element selected is invalid then null.*/
            carList.SelectedCar = car;

            /*Returns the car list after we've seleted the chosen car.*/
            return carList;
        }

        /*Function that's called when the user wants to sort out the CurrentCars by taking in:
         a. the array of cars that we need ordering
         b. boolean that indicated if we want to sort by ascending or descending order.
            i. true = ascending
            ii. false = descending
        c. the ListBox we want to populate afterwards (most likely ModelBox.).
         the array then returns the new IEnumerable*/
        public IEnumerable<Car> OrderedCars(IEnumerable<Car> carsToBeSorted, bool sortingOrder, ListBox list)
        {
            Order order = new Order();
            /*If we are sorting by ascneding order then we want to tell the Order class
             else we're sorting by descending order.*/
            if (sortingOrder)
            {
                carsToBeSorted = order.orderByMPG(carsToBeSorted);
                PopulateListBoxWithCarsDetails(list, carsToBeSorted);
            }
            else
            {
                carsToBeSorted = order.orderByMPGDescending(carsToBeSorted);
                PopulateListBoxWithCarsDetails(list, carsToBeSorted);
            }

            /*repopulating the listbox with the new, sorted list.*/
            PopulateListBoxWithCarsDetails(list, carsToBeSorted);
            /*Return the list after sorting.*/
            return carsToBeSorted;
        }

        /*Function that takes in: 
         a. the fueltype of the vehicle we want to display e.g. if the user wants to display
            only petrol cars then the fuelType would be petrol.
         b. the list box we want to update, most likely ModelBox.
         c. the IEnumerable<Car> we wish to update.
         The function will then remove all but the selected from the array and return the new
         array.*/
         public IEnumerable<Car> ShowOnlySelectedFuelType(string fuelType, ListBox list, IEnumerable<Car> carsToBeSorted)
        {
            try
            {
                /*Only remove fuelTypes if the list we was given is not empty or null.*/
                if (carsToBeSorted.Count() != 0 &&
                    carsToBeSorted != null)
                {
                    Order order = new Order();

                    /*removing all but the cars with the selected fuelType.*/
                    carsToBeSorted = order.RemoveAllButSpecified(carsToBeSorted, fuelType);
                    /*redrawing the ListBox with only cars of this fuelType.*/
                    PopulateListBoxWithCarsDetails(list, carsToBeSorted);
                    /*Returning the cars to be sorted when we remove all but the necessary fueltypes.*/
                }
            } catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            return carsToBeSorted;
        }
    }
}
