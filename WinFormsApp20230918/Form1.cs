using System.Text;

namespace WinFormsApp20230918
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 实例化一个可变字符串
        StringBuilder sb = new StringBuilder();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            sb.Append(originalText.Text);
            int index = Convert.ToInt32(insertPositionText.Text);
            sb.Insert(index, insertText.Text, 1);
            lblShow.Text += "插入成功：" + sb.ToString();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            int index = sb.ToString().IndexOf(queryText.Text);
            if (index == -1)
            {
                lblShow.Text += "\n查找的子字符串不存在";
            }
            else
            {
                lblShow.Text += "\n查找的子字符串在原字符串中，索引值：" + index;
            }
        }
    }
}