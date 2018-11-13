using keypass.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using keypass.Account;
using System.Security.Cryptography;

namespace keypass
{
    public delegate void addLoadListEntry();
    public delegate void AddEntry(keypass.Account.Account acc);
    public partial class frmKeyPass : Form
    {
        public addLoadListEntry callbackLoadListEntry;
        public AddEntry callAddEntry;
        public frmMainKeyPass mainKeyPass;
        public frmKeyPass()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            txtRepeat.UseSystemPasswordChar = true;
            btnAccept.Enabled = false;
            lbCheck.Visible = false;
        }
        private void frmKeyPass_Load(object sender, EventArgs e)
        {
            txtTitle.Focus();
        }
        public keypass.Account.Account createAccount()
        {
            keypass.Account.Account acc = new keypass.Account.Account();
            acc.Title=txtTitle.Text;
            acc.Password=txtPassword.Text;
            acc.Notes=txtNotes.Text;
            acc.URL=txtURL.Text;
            acc.UserName=txtUserName.Text;
            return acc;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            
            keypass.Account.Account acc = new keypass.Account.Account();
            acc = createAccount();
            this.Hide();
            if(callAddEntry !=null)
            {
                callAddEntry(acc);
            }
            if (callbackLoadListEntry != null)
            {
                callbackLoadListEntry();
            }

        }
        private void ConditionToEnableBtn()
        {
            btnAccept.Enabled = txtTitle.Text != string.Empty&&
                                txtUserName.Text != string.Empty&&
                                txtPassword.Text != string.Empty&&
                                txtRepeat.Text != string.Empty;
        }
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            ConditionToEnableBtn();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            ConditionToEnableBtn();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
            ConditionToEnableBtn();
        }

        private void txtRepeat_TextChanged(object sender, EventArgs e)
        {
            if (txtRepeat.Text != txtPassword.Text)
            {
                lbCheck.Visible = true;
                lbCheck.ForeColor = System.Drawing.Color.Red;
                btnAccept.Enabled = false;
            }
            else if(txtRepeat.Text=="")
            {
                btnAccept.Enabled = false;
            }
            else
            {
                lbCheck.Visible = false;
                btnAccept.Enabled = true;
            }

        }
    }
}
