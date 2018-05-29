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
   

    public partial class Form1 : Form
    {
        private static int judgesum;
        private static int playersum;
        public static string[] playersnum;
        public static string[] playersname;

        internal static int getJudgesum()
        {
            return judgesum;
        }

        
        internal static int getPlayersum()
        {
            return playersum;
        }

        public Form1()
        {
            InitializeComponent();
        }

        internal static string getPlayersnum(int i)
        {
            return playersnum[i];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_init_Click(object sender, EventArgs e)
        {
            if(!txt_judgesum.Text.Equals("")&&!txt_palyersum.Text.Equals(""))
            {
                judgesum = Convert.ToInt32(txt_judgesum.Text);
                playersum = Convert.ToInt32(txt_palyersum.Text);
                txt_num.ReadOnly = false;
                txt_name.ReadOnly = false;
                button_add.Enabled = true;
                MessageBox.Show("初始化成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button_init.Enabled = false;
                txt_judgesum.ReadOnly = txt_palyersum.ReadOnly = true;
                txt_num.Focus();
            }
            else
            {
                MessageBox.Show("请输入正确的评委和参赛者人数", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            playersum = judgesum = 0;
            button_mark.Enabled = button_add.Enabled = button_dele.Enabled = false;
            listBox1.Items.Clear();
            txt_judgesum.Text = txt_name.Text = txt_num.Text = txt_palyersum.Text = "";
            txt_palyersum.ReadOnly = txt_judgesum.ReadOnly = false;
            button_init.Enabled = true;
            playersname = playersnum = null;
            txt_name.ReadOnly = txt_num.ReadOnly = true;
            txt_judgesum.Focus();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            txt_judgesum.Text = playersum.ToString();
            if(lbl_name.Text!=""&&lbl_num.Text!="")
            {
                listBox1.Items.Add(txt_num.Text + "              " + txt_name.Text);
                txt_num.Text = txt_name.Text = "";
            }
            else
                MessageBox.Show("请输入正确的姓名和编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            check();
            txt_num.Focus();

        }

        private void button_dele_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            txt_num.Focus();
            check();
        }

        //用来判断并改变按钮是否可用
        private void check()
        {
            if (listBox1.Items.Count == 0)
                button_dele.Enabled = false;
            else
                button_dele.Enabled = true;

            if (listBox1.Items.Count == playersum)
            {
                button_mark.Enabled = true;
                button_add.Enabled = false;
            }
            else
            {
                button_mark.Enabled = false;
                button_add.Enabled = true;
            }
        }

        private void button_mark_Click(object sender, EventArgs e)
        {
            DialogResult ans;
            ans = MessageBox.Show("确认所有输入均无错误并打分？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ans == DialogResult.Yes)
            {
                string []a = new string[2];
                playersnum = new string[listBox1.Items.Count];
                playersname = new string[listBox1.Items.Count];
                for(int i=0;i<listBox1.Items.Count;i++)
                {
                    string b= (string)listBox1.Items[i];
                    b = new System.Text.RegularExpressions.Regex("[\\s]+").Replace(b, " ");//用正则表达式将多个空格合并为一个
                    a = b.Split();
                    playersnum[i] = a[0];
                    playersname[i] = a[1];
                    txt_name.Text += (a[0] + a[1]);
                }
                new Form2().Show();//新建一个窗口
                button_mark.Enabled = false;
            }
           
        }
    }

}


