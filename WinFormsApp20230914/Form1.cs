namespace WinFormsApp20230914
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int num = 4321;
            lblShow.Text += "\n" + num + ":";
            lblShow.Text += "\n" + "千位数是：" + num / 1000 % 10;
            lblShow.Text += "\n" + "百位数是：" + num / 100 % 10;
            lblShow.Text += "\n" + "十位数是：" + num / 10 % 10;
            lblShow.Text += "\n" + "个位数是：" + num % 10;
        }

        private void lblShow_Click(object sender, EventArgs e)
        {
            int num = 7523;
            lblShow.Text += "\n" + num + ":";
            lblShow.Text += "\n" + "千位数是：" + num / 1000 % 10;
            lblShow.Text += "\n" + "百位数是：" + num / 100 % 10;
            lblShow.Text += "\n" + "十位数是：" + num / 10 % 10;
            lblShow.Text += "\n" + "个位数是：" + num % 10;
        }
    }
}