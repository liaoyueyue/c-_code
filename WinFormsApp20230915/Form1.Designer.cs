namespace WinFormsApp20230915
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
            txtNum = new TextBox();
            btnSum = new Button();
            lblShow = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 15);
            label1.Name = "label1";
            label1.Size = new Size(92, 17);
            label1.TabIndex = 0;
            label1.Text = "输入一个正整数";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(122, 12);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(104, 23);
            txtNum.TabIndex = 1;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(232, 12);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(76, 23);
            btnSum.TabIndex = 2;
            btnSum.Text = "求和";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Location = new Point(24, 43);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(284, 165);
            lblShow.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 228);
            Controls.Add(lblShow);
            Controls.Add(btnSum);
            Controls.Add(txtNum);
            Controls.Add(label1);
            Name = "Form1";
            Text = "求一位正整数各位数字之和";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum;
        private Button btnSum;
        private Label lblShow;
    }
}