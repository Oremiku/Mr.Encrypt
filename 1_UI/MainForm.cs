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
        public MainForm(NavigateParam param)
        {
            InitializeComponent();
            this.NavigatePage(param);
        }

        /// <summary>
        /// ページを遷移させます。
        /// </summary>
        /// <param name="param">遷移パラメータ</param>
        private void NavigatePage(NavigateParam param)
        {
            this.NavigatePage(this, param);
        }

        /// <summary>
        /// ページを遷移させます。
        /// </summary>
        private void NavigatePage(object sender, NavigateParam e)
        {
            var nextPage = e.NextPage;
            nextPage.Dock = DockStyle.Fill;
            nextPage.Param = e.Param;
            nextPage.NavigateEvent += this.NavigatePage;

            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(e.NextPage);
        }
    }
}
