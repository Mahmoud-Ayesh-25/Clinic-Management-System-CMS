namespace Clinic_Manager_Proj.Users
{
    partial class frmAddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewUser));
            this.ctrlPersonCardWithSearch1 = new Clinic_Manager_Proj.People.Controls.ctrlPersonCardWithSearch();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.btnSaveUser = new CuoreUI.Controls.cuiButton();
            this.btnNext = new CuoreUI.Controls.cuiButton();
            this.btnBack = new CuoreUI.Controls.cuiButton();
            this.pnlUserDetails = new CuoreUI.Controls.cuiPanel();
            this.cbxPermissions = new CuoreUI.Controls.cuiComboBox();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.schActive = new CuoreUI.Controls.cuiSwitch();
            this.ctrlConfirmPassword = new Clinic_Manager_Proj.ctrlPassword();
            this.ctrlPassword = new Clinic_Manager_Proj.ctrlPassword();
            this.cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.tbxUsername = new CuoreUI.Controls.cuiTextBox();
            this.cuiPictureBox5 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox6 = new CuoreUI.Controls.cuiPictureBox();
            this.lblID = new CuoreUI.Controls.cuiLabel();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.pnlBtnClose.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.pnlUserDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMaximized
            // 
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            this.btnMaximized.Location = new System.Drawing.Point(808, 11);
            this.btnMaximized.Visible = false;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMinimized.Location = new System.Drawing.Point(808, 11);
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.user__4_;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMainTitle.Content = "Add\\ New\\ User";
            this.lblMainTitle.Size = new System.Drawing.Size(897, 58);
            // 
            // pnlBtnClose
            // 
            this.pnlBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtnClose.Location = new System.Drawing.Point(850, 11);
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Location = new System.Drawing.Point(909, 0);
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 504);
            // 
            // ctrlPersonCardWithSearch1
            // 
            this.ctrlPersonCardWithSearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlPersonCardWithSearch1.Location = new System.Drawing.Point(0, 70);
            this.ctrlPersonCardWithSearch1.Name = "ctrlPersonCardWithSearch1";
            this.ctrlPersonCardWithSearch1.Size = new System.Drawing.Size(921, 364);
            this.ctrlPersonCardWithSearch1.TabIndex = 2;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.btnSaveUser);
            this.cuiPanel1.Controls.Add(this.btnNext);
            this.cuiPanel1.Controls.Add(this.btnBack);
            this.cuiPanel1.Location = new System.Drawing.Point(12, 434);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(28);
            this.cuiPanel1.Size = new System.Drawing.Size(897, 58);
            this.cuiPanel1.TabIndex = 3;
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
            this.btnSaveUser.Location = new System.Drawing.Point(620, 8);
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
            this.btnSaveUser.TabIndex = 23;
            this.btnSaveUser.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSaveUser.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSaveUser.Visible = false;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.CheckButton = false;
            this.btnNext.Checked = false;
            this.btnNext.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnNext.CheckedForeColor = System.Drawing.Color.White;
            this.btnNext.CheckedImageTint = System.Drawing.Color.White;
            this.btnNext.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnNext.Content = "Next";
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNext.HoverForeColor = System.Drawing.Color.White;
            this.btnNext.HoverImageTint = System.Drawing.Color.White;
            this.btnNext.HoverOutline = System.Drawing.Color.White;
            this.btnNext.Image = null;
            this.btnNext.ImageAutoCenter = true;
            this.btnNext.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnNext.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNext.Location = new System.Drawing.Point(757, 8);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.NormalBackground = System.Drawing.Color.Transparent;
            this.btnNext.NormalForeColor = System.Drawing.Color.White;
            this.btnNext.NormalImageTint = System.Drawing.Color.White;
            this.btnNext.NormalOutline = System.Drawing.Color.White;
            this.btnNext.OutlineThickness = 1F;
            this.btnNext.PressedBackground = System.Drawing.Color.White;
            this.btnNext.PressedForeColor = System.Drawing.Color.Black;
            this.btnNext.PressedImageTint = System.Drawing.Color.White;
            this.btnNext.PressedOutline = System.Drawing.Color.White;
            this.btnNext.Rounding = new System.Windows.Forms.Padding(19);
            this.btnNext.Size = new System.Drawing.Size(131, 40);
            this.btnNext.TabIndex = 23;
            this.btnNext.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnNext.TextOffset = new System.Drawing.Point(0, 0);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.CheckButton = false;
            this.btnBack.Checked = false;
            this.btnBack.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBack.CheckedForeColor = System.Drawing.Color.White;
            this.btnBack.CheckedImageTint = System.Drawing.Color.White;
            this.btnBack.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBack.Content = "Back";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBack.HoverForeColor = System.Drawing.Color.White;
            this.btnBack.HoverImageTint = System.Drawing.Color.White;
            this.btnBack.HoverOutline = System.Drawing.Color.White;
            this.btnBack.Image = null;
            this.btnBack.ImageAutoCenter = true;
            this.btnBack.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBack.Location = new System.Drawing.Point(757, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.NormalBackground = System.Drawing.Color.Transparent;
            this.btnBack.NormalForeColor = System.Drawing.Color.White;
            this.btnBack.NormalImageTint = System.Drawing.Color.White;
            this.btnBack.NormalOutline = System.Drawing.Color.White;
            this.btnBack.OutlineThickness = 1F;
            this.btnBack.PressedBackground = System.Drawing.Color.White;
            this.btnBack.PressedForeColor = System.Drawing.Color.Black;
            this.btnBack.PressedImageTint = System.Drawing.Color.White;
            this.btnBack.PressedOutline = System.Drawing.Color.White;
            this.btnBack.Rounding = new System.Windows.Forms.Padding(19);
            this.btnBack.Size = new System.Drawing.Size(131, 40);
            this.btnBack.TabIndex = 23;
            this.btnBack.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBack.TextOffset = new System.Drawing.Point(0, 0);
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlUserDetails
            // 
            this.pnlUserDetails.Controls.Add(this.cbxPermissions);
            this.pnlUserDetails.Controls.Add(this.cuiLabel1);
            this.pnlUserDetails.Controls.Add(this.schActive);
            this.pnlUserDetails.Controls.Add(this.ctrlConfirmPassword);
            this.pnlUserDetails.Controls.Add(this.ctrlPassword);
            this.pnlUserDetails.Controls.Add(this.cuiPictureBox4);
            this.pnlUserDetails.Controls.Add(this.cuiPictureBox3);
            this.pnlUserDetails.Controls.Add(this.cuiPictureBox1);
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
            this.pnlUserDetails.Size = new System.Drawing.Size(897, 340);
            this.pnlUserDetails.TabIndex = 4;
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
            this.cbxPermissions.Location = new System.Drawing.Point(147, 178);
            this.cbxPermissions.Name = "cbxPermissions";
            this.cbxPermissions.NoSelectionDropdownText = "Empty";
            this.cbxPermissions.NoSelectionText = " ";
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
            this.cuiLabel1.Location = new System.Drawing.Point(53, 219);
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
            this.schActive.Location = new System.Drawing.Point(104, 224);
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
            // ctrlConfirmPassword
            // 
            this.ctrlConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ctrlConfirmPassword.Content = "";
            this.ctrlConfirmPassword.Location = new System.Drawing.Point(53, 137);
            this.ctrlConfirmPassword.Name = "ctrlConfirmPassword";
            this.ctrlConfirmPassword.OutLineColor = System.Drawing.Color.Black;
            this.ctrlConfirmPassword.PlaceHolderColor = System.Drawing.Color.DimGray;
            this.ctrlConfirmPassword.PlaceHolderText = "Confirm Password";
            this.ctrlConfirmPassword.Size = new System.Drawing.Size(257, 35);
            this.ctrlConfirmPassword.TabIndex = 23;
            this.ctrlConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ctrlConfirmPassword_Validating);
            // 
            // ctrlPassword
            // 
            this.ctrlPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ctrlPassword.Content = "";
            this.ctrlPassword.Location = new System.Drawing.Point(53, 97);
            this.ctrlPassword.Name = "ctrlPassword";
            this.ctrlPassword.OutLineColor = System.Drawing.Color.Black;
            this.ctrlPassword.PlaceHolderColor = System.Drawing.Color.DimGray;
            this.ctrlPassword.PlaceHolderText = "Password";
            this.ctrlPassword.Size = new System.Drawing.Size(257, 35);
            this.ctrlPassword.TabIndex = 23;
            this.ctrlPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ctrlPassword1_Validating);
            // 
            // cuiPictureBox4
            // 
            this.cuiPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox4.Content = global::Clinic_Manager_Proj.Properties.Resources.check__3_;
            this.cuiPictureBox4.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox4.Location = new System.Drawing.Point(12, 219);
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
            this.cuiPictureBox3.Location = new System.Drawing.Point(12, 178);
            this.cuiPictureBox3.Name = "cuiPictureBox3";
            this.cuiPictureBox3.OutlineThickness = 1F;
            this.cuiPictureBox3.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox3.Rotation = 0;
            this.cuiPictureBox3.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox3.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox3.TabIndex = 23;
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox1.Content = global::Clinic_Manager_Proj.Properties.Resources.password__1_;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox1.Location = new System.Drawing.Point(12, 137);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox1.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox1.TabIndex = 23;
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
            this.lblID.Size = new System.Drawing.Size(314, 35);
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
            this.cuiLabel2.Location = new System.Drawing.Point(53, 178);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(96, 35);
            this.cuiLabel2.TabIndex = 28;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 504);
            this.Controls.Add(this.cuiPanel1);
            this.Controls.Add(this.ctrlPersonCardWithSearch1);
            this.Controls.Add(this.pnlUserDetails);
            this.MaximumSize = new System.Drawing.Size(921, 504);
            this.MinimumSize = new System.Drawing.Size(921, 504);
            this.Name = "frmAddNewUser";
            this.Text = "frmAddNewUser";
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            this.Controls.SetChildIndex(this.pnlUserDetails, 0);
            this.Controls.SetChildIndex(this.ctrlPersonCardWithSearch1, 0);
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.Controls.SetChildIndex(this.cuiPanel1, 0);
            this.pnlBtnClose.ResumeLayout(false);
            this.cuiPanel1.ResumeLayout(false);
            this.pnlUserDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.ctrlPersonCardWithSearch ctrlPersonCardWithSearch1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        protected CuoreUI.Controls.cuiButton btnNext;
        protected CuoreUI.Controls.cuiButton btnBack;
        private CuoreUI.Controls.cuiPanel pnlUserDetails;
        private CuoreUI.Controls.cuiLabel lblID;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox5;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox6;
        protected CuoreUI.Controls.cuiButton btnSaveUser;
        protected CuoreUI.Controls.cuiTextBox tbxUsername;
        private ctrlPassword ctrlPassword;
        private ctrlPassword ctrlConfirmPassword;
        private CuoreUI.Controls.cuiSwitch schActive;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        protected CuoreUI.Controls.cuiComboBox cbxPermissions;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
    }
}