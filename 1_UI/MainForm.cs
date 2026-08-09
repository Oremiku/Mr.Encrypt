using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReservationApp.UI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 現在のページ
        /// </summary>
        private CtlMainFrame _currentPage;

        /// <summary>
        /// メインフォームをインスタンス化
        /// </summary>
        /// <param name="firstPage">一番最初に表示するページ名</param>
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
