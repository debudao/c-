namespace _161002604_陈立德
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_find = new System.Windows.Forms.TextBox();
            this.textBox_replace = new System.Windows.Forms.TextBox();
            this.button_next = new System.Windows.Forms.Button();
            this.button_replace = new System.Windows.Forms.Button();
            this.button_replaceall = new System.Windows.Forms.Button();
            this.button_cansel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查找内容：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "替换为：";
            // 
            // textBox_find
            // 
            this.textBox_find.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_find.Location = new System.Drawing.Point(126, 27);
            this.textBox_find.Name = "textBox_find";
            this.textBox_find.Size = new System.Drawing.Size(285, 26);
            this.textBox_find.TabIndex = 2;
            this.textBox_find.TextChanged += new System.EventHandler(this.textBox_find_TextChanged);
            // 
            // textBox_replace
            // 
            this.textBox_replace.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_replace.Location = new System.Drawing.Point(126, 74);
            this.textBox_replace.Name = "textBox_replace";
            this.textBox_replace.Size = new System.Drawing.Size(285, 26);
            this.textBox_replace.TabIndex = 3;
            // 
            // button_next
            // 
            this.button_next.Enabled = false;
            this.button_next.Location = new System.Drawing.Point(477, 11);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(86, 35);
            this.button_next.TabIndex = 4;
            this.button_next.Text = "查找下一个";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_replace
            // 
            this.button_replace.Enabled = false;
            this.button_replace.Location = new System.Drawing.Point(477, 52);
            this.button_replace.Name = "button_replace";
            this.button_replace.Size = new System.Drawing.Size(86, 35);
            this.button_replace.TabIndex = 5;
            this.button_replace.Text = "替换";
            this.button_replace.UseVisualStyleBackColor = true;
            this.button_replace.Click += new System.EventHandler(this.button_replace_Click);
            // 
            // button_replaceall
            // 
            this.button_replaceall.Enabled = false;
            this.button_replaceall.Location = new System.Drawing.Point(477, 93);
            this.button_replaceall.Name = "button_replaceall";
            this.button_replaceall.Size = new System.Drawing.Size(86, 35);
            this.button_replaceall.TabIndex = 6;
            this.button_replaceall.Text = "全部替换";
            this.button_replaceall.UseVisualStyleBackColor = true;
            this.button_replaceall.Click += new System.EventHandler(this.button_replaceall_Click);
            // 
            // button_cansel
            // 
            this.button_cansel.Location = new System.Drawing.Point(477, 134);
            this.button_cansel.Name = "button_cansel";
            this.button_cansel.Size = new System.Drawing.Size(86, 35);
            this.button_cansel.TabIndex = 7;
            this.button_cansel.Text = "取消";
            this.button_cansel.UseVisualStyleBackColor = true;
            this.button_cansel.Click += new System.EventHandler(this.button_cansel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 209);
            this.Controls.Add(this.button_cansel);
            this.Controls.Add(this.button_replaceall);
            this.Controls.Add(this.button_replace);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.textBox_replace);
            this.Controls.Add(this.textBox_find);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "替换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_find;
        private System.Windows.Forms.TextBox textBox_replace;
        private System.Windows.Forms.Button button_replace;
        private System.Windows.Forms.Button button_replaceall;
        private System.Windows.Forms.Button button_cansel;
        private System.Windows.Forms.Button button_next;
    }
}