using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp1405
{
    public partial class Form1 : Form
    {
        //当前鼠标事件点中的项
        public ListViewItem mouseClickItem;

        public Form1()
        {
            InitializeComponent();

            InitListView();

            //添加几项数据
            AddListItem(new Student(202001001, "shao", "138100123456"));
            AddListItem(new Student(202001002, "wang", "138100000000"));
            AddListItem(new Student(202001003, "li", "138100111111"));
        }

        private void InitListView()
        {
            //设置显示模式
            listView1.View = View.Details;
            //整行选中
            //listView1.FullRowSelect = true;
            listView1.LabelEdit = true;

            //设置列名
            //宽度值-2表示自动调整宽度
            listView1.Columns.Add("姓名", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("学号", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("手机号", -2, HorizontalAlignment.Left);
        }

        private void AddListItem(Student student)
        {
            ListViewItem item = new ListViewItem(student.Name, 0);
            item.Tag = student;

            item.SubItems.Add(student.Code + "");
            item.SubItems.Add(student.Phone);
            listView1.Items.Add(item);
        }

        /// <summary>
        /// 鼠标右键点击, 弹出菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listView1.GetItemAt(e.X, e.Y);
                this.mouseClickItem = item;

                menu_Rename.Enabled = (item != null);

                contextMenuStrip1.Show(listView1, e.Location);
            }
        }

        /// <summary>
        /// 点击'重命名'菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_Rename_Click(object sender, EventArgs e)
        {
            this.mouseClickItem.BeginEdit();
        }

        /// <summary>
        /// 开启列表项的编辑(编辑前验证)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            //
        }

        /// <summary>
        /// 结束列表项的编辑(编辑之后验证)
        /// e.Item 表示编辑项的索引
        /// e.Label 表示文本框中的值
        /// e.CancelEdit 表示是否取消此次输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            int index = e.Item;   //当前项的索引
            string label = e.Label;   //新输入的文本

            //检查是否冲突
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (index == i) continue;
                if (label == listView1.Items[i].Text)
                {
                    e.CancelEdit = true;
                    MessageBox.Show("名字重复", "提示");
                    return;
                }
            }

            e.CancelEdit = false;   //接受此输入

            //更新后台数据
            Student stu = (Student)listView1.Items[index].Tag;
            stu.Name = label;
        }
        
    }
}
