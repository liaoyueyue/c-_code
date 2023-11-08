namespace Experiment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string username = Convert.ToString(txtUsername.Text);
            string password = Convert.ToString(txtPassword.Text);
            string confirmPassword = Convert.ToString(txtConfirmPassword.Text);
            string email = Convert.ToString(txtEmail.Text);

            if (string.IsNullOrWhiteSpace(username) || !IsAlpha(username) || username.Length < 6)
            {
                MessageBox.Show("用户名必须由字母构成且长度不能小于6");
                return;
            }

            if (password.Length < 6 || password.Length > 14)
            {
                MessageBox.Show("密码长度必须在6到14位之间。");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("两次输入的密码不一致。");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("邮箱格式不正确。");
                return;
            }

            MessageBox.Show("恭喜验证成功");
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool IsAlpha(string input)
        {
            return input.All(char.IsLetter);
        }
    }
}