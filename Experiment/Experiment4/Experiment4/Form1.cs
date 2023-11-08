namespace Experiment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ���������ӵ�ComboBox
            comboBoxOperators.Items.Add("+");
            comboBoxOperators.Items.Add("-");
            comboBoxOperators.Items.Add("*");
            comboBoxOperators.Items.Add("/");

            // ��ʼ�����ַ�Χ
            for (int i = 0; i <= 10; i++)
            {
                listBoxNumber1.Items.Add(i);
                listBoxNumber2.Items.Add(i);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (comboBoxOperators.SelectedItem != null && listBoxNumber1.SelectedItem != null && listBoxNumber2.SelectedItem != null)
            {
                int num1 = (int)listBoxNumber1.SelectedItem;
                int num2 = (int)listBoxNumber2.SelectedItem;
                string selectedOperator = comboBoxOperators.SelectedItem.ToString();

                double result = 0.0;

                switch (selectedOperator)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = (double)num1 / num2;
                        else
                            MessageBox.Show("��������Ϊ0��");
                            return;
                }

                MessageBox.Show("������: " + result);
            }
        }
    }
}