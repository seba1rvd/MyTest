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
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        public Test()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("TestExample/One.xaml", UriKind.Relative));
        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("TestExample/Two.xaml", UriKind.Relative));
        }
        private void Three_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("TestExample/Three.xaml", UriKind.Relative));
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("TestExample/Four.xaml", UriKind.Relative));
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("TestExample/Five.xaml", UriKind.Relative));
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("TestExample/Six.xaml", UriKind.Relative));
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("TestExample/Seven.xaml", UriKind.Relative));
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("TestExample/Eight.xaml", UriKind.Relative));
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("TestExample/Nine.xaml", UriKind.Relative));
        }

        private void Ten_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Navigate(new Uri("TestExample/Ten.xaml", UriKind.Relative));
        }
    }
}
