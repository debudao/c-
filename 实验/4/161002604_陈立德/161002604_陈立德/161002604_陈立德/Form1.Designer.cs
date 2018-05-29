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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_fine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_replace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_all = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_style = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_changeline = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_font = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_open = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_copy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_cut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_all = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_find = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_replace = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_bold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_ilalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_underline = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBox_body = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_file,
            this.mnu_edit,
            this.mnu_style});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_file
            // 
            this.mnu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_open,
            this.mnu_save,
            this.toolStripMenuItem1,
            this.mnu_exit});
            this.mnu_file.Name = "mnu_file";
            this.mnu_file.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.mnu_file.Size = new System.Drawing.Size(58, 21);
            this.mnu_file.Text = "文件(&F)";
            // 
            // mnu_open
            // 
            this.mnu_open.Name = "mnu_open";
            this.mnu_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnu_open.Size = new System.Drawing.Size(165, 22);
            this.mnu_open.Text = "打开(&O)";
            this.mnu_open.Click += new System.EventHandler(this.mnu_open_Click);
            // 
            // mnu_save
            // 
            this.mnu_save.Name = "mnu_save";
            this.mnu_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnu_save.Size = new System.Drawing.Size(165, 22);
            this.mnu_save.Text = "保存(&S)";
            this.mnu_save.Click += new System.EventHandler(this.mnu_save_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // mnu_exit
            // 
            this.mnu_exit.Name = "mnu_exit";
            this.mnu_exit.Size = new System.Drawing.Size(165, 22);
            this.mnu_exit.Text = "退出(X)";
            this.mnu_exit.Click += new System.EventHandler(this.mnu_exit_Click);
            // 
            // mnu_edit
            // 
            this.mnu_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_cut,
            this.mnu_copy,
            this.mnu_paste,
            this.toolStripMenuItem2,
            this.mnu_fine,
            this.mnu_replace,
            this.toolStripMenuItem3,
            this.mnu_all});
            this.mnu_edit.Name = "mnu_edit";
            this.mnu_edit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.mnu_edit.Size = new System.Drawing.Size(59, 21);
            this.mnu_edit.Text = "编辑(&E)";
            // 
            // mnu_cut
            // 
            this.mnu_cut.Name = "mnu_cut";
            this.mnu_cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnu_cut.Size = new System.Drawing.Size(162, 22);
            this.mnu_cut.Text = "剪切(&T)";
            this.mnu_cut.Click += new System.EventHandler(this.mnu_cut_Click);
            // 
            // mnu_copy
            // 
            this.mnu_copy.Name = "mnu_copy";
            this.mnu_copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnu_copy.Size = new System.Drawing.Size(162, 22);
            this.mnu_copy.Text = "复制(&C)";
            this.mnu_copy.Click += new System.EventHandler(this.mnu_copy_Click);
            // 
            // mnu_paste
            // 
            this.mnu_paste.Name = "mnu_paste";
            this.mnu_paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnu_paste.Size = new System.Drawing.Size(162, 22);
            this.mnu_paste.Text = "粘贴(&P)";
            this.mnu_paste.Click += new System.EventHandler(this.mnu_paste_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 6);
            // 
            // mnu_fine
            // 
            this.mnu_fine.Name = "mnu_fine";
            this.mnu_fine.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnu_fine.Size = new System.Drawing.Size(162, 22);
            this.mnu_fine.Text = "查找(&F)";
            this.mnu_fine.Click += new System.EventHandler(this.mnu_fine_Click);
            // 
            // mnu_replace
            // 
            this.mnu_replace.Name = "mnu_replace";
            this.mnu_replace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mnu_replace.Size = new System.Drawing.Size(162, 22);
            this.mnu_replace.Text = "替换(&R)";
            this.mnu_replace.Click += new System.EventHandler(this.mnu_replace_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(159, 6);
            // 
            // mnu_all
            // 
            this.mnu_all.Name = "mnu_all";
            this.mnu_all.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnu_all.Size = new System.Drawing.Size(162, 22);
            this.mnu_all.Text = "全选(&A)";
            this.mnu_all.Click += new System.EventHandler(this.mnu_all_Click);
            // 
            // mnu_style
            // 
            this.mnu_style.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_changeline,
            this.mnu_font});
            this.mnu_style.Name = "mnu_style";
            this.mnu_style.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.mnu_style.Size = new System.Drawing.Size(62, 21);
            this.mnu_style.Text = "格式(&O)";
            // 
            // mnu_changeline
            // 
            this.mnu_changeline.Checked = true;
            this.mnu_changeline.CheckOnClick = true;
            this.mnu_changeline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnu_changeline.Name = "mnu_changeline";
            this.mnu_changeline.Size = new System.Drawing.Size(144, 22);
            this.mnu_changeline.Text = "自动换行(&W)";
            this.mnu_changeline.Click += new System.EventHandler(this.mnu_changeline_Click);
            // 
            // mnu_font
            // 
            this.mnu_font.Name = "mnu_font";
            this.mnu_font.Size = new System.Drawing.Size(144, 22);
            this.mnu_font.Text = "字体(&F)";
            this.mnu_font.Click += new System.EventHandler(this.mnu_font_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_open,
            this.toolStripButton_save,
            this.toolStripSeparator1,
            this.toolStripButton_copy,
            this.toolStripButton_cut,
            this.toolStripButton_paste,
            this.toolStripButton_all,
            this.toolStripSeparator2,
            this.toolStripButton_find,
            this.toolStripButton_replace,
            this.toolStripSeparator3,
            this.toolStripButton_bold,
            this.toolStripButton_ilalic,
            this.toolStripButton_underline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(680, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_open
            // 
            this.toolStripButton_open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_open.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_open.Image")));
            this.toolStripButton_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_open.Name = "toolStripButton_open";
            this.toolStripButton_open.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_open.Text = "打开文件";
            this.toolStripButton_open.Click += new System.EventHandler(this.toolStripButton_open_Click);
            // 
            // toolStripButton_save
            // 
            this.toolStripButton_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_save.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_save.Image")));
            this.toolStripButton_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_save.Name = "toolStripButton_save";
            this.toolStripButton_save.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_save.Text = "保存文件";
            this.toolStripButton_save.Click += new System.EventHandler(this.toolStripButton_save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_copy
            // 
            this.toolStripButton_copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_copy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_copy.Image")));
            this.toolStripButton_copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_copy.Name = "toolStripButton_copy";
            this.toolStripButton_copy.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_copy.Text = "复制";
            this.toolStripButton_copy.Click += new System.EventHandler(this.toolStripButton_copy_Click);
            // 
            // toolStripButton_cut
            // 
            this.toolStripButton_cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_cut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_cut.Image")));
            this.toolStripButton_cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_cut.Name = "toolStripButton_cut";
            this.toolStripButton_cut.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_cut.Text = "剪切";
            this.toolStripButton_cut.Click += new System.EventHandler(this.toolStripButton_cut_Click);
            // 
            // toolStripButton_paste
            // 
            this.toolStripButton_paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_paste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_paste.Image")));
            this.toolStripButton_paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_paste.Name = "toolStripButton_paste";
            this.toolStripButton_paste.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_paste.Text = "粘贴";
            this.toolStripButton_paste.Click += new System.EventHandler(this.toolStripButton_paste_Click);
            // 
            // toolStripButton_all
            // 
            this.toolStripButton_all.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_all.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_all.Image")));
            this.toolStripButton_all.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_all.Name = "toolStripButton_all";
            this.toolStripButton_all.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_all.Text = "全选";
            this.toolStripButton_all.Click += new System.EventHandler(this.toolStripButton_all_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_find
            // 
            this.toolStripButton_find.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_find.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_find.Image")));
            this.toolStripButton_find.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_find.Name = "toolStripButton_find";
            this.toolStripButton_find.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_find.Text = "查找";
            this.toolStripButton_find.Click += new System.EventHandler(this.toolStripButton_find_Click);
            // 
            // toolStripButton_replace
            // 
            this.toolStripButton_replace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_replace.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_replace.Image")));
            this.toolStripButton_replace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_replace.Name = "toolStripButton_replace";
            this.toolStripButton_replace.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_replace.Text = "toolStripButton2";
            this.toolStripButton_replace.ToolTipText = "替换";
            this.toolStripButton_replace.Click += new System.EventHandler(this.toolStripButton_replace_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_bold
            // 
            this.toolStripButton_bold.CheckOnClick = true;
            this.toolStripButton_bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_bold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_bold.Image")));
            this.toolStripButton_bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_bold.Name = "toolStripButton_bold";
            this.toolStripButton_bold.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_bold.Text = "粗体";
            this.toolStripButton_bold.Click += new System.EventHandler(this.toolStripButton_bold_Click);
            // 
            // toolStripButton_ilalic
            // 
            this.toolStripButton_ilalic.CheckOnClick = true;
            this.toolStripButton_ilalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ilalic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ilalic.Image")));
            this.toolStripButton_ilalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ilalic.Name = "toolStripButton_ilalic";
            this.toolStripButton_ilalic.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_ilalic.Text = "斜体";
            this.toolStripButton_ilalic.Click += new System.EventHandler(this.toolStripButton_ilalic_Click);
            // 
            // toolStripButton_underline
            // 
            this.toolStripButton_underline.CheckOnClick = true;
            this.toolStripButton_underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_underline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_underline.Image")));
            this.toolStripButton_underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_underline.Name = "toolStripButton_underline";
            this.toolStripButton_underline.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_underline.Text = "下划线";
            this.toolStripButton_underline.Click += new System.EventHandler(this.toolStripButton_underline_Click);
            // 
            // richTextBox_body
            // 
            this.richTextBox_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_body.HideSelection = false;
            this.richTextBox_body.Location = new System.Drawing.Point(0, 53);
            this.richTextBox_body.Name = "richTextBox_body";
            this.richTextBox_body.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox_body.Size = new System.Drawing.Size(680, 421);
            this.richTextBox_body.TabIndex = 2;
            this.richTextBox_body.Text = "";
            this.richTextBox_body.SelectionChanged += new System.EventHandler(this.richTextBox_body_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 475);
            this.Controls.Add(this.richTextBox_body);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "记事本";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_file;
        private System.Windows.Forms.ToolStripMenuItem mnu_open;
        private System.Windows.Forms.ToolStripMenuItem mnu_save;
        private System.Windows.Forms.ToolStripMenuItem mnu_exit;
        private System.Windows.Forms.ToolStripMenuItem mnu_edit;
        private System.Windows.Forms.ToolStripMenuItem mnu_cut;
        private System.Windows.Forms.ToolStripMenuItem mnu_copy;
        private System.Windows.Forms.ToolStripMenuItem mnu_paste;
        private System.Windows.Forms.ToolStripMenuItem mnu_fine;
        private System.Windows.Forms.ToolStripMenuItem mnu_replace;
        private System.Windows.Forms.ToolStripMenuItem mnu_all;
        private System.Windows.Forms.ToolStripMenuItem mnu_style;
        private System.Windows.Forms.ToolStripMenuItem mnu_font;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_open;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_save;
        private System.Windows.Forms.ToolStripButton toolStripButton_copy;
        private System.Windows.Forms.ToolStripButton toolStripButton_cut;
        private System.Windows.Forms.ToolStripButton toolStripButton_paste;
        private System.Windows.Forms.ToolStripButton toolStripButton_all;
        private System.Windows.Forms.ToolStripMenuItem mnu_changeline;
        public System.Windows.Forms.RichTextBox richTextBox_body;
        private System.Windows.Forms.ToolStripButton toolStripButton_find;
        private System.Windows.Forms.ToolStripButton toolStripButton_replace;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton_bold;
        private System.Windows.Forms.ToolStripButton toolStripButton_ilalic;
        private System.Windows.Forms.ToolStripButton toolStripButton_underline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

