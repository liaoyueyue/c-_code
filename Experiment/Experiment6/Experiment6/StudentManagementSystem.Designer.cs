namespace Experiment6
{
    partial class StudentManagementSystem
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
            components = new System.ComponentModel.Container();
            dBManagerBindingSource = new BindingSource(components);
            dataGridView = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnStudentId = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnGender = new DataGridViewTextBoxColumn();
            ColumnAge = new DataGridViewTextBoxColumn();
            ColumnMajor = new DataGridViewTextBoxColumn();
            ColumnPhoto = new DataGridViewTextBoxColumn();
            btnAddStudent = new Button();
            btnDelStudent = new Button();
            btnUpdateStudent = new Button();
            btnQueryStudent = new Button();
            txtQueryStudent = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dBManagerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dBManagerBindingSource
            // 
            dBManagerBindingSource.DataSource = typeof(utils.DBManager);
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnStudentId, ColumnName, ColumnGender, ColumnAge, ColumnMajor, ColumnPhoto });
            dataGridView.Location = new Point(12, 66);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.ScrollBars = ScrollBars.None;
            dataGridView.Size = new Size(776, 426);
            dataGridView.TabIndex = 0;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "编号";
            ColumnId.Name = "ColumnId";
            // 
            // ColumnStudentId
            // 
            ColumnStudentId.HeaderText = "学号";
            ColumnStudentId.Name = "ColumnStudentId";
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "姓名";
            ColumnName.Name = "ColumnName";
            // 
            // ColumnGender
            // 
            ColumnGender.HeaderText = "性别";
            ColumnGender.Name = "ColumnGender";
            // 
            // ColumnAge
            // 
            ColumnAge.HeaderText = "年龄";
            ColumnAge.Name = "ColumnAge";
            // 
            // ColumnMajor
            // 
            ColumnMajor.HeaderText = "专业";
            ColumnMajor.Name = "ColumnMajor";
            // 
            // ColumnPhoto
            // 
            ColumnPhoto.HeaderText = "电话";
            ColumnPhoto.Name = "ColumnPhoto";
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(12, 16);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(160, 44);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "添加学生";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnDelStudent
            // 
            btnDelStudent.Location = new Point(178, 16);
            btnDelStudent.Name = "btnDelStudent";
            btnDelStudent.Size = new Size(160, 44);
            btnDelStudent.TabIndex = 2;
            btnDelStudent.Text = "删除学生";
            btnDelStudent.UseVisualStyleBackColor = true;
            btnDelStudent.Click += btnDelStudent_Click;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.Location = new Point(344, 16);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(160, 44);
            btnUpdateStudent.TabIndex = 3;
            btnUpdateStudent.Text = "修改学生";
            btnUpdateStudent.UseVisualStyleBackColor = true;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            // 
            // btnQueryStudent
            // 
            btnQueryStudent.Location = new Point(692, 16);
            btnQueryStudent.Name = "btnQueryStudent";
            btnQueryStudent.Size = new Size(96, 44);
            btnQueryStudent.TabIndex = 4;
            btnQueryStudent.Text = "查询学生";
            btnQueryStudent.UseVisualStyleBackColor = true;
            btnQueryStudent.Click += btnQueryStudent_Click;
            // 
            // txtQueryStudent
            // 
            txtQueryStudent.Location = new Point(510, 16);
            txtQueryStudent.Multiline = true;
            txtQueryStudent.Name = "txtQueryStudent";
            txtQueryStudent.Size = new Size(176, 44);
            txtQueryStudent.TabIndex = 5;
            // 
            // StudentManagementSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(txtQueryStudent);
            Controls.Add(btnQueryStudent);
            Controls.Add(btnUpdateStudent);
            Controls.Add(btnDelStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(dataGridView);
            Name = "StudentManagementSystem";
            Text = "学生信息管理";
            ((System.ComponentModel.ISupportInitialize)dBManagerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource dBManagerBindingSource;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnStudentId;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnGender;
        private DataGridViewTextBoxColumn ColumnAge;
        private DataGridViewTextBoxColumn ColumnMajor;
        private DataGridViewTextBoxColumn ColumnPhoto;
        private Button btnAddStudent;
        private Button btnDelStudent;
        private Button btnUpdateStudent;
        private Button btnQueryStudent;
        private TextBox txtQueryStudent;
    }
}