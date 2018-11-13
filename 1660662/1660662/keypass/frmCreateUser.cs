using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keypass
{
    public partial class frmCreateUser : Form
    {
        private const int Keysize = 256;
        public bool cancle = false;
        // This constant determines the number of iterations for the password bytes generation function.
        private const int DerivationIterations = 1000;
        public frmCreateUser()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            txtRepeat.UseSystemPasswordChar = true;
            lbCheck.Visible = false;
            
        }
        private string Encrypt(string plainText, string passPhrase)
        {
            // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
            // so that the same Salt and IV values can be used when decrypting.  
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }
        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
        private void txtRepeat_TextChanged(object sender, EventArgs e)
        {
            if(txtRepeat.Text != "")
                lbCheck.Visible = true;
            if (txtRepeat.Text != txtPassword.Text&&txtRepeat.Text!="")
            {
                lbCheck.ForeColor = System.Drawing.Color.Red;
                btnSignUp.Enabled = false;
            }
            else
            {
                lbCheck.Visible = false;
                btnSignUp.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            cancle = true;
            txtPassword.Clear();
            txtRepeat.Clear();
            txtUserName.Clear();
            this.Close();
        }
        public string UserName()
        {
            return txtUserName.Text;
        }
        public string Password ()
        {
            return txtPassword.Text;
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string strPass = this.Encrypt(txtPassword.Text,"password*&%^*&%^&%^$");
            txtPassword.Text = strPass;
            this.Close();
        }
    }
}
