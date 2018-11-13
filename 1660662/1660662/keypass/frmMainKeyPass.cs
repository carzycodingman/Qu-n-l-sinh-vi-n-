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
using System.IO;
using System.Security.Cryptography;

namespace keypass
{
    public partial class frmMainKeyPass : Form
    {
        private ListAccount accounts;
        private string pathProgram = @"./Data/";
        private const int Keysize = 256;
        private string strPassword="";
        private string strUserName="";
        private string strNewFileName = "";

        // This constant determines the number of iterations for the password bytes generation function.
        private const int DerivationIterations = 1000;
        public frmMainKeyPass()
        {
            InitializeComponent();
            accounts = new ListAccount();
            listView1.FullRowSelect = true;
        }
        
        private void clearListViewItem()
        {
            listView1.Items.Clear();
        }

        private void loadListViewItem()
        {
            
            if (accounts != null)
            {
                clearListViewItem();
                foreach (keypass.Account.Account acc in accounts.listAccount)
                {
                    
                    ListViewItem lviTitle = new ListViewItem(acc.Title);
                    ListViewItem.ListViewSubItem lviUserName = new ListViewItem.ListViewSubItem(lviTitle,acc.UserName);
                    ListViewItem.ListViewSubItem lviPassword = new ListViewItem.ListViewSubItem(lviTitle,acc.Password);
                    ListViewItem.ListViewSubItem lviURL = new ListViewItem.ListViewSubItem(lviTitle, acc.URL);
                    ListViewItem.ListViewSubItem lviNotes = new ListViewItem.ListViewSubItem(lviTitle, acc.Notes);
                    listView1.Items.Add(lviTitle);
                    lviTitle.SubItems.Add(lviUserName);
                    lviTitle.SubItems.Add(lviPassword);
                    lviTitle.SubItems.Add(lviURL);
                    lviTitle.SubItems.Add(lviNotes);
                }
            }
        }
        private void PushEntryToList(keypass.Account.Account acc)
        {
            if (accounts == null)
                accounts = new ListAccount();
            if(accounts.addAccount(acc)==false)
            {
                MessageBox.Show("Tài khoản đã tồn tại!!!","Thông báo");
                return;
            }
            MessageBox.Show("Đã thêm entry thành công!", "Thông báo");
        }
        private void frmMainKeyPass_Load(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openKeyPass_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            
            openFile.InitialDirectory = @pathProgram;
            openFile.Title = "Open File";
            openFile.DefaultExt = "txt";
            openFile.Filter = "txt files (*.txt)|*.txt";
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;
            openFile.ReadOnlyChecked = true;
            openFile.ShowReadOnly = true;
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                accounts = new ListAccount();
                string fileContent = "";
                StreamReader reader = new StreamReader(openFile.OpenFile());
                if ((strUserName = reader.ReadLine()) == null ||
                    (strPassword = reader.ReadLine()) == null ||
                    strUserName == ""   ||
                    strPassword == "")
                {
                    MessageBox.Show("Tài liệu trống","Thông báo");
                    return;
                }
                while (fileContent != null)
                {
                    string Title = reader.ReadLine();
                    if (Title == null)
                    {
                        MessageBox.Show("Tài liệu trống", "Thông báo");
                        return;
                    }
                    keypass.Account.Account acc = new keypass.Account.Account(Title, reader.ReadLine(),
                                                                              reader.ReadLine(), reader.ReadLine(),
                                                                              reader.ReadLine());
                    accounts.addAccount(acc);
                    fileContent = reader.ReadLine();
                }
                reader.Dispose();
                reader.Close();
                login.Pass(strPassword);
                
                login.ShowDialog();
                if (login.cancle == true)
                    accounts.listAccount.Clear();
                loadListViewItem();
            }
        }
        
