using intarface_kirillov.Barbershop.AppData;
using intarface_kirillov.Barbershop.View.Windows;
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
    /// Логика взаимодействия для NewsPage.xaml
    /// </summary>
    public partial class NewsPage : Page
    {
        public NewsPage()
        {
            InitializeComponent();

            List<News> news = new List<News>()
            {
                new News("Новость №1", "шыпвапгафшыпашыгпашпашдфыапгфыдапгфдшагпуцдгап", DateTime.Now, new Uri(@"O:\KirillovLeonid\intarface_kirillov\intarface_kirillov\Barbershop\Resources\Images\s1.jpg")),
                new News("Новость №2", "шыпвапгафшыпашыгпашпашдфыапгфыдапгфдшагпуцдгап", DateTime.Now, new Uri(@"O:\KirillovLeonid\intarface_kirillov\intarface_kirillov\Barbershop\Resources\Images\s2.jpg")),
                new News("Новость №3", "шыпвапгафшыпашыгпашпашдфыапгфыдапгфдшагпуцдгап", DateTime.Now, new Uri(@"O:\KirillovLeonid\intarface_kirillov\intarface_kirillov\Barbershop\Resources\Images\s1.jpg")),
                new News("Новость №4", "шыпвапгафшыпашыгпашпашдфыапгфыдапгфдшагпуцдгап", DateTime.Now, new Uri(@"O:\KirillovLeonid\intarface_kirillov\intarface_kirillov\Barbershop\Resources\Images\s2.jpg")),
            };

            foreach (News item in news)
            {
                ///Куда отображать(добавлять).предмет(Item).Добавить(Add)
                NewsLb.Items.Add(item);
            }
        }

        private void AddNewsBtn_Click(object sender, RoutedEventArgs e)
        {
            AddNewsWindow addNewsWindow = new AddNewsWindow();
            addNewsWindow.ShowDialog();
        }
    }
}
