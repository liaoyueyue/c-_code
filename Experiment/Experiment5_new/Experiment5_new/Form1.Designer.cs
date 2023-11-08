namespace Experiment5_new
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.btnPupil = new System.Windows.Forms.Button();
            this.btnMiddleStu = new System.Windows.Forms.Button();
            this.btnCollegeStu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 2;
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(16, 106);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(448, 189);
            this.lblShow.TabIndex = 1;
            this.lblShow.Text = "注意：小学生语文、数学; 中学生语文、数学、英语; 大学生必修课、选修课";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(66, 52);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 21);
            this.txtAge.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "语文/必修课";
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(276, 22);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(100, 21);
            this.txtChinese.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "数学/选修课";
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(276, 49);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 21);
            this.txtMath.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "英语";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(276, 76);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 21);
            this.txtEnglish.TabIndex = 2;
            // 
            // btnPupil
            // 
            this.btnPupil.Location = new System.Drawing.Point(389, 20);
            this.btnPupil.Name = "btnPupil";
            this.btnPupil.Size = new System.Drawing.Size(75, 23);
            this.btnPupil.TabIndex = 3;
            this.btnPupil.Text = "小学生";
            this.btnPupil.UseVisualStyleBackColor = true;
            this.btnPupil.Click += new System.EventHandler(this.btnPupil_Click);
            // 
            // btnMiddleStu
            // 
            this.btnMiddleStu.Location = new System.Drawing.Point(389, 47);
            this.btnMiddleStu.Name = "btnMiddleStu";
            this.btnMiddleStu.Size = new System.Drawing.Size(75, 23);
            this.btnMiddleStu.TabIndex = 3;
            this.btnMiddleStu.Text = "中学生";
            this.btnMiddleStu.UseVisualStyleBackColor = true;
            this.btnMiddleStu.Click += new System.EventHandler(this.btnMiddleStu_Click);
            // 
            // btnCollegeStu
            // 
            this.btnCollegeStu.Location = new System.Drawing.Point(389, 74);
            this.btnCollegeStu.Name = "btnCollegeStu";
            this.btnCollegeStu.Size = new System.Drawing.Size(75, 23);
            this.btnCollegeStu.TabIndex = 3;
            this.btnCollegeStu.Text = "大学生";
            this.btnCollegeStu.UseVisualStyleBackColor = true;
            this.btnCollegeStu.Click += new System.EventHandler(this.btnCollegeStu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "年龄";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 313);
            this.Controls.Add(this.btnCollegeStu);
            this.Controls.Add(this.btnMiddleStu);
            this.Controls.Add(this.btnPupil);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "大中小学生求平均成绩";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Button btnPupil;
        private System.Windows.Forms.Button btnMiddleStu;
        private System.Windows.Forms.Button btnCollegeStu;
        private System.Windows.Forms.Label label1;
    }
}

