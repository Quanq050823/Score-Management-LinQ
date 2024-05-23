using PrjTest.BL;
using PrjTest.Hooman;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjTest.StudentForm
{
    public partial class fStudentInformation : Form
    {
        Student_Object hooman = new Student_Object();
        BLStudent student = new BLStudent();

        int ID;

        public fStudentInformation()
        {
            InitializeComponent();
        }

        private void fStudentInformation_Load(object sender, EventArgs e)
        {
            ID = fLogin.RootID;
            hooman = student.GetInfo(ID);

            txtID.Text = hooman.Student_ID.ToString();
            txtIDC.Text += hooman.Student_IDC.ToString();
            txtAdmission.Text += hooman.Admission.ToString();
            txtMajor.Text += hooman.Major.ToString();
            txtName.Text += hooman.Student_Name.ToString();

            txtMail.Text += hooman.Email.ToString();
            txtPhone.Text += hooman.Phone_num.ToString();
            txtDoB.Text += hooman.DoB1.ToShortDateString();
            if (hooman.Gender) txtGender.Text = "Male";
            else txtGender.Text = "Female";

            txtScholastic.Text = hooman.Admission.ToString() + " - " + (hooman.Admission + 4).ToString();

            txtSetUp();
        }

        public void txtSetUp()
        {
            txtID.ReadOnly= true;
            txtIDC.ReadOnly= true;
            txtAdmission.ReadOnly= true;
            txtMajor.ReadOnly= true;
            txtName.ReadOnly= true;
            txtMail.ReadOnly= true;
            txtPhone.ReadOnly= true;
            txtDoB.ReadOnly= true;
            txtGender.ReadOnly= true;
            txtScholastic.ReadOnly= true;

            btnEdit.Visible= false;
            btDone.Visible = false;
        }

        public void txtEnable()
        {
            txtID.Enabled = true;
            txtIDC.Enabled = true;
            txtAdmission.Enabled = true;
            txtMajor.Enabled = true;
            txtName.Enabled = true;
            txtMail.Enabled = true;
            txtPhone.Enabled = true;
            txtDoB.ReadOnly = true;
            txtGender.ReadOnly = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtIDC.Enabled = false;
            txtAdmission.Enabled = false;
            txtMajor.Enabled = false;
            txtName.Enabled = false;            
            txtDoB.Enabled = false;
            txtGender.Enabled = false;

            txtMail.Enabled = true;
            txtPhone.Enabled = true;
            txtMail.ReadOnly = false;
            txtPhone.ReadOnly = false;
        }

        private void btDone_Click(object sender, EventArgs e)
        {

        }
    }
}