        private static void AddText(Stream fs ,string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
        private void saveKeyPass_Click(object sender, EventArgs e)
        {

            saveFile.InitialDirectory = @pathProgram;
            saveFile.Title = "Save File";
            if(strNewFileName!="")
                saveFile.FileName = newFile.FileName;
            saveFile.DefaultExt = "txt";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;
            if(saveFile.ShowDialog()==DialogResult.OK)
            {
                    StreamWriter writer = new StreamWriter(saveFile.OpenFile());
                writer.WriteLine(strUserName);
                writer.WriteLine(strPassword);
                for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        writer.WriteLine(listView1.Items[i].Text);
                        writer.WriteLine(listView1.Items[i].SubItems[1].Text);
                        writer.WriteLine(this.Encrypt(listView1.Items[i].SubItems[2].Text, "keypass*&^&*%^^%$&^%"));
                        writer.WriteLine(listView1.Items[i].SubItems[3].Text);
                        writer.WriteLine(listView1.Items[i].SubItems[4].Text);

                    if (i + 1 <= listView1.Items.Count - 1)
                    {
                        writer.WriteLine();
                    }
                    }
                    writer.Dispose();
                    writer.Close();
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveasKeyPass_Click(object sender, EventArgs e)
        {
            saveFile.InitialDirectory = @pathProgram;
            saveFile.Title = "Save File";
            if (strNewFileName != "")
                saveFile.FileName = newFile.FileName;
            if(strUserName==""||strPassword=="")
            {
                frmCreateUser frmCreateAccount = new frmCreateUser();
                frmCreateAccount.ShowDialog();
                if (frmCreateAccount.cancle == true)
                    return;
                this.strPassword = frmCreateAccount.Password();
                this.strUserName = frmCreateAccount.UserName();
            }
            saveFile.DefaultExt = "txt";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;
            //if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFile.OpenFile());
                writer.WriteLine(strUserName);
                writer.WriteLine(strPassword);
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    writer.WriteLine(listView1.Items[i].Text);
                    writer.WriteLine(listView1.Items[i].SubItems[1].Text);
                    writer.WriteLine(this.Encrypt(listView1.Items[i].SubItems[2].Text, "keypass*&^&*%^^%$&^%"));
                    writer.WriteLine(listView1.Items[i].SubItems[3].Text);
                    writer.WriteLine(listView1.Items[i].SubItems[4].Text);

                    if (i + 1 <= listView1.Items.Count - 1)
                    {
                        writer.WriteLine();
                    }
                }
                writer.Dispose();
                writer.Close();
                MessageBox.Show("Đã lưu","Thông báo");
            }
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(folderPath.ShowDialog() == DialogResult.OK)
            {
                pathProgram = folderPath.SelectedPath;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKeyPass frmEntry = new frmKeyPass();
            frmEntry.callbackLoadListEntry += new addLoadListEntry(loadListViewItem);
            frmEntry.callAddEntry += new AddEntry(PushEntryToList);
            frmEntry.ShowDialog();
        }

        private void deleteEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(listView1 != null)
            {
                for(int i = 0; i<listView1.Items.Count;i++)
                {
                    if(listView1.Items[i].Selected||listView1.Items[i].Checked==true)
                    {
                        keypass.Account.Account acc = new keypass.Account.Account();
                        acc.Title = listView1.Items[i].Text;
                        acc.Title = listView1.Items[i].SubItems[1].Text;
                        acc.Title = listView1.Items[i].SubItems[1].Text;
                        acc.Title = listView1.Items[i].SubItems[1].Text;
                        acc.Title = listView1.Items[i].SubItems[1].Text;
                        accounts.removeAccount(acc);
                        listView1.Items[i].Remove();
                        MessageBox.Show("đã xóa entry!!!", "Thông báo");
                        return;
                        
                    }
                }
                MessageBox.Show("Không tìm thấy entry!!!","Thông báo");
            }
        }

        private void itemCheckBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(itemCheckBoxToolStripMenuItem.Checked)
            {
                listView1.CheckBoxes = true;
            }
        }

        private void listView1_Resize(object sender, EventArgs e)
        {

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

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateUser frmCreateAccount = new frmCreateUser();
            frmCreateAccount.ShowDialog();
            if(frmCreateAccount.cancle == true)
            {
                return;
            }
            
            this.strPassword = frmCreateAccount.Password();
            this.strUserName = frmCreateAccount.UserName();
            newFile.InitialDirectory = @pathProgram;
            newFile.Title = "Save File";
            newFile.DefaultExt = "txt";
            newFile.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";
            newFile.FilterIndex = 2;
            newFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                accounts = new ListAccount();
                clearListViewItem();
            }
            strNewFileName = newFile.FileName;
            
        }

        private void lbInformation_Click(object sender, EventArgs e)
        {
        }

        private void addEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void deleteEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
