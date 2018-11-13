namespace keypass
{
    partial class frmKeyPass
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
            this.lbHeadImage = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbRepeat = new System.Windows.Forms.Label();
            this.lbQuality = new System.Windows.Forms.Label();
            this.lbNotes = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtRepeat = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lbURL = new System.Windows.Forms.Label();
            this.lbCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbHeadImage
            // 
            this.lbHeadImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbHeadImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHeadImage.Location = new System.Drawing.Point(0, 0);
            this.lbHeadImage.Name = "lbHeadImage";
            this.lbHeadImage.Size = new System.Drawing.Size(408, 93);
            this.lbHeadImage.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.Location = new System.Drawing.Point(24, 116);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(68, 22);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Title:";
            // 
            // lbUserName
            // 
            this.lbUserName.Location = new System.Drawing.Point(24, 142);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(68, 22);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "User Name:";
            // 
            // lbPassword
            // 
            this.lbPassword.Location = new System.Drawing.Point(24, 168);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(68, 22);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password:";
            // 
            // lbRepeat
            // 
            this.lbRepeat.Location = new System.Drawing.Point(24, 194);
            this.lbRepeat.Name = "lbRepeat";
            this.lbRepeat.Size = new System.Drawing.Size(68, 22);
            this.lbRepeat.TabIndex = 4;
            this.lbRepeat.Text = "Repeat:";
            // 
            // lbQuality
            // 
            this.lbQuality.Location = new System.Drawing.Point(24, 220);
            this.lbQuality.Name = "lbQuality";
            this.lbQuality.Size = new System.Drawing.Size(68, 22);
            this.lbQuality.TabIndex = 5;
            this.lbQuality.Text = "Quality:";
            // 
            // lbNotes
            // 
            this.lbNotes.Location = new System.Drawing.Point(24, 272);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(68, 22);
            this.lbNotes.TabIndex = 6;
            this.lbNotes.Text = "Notes:";
            // 
            // txtTitle
            // 
            this.txtTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTitle.Location = new System.Drawing.Point(98, 113);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(225, 20);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(98, 272);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(225, 117);
            this.txtNotes.TabIndex = 5;
            // 
            // txtRepeat
            // 
            this.txtRepeat.Location = new System.Drawing.Point(98, 191);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.PasswordChar = '*';
            this.txtRepeat.Size = new System.Drawing.Size(225, 20);
            this.txtRepeat.TabIndex = 3;
            this.txtRepeat.TextChanged += new System.EventHandler(this.txtRepeat_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(98, 165);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(225, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(98, 139);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(225, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(248, 404);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(167, 404);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "OK";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(98, 243);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(225, 20);
            this.txtURL.TabIndex = 4;
            // 
            // lbURL
            // 
            this.lbURL.Location = new System.Drawing.Point(24, 246);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(68, 22);
            this.lbURL.TabIndex = 15;
            this.lbURL.Text = "URL";
            // 
            // lbCheck
            // 
            this.lbCheck.AutoSize = true;
            this.lbCheck.Location = new System.Drawing.Point(330, 194);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(59, 13);
            this.lbCheck.TabIndex = 16;
            this.lbCheck.Text = "Chưa khớp";
            // 
            // frmKeyPass
            // 
            this.AcceptButton = this.btnAccept;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(408, 504);
            this.Controls.Add(this.lbCheck);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtRepeat);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lbNotes);
            this.Controls.Add(this.lbQuality);
            this.Controls.Add(this.lbRepeat);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbHeadImage);
            this.Name = "frmKeyPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Entry";
            this.Load += new System.EventHandler(this.frmKeyPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeadImage;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbRepeat;
        private System.Windows.Forms.Label lbQuality;
        private System.Windows.Forms.Label lbNotes;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtRepeat;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.Label lbCheck;
    }
}