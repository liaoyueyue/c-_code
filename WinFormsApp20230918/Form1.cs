using System.Text;

namespace WinFormsApp20230918
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ʵ����һ���ɱ��ַ���
        StringBuilder sb = new StringBuilder();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            sb.Append(originalText.Text);
            int index = Convert.ToInt32(insertPositionText.Text);
            sb.Insert(index, insertText.Text, 1);
            lblShow.Text += "����ɹ���" + sb.ToString();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            int index = sb.ToString().IndexOf(queryText.Text);
            if (index == -1)
            {
                lblShow.Text += "\n���ҵ����ַ���������";
            }
            else
            {
                lblShow.Text += "\n���ҵ����ַ�����ԭ�ַ����У�����ֵ��" + index;
            }
        }
    }
}