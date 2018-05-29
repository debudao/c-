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
            this.lbl_judgesum = new System.Windows.Forms.Label();
            this.lbl_playersum = new System.Windows.Forms.Label();
            this.button_init = new System.Windows.Forms.Button();
            this.txt_judgesum = new System.Windows.Forms.TextBox();
            this.txt_palyersum = new System.Windows.Forms.TextBox();
            this.lbl_num = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_dele = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_mark = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_judgesum
            // 
            this.lbl_judgesum.AutoSize = true;
            this.lbl_judgesum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_judgesum.Location = new System.Drawing.Point(29, 40);
            this.lbl_judgesum.Name = "lbl_judgesum";
            this.lbl_judgesum.Size = new System.Drawing.Size(88, 16);
            this.lbl_judgesum.TabIndex = 0;
            this.lbl_judgesum.Text = "评委人数：";
            // 
            // lbl_playersum
            // 
            this.lbl_playersum.AutoSize = true;
            this.lbl_playersum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_playersum.Location = new System.Drawing.Point(255, 40);
            this.lbl_playersum.Name = "lbl_playersum";
            this.lbl_playersum.Size = new System.Drawing.Size(104, 16);
            this.lbl_playersum.TabIndex = 1;
            this.lbl_playersum.Text = "参赛者人数：";
            // 
            // button_init
            // 
            this.button_init.Location = new System.Drawing.Point(507, 34);
            this.button_init.Name = "button_init";
            this.button_init.Size = new System.Drawing.Size(72, 30);
            this.button_init.TabIndex = 2;
            this.button_init.Text = "确定";
            this.button_init.UseVisualStyleBackColor = true;
            this.button_init.Click += new System.EventHandler(this.button_init_Click);
            // 
            // txt_judgesum
            // 
            this.txt_judgesum.Location = new System.Drawing.Point(137, 37);
            this.txt_judgesum.Name = "txt_judgesum";
            this.txt_judgesum.Size = new System.Drawing.Size(82, 23);
            this.txt_judgesum.TabIndex = 3;
            // 
            // txt_palyersum
            // 
            this.txt_palyersum.Location = new System.Drawing.Point(364, 37);
            this.txt_palyersum.Name = "txt_palyersum";
            this.txt_palyersum.Size = new System.Drawing.Size(82, 23);
            this.txt_palyersum.TabIndex = 4;
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_num.Location = new System.Drawing.Point(66, 168);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(56, 16);
            this.lbl_num.TabIndex = 5;
            this.lbl_num.Text = "编号：";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_name.Location = new System.Drawing.Point(66, 243);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(56, 16);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "姓名：";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(125, 165);
            this.txt_num.Name = "txt_num";
            this.txt_num.ReadOnly = true;
            this.txt_num.Size = new System.Drawing.Size(110, 23);
            this.txt_num.TabIndex = 7;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(125, 240);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(110, 23);
            this.txt_name.TabIndex = 8;
            // 
            // button_add
            // 
            this.button_add.Enabled = false;
            this.button_add.Location = new System.Drawing.Point(291, 175);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(73, 30);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_dele
            // 
            this.button_dele.Enabled = false;
            this.button_dele.Location = new System.Drawing.Point(291, 225);
            this.button_dele.Name = "button_dele";
            this.button_dele.Size = new System.Drawing.Size(73, 30);
            this.button_dele.TabIndex = 10;
            this.button_dele.Text = "删除";
            this.button_dele.UseVisualStyleBackColor = true;
            this.button_dele.Click += new System.EventHandler(this.button_dele_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(398, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(226, 228);
            this.listBox1.TabIndex = 11;
            // 
            // button_mark
            // 
            this.button_mark.Enabled = false;
            this.button_mark.Location = new System.Drawing.Point(266, 371);
            this.button_mark.Name = "button_mark";
            this.button_mark.Size = new System.Drawing.Size(98, 37);
            this.button_mark.TabIndex = 12;
            this.button_mark.Text = "打分";
            this.button_mark.UseVisualStyleBackColor = true;
            this.button_mark.Click += new System.EventHandler(this.button_mark_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(38, 371);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(98, 37);
            this.button_reset.TabIndex = 13;
            this.button_reset.Text = "重置";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "姓名";
            // 
            // Form1
            // 
            this.AcceptButton = this.button_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_mark);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_dele);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.txt_palyersum);
            this.Controls.Add(this.txt_judgesum);
            this.Controls.Add(this.button_init);
            this.Controls.Add(this.lbl_playersum);
            this.Controls.Add(this.lbl_judgesum);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "输入信息";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_judgesum;
        private System.Windows.Forms.Label lbl_playersum;
        private System.Windows.Forms.Button button_init;
        private System.Windows.Forms.TextBox txt_judgesum;
        private System.Windows.Forms.TextBox txt_palyersum;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_dele;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_mark;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

