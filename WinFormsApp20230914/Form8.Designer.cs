namespace WinFormsApp20230914
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNum = new TextBox();
            btnFactorial = new Button();
            lblShow = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 18);
            label1.Name = "label1";
            label1.Size = new Size(118, 17);
            label1.TabIndex = 0;
            label1.Text = "输入不大于10的整数";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(165, 15);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(108, 23);
            txtNum.TabIndex = 1;
            // 
            // btnFactorial
            // 
            btnFactorial.Location = new Point(279, 15);
            btnFactorial.Name = "btnFactorial";
            btnFactorial.Size = new Size(98, 23);
            btnFactorial.TabIndex = 2;
            btnFactorial.Text = "计算阶乘";
            btnFactorial.UseVisualStyleBackColor = true;
            btnFactorial.Click += button1_Click;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Location = new Point(41, 54);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(336, 177);
            lblShow.TabIndex = 3;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 253);
            Controls.Add(lblShow);
            Controls.Add(btnFactorial);
            Controls.Add(txtNum);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum;
        private Button btnFactorial;
        private Label lblShow;
    }
}