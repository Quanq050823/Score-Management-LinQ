 
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
    public partial class fStudentScore : Form
    {

        Student_Object hooman = new Student_Object();
        BLStudent student = new BLStudent();
        BLScore scoredb = new BLScore();
        DataTable dtb = null;

        int ID;
        string slt, ncd, savg;
        public fStudentScore()
        {
            InitializeComponent();
        }

        //Setup form
        private void fStudentScore_Load(object sender, EventArgs e)
        {
            //Get in4 from StudentID
            ID = fLogin.RootID;
            hooman = student.GetInfo(ID);

            //Set in4 to box
            lbStudent_ID.Text = "Student ID: "+ hooman.Student_ID.ToString();
            lbAccCredit.Text = "Accumulated Credits: " + scoredb.GetAccumulatedCredits(ID).ToString();
            lbAccScore.Text = "Accumulated average score: " + scoredb.GetAccumulatedAvg(ID).ToString();

            //Set value of 2 combo box
            SetCbScholastic();
            cbScholastic.SelectedIndex = 0;
            cbSemester.SelectedIndex = 0;

            DgvReset();  
        }

        //Setup the datagridview
        private void DgvReset()
        {
            dgvStudentScore.DataSource = scoredb.GetScore(ID, Convert.ToInt32(cbScholastic.Text), Convert.ToInt32(cbSemester.Text));
            dgvStudentScore.AutoResizeColumns();
            AdjustColumnOrder();

            Set_NoC_Avg();
            dgvStudentScore.ReadOnly = true;
        }

        //Setup thhe column order
        private void AdjustColumnOrder()
        {
            //Set column order
            dgvStudentScore.Columns["Student_ID1"].Visible = false;
            dgvStudentScore.Columns["Session_ID1"].DisplayIndex = 0;
            dgvStudentScore.Columns["Session_Name1"].DisplayIndex = 1;
            dgvStudentScore.Columns["NoCredit1"].DisplayIndex = 2;
            dgvStudentScore.Columns["Process_Score1"].DisplayIndex = 3;
            dgvStudentScore.Columns["Final_Score1"].DisplayIndex = 4;
            dgvStudentScore.Columns["Avg_Score1"].DisplayIndex = 5;

            dgvStudentScore.Columns["Semester1"].Visible = false;
            dgvStudentScore.Columns["Scholastic1"].Visible = false;
            dgvStudentScore.Columns["Status"].DisplayIndex = 7;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Set combo box index
        private void SetCbScholastic()
        {
            int admission = Convert.ToInt32(hooman.Admission);
            DateTime now = DateTime.Now;
            int year_now = now.Year % 100;
            
            for (int i=0; i<year_now - admission; i++) 
            {
                cbScholastic.Items.Add( ((admission+i)*100+admission+i+1) .ToString());
            }

        }

        public void Set_NoC_Avg()
        {
            string[] getValue= new string[] {"",""};
            getValue = scoredb.GetAvg_NoC(ID, Convert.ToInt32(cbScholastic.Text), Convert.ToInt32(cbSemester.Text));
            lbNoCredit.Text = "Number of credits: " + getValue[0];
            lbAvg.Text = "Averange score of semester: " + getValue[1];
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DgvReset();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ReportViewerForm rp = new ReportViewerForm(5);
            rp.StudentId = hooman.Student_ID;
            rp.Scholastic1 = cbScholastic.SelectedItem.ToString();
            rp.Semester1 = cbSemester.SelectedItem.ToString();
            //rp.AccumulatedScore = lbAccScore.Text;
            //rp.AccumulatedCredit = lbAccCredit.Text;
            //rp.TotalNoCre = lbNoCredit.Text;
            //rp.AvgScore = lbAvg.Text;
            rp.Show();
        }


    }
}
