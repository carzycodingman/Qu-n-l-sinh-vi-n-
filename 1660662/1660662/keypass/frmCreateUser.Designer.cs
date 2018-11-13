namespace keypass
{
    partial class frmCreateUser
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
            this.lbUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtRepeat = new System.Windows.Forms.TextBox();
            this.lbRepeat = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.lbCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(20, 30);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(81, 13);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Tên đăng nhập";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(107, 23);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(209, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // txtRepeat
            // 
            this.txtRepeat.Location = new System.Drawing.Point(107, 75);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Size = new System.Drawing.Size(209, 20);
            this.txtRepeat.TabIndex = 2;
            this.txtRepeat.TextChanged += new System.EventHandler(this.txtRepeat_TextChanged);
            // 
            // lbRepeat
            // 
            this.lbRepeat.AutoSize = true;
            this.lbRepeat.Location = new System.Drawing.Point(55, 82);
            this.lbRepeat.Name = "lbRepeat";
            this.lbRepeat.Size = new System.Drawing.Size(46, 13);
            this.lbRepeat.TabIndex = 2;
            this.lbRepeat.Text = "Nhập lại";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(107, 49);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(209, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(49, 56);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(52, 13);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(160, 111);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Đăng kí";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(241, 111);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.Text = "Hủy";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // lbCheck
            // 
            this.lbCheck.AutoSize = true;
            this.lbCheck.Location = new System.Drawing.Point(322, 82);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(92, 13);
            this.lbCheck.TabIndex = 8;
            this.lbCheck.Text = "Không trùng khớp";
            this.lbCheck.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmCreateUser
            // 
            this.AcceptButton = this.btnSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(418, 160);
            this.Controls.Add(this.lbCheck);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtRepeat);
            this.Controls.Add(this.lbRepeat);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lbUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtRepeat;
        private System.Windows.Forms.Label lbRepeat;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label lbCheck;
    }
}