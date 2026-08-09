using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReservationApp.UI;

namespace ReservationApp
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var param = new NavigateParam()
            {
                NextPage = new CtlLogin(),
                Param = null
            };
            Application.Run(new MainForm(param));
        }
    }
}
