using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CarCoster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*When the program initially loads we want to load an image.*/
        private void Form1_Load(object sender, EventArgs e)
        {
            string thisDirectory = Directory.GetCurrentDirectory().ToString();
            string fileLoc = thisDirectory + @"\Images\LeafIcon.png";

            pictureBox1.Image = Image.FromFile(thisDirectory);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Title.Text = fileLoc;
        }
    }
}
