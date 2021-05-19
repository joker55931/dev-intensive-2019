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

namespace LAB__20
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

        private void BtnNormal_Click(object sender, RoutedEventArgs e)
        {
            sldSource.Value = 30;
        }

        private void BtnLarge_Click(object sender, RoutedEventArgs e)
        {
            txtTarget.FontSize = 60;
        }

        private void BtnCreateBinding_Click(object sender, RoutedEventArgs e)
        {
            Binding b1 = new Binding
            {
                ElementName = "listFont",
                Path = new PropertyPath("SelectedItem.Tag"),
                Mode = BindingMode.TwoWay,
            };

            Binding b2 = new Binding
            {
                ElementName = "listWeight",
                Path = new PropertyPath("SelectedItem.Tag"),
                Mode = BindingMode.TwoWay,
            };
            txtTarget.SetBinding(TextBlock.FontFamilyProperty, b1);
            txtTarget.SetBinding(TextBlock.FontWeightProperty, b2);
        }

        private void BtnDeleteBinding_Click(object sender, RoutedEventArgs e)
        {
            BindingOperations.ClearBinding(txtTarget, TextBlock.FontFamilyProperty);
            BindingOperations.ClearBinding(txtTarget, TextBlock.FontWeightProperty);
        }
    }
}
