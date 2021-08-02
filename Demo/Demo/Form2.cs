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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
            Table();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();   //结束整个程序
        }

        //让表显示数据
        public void Table()
        {
            string sql = "select * from Student";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d, e;
                a = dr["Id"].ToString();
                b = dr["Name"].ToString();
                c = dr["Class"].ToString();
                d = dr["Birthday"].ToString();
                e = dr["JG"].ToString();
                string[] str = {a, b, c, d, e};
                dataGridView1.Rows.Add(str);
            }
            dr.Close();   //关闭连接
        }

        private void 添加学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form21 f = new Form21(this);
            f.ShowDialog();
        }

        private void 修改学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] str = {
                               dataGridView1.SelectedCells[0].Value.ToString(),
                               dataGridView1.SelectedCells[1].Value.ToString(),
                               dataGridView1.SelectedCells[2].Value.ToString(),
                               dataGridView1.SelectedCells[3].Value.ToString(),
                               dataGridView1.SelectedCells[4].Value.ToString(),
                           };
            Form21 f = new Form21(str, this);
            f.ShowDialog();
        }

        private void 删除学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定要删除吗? ", "提示", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                string id, name;
                id = dataGridView1.SelectedCells[0].Value.ToString();
                name = dataGridView1.SelectedCells[1].Value.ToString();
                string sql = "DELETE FROM Student WHERE Id = '" + id + "' AND Name = '" + name + "'";
                Dao dao = new Dao();
                dao.Excute(sql);
                Table();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
