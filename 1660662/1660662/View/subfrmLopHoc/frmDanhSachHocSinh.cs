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
    public partial class frmDanhSachHocSinh : Form
    {
        public frmDanhSachHocSinh(string strIDClass)
        {
            InitializeComponent();
            txtIDClass.Text = strIDClass;
            btnShow.Enabled = false;
            lbError.Hide();
            clearListStudent();
            showListStudent();
        }
        public frmDanhSachHocSinh()
        {
            InitializeComponent();
            btnShow.Enabled = false;
            lbError.Hide();
        }
        private void showListStudent()
        {
            QLHSDataContext context = new QLHSDataContext();
            var listHocSinh = (from student in context.HOCSINHs
                               where student.MaLop == Int32.Parse(txtIDClass.Text)
                               select student).ToList();
            datagridviewListStudent.DataSource = listHocSinh;
            context.Dispose();
        }
        private void clearListStudent()
        {
            if (datagridviewListStudent.DataSource != null)
            {
                datagridviewListStudent.DataSource = null;
                datagridviewListStudent.Refresh();
            }
        }

        private void txtIDClass_TextChanged(object sender, EventArgs e)
        {
            if(txtIDClass.Text == string.Empty)
            {
                btnShow.Enabled = false;
                lbError.Hide();
            }
            else
            {
                QLHSDataContext context = new QLHSDataContext();
                var Class = context.LOPHOCs.Where(lh=>lh.MaLop == Int32.Parse(txtIDClass.Text));
                if(Class.Count()>0)
                {
                    btnShow.Enabled = true;
                    lbError.Hide();
                }
                else
                {
                    btnShow.Enabled = false;
                    lbError.Show();
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            clearListStudent();
            showListStudent();
        }
    }
}
