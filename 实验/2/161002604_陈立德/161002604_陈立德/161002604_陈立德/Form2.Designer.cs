namespace _161002604_陈立德
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_lookup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lookupnum = new System.Windows.Forms.TextBox();
            this.lbl_hintmark = new System.Windows.Forms.Label();
            this.txt_score = new System.Windows.Forms.TextBox();
            this.button_addscore = new System.Windows.Forms.Button();
            this.button_delescore = new System.Windows.Forms.Button();
            this.listBox_score = new System.Windows.Forms.ListBox();
            this.button_grade = new System.Windows.Forms.Button();
            this.lbl_show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_lookup
            // 
            this.button_lookup.Location = new System.Drawing.Point(335, 18);
            this.button_lookup.Name = "button_lookup";
            this.button_lookup.Size = new System.Drawing.Size(91, 36);
            this.button_lookup.TabIndex = 0;
            this.button_lookup.Text = "查询";
            this.button_lookup.UseVisualStyleBackColor = true;
            this.button_lookup.Click += new System.EventHandler(this.button_lookup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(90, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "查询编号：";
            // 
            // txt_lookupnum
            // 
            this.txt_lookupnum.Location = new System.Drawing.Point(188, 26);
            this.txt_lookupnum.Name = "txt_lookupnum";
            this.txt_lookupnum.Size = new System.Drawing.Size(120, 21);
            this.txt_lookupnum.TabIndex = 2;
            // 
            // lbl_hintmark
            // 
            this.lbl_hintmark.AutoSize = true;
            this.lbl_hintmark.Location = new System.Drawing.Point(12, 218);
            this.lbl_hintmark.Name = "lbl_hintmark";
            this.lbl_hintmark.Size = new System.Drawing.Size(41, 12);
            this.lbl_hintmark.TabIndex = 3;
            this.lbl_hintmark.Text = "label2";
            // 
            // txt_score
            // 
            this.txt_score.Location = new System.Drawing.Point(161, 215);
            this.txt_score.Name = "txt_score";
            this.txt_score.ReadOnly = true;
            this.txt_score.Size = new System.Drawing.Size(81, 21);
            this.txt_score.TabIndex = 4;
            // 
            // button_addscore
            // 
            this.button_addscore.Enabled = false;
            this.button_addscore.Location = new System.Drawing.Point(254, 171);
            this.button_addscore.Name = "button_addscore";
            this.button_addscore.Size = new System.Drawing.Size(68, 30);
            this.button_addscore.TabIndex = 5;
            this.button_addscore.Text = "添加";
            this.button_addscore.UseVisualStyleBackColor = true;
            this.button_addscore.Click += new System.EventHandler(this.button_addscore_Click);
            // 
            // button_delescore
            // 
            this.button_delescore.Enabled = false;
            this.button_delescore.Location = new System.Drawing.Point(254, 246);
            this.button_delescore.Name = "button_delescore";
            this.button_delescore.Size = new System.Drawing.Size(68, 30);
            this.button_delescore.TabIndex = 6;
            this.button_delescore.Text = "删除";
            this.button_delescore.UseVisualStyleBackColor = true;
            this.button_delescore.Click += new System.EventHandler(this.button_delescore_Click);
            // 
            // listBox_score
            // 
            this.listBox_score.FormattingEnabled = true;
            this.listBox_score.HorizontalScrollbar = true;
            this.listBox_score.ItemHeight = 12;
            this.listBox_score.Location = new System.Drawing.Point(335, 119);
            this.listBox_score.Name = "listBox_score";
            this.listBox_score.Size = new System.Drawing.Size(211, 220);
            this.listBox_score.TabIndex = 7;
            // 
            // button_grade
            // 
            this.button_grade.Enabled = false;
            this.button_grade.Location = new System.Drawing.Point(417, 345);
            this.button_grade.Name = "button_grade";
            this.button_grade.Size = new System.Drawing.Size(84, 34);
            this.button_grade.TabIndex = 8;
            this.button_grade.Text = "评分";
            this.button_grade.UseVisualStyleBackColor = true;
            this.button_grade.Click += new System.EventHandler(this.button_grade_Click);
            // 
            // lbl_show
            // 
            this.lbl_show.AutoSize = true;
            this.lbl_show.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_show.Location = new System.Drawing.Point(11, 352);
            this.lbl_show.Name = "lbl_show";
            this.lbl_show.Size = new System.Drawing.Size(56, 16);
            this.lbl_show.TabIndex = 9;
            this.lbl_show.Text = "label2";
            // 
            // Form2
            // 
            this.AcceptButton = this.button_addscore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 406);
            this.Controls.Add(this.lbl_show);
            this.Controls.Add(this.button_grade);
            this.Controls.Add(this.listBox_score);
            this.Controls.Add(this.button_delescore);
            this.Controls.Add(this.button_addscore);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.lbl_hintmark);
            this.Controls.Add(this.txt_lookupnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_lookup);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打分";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_lookup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_lookupnum;
        private System.Windows.Forms.Label lbl_hintmark;
        private System.Windows.Forms.TextBox txt_score;
        private System.Windows.Forms.Button button_addscore;
        private System.Windows.Forms.Button button_delescore;
        private System.Windows.Forms.ListBox listBox_score;
        private System.Windows.Forms.Button button_grade;
        private System.Windows.Forms.Label lbl_show;
    }
}