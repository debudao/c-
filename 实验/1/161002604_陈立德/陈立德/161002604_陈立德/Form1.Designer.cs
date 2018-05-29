namespace _161002604_陈立德
{
    partial class frm陈立德
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
            this.components = new System.ComponentModel.Container();
            this.cmdFind = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.txtPaper = new System.Windows.Forms.TextBox();
            this.txtFinding = new System.Windows.Forms.TextBox();
            this.txtReplacing = new System.Windows.Forms.TextBox();
            this.lblFinded = new System.Windows.Forms.Label();
            this.lblReplaced = new System.Windows.Forms.Label();
            this.cmdReset = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // cmdFind
            // 
            this.cmdFind.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdFind.Location = new System.Drawing.Point(46, 124);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(94, 56);
            this.cmdFind.TabIndex = 0;
            this.cmdFind.Text = "查找";
            this.cmdFind.UseVisualStyleBackColor = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            this.cmdFind.MouseHover += new System.EventHandler(this.cmdFind_MouseHover);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(555, 424);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(94, 56);
            this.cmdExit.TabIndex = 1;
            this.cmdExit.Text = "退出";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // txtPaper
            // 
            this.txtPaper.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPaper.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPaper.HideSelection = false;
            this.txtPaper.Location = new System.Drawing.Point(212, 23);
            this.txtPaper.Multiline = true;
            this.txtPaper.Name = "txtPaper";
            this.txtPaper.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPaper.Size = new System.Drawing.Size(384, 207);
            this.txtPaper.TabIndex = 2;
            this.txtPaper.Text = "请在这里输入文章";
            this.txtPaper.Enter += new System.EventHandler(this.txtPaper_Enter_1);
            // 
            // txtFinding
            // 
            this.txtFinding.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFinding.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFinding.Location = new System.Drawing.Point(212, 236);
            this.txtFinding.Multiline = true;
            this.txtFinding.Name = "txtFinding";
            this.txtFinding.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFinding.Size = new System.Drawing.Size(384, 56);
            this.txtFinding.TabIndex = 2;
            this.txtFinding.Text = "请在这里输入要查找的单词";
            this.txtFinding.Enter += new System.EventHandler(this.txtFinding_Enter);
            // 
            // txtReplacing
            // 
            this.txtReplacing.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtReplacing.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtReplacing.Location = new System.Drawing.Point(212, 310);
            this.txtReplacing.Multiline = true;
            this.txtReplacing.Name = "txtReplacing";
            this.txtReplacing.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReplacing.Size = new System.Drawing.Size(384, 56);
            this.txtReplacing.TabIndex = 2;
            this.txtReplacing.Text = "请在这里输入要替换的单词";
            this.txtReplacing.Enter += new System.EventHandler(this.txtReplacing_Enter);
            // 
            // lblFinded
            // 
            this.lblFinded.AutoSize = true;
            this.lblFinded.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFinded.Location = new System.Drawing.Point(75, 405);
            this.lblFinded.Name = "lblFinded";
            this.lblFinded.Size = new System.Drawing.Size(149, 19);
            this.lblFinded.TabIndex = 6;
            this.lblFinded.Text = "总共查找次数：";
            // 
            // lblReplaced
            // 
            this.lblReplaced.AutoSize = true;
            this.lblReplaced.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReplaced.Location = new System.Drawing.Point(75, 461);
            this.lblReplaced.Name = "lblReplaced";
            this.lblReplaced.Size = new System.Drawing.Size(149, 19);
            this.lblReplaced.TabIndex = 7;
            this.lblReplaced.Text = "总共替换次数：";
            // 
            // cmdReset
            // 
            this.cmdReset.Location = new System.Drawing.Point(46, 222);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(94, 56);
            this.cmdReset.TabIndex = 8;
            this.cmdReset.Text = "重置";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // frm陈立德
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 502);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.lblReplaced);
            this.Controls.Add(this.lblFinded);
            this.Controls.Add(this.txtReplacing);
            this.Controls.Add(this.txtFinding);
            this.Controls.Add(this.txtPaper);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm陈立德";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm陈立德";
            this.Load += new System.EventHandler(this.frm陈立德_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.TextBox txtPaper;
        private System.Windows.Forms.TextBox txtFinding;
        private System.Windows.Forms.TextBox txtReplacing;
        private System.Windows.Forms.Label lblFinded;
        private System.Windows.Forms.Label lblReplaced;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

