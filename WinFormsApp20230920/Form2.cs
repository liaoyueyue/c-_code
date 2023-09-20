using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp20230920
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            Regex rgx = new Regex(@"^(\w)+(\.\w+)*@(\w)+((\.\w+)+)$");
            if (rgx.IsMatch(email))
            {
                lblShow.Text = "输入：" + txtEmail.Text + "邮箱格式正确";
            }
            else
            {
                lblShow.Text = "输入：" + txtEmail.Text + "邮箱格式错误";
            }
        }
    }
}
