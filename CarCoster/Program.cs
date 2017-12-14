﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCoster
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //loading a car from the database.
            LoadCar load = new LoadCar();
            Car car = load.Load();

            //if the car is null then there was no saved car.
            if (car == null)
                Application.Run(new Form1());
            else
                Application.Run(new Overview());
            
            
        }
    }
}
