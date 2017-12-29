﻿using System;
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

        /*Default constructor that gets all the files in the Json folder, and
         then checks which is the latest file and uses this as the default.*/
        public JsonReader()
        {

            string[] fileLocs = GetAllFiles();
            string fileLoc = "";
            //int that holds the most recent integer so we can replace when a new larger one comes.
            int mostRecent = 0;

            foreach (string file in fileLocs)
            {

                //setting file to be string name without an extension.
                string theFile = Path.GetFileNameWithoutExtension(file);

                /*Trying to parse the filename to an integer so we can compare them.*/
                try
                {
                    int thisYear = int.Parse(theFile);
                    /*If this new year is greater than the previous one then this is the latest year.*/
                    if(thisYear > mostRecent)
                    {
                        mostRecent = thisYear;
                    }
                } catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            /*If mostRecent is still 0 then we will set it as 2017 to be our new default.*/
            if (mostRecent == 0)
            {
                mostRecent = 2017;
            }

            /*Setting the fileLoc to be the value of mostRecent.*/
            fileLoc = mostRecent.ToString();


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
                        car.carJSONYear = year;
                    }

                }

            } else
            {
                string[] filePaths = GetAllFiles();

                /*For each of the files in the filepath the cars will be added to an
                 array which will contain the cars for each year.*/
                foreach (string filePath in filePaths)
                {
                    string fileName = Path.GetFileNameWithoutExtension(filePath);
                    List<Car> theCars = new List<Car>();

                    using (StreamReader r = new StreamReader(filePath))
                    {
                        string json = r.ReadToEnd();
                        theCars = JsonConvert.DeserializeObject<List<Car>>(json);
                        /*Adding each of the cars in this file to the cars array.*/
                        foreach (Car car in theCars)
                        {
                            car.carJSONYear = fileName;
                            cars.Add(car);
                        }
                        
                    }
                }
            }


        }

        /*function that gets all the filepaths.*/
        public string[] GetAllFiles()
        {
            /*Getting the location of each and all of the JSON files for the project.*/
            string thisDirectory = Directory.GetCurrentDirectory().ToString();
            thisDirectory += @"\json";
            string[] filePaths = Directory.GetFiles(thisDirectory);

            return filePaths;
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
