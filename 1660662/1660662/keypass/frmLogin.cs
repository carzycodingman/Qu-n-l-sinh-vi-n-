﻿using System;
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
    public delegate void CancleLogin();
    public partial class frmLogin : Form
    {
        private const int Keysize = 256;
        private string strPassword = "";
        public bool cancle = false; 

        // This constant determines the number of iterations for the password bytes generation function.
        private const int DerivationIterations = 1000;
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            lbNotification.Visible = false;
        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }
        
       

        private void btnCancle_Click(object sender, EventArgs e)
        {

            cancle = true;
            txtPassword.Clear();
            txtUserName.Clear();
            this.Close();
        }
        public void Pass(string pass)
        {
            this.strPassword = pass;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtPassword.Text == null)
            {
                lbNotification.Visible = true;
                lbNotification.ForeColor = System.Drawing.Color.Red;
            }
            else if (txtPassword.Text != this.Decrypt(strPassword, "password*&%^*&%^&%^$"))
            {
                lbNotification.Visible = false;
                MessageBox.Show("Sai mật khẩu!!!", "ERROR");
            }
            else
                this.Close();
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private string Decrypt(string cipherText, string passPhrase)
        {
            // Get the complete stream of bytes that represent:
            // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }
    }
}
