 
using PrjTest.BL;
using PrjTest.TeacherForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using PrjTest.Hooman;

namespace PrjTest.StudentForm
{
    public partial class fTeacherScore : Form
    {
        Teacher_Object hooman = new Teacher_Object();
        BLTeacher dbTeacher = new BLTeacher();
        BLTeacherScore dbTeacherScore = new BLTeacherScore();

        DataTable dtb = null;

        int ID = fLogin.RootID;

        int nowScholastic, nowSemester;

        private static int Scholastict, Semestert;
        private static string Courset, Sessionsst;

        string slt;

        public static int Scholastict1 { get => Scholastict; set => Scholastict = value; }
        public static int Semestert1 { get => Semestert; set => Semestert = value; }
        public static string Courset1 { get => Courset; set => Courset = value; }
        public static string Sessionsst1 { get => Sessionsst; set => Sessionsst = value; }

        public fTeacherScore()
        {
            InitializeComponent();
        }

        //Setup form
        private void fTeacherScore_Load(object sender, EventArgs e)
        {
            //Get in4 from StudentID
            //ID = fLogin.RootStudentID;
            hooman = dbTeacher.GetInfo(ID);

            //Set in4 to box
            lbName.Text = "Teacher " + hooman.Teacher_Name;
            lbStudent_ID.Text = "Teacher ID: " + hooman.Teacher_ID.ToString();

            //Set value of 2 combo box
            SetScholastic_Semester();//Only sessionss in this Scholastic and semester can be edit
            SetCbScholastic();
            SetCbCourse();
            
            DgvReset();  
            

        }

        #region Setting up form
        //Setup the datagridview
        private void DgvReset()
        {
            string[] cb = new string[100];
            if (cbCourse.Items.Count != 0) cb = GetSession_Course_ID();
            dgvStudentScore.DataSource = dbTeacherScore.GetScore(ID, Convert.ToInt32(cbScholastic.SelectedItem), Convert.ToInt32(cbSemester.SelectedItem), cb[0], cb[1] );
            dgvStudentScore.AutoResizeColumns();
            AdjustColumnOrder();

            dgvStudentScore.ReadOnly = true;
        }

        //Setup thhe column order
        private void AdjustColumnOrder()
        {
            //Set column order
            dgvStudentScore.Columns["Sessionss_Name"].Visible = false;
            dgvStudentScore.Columns["Sessionss_ID"].Visible = false;

            dgvStudentScore.Columns["Teacher_ID"].Visible = false;
            dgvStudentScore.Columns["Course_ID"].Visible = false;

            dgvStudentScore.Columns["Scholastic"].Visible = false;
            dgvStudentScore.Columns["Semester"].Visible = false;
            dgvStudentScore.Columns["Numberofcredits"].Visible = false;

            dgvStudentScore.Columns["Student_ID"].DisplayIndex = 0;
            dgvStudentScore.Columns["Student_Name"].DisplayIndex = 1;
            dgvStudentScore.Columns["Process_score"].DisplayIndex = 2;
            dgvStudentScore.Columns["Final_exam"].DisplayIndex = 3;
            dgvStudentScore.Columns["Average_score"].DisplayIndex = 4;
        }


        //Set label
        private void SetScholastic_Semester()
        {
            DateTime now = DateTime.Now;

            if (now.Month <=5)
            {
                lbSemester.Text = "Semster: 2";
                nowSemester = 2;
                lbScholastic.Text = "Scholastic: " + (now.Year-1).ToString() + " - " + now.Year.ToString();
                nowScholastic = (now.Year - 1) % 100 * 100 + now.Year%100;
            }
            else
            {
                lbSemester.Text = "Semster: 1";
                nowSemester = 1;
                lbScholastic.Text = "Scholastic: " + now.Year.ToString() + " - " + (now.Year +1).ToString();
                nowScholastic = now.Year % 100 * 100 + (now.Year+1) % 100;
            }
            //MessageBox.Show(nowScholastic.ToString() + "\n" + nowSemester.ToString());
        }

        private void SetCbCourse()
        {
            //Set Course
            List<string> courseList = new List<string>();
            courseList = dbTeacherScore.GetCourse(ID, Convert.ToInt32(cbScholastic.SelectedItem), Convert.ToInt32(cbSemester.SelectedItem));
            cbCourse.Text = "";
            cbCourse.Items.Clear();
            foreach (string course in courseList)
            {
                cbCourse.Items.Add(course);
            }
            if (cbCourse.Items.Count != 0)  cbCourse.SelectedIndex = 0;
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
        #endregion

        #region Setting the control behaviour

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string[] cb = new string[100];
            if (cbCourse.Items.Count != 0) cb = GetSession_Course_ID();
            Scholastict1 = Convert.ToInt32(cbScholastic.Text);
            Semestert1 = Convert.ToInt32(cbSemester.Text);
            Sessionsst1 = cb[0];
            Courset1 = cb[1];

            fEditScore fes = new fEditScore();
            fes.Show();
        }

        private void cbScholastic_DropDownClosed(object sender, EventArgs e)
        {
            SetCbCourse();
        }

        private void cbSemester_DropDownClosed(object sender, EventArgs e)
        {
            SetCbCourse();
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            string[] words = cbCourse.Text.Split(' ');
            ReportViewerForm rp = new ReportViewerForm(7);
            rp.TeacherId = hooman.Teacher_ID;
            rp.Scholastic1 = cbScholastic.SelectedItem.ToString();
            rp.Semester1 = cbSemester.SelectedItem.ToString();
            rp.Courset1 = words[0].ToString();
            rp.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DgvReset();
        }



        #endregion

        //Split to get Sessionss ID and course ID from combobox
        private string[] GetSession_Course_ID()
        {
            string[] words = cbCourse.Text.Split(' ');
            return words;
        }

        private void changeslt()
        {
            string strslt = cbScholastic.Text;
            slt = "20" + strslt.Substring(0, 2) + " - " + "20" + strslt.Substring(2);
        }
    }
}
