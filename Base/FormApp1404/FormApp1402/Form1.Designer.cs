namespace FormApp1402
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详情模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大图标模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(525, 315);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.详情模式ToolStripMenuItem,
            this.列表模式ToolStripMenuItem,
            this.大图标模式ToolStripMenuItem,
            this.小图标模式ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // 详情模式ToolStripMenuItem
            // 
            this.详情模式ToolStripMenuItem.Name = "详情模式ToolStripMenuItem";
            this.详情模式ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.详情模式ToolStripMenuItem.Text = "详情模式";
            this.详情模式ToolStripMenuItem.Click += new System.EventHandler(this.详情模式ToolStripMenuItem_Click);
            // 
            // 列表模式ToolStripMenuItem
            // 
            this.列表模式ToolStripMenuItem.Name = "列表模式ToolStripMenuItem";
            this.列表模式ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.列表模式ToolStripMenuItem.Text = "列表模式";
            this.列表模式ToolStripMenuItem.Click += new System.EventHandler(this.列表模式ToolStripMenuItem_Click);
            // 
            // 大图标模式ToolStripMenuItem
            // 
            this.大图标模式ToolStripMenuItem.Name = "大图标模式ToolStripMenuItem";
            this.大图标模式ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.大图标模式ToolStripMenuItem.Text = "大图标模式";
            this.大图标模式ToolStripMenuItem.Click += new System.EventHandler(this.大图标模式ToolStripMenuItem_Click);
            // 
            // 小图标模式ToolStripMenuItem
            // 
            this.小图标模式ToolStripMenuItem.Name = "小图标模式ToolStripMenuItem";
            this.小图标模式ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.小图标模式ToolStripMenuItem.Text = "小图标模式";
            this.小图标模式ToolStripMenuItem.Click += new System.EventHandler(this.小图标模式ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 315);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 详情模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大图标模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小图标模式ToolStripMenuItem;
    }
}

