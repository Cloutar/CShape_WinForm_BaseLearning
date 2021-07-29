using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp1201
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".cs";
            dlg.Filter = "C#源码文件 | *.cs";
            dlg.InitialDirectory = Path.GetFullPath(".");

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName;
                Console.WriteLine("选中了:" + fileName);
            }
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "新的文本文件";
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt) | *.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName;
                Console.WriteLine("选中了:" + fileName);
            }

        }

        /// <summary>
        /// 选择目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string path = dlg.SelectedPath;
                Console.WriteLine("选中了:" + path);
            }
        }

        /// <summary>
        /// 选择颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = button4.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                button4.ForeColor = MyDialog.Color;
            }
        }

        /// <summary>
        /// 选择字体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            fontDialog1.ShowColor = true;

            fontDialog1.Font = button5.Font;
            fontDialog1.Color = button5.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                button5.Font = fontDialog1.Font;
                button5.ForeColor = fontDialog1.Color;
            }

        }
    }
}
