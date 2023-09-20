namespace WinFormsApp20230920
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
            label1 = new Label();
            label2 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtNum3 = new TextBox();
            btnOutputMaxNum = new Button();
            lblShow = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 12);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = "第一个数";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 49);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 1;
            label2.Text = "第二个数";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(85, 9);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(85, 43);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 4;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(85, 83);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(100, 23);
            txtNum3.TabIndex = 5;
            // 
            // btnOutputMaxNum
            // 
            btnOutputMaxNum.Location = new Point(22, 123);
            btnOutputMaxNum.Name = "btnOutputMaxNum";
            btnOutputMaxNum.Size = new Size(163, 23);
            btnOutputMaxNum.TabIndex = 6;
            btnOutputMaxNum.Text = "输出最大值";
            btnOutputMaxNum.UseVisualStyleBackColor = true;
            btnOutputMaxNum.Click += btnOutputMaxNum_Click;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Location = new Point(202, 9);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(160, 137);
            lblShow.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 86);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 2;
            label5.Text = "第三个数";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 158);
            Controls.Add(lblShow);
            Controls.Add(btnOutputMaxNum);
            Controls.Add(txtNum3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "三个数找最大值";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtNum3;
        private Button btnOutputMaxNum;
        private Label lblShow;
        private Label label5;
    }
}