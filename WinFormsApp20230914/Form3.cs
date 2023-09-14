using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp20230914
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int num1 = 88;
            int num2 = 56;
            lblShow.Text = "两数交换前:";
            lblShow.Text += "\n" + string.Format("num1={0};num2={1}", num1, num2);
            lblShow.Text += "\n两数交换后:";
            // 设计两数交换的算法
            num1 = num1 ^ num2;
            num2 = num1 ^ num2;
            num1 = num1 ^ num2;
            lblShow.Text += "\n" + string.Format("num1={0};num2={1}", num1, num2);
        }
    }
}
