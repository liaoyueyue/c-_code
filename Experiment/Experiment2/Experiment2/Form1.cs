using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experiment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJudment_Click(object sender, EventArgs e)
        {
            String str = Convert.ToString(txtStr.Text);
            int len = str.Length;
            for (int i = 0; i < len / 2;i++ )
            {
                if (str[i].CompareTo(str[len-i-1]) != 0)
                {
                    lblShow.Text = "字符串： " + str + "不是回文字符串！";
                    return;
                }
            }
            lblShow.Text = "字符串： " + str + "是回文字符串！";
        }
    }
}