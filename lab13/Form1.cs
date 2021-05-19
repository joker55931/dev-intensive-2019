using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double Z = 0;
                int X = Convert.ToInt32(textBoxX.Text);
                int Y = Convert.ToInt32(textBoxY.Text);
                int n = Convert.ToInt32(textBox3.Text);
                int N = Convert.ToInt32(textBoxN.Text);
                int R = Convert.ToInt32(textBoxR.Text);
                int h = Convert.ToInt32(textBoxh.Text);
                int c = Convert.ToInt32(textBoxc.Text);


                if (radioButton1.Checked)
                {
                    for (int i = 2; i < n; i++)
                    {
                        int item;
                        item = (i % 2 == 0) ? Y : X;
                        Z += -1 + (Math.Pow(item, (i - 1)) / i) * Math.Pow(-1, i);
                    }
                    textBoxZ.Text = Z.ToString();
                }
                if (radioButton2.Checked)
                {
                    for (int i = 1; i < N; i++)
                    {
                        for (int j = 1; j < R; j++)
                        {
                            Z += (j * j + h * i) / (Math.Pow(i, j) + c * j);
                        }
                    }
                    textBoxZ.Text = Z.ToString();
                }
                
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Пожалуйста, введите в поля целые числа! Иначе программа работать не будет!");
            }
        }
    }
}
