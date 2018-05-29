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
    public partial class Form2 : Form
    {
        static private int[] ok;//用来记录选手是否打过分了
        static public  List<List<int>> score;//用来记录每个选手的每次评分
        static private int[] flag;//用来记录每个选手打了几次分
        private int count;//用来记录已经为几个选手评完分
        static private int k;
        public Form2()
        {
            InitializeComponent();
            lbl_hintmark.Text = "请输入" + Form1.getJudgesum().ToString() + "位评委的分数：";
            lbl_show.Text = "已经为" + count + "位选手评完分，还剩" + (Form1.getPlayersum() - count) + "位选手未打分";
            ok = new int[Form1.getPlayersum()];
            score = new List<List<int>>();
            for (int i = 0; i < Form1.getPlayersum(); i++)
            {
                List<int> l = new List<int>();
                score.Add(l);
            }
                
            flag = new int[Form1.getPlayersum()];
            this.count = 0;
        }

        private void button_lookup_Click(object sender, EventArgs e)
        {
            k = find(txt_lookupnum.Text);

            if (k == -2)
            {
                MessageBox.Show("该选手已经打过分了", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_lookupnum.Text = "";
            }
                
            else if (k == -1)
            {
                MessageBox.Show("输入的编号有误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_lookupnum.Text = "";
            }              
            else
            {
                MessageBox.Show("查询成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_score.ReadOnly = false;
                ok[k] = 1;
                button_lookup.Enabled = false;
                listBox_score.Items.Clear();
                button_addscore.Enabled = true;
            }
                

            
        }

        private int find(String s)//用来返回该选手在数组里的索引
        {
            for (int i = 0; i < Form1.getPlayersum(); i++)
            {
                if (s == Form1.getPlayersnum(i))
                {
                    if (ok[i] == 1)//表示该选手已经打过分了，返回0
                        return -2;
                    else
                        return i;//找到并且该选手未被打分，返回该选手在数组里的序号
                }
            }
            return -1;//没找到返回-1
        }

        private void check(int i)//用来判断并改变按钮是否可用
        {
            if (flag[i] == 0)
                button_delescore.Enabled = false;
            else
                button_delescore.Enabled = true;

            if(flag[i]==Form1.getJudgesum())
            {
                button_addscore.Enabled = false;
                button_grade.Enabled = button_grade.Enabled = true;
            }
            else
            {
                button_addscore.Enabled = true;
                button_grade.Enabled = button_grade.Enabled = false;
            }

        }

        private void button_addscore_Click(object sender, EventArgs e)
        {
            listBox_score.Items.Add(txt_score.Text);
            score[k].Add(Convert.ToInt32(txt_score.Text));
            flag[k]++;
            txt_score.Text = "";
            check(k);
            if (flag[k] == Form1.getJudgesum())
            { 
                button_grade.Enabled = true;
            }
            else
                button_grade.Enabled = false;
        }

        private void button_grade_Click(object sender, EventArgs e)
        {
            
            string res = "该选手的最高分：" + score[k].Max() + "  最低分：" + score[k].Min() + "  最后得分：" + score[k].Average();
            listBox_score.Items.Add(res);
            button_lookup.Enabled = true;
            txt_score.ReadOnly = true;
            button_delescore.Enabled = button_addscore.Enabled = false;
            button_grade.Enabled = false;
            count++;
            lbl_show.Text = "已经为" + count + "位选手评完分，还剩" + (Form1.getPlayersum() - count) + "位选手未打分";
            txt_lookupnum.Text = "";
            txt_lookupnum.Focus();

            if (count == Form1.getPlayersum())
                new Form3().Show();
        }

        private void button_delescore_Click(object sender, EventArgs e)
        {
            score[k].Remove(Convert.ToInt32(listBox_score.SelectedItem));
            listBox_score.Items.Remove(listBox_score.SelectedItem);
            txt_score.Focus();
            
            flag[k]--;
            check(k);
        }
    }
}
