using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experiment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string name = txtName.Text;
            string sex = txtSex.Text;
            string age = txtAge.Text;
            string major = txtMajor.Text;
            // 非空判断
            if (id.Length == 0 || name.Length == 0 || sex.Length == 0 || age.Length == 0 || major.Length == 0)
            {
                MessageBox.Show("请输入完整的信息");
                return;
            }
            // 数据校正 ...
            if (Convert.ToInt32(age) < 0)
            {
                age = "0";
            }
            Student currentStudent = new Student(id, name, sex, age, major);
            lblShow.Text = currentStudent.toString();

        }
    }
}
