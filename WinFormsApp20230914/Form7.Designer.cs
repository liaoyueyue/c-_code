namespace WinFormsApp20230914
{
    partial class Form7
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
            tabShow = new TableLayoutPanel();
            SuspendLayout();
            // 
            // tabShow
            // 
            tabShow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabShow.ColumnCount = 9;
            tabShow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tabShow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tabShow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tabShow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tabShow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tabShow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tabShow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tabShow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tabShow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tabShow.Location = new Point(32, 12);
            tabShow.Name = "tabShow";
            tabShow.RowCount = 9;
            tabShow.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tabShow.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tabShow.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tabShow.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tabShow.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tabShow.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tabShow.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tabShow.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tabShow.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tabShow.Size = new Size(720, 360);
            tabShow.TabIndex = 0;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 391);
            Controls.Add(tabShow);
            Name = "Form7";
            Text = "打印九九乘法表";
            Load += Form7_Load;
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tabShow;
    }
}