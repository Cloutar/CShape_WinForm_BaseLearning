using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp1502
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitGridView();
        }

        private void InitGridView()
        {
            //列的设置
            this.dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "学号";
            dataGridView1.Columns[1].Name = "姓名";
            dataGridView1.Columns[2].Name = "性别";
            dataGridView1.Columns[3].Name = "手机号";

            AddRow(new Student(20201001, "shao", true, "18024165555"));
            AddRow(new Student(20201002, "li", false, "18024164444"));
            AddRow(new Student(20201003, "wang", true, "18024163333"));
        }

        private void AddRow(Student student)
        {
            object[] row = {
                               student.Code,
                               student.Name,
                               student.Sex ? "男" : "女",
                               student.Phone
                           };
            dataGridView1.Rows.Add(row);
        }

        /// <summary>
        /// 添加一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            object[] row = new object[4];
            row[0] = 20201004;
            row[1] = "zhang";
            row[2] = "男";
            row[3] = "13899990000";
            dataGridView1.Rows.Add(row);
        }

        /// <summary>
        /// 获取表格的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //注意顺序 [col, row]
                object code = dataGridView1[0, i].Value;
                object name = dataGridView1[1, i].Value;
                object sex = dataGridView1.Rows[i].Cells[2].Value;
                object phone = dataGridView1.Rows[i].Cells[3].Value;
                Console.WriteLine("{0}, {1}, {2}, {3}", code, name, sex, phone);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //单项删除
            //dataGridView1.Rows.RemoveAt(0);

            //多项删除
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }
    }
}
