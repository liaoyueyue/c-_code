namespace WinFormsApp20230914
{
    partial class Form2
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
            txtRadius = new TextBox();
            btnCalculate = new Button();
            lblShow = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 44);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 0;
            label1.Text = "半径";
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(93, 41);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(133, 23);
            txtRadius.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(232, 41);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(101, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "计算";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += button1_Click;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Location = new Point(55, 79);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(278, 184);
            lblShow.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 307);
            Controls.Add(lblShow);
            Controls.Add(btnCalculate);
            Controls.Add(txtRadius);
            Controls.Add(label1);
            Name = "Form2";
            Text = "计算圆的周长面积";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRadius;
        private Button btnCalculate;
        private Label lblShow;
    }
}