using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp0402
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            testButton.Click += new EventHandler(this.OnTest);
        }

        public void OnTest(object sender, EventArgs e)
        {
            MessageBox.Show("大家好");
        }
    }
}
