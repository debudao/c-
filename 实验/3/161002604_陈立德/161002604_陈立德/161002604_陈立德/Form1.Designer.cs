namespace _161002604_陈立德
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dirListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DirListBox();
            this.driveListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DriveListBox();
            this.fileListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.FileListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_lastone = new System.Windows.Forms.Button();
            this.button_nextone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dirListBox1
            // 
            this.dirListBox1.FormattingEnabled = true;
            this.dirListBox1.IntegralHeight = false;
            this.dirListBox1.Location = new System.Drawing.Point(23, 53);
            this.dirListBox1.Name = "dirListBox1";
            this.dirListBox1.Size = new System.Drawing.Size(205, 194);
            this.dirListBox1.TabIndex = 0;
            this.dirListBox1.SelectedIndexChanged += new System.EventHandler(this.dirListBox1_SelectedIndexChanged);
            // 
            // driveListBox1
            // 
            this.driveListBox1.FormattingEnabled = true;
            this.driveListBox1.Location = new System.Drawing.Point(56, 12);
            this.driveListBox1.Name = "driveListBox1";
            this.driveListBox1.Size = new System.Drawing.Size(139, 22);
            this.driveListBox1.TabIndex = 1;
            this.driveListBox1.SelectedIndexChanged += new System.EventHandler(this.driveListBox1_SelectedIndexChanged);
            // 
            // fileListBox1
            // 
            this.fileListBox1.FormattingEnabled = true;
            this.fileListBox1.Location = new System.Drawing.Point(23, 258);
            this.fileListBox1.Name = "fileListBox1";
            this.fileListBox1.Pattern = "*.jpg;*.png;*.bmp";
            this.fileListBox1.Size = new System.Drawing.Size(205, 160);
            this.fileListBox1.TabIndex = 2;
            this.fileListBox1.SelectedIndexChanged += new System.EventHandler(this.fileListBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(258, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button_lastone
            // 
            this.button_lastone.Location = new System.Drawing.Point(258, 377);
            this.button_lastone.Name = "button_lastone";
            this.button_lastone.Size = new System.Drawing.Size(90, 41);
            this.button_lastone.TabIndex = 4;
            this.button_lastone.Text = "上一张";
            this.button_lastone.UseVisualStyleBackColor = true;
            this.button_lastone.Click += new System.EventHandler(this.button_lastone_Click);
            // 
            // button_nextone
            // 
            this.button_nextone.Location = new System.Drawing.Point(494, 377);
            this.button_nextone.Name = "button_nextone";
            this.button_nextone.Size = new System.Drawing.Size(90, 41);
            this.button_nextone.TabIndex = 5;
            this.button_nextone.Text = "下一张";
            this.button_nextone.UseVisualStyleBackColor = true;
            this.button_nextone.Click += new System.EventHandler(this.button_nextone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 428);
            this.Controls.Add(this.button_nextone);
            this.Controls.Add(this.button_lastone);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fileListBox1);
            this.Controls.Add(this.driveListBox1);
            this.Controls.Add(this.dirListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.Compatibility.VB6.DirListBox dirListBox1;
        private Microsoft.VisualBasic.Compatibility.VB6.DriveListBox driveListBox1;
        private Microsoft.VisualBasic.Compatibility.VB6.FileListBox fileListBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_lastone;
        private System.Windows.Forms.Button button_nextone;
    }
}

