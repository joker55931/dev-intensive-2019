using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr14_2задание_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format(e.X + " " + e.Y);
            int X = (e.X);
            int Y = (e.Y);
            double z = 0;

                if (Convert.ToString(toolStripComboBox1.Text) == "1")
                {
                    z = Math.Pow(X, 4);
                    toolStripStatusLabel1.Text = Convert.ToString(z);
                }
                if (Convert.ToString(toolStripComboBox1.Text) == "2")
                {
                    z = Math.Pow(Y, 3);
                    toolStripStatusLabel1.Text = Convert.ToString(z);
                }
                if (Convert.ToString(toolStripComboBox1.Text) == "3")
                {
                    z = Math.Sqrt(X / Y) + Math.Pow(Y, 2);
                    toolStripStatusLabel1.Text = Convert.ToString(z);
                } 
        }
    }
}
