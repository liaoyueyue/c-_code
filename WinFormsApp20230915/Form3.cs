using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp20230915
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            char oldchar, newchar;
            oldchar = Convert.ToChar(string.Empty.Length);// 可 oldchar = '';
            lblShow.Text = "过滤字符串后的结果：\n";
            for (int i = 0; i < txtString.Text.Length; i++)
            {
                newchar = txtString.Text[i];
                if (oldchar == newchar)
                {
                    continue;
                }
                lblShow.Text += newchar.ToString();
                oldchar = newchar;
            }
        }
    }
}
