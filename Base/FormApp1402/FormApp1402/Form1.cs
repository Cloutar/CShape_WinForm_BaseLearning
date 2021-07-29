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

namespace FormApp1402
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitListView();

            LoadDir(new DirectoryInfo("c:\\"));
        }

        private void InitListView()
        {
            //设置显示模式
            listView1.View = View.Details;
            //整行选中
            listView1.FullRowSelect = true;

            //设置列名
            //宽度值-2表示自动调整宽度
            listView1.Columns.Add("文件名", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("修改时间", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("类型", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("大小", -2, HorizontalAlignment.Center);

            //创建ImageList, 并添加两个小图标
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(16, 16);
            imageList.Images.Add(Properties.Resources.Ico_Folder);
            imageList.Images.Add(Properties.Resources.Ico_File);
            //设置SmallImageList用于显示
            listView1.SmallImageList = imageList;
        }

        public void LoadDir(DirectoryInfo dir)
        {
            //子目录
            DirectoryInfo[] subDirs = dir.GetDirectories();
            foreach (DirectoryInfo d in subDirs)
            {
                if ((d.Attributes & FileAttributes.Hidden) > 0) continue;

                AddListItem(d.Name, d.LastWriteTime, "文件夹", -1);
            }
            //子文件
            FileInfo[] subFiles = dir.GetFiles();
            foreach (FileInfo f in subFiles)
            {
                if ((f.Attributes & FileAttributes.Hidden) > 0) continue;

                string ext = f.Extension.ToUpper();   //后缀
                AddListItem(f.Name, f.LastWriteTime, ext, f.Length);
            }
        }

        public void AddListItem(string label
            , DateTime time
            , string type
            , long size)
        {
            // 判断是文件还是文件夹, 使用不同的图标\
            int imageIndex = 0;
            if (!type.Equals("文件夹")) imageIndex = 1;

            ListViewItem item = new ListViewItem(label, imageIndex);

            // 时间
            item.SubItems.Add(time.ToString("yyyy-MM-dd HH:mm"));
            //类型
            item.SubItems.Add(type);
            //文件大小
            string sizeStr = "";
            if (size < 0)
            {
                sizeStr = ""; //文件夹不显示大小
            }
            else if (size < 1000)
            {
                sizeStr = "" + size;
            }
            else if (size < 1000000)
            {
                sizeStr = size / 1000 + " KB";
            }
            else if (size < 1000000000)
            {
                sizeStr = size / 1000000 + " MB";
            }
            else
            {
                sizeStr = size / 1000000000 + " GB";
            }

            item.SubItems.Add(sizeStr);

            listView1.Items.Add(item);
        }
    }
}
