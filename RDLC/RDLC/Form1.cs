using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDLC
{
    public partial class Form1 : Form
    {
        /**
         * RDLC: Report Definition Language: 报表定义语言
         * 默认文件rdl
         * 微软继承了RDL, Client: C;
         * VS2012有, vs2019没有
         * 
         * 报表技术: 主要用来打印; 水晶报表: SAP
         * ReportViewer: 报表视图控件
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“FCRI_JYS_2021DataSet.V02_WT”中。您可以根据需要移动或删除它。
            this.V02_WTTableAdapter.Fill(this.FCRI_JYS_2021DataSet.V02_WT);

            this.reportViewer1.RefreshReport();
        }
    }
}
