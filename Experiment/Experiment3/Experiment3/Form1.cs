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
                MessageBox.Show("�û�����������ĸ�����ҳ��Ȳ���С��6");
                return;
            }

            if (password.Length < 6 || password.Length > 14)
            {
                MessageBox.Show("���볤�ȱ�����6��14λ֮�䡣");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("������������벻һ�¡�");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("�����ʽ����ȷ��");
                return;
            }

            MessageBox.Show("��ϲ��֤�ɹ�");
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