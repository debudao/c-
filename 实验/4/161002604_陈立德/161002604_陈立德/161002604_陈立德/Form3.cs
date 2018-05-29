using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _161002604_陈立德
{
    public partial class Form3 : Form
    {
        private static int lastindex = 0;//记录每次查找完的位置，方便查找下一个


        public Form3()
        {
            InitializeComponent();
        }

        private void button_cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            string a = Form1.F.richTextBox_body.Text, b = textBox_find.Text;

            if (a.IndexOf(b, lastindex) == -1 || lastindex >= a.Length - 1)//如果查找不到，说明已经查找完毕了
                MessageBox.Show("查找不到或者已全部查找完毕", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int x = a.IndexOf(b, lastindex), y = b.Length;
                Form1.F.richTextBox_body.Select(x, y);
                lastindex = a.IndexOf(b, lastindex);
            }
            lastindex++;
        }

        private void textBox_find_TextChanged(object sender, EventArgs e)
        {
            if (textBox_find.Text.Equals(""))
                button_next.Enabled =button_replace.Enabled=button_replaceall.Enabled= false;
            else
                button_next.Enabled = button_replace.Enabled = button_replaceall.Enabled  = true;

            lastindex = 0;
        }

        private void button_replace_Click(object sender, EventArgs e)
        {
            if (Form1.F.richTextBox_body.SelectedText.Equals(""))
                MessageBox.Show("请先查找", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Form1.F.richTextBox_body.Text = Form1.F.richTextBox_body.Text.Remove(lastindex-1, textBox_find.Text.Length);
                Form1.F.richTextBox_body.Text = Form1.F.richTextBox_body.Text.Insert(lastindex-1, textBox_replace.Text);
                lastindex += textBox_replace.Text.Length;
                button_next_Click(sender, e);
            }
               

        }

        private void button_replaceall_Click(object sender, EventArgs e)
        {
            string  b = textBox_find.Text;
            int l=0;

            while(true)
            {
                if (l >= Form1.F.richTextBox_body.Text.Length)
                    MessageBox.Show("已全部替换完毕", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                l = Form1.F.richTextBox_body.Text.IndexOf(b, l);
                if (l == -1)
                {
                    MessageBox.Show("已全部替换完毕", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else
                {
                    Form1.F.richTextBox_body.Text = Form1.F.richTextBox_body.Text.Remove(l, textBox_find.Text.Length);
                    Form1.F.richTextBox_body.Text = Form1.F.richTextBox_body.Text.Insert(l, textBox_replace.Text);
                    l += textBox_replace.Text.Length;
                }

            }

          
        }
    }
}
