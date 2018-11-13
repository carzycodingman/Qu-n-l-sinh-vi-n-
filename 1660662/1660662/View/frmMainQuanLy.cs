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

namespace _1660662.View
{
    public partial class frmMainQuanLy : Form
    {
        public frmMainQuanLy()
        {
            InitializeComponent();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManagerClass_Click(object sender, EventArgs e)
        {
            frmQuanLyLopHoc frmQuanLyLop = new frmQuanLyLopHoc();
            CheckConnectToServer();
            frmQuanLyLop.ShowDialog();
        }

        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            frmQuanLyHocSinh frmQLHocSinh = new frmQuanLyHocSinh();
            CheckConnectToServer();
            frmQLHocSinh.ShowDialog();
        }

        private void CheckConnectToServer()
        {
            QLHSDataContext context = new QLHSDataContext();
            if (!context.DatabaseExists())
            {
                DialogResult res = MessageBox.Show("Không thể kết nối đến Server! Vui lòng thử lại.", "ERROR");
                if(res == DialogResult.OK)
                {
                    this.Close();
                    context.Dispose();
                }
            }

        }

        private void frmMainQuanLy_Load(object sender, EventArgs e)
        {
      
        }
    }
}
