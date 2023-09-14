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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Button btn = new Button();
                    btn.Text = j.ToString() + "*" + i.ToString() + "=" + (i * j).ToString();
                    this.tabShow.SetRow(btn, i - 1);
                    this.tabShow.SetColumn(btn, j - 1);
                    this.tabShow.Controls.Add(btn);
                }
            }
        }
    }
}
