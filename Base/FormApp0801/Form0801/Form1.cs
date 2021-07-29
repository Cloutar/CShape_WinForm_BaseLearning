using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form0801
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Bitmap img = new Bitmap("C:\\Users\\fcrit\\Desktop\\小型企业无线VPN的网络拓扑结构图.jpg");
            int w = img.Width;
            int h = img.Height;

            //缩放
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //显示图片
            //pictureBox1.Image = img;

            pictureBox1.Load("C:\\Users\\fcrit\\Desktop\\小型企业无线VPN的网络拓扑结构图.jpg");
        }
    }
}
