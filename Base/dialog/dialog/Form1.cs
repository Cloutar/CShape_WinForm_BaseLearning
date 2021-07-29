using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            //注册事件
            form2.TransfEvent += form2_TransfEvent;
            form2.ShowDialog();
        }

        void form2_TransfEvent(String value)
        {
            textBox1.Text = value;
        }
    }
}
