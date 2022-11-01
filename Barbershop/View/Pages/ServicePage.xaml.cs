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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace intarface_kirillov.Barbershop.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ServicePage.xaml
    /// </summary>
    public partial class ServicePage : Page
    {
        public ServicePage()
        {
            InitializeComponent();

            List<Service> servicesList = new List<Service>()
            {
                new Heircut() { Name ="Модельная", Cost=300m, Description="Прикилдысная стрижка", Uri=new Uri(@"O:\KirillovLeonid\intarface_kirillov\intarface_kirillov\Barbershop\Resources\Images\s2.jpg")},
                new Heircut() { Name ="Толик подстриги меня под нолик", Cost=500m, Description="Стрижка для настоящих мужчин"},
                new Shave() { Name ="Опасное бритьё", Cost=1000m, Description="Немного страшно, но нормально", Uri=new Uri(@"O:\KirillovLeonid\intarface_kirillov\intarface_kirillov\Barbershop\Resources\Images\s1.jpg")},
                new Shave() { Name ="Очень опасное бритьё", Cost=1m, Description="Только выживший может судить о крутизне этого мужчины"},
                new Addition() { Name ="Мытьё головы", Cost=450m, Description="Мужчина моет голову только в одном случае..."},
                new Addition() { Name ="Сырный соус", Cost=40m, Description="Для истинных ценителей"}
            };

            //Условие: что мы ищем и внутри чего
            foreach (Service service in servicesList)
            {
                if (service is Heircut heircut)
                {
                    HeircutLv.Items.Add(heircut);
                }
                if (service is Shave shave)
                {
                    ShaveLv.Items.Add(shave);
                }
                if (service is Addition addition)
                {
                    AdditionLv.Items.Add(addition);
                }
            }
        }

        private void Service_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(((Service)((ListView)sender).SelectedItem).Description);

            //1)Когда все плачевно :(
            //обращается напрямую
            //InfoTbl.Text= ((Service)((ListView)sender).SelectedItem).Name;

            //2) Когда нужно пользоваться привязкой
            InfoTbl.DataContext = (Service)((ListView)sender).SelectedItem;
            ServiceImg.DataContext = (Service)((ListView)sender).SelectedItem;

        }

    }
}
