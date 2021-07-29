namespace FormApp0902
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
            this.searchBox1 = new FormApp0902.SearchBox();
            this.SuspendLayout();
            // 
            // searchBox1
            // 
            this.searchBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.searchBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox1.Location = new System.Drawing.Point(23, 52);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.SearchText = "大家好";
            this.searchBox1.Size = new System.Drawing.Size(216, 45);
            this.searchBox1.TabIndex = 0;
            this.searchBox1.Text = "大家好";
            this.searchBox1.Xyz = null;
            this.searchBox1.SearchEvent += new System.EventHandler(this.searchBox1_SearchEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.searchBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SearchBox searchBox1;
    }
}

