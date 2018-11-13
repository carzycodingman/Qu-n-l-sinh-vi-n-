using _1660662.DataDPOAccess;
using _1660662.View.subfrmLopHoc;
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
    public partial class frmQuanLyLopHoc : Form
    {

        public frmQuanLyLopHoc()
        {
            InitializeComponent();
            btnDeleteClass.Enabled = false;
            btnUpdateClass.Enabled = false;
            btnShowListStudent.Enabled = false;
            lbError.Hide();
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            QLHSDataContext context = new QLHSDataContext();
            var Class = (from LopHoc in context.LOPHOCs
                         where LopHoc.MaLop == Int32.Parse(txtClass.Text)
                         select LopHoc).FirstOrDefault();
            var students = (from student in context.HOCSINHs
                            where student.MaLop == Int32.Parse(txtClass.Text)
                            select student).ToList();
            if(students.Count > 0)
            {
                context.HOCSINHs.DeleteAllOnSubmit(students);
                context.SubmitChanges();
            }
            if (Class != null)
            {
                context.LOPHOCs.DeleteOnSubmit(Class);
                context.SubmitChanges();
                clearListClass();
                showListClass();
                txtClass.Text = "";
                if (txtClass.Text != string.Empty)
                {
                    var Class1 = context.LOPHOCs.Where(lh => lh.MaLop == Int32.Parse(txtClass.Text)).ToList();
                    if (Class1.Count == 0)
                    {
                        lbError.Show();
                        btnDeleteClass.Enabled = false;
                        btnUpdateClass.Enabled = false;
                        btnShowListStudent.Enabled = false;
                    }
                }
                else
                    lbError.Hide();
            }
            context.Dispose();
        }
        private void ConditionToEnableBtn()
        {
            btnUpdateClass.Enabled = txtClass.Text != string.Empty;
            btnDeleteClass.Enabled = txtClass.Text != string.Empty;
            btnShowListStudent.Enabled = txtClass.Text != string.Empty;
        }
        private void showListClass()
        {
            QLHSDataContext context = new QLHSDataContext();
            datagridviewClass.DataSource = (from Class in context.LOPHOCs
                                            select Class).ToList();
            context.Dispose();
        }
        private void clearListClass()
        {
            if (datagridviewClass.DataSource != null)
            {
                datagridviewClass.DataSource = null;
                datagridviewClass.Refresh();
            }
        }
        private void txtStudent_TextChanged(object sender, EventArgs e)
        {
            QLHSDataContext context = new QLHSDataContext();
            ConditionToEnableBtn();
            if (txtClass.Text != string.Empty)
            {
                var Class = context.LOPHOCs.Where(lh => lh.MaLop == Int32.Parse(txtClass.Text)).ToList();
                if (Class.Count == 0)
                {
                    lbError.Show();
                    btnDeleteClass.Enabled = false;
                    btnUpdateClass.Enabled = false;
                    btnShowListStudent.Enabled = false;
                }
            }
            else
                lbError.Hide();
            context.Dispose();
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            frmSuaLopHoc suaLopHoc = new frmSuaLopHoc(txtClass.Text);
            suaLopHoc.ShowDialog();
            clearListClass();
            showListClass();
        }

        private void btnListClass_Click(object sender, EventArgs e)
        {
            clearListClass();
            showListClass();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            subfrmLopHoc.frmQuanLyHocSinh themLopHoc = new subfrmLopHoc.frmQuanLyHocSinh();
            themLopHoc.ShowDialog();
            clearListClass();
            showListClass();
        }

        private void btnShowListStudent_Click(object sender, EventArgs e)
        {
            frmDanhSachHocSinh frmDSHocSinh = new frmDanhSachHocSinh(txtClass.Text);
            frmDSHocSinh.ShowDialog();
        }
    }
}
