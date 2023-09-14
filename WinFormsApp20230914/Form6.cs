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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum = sum + i;
            }
            lblShow.Text = "1到100的累加和为：" + sum;
        }
    }
}
