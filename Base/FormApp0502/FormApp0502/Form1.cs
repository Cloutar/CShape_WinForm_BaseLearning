using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp0502
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //TextBox默认AutoSize=ture (根据内容自动调整大小)
            this.textBox1.AutoSize = false;
        }

        /// <summary>
        /// 窗口自适应
        /// 1. TextBox: AutoSize = false 否则它会自己计算所需大小
        /// 2. Size包含标题栏 ClientSize不包含标题栏
        /// 3. 当窗口大小变化时, 会自动调用OnLayout()方法
        /// </summary>
        /// <param name="levent"></param>
        protected override void OnLayout(LayoutEventArgs levent)
        {
            //1. 调用父类的OnLayout(), 不是必需的
            base.OnLayout(levent);

            //2. 获取窗口大小ClienSize(仅客户区, 不含标题栏)
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            //3. 计算每一个控件的位置和大小
            int yoff = 0;

            yoff = 4;
            this.textBox1.Location = new Point(0, yoff);
            this.textBox1.Size = new Size(w - 80, 30);
            this.button1.Location = new Point(w - 80, yoff);
            this.button1.Size = new Size(80, 30);

            yoff += 30;  //第一行的高度
            yoff += 4;  //间隔
            this.pictureBox1.Location = new Point(0, yoff);
            this.pictureBox1.Size = new Size(w, h - yoff - 4);

        }
    }
}
