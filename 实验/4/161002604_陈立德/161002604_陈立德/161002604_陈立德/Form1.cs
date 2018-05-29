using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _161002604_陈立德
{
    public partial class Form1 : Form
    {
        private string path;//记录打开的文件的路径
        public static Form1 F=null;

        public Form1()
        {
            path = "";
            InitializeComponent();
            F = this;
            check();
        }

        private void mnu_open_Click(object sender, EventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "文本文件|*.txt";
            op.RestoreDirectory = true;
            if (op.ShowDialog() == DialogResult.OK)
            {
                path = op.FileName;
                richTextBox_body.LoadFile(path, RichTextBoxStreamType.PlainText);
                //StreamReader read = new StreamReader(path, Encoding.Default);
                
                //richTextBox_body.Text = read.ReadToEnd();
                //read.Close();
            }

            check();


        }

        private void toolStripButton_open_Click(object sender, EventArgs e)
        {
            mnu_open_Click(sender,e);
            check();
        }

        private void mnu_save_Click(object sender, EventArgs e)
        {
            richTextBox_body.SaveFile(path, RichTextBoxStreamType.PlainText);
            //StreamWriter write = new StreamWriter(path, false, Encoding.Default);
            //for (int i = 0; i < richTextBox_body.Lines.Length; i++)
            //{
            //    write.WriteLine(richTextBox_body.Lines[i]);
            //    write.Flush();
            //}
                
            //write.Close();

            check();
        }

        private void toolStripButton_save_Click(object sender, EventArgs e)
        {
            mnu_save_Click(sender, e);
            check();
        }

        private void mnu_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            check();
        }

        private void toolStripButton_all_Click(object sender, EventArgs e)
        {
            richTextBox_body.SelectAll();
            check();
        }

        private void mnu_all_Click(object sender, EventArgs e)
        {
            richTextBox_body.SelectAll();
            check();
        }

        private void mnu_cut_Click(object sender, EventArgs e)
        {
            richTextBox_body.Cut();
            check();
        }

        private void toolStripButton_cut_Click(object sender, EventArgs e)
        {
            richTextBox_body.Cut();
            check();
        }

        private void mnu_copy_Click(object sender, EventArgs e)
        {
            richTextBox_body.Copy();
            check();
        }

        private void mnu_paste_Click(object sender, EventArgs e)
        {
            richTextBox_body.Paste();
            check();
        }

        private void toolStripButton_copy_Click(object sender, EventArgs e)
        {
            richTextBox_body.Copy();
            check();
        }

        private void toolStripButton_paste_Click(object sender, EventArgs e)
        {
            richTextBox_body.Paste();
            check();
        }

        private void mnu_changeline_Click(object sender, EventArgs e)
        {
            if (mnu_changeline.Checked == true)
                richTextBox_body.WordWrap = true;
            else
                richTextBox_body.WordWrap = false;

            check();

        }

        void check()//检查每个功能是否可用
        {
            if (path == "")
                mnu_save.Enabled = toolStripButton_save.Enabled = false;
            else
                mnu_save.Enabled = toolStripButton_save.Enabled = true;

            if (Clipboard.GetDataObject().ToString().Equals(""))
                mnu_paste.Enabled = toolStripButton_paste.Enabled = false;
            else
                mnu_paste.Enabled = toolStripButton_paste.Enabled = true;

            if (richTextBox_body.SelectedText.Equals(""))
            {
                toolStripButton_ilalic.Checked = toolStripButton_bold.Checked = toolStripButton_underline.Checked = false;
                mnu_cut.Enabled = mnu_copy.Enabled = toolStripButton_cut.Enabled = toolStripButton_copy.Enabled = toolStripButton_bold.Enabled = toolStripButton_ilalic.Enabled = toolStripButton_underline.Enabled = false;

            }
            else
            {
                mnu_cut.Enabled = mnu_copy.Enabled = toolStripButton_cut.Enabled = toolStripButton_copy.Enabled = toolStripButton_bold.Enabled = toolStripButton_ilalic.Enabled = toolStripButton_underline.Enabled = true;
                if (richTextBox_body.SelectionFont.Underline)
                    toolStripButton_underline.Checked = true;
                else
                    toolStripButton_underline.Checked = false;
                if (richTextBox_body.SelectionFont.Bold)
                    toolStripButton_bold.Checked = true;
                else
                    toolStripButton_bold.Checked = false;
                if (richTextBox_body.SelectionFont.Italic)
                    toolStripButton_ilalic.Checked = true;
                else
                    toolStripButton_ilalic.Checked = false;
            }

            if (richTextBox_body.Text.Equals(""))
            {
                mnu_fine.Enabled = mnu_replace.Enabled = toolStripButton_find.Enabled = toolStripButton_replace.Enabled = false;
                
            }
                
            else
                mnu_fine.Enabled = mnu_replace.Enabled = toolStripButton_find.Enabled = toolStripButton_replace.Enabled = true;

        }

        private void richTextBox_body_SelectionChanged(object sender, EventArgs e)//在选中的内容发生变化时检查每个按钮的可用性
        {
            check();
        }

        private void mnu_fine_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show();
        }

        private void toolStripButton_find_Click(object sender, EventArgs e)
        {
            mnu_fine_Click(sender, e);
        }

        private void mnu_replace_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.Show();
        }

        private void toolStripButton_replace_Click(object sender, EventArgs e)
        {
            mnu_replace_Click(sender, e);
        }

        private void mnu_font_Click(object sender, EventArgs e)
        {
            //fontDialog1.ShowDialog();
            fontDialog1.ShowColor = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox_body.SelectionFont = fontDialog1.Font;
                richTextBox_body.SelectionColor = fontDialog1.Color;
            }
                
        }

        private void toolStripButton_bold_Click(object sender, EventArgs e)
        {
            Font old = richTextBox_body.SelectionFont;
            if (old.Bold)
            {
                
                richTextBox_body.SelectionFont = new Font(old, old.Style ^ FontStyle.Bold);
            }
            else
            {
                
                richTextBox_body.SelectionFont = new Font(old, old.Style | FontStyle.Bold);
            }
                
        }

        private void toolStripButton_ilalic_Click(object sender, EventArgs e)
        {
            Font old = richTextBox_body.SelectionFont;
            if (old.Italic)
            {

                richTextBox_body.SelectionFont = new Font(old, old.Style ^ FontStyle.Italic);
            }
            else
            {

                richTextBox_body.SelectionFont = new Font(old, old.Style | FontStyle.Italic);
            }
        }

        private void toolStripButton_underline_Click(object sender, EventArgs e)
        {
            Font old = richTextBox_body.SelectionFont;
            if (old.Underline)
            {

                richTextBox_body.SelectionFont = new Font(old, old.Style ^ FontStyle.Underline);
            }
            else
            {

                richTextBox_body.SelectionFont = new Font(old, old.Style | FontStyle.Underline);
            }
        }
    }
}
