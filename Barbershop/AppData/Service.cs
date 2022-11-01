using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intarface_kirillov.Barbershop.AppData
{
    abstract class Service
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public Uri Uri { get; set; }
    }
}
