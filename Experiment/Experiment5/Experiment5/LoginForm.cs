using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experiment5
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            // 非空校验
            if (username.Length == 0 || password.Length == 0 || username == null || password == null)
            {
                MessageBox.Show("请输入用户名或者密码");
                return;
            }
            if (username == "admin" && password == "123")
            {
                MessageBox.Show(string.Format("欢迎 {0}", username));
                // 跳转到管理界面
                ManageForm form2 = new ManageForm();
                this.Hide();
                form2.ShowDialog();
                Application.ExitThread();// 退出当前窗体
            }
            else
            {
                MessageBox.Show("账号或者密码错误");
            }
        }
    }
}
