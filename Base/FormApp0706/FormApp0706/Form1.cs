using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp0706
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            sexField.Items.Add("女");
            sexField.Items.Add("男");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.Id = Convert.ToInt32(idField.Text.Trim());
            stu.Name = nameField.Text.Trim();
            stu.Sex = (sexField.SelectedIndex == 1);
            stu.Phone = phoneField.Text.Trim();

            MessageBox.Show(string.Format("操作成功: {0}-{1}-{2}-{3}", stu.Id, stu.Name, stu.Sex, stu.Phone));
        }
    }
}
