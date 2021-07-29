using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp0902
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //访问钱先把modify改成public
            searchBox1.edit.Text = "Java";

            //添加事件处理
            searchBox1.btn.Click += new EventHandler(this.onSearch);

        }

        public void onSearch(object sender, EventArgs e)
        {
            //MessageBox.Show("开始搜索: " + searchBox1.edit.Text.Trim());
        }

        private void searchBox1_SearchEvent(object sender, EventArgs e)
        {
            MessageBox.Show("开始搜索: " + searchBox1.edit.Text.Trim());
        }

    }
}
