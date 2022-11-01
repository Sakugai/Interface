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

namespace intarface_kirillov.Barbershop.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AboutClubPage.xaml
    /// </summary>
    public partial class AboutClubPage : Page
    {
        public AboutClubPage()
        {
            InitializeComponent();
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
