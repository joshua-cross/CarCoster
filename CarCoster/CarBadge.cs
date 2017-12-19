using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace CarCoster
{
    class CarBadge
    {
        /*Function that takes in the cars manufactorer
         then finds the matching image file e.g. if man was audi
         we would return the audi.png image url.*/
        public string getBadge(string man)
        {
            //ensuring that man is all lower so there are no case sensitive errors.
            man = man.ToLower();

            /*The URL for the image file*/
            string thisDirectory = Directory.GetCurrentDirectory().ToString();
            string fileLoc = thisDirectory + @"\Images\CarBadges\" + man + ".png";

            return fileLoc;
        }
    }
}
