using Guna.UI2.WinForms;
using PrjTest.Admin_form;
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

namespace PrjTest
{
    public partial class fAdmin1 : Form
    {
        
        public fAdmin1()
        {
            InitializeComponent();
        }

        private void fAdmin1_Load(object sender, EventArgs e)
        {
            imgSlide.Visible = false;
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) { activeForm.Close(); }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            plform.Controls.Add(childForm);
            plform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void moveImageBox(object sender)
        {
            imgSlide.Visible = true;
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 118, b.Location.Y - 28);
            imgSlide.SendToBack();
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
            OpenChildForm(new fStudentInfo());
        }

        private void btnTeacherInfo_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
            OpenChildForm(new fTeachherInfo());
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
            OpenChildForm(new Admin_form.fStudentScore());
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            moveImageBox(sender);
            OpenChildForm(new fSessions());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
