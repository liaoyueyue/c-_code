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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // const 常数； convert 转换； perimeter 周长； acreage 面积
            const double PI = 3.14; // 定义符号常量PI的值3.14
            // 定义半径radius变量获取窗体界面文本框txtRaiuse.Text的值，并将该值转换为double类型
            double radius = Convert.ToDouble(txtRadius.Text);
            // 定义周长、面积变量并计算周长、面积
            double perimeter = 2 * PI * radius;
            double acreage = PI * radius * radius;
            // 采用字符串格式化语句输入周长和面积
            lblShow.Text = string.Format("输入半径：{0}\n计算圆的周长：{1}\n计算圆的面积：{2}", radius, perimeter, acreage);
        }
    }
}
