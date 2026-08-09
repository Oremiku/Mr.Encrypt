using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationApp.UI
{
    /// <summary>
    /// ページ遷移時のパラメータ
    /// </summary>
    public class NavigateParam
    {
        /// <summary>
        /// 遷移先のページ
        /// </summary>
        public UserControl NextPage { get; set; }

        /// <summary>
        /// 任意のパラメータ
        /// </summary>
        public object Param { get; set; }
    }
}
