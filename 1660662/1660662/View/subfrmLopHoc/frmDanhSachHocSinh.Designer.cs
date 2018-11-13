namespace _1660662.View.subfrmLopHoc
{
    partial class frmDanhSachHocSinh
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
            this.datagridviewListStudent = new System.Windows.Forms.DataGridView();
            this.lbListStudent = new System.Windows.Forms.Label();
            this.txtIDClass = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewListStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridviewListStudent
            // 
            this.datagridviewListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewListStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagridviewListStudent.Location = new System.Drawing.Point(0, 56);
            this.datagridviewListStudent.Name = "datagridviewListStudent";
            this.datagridviewListStudent.Size = new System.Drawing.Size(529, 167);
            this.datagridviewListStudent.TabIndex = 0;
            // 
            // lbListStudent
            // 
            this.lbListStudent.AutoSize = true;
            this.lbListStudent.Location = new System.Drawing.Point(13, 13);
            this.lbListStudent.Name = "lbListStudent";
            this.lbListStudent.Size = new System.Drawing.Size(122, 13);
            this.lbListStudent.TabIndex = 1;
            this.lbListStudent.Text = "Danh sách học sinh lớp:";
            // 
            // txtIDClass
            // 
            this.txtIDClass.Location = new System.Drawing.Point(151, 9);
            this.txtIDClass.Name = "txtIDClass";
            this.txtIDClass.Size = new System.Drawing.Size(75, 20);
            this.txtIDClass.TabIndex = 2;
            this.txtIDClass.TextChanged += new System.EventHandler(this.txtIDClass_TextChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(151, 30);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Xem";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(233, 12);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(108, 13);
            this.lbError.TabIndex = 4;
            this.lbError.Text = "*Mã lớp không tồn tại";
            // 
            // frmDanhSachHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 223);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtIDClass);
            this.Controls.Add(this.lbListStudent);
            this.Controls.Add(this.datagridviewListStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDanhSachHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDanhSachHocSinh";
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewListStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridviewListStudent;
        private System.Windows.Forms.Label lbListStudent;
        private System.Windows.Forms.TextBox txtIDClass;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lbError;
    }
}