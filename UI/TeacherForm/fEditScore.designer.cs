namespace PrjTest.TeacherForm
{
    partial class fEditScore
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
            this.components = new System.ComponentModel.Container();
            this.dgvEditScore = new System.Windows.Forms.DataGridView();
            this.teacherScoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbWellcome = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStuID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblProScore = new System.Windows.Forms.Label();
            this.lblFiScore = new System.Windows.Forms.Label();
            this.txtFiScore = new System.Windows.Forms.TextBox();
            this.txtProScore = new System.Windows.Forms.TextBox();
            this.lblAveScore = new System.Windows.Forms.Label();
            this.txtAveScore = new System.Windows.Forms.TextBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnReload = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherScoresBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEditScore
            // 
            this.dgvEditScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEditScore.BackgroundColor = System.Drawing.Color.White;
            this.dgvEditScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditScore.Location = new System.Drawing.Point(625, 110);
            this.dgvEditScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEditScore.Name = "dgvEditScore";
            this.dgvEditScore.RowHeadersWidth = 62;
            this.dgvEditScore.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvEditScore.RowTemplate.Height = 28;
            this.dgvEditScore.Size = new System.Drawing.Size(713, 398);
            this.dgvEditScore.TabIndex = 0;
            this.dgvEditScore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditScore_CellClick);
            // 
            // teacherScoresBindingSource
            // 
            this.teacherScoresBindingSource.DataMember = "Teacher_Scores";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lbWellcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 86);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbWellcome
            // 
            this.lbWellcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbWellcome.AutoSize = true;
            this.lbWellcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWellcome.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWellcome.ForeColor = System.Drawing.Color.Transparent;
            this.lbWellcome.Location = new System.Drawing.Point(534, 30);
            this.lbWellcome.Name = "lbWellcome";
            this.lbWellcome.Size = new System.Drawing.Size(274, 29);
            this.lbWellcome.TabIndex = 2;
            this.lbWellcome.Text = "SCORE MANAGEMENT";
            this.lbWellcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(45, 189);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(157, 23);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Student Name:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(209, 186);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(360, 32);
            this.txtName.TabIndex = 6;
            // 
            // txtStuID
            // 
            this.txtStuID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStuID.AutoSize = true;
            this.txtStuID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuID.Location = new System.Drawing.Point(45, 245);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(116, 23);
            this.txtStuID.TabIndex = 7;
            this.txtStuID.Text = "Student ID:";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(209, 242);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(360, 32);
            this.txtID.TabIndex = 8;
            // 
            // lblProScore
            // 
            this.lblProScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProScore.AutoSize = true;
            this.lblProScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProScore.Location = new System.Drawing.Point(45, 301);
            this.lblProScore.Name = "lblProScore";
            this.lblProScore.Size = new System.Drawing.Size(149, 23);
            this.lblProScore.TabIndex = 9;
            this.lblProScore.Text = "Process Score:";
            // 
            // lblFiScore
            // 
            this.lblFiScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiScore.AutoSize = true;
            this.lblFiScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiScore.Location = new System.Drawing.Point(332, 301);
            this.lblFiScore.Name = "lblFiScore";
            this.lblFiScore.Size = new System.Drawing.Size(120, 23);
            this.lblFiScore.TabIndex = 11;
            this.lblFiScore.Text = "Final Score:";
            // 
            // txtFiScore
            // 
            this.txtFiScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFiScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiScore.Location = new System.Drawing.Point(481, 298);
            this.txtFiScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiScore.Name = "txtFiScore";
            this.txtFiScore.Size = new System.Drawing.Size(88, 32);
            this.txtFiScore.TabIndex = 12;
            // 
            // txtProScore
            // 
            this.txtProScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProScore.Location = new System.Drawing.Point(209, 298);
            this.txtProScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProScore.Name = "txtProScore";
            this.txtProScore.Size = new System.Drawing.Size(88, 32);
            this.txtProScore.TabIndex = 13;
            // 
            // lblAveScore
            // 
            this.lblAveScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAveScore.AutoSize = true;
            this.lblAveScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAveScore.Location = new System.Drawing.Point(45, 359);
            this.lblAveScore.Name = "lblAveScore";
            this.lblAveScore.Size = new System.Drawing.Size(163, 23);
            this.lblAveScore.TabIndex = 14;
            this.lblAveScore.Text = "Average Score:";
            // 
            // txtAveScore
            // 
            this.txtAveScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAveScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAveScore.Location = new System.Drawing.Point(209, 357);
            this.txtAveScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAveScore.Name = "txtAveScore";
            this.txtAveScore.Size = new System.Drawing.Size(88, 32);
            this.txtAveScore.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.CheckedState.Image = global::PrjTest.Properties.Resources.cancel;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FillColor2 = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.HoverState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnUpdate.HoverState.Image = global::PrjTest.Properties.Resources.edit2;
            this.btnUpdate.Image = global::PrjTest.Properties.Resources.edit;
            this.btnUpdate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdate.Location = new System.Drawing.Point(418, 344);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Size = new System.Drawing.Size(56, 45);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnReload.Location = new System.Drawing.Point(513, 344);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(57, 45);
            this.btnReload.TabIndex = 43;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BorderRadius = 10;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.FillColor2 = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.HoverState.FillColor2 = System.Drawing.Color.Transparent;
            this.btnSave.HoverState.Image = global::PrjTest.Properties.Resources.save2;
            this.btnSave.Image = global::PrjTest.Properties.Resources.save;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(466, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 45);
            this.btnSave.TabIndex = 44;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BorderRadius = 5;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::PrjTest.Properties.Resources.logout;
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(24, 519);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 38);
            this.btnExit.TabIndex = 45;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fEditScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 587);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAveScore);
            this.Controls.Add(this.lblAveScore);
            this.Controls.Add(this.txtProScore);
            this.Controls.Add(this.txtFiScore);
            this.Controls.Add(this.lblFiScore);
            this.Controls.Add(this.lblProScore);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtStuID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEditScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fEditScore";
            this.Text = "fEditScore";
            this.Load += new System.EventHandler(this.fEditScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherScoresBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEditScore;
        private System.Windows.Forms.BindingSource teacherScoresBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbWellcome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label txtStuID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblProScore;
        private System.Windows.Forms.Label lblFiScore;
        private System.Windows.Forms.TextBox txtFiScore;
        private System.Windows.Forms.TextBox txtProScore;
        private System.Windows.Forms.Label lblAveScore;
        private System.Windows.Forms.TextBox txtAveScore;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdate;
        private Guna.UI2.WinForms.Guna2GradientButton btnReload;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}