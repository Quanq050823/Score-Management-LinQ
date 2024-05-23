 
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
    public partial class fTeacherTeached : Form
    {
        Teacher_Object hooman = new Teacher_Object();
        BLTeacher teacher = new BLTeacher();
        BLTeacherScore enrolled_db = new BLTeacherScore();
        DataTable dtb = null;

        int ID = fLogin.RootID;

        public fTeacherTeached()
        {
            InitializeComponent();
        }

        //Setup form
        private void fTeacherTeached_Load(object sender, EventArgs e)
        {
            //ID = fLogin.RootStudentID;
            hooman = teacher.GetInfo(ID);

            lbName.Text += hooman.Teacher_Name;
            lbTeacher_ID.Text += hooman.Teacher_ID.ToString();

            //Set value of 2 combo box
            SetCbScholastic();
            cbScholastic.SelectedIndex = 0;
            cbSemester.SelectedIndex = 0;

            DgvReset();  
        }

        private void DgvReset()
        {
            dgvStudentEnrolled.DataSource = enrolled_db.GetCourse_dgv(ID, Convert.ToInt32(cbScholastic.Text), Convert.ToInt32(cbSemester.Text));
            dgvStudentEnrolled.AutoResizeColumns();
            AdjustColumnOrder();

            dgvStudentEnrolled.ReadOnly = true;
        }

        private void AdjustColumnOrder()
        {
            dgvStudentEnrolled.Columns["Teacher_ID"].Visible = false;
            dgvStudentEnrolled.Columns["Scholastic"].Visible = false;
            dgvStudentEnrolled.Columns["Semester"].Visible = false;

            dgvStudentEnrolled.Columns["Sessionss_ID"].DisplayIndex = 0;
            dgvStudentEnrolled.Columns["Sessionss_name"].DisplayIndex = 0;
            dgvStudentEnrolled.AutoResizeColumnHeadersHeight();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SetCbScholastic()
        {
            //Set Scholastic
            int admission = 21;
            DateTime now = DateTime.Now;
            int year_now = now.Year % 100;

            for (int i = 0; i < year_now - admission; i++)
            {
                cbScholastic.Items.Add(((admission + i) * 100 + admission + i + 1).ToString());
            }

            cbScholastic.SelectedIndex = 0;
            cbSemester.SelectedIndex = 0;
        }

        string slt;
        private void changeslt()
        {
            string strslt = cbScholastic.Text;
            slt = "20" + strslt.Substring(0, 2) + " - " + "20" + strslt.Substring(2);
        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            DgvReset();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ReportViewerForm rp = new ReportViewerForm(8);
            rp.TeacherId = hooman.Teacher_ID;
            rp.Scholastic1 = cbScholastic.SelectedItem.ToString();
            rp.Semester1 = cbSemester.SelectedItem.ToString();
            rp.Show();
        }

        private void lbScholastic_Click(object sender, EventArgs e)
        {

        }

        private void cbScholastic_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnReload.PerformClick();
        }

        private void lbSemester_Click(object sender, EventArgs e)
        {

        }

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnReload.PerformClick();
        }
    }
}
