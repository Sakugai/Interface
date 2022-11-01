using intarface_kirillov.Barbershop.View.Pages;
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

namespace intarface_kirillov.View.Windows
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

        private void AboutClubBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AboutClubPage());
        }

        private void ServicesBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ServicePage());
        }

        private void NewsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new NewsPage());
        }

        private void FrashizaBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new FranshizaPage());
        }

        private void KontactBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ContactPage());
        }
    }
}
