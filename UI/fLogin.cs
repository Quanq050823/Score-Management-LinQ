using PrjTest.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjTest
{
    public partial class fLogin : Form
    {
        BLAccount blAcc = new BLAccount();

        //Acc type is Student or teacher
        int AccType = 1;

        //RootStudentID used to stored the input ID from all over the project
        public static int RootID { get => rootID; set => rootID = value; }
        public static int Password { get => password; set => password = value; }

        private static int rootID;

        private static int password;

        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            rbtStudent.Checked = true;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                switch (AccType)
                {
                    case 2:
                        {
                            if (blAcc.CheckAcc(Convert.ToInt32(txtUsername.Text), txtPassword.Text, AccType))
                            {
                                //dBMS.PROC_Create_AllLogin();
                                fTeacherAccount teacherAccount = new fTeacherAccount();
                                teacherAccount.Show();


                                RootID = Convert.ToInt32(txtUsername.Text);
                                password = Convert.ToInt32(txtPassword.Text);
                            }
                            else MessageBox.Show("Wrong username or password", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    case 1:
                        {
                            if (blAcc.CheckAcc(Convert.ToInt32(txtUsername.Text), txtPassword.Text, AccType))
                            {
                                //dBMS.PROC_Create_AllLogin();
                                fStudentAccount studentAccount = new fStudentAccount();
                                studentAccount.Show();

                                RootID = Convert.ToInt32(txtUsername.Text);
                                password = Convert.ToInt32(txtPassword.Text);
                            }
                            else MessageBox.Show("Wrong username or password", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    case 3:
                        {
                            //check if the username meet one of the requirements and so does the password
                            if (txtUsername.Text == "admin" || txtUsername.Text == "Admin" && txtPassword.Text == "admin")
                            {
                                //dBMS.PROC_Create_AllLogin();
                                fAdmin1 admin = new fAdmin1();
                                admin.Show();
                            }
                        }
                        break;
                }

            }
            catch (Exception ex) { MessageBox.Show("Username must be your ID", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }

        private void rbtTeacher_CheckedChanged(object sender, EventArgs e)
        {
            AccType = 2;
        }

        private void rbtStudent_CheckedChanged(object sender, EventArgs e)
        {
            AccType = 1;
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            AccType = 3;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login.PerformClick();
                txtUsername.Focus();
            }
            
        }


        //txtPassword current type show or not show password
        bool Showed = false;
        private void picShowPass_Click(object sender, EventArgs e)
        {
            if (Showed)
            {
                picShowPass.Image = Properties.Resources.Showed;
                txtPassword.PasswordChar = '•';
                Showed= false;
            }
            else 
            { 
                picShowPass.Image = Properties. Resources.NotShowed;
                txtPassword.PasswordChar = '\0';
                Showed = true;
            }  
        }

        private void guna2GradientPanel2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login.PerformClick();
            }
            
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
