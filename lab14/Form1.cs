using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr14
{
    public enum DateTimeFormat
    {
        ShowTime,
        ShowDate
    }
    public partial class Form1 : Form
    {
        DateTimeFormat dtFormat = DateTimeFormat.ShowTime;
        ToolStripMenuItem currentCheckedItem;

        public Form1()
        {
            InitializeComponent();
            Text = "Пример состояния строки";
            CenterToScreen();
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemDate_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowDate;
            currentCheckedItem = toolStripMenuItemDate;
            currentCheckedItem.Checked = true;
        }

        private void toolStripMenuItemTime_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowTime;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabelClock.Text = (e.X + " " + e.Y).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double z = 0;
                int X = Convert.ToInt32(toolStripTextBox3.Text);
                int Y = Convert.ToInt32(toolStripTextBox2.Text);
                int Z = Convert.ToInt32(toolStripTextBox1.Text);
                int A = Convert.ToInt32(toolStripComboBox1.Text);
                int B = Convert.ToInt32(toolStripComboBox2.Text); 
                z = ((A * X) / Math.Abs(Z)) + (B * Y) + ((Math.Sin(Z)) / Math.Sqrt(Math.Abs(Math.Pow(X, 2) - Y)));
                Text = Convert.ToString(z);
            }
            catch
            {
                MessageBox.Show("Пожалуйста заполните все поля в toolStripDropDownButton!");
            }
        }

    }
}
