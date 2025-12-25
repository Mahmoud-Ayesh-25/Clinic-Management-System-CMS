namespace Clinic_Manager_Proj.Users
{
    partial class frmEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditUser));
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.pnlUserDetails = new CuoreUI.Controls.cuiPanel();
            this.cbxPermissions = new CuoreUI.Controls.cuiComboBox();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.schActive = new CuoreUI.Controls.cuiSwitch();
            this.ctrlOldPassword = new Clinic_Manager_Proj.ctrlPassword();
            this.cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.tbxUsername = new CuoreUI.Controls.cuiTextBox();
            this.cuiPictureBox5 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox6 = new CuoreUI.Controls.cuiPictureBox();
            this.lblID = new CuoreUI.Controls.cuiLabel();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.ctrlConfirmPassword = new Clinic_Manager_Proj.ctrlPassword();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            this.schChangePassword = new CuoreUI.Controls.cuiSwitch();
            this.ctrlNewPassword = new Clinic_Manager_Proj.ctrlPassword();
            this.cuiPictureBox7 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox9 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.btnSaveUser = new CuoreUI.Controls.cuiButton();
            this.pnlBtnClose.SuspendLayout();
            this.pnlUserDetails.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.cuiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            this.btnMaximized.Location = new System.Drawing.Point(411, 11);
            this.btnMaximized.Visible = false;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMinimized.Location = new System.Drawing.Point(411, 11);
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.user__4_;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMainTitle.Content = "Edit\\ User";
            this.lblMainTitle.Size = new System.Drawing.Size(500, 58);
            // 
            // pnlBtnClose
            // 
            this.pnlBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtnClose.Location = new System.Drawing.Point(453, 11);
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Location = new System.Drawing.Point(1000, 0);
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 544);
            this.cuiResizeGrip.TargetForm = null;
            this.cuiResizeGrip.Visible = false;
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // pnlUserDetails
            // 
            this.pnlUserDetails.Controls.Add(this.cbxPermissions);
            this.pnlUserDetails.Controls.Add(this.cuiLabel1);
            this.pnlUserDetails.Controls.Add(this.schActive);
            this.pnlUserDetails.Controls.Add(this.ctrlOldPassword);
            this.pnlUserDetails.Controls.Add(this.cuiPictureBox4);
            this.pnlUserDetails.Controls.Add(this.cuiPictureBox3);
            this.pnlUserDetails.Controls.Add(this.tbxUsername);
            this.pnlUserDetails.Controls.Add(this.cuiPictureBox5);
            this.pnlUserDetails.Controls.Add(this.cuiPictureBox6);
            this.pnlUserDetails.Controls.Add(this.lblID);
            this.pnlUserDetails.Controls.Add(this.cuiPictureBox2);
            this.pnlUserDetails.Controls.Add(this.cuiLabel2);
            this.pnlUserDetails.Location = new System.Drawing.Point(12, 82);
            this.pnlUserDetails.Name = "pnlUserDetails";
            this.pnlUserDetails.OutlineThickness = 1F;
            this.pnlUserDetails.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlUserDetails.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.pnlUserDetails.Rounding = new System.Windows.Forms.Padding(15);
            this.pnlUserDetails.Size = new System.Drawing.Size(498, 225);
            this.pnlUserDetails.TabIndex = 5;
            // 
            // cbxPermissions
            // 
            this.cbxPermissions.AutoScroll = true;
            this.cbxPermissions.BackColor = System.Drawing.Color.Transparent;
            this.cbxPermissions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxPermissions.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxPermissions.ButtonHoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbxPermissions.ButtonHoverOutline = System.Drawing.Color.Empty;
            this.cbxPermissions.ButtonNormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbxPermissions.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cbxPermissions.ButtonPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbxPermissions.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cbxPermissions.DropDownBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbxPermissions.DropDownOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxPermissions.ExpandArrowColor = System.Drawing.Color.Gray;
            this.cbxPermissions.ForeColor = System.Drawing.Color.White;
            this.cbxPermissions.Items = new string[] {
        "Admin",
        "Doctor",
        "Receptionist",
        "Accountant"};
            this.cbxPermissions.Location = new System.Drawing.Point(147, 137);
            this.cbxPermissions.Name = "cbxPermissions";
            this.cbxPermissions.NoSelectionDropdownText = "Empty";
            this.cbxPermissions.NoSelectionText = " Admin";
            this.cbxPermissions.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxPermissions.OutlineThickness = 1F;
            this.cbxPermissions.Rounding = 17;
            this.cbxPermissions.Size = new System.Drawing.Size(163, 35);
            this.cbxPermissions.TabIndex = 27;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel1.Content = "Active";
            this.cuiLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.ForeColor = System.Drawing.Color.White;
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel1.Location = new System.Drawing.Point(53, 178);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(48, 35);
            this.cuiLabel1.TabIndex = 26;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // schActive
            // 
            this.schActive.BackColor = System.Drawing.Color.Transparent;
            this.schActive.Checked = true;
            this.schActive.CheckedBackground = System.Drawing.Color.Green;
            this.schActive.CheckedForeground = System.Drawing.Color.White;
            this.schActive.CheckedOutlineColor = System.Drawing.Color.Empty;
            this.schActive.CheckedSymbolColor = System.Drawing.Color.Green;
            this.schActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.schActive.Location = new System.Drawing.Point(104, 183);
            this.schActive.MinimumSize = new System.Drawing.Size(12, 8);
            this.schActive.Name = "schActive";
            this.schActive.OutlineThickness = 1F;
            this.schActive.ShowSymbols = false;
            this.schActive.Size = new System.Drawing.Size(48, 26);
            this.schActive.TabIndex = 25;
            this.schActive.ThumbSizeModifier = new System.Drawing.Size(0, 0);
            this.schActive.UncheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.schActive.UncheckedForeground = System.Drawing.Color.White;
            this.schActive.UncheckedOutlineColor = System.Drawing.Color.Empty;
            this.schActive.UncheckedSymbolColor = System.Drawing.Color.Gray;
            // 
            // ctrlOldPassword
            // 
            this.ctrlOldPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ctrlOldPassword.Content = "";
            this.ctrlOldPassword.Location = new System.Drawing.Point(53, 97);
            this.ctrlOldPassword.Name = "ctrlOldPassword";
            this.ctrlOldPassword.OutLineColor = System.Drawing.Color.Black;
            this.ctrlOldPassword.PlaceHolderColor = System.Drawing.Color.DimGray;
            this.ctrlOldPassword.PlaceHolderText = "Current Password";
            this.ctrlOldPassword.Size = new System.Drawing.Size(257, 35);
            this.ctrlOldPassword.TabIndex = 23;
            this.ctrlOldPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ctrlOldPassword_Validating);
            // 
            // cuiPictureBox4
            // 
            this.cuiPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox4.Content = global::Clinic_Manager_Proj.Properties.Resources.check__3_;
            this.cuiPictureBox4.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox4.Location = new System.Drawing.Point(12, 178);
            this.cuiPictureBox4.Name = "cuiPictureBox4";
            this.cuiPictureBox4.OutlineThickness = 1F;
            this.cuiPictureBox4.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox4.Rotation = 0;
            this.cuiPictureBox4.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox4.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox4.TabIndex = 23;
            // 
            // cuiPictureBox3
            // 
            this.cuiPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox3.Content = global::Clinic_Manager_Proj.Properties.Resources.login__2_;
            this.cuiPictureBox3.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox3.Location = new System.Drawing.Point(12, 137);
            this.cuiPictureBox3.Name = "cuiPictureBox3";
            this.cuiPictureBox3.OutlineThickness = 1F;
            this.cuiPictureBox3.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox3.Rotation = 0;
            this.cuiPictureBox3.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox3.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox3.TabIndex = 23;
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
            this.tbxUsername.Location = new System.Drawing.Point(53, 55);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUsername.Multiline = false;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.NormalImageTint = System.Drawing.Color.White;
            this.tbxUsername.OutlineColor = System.Drawing.Color.Black;
            this.tbxUsername.Padding = new System.Windows.Forms.Padding(16, 9, 16, 0);
            this.tbxUsername.PasswordChar = false;
            this.tbxUsername.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxUsername.PlaceholderText = "Username";
            this.tbxUsername.Rounding = new System.Windows.Forms.Padding(19);
            this.tbxUsername.Size = new System.Drawing.Size(257, 35);
            this.tbxUsername.TabIndex = 22;
            this.tbxUsername.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxUsername.UnderlinedStyle = false;
            this.tbxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbxUsername_Validating);
            // 
            // cuiPictureBox5
            // 
            this.cuiPictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox5.Content = global::Clinic_Manager_Proj.Properties.Resources.password__1_;
            this.cuiPictureBox5.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox5.Location = new System.Drawing.Point(12, 96);
            this.cuiPictureBox5.Name = "cuiPictureBox5";
            this.cuiPictureBox5.OutlineThickness = 1F;
            this.cuiPictureBox5.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox5.Rotation = 0;
            this.cuiPictureBox5.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox5.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox5.TabIndex = 23;
            // 
            // cuiPictureBox6
            // 
            this.cuiPictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox6.Content = global::Clinic_Manager_Proj.Properties.Resources.id_card__1_;
            this.cuiPictureBox6.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox6.Location = new System.Drawing.Point(12, 55);
            this.cuiPictureBox6.Name = "cuiPictureBox6";
            this.cuiPictureBox6.OutlineThickness = 1F;
            this.cuiPictureBox6.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox6.Rotation = 0;
            this.cuiPictureBox6.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox6.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox6.TabIndex = 24;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Content = "ID:\\ ";
            this.lblID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblID.Location = new System.Drawing.Point(53, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(257, 35);
            this.lblID.TabIndex = 3;
            this.lblID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiPictureBox2
            // 
            this.cuiPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox2.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.key_tag;
            this.cuiPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox2.Content = null;
            this.cuiPictureBox2.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox2.Location = new System.Drawing.Point(12, 12);
            this.cuiPictureBox2.Name = "cuiPictureBox2";
            this.cuiPictureBox2.OutlineThickness = 1F;
            this.cuiPictureBox2.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox2.Rotation = 0;
            this.cuiPictureBox2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox2.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox2.TabIndex = 9;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel2.Content = "Permissions";
            this.cuiLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.ForeColor = System.Drawing.Color.White;
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel2.Location = new System.Drawing.Point(53, 137);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(96, 35);
            this.cuiLabel2.TabIndex = 28;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ctrlConfirmPassword
            // 
            this.ctrlConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ctrlConfirmPassword.Content = "";
            this.ctrlConfirmPassword.Enabled = false;
            this.ctrlConfirmPassword.Location = new System.Drawing.Point(53, 94);
            this.ctrlConfirmPassword.Name = "ctrlConfirmPassword";
            this.ctrlConfirmPassword.OutLineColor = System.Drawing.Color.Black;
            this.ctrlConfirmPassword.PlaceHolderColor = System.Drawing.Color.DimGray;
            this.ctrlConfirmPassword.PlaceHolderText = "Confirm Password";
            this.ctrlConfirmPassword.Size = new System.Drawing.Size(257, 35);
            this.ctrlConfirmPassword.TabIndex = 23;
            this.ctrlConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ctrlConfirmPassword_Validating);
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox1.Content = global::Clinic_Manager_Proj.Properties.Resources.password__1_;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox1.Location = new System.Drawing.Point(12, 94);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox1.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox1.TabIndex = 23;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.cuiLabel3);
            this.cuiPanel1.Controls.Add(this.schChangePassword);
            this.cuiPanel1.Controls.Add(this.ctrlNewPassword);
            this.cuiPanel1.Controls.Add(this.ctrlConfirmPassword);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox7);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox1);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox9);
            this.cuiPanel1.Location = new System.Drawing.Point(12, 319);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel1.Size = new System.Drawing.Size(498, 143);
            this.cuiPanel1.TabIndex = 29;
            // 
            // cuiLabel3
            // 
            this.cuiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel3.Content = "Change\\ Password";
            this.cuiLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel3.ForeColor = System.Drawing.Color.White;
            this.cuiLabel3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel3.Location = new System.Drawing.Point(53, 12);
            this.cuiLabel3.Name = "cuiLabel3";
            this.cuiLabel3.Size = new System.Drawing.Size(128, 35);
            this.cuiLabel3.TabIndex = 26;
            this.cuiLabel3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // schChangePassword
            // 
            this.schChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.schChangePassword.Checked = false;
            this.schChangePassword.CheckedBackground = System.Drawing.Color.Green;
            this.schChangePassword.CheckedForeground = System.Drawing.Color.White;
            this.schChangePassword.CheckedOutlineColor = System.Drawing.Color.Empty;
            this.schChangePassword.CheckedSymbolColor = System.Drawing.Color.Green;
            this.schChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.schChangePassword.Location = new System.Drawing.Point(184, 17);
            this.schChangePassword.MinimumSize = new System.Drawing.Size(12, 8);
            this.schChangePassword.Name = "schChangePassword";
            this.schChangePassword.OutlineThickness = 1F;
            this.schChangePassword.ShowSymbols = false;
            this.schChangePassword.Size = new System.Drawing.Size(48, 26);
            this.schChangePassword.TabIndex = 25;
            this.schChangePassword.ThumbSizeModifier = new System.Drawing.Size(0, 0);
            this.schChangePassword.UncheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.schChangePassword.UncheckedForeground = System.Drawing.Color.White;
            this.schChangePassword.UncheckedOutlineColor = System.Drawing.Color.Empty;
            this.schChangePassword.UncheckedSymbolColor = System.Drawing.Color.Gray;
            this.schChangePassword.CheckedChanged += new System.EventHandler(this.schChangePassword_CheckedChanged);
            // 
            // ctrlNewPassword
            // 
            this.ctrlNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ctrlNewPassword.Content = "";
            this.ctrlNewPassword.Enabled = false;
            this.ctrlNewPassword.Location = new System.Drawing.Point(53, 53);
            this.ctrlNewPassword.Name = "ctrlNewPassword";
            this.ctrlNewPassword.OutLineColor = System.Drawing.Color.Black;
            this.ctrlNewPassword.PlaceHolderColor = System.Drawing.Color.DimGray;
            this.ctrlNewPassword.PlaceHolderText = "New Password";
            this.ctrlNewPassword.Size = new System.Drawing.Size(257, 35);
            this.ctrlNewPassword.TabIndex = 23;
            this.ctrlNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ctrlNewPassword_Validating);
            // 
            // cuiPictureBox7
            // 
            this.cuiPictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox7.Content = global::Clinic_Manager_Proj.Properties.Resources.password__1_;
            this.cuiPictureBox7.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox7.Location = new System.Drawing.Point(12, 12);
            this.cuiPictureBox7.Name = "cuiPictureBox7";
            this.cuiPictureBox7.OutlineThickness = 1F;
            this.cuiPictureBox7.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox7.Rotation = 0;
            this.cuiPictureBox7.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox7.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox7.TabIndex = 23;
            // 
            // cuiPictureBox9
            // 
            this.cuiPictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox9.Content = global::Clinic_Manager_Proj.Properties.Resources.password__1_;
            this.cuiPictureBox9.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox9.Location = new System.Drawing.Point(12, 53);
            this.cuiPictureBox9.Name = "cuiPictureBox9";
            this.cuiPictureBox9.OutlineThickness = 1F;
            this.cuiPictureBox9.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox9.Rotation = 0;
            this.cuiPictureBox9.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox9.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox9.TabIndex = 23;
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.Controls.Add(this.btnSaveUser);
            this.cuiPanel2.Location = new System.Drawing.Point(12, 474);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(28);
            this.cuiPanel2.Size = new System.Drawing.Size(498, 58);
            this.cuiPanel2.TabIndex = 29;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveUser.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveUser.CheckButton = false;
            this.btnSaveUser.Checked = false;
            this.btnSaveUser.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSaveUser.CheckedForeColor = System.Drawing.Color.White;
            this.btnSaveUser.CheckedImageTint = System.Drawing.Color.White;
            this.btnSaveUser.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSaveUser.Content = "Save User";
            this.btnSaveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUser.ForeColor = System.Drawing.Color.White;
            this.btnSaveUser.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveUser.HoverForeColor = System.Drawing.Color.White;
            this.btnSaveUser.HoverImageTint = System.Drawing.Color.White;
            this.btnSaveUser.HoverOutline = System.Drawing.Color.White;
            this.btnSaveUser.Image = null;
            this.btnSaveUser.ImageAutoCenter = true;
            this.btnSaveUser.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSaveUser.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSaveUser.Location = new System.Drawing.Point(358, 9);
            this.btnSaveUser.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.NormalBackground = System.Drawing.Color.Transparent;
            this.btnSaveUser.NormalForeColor = System.Drawing.Color.White;
            this.btnSaveUser.NormalImageTint = System.Drawing.Color.White;
            this.btnSaveUser.NormalOutline = System.Drawing.Color.White;
            this.btnSaveUser.OutlineThickness = 1F;
            this.btnSaveUser.PressedBackground = System.Drawing.Color.White;
            this.btnSaveUser.PressedForeColor = System.Drawing.Color.Black;
            this.btnSaveUser.PressedImageTint = System.Drawing.Color.White;
            this.btnSaveUser.PressedOutline = System.Drawing.Color.White;
            this.btnSaveUser.Rounding = new System.Windows.Forms.Padding(19);
            this.btnSaveUser.Size = new System.Drawing.Size(131, 40);
            this.btnSaveUser.TabIndex = 24;
            this.btnSaveUser.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSaveUser.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // frmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 544);
            this.Controls.Add(this.cuiPanel2);
            this.Controls.Add(this.cuiPanel1);
            this.Controls.Add(this.pnlUserDetails);
            this.MaximumSize = new System.Drawing.Size(524, 544);
            this.MinimumSize = new System.Drawing.Size(524, 544);
            this.Name = "frmEditUser";
            this.Text = "frmEditUser";
            this.Load += new System.EventHandler(this.frmEditUser_Load);
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.Controls.SetChildIndex(this.pnlUserDetails, 0);
            this.Controls.SetChildIndex(this.cuiPanel1, 0);
            this.Controls.SetChildIndex(this.cuiPanel2, 0);
            this.pnlBtnClose.ResumeLayout(false);
            this.pnlUserDetails.ResumeLayout(false);
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Controls.cuiPanel pnlUserDetails;
        protected CuoreUI.Controls.cuiComboBox cbxPermissions;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiSwitch schActive;
        private ctrlPassword ctrlConfirmPassword;
        private ctrlPassword ctrlOldPassword;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        protected CuoreUI.Controls.cuiTextBox tbxUsername;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox5;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox6;
        private CuoreUI.Controls.cuiLabel lblID;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiSwitch schChangePassword;
        private ctrlPassword ctrlNewPassword;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox7;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox9;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        protected CuoreUI.Controls.cuiButton btnSaveUser;
    }
}