using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp0704
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //使用Add或Insert可以添加项
            comboBox1.Items.Add("代码1");
            comboBox1.Items.Add("代码2");
            comboBox1.Items.Add("代码3");

            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SelectedItem : 选中项的值, null表示未选中
            //SelectedIndex : 选中项的索引, -1表示未选中
            int index = comboBox1.SelectedIndex;
            string sel = (string)comboBox1.SelectedItem;
            Console.WriteLine("选中了: " + sel);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("现在选中的是: " + comboBox1.SelectedItem);
        }
    }
}
