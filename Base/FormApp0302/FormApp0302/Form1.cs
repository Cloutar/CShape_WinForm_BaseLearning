using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp0302
{
    public partial class Form1 : Form
    {
        private Button testButton = new Button();

        public Form1()
        {
            InitializeComponent();

            //InitializeComponent是初始化界面
            //
            this.Controls.Add(testButton);
            testButton.Text = "我的测试";
            testButton.Location = new Point(40, 40);
            testButton.Size = new Size(100, 40);
        }
    }
}
