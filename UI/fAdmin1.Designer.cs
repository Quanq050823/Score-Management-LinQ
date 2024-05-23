namespace PrjTest
{
    partial class fAdmin1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.plform = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pl_logo = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.plmain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.plMenu = new System.Windows.Forms.Panel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnTeacherInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentInfo = new Guna.UI2.WinForms.Guna2Button();
            this.imgSlide = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSession = new Guna.UI2.WinForms.Guna2Button();
            this.btnScore = new Guna.UI2.WinForms.Guna2Button();
            this.pl_logo.SuspendLayout();
            this.plmain.SuspendLayout();
            this.plMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Enroll.png");
            this.imageList1.Images.SetKeyName(1, "Hooman.png");
            this.imageList1.Images.SetKeyName(2, "Score.png");
            // 
            // plform
            // 
            this.plform.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plform.BackColor = System.Drawing.Color.Transparent;
            this.plform.Location = new System.Drawing.Point(252, 38);
            this.plform.Margin = new System.Windows.Forms.Padding(4);
            this.plform.Name = "plform";
            this.plform.Size = new System.Drawing.Size(1116, 660);
            this.plform.TabIndex = 2;
            // 
            // pl_logo
            // 
            this.pl_logo.BackColor = System.Drawing.Color.Transparent;
            this.pl_logo.Controls.Add(this.pictureBox1);
            this.pl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_logo.Location = new System.Drawing.Point(0, 0);
            this.pl_logo.Name = "pl_logo";
            this.pl_logo.Size = new System.Drawing.Size(248, 141);
            this.pl_logo.TabIndex = 3;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // plmain
            // 
            this.plmain.Controls.Add(this.plform);
            this.plmain.Controls.Add(this.plMenu);
            this.plmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plmain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(106)))));
            this.plmain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.plmain.Location = new System.Drawing.Point(0, 0);
            this.plmain.Margin = new System.Windows.Forms.Padding(4);
            this.plmain.Name = "plmain";
            this.plmain.Size = new System.Drawing.Size(1413, 753);
            this.plmain.TabIndex = 2;
            // 
            // plMenu
            // 
            this.plMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plMenu.BackColor = System.Drawing.Color.Transparent;
            this.plMenu.Controls.Add(this.btnExit);
            this.plMenu.Controls.Add(this.btnTeacherInfo);
            this.plMenu.Controls.Add(this.btnStudentInfo);
            this.plMenu.Controls.Add(this.imgSlide);
            this.plMenu.Controls.Add(this.pl_logo);
            this.plMenu.Controls.Add(this.btnSession);
            this.plMenu.Controls.Add(this.btnScore);
            this.plMenu.Location = new System.Drawing.Point(4, 13);
            this.plMenu.Margin = new System.Windows.Forms.Padding(4);
            this.plMenu.Name = "plMenu";
            this.plMenu.Size = new System.Drawing.Size(248, 753);
            this.plMenu.TabIndex = 1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 26;
            this.guna2Elipse2.TargetControl = this.plform;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PrjTest.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BorderRadius = 5;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(13, 630);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 38);
            this.btnExit.TabIndex = 6;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTeacherInfo
            // 
            this.btnTeacherInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTeacherInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnTeacherInfo.BorderRadius = 22;
            this.btnTeacherInfo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTeacherInfo.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTeacherInfo.CheckedState.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherInfo.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(102)))), ((int)(((byte)(123)))));
            this.btnTeacherInfo.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnTeacherInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacherInfo.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnTeacherInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTeacherInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTeacherInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTeacherInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnTeacherInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherInfo.ForeColor = System.Drawing.Color.White;
            this.btnTeacherInfo.HoverState.FillColor = System.Drawing.Color.White;
            this.btnTeacherInfo.HoverState.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherInfo.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(102)))), ((int)(((byte)(123)))));
            this.btnTeacherInfo.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnTeacherInfo.Image = global::PrjTest.Properties.Resources.ningen;
            this.btnTeacherInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTeacherInfo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTeacherInfo.Location = new System.Drawing.Point(13, 252);
            this.btnTeacherInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnTeacherInfo.Name = "btnTeacherInfo";
            this.btnTeacherInfo.PressedColor = System.Drawing.Color.White;
            this.btnTeacherInfo.Size = new System.Drawing.Size(217, 53);
            this.btnTeacherInfo.TabIndex = 1;
            this.btnTeacherInfo.Text = "Teacher Info";
            this.btnTeacherInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTeacherInfo.UseTransparentBackground = true;
            this.btnTeacherInfo.Click += new System.EventHandler(this.btnTeacherInfo_Click);
            // 
            // btnStudentInfo
            // 
            this.btnStudentInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStudentInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnStudentInfo.BorderRadius = 22;
            this.btnStudentInfo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStudentInfo.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStudentInfo.CheckedState.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentInfo.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(102)))), ((int)(((byte)(123)))));
            this.btnStudentInfo.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnStudentInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentInfo.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnStudentInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudentInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudentInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnStudentInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentInfo.ForeColor = System.Drawing.Color.White;
            this.btnStudentInfo.HoverState.FillColor = System.Drawing.Color.White;
            this.btnStudentInfo.HoverState.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentInfo.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(102)))), ((int)(((byte)(123)))));
            this.btnStudentInfo.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnStudentInfo.Image = global::PrjTest.Properties.Resources.ningen;
            this.btnStudentInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudentInfo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStudentInfo.Location = new System.Drawing.Point(13, 182);
            this.btnStudentInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentInfo.Name = "btnStudentInfo";
            this.btnStudentInfo.PressedColor = System.Drawing.Color.White;
            this.btnStudentInfo.Size = new System.Drawing.Size(217, 53);
            this.btnStudentInfo.TabIndex = 1;
            this.btnStudentInfo.Text = "Student Info";
            this.btnStudentInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudentInfo.UseTransparentBackground = true;
            this.btnStudentInfo.Click += new System.EventHandler(this.btnStudentInfo_Click);
            // 
            // imgSlide
            // 
            this.imgSlide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgSlide.Image = ((System.Drawing.Image)(resources.GetObject("imgSlide.Image")));
            this.imgSlide.ImageRotate = 0F;
            this.imgSlide.Location = new System.Drawing.Point(163, 147);
            this.imgSlide.Margin = new System.Windows.Forms.Padding(4);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(121, 119);
            this.imgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlide.TabIndex = 1;
            this.imgSlide.TabStop = false;
            // 
            // btnSession
            // 
            this.btnSession.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSession.BackColor = System.Drawing.Color.Transparent;
            this.btnSession.BorderRadius = 22;
            this.btnSession.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSession.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSession.CheckedState.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSession.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(102)))), ((int)(((byte)(123)))));
            this.btnSession.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSession.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSession.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSession.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSession.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSession.FillColor = System.Drawing.Color.Transparent;
            this.btnSession.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSession.ForeColor = System.Drawing.Color.White;
            this.btnSession.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSession.HoverState.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSession.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(102)))), ((int)(((byte)(123)))));
            this.btnSession.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btnSession.Image = ((System.Drawing.Image)(resources.GetObject("btnSession.Image")));
            this.btnSession.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSession.ImageSize = new System.Drawing.Size(37, 37);
            this.btnSession.Location = new System.Drawing.Point(13, 383);
            this.btnSession.Margin = new System.Windows.Forms.Padding(4);
            this.btnSession.Name = "btnSession";
            this.btnSession.Size = new System.Drawing.Size(217, 53);
            this.btnSession.TabIndex = 1;
            this.btnSession.Text = "Sessions";
            this.btnSession.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSession.UseTransparentBackground = true;
            this.btnSession.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnScore
            // 
            this.btnScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnScore.BackColor = System.Drawing.Color.Transparent;
            this.btnScore.BorderRadius = 22;
            this.btnScore.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnScore.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnScore.CheckedState.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(102)))), ((int)(((byte)(123)))));
            this.btnScore.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.btnScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnScore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnScore.FillColor = System.Drawing.Color.Transparent;
            this.btnScore.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.White;
            this.btnScore.HoverState.FillColor = System.Drawing.Color.White;
            this.btnScore.HoverState.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(102)))), ((int)(((byte)(123)))));
            this.btnScore.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            this.btnScore.Image = ((System.Drawing.Image)(resources.GetObject("btnScore.Image")));
            this.btnScore.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnScore.ImageSize = new System.Drawing.Size(30, 30);
            this.btnScore.Location = new System.Drawing.Point(13, 322);
            this.btnScore.Margin = new System.Windows.Forms.Padding(4);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(217, 53);
            this.btnScore.TabIndex = 1;
            this.btnScore.Text = "Score";
            this.btnScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnScore.UseTransparentBackground = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // fAdmin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1413, 753);
            this.Controls.Add(this.plmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAdmin1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fAdmin1_Load);
            this.pl_logo.ResumeLayout(false);
            this.plmain.ResumeLayout(false);
            this.plMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2GradientPanel plform;
        private System.Windows.Forms.Panel pl_logo;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel plmain;
        private System.Windows.Forms.Panel plMenu;
        private Guna.UI2.WinForms.Guna2PictureBox imgSlide;
        private Guna.UI2.WinForms.Guna2Button btnStudentInfo;
        private Guna.UI2.WinForms.Guna2Button btnSession;
        private Guna.UI2.WinForms.Guna2Button btnScore;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnTeacherInfo;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

