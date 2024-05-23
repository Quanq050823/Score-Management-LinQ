namespace PrjTest
{
    partial class ReportViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sessionssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMSProjectTestDataSet = new PrjTest.DBMSProjectTestDataSet();
            this.View_ScoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewEnrollListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Course_SessionssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewScoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseSessionssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherScoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMSProjectTestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ScoresTableAdapter = new PrjTest.DBMSProjectTestDataSetTableAdapters.View_ScoresTableAdapter();
            this.studentTableAdapter = new PrjTest.DBMSProjectTestDataSetTableAdapters.StudentTableAdapter();
            this.teacherTableAdapter = new PrjTest.DBMSProjectTestDataSetTableAdapters.TeacherTableAdapter();
            this.sessionssTableAdapter = new PrjTest.DBMSProjectTestDataSetTableAdapters.SessionssTableAdapter();
            this.view_EnrollListTableAdapter = new PrjTest.DBMSProjectTestDataSetTableAdapters.View_EnrollListTableAdapter();
            this.teacher_ScoresTableAdapter = new PrjTest.DBMSProjectTestDataSetTableAdapters.Teacher_ScoresTableAdapter();
            this.course_SessionssTableAdapter = new PrjTest.DBMSProjectTestDataSetTableAdapters.Course_SessionssTableAdapter();
            this.ScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_EnrollListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Teacher_ScoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionssBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMSProjectTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_ScoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnrollListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Course_SessionssBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewScoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSessionssBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherScoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMSProjectTestDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_EnrollListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_ScoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1451, 783);
            this.splitContainer1.SplitterDistance = 105;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Cooper", 25.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(455, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "GENERATE REPORT";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSScores";
            reportDataSource1.Value = this.View_ScoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrjTest.Report.RWScores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1451, 674);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // sessionssBindingSource
            // 
            this.sessionssBindingSource.DataMember = "Sessionss";
            this.sessionssBindingSource.DataSource = this.dBMSProjectTestDataSet;
            // 
            // dBMSProjectTestDataSet
            // 
            this.dBMSProjectTestDataSet.DataSetName = "DBMSProjectTestDataSet";
            this.dBMSProjectTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_ScoresBindingSource
            // 
            this.View_ScoresBindingSource.DataMember = "View_Scores";
            this.View_ScoresBindingSource.DataSource = this.dBMSProjectTestDataSet;
            // 
            // viewEnrollListBindingSource
            // 
            this.viewEnrollListBindingSource.DataMember = "View_EnrollList";
            this.viewEnrollListBindingSource.DataSource = this.dBMSProjectTestDataSet;
            // 
            // Course_SessionssBindingSource
            // 
            this.Course_SessionssBindingSource.DataMember = "Course_Sessionss";
            this.Course_SessionssBindingSource.DataSource = this.dBMSProjectTestDataSet;
            // 
            // viewScoresBindingSource
            // 
            this.viewScoresBindingSource.DataMember = "View_Scores";
            this.viewScoresBindingSource.DataSource = this.dBMSProjectTestDataSet;
            // 
            // courseSessionssBindingSource
            // 
            this.courseSessionssBindingSource.DataMember = "Course_Sessionss";
            this.courseSessionssBindingSource.DataSource = this.dBMSProjectTestDataSet;
            // 
            // teacherScoresBindingSource
            // 
            this.teacherScoresBindingSource.DataMember = "Teacher_Scores";
            this.teacherScoresBindingSource.DataSource = this.dBMSProjectTestDataSet;
            // 
            // dBMSProjectTestDataSetBindingSource
            // 
            this.dBMSProjectTestDataSetBindingSource.DataSource = this.dBMSProjectTestDataSet;
            this.dBMSProjectTestDataSetBindingSource.Position = 0;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.dBMSProjectTestDataSet;
            // 
            // TeacherBindingSource
            // 
            this.TeacherBindingSource.DataMember = "Teacher";
            this.TeacherBindingSource.DataSource = this.dBMSProjectTestDataSet;
            // 
            // view_ScoresTableAdapter
            // 
            this.view_ScoresTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // sessionssTableAdapter
            // 
            this.sessionssTableAdapter.ClearBeforeFill = true;
            // 
            // view_EnrollListTableAdapter
            // 
            this.view_EnrollListTableAdapter.ClearBeforeFill = true;
            // 
            // teacher_ScoresTableAdapter
            // 
            this.teacher_ScoresTableAdapter.ClearBeforeFill = true;
            // 
            // course_SessionssTableAdapter
            // 
            this.course_SessionssTableAdapter.ClearBeforeFill = true;
            // 
            // ScoreBindingSource
            // 
            this.ScoreBindingSource.DataMember = "Score";
            this.ScoreBindingSource.DataSource = this.dBMSProjectTestDataSet;
            // 
            // View_EnrollListBindingSource
            // 
            this.View_EnrollListBindingSource.DataMember = "View_EnrollList";
            this.View_EnrollListBindingSource.DataSource = this.dBMSProjectTestDataSet;
            // 
            // Teacher_ScoresBindingSource
            // 
            this.Teacher_ScoresBindingSource.DataMember = "Teacher_Scores";
            this.Teacher_ScoresBindingSource.DataSource = this.dBMSProjectTestDataSet;
            // 
            // ReportViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1451, 783);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ReportViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportViewerForm";
            this.Load += new System.EventHandler(this.ReportViewerForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sessionssBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMSProjectTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_ScoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnrollListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Course_SessionssBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewScoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSessionssBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherScoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMSProjectTestDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_EnrollListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_ScoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DBMSProjectTestDataSet dBMSProjectTestDataSet;
        private DBMSProjectTestDataSetTableAdapters.View_ScoresTableAdapter view_ScoresTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DBMSProjectTestDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource TeacherBindingSource;
        private DBMSProjectTestDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.BindingSource sessionssBindingSource;
        private DBMSProjectTestDataSetTableAdapters.SessionssTableAdapter sessionssTableAdapter;
        private System.Windows.Forms.BindingSource viewScoresBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dBMSProjectTestDataSetBindingSource;
        private System.Windows.Forms.BindingSource viewEnrollListBindingSource;
        private DBMSProjectTestDataSetTableAdapters.View_EnrollListTableAdapter view_EnrollListTableAdapter;
        private System.Windows.Forms.BindingSource teacherScoresBindingSource;
        private DBMSProjectTestDataSetTableAdapters.Teacher_ScoresTableAdapter teacher_ScoresTableAdapter;
        private System.Windows.Forms.BindingSource Course_SessionssBindingSource;
        private System.Windows.Forms.BindingSource courseSessionssBindingSource;
        private DBMSProjectTestDataSetTableAdapters.Course_SessionssTableAdapter course_SessionssTableAdapter;
        private System.Windows.Forms.BindingSource ScoreBindingSource;
        private System.Windows.Forms.BindingSource View_EnrollListBindingSource;
        private System.Windows.Forms.BindingSource View_ScoresBindingSource;
        private System.Windows.Forms.BindingSource Teacher_ScoresBindingSource;
    }
}