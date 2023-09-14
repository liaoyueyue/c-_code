namespace WinFormsApp20230914
{
    partial class Form4
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
            txtScore = new TextBox();
            btnShowGrade = new Button();
            lblShow = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 24);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 0;
            label1.Text = "成绩";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(82, 21);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(124, 23);
            txtScore.TabIndex = 1;
            // 
            // btnShowGrade
            // 
            btnShowGrade.Location = new Point(212, 21);
            btnShowGrade.Name = "btnShowGrade";
            btnShowGrade.Size = new Size(108, 23);
            btnShowGrade.TabIndex = 2;
            btnShowGrade.Text = "显示等级";
            btnShowGrade.UseVisualStyleBackColor = true;
            btnShowGrade.Click += btnShowGrade_Click;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Location = new Point(44, 56);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(276, 171);
            lblShow.TabIndex = 3;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 252);
            Controls.Add(lblShow);
            Controls.Add(btnShowGrade);
            Controls.Add(txtScore);
            Controls.Add(label1);
            Name = "Form4";
            Text = "显示学生成绩等级";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtScore;
        private Button btnShowGrade;
        private Label lblShow;
    }
}