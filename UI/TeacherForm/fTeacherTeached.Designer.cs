namespace PrjTest.StudentForm
{
    partial class fTeacherTeached
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
            this.lbWellcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExport = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.lbSemester = new System.Windows.Forms.Label();
            this.lbScholastic = new System.Windows.Forms.Label();
            this.cbScholastic = new System.Windows.Forms.ComboBox();
            this.btnReload = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbTeacher_ID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.dgvStudentEnrolled = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentEnrolled)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWellcome
            // 
            this.lbWellcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbWellcome.AutoSize = true;
            this.lbWellcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWellcome.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWellcome.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbWellcome.Location = new System.Drawing.Point(394, 37);
            this.lbWellcome.Name = "lbWellcome";
            this.lbWellcome.Size = new System.Drawing.Size(160, 39);
            this.lbWellcome.TabIndex = 2;
            this.lbWellcome.Text = "TEACHED";
            this.lbWellcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.lbWellcome);
            this.panel2.Controls.Add(this.lbTeacher_ID);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.dgvStudentEnrolled);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 595);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.btnExport.Location = new System.Drawing.Point(800, 480);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(45, 45);
            this.btnExport.TabIndex = 11;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbSemester);
            this.panel1.Controls.Add(this.lbSemester);
            this.panel1.Controls.Add(this.lbScholastic);
            this.panel1.Controls.Add(this.cbScholastic);
            this.panel1.Location = new System.Drawing.Point(352, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 48);
            this.panel1.TabIndex = 44;
            // 
            // cbSemester
            // 
            this.cbSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSemester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemester.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.IntegralHeight = false;
            this.cbSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbSemester.Location = new System.Drawing.Point(363, 9);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(121, 29);
            this.cbSemester.TabIndex = 5;
            // 
            // lbSemester
            // 
            this.lbSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSemester.AutoSize = true;
            this.lbSemester.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbSemester.Location = new System.Drawing.Point(257, 11);
            this.lbSemester.Name = "lbSemester";
            this.lbSemester.Size = new System.Drawing.Size(85, 21);
            this.lbSemester.TabIndex = 4;
            this.lbSemester.Text = "Semester";
            this.lbSemester.Click += new System.EventHandler(this.lbSemester_Click);
            // 
            // lbScholastic
            // 
            this.lbScholastic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbScholastic.AutoSize = true;
            this.lbScholastic.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbScholastic.Location = new System.Drawing.Point(3, 12);
            this.lbScholastic.Name = "lbScholastic";
            this.lbScholastic.Size = new System.Drawing.Size(93, 21);
            this.lbScholastic.TabIndex = 4;
            this.lbScholastic.Text = "Scholastic";
            this.lbScholastic.Click += new System.EventHandler(this.lbScholastic_Click);
            // 
            // cbScholastic
            // 
            this.cbScholastic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbScholastic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbScholastic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScholastic.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbScholastic.FormattingEnabled = true;
            this.cbScholastic.IntegralHeight = false;
            this.cbScholastic.Location = new System.Drawing.Point(117, 7);
            this.cbScholastic.Name = "cbScholastic";
            this.cbScholastic.Size = new System.Drawing.Size(121, 29);
            this.cbScholastic.TabIndex = 5;
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
            this.btnReload.Location = new System.Drawing.Point(737, 480);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(57, 45);
            this.btnReload.TabIndex = 43;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lbTeacher_ID
            // 
            this.lbTeacher_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTeacher_ID.AutoSize = true;
            this.lbTeacher_ID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacher_ID.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbTeacher_ID.Location = new System.Drawing.Point(84, 107);
            this.lbTeacher_ID.Name = "lbTeacher_ID";
            this.lbTeacher_ID.Size = new System.Drawing.Size(126, 23);
            this.lbTeacher_ID.TabIndex = 4;
            this.lbTeacher_ID.Text = "Teacher ID: ";
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbName.Location = new System.Drawing.Point(84, 140);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(94, 23);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Teacher ";
            // 
            // dgvStudentEnrolled
            // 
            this.dgvStudentEnrolled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStudentEnrolled.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudentEnrolled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentEnrolled.Location = new System.Drawing.Point(88, 239);
            this.dgvStudentEnrolled.Name = "dgvStudentEnrolled";
            this.dgvStudentEnrolled.RowHeadersWidth = 51;
            this.dgvStudentEnrolled.RowTemplate.Height = 24;
            this.dgvStudentEnrolled.Size = new System.Drawing.Size(758, 235);
            this.dgvStudentEnrolled.TabIndex = 3;
            // 
            // fTeacherTeached
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 595);
            this.Controls.Add(this.panel2);
            this.Name = "fTeacherTeached";
            this.Text = "fStudentScore";
            this.Load += new System.EventHandler(this.fTeacherTeached_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentEnrolled)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbWellcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvStudentEnrolled;
        private System.Windows.Forms.Label lbTeacher_ID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox cbScholastic;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.Label lbScholastic;
        private System.Windows.Forms.Label lbSemester;
        private Guna.UI2.WinForms.Guna2GradientButton btnReload;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnExport;
    }
}