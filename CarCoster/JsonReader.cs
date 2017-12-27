using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace CarCoster
{
    /**
     * Class that takes the Json File and converts it into a list of cars. 
     */
    class JsonReader
    {
        List<Car> cars = new List<Car>();

        //default constructor.
        public JsonReader()
        {

            string fileLoc = getJsonLocation();

            using (StreamReader r = new StreamReader(fileLoc))
            {
                string json = r.ReadToEnd();
                cars = JsonConvert.DeserializeObject<List<Car>>(json);
                foreach (Car car in cars)
                {
                    Console.WriteLine(car.Manufacturer);
                }

            }

        }

        //Constructor using the year.
        public JsonReader(string year)
        {

            /*Only do the following if the user has not selected the option
             all, if they do select all then we want to get all the files in the
             JSON folder and add them to the cars array, then return the car array.*/
            if (year.ToLower() != "all")
            {
                string fileLoc = getJsonLocation(year);

                /*Converting all JSON element to the car object.*/
                using (StreamReader r = new StreamReader(fileLoc))
                {
                    string json = r.ReadToEnd();
                    cars = JsonConvert.DeserializeObject<List<Car>>(json);
                    foreach (Car car in cars)
                    {
                        Console.WriteLine(car.Manufacturer);
                    }

                }

            } else
            {
                /*Getting the location of each and all of the JSON files for the project.*/
                string thisDirectory = Directory.GetCurrentDirectory().ToString();
                thisDirectory += @"\json";
                string[] filePaths = Directory.GetFiles(thisDirectory);

                /*For each of the files in the filepath the cars will be added to an
                 array which will contain the cars for each year.*/
                foreach (string filePath in filePaths)
                {
                    List<Car> theCars = new List<Car>();

                    using (StreamReader r = new StreamReader(filePath))
                    {
                        string json = r.ReadToEnd();
                        theCars = JsonConvert.DeserializeObject<List<Car>>(json);
                        /*Adding each of the cars in this file to the cars array.*/
                        foreach (Car car in theCars)
                        {
                            cars.Add(car);
                        }
                        
                    }
                }
            }


        }



        public List<Car> getCars()
        {
            return cars;
        }

        public string getJsonLocation()
        {
            string thisDirectory = Directory.GetCurrentDirectory().ToString();
            return thisDirectory + @"\Json\2017.json";
        }

        public string getJsonLocation(string year)
        {
            string thisDirectory = Directory.GetCurrentDirectory().ToString();
            return thisDirectory + @"\Json\" + year + ".json";
        }
    }
}
