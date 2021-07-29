using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp1401
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitListView();
        }

        private void InitListView()
        {
            //设置显示模式
            listView1.View = View.Details;
            //整行选中
            listView1.FullRowSelect = true;

            //设置列名
            //宽度值-2表示自动调整宽度
            listView1.Columns.Add("文件名", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("修改时间", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("类型", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("大小", -2, HorizontalAlignment.Left);

            //添加数据项
            ListViewItem item1 = new ListViewItem("Java学习指南.pdf", 0);
            //添加子项数据
            item1.SubItems.Add("2020-2-20 12:10");
            item1.SubItems.Add("PDF");
            item1.SubItems.Add("192 KB");
            listView1.Items.Add(item1);
        }
    }



}
