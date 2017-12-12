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



        public List<Car> getCars()
        {
            return cars;
        }

        public string getJsonLocation()
        {
            string thisDirectory = Directory.GetCurrentDirectory().ToString();
            return thisDirectory + @"\Json\CarCost.json";
        }
    }
}
