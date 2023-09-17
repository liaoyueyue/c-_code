namespace WinFormsApp20230918
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
            label3 = new Label();
            label4 = new Label();
            originalText = new TextBox();
            insertText = new TextBox();
            queryText = new TextBox();
            insertPositionText = new TextBox();
            btnInsert = new Button();
            btnQuery = new Button();
            lblShow = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = "原字符串";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 57);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 1;
            label2.Text = "插入字符串";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 87);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 2;
            label3.Text = "插入位置";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 119);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 3;
            label4.Text = "查找字符串";
            // 
            // originalText
            // 
            originalText.Location = new Point(99, 17);
            originalText.Name = "originalText";
            originalText.Size = new Size(206, 23);
            originalText.TabIndex = 4;
            // 
            // insertText
            // 
            insertText.Location = new Point(99, 51);
            insertText.Name = "insertText";
            insertText.Size = new Size(206, 23);
            insertText.TabIndex = 5;
            // 
            // queryText
            // 
            queryText.Location = new Point(99, 116);
            queryText.Name = "queryText";
            queryText.Size = new Size(125, 23);
            queryText.TabIndex = 6;
            // 
            // insertPositionText
            // 
            insertPositionText.Location = new Point(99, 81);
            insertPositionText.Name = "insertPositionText";
            insertPositionText.Size = new Size(125, 23);
            insertPositionText.TabIndex = 7;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(230, 81);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "1.插入";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnQuery
            // 
            btnQuery.Location = new Point(230, 116);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(75, 23);
            btnQuery.TabIndex = 9;
            btnQuery.Text = "2.查找";
            btnQuery.UseVisualStyleBackColor = true;
            btnQuery.Click += btnQuery_Click;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Location = new Point(20, 151);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(285, 74);
            lblShow.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 243);
            Controls.Add(lblShow);
            Controls.Add(btnQuery);
            Controls.Add(btnInsert);
            Controls.Add(insertPositionText);
            Controls.Add(queryText);
            Controls.Add(insertText);
            Controls.Add(originalText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "字符串插入查找";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox originalText;
        private TextBox insertText;
        private TextBox queryText;
        private TextBox insertPositionText;
        private Button btnInsert;
        private Button btnQuery;
        private Label lblShow;
    }
}