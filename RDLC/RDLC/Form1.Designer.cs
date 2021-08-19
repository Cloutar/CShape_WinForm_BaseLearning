namespace RDLC
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FCRI_JYS_2021DataSet = new RDLC.FCRI_JYS_2021DataSet();
            this.V02_WTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.V02_WTTableAdapter = new RDLC.FCRI_JYS_2021DataSetTableAdapters.V02_WTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FCRI_JYS_2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V02_WTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.V02_WTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RDLC.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(608, 454);
            this.reportViewer1.TabIndex = 0;
            // 
            // FCRI_JYS_2021DataSet
            // 
            this.FCRI_JYS_2021DataSet.DataSetName = "FCRI_JYS_2021DataSet";
            this.FCRI_JYS_2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // V02_WTBindingSource
            // 
            this.V02_WTBindingSource.DataMember = "V02_WT";
            this.V02_WTBindingSource.DataSource = this.FCRI_JYS_2021DataSet;
            // 
            // V02_WTTableAdapter
            // 
            this.V02_WTTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 454);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "报表打印";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FCRI_JYS_2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V02_WTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource V02_WTBindingSource;
        private FCRI_JYS_2021DataSet FCRI_JYS_2021DataSet;
        private FCRI_JYS_2021DataSetTableAdapters.V02_WTTableAdapter V02_WTTableAdapter;
    }
}

