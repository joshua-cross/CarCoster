using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCoster
{
    public partial class Overview : Form
    {
        IEnumerable<Car> cars;

        public Overview()
        {
            InitializeComponent();
            LoadCar load = new LoadCar();
            cars = load.Load();
        }

        private void SaveButton_Enter(object sender, EventArgs e)
        {
        }

        //when the user hovers over the button a selector shows up next to it.
        private void SaveButton_MouseHover(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            OverviewText.Text = button.Text;

            while (SelectedButton.Location.Y != button.Location.Y)
            {

                if (SelectedButton.Location.Y > button.Location.Y)
                    SelectedButton.Location = new Point(SelectedButton.Location.X, SelectedButton.Location.Y - 1);
                else
                    SelectedButton.Location = new Point(SelectedButton.Location.X, SelectedButton.Location.Y + 1);
            }

        }

        private void Overview_Load(object sender, EventArgs e)
        {
            if(cars.Count() == 0)
            {
                OverviewText.Text = "There are currently no saved cars :(";
            } else
            {
                OverviewText.Text = cars.ElementAt(0).Model;
            }
        }
    }
}
