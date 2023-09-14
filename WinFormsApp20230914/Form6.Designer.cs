namespace WinFormsApp20230914
{
    partial class Form6
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
            SuspendLayout();
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Location = new Point(22, 15);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(290, 235);
            lblShow.TabIndex = 0;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 270);
            Controls.Add(lblShow);
            Name = "Form6";
            Text = "求1到100的累加和";
            Load += Form6_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblShow;
    }
}