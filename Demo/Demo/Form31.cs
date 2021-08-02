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
    public partial class Form31 : Form
    {
        string SID;

        public Form31(string sID)
        {
            SID = sID;
            InitializeComponent();
            Table();
        }

        public void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select * from CourseRecord where sId = '" + SID + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string cID = dr["cId"].ToString();
                string sql2 = "SELECT * FROM Course WHERE Id = '" + cID + "'";
                IDataReader dr2 = dao.read(sql2);
                dr2.Read();
                string a, b, c, d;
                a = dr2["Id"].ToString();
                b = dr2["Name"].ToString();
                c = dr2["Teacher"].ToString();
                d = dr2["Credit"].ToString();
                string[] str = { a, b, c, d };
                dataGridView1.Rows.Add(str);
                dr2.Close();
            }
            dr.Close();   //关闭连接
        }

        private void 取消选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cID = dataGridView1.SelectedCells[0].Value.ToString();
            string sql = "DELETE FROM CourseRecord WHERE sId = '" + SID + "' AND cId = '" + cID + "'";
            Dao dao = new Dao();
            dao.Excute(sql);
            Table();
        }
    }
}
