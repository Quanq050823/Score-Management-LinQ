namespace PrjTest.StudentForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExport = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbScholastic = new System.Windows.Forms.ComboBox();
            this.lbSemester = new System.Windows.Forms.Label();
            this.lbScholastic = new System.Windows.Forms.Label();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.btnReload = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbWellcome = new System.Windows.Forms.Label();
            this.lbAccCredit = new System.Windows.Forms.Label();
            this.lbAccScore = new System.Windows.Forms.Label();
            this.lbStudent_ID = new System.Windows.Forms.Label();
            this.lbAvg = new System.Windows.Forms.Label();
            this.lbNoCredit = new System.Windows.Forms.Label();
            this.dgvStudentScore = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentScore)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.lbWellcome);
            this.panel2.Controls.Add(this.lbAccCredit);
            this.panel2.Controls.Add(this.lbAccScore);
            this.panel2.Controls.Add(this.lbStudent_ID);
            this.panel2.Controls.Add(this.lbAvg);
            this.panel2.Controls.Add(this.lbNoCredit);
            this.panel2.Controls.Add(this.dgvStudentScore);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 688);
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
            this.btnExport.Location = new System.Drawing.Point(999, 571);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(45, 45);
            this.btnExport.TabIndex = 11;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbScholastic);
            this.panel1.Controls.Add(this.lbSemester);
            this.panel1.Controls.Add(this.lbScholastic);
            this.panel1.Controls.Add(this.cbSemester);
            this.panel1.Location = new System.Drawing.Point(533, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 56);
            this.panel1.TabIndex = 44;
            // 
            // cbScholastic
            // 
            this.cbScholastic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbScholastic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScholastic.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbScholastic.FormattingEnabled = true;
            this.cbScholastic.IntegralHeight = false;
            this.cbScholastic.Location = new System.Drawing.Point(125, 18);
            this.cbScholastic.Name = "cbScholastic";
            this.cbScholastic.Size = new System.Drawing.Size(121, 29);
            this.cbScholastic.TabIndex = 5;
            // 
            // lbSemester
            // 
            this.lbSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSemester.AutoSize = true;
            this.lbSemester.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbSemester.Location = new System.Drawing.Point(271, 20);
            this.lbSemester.Name = "lbSemester";
            this.lbSemester.Size = new System.Drawing.Size(85, 21);
            this.lbSemester.TabIndex = 4;
            this.lbSemester.Text = "Semester";
            // 
            // lbScholastic
            // 
            this.lbScholastic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbScholastic.AutoSize = true;
            this.lbScholastic.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbScholastic.Location = new System.Drawing.Point(11, 20);
            this.lbScholastic.Name = "lbScholastic";
            this.lbScholastic.Size = new System.Drawing.Size(93, 21);
            this.lbScholastic.TabIndex = 4;
            this.lbScholastic.Text = "Scholastic";
            // 
            // cbSemester
            // 
            this.cbSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemester.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.IntegralHeight = false;
            this.cbSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbSemester.Location = new System.Drawing.Point(377, 18);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(121, 29);
            this.cbSemester.TabIndex = 5;
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
            this.btnReload.Location = new System.Drawing.Point(936, 571);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(57, 45);
            this.btnReload.TabIndex = 43;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lbWellcome
            // 
            this.lbWellcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbWellcome.AutoSize = true;
            this.lbWellcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWellcome.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWellcome.ForeColor = System.Drawing.Color.Maroon;
            this.lbWellcome.Location = new System.Drawing.Point(485, 54);
            this.lbWellcome.Name = "lbWellcome";
            this.lbWellcome.Size = new System.Drawing.Size(124, 39);
            this.lbWellcome.TabIndex = 2;
            this.lbWellcome.Text = "SCORE";
            this.lbWellcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAccCredit
            // 
            this.lbAccCredit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAccCredit.AutoSize = true;
            this.lbAccCredit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccCredit.Location = new System.Drawing.Point(54, 191);
            this.lbAccCredit.Name = "lbAccCredit";
            this.lbAccCredit.Size = new System.Drawing.Size(206, 23);
            this.lbAccCredit.TabIndex = 4;
            this.lbAccCredit.Text = "AccumulatedCredit";
            // 
            // lbAccScore
            // 
            this.lbAccScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAccScore.AutoSize = true;
            this.lbAccScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccScore.Location = new System.Drawing.Point(54, 151);
            this.lbAccScore.Name = "lbAccScore";
            this.lbAccScore.Size = new System.Drawing.Size(202, 23);
            this.lbAccScore.TabIndex = 4;
            this.lbAccScore.Text = "AccumulatedScore";
            // 
            // lbStudent_ID
            // 
            this.lbStudent_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStudent_ID.AutoSize = true;
            this.lbStudent_ID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudent_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbStudent_ID.Location = new System.Drawing.Point(54, 115);
            this.lbStudent_ID.Name = "lbStudent_ID";
            this.lbStudent_ID.Size = new System.Drawing.Size(102, 23);
            this.lbStudent_ID.TabIndex = 4;
            this.lbStudent_ID.Text = "StudentID";
            // 
            // lbAvg
            // 
            this.lbAvg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAvg.AutoSize = true;
            this.lbAvg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvg.Location = new System.Drawing.Point(62, 553);
            this.lbAvg.Name = "lbAvg";
            this.lbAvg.Size = new System.Drawing.Size(51, 23);
            this.lbAvg.TabIndex = 4;
            this.lbAvg.Text = "Avg";
            // 
            // lbNoCredit
            // 
            this.lbNoCredit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNoCredit.AutoSize = true;
            this.lbNoCredit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoCredit.Location = new System.Drawing.Point(62, 519);
            this.lbNoCredit.Name = "lbNoCredit";
            this.lbNoCredit.Size = new System.Drawing.Size(97, 23);
            this.lbNoCredit.TabIndex = 4;
            this.lbNoCredit.Text = "NoCredit";
            // 
            // dgvStudentScore
            // 
            this.dgvStudentScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStudentScore.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudentScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentScore.Location = new System.Drawing.Point(58, 270);
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
            this.ClientSize = new System.Drawing.Size(1087, 688);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fStudentScore";
            this.Text = "fStudentScore";
            this.Load += new System.EventHandler(this.fStudentScore_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvStudentScore;
        private System.Windows.Forms.Label lbStudent_ID;
        private System.Windows.Forms.ComboBox cbScholastic;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.Label lbScholastic;
        private System.Windows.Forms.Label lbSemester;
        private System.Windows.Forms.Label lbAvg;
        private System.Windows.Forms.Label lbNoCredit;
        private System.Windows.Forms.Label lbWellcome;
        private System.Windows.Forms.Label lbAccCredit;
        private System.Windows.Forms.Label lbAccScore;
        private Guna.UI2.WinForms.Guna2GradientButton btnReload;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnExport;
    }
}