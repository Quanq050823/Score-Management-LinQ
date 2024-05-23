namespace PrjTest.Admin_form
{
    partial class fStudentScore
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
            this.plTitle = new System.Windows.Forms.Panel();
            this.lbWellcome = new System.Windows.Forms.Label();
            this.plMain = new System.Windows.Forms.Panel();
            this.btnExport = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnReload = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbScholastic = new System.Windows.Forms.ComboBox();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.lblScholastic = new System.Windows.Forms.Label();
            this.cbSession = new System.Windows.Forms.ComboBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.dgvStudentScore = new System.Windows.Forms.DataGridView();
            this.plTitle.SuspendLayout();
            this.plMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentScore)).BeginInit();
            this.SuspendLayout();
            // 
            // plTitle
            // 
            this.plTitle.BackColor = System.Drawing.Color.White;
            this.plTitle.Controls.Add(this.lbWellcome);
            this.plTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTitle.Location = new System.Drawing.Point(0, 0);
            this.plTitle.Name = "plTitle";
            this.plTitle.Size = new System.Drawing.Size(1092, 124);
            this.plTitle.TabIndex = 1;
            // 
            // lbWellcome
            // 
            this.lbWellcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbWellcome.AutoSize = true;
            this.lbWellcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWellcome.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWellcome.ForeColor = System.Drawing.Color.Teal;
            this.lbWellcome.Location = new System.Drawing.Point(415, 46);
            this.lbWellcome.Name = "lbWellcome";
            this.lbWellcome.Size = new System.Drawing.Size(274, 29);
            this.lbWellcome.TabIndex = 2;
            this.lbWellcome.Text = "SCORE MANAGEMENT";
            this.lbWellcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.White;
            this.plMain.Controls.Add(this.btnExport);
            this.plMain.Controls.Add(this.btnEdit);
            this.plMain.Controls.Add(this.btnReload);
            this.plMain.Controls.Add(this.cbScholastic);
            this.plMain.Controls.Add(this.cbSemester);
            this.plMain.Controls.Add(this.lblScholastic);
            this.plMain.Controls.Add(this.cbSession);
            this.plMain.Controls.Add(this.lblSemester);
            this.plMain.Controls.Add(this.lblSession);
            this.plMain.Controls.Add(this.dgvStudentScore);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 124);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1092, 555);
            this.plMain.TabIndex = 5;
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
            this.btnExport.Location = new System.Drawing.Point(994, 449);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(45, 45);
            this.btnExport.TabIndex = 46;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(875, 449);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PressedColor = System.Drawing.Color.Transparent;
            this.btnEdit.Size = new System.Drawing.Size(56, 45);
            this.btnEdit.TabIndex = 44;
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
            this.btnReload.Location = new System.Drawing.Point(931, 449);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(57, 45);
            this.btnReload.TabIndex = 45;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // cbScholastic
            // 
            this.cbScholastic.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.cbScholastic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbScholastic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbScholastic.FormattingEnabled = true;
            this.cbScholastic.Location = new System.Drawing.Point(838, 36);
            this.cbScholastic.Name = "cbScholastic";
            this.cbScholastic.Size = new System.Drawing.Size(202, 31);
            this.cbScholastic.TabIndex = 7;
            this.cbScholastic.DropDownClosed += new System.EventHandler(this.cbScholastic_DropDownClosed);
            // 
            // cbSemester
            // 
            this.cbSemester.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.cbSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSemester.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbSemester.Location = new System.Drawing.Point(838, 82);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(202, 31);
            this.cbSemester.TabIndex = 7;
            this.cbSemester.DropDownClosed += new System.EventHandler(this.cbSemester_DropDownClosed);
            // 
            // lblScholastic
            // 
            this.lblScholastic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScholastic.AutoSize = true;
            this.lblScholastic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScholastic.Location = new System.Drawing.Point(628, 39);
            this.lblScholastic.Name = "lblScholastic";
            this.lblScholastic.Size = new System.Drawing.Size(180, 23);
            this.lblScholastic.TabIndex = 4;
            this.lblScholastic.Text = "Select Scholastic:";
            // 
            // cbSession
            // 
            this.cbSession.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.cbSession.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSession.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSession.FormattingEnabled = true;
            this.cbSession.Location = new System.Drawing.Point(838, 128);
            this.cbSession.Name = "cbSession";
            this.cbSession.Size = new System.Drawing.Size(201, 31);
            this.cbSession.TabIndex = 7;
            // 
            // lblSemester
            // 
            this.lblSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(628, 85);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(171, 23);
            this.lblSemester.TabIndex = 4;
            this.lblSemester.Text = "Select Semester:";
            // 
            // lblSession
            // 
            this.lblSession.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(628, 131);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(149, 23);
            this.lblSession.TabIndex = 4;
            this.lblSession.Text = "Select Session:";
            // 
            // dgvStudentScore
            // 
            this.dgvStudentScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStudentScore.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudentScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentScore.Location = new System.Drawing.Point(53, 206);
            this.dgvStudentScore.Name = "dgvStudentScore";
            this.dgvStudentScore.RowHeadersWidth = 51;
            this.dgvStudentScore.RowTemplate.Height = 24;
            this.dgvStudentScore.Size = new System.Drawing.Size(986, 235);
            this.dgvStudentScore.TabIndex = 3;
            // 
            // fStudentScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 679);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.plTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fStudentScore";
            this.Text = "fStudentScore";
            this.Load += new System.EventHandler(this.fStudentScore_Load);
            this.plTitle.ResumeLayout(false);
            this.plTitle.PerformLayout();
            this.plMain.ResumeLayout(false);
            this.plMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plTitle;
        private System.Windows.Forms.Label lbWellcome;
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.Label lblScholastic;
        private System.Windows.Forms.ComboBox cbSession;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.DataGridView dgvStudentScore;
        private Guna.UI2.WinForms.Guna2GradientButton btnEdit;
        private Guna.UI2.WinForms.Guna2GradientButton btnReload;
        private Guna.UI2.WinForms.Guna2GradientButton btnExport;
        private System.Windows.Forms.ComboBox cbScholastic;
    }
}