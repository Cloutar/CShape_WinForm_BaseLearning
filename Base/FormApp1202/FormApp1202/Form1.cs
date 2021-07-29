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

namespace FormApp1202
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击浏览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string dir = dlg.SelectedPath;
                this.afTextBox1.Text = dir;
                //加载图片列表
                ShowPictureList(dir);
            }
        }

        /// <summary>
        /// 获取图片列表
        /// </summary>
        /// <param name="dir"></param>
        private void ShowPictureList(string dir)
        {
            //清空显示
            this.listBox1.Items.Clear();
            //遍历所有的文件, 检查文件名后缀
            string[] fff = Directory.GetFiles(dir);
            foreach (string f in fff)
            {
                if (f.EndsWith(".jpg") 
                    || f.EndsWith(".jpeg") 
                    || f.EndsWith(".png"))
                {
                    //取得文件名
                    PictureListItem item = new PictureListItem();
                    item.filePath = f;
                    item.name = Path.GetFileName(f);
                    //加到列表框显示
                    this.listBox1.Items.Add(item);
                }
            }
            //默认打开第一个文件
            if (listBox1.Items.Count > 0)
            {
                this.listBox1.SetSelected(0, true);
            }
        }

        /// <summary>
        /// 点击列表框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PictureListItem item = (PictureListItem)listBox1.SelectedItem;
            if (item == null) return;

            this.pictureBox1.Load(item.filePath);
        }
    }

    /// <summary>
    /// 文件类
    /// </summary>
    class PictureListItem
    {
        public string name;
        public string filePath;

        public override string ToString()
        {
            return name;
        }
    }
}
