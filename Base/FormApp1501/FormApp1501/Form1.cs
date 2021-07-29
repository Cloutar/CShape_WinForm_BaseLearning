using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp1501
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
    }
}
