using Guna.UI2.WinForms;
using PrjTest.BL;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjTest.Admin_form
{
    public partial class fStudentInfo : Form
    {
        BLStudent blStudent = new BLStudent();
        bool add = false;
        public fStudentInfo()
        {
            InitializeComponent();
            dgvset();
            SetTextbox(true);
        }

        public void dgvset()
        {
            dgvStudent.DataSource = blStudent.GetStudents();
            dgvStudent.AutoResizeColumns();
            dgvStudent.ReadOnly = true;
            btnSave.Enabled = false;
        }
               

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
            
            bool tmpGender;
            if (rdMale.Checked) { tmpGender = true; }
            else { tmpGender = false; }

            //If add = true -> go for add account else update existed account
            if (add)
            {
                if (blStudent.InsertStudent(txtID.Text, txtIDC.Text, txtName.Text, txtPhone.Text, Convert.ToDateTime(dtDob.Value), tmpGender, txtAdmission.Text, txtMajor.Text))
                {
                    MessageBox.Show("Inserted succeed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                if (blStudent.UpdateStudent(txtID.Text, txtIDC.Text, txtName.Text, txtPhone.Text, Convert.ToDateTime(dtDob.Value),
                            tmpGender, txtAdmission.Text, txtMajor.Text))
                {
                    MessageBox.Show("Updated succeed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
                        
            btnEdit.PerformClick();
            btnReload.PerformClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //If btnSave is not enable -> Enable save and allow edit, else disable save and exit edited
            if (btnSave.Enabled == false)
            {
                btnSave.Enabled = true;
                //btnEdit.Text = "Exit";
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
                //btnEdit.Text = "Edit";

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
            this.dtDob.Value = DateTime.Parse(dgvStudent.Rows[r].Cells[2].Value.ToString());
            dtDob.CustomFormat = "dd MMM yyyy";
            this.txtMail.Text = dgvStudent.Rows[r].Cells[3].Value.ToString();

            try
            {
                this.txtPhone.Text = dgvStudent.Rows[r].Cells[4].Value.ToString();
            }
            catch(Exception ex) { txtPhone.Text = ""; }
            
            if (Convert.ToBoolean(dgvStudent.Rows[r].Cells[5].Value.ToString()))
            {
                rdMale.Enabled= true;
                rdMale.Checked = true;
                rdFemale.Enabled = false;
            }
            else
            {
                rdFemale.Enabled= true;
                rdFemale.Checked = true;
                rdMale.Enabled = false;
            }
            this.txtIDC.Text = dgvStudent.Rows[r].Cells[6].Value.ToString();
            this.txtAdmission.Text = dgvStudent.Rows[r].Cells[7].Value.ToString();
            this.txtMajor.Text = dgvStudent.Rows[r].Cells[8].Value.ToString();

        }


        //s is the state of the information below dgv, if edit button is clicked then s = false to be edited else it is true
        private void SetTextbox(bool s)
        {
            txtID.ReadOnly = true;txtMail.ReadOnly= true; //These can't be changed 
            txtName.ReadOnly = s;
            txtPhone.ReadOnly = s;
            txtAdmission.ReadOnly = s;
            txtMajor.ReadOnly = s;
            dtDob.Enabled= s;
            txtIDC.ReadOnly= s;
            
            if (!s)
            {
                rdFemale.Enabled= true;
                rdMale.Enabled = true;
            }
            dtDob.Enabled= !s;
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

        private void fStudentInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                if (blStudent.DeleteStudet(txtID.Text)) MessageBox.Show("Deleted succeed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else MessageBox.Show("Deleted Failed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            btnReload.PerformClick();
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            if (sender == btnAdd) { guna2HtmlToolTip1.Show("Add student", btnAdd); }
            else if (sender == btnDelete) { guna2HtmlToolTip1.Show("Kick student", btnDelete); }
            else if (sender == btnEdit) 
            { 
                if (btnSave.Enabled == false) guna2HtmlToolTip1.Show("Edit student", btnEdit); 
                else guna2HtmlToolTip1.Show("Cancel edit", btnEdit);

            }
            else if (sender == btnSave) { guna2HtmlToolTip1.Show("Save changed", btnSave); }
            else { guna2HtmlToolTip1.Show("Reload", btnReload); }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ReportViewerForm rp = new ReportViewerForm(1);
            rp.Show();
        }
    }
}
