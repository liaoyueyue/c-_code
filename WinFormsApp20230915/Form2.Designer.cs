namespace WinFormsApp20230915
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
            lblShow = new Label();
            btnJudging = new Button();
            txtNum = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Location = new Point(12, 40);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(284, 165);
            lblShow.TabIndex = 7;
            // 
            // btnJudging
            // 
            btnJudging.Location = new Point(220, 9);
            btnJudging.Name = "btnJudging";
            btnJudging.Size = new Size(76, 23);
            btnJudging.TabIndex = 6;
            btnJudging.Text = "判断";
            btnJudging.UseVisualStyleBackColor = true;
            btnJudging.Click += btnJudging_Click;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(110, 9);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(104, 23);
            txtNum.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 4;
            label1.Text = "输入一个整数";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 227);
            Controls.Add(lblShow);
            Controls.Add(btnJudging);
            Controls.Add(txtNum);
            Controls.Add(label1);
            Name = "Form2";
            Text = "判断素数";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShow;
        private Button btnJudging;
        private TextBox txtNum;
        private Label label1;
    }
}