using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp1303
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = listBox1.IndexFromPoint(e.Location);   //根据鼠标点击的位置, 判断点中了哪一项
                if (index >= 0)
                {
                    listBox1.SetSelected(index, true);  
                    menuItem_Edit.Enabled = true;
                    menuItem_Del.Enabled = true;
                }
                else
                {
                    menuItem_Edit.Enabled = false;
                    menuItem_Del.Enabled = false;

                    //menuItem_Add.Visible = true;
                }
                this.contextMenuStrip1.Show(this.listBox1, e.Location);
            }
        }
    }
}
