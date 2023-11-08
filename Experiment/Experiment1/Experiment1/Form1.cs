using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experiment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJudment_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(txtYear.Text);
            if (year == null || year <= 0)
            {
                lblShow.Text = "输入年份不合格，请重新输入";
            }
            else
            {
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    lblShow.Text = "年份：" + year + "是闰年";
                }
                else
                {
                    lblShow.Text = "年份：" + year + "不是闰年";
                }
            }
        }
    }
}
