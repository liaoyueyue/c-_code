namespace Experiment2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblShow = new System.Windows.Forms.Label();
            this.btnJudment = new System.Windows.Forms.Button();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(12, 33);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(262, 149);
            this.lblShow.TabIndex = 7;
            // 
            // btnJudment
            // 
            this.btnJudment.Location = new System.Drawing.Point(199, 7);
            this.btnJudment.Name = "btnJudment";
            this.btnJudment.Size = new System.Drawing.Size(75, 23);
            this.btnJudment.TabIndex = 6;
            this.btnJudment.Text = "判断";
            this.btnJudment.UseVisualStyleBackColor = true;
            this.btnJudment.Click += new System.EventHandler(this.btnJudment_Click);
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(93, 9);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(100, 21);
            this.txtStr.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "请输入字符串";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 195);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnJudment);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "判断字符串是否回文";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnJudment;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.Label label1;
    }
}

