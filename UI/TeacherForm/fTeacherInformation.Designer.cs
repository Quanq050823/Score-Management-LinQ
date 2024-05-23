namespace PrjTest.StudentForm
{
    partial class fTeacherInformation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbWellcome = new System.Windows.Forms.Label();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.lbDoB = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbIDC = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDoB = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtIDC = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDone = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbWellcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 109);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbWellcome
            // 
            this.lbWellcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbWellcome.AutoSize = true;
            this.lbWellcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWellcome.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWellcome.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbWellcome.Location = new System.Drawing.Point(298, 38);
            this.lbWellcome.Name = "lbWellcome";
            this.lbWellcome.Size = new System.Drawing.Size(406, 40);
            this.lbWellcome.TabIndex = 2;
            this.lbWellcome.Text = "TEACHER INFORMATION";
            this.lbWellcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStudentID
            // 
            this.lbStudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentID.Location = new System.Drawing.Point(55, 43);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(126, 23);
            this.lbStudentID.TabIndex = 1;
            this.lbStudentID.Text = "Teacher ID: ";
            // 
            // lbStudentName
            // 
            this.lbStudentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentName.Location = new System.Drawing.Point(55, 114);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(88, 23);
            this.lbStudentName.TabIndex = 1;
            this.lbStudentName.Text = "Name:  ";
            this.lbStudentName.Click += new System.EventHandler(this.lbStudentName_Click);
            // 
            // lbDoB
            // 
            this.lbDoB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDoB.AutoSize = true;
            this.lbDoB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoB.Location = new System.Drawing.Point(55, 185);
            this.lbDoB.Name = "lbDoB";
            this.lbDoB.Size = new System.Drawing.Size(134, 23);
            this.lbDoB.TabIndex = 1;
            this.lbDoB.Text = "Day of birth: ";
            // 
            // lbGender
            // 
            this.lbGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(574, 109);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(96, 23);
            this.lbGender.TabIndex = 1;
            this.lbGender.Text = "Gender: ";
            // 
            // lbIDC
            // 
            this.lbIDC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbIDC.AutoSize = true;
            this.lbIDC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDC.Location = new System.Drawing.Point(539, 32);
            this.lbIDC.Name = "lbIDC";
            this.lbIDC.Size = new System.Drawing.Size(142, 23);
            this.lbIDC.TabIndex = 1;
            this.lbIDC.Text = "Teacher IDC: ";
            // 
            // lbMail
            // 
            this.lbMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(55, 272);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(85, 23);
            this.lbMail.TabIndex = 1;
            this.lbMail.Text = "Email:   ";
            // 
            // lbPhone
            // 
            this.lbPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(539, 180);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(165, 23);
            this.lbPhone.TabIndex = 1;
            this.lbPhone.Text = "Phone number: ";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(892, 384);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 37);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtID.Location = new System.Drawing.Point(199, 34);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(166, 32);
            this.txtID.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtName.Location = new System.Drawing.Point(199, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 32);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDoB
            // 
            this.txtDoB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDoB.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDoB.Location = new System.Drawing.Point(199, 182);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.Size = new System.Drawing.Size(166, 32);
            this.txtDoB.TabIndex = 3;
            // 
            // txtGender
            // 
            this.txtGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGender.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtGender.Location = new System.Drawing.Point(718, 100);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(166, 32);
            this.txtGender.TabIndex = 3;
            // 
            // txtIDC
            // 
            this.txtIDC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDC.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtIDC.Location = new System.Drawing.Point(718, 29);
            this.txtIDC.Name = "txtIDC";
            this.txtIDC.Size = new System.Drawing.Size(166, 32);
            this.txtIDC.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtMail.Location = new System.Drawing.Point(199, 263);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(310, 32);
            this.txtMail.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPhone.Location = new System.Drawing.Point(718, 171);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(166, 32);
            this.txtPhone.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.lbStudentID);
            this.panel2.Controls.Add(this.lbStudentName);
            this.panel2.Controls.Add(this.lbDoB);
            this.panel2.Controls.Add(this.txtMail);
            this.panel2.Controls.Add(this.lbGender);
            this.panel2.Controls.Add(this.txtIDC);
            this.panel2.Controls.Add(this.lbIDC);
            this.panel2.Controls.Add(this.txtGender);
            this.panel2.Controls.Add(this.txtDoB);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.lbMail);
            this.panel2.Controls.Add(this.btDone);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.lbPhone);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 433);
            this.panel2.TabIndex = 4;
            // 
            // btDone
            // 
            this.btDone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDone.Location = new System.Drawing.Point(783, 384);
            this.btDone.Name = "btDone";
            this.btDone.Size = new System.Drawing.Size(93, 37);
            this.btDone.TabIndex = 2;
            this.btDone.Text = "Done";
            this.btDone.UseVisualStyleBackColor = true;
            this.btDone.Click += new System.EventHandler(this.btDone_Click);
            // 
            // fTeacherInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fTeacherInformation";
            this.Text = "fStudentInformation";
            this.Load += new System.EventHandler(this.fTeacherInformation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbWellcome;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.Label lbDoB;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbIDC;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDoB;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtIDC;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btDone;
    }
}