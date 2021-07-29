using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Af.WinForms
{
    class AfTextBox : UserControl
    {
        private TextBox edit;
    
        private void InitializeComponent()
        {
            this.edit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // edit
            // 
            this.edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.edit.Location = new System.Drawing.Point(99, 26);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(100, 16);
            this.edit.TabIndex = 0;
            this.edit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_KeyPress);
            // 
            // AfTextBox
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.edit);
            this.Name = "AfTextBox";
            this.Size = new System.Drawing.Size(312, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

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

        //自定义事件
        public event EventHandler ReturnPressed;

        private void edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == '\r')
            {
                //ReturnPressed?.Invoke(this,e);
                if (ReturnPressed != null)
                {
                    ReturnPressed.Invoke(this, e);
                }
            }
        }
    }
}
