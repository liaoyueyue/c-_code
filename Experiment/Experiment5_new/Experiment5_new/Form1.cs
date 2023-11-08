using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Experiment5_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student[] stu = new Student[100];

        public void DisPlay(Student stu)
        {
            string type = "";
            if (stu is Pupil)
            {
                type = "小学生";
            }
            else if (stu is MiddleStu)
            {
                type = "中学生";
            }
            else if (stu is CollegeStu)
            {
                type = "大学生";
            }
            lblShow.Text += string.Format("\n总人数： {0}， 姓名： {1}， 年龄： {2}, {3}, 平均成绩：{4}", Student.count, stu.Name, stu.Age, type, stu.GetAverage());
        }

        private void btnPupil_Click(object sender, EventArgs e)
        {
            notNullCheck();
            Pupil pl = new Pupil(txtName.Text, Convert.ToInt32(txtAge.Text), Convert.ToDouble(txtChinese.Text), Convert.ToDouble(txtMath.Text));
            DisPlay(pl);
        }

        private void btnMiddleStu_Click(object sender, EventArgs e)
        {
            notNullCheck();
            if (txtEnglish.Text == "")
            {
                MessageBox.Show("请检查输入框填写是否完整！");
                return;
            }
            MiddleStu ms = new MiddleStu(txtName.Text, Convert.ToInt32(txtAge.Text), Convert.ToDouble(txtChinese.Text), Convert.ToDouble(txtMath.Text), Convert.ToDouble(txtEnglish.Text));
            DisPlay(ms);
        }

        private void btnCollegeStu_Click(object sender, EventArgs e)
        {
            notNullCheck();
            CollegeStu cs = new CollegeStu(txtName.Text, Convert.ToInt32(txtAge.Text), Convert.ToDouble(txtChinese.Text), Convert.ToDouble(txtMath.Text));
            DisPlay(cs);
        }

        private void notNullCheck()
        {
            if (txtName.Text == "" || txtAge.Text == "" || txtChinese.Text == "" || txtMath.Text == "")
            {
                MessageBox.Show("请检查输入框填写是否完整！");
                return;
            }
        }
    }
}
