using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp0705
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox1.Items.Add(new Student("10000", "一哥"));
            listBox1.Items.Add(new Student("20000", "二哥"));

            listBox1.SetSelected(4, true);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //单选模式
            //listBox1.SelectedIndex
            //listBox1.SelectedItem

            //多选模式
            //listBox1.SelectedIndices
            //listBox1.SelectedItems

            foreach (object o in listBox1.SelectedItems)
            {
                Student stu = (Student)o;
                Console.WriteLine("选中了:" + stu.Name);
            }
        }


    }
}
