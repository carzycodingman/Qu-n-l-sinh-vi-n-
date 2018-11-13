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

namespace _1660662.View.subfrmLopHoc
{
    public partial class frmQuanLyHocSinh : Form
    {
        public frmQuanLyHocSinh()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LOPHOC lophoc = new LOPHOC
            {
                MaLop = Int32.Parse(txtIDClass.Text),
                SiSo = Int32.Parse(txtNumberOfStudent.Text),
                LopTruong = Int32.Parse(txtClassPresident.Text),
                GVQuanLy = Int32.Parse(txtIDTeacher.Text),
                NamBatDau = Convert.ToDateTime(dateTimePicker1.Text),
                NamKetThuc = Convert.ToDateTime(dateTimePicker2.Text)
            };
            QLHSDataContext context = new QLHSDataContext();
            context.LOPHOCs.InsertOnSubmit(lophoc);
            context.SubmitChanges();
            context.Dispose();
            this.Close();
        }
    }
}
