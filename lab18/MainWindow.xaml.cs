using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lr18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            if (Radio1.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R1TextA.Text);
                double f = Convert.ToDouble(R1ComboF.Text);
                this.Title = "Ответ: " + Math.Sin(f * a).ToString("F");
            }

            if (Radio2.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R2TextA.Text);
                double b = Convert.ToDouble(R2TextB.Text);
                double f = Convert.ToDouble(R2ComboF.Text);
                this.Title = "Ответ: " + (Math.Cos(f * a) + Math.Sin(f * b)).ToString("F");
            }

            if (Radio3.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R3TextA.Text);
                double b = Convert.ToDouble(R3TextB.Text);
                double c = Convert.ToDouble(R3ComboC.Text);
                double d = Convert.ToDouble(R3ComboD.Text);
                this.Title = "Ответ: " + (c * a * a + d * b * b).ToString("F");
            }

            if (Radio4.IsChecked.GetValueOrDefault())
            {
                double x = Convert.ToDouble(R4TextX.Text);
                double y = Convert.ToDouble(R4TextY.Text);
                double N = Convert.ToDouble(R4ComboN.Text);
                double K = Convert.ToDouble(R4ComboK.Text);
                double res = 1;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < K; j++)
                    {
                        res = res * ((i * Math.Pow(x, i) + j * Math.Pow(y, j)) / (i * j));
                    }
                }
                this.Title = "Ответ: " + res.ToString("F");
            }
        }
    }
}
