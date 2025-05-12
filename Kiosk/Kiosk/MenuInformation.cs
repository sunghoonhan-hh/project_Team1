using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Kiosk
{
    internal class MenuInformation
    {
        public string MenuName { get; set; }
        public int OptionShot { get; set; }
        public int OptionSyrup { get; set; }
        public int Count { get; set; }
        public Image MenuImage { get; set; }
        public decimal Price { get; set; }

        public MenuInformation(string name, Image image, decimal price)
        {
            MenuName = name;
            OptionShot = 0;
            OptionSyrup = 0;
            Count = 1;
            MenuImage = image;
            Price = price;
        }
    }
}
