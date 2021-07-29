using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("checkBox1_click");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("checkBox1_CheckedChanged");

            bool isChecked = checkBox1.Checked;
            if (isChecked)
            {
                passwordBox.PasswordChar = '\0';
            }
            else
            {
                passwordBox.PasswordChar = '*';
            }
        }

    }
}
