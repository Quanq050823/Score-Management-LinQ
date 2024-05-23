 
using PrjTest.BL;
using PrjTest.StudentForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjTest.Admin_form
{
    public partial class fStudentScore : Form
    {
        BLTeacherScore dbTeaScore = new BLTeacherScore();
        DataTable dt = null;
        string slt;
        private static int scholastic1, semester1;
        private static string session1;

        public static int Scholastic1 { get => scholastic1; set => scholastic1 = value; }
        public static string Session1 { get => session1; set => session1 = value; }
        public static int Semester1 { get => semester1; set => semester1 = value; }

        public fStudentScore()
        {
            InitializeComponent();
        }

        private void dgvSetup()
        {
            dgvStudentScore.DataSource = dbTeaScore.GetScoreAdmin(Convert.ToInt32(cbScholastic.SelectedItem), Convert.ToInt32(cbSemester.SelectedItem), cbSession.Text);
            dgvStudentScore.AutoResizeColumns();
            AdjustColumnOrder();
            dgvStudentScore.ReadOnly = true;
        }

        private void fStudentScore_Load(object sender, EventArgs e)
        { 
            SetupCbScholastic();
            SetupCbSession();
            dgvSetup();
        }

        private void AdjustColumnOrder()
        {

            dgvStudentScore.Columns["Sessionss_Name"].Visible = false;
            dgvStudentScore.Columns["Sessionss_ID"].Visible = false;

            dgvStudentScore.Columns["Teacher_ID"].Visible = false;
            dgvStudentScore.Columns["Course_ID"].Visible = false;

            dgvStudentScore.Columns["Scholastic"].Visible = false;
            dgvStudentScore.Columns["Semester"].Visible = false;
            dgvStudentScore.Columns["Numberofcredits"].Visible = false;
            //dgvStudentScore.Columns["Sessionss_Name"].Visible = true;

            dgvStudentScore.Columns["Student_ID"].DisplayIndex = 0;
            dgvStudentScore.Columns["Student_Name"].DisplayIndex = 1;
            dgvStudentScore.Columns["Process_score"].DisplayIndex = 2;
            dgvStudentScore.Columns["Final_exam"].DisplayIndex = 3;
            dgvStudentScore.Columns["Average_score"].DisplayIndex = 4;
        }

        private void SetupCbScholastic()
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

        private void SetupCbSession()
        {
            //Set session
            List<string> sessionList = new List<string>();
            sessionList = dbTeaScore.GetSession(Convert.ToInt32(cbScholastic.SelectedItem), Convert.ToInt32(cbSemester.SelectedItem));
            cbSession.Text = "";
            cbSession.Items.Clear();
            foreach (string session in sessionList)
            {
                cbSession.Items.Add(session);
            }
            if (cbSession.Items.Count != 0) cbSession.SelectedIndex = 0;
        }

        private void changeslt()
        {
            string strslt = cbScholastic.Text;
            slt = "20" + strslt.Substring(0, 2) + " - " + "20" + strslt.Substring(2);
        }

        private void cbScholastic_DropDownClosed(object sender, EventArgs e)
        {
            SetupCbSession();
        }

        private void cbSemester_DropDownClosed(object sender, EventArgs e)
        {
            SetupCbSession();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvSetup();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ReportViewerForm rp = new ReportViewerForm(3);
            rp.Scholastic1 = cbScholastic.SelectedItem.ToString();
            rp.Semester1 = cbSemester.SelectedItem.ToString();
            rp.Session1 = cbSession.SelectedItem.ToString();
            rp.Show();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            Scholastic1 = Convert.ToInt32(cbScholastic.Text);
            Semester1 = Convert.ToInt32(cbSemester.Text);
            Session1 = cbSession.Text;

            Admin_form.fEditScoreAdmin es = new Admin_form.fEditScoreAdmin();
            es.Show();
        }
    }
}
