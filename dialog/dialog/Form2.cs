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
    //声明委托和事件
    public delegate void TransfDelegate(String value);

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event TransfDelegate TransfEvent;
        private void button1_Click(object sender, EventArgs e)
        {
            //触发事件
            TransfEvent(textBox1.Text);
            this.Close();
        }
    }
}
