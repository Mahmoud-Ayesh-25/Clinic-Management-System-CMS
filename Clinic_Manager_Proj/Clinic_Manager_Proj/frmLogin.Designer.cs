namespace Clinic_Manager_Proj
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            this.tbxUsername = new CuoreUI.Controls.cuiTextBox();
            this.ctrlPassword1 = new Clinic_Manager_Proj.ctrlPassword();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.pnlAppointmants = new CuoreUI.Controls.cuiGradientPanel();
            this.btnLogin = new CuoreUI.Controls.cuiButton();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.lblWarning = new CuoreUI.Controls.cuiLabel();
            this.pnlBtnClose.SuspendLayout();
            this.pnlAppointmants.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMaximized
            // 
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            this.btnMaximized.Location = new System.Drawing.Point(386, 11);
            this.btnMaximized.Visible = false;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMinimized.Location = new System.Drawing.Point(386, 11);
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.login__1_;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMainTitle.Content = "Login";
            this.lblMainTitle.Location = new System.Drawing.Point(3, 0);
            this.lblMainTitle.Size = new System.Drawing.Size(476, 58);
            // 
            // pnlBtnClose
            // 
            this.pnlBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtnClose.Location = new System.Drawing.Point(428, 11);
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Location = new System.Drawing.Point(488, 0);
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 600);
            this.cuiResizeGrip.Visible = false;
            // 
            // cuiLabel4
            // 
            this.cuiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel4.Content = "Welcome\\ To\\n\\ Clinic\\ Managment\\ System\\n\\ \\(CMS\\)";
            this.cuiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel4.ForeColor = System.Drawing.Color.White;
            this.cuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel4.Location = new System.Drawing.Point(0, 53);
            this.cuiLabel4.Name = "cuiLabel4";
            this.cuiLabel4.Size = new System.Drawing.Size(476, 128);
            this.cuiLabel4.TabIndex = 3;
            this.cuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.Color.Transparent;
            this.tbxUsername.BackgroundColor = System.Drawing.Color.Black;
            this.tbxUsername.Content = "";
            this.tbxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUsername.FocusBackgroundColor = System.Drawing.Color.Black;
            this.tbxUsername.FocusImageTint = System.Drawing.Color.White;
            this.tbxUsername.FocusOutlineColor = System.Drawing.Color.White;
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.ForeColor = System.Drawing.Color.White;
            this.tbxUsername.Image = null;
            this.tbxUsername.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxUsername.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxUsername.Location = new System.Drawing.Point(131, 205);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUsername.Multiline = false;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.NormalImageTint = System.Drawing.Color.White;
            this.tbxUsername.OutlineColor = System.Drawing.Color.Black;
            this.tbxUsername.Padding = new System.Windows.Forms.Padding(16, 12, 16, 0);
            this.tbxUsername.PasswordChar = false;
            this.tbxUsername.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxUsername.PlaceholderText = "Username";
            this.tbxUsername.Rounding = new System.Windows.Forms.Padding(19);
            this.tbxUsername.Size = new System.Drawing.Size(257, 40);
            this.tbxUsername.TabIndex = 0;
            this.tbxUsername.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxUsername.UnderlinedStyle = false;
            this.tbxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUsername_KeyPress);
            // 
            // ctrlPassword1
            // 
            this.ctrlPassword1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ctrlPassword1.Content = "";
            this.ctrlPassword1.Location = new System.Drawing.Point(131, 272);
            this.ctrlPassword1.Name = "ctrlPassword1";
            this.ctrlPassword1.OutLineColor = System.Drawing.Color.Black;
            this.ctrlPassword1.PlaceHolderColor = System.Drawing.Color.DimGray;
            this.ctrlPassword1.PlaceHolderText = "Password";
            this.ctrlPassword1.Size = new System.Drawing.Size(257, 40);
            this.ctrlPassword1.TabIndex = 1;
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox1.Content = global::Clinic_Manager_Proj.Properties.Resources.id_card__1_;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox1.Location = new System.Drawing.Point(82, 204);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox1.Size = new System.Drawing.Size(42, 42);
            this.cuiPictureBox1.TabIndex = 22;
            // 
            // cuiPictureBox2
            // 
            this.cuiPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox2.Content = global::Clinic_Manager_Proj.Properties.Resources.password__1_;
            this.cuiPictureBox2.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox2.Location = new System.Drawing.Point(82, 271);
            this.cuiPictureBox2.Name = "cuiPictureBox2";
            this.cuiPictureBox2.OutlineThickness = 1F;
            this.cuiPictureBox2.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox2.Rotation = 0;
            this.cuiPictureBox2.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox2.Size = new System.Drawing.Size(42, 42);
            this.cuiPictureBox2.TabIndex = 22;
            // 
            // pnlAppointmants
            // 
            this.pnlAppointmants.Controls.Add(this.lblWarning);
            this.pnlAppointmants.Controls.Add(this.btnLogin);
            this.pnlAppointmants.Controls.Add(this.cuiPictureBox2);
            this.pnlAppointmants.Controls.Add(this.cuiPictureBox1);
            this.pnlAppointmants.Controls.Add(this.ctrlPassword1);
            this.pnlAppointmants.Controls.Add(this.tbxUsername);
            this.pnlAppointmants.Controls.Add(this.cuiLabel4);
            this.pnlAppointmants.GradientAngle = 0F;
            this.pnlAppointmants.Location = new System.Drawing.Point(12, 84);
            this.pnlAppointmants.Name = "pnlAppointmants";
            this.pnlAppointmants.OutlineThickness = 1F;
            this.pnlAppointmants.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlAppointmants.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlAppointmants.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.pnlAppointmants.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.pnlAppointmants.Rounding = new System.Windows.Forms.Padding(15);
            this.pnlAppointmants.Size = new System.Drawing.Size(476, 504);
            this.pnlAppointmants.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.CheckButton = false;
            this.btnLogin.Checked = false;
            this.btnLogin.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLogin.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogin.CheckedImageTint = System.Drawing.Color.White;
            this.btnLogin.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLogin.Content = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.HoverForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverImageTint = System.Drawing.Color.White;
            this.btnLogin.HoverOutline = System.Drawing.Color.White;
            this.btnLogin.Image = null;
            this.btnLogin.ImageAutoCenter = true;
            this.btnLogin.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnLogin.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogin.Location = new System.Drawing.Point(280, 335);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormalBackground = System.Drawing.Color.Transparent;
            this.btnLogin.NormalForeColor = System.Drawing.Color.White;
            this.btnLogin.NormalImageTint = System.Drawing.Color.White;
            this.btnLogin.NormalOutline = System.Drawing.Color.White;
            this.btnLogin.OutlineThickness = 1F;
            this.btnLogin.PressedBackground = System.Drawing.Color.White;
            this.btnLogin.PressedForeColor = System.Drawing.Color.Black;
            this.btnLogin.PressedImageTint = System.Drawing.Color.White;
            this.btnLogin.PressedOutline = System.Drawing.Color.White;
            this.btnLogin.Rounding = new System.Windows.Forms.Padding(19);
            this.btnLogin.Size = new System.Drawing.Size(108, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.TextOffset = new System.Drawing.Point(0, 0);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // lblWarning
            // 
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Content = resources.GetString("lblWarning.Content");
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblWarning.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblWarning.Location = new System.Drawing.Point(12, 399);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(452, 70);
            this.lblWarning.TabIndex = 23;
            this.lblWarning.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.lblWarning.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.pnlAppointmants);
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "frmLogin";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Controls.SetChildIndex(this.pnlAppointmants, 0);
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.pnlBtnClose.ResumeLayout(false);
            this.pnlAppointmants.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiLabel cuiLabel4;
        protected CuoreUI.Controls.cuiTextBox tbxUsername;
        private ctrlPassword ctrlPassword1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiGradientPanel pnlAppointmants;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Controls.cuiButton btnLogin;
        private CuoreUI.Controls.cuiLabel lblWarning;
    }
}