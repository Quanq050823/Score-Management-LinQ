namespace PrjTest.StudentForm
{
    partial class fTeacherScore
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
            this.lbScholastic = new System.Windows.Forms.Label();
            this.lbSemester = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExport = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.cbScholastic = new System.Windows.Forms.ComboBox();
            this.btnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnReload = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbStudent_ID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.dgvStudentScore = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentScore)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbWellcome);
            this.panel1.Controls.Add(this.lbScholastic);
            this.panel1.Controls.Add(this.lbSemester);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 156);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbWellcome
            // 
            this.lbWellcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbWellcome.AutoSize = true;
            this.lbWellcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWellcome.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWellcome.ForeColor = System.Drawing.Color.Teal;
            this.lbWellcome.Location = new System.Drawing.Point(416, 25);
            this.lbWellcome.Name = "lbWellcome";
            this.lbWellcome.Size = new System.Drawing.Size(274, 29);
            this.lbWellcome.TabIndex = 2;
            this.lbWellcome.Text = "SCORE MANAGEMENT";
            this.lbWellcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbScholastic
            // 
            this.lbScholastic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbScholastic.AutoSize = true;
            this.lbScholastic.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScholastic.ForeColor = System.Drawing.Color.Teal;
            this.lbScholastic.Location = new System.Drawing.Point(425, 65);
            this.lbScholastic.Name = "lbScholastic";
            this.lbScholastic.Size = new System.Drawing.Size(120, 26);
            this.lbScholastic.TabIndex = 4;
            this.lbScholastic.Text = "Scholastic";
            // 
            // lbSemester
            // 
            this.lbSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSemester.AutoSize = true;
            this.lbSemester.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSemester.ForeColor = System.Drawing.Color.Teal;
            this.lbSemester.Location = new System.Drawing.Point(484, 102);
            this.lbSemester.Name = "lbSemester";
            this.lbSemester.Size = new System.Drawing.Size(99, 23);
            this.lbSemester.TabIndex = 4;
            this.lbSemester.Text = "Semester";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.lbStudent_ID);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.dgvStudentScore);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 523);
            this.panel2.TabIndex = 4;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExport.BorderRadius = 10;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExport.FillColor = System.Drawing.Color.Transparent;
            this.btnExport.FillColor2 = System.Drawing.Color.Transparent;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnExport.HoverState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnExport.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnExport.HoverState.Image = global::PrjTest.Properties.Resources.dowload2;
            this.btnExport.Image = global::PrjTest.Properties.Resources.dowload;
            this.btnExport.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExport.Location = new System.Drawing.Point(995, 433);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(45, 45);
            this.btnExport.TabIndex = 44;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbCourse);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cbSemester);
            this.panel3.Controls.Add(this.cbScholastic);
            this.panel3.Location = new System.Drawing.Point(623, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 142);
            this.panel3.TabIndex = 43;
            // 
            // cbCourse
            // 
            this.cbCourse.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.cbCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCourse.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(163, 100);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(248, 29);
            this.cbCourse.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(9, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select course:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Semester:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(9, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select Scholastic:";
            // 
            // cbSemester
            // 
            this.cbSemester.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.cbSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSemester.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbSemester.Location = new System.Drawing.Point(209, 54);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(202, 29);
            this.cbSemester.TabIndex = 7;
            this.cbSemester.DropDownClosed += new System.EventHandler(this.cbSemester_DropDownClosed);
            // 
            // cbScholastic
            // 
            this.cbScholastic.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.cbScholastic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbScholastic.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbScholastic.FormattingEnabled = true;
            this.cbScholastic.Location = new System.Drawing.Point(209, 8);
            this.cbScholastic.Name = "cbScholastic";
            this.cbScholastic.Size = new System.Drawing.Size(202, 29);
            this.cbScholastic.TabIndex = 7;
            this.cbScholastic.DropDownClosed += new System.EventHandler(this.cbScholastic_DropDownClosed);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.CheckedState.Image = global::PrjTest.Properties.Resources.cancel;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.Transparent;
            this.btnEdit.FillColor2 = System.Drawing.Color.Transparent;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnEdit.HoverState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnEdit.HoverState.Image = global::PrjTest.Properties.Resources.edit2;
            this.btnEdit.Image = global::PrjTest.Properties.Resources.edit;
            this.btnEdit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEdit.Location = new System.Drawing.Point(870, 433);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PressedColor = System.Drawing.Color.Transparent;
            this.btnEdit.Size = new System.Drawing.Size(56, 45);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReload.BorderRadius = 10;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReload.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReload.FillColor = System.Drawing.Color.Transparent;
            this.btnReload.FillColor2 = System.Drawing.Color.Transparent;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnReload.HoverState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnReload.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnReload.HoverState.Image = global::PrjTest.Properties.Resources.reload2;
            this.btnReload.Image = global::PrjTest.Properties.Resources.Reload;
            this.btnReload.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReload.Location = new System.Drawing.Point(932, 433);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(57, 45);
            this.btnReload.TabIndex = 42;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lbStudent_ID
            // 
            this.lbStudent_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStudent_ID.AutoSize = true;
            this.lbStudent_ID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudent_ID.ForeColor = System.Drawing.Color.Teal;
            this.lbStudent_ID.Location = new System.Drawing.Point(49, 37);
            this.lbStudent_ID.Name = "lbStudent_ID";
            this.lbStudent_ID.Size = new System.Drawing.Size(108, 23);
            this.lbStudent_ID.TabIndex = 4;
            this.lbStudent_ID.Text = "TeacherID";
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Teal;
            this.lbName.Location = new System.Drawing.Point(49, 70);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(148, 23);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "TeacherName";
            // 
            // dgvStudentScore
            // 
            this.dgvStudentScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStudentScore.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudentScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentScore.Location = new System.Drawing.Point(53, 190);
            this.dgvStudentScore.Name = "dgvStudentScore";
            this.dgvStudentScore.RowHeadersWidth = 51;
            this.dgvStudentScore.RowTemplate.Height = 24;
            this.dgvStudentScore.Size = new System.Drawing.Size(986, 235);
            this.dgvStudentScore.TabIndex = 3;
            // 
            // fTeacherScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 679);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fTeacherScore";
            this.Text = "fStudentScore";
            this.Load += new System.EventHandler(this.fTeacherScore_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbWellcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvStudentScore;
        private System.Windows.Forms.Label lbStudent_ID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbScholastic;
        private System.Windows.Forms.Label lbSemester;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbScholastic;
        private Guna.UI2.WinForms.Guna2GradientButton btnEdit;
        private Guna.UI2.WinForms.Guna2GradientButton btnReload;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2GradientButton btnExport;
    }
}