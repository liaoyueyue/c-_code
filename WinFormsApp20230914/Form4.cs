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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnShowGrade_Click(object sender, EventArgs e)
        {
            double score = Convert.ToDouble(txtScore.Text);
            string grade = string.Empty;// 等级字符串初始值为空
            if (score >= 90)
            {
                grade = "优秀";
            }
            else if (score >= 80)
            {
                grade = "良好";
            }
            else if (score >= 70)
            {
                grade = "中等";
            }
            else if (score >= 60)
            {
                grade = "及格";
            }
            else
            {
                grade = "不及格";
            }
            lblShow.Text = string.Format("你输入的成绩是：{0}， 对应的成绩等级为：{1}", score, grade);
        }
    }
}
