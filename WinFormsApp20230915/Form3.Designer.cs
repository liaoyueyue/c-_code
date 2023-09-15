namespace WinFormsApp20230915
{
    partial class Form3
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
            btnOk = new Button();
            txtString = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Location = new Point(22, 43);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(284, 165);
            lblShow.TabIndex = 11;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(230, 12);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(76, 23);
            btnOk.TabIndex = 10;
            btnOk.Text = "过滤";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtString
            // 
            txtString.Location = new Point(96, 12);
            txtString.Name = "txtString";
            txtString.Size = new Size(128, 23);
            txtString.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 8;
            label1.Text = "输入字符串";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 228);
            Controls.Add(lblShow);
            Controls.Add(btnOk);
            Controls.Add(txtString);
            Controls.Add(label1);
            Name = "Form3";
            Text = "过滤重复字符";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShow;
        private Button btnOk;
        private TextBox txtString;
        private Label label1;
    }
}