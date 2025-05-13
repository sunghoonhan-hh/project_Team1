using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<MenuInformation> list = new List<MenuInformation>();
            MenuInformation m = new MenuInformation("왕메가헛개리카노");
            m.Option_Shot = true;
            list.Add(m);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new SelectCoffee());
        }
    }
}
