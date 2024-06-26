﻿using PrjTest.BL;
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
    public partial class fEditScoreAdmin : Form
    {
        int scholastic = Admin_form.fStudentScore.Scholastic1;
        int semester = Admin_form.fStudentScore.Semester1;
        string session = Admin_form.fStudentScore.Session1;
        BLTeacherScore dbTeaScore = new BLTeacherScore();

        public fEditScoreAdmin()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            btnSave.Enabled = false;
            dgvEditScore.DataSource = dbTeaScore.GetScoreAdmin(scholastic, semester, session);
            dgvEditScore.AutoResizeColumns();
            AdjustColumnOrder();
            dgvEditScore_CellClick(null, null);
        }

        private void AdjustColumnOrder()
        {
            //Set column order
            //Set column order'
            dgvEditScore.Columns["Student_ID"].DisplayIndex = 0;
            dgvEditScore.Columns["Student_Name"].DisplayIndex = 1;
            dgvEditScore.Columns["Process_score"].DisplayIndex = 2;
            dgvEditScore.Columns["Final_exam"].DisplayIndex = 3;
            dgvEditScore.Columns["Average_score"].DisplayIndex = 4;

            dgvEditScore.Columns["Sessionss_Name"].Visible = false;
            dgvEditScore.Columns["Sessionss_ID"].Visible = false;

            dgvEditScore.Columns["Teacher_ID"].Visible = false;
            dgvEditScore.Columns["Course_ID"].Visible = false;

            dgvEditScore.Columns["Scholastic"].Visible = false;
            dgvEditScore.Columns["Semester"].Visible = false;
            dgvEditScore.Columns["Numberofcredits"].Visible = false;

        }

        private void dgvEditScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e == null) dgvEditScore.Rows[0].Selected = true;

            int r = dgvEditScore.CurrentCell.RowIndex;
            this.txtID.Text = dgvEditScore.Rows[r].Cells[0].Value.ToString();
            this.txtName.Text = dgvEditScore.Rows[r].Cells[1].Value.ToString();
            this.txtProScore.Text = dgvEditScore.Rows[r].Cells[9].Value.ToString();
            this.txtFiScore.Text = dgvEditScore.Rows[r].Cells[11].Value.ToString();
            this.txtAveScore.Text = dgvEditScore.Rows[r].Cells[10].Value.ToString();
            //this.sessionssID = 

            this.txtName.ReadOnly = true;
            this.txtID.ReadOnly = true;
            this.txtProScore.ReadOnly = true;
            this.txtFiScore.ReadOnly = true;
            this.txtAveScore.ReadOnly = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnSave.Enabled == false)
            {
                this.txtProScore.ReadOnly = false;
                this.txtFiScore.ReadOnly = false;

                btnSave.Enabled = true;
                btnUpdate.Image = Properties.Resources.cancel;
                btnUpdate.HoverState.Image = Properties.Resources.cancel2;

                btnReload.Enabled = false;
            }
            else
            {
                this.txtProScore.ReadOnly = true;
                this.txtFiScore.ReadOnly = true;

                btnSave.Enabled = false;
                btnUpdate.Image = Properties.Resources.edit;
                btnUpdate.HoverState.Image = Properties.Resources.edit2;

                btnReload.Enabled = true;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BLTeacherScore tso = new BLTeacherScore();
            bool f =tso.UpdateScore(this.txtID.Text, this.session, this.semester.ToString(), this.scholastic.ToString(), this.txtProScore.Text, this.txtFiScore.Text);
            btnUpdate.PerformClick();
            btnReload.PerformClick();
            if (f) MessageBox.Show("Updated!!!");
            else MessageBox.Show("Updated Failed!!!");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void fEditScore_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
