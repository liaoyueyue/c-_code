using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Experiment5
{
    public partial class ManageForm : Form
    {
        private List<Student> students = new List<Student>();
        public ManageForm()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // 获取用户输入的学生信息
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // 非空校验
            if (username.Length == 0 || password.Length == 0 || username == null || password == null)
            {
                MessageBox.Show("请输入用户名或者密码");
                return;
            }

            // 创建学生对象并添加到列表
            Student student = new Student(username, password);
            students.Add(student);

            // 在ListView中显示学生信息
            ListViewItem item = new ListViewItem(username);
            item.SubItems.Add(password);
            listView.Items.Add(item);
        }

        private void btnDelStudent_Click(object sender, EventArgs e)
        {
            // 检查是否选择了学生
            if (listView.SelectedItems.Count > 0)
            {
                // 获取选定的学生
                ListViewItem selectedItem = listView.SelectedItems[0];
                string username = selectedItem.Text;

                // 从列表中删除学生
                Student studentToRemove = students.Find(s => s.getUsername().Equals(username));
                students.Remove(studentToRemove);

                // 从ListView中移除学生信息
                listView.Items.Remove(selectedItem);
                MessageBox.Show("删除学生成功");
            }
            else
            {
                MessageBox.Show("请在列表中选择学生");
            }
        }
    }
}
