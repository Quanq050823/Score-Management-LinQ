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
    public partial class fTeachherInfo : Form
    {
        BLTeacher blTeacher = new BLTeacher();
        bool add = false;
        public fTeachherInfo()
        {
            InitializeComponent();
        }
        private void fTeacherInfo_Load(object sender, EventArgs e)
        {

            dgvset();
            SetTextbox(true);
        }

        public void dgvset()
        {            
            dgvStudent.DataSource = blTeacher.GetTeachers();
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
                if (blTeacher.InsertTeacher(txtID.Text, txtIDC.Text, txtName.Text, txtPhone.Text, Convert.ToDateTime(dtDob.Value), tmpGender))
                {
                    MessageBox.Show("Inserted succeed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                if (blTeacher.UpdateTeacher(txtID.Text, txtIDC.Text, txtName.Text, txtPhone.Text, Convert.ToDateTime(dtDob.Value),
                            tmpGender, true))
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

        }


        //s is the state of the information below dgv, if edit button is clicked then s = false to be edited else it is true
        private void SetTextbox(bool s)
        {
            txtID.ReadOnly = true;txtMail.ReadOnly= true; //These can't be changed 
            txtName.ReadOnly = s;
            txtPhone.ReadOnly = s;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                if (blTeacher.DeleteTeacher(txtID.Text)) MessageBox.Show("Deleted succeed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else MessageBox.Show("Deleted Failed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            btnReload.PerformClick();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ReportViewerForm rp = new ReportViewerForm(2);
            rp.Show();
        }
    }
}
