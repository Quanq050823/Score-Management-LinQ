using PrjTest.BL;
using System;
using System.CodeDom;
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
    public partial class fSessions : Form
    {
        BLSessions blSessions = new BLSessions();
        bool add = false;
        public fSessions()
        {
            InitializeComponent();
            SetCbScholastic();
            dgvset();
            SetTextbox(true);
        }

        public void dgvset()
        {
            dgvStudent.DataSource = blSessions.GetSessions(Convert.ToInt32(cbScholastic.SelectedItem), Convert.ToInt32(cbSemester.SelectedItem));
            dgvStudent.AutoResizeColumns();

            dgvStudent.ReadOnly = true;
            btnSave.Enabled = false;
        }
               

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
            //If add = true -> go for add account else update existed account
            if (add) 
            {
                if (blSessions.InsertSession(txtID.Text, txtName.Text, Convert.ToInt32(txtMail.Text), Convert.ToInt32(cbScholastic.SelectedItem), Convert.ToInt32(cbSemester.SelectedItem)))
                {
                    MessageBox.Show("Inserted succeed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Insert Failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                if (blSessions.UpdateSessions(txtID.Text, txtName.Text, Convert.ToInt32(txtMail.Text), Convert.ToInt32(cbScholastic.SelectedItem), Convert.ToInt32(cbSemester.SelectedItem)))
                {
                    MessageBox.Show("Updated succeed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Updated Failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            btnReload.PerformClick();            
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //If btnSave is not enable -> Enable save and allow edit, else disable save and exit edited
            if (btnSave.Enabled == false)
            {
                btnSave.Enabled = true;
                btnEdit.Image = Properties.Resources.cancel;
                btnEdit.HoverState.Image = Properties.Resources.cancel2;

                btnReload.Enabled = false;
                btnAdd.Enabled = false;

                SetTextbox(false);
                if (add) txtID.ReadOnly = false;
            }
            else
            {
                btnSave.Enabled = false;
                btnEdit.Image = Properties.Resources.edit;
                btnEdit.HoverState.Image = Properties.Resources.edit2;

                btnReload.Enabled = true;
                btnAdd.Enabled = true;
                add = false;

                SetTextbox(true);
                
            }
            
        }

        //Assign value to textbox when clicked on dgv
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvStudent.CurrentCell.RowIndex;
            
            this.txtID.Text = dgvStudent.Rows[r].Cells[0].Value.ToString();
            this.txtName.Text = dgvStudent.Rows[r].Cells[1].Value.ToString();
            this.txtMail.Text = dgvStudent.Rows[r].Cells[4].Value.ToString();

        }


        //s is the state of the information below dgv, if edit button is clicked then s = false to be edited else it is true
        private void SetTextbox(bool s)
        {
            txtID.ReadOnly = true;
            txtMail.ReadOnly= s; //These can't be changed 
            txtName.ReadOnly = s;
            
        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvset();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = true;
            btnEdit.PerformClick();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                if (blSessions.DeleteSession(txtID.Text, Convert.ToInt32(cbScholastic.SelectedItem), Convert.ToInt32(cbSemester.SelectedItem))) 
                    MessageBox.Show("Deleted succeed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else MessageBox.Show("Deleted Failed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
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

        private void fSessions_Load(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ReportViewerForm rp = new ReportViewerForm(4);
            rp.Show();
        }

    }
}
