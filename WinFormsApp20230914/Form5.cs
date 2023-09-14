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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnShowGrade_Click(object sender, EventArgs e)
        {
            double score = Convert.ToDouble(txtScore.Text);
            string grade = string.Empty;
            switch ((int)score / 10)
            {
                case 10:
                case 9:
                    grade = "优秀";
                    break;
                case 8:
                    grade = "良好";
                    break;
                case 7:
                    grade = "中等";
                    break;
                case 6:
                    grade = "及格";
                    break;
                default:
                    grade = "不及格";
                    break;
            }
            lblShow.Text = string.Format("你输入的成绩是：{0}, 对应的等级是：{1}", score, grade);
        }
    }
}
