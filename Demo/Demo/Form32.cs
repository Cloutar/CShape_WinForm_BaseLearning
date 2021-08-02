using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form32 : Form
    {
        string SID;

        public Form32()
        {
            InitializeComponent();
        }

        public Form32(string sid)
        {
            InitializeComponent();
            this.SID = sid;
            string sql = "SELECT * FROM Student WHERE Id = '" + SID + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            dr.Read();
            textBox1.Text = dr["PassWord"].ToString();
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Student SET PassWord = '" + textBox2.Text + "' WHERE Id = '" + SID + "'";
            Dao dao = new Dao();
            dao.Excute(sql);
            int i = dao.Excute(sql);
            if (i > 0)
            {
                MessageBox.Show("修改成功");
            }
        }
    }
}
