using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp1002
{
    public partial class AfTextBox : UserControl
    {
        public AfTextBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 自定义布局
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            //获取子控件
            if (this.Controls.Count == 0) return;
            Control c = this.Controls[0];

            //父窗口参数
            Padding p = this.Padding;
            int x = 0, y = 0;
            int w = this.Width, h = this.Height;
            w -= (p.Left + p.Right);
            x += p.Left;

            //计算文本框的高度, 使期显示在中间
            int h2 = c.PreferredSize.Height;
            if (h2 > h) h2 = h;
            y = (h - h2) / 2;

            c.Location = new Point(x, y);
            c.Size = new Size(w, h2);
        }
    }
}
