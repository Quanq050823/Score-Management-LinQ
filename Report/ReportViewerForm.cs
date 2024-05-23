using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace PrjTest
{
    public partial class ReportViewerForm : Form
    {
        private int indx;
        public string Scholastic1 { get; set; }
        public string Session1 { get; set; }
        public string Semester1 { get; set; }
        public string Courset1 { get; set; }
        public decimal StudentId { get; set; }
        public decimal TeacherId { get; set; }
        public string AccumulatedScore { get; set; }
        public string AccumulatedCredit { get; set; }
        public string TotalNoCre { get; set; }
        public string AvgScore { get; set; }

        public int Indx { get => indx; set => indx = value; }

        public ReportViewerForm(int i)
        {
            indx = i;
            InitializeComponent();
        }
        private void ReportViewerForm_Load(object sender, EventArgs e)
        {

            switch (indx)
            {
                case 1:
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrjTest.Report.RWStudentin4.rdlc";
                        this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSStudent", studentBindingSource));
                        this.studentTableAdapter.Fill(this.dBMSProjectTestDataSet.Student);
                        this.reportViewer1.RefreshReport();
                    }
                    break;
                case 2:
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrjTest.Report.RWTeacher.rdlc";
                        this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSTeacher", TeacherBindingSource));
                        this.teacherTableAdapter.Fill(this.dBMSProjectTestDataSet.Teacher);
                        this.reportViewer1.RefreshReport();
                    }
                    break;
                case 3:
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrjTest.Report.RWScores.rdlc";
                        this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSSCores", viewScoresBindingSource));
                        this.view_ScoresTableAdapter.FillBy(this.dBMSProjectTestDataSet.View_Scores, Convert.ToDecimal(Scholastic1), Convert.ToDecimal(Semester1),Session1);
                        this.reportViewer1.RefreshReport();
                    }
                    break;
                case 4:
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrjTest.Report.RWSessions.rdlc";
                        this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSSessions", sessionssBindingSource));
                        this.sessionssTableAdapter.Fill(this.dBMSProjectTestDataSet.Sessionss);
                        this.reportViewer1.RefreshReport();
                    }
                    break;
                case 5:
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrjTest.Report.RWStudentScore.rdlc";
                        this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSStudentScore", viewScoresBindingSource));
                        this.view_ScoresTableAdapter.FillBy2(this.dBMSProjectTestDataSet.View_Scores, StudentId, Convert.ToDecimal(Scholastic1), Convert.ToDecimal(Semester1));
                        this.reportViewer1.RefreshReport();
                    }
                    break;
                case 6:
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrjTest.Report.RWStudentEnroll.rdlc";
                        this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSStudentEnroll", viewEnrollListBindingSource));
                        this.view_EnrollListTableAdapter.FillBy(this.dBMSProjectTestDataSet.View_EnrollList,StudentId, Convert.ToDecimal(Scholastic1), Convert.ToDecimal(Semester1));
                        this.reportViewer1.RefreshReport();
                    }
                    break;
                case 7:
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrjTest.Report.RWTeacherScores.rdlc";
                        this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSTeacherScores", teacherScoresBindingSource));
                        this.teacher_ScoresTableAdapter.FillBy(this.dBMSProjectTestDataSet.Teacher_Scores, TeacherId, Convert.ToDecimal(Scholastic1), Convert.ToDecimal(Semester1), Courset1);
                        this.reportViewer1.RefreshReport();
                    }
                    break;
                case 8:
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrjTest.Report.RWTeacherCourses.rdlc";
                        this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSTeacherCourse", courseSessionssBindingSource));
                        dBMSProjectTestDataSet.EnforceConstraints = false;
                        this.course_SessionssTableAdapter.FillBy1(this.dBMSProjectTestDataSet.Course_Sessionss,TeacherId, Convert.ToDecimal(Scholastic1), Convert.ToDecimal(Semester1));
                        this.reportViewer1.RefreshReport();
                    }
                    break;
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
