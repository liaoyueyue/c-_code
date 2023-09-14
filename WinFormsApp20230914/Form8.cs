using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp20230914
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            int fun = 1, i = 1;
            while (i <= num)
            {
                fun = fun * i;
                i++;
            }
            lblShow.Text = string.Format("{0}的阶乘是：{1}", num, fun);
        }
    }
}
