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
    public partial class frmSuaLopHoc : Form
    {
        public frmSuaLopHoc(string IDclass)
        {
            InitializeComponent();
            txtIDClass.Text = IDclass;
        }

        private void frmSuaLopHoc_Load(object sender, EventArgs e)
        {
            QLHSDataContext context = new QLHSDataContext();
            var Class = (from LopHoc in context.LOPHOCs
                         where LopHoc.MaLop.ToString() == txtIDClass.Text
                         select LopHoc).FirstOrDefault();
            if (Class != null)
            {
                txtClassPresident.Text = Class.LopTruong.ToString();
                txtIDTeacher.Text = Class.GVQuanLy.ToString();
                txtNumberOfStudent.Text = Class.SiSo.ToString();
                dateTimePicker1.Text = Class.NamBatDau.ToString();
                dateTimePicker2.Text = Class.NamKetThuc.ToString();
               
            }
            context.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            QLHSDataContext context = new QLHSDataContext();
            var Class = (from LopHoc in context.LOPHOCs
                         where LopHoc.MaLop.ToString() == txtIDClass.Text
                         select LopHoc).FirstOrDefault();
            if (Class != null)
            {
                Class.SiSo = Int32.Parse(txtNumberOfStudent.Text);
                Class.LopTruong = Int32.Parse(txtClassPresident.Text);
                Class.GVQuanLy = Int32.Parse(txtIDTeacher.Text);
                Class.NamBatDau = Convert.ToDateTime(dateTimePicker1.Text);
                Class.NamKetThuc = Convert.ToDateTime(dateTimePicker2.Text);
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
