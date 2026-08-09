using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationApp.UI
{
    /// <summary>
    /// メインの画面フレームです。
    /// 画面を作る際、このコントロールを最背面に配置し、「Dock」プロパティを「Fill」に設定してください。
    /// </summary>
    public partial class CtlMainFrame : UserControl
    {
        public CtlMainFrame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 画面遷移時のパラメータ
        /// </summary>
        public NavigateParam NavigateParam { get; set; }

        /// <summary>
        /// ヘッダに表示するタイトルを設定
        /// </summary>
        [Category("カスタム設定")]
        [Description("ヘッダに表示するタイトルを設定します")] // 説明文
        public string HeaderTitle
        {
            get
            {
                return this.lblTitle.Text;
            }

            set
            {
                this.lblTitle.Text = value;
            }
        }
    }
}
