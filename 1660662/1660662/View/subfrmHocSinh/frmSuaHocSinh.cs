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
    public partial class frmSuaHocSinh : Form
    {
        public frmSuaHocSinh(string IDStudent)
        {
            InitializeComponent();
            txtIDStudent.Text = IDStudent;

        }

        private void frmSuaHocSinh_Load(object sender, EventArgs e)
        {
            QLHSDataContext context = new QLHSDataContext();
            var Student = (from HocSinh in context.HOCSINHs
                           where HocSinh.MaHocSinh.ToString() == txtIDStudent.Text
                           select HocSinh).FirstOrDefault();
            if(Student != null)
            {
                txtFullName.Text = Student.TenHocSinh;
                txtIDClass.Text = Student.MaLop.ToString();
                txtSex.Text = Student.GioiTinh;
                dateTimePicker1.Text = Student.NgaySinh.ToString();

            }
            context.Dispose();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            QLHSDataContext context = new QLHSDataContext();
            var student = (from HocSinh in context.HOCSINHs
                         where HocSinh.MaHocSinh == Int32.Parse(txtIDStudent.Text)
                         select HocSinh).FirstOrDefault();
            if (student != null)
            {
                student.MaLop = Int32.Parse(txtIDClass.Text);
                student.NgaySinh = Convert.ToDateTime(dateTimePicker1.Text);
                student.TenHocSinh = txtFullName.Text;
                student.GioiTinh = txtSex.Text;
                context.SubmitChanges();
            }
            context.Dispose();
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
