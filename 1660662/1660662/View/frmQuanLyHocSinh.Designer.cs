namespace _1660662.View
{
    partial class frmQuanLyHocSinh
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
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnListStudent = new System.Windows.Forms.Button();
            this.datagridviewStudent = new System.Windows.Forms.DataGridView();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(344, 4);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(162, 23);
            this.btnUpdateStudent.TabIndex = 15;
            this.btnUpdateStudent.Text = "Sửa thông tin học sinh";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(222, 41);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(118, 23);
            this.btnAddStudent.TabIndex = 14;
            this.btnAddStudent.Text = "Thêm học sinh";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(222, 4);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(116, 23);
            this.btnDeleteStudent.TabIndex = 13;
            this.btnDeleteStudent.Text = "Xóa học sinh";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnListStudent
            // 
            this.btnListStudent.Location = new System.Drawing.Point(344, 41);
            this.btnListStudent.Name = "btnListStudent";
            this.btnListStudent.Size = new System.Drawing.Size(165, 23);
            this.btnListStudent.TabIndex = 12;
            this.btnListStudent.Text = "Danh sách học sinh";
            this.btnListStudent.UseVisualStyleBackColor = true;
            this.btnListStudent.Click += new System.EventHandler(this.btnListStudent_Click);
            // 
            // datagridviewStudent
            // 
            this.datagridviewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagridviewStudent.Location = new System.Drawing.Point(0, 73);
            this.datagridviewStudent.Name = "datagridviewStudent";
            this.datagridviewStudent.Size = new System.Drawing.Size(518, 206);
            this.datagridviewStudent.TabIndex = 8;
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(116, 6);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(100, 20);
            this.txtStudent.TabIndex = 16;
            this.txtStudent.TextChanged += new System.EventHandler(this.txtClass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ma học sinh";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(114, 26);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(99, 13);
            this.lbError.TabIndex = 18;
            this.lbError.Text = "*Không tìm thấy HS";
            // 
            // frmQuanLyHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 279);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnListStudent);
            this.Controls.Add(this.datagridviewStudent);
            this.Name = "frmQuanLyHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmQuanLyHocSinhForm1";
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnListStudent;
        private System.Windows.Forms.DataGridView datagridviewStudent;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbError;
    }
}