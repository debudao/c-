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
        private double[] avr;
        public Form3()
        {
            InitializeComponent();
            avr = new double[Form1.getPlayersum()];
            for (int i = 0; i < Form1.getPlayersum(); i++)
                avr[i] = Form2.score[i].Average();
            sort();
            textBox1.Text = "名次：" + "\t编号：" + "\t姓名：" + "\t得分\r\n";
            for (int i = 0; i < Form1.getPlayersum(); i++)
                textBox1.Text += ((i + 1) + "\t" + Form1.playersnum[i] + "\t" + Form1.playersname[i] + "\t" + avr[i] + "\r\n");
        }

        private void sort()
        {
            for (int i = 0; i < Form1.getPlayersum()-1; i++)
            {
                for(int j=i+1;j< Form1.getPlayersum();j++)
                    if(avr[i]<avr[j])
                    {
                        double temp = avr[i];
                        avr[i] = avr[j];
                        avr[j] = temp;
                        String one = Form1.playersname[i], two = Form1.playersnum[i];
                        Form1.playersname[i] = Form1.playersname[j];
                        Form1.playersname[j] = one;
                        Form1.playersnum[i] = Form1.playersnum[j];
                        Form1.playersnum[j] = two;
                    }
            }
        }
    }
}
