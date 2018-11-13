using _1660662.DataDPOAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1660662.View.subfrmHocSinh
{
    public partial class frmThemHocSinh : Form
    {
        public frmThemHocSinh()
        {
            InitializeComponent();
            btnAdd.Enabled = false;
            lbError.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HOCSINH hocsinh = new HOCSINH
            {
                MaHocSinh = Int32.Parse(txtIDStudent.Text),
                TenHocSinh = txtFullName.Text,
                NgaySinh = Convert.ToDateTime(dtNgaySinh.Text),
                GioiTinh = txtSex.Text,
                MaLop = Int32.Parse(txtIDClass.Text)
            };
            QLHSDataContext context = new QLHSDataContext();
            context.HOCSINHs.InsertOnSubmit(hocsinh);
            context.SubmitChanges();
            context.Dispose();
            this.Close();
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIDClass_TextChanged(object sender, EventArgs e)
        {
            QLHSDataContext context = new QLHSDataContext();
            if (txtIDClass.Text != string.Empty)
            {
                var Class = context.LOPHOCs.Where(lh => lh.MaLop.ToString() == txtIDClass.Text);
                if (Class.Count() != 0)
                {
                    btnAdd.Enabled = true;
                    lbError.Hide();
                }
                else
                {
                    lbError.Show();
                }

            }
            else
            {
                lbError.Hide();
            }

        }
    }
}
