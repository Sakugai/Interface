using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intarface_kirillov.Barbershop.AppData
{
    internal class News
    {
        public News(string title, string information, DateTime date, Uri uriNews)
        {
            Title = title;
            Information = information;
            Date = date;
            UriNews = uriNews;
        }

        public string Title { get; }
        public string Information { get; }
        public DateTime Date { get; }
        public Uri UriNews { get; }
    }
}
