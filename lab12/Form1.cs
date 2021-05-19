using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr12
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
            Text = string.Format("Координаты: {0}, {1}", e.X, e.Y);
            textBox1.Text = (e.X).ToString();
            textBox2.Text = (e.Y).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, z, as_9, exp;
            double Z;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            z = Convert.ToInt32(textBox3.Text);
            as_9 = Convert.ToInt32(textBox4.Text);
            exp = Convert.ToInt32(textBox6.Text);
            Z = z * Math.Cos(y) + Math.Sqrt(Math.Exp(exp) * 7) - Math.Abs(x + Math.Cos(as_9 + y));
            textBox5.Text = (Z).ToString();
            Text = (Z).ToString();
        }
    }
}
