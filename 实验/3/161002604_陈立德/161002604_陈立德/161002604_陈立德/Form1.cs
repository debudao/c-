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
        public Form1()
        {
            InitializeComponent();
        }

        private void driveListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dirListBox1.Path = driveListBox1.Drive;
        }

        private void dirListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileListBox1.Path = dirListBox1.Path;
        }

        private void fileListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string f, a;
            int m;
  
            f = fileListBox1.Path;

            m = f.Length;
            if (f.Substring(m - 1, 1) == "\\")
                a = fileListBox1.Path + fileListBox1.FileName;
            else
                a = fileListBox1.Path + "\\" + fileListBox1.FileName;

            pictureBox1.Image = Image.FromFile(a);
        }

        private void button_lastone_Click(object sender, EventArgs e)
        {
            if (fileListBox1.SelectedIndex == 0)
                fileListBox1.SelectedIndex = fileListBox1.Items.Count - 1;
            else
                fileListBox1.SelectedIndex -= 1;
        }

        private void button_nextone_Click(object sender, EventArgs e)
        {
            if (fileListBox1.SelectedIndex == fileListBox1.Items.Count - 1)
                fileListBox1.SelectedIndex = 0;
            else
                fileListBox1.SelectedIndex += 1;
        }
    }
}
