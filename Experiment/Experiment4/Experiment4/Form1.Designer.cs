namespace Experiment4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxOperators = new ComboBox();
            listBoxNumber2 = new ListBox();
            btnCalculate = new Button();
            listBoxNumber1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBoxOperators
            // 
            comboBoxOperators.FormattingEnabled = true;
            comboBoxOperators.Location = new Point(140, 61);
            comboBoxOperators.Name = "comboBoxOperators";
            comboBoxOperators.Size = new Size(57, 25);
            comboBoxOperators.TabIndex = 0;
            // 
            // listBoxNumber2
            // 
            listBoxNumber2.FormattingEnabled = true;
            listBoxNumber2.ItemHeight = 17;
            listBoxNumber2.Location = new Point(203, 29);
            listBoxNumber2.Name = "listBoxNumber2";
            listBoxNumber2.Size = new Size(72, 89);
            listBoxNumber2.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(62, 133);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(213, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "计算";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // listBoxNumber1
            // 
            listBoxNumber1.FormattingEnabled = true;
            listBoxNumber1.ItemHeight = 17;
            listBoxNumber1.Location = new Point(62, 29);
            listBoxNumber1.Name = "listBoxNumber1";
            listBoxNumber1.Size = new Size(72, 89);
            listBoxNumber1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Location = new Point(12, 176);
            label1.Name = "label1";
            label1.Size = new Size(297, 41);
            label1.TabIndex = 4;
            label1.Text = "tip: 计算0-10以内的所有加、减、乘、除运算.请在下面选择框内做出选择，点击计算，结果会以对话框来提示";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 231);
            Controls.Add(label1);
            Controls.Add(listBoxNumber1);
            Controls.Add(btnCalculate);
            Controls.Add(listBoxNumber2);
            Controls.Add(comboBoxOperators);
            Name = "Form1";
            Text = "四则运算的计算器";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxOperators;
        private ListBox listBoxNumber2;
        private Button btnCalculate;
        private ListBox listBoxNumber1;
        private Label label1;
    }
}