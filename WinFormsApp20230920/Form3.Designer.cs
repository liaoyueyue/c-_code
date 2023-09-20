namespace WinFormsApp20230920
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
            label1 = new Label();
            txtArr = new TextBox();
            btnAdd = new Button();
            btnDisplay = new Button();
            btnQuery = new Button();
            lblShow = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = "数组元素";
            // 
            // txtArr
            // 
            txtArr.Location = new Point(74, 15);
            txtArr.Name = "txtArr";
            txtArr.Size = new Size(100, 23);
            txtArr.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(180, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "添加";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(261, 15);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(75, 23);
            btnDisplay.TabIndex = 3;
            btnDisplay.Text = "显示";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnQuery
            // 
            btnQuery.Location = new Point(342, 15);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(75, 23);
            btnQuery.TabIndex = 4;
            btnQuery.Text = "查找";
            btnQuery.UseVisualStyleBackColor = true;
            btnQuery.Click += btnQuery_Click;
            // 
            // lblShow
            // 
            lblShow.BackColor = SystemColors.Control;
            lblShow.Location = new Point(12, 44);
            lblShow.Multiline = true;
            lblShow.Name = "lblShow";
            lblShow.ScrollBars = ScrollBars.Vertical;
            lblShow.Size = new Size(405, 129);
            lblShow.TabIndex = 6;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 185);
            Controls.Add(lblShow);
            Controls.Add(btnQuery);
            Controls.Add(btnDisplay);
            Controls.Add(btnAdd);
            Controls.Add(txtArr);
            Controls.Add(label1);
            Name = "Form3";
            Text = "数组元素的添加查找操作";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtArr;
        private Button btnAdd;
        private Button btnDisplay;
        private Button btnQuery;
        private TextBox lblShow;
    }
}