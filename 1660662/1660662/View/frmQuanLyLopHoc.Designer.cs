namespace _1660662.View
{
    partial class frmQuanLyLopHoc
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
            this.datagridviewClass = new System.Windows.Forms.DataGridView();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnListClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.btnShowListStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewClass)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridviewClass
            // 
            this.datagridviewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewClass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagridviewClass.Location = new System.Drawing.Point(0, 62);
            this.datagridviewClass.Name = "datagridviewClass";
            this.datagridviewClass.Size = new System.Drawing.Size(569, 206);
            this.datagridviewClass.TabIndex = 0;
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Location = new System.Drawing.Point(295, 4);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteClass.TabIndex = 5;
            this.btnDeleteClass.Text = "Xóa lóp học";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // btnListClass
            // 
            this.btnListClass.Location = new System.Drawing.Point(396, 33);
            this.btnListClass.Name = "btnListClass";
            this.btnListClass.Size = new System.Drawing.Size(128, 23);
            this.btnListClass.TabIndex = 4;
            this.btnListClass.Text = "Danh sách lớp học";
            this.btnListClass.UseVisualStyleBackColor = true;
            this.btnListClass.Click += new System.EventHandler(this.btnListClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(295, 33);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(98, 23);
            this.btnAddClass.TabIndex = 6;
            this.btnAddClass.Text = "Thêm lớp học";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.Location = new System.Drawing.Point(396, 4);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(128, 23);
            this.btnUpdateClass.TabIndex = 7;
            this.btnUpdateClass.Text = "Sửa thông tin lớp học";
            this.btnUpdateClass.UseVisualStyleBackColor = true;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(66, 7);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 20);
            this.txtClass.TabIndex = 17;
            this.txtClass.TextChanged += new System.EventHandler(this.txtStudent_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã lớp";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(64, 28);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(98, 13);
            this.lbError.TabIndex = 19;
            this.lbError.Text = "*Không tìm thấy LH";
            // 
            // btnShowListStudent
            // 
            this.btnShowListStudent.Location = new System.Drawing.Point(172, 5);
            this.btnShowListStudent.Name = "btnShowListStudent";
            this.btnShowListStudent.Size = new System.Drawing.Size(118, 23);
            this.btnShowListStudent.TabIndex = 20;
            this.btnShowListStudent.Text = "danh sách học sinh";
            this.btnShowListStudent.UseVisualStyleBackColor = true;
            this.btnShowListStudent.Click += new System.EventHandler(this.btnShowListStudent_Click);
            // 
            // frmQuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 268);
            this.Controls.Add(this.btnShowListStudent);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.btnUpdateClass);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.btnListClass);
            this.Controls.Add(this.datagridviewClass);
            this.Name = "frmQuanLyLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmQuanLy";
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridviewClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnListClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btnShowListStudent;
    }
}