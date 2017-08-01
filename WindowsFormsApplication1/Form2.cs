using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        string num;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string number)
        {
            string Store = AppDomain.CurrentDomain.BaseDirectory + @"\images\";
            InitializeComponent();
            this.num = number;
            this.KeyPreview = true;
            try
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(Store + "Photokatsu_" + num + ".jpg");

                if (!fi.Exists)
                {

                }
                else
                {
                    Image image_size = new Bitmap(Store + "Photokatsu_" + num + ".jpg", false);
                    int width = image_size.Width;
                    int height = image_size.Height;
                    if (height > 1049)
                        height = 1049;
                    if (width > 750)
                        width = 750;
                    ClientSize = new Size(width, height);
                    this.BackgroundImage = image_size;
                }
            }
            catch
            {

            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }
    }
}
