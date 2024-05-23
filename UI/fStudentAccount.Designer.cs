namespace PrjTest
{
    partial class fStudentAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStudentAccount));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.plform = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pl_logo = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.plmain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.plMenu = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Info = new Guna.UI2.WinForms.Guna2Button();
            this.imgSlide = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnEnroll = new Guna.UI2.WinForms.Guna2Button();
            this.btnScore = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pl_logo.SuspendLayout();
            this.plmain.SuspendLayout();
            this.plMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.plform.Location = new System.Drawing.Point(248, 13);
            this.plform.Margin = new System.Windows.Forms.Padding(4);
            this.plform.Name = "plform";
            this.plform.Size = new System.Drawing.Size(1043, 676);
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
            this.guna2Elipse1.TargetControl = this.plform;
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
            this.plmain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.plmain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(94)))), ((int)(((byte)(172)))));
            this.plmain.Location = new System.Drawing.Point(0, 0);
            this.plmain.Margin = new System.Windows.Forms.Padding(4);
            this.plmain.Name = "plmain";
            this.plmain.Size = new System.Drawing.Size(1304, 702);
            this.plmain.TabIndex = 2;
            // 
            // plMenu
            // 
            this.plMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plMenu.BackColor = System.Drawing.Color.Transparent;
            this.plMenu.Controls.Add(this.btnExit);
            this.plMenu.Controls.Add(this.btn_Info);
            this.plMenu.Controls.Add(this.imgSlide);
            this.plMenu.Controls.Add(this.pl_logo);
            this.plMenu.Controls.Add(this.btnEnroll);
            this.plMenu.Controls.Add(this.btnScore);
            this.plMenu.Location = new System.Drawing.Point(0, 0);
            this.plMenu.Margin = new System.Windows.Forms.Padding(4);
            this.plMenu.Name = "plMenu";
            this.plMenu.Size = new System.Drawing.Size(248, 702);
            this.plMenu.TabIndex = 1;
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
            this.btnExit.Location = new System.Drawing.Point(13, 623);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 38);
            this.btnExit.TabIndex = 6;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Info.BackColor = System.Drawing.Color.Transparent;
            this.btn_Info.BorderRadius = 22;
            this.btn_Info.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Info.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_Info.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.btn_Info.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Info.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Info.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Info.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Info.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Info.FillColor = System.Drawing.Color.Transparent;
            this.btn_Info.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Info.ForeColor = System.Drawing.Color.White;
            this.btn_Info.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Info.HoverState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Info.HoverState.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_Info.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btn_Info.Image = global::PrjTest.Properties.Resources.ningen;
            this.btn_Info.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Info.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Info.Location = new System.Drawing.Point(13, 212);
            this.btn_Info.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.PressedColor = System.Drawing.Color.White;
            this.btn_Info.Size = new System.Drawing.Size(217, 53);
            this.btn_Info.TabIndex = 1;
            this.btn_Info.Text = "Information";
            this.btn_Info.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Info.UseTransparentBackground = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // imgSlide
            // 
            this.imgSlide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgSlide.Image = ((System.Drawing.Image)(resources.GetObject("imgSlide.Image")));
            this.imgSlide.ImageRotate = 0F;
            this.imgSlide.Location = new System.Drawing.Point(163, 177);
            this.imgSlide.Margin = new System.Windows.Forms.Padding(4);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(121, 120);
            this.imgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlide.TabIndex = 1;
            this.imgSlide.TabStop = false;
            // 
            // btnEnroll
            // 
            this.btnEnroll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnroll.BackColor = System.Drawing.Color.Transparent;
            this.btnEnroll.BorderRadius = 22;
            this.btnEnroll.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEnroll.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEnroll.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.btnEnroll.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnEnroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnroll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnroll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnroll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnroll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnroll.FillColor = System.Drawing.Color.Transparent;
            this.btnEnroll.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.ForeColor = System.Drawing.Color.White;
            this.btnEnroll.HoverState.FillColor = System.Drawing.Color.White;
            this.btnEnroll.HoverState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.HoverState.ForeColor = System.Drawing.Color.IndianRed;
            this.btnEnroll.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnEnroll.Image = ((System.Drawing.Image)(resources.GetObject("btnEnroll.Image")));
            this.btnEnroll.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEnroll.ImageSize = new System.Drawing.Size(37, 37);
            this.btnEnroll.Location = new System.Drawing.Point(13, 439);
            this.btnEnroll.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(217, 53);
            this.btnEnroll.TabIndex = 1;
            this.btnEnroll.Text = "Enrolled";
            this.btnEnroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEnroll.UseTransparentBackground = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnScore
            // 
            this.btnScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnScore.BackColor = System.Drawing.Color.Transparent;
            this.btnScore.BorderRadius = 22;
            this.btnScore.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnScore.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnScore.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.btnScore.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnScore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnScore.FillColor = System.Drawing.Color.Transparent;
            this.btnScore.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.White;
            this.btnScore.HoverState.FillColor = System.Drawing.Color.White;
            this.btnScore.HoverState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.HoverState.ForeColor = System.Drawing.Color.IndianRed;
            this.btnScore.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btnScore.Image = ((System.Drawing.Image)(resources.GetObject("btnScore.Image")));
            this.btnScore.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnScore.ImageSize = new System.Drawing.Size(30, 30);
            this.btnScore.Location = new System.Drawing.Point(13, 326);
            this.btnScore.Margin = new System.Windows.Forms.Padding(4);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(217, 53);
            this.btnScore.TabIndex = 1;
            this.btnScore.Text = "Score";
            this.btnScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnScore.UseTransparentBackground = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 26;
            this.guna2Elipse2.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PrjTest.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(32, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // fStudentAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1304, 702);
            this.Controls.Add(this.plmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fStudentAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pl_logo.ResumeLayout(false);
            this.plmain.ResumeLayout(false);
            this.plMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Button btn_Info;
        private Guna.UI2.WinForms.Guna2Button btnEnroll;
        private Guna.UI2.WinForms.Guna2Button btnScore;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

