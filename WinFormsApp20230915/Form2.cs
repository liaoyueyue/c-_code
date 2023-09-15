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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnJudging_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            int n = (int)Math.Sqrt(num);
            int i;
            // 判断素数方法： 将整数 num 逐个除以这个数的平方根之间的所有数，若能整除，则不是素数，否则是素数
            for (i = 2; i <= n; i++)
            {
                if (num % i == 0)
                {
                    break;
                }
            }
            if (i <= n)
            {
                lblShow.Text = string.Format("输入的正整数：{0}， 不是素数！", num);
            }
            else
            {
                lblShow.Text = string.Format("输入的正整数：{0}， 是素数！", num);
            }
        }
    }
}
