 
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
    public partial class fStudentEnrolled : Form
    {
        Student_Object hooman = new Student_Object();
        BLStudent student = new BLStudent();
        BLEnrolled enrolled_db = new BLEnrolled();
        DataTable dtb = null;


        int ID;
        public fStudentEnrolled()
        {
            InitializeComponent();
        }

        //Setup form
        private void fStudentEnrolled_Load(object sender, EventArgs e)
        {
            ID = fLogin.RootID;
            hooman = student.GetInfo(ID);

            lbName.Text = hooman.Student_Name;
            lbStudent_ID.Text = hooman.Student_ID.ToString();

            //Set value of 2 combo box
            SetCbScholastic();
            cbScholastic.SelectedIndex = 0;
            cbSemester.SelectedIndex = 0;

            DgvReset();  
        }

        private void DgvReset()
        {
            dgvStudentEnrolled.DataSource = enrolled_db.GetEnrolled(ID, Convert.ToInt32(cbScholastic.Text), Convert.ToInt32(cbSemester.Text));
            dgvStudentEnrolled.AutoResizeColumns();
            AdjustColumnOrder();

            lbNoC.Text = "Number of credits: " + (enrolled_db.GetNoC(ID, Convert.ToInt32(cbScholastic.Text), Convert.ToInt32(cbSemester.Text))).ToString();
            dgvStudentEnrolled.ReadOnly = true;
        }

        private void AdjustColumnOrder()
        {
            //Set column order
            dgvStudentEnrolled.Columns["Student_ID"].Visible = false;
            dgvStudentEnrolled.Columns["Session_Name"].DisplayIndex = 0;
            dgvStudentEnrolled.Columns["Session"].DisplayIndex = 1;
            dgvStudentEnrolled.Columns["NoCredit"].DisplayIndex = 2;
            dgvStudentEnrolled.Columns["Scholastic"].Visible = false;
            dgvStudentEnrolled.Columns["Semester"].Visible = false;
        }

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

        string slt, ncd;
        private void setup()
        {
            string strslt = cbScholastic.Text;
            slt = "20" + strslt.Substring(0, 2) + " - " + "20" + strslt.Substring(2);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ReportViewerForm rp = new ReportViewerForm(6);
            rp.StudentId = hooman.Student_ID;
            rp.Scholastic1 = cbScholastic.SelectedItem.ToString();
            rp.Semester1 = cbSemester.SelectedItem.ToString();
            rp.Show();
        }

        private void lbStudent_ID_Click(object sender, EventArgs e)
        {

        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            DgvReset();
        }

    }
}
