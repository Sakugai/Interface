using intarface_kirillov.Barbershop.AppData;
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

namespace intarface_kirillov.Barbershop.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddNewsWindow.xaml
    /// </summary>
    public partial class AddNewsWindow : Window
    {
        List<News> user;
        public AddNewsWindow()
        {
            InitializeComponent();
        }
    }
}
