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
using System.Windows.Shapes;

namespace MyTest
{
    /// <summary>
    /// Логика взаимодействия для ExapmleOneAndTwo.xaml
    /// </summary>
    public partial class ExapmleOneAndTwo : Window
    {
        public ExapmleOneAndTwo()
        {
            InitializeComponent();
        }

        private void OneExample_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("Example1.xaml", UriKind.Relative));
        }

        private void TwoExaple_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("Example2.xaml", UriKind.Relative));
        }
    }
}
