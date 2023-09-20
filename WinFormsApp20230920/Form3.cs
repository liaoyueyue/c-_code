using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp20230920
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        const int MAX = 10;
        static int index = 0;
        int[] arr = new int[MAX];
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtArr.Text.Length == 0)
            {
                lblShow.Text += "\r\n输入框内没有元素";
                return;
            }
            arr[index] = Convert.ToInt32(txtArr.Text);
            lblShow.Text += string.Format("\r\n元素{0}添加成功", arr[index]);
            index++;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\r\n{");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0)
                {
                    sb.Append(", ");
                }
                sb.Append(arr[i]);
            }
            sb.Append("}");
            lblShow.Text += sb;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(txtArr.Text);
            int index = Array.IndexOf(arr, key);
            if (index == -1)
            {
                lblShow.Text += string.Format("\r\n在现有数组中找不到{0}元素", key);
            }
            else
            {
                lblShow.Text += string.Format("\r\n在现有数组中找到了{0}元素，它在该数组的索引为{1}", key, index);
            }
        }
    }
}
