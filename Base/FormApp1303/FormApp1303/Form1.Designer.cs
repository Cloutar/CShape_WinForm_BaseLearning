namespace FormApp1303
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "张三",
            "李四",
            "王五",
            "梁六",
            "封七"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(402, 263);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Add,
            this.menuItem_Edit,
            this.menuItem_Del});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // menuItem_Add
            // 
            this.menuItem_Add.Name = "menuItem_Add";
            this.menuItem_Add.Size = new System.Drawing.Size(100, 22);
            this.menuItem_Add.Text = "添加";
            // 
            // menuItem_Edit
            // 
            this.menuItem_Edit.Name = "menuItem_Edit";
            this.menuItem_Edit.Size = new System.Drawing.Size(100, 22);
            this.menuItem_Edit.Text = "编辑";
            // 
            // menuItem_Del
            // 
            this.menuItem_Del.Name = "menuItem_Del";
            this.menuItem_Del.Size = new System.Drawing.Size(100, 22);
            this.menuItem_Del.Text = "删除";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 263);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Add;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Del;
    }
}

