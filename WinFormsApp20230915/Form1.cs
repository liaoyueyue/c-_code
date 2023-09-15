namespace WinFormsApp20230915
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            int sum = 0;
            lblShow.Text = "输入的整数为：" + num;
            do
            {
                sum += num % 10;
                num /= 10;
            } while (num != 0);
            lblShow.Text += " ; " + string.Format("各位数字之和为：{0}", sum);
        }
    }
}