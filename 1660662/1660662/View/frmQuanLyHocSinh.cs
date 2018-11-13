using _1660662.DataDPOAccess;
using _1660662.View.subfrmHocSinh;
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
    public partial class frmQuanLyHocSinh : Form
    {
        private QLHSDataContext context;
        public frmQuanLyHocSinh()
        {
            InitializeComponent();
            context = new QLHSDataContext();
            btnDeleteStudent.Enabled = false;
            btnUpdateStudent.Enabled = false;
            lbError.Hide();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmThemHocSinh themHocSinh = new frmThemHocSinh();
            themHocSinh.ShowDialog();
        }
        private void ConditionToEnableBtn()
        {
            btnDeleteStudent.Enabled = txtStudent.Text != string.Empty;
            btnUpdateStudent.Enabled = txtStudent.Text != string.Empty;
        }
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if(context==null)
                context = new QLHSDataContext();
            var Student = (from HocSinh in context.HOCSINHs
                          where HocSinh.MaHocSinh == Int32.Parse(txtStudent.Text)
                          select HocSinh).FirstOrDefault();
            if (Student != null)
            {
                context.HOCSINHs.DeleteOnSubmit(Student);
                context.SubmitChanges();
                clearListStudent();
                showListStudent();
                txtStudent.Text = "";
                if (txtStudent.Text != string.Empty)
                {
                    var Student1 = context.HOCSINHs.Where(hs => hs.MaHocSinh.ToString() == txtStudent.Text);
                    if (Student1.Count() == 0)
                    {
                        btnDeleteStudent.Enabled = false;
                        btnUpdateStudent.Enabled = false;
                        lbError.Hide();
                    }
                    else
                    {
                        lbError.Show();
                    }
                }
                else
                    lbError.Hide();
            }
            context.Dispose();
        }

        private void txtClass_TextChanged(object sender, EventArgs e)
        {
            QLHSDataContext context = new QLHSDataContext();
            ConditionToEnableBtn();
            if (txtStudent.Text != string.Empty)
            {
                var Student = context.HOCSINHs.Where(hs => hs.MaHocSinh.ToString() == txtStudent.Text);
                if (Student.Count() != 0)
                {
                    btnDeleteStudent.Enabled = true;
                    btnUpdateStudent.Enabled = true;
                    lbError.Hide();
                }
                else
                {
                    btnDeleteStudent.Enabled = false;
                    btnUpdateStudent.Enabled = false;
                    lbError.Show();
                }
            }
            else
                lbError.Hide();
            context.Dispose();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            frmSuaHocSinh suaHocSinh = new frmSuaHocSinh(txtStudent.Text);
            suaHocSinh.ShowDialog();
            clearListStudent();
            showListStudent();
        }
        private void showListStudent()
        {
            QLHSDataContext context = new QLHSDataContext();
            var listHocSinh = (from student in context.HOCSINHs
                               select student).ToList();
            datagridviewStudent.DataSource = listHocSinh;
            context.Dispose();
        }
        private void clearListStudent()
        {
            if (datagridviewStudent.DataSource != null)
            {
                datagridviewStudent.DataSource = null;
                datagridviewStudent.Refresh();
            }
        }
        private void btnListStudent_Click(object sender, EventArgs e)
        {
            clearListStudent();
            showListStudent();
        }

    }
}
