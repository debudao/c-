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
    public partial class frm陈立德 : Form
    {
        private static int n1 = 0,n2=0,n3=0;//记录是不是第一次获得焦点
        private static int allsum = 0;//记录查找到的总个数
        private static int replacesum = 0;//记录替换的总个数
        private static int lastindex = 0;//记录每次查找完的位置，方便查找下一个
        public frm陈立德()
        {
            InitializeComponent();
        }

        //当txtPaper获得焦点时，将默认的text清除
        private void txtPaper_Enter_1(object sender, EventArgs e)
        {
            if(n1==0)//第一次或者焦点，就把默认文本清除，其他情况则不用
            {
                txtPaper.Text = "";
                n1++;
            }
            txtPaper.Font = new Font("华文楷体", 15);
            txtPaper.ForeColor = Color.Black;
                
        }

        //当txtFinding获得焦点时，将默认的text清除
        private void txtFinding_Enter(object sender, EventArgs e)
        {
            if (n2 == 0)//第一次或者焦点，就把默认文本清除，其他情况则不用
            {
                txtFinding.Text = "";
                n2++;
            }
            txtFinding.Font = new Font("华文楷体", 15);
            txtFinding.ForeColor = Color.Black;
        }

        //当txtReplacing获得焦点时，将默认的text清除
        private void txtReplacing_Enter(object sender, EventArgs e)
        {
            if (n3 == 0)//第一次或者焦点，就把默认文本清除，其他情况则不用
            {
                txtReplacing.Text = "";
                n3++;
            }
            txtReplacing.Font = new Font("华文楷体", 15);
            txtReplacing.ForeColor = Color.Black;
        }

        //重置按钮，将所有东西重置
        private void cmdReset_Click(object sender, EventArgs e)
        {
            n1 = n2 = n3 = allsum = replacesum = lastindex = 0;
            txtFinding.Text = txtPaper.Text = txtReplacing.Text = "";
            lblFinded.Text = "总共查找次数：";
            lblReplaced.Text = "总共替换次数：";
        }

        private void cmdFind_MouseHover(object sender, EventArgs e)
        {
            int a = 0;
            toolTip1.SetToolTip(cmdFind, a.ToString());
            a++;
        }

        private void frm陈立德_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(cmdReset, "quxiao");
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            string a = txtPaper.Text, b = txtFinding.Text, c = txtReplacing.Text;
            //a.IndexOf()
            if(a.IndexOf(b,lastindex)==-1||lastindex>=a.Length-1)//如果查找不到，说明已经查找完毕了
            {
               lastindex = 0;
                MessageBox.Show("已全部查找完毕", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                allsum++;//总共查找次数增加
                lblFinded.Text = "总共查找次数：" + allsum.ToString();
                int x = a.IndexOf(b,lastindex), y = b.Length, z = c.Length;
                txtPaper.SelectionStart = x;//选择
                txtPaper.SelectionLength = y;
                DialogResult ans;
                ans = MessageBox.Show("是否替换", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (ans == DialogResult.Yes)//如果选择是，则跳出询问窗口
                {
                    replacesum++;
                    lblReplaced.Text = "总共替换次数：" + replacesum.ToString();
                    txtPaper.Text = txtPaper.Text.Remove(x, y);//删除查找到的部分
                    txtPaper.Text = txtPaper.Text.Insert(x, txtReplacing.Text);//将要替换的部分插入
                }
                else
                {
                    lastindex = a.IndexOf(b, lastindex);

                }
               
               
            }
            lastindex++;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
