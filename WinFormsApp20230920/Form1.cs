namespace WinFormsApp20230920
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOutputMaxNum_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtNum1.Text);
            int y = Convert.ToInt32(txtNum2.Text);
            int z = Convert.ToInt32(txtNum3.Text);
            int max = x;
            if(y > max)
            {
                max = y;
            }
            if(z > max)
            {
                max = z;
            }
            lblShow.Text = string.Format("��{0},{1},{2}�����ֵΪ{3}", x, y, z, max);
        }
    }
}