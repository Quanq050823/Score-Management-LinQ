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
    public partial class fTeacherInformation : Form
    {

        Teacher_Object hooman = new Teacher_Object();
        BLTeacher teacher = new BLTeacher();

        int ID = fLogin.RootID;

        public fTeacherInformation()
        {
            InitializeComponent();
        }

        private void fTeacherInformation_Load(object sender, EventArgs e)
        {
            ID = fLogin.RootID;
            hooman = teacher.GetInfo(ID);

            txtID.Text = hooman.Teacher_ID.ToString();
            txtIDC.Text = hooman.Teacher_IDC.ToString();

            txtName.Text = hooman.Teacher_Name.ToString();

            txtMail.Text = hooman.Email.ToString();
            txtPhone.Text = hooman.Phone_no.ToString();
            txtDoB.Text = hooman.Dob.ToShortDateString();
            if (hooman.Gender) txtGender.Text = "Male";
            else txtGender.Text = "Female";


            txtSetUp();
        }

        public void txtSetUp()
        {
            txtID.ReadOnly= true;
            txtIDC.ReadOnly= true;
            
            txtName.ReadOnly= true;
            txtMail.ReadOnly= true;
            txtPhone.ReadOnly= true;
            txtDoB.ReadOnly= true;
            txtGender.ReadOnly= true;

            btnEdit.Visible= false;
            btDone.Visible = false;
        }

        public void txtEnable()
        {
            txtID.Enabled = true;
            txtIDC.Enabled = true;
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

        private void lbStudentName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
