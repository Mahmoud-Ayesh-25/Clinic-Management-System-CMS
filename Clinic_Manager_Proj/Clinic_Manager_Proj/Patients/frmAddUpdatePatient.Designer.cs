namespace Clinic_Manager_Proj.Patients
{
    partial class frmAddUpdatePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdatePatient));
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.btnSaveUser = new CuoreUI.Controls.cuiButton();
            this.btnNext = new CuoreUI.Controls.cuiButton();
            this.btnBack = new CuoreUI.Controls.cuiButton();
            this.ctrlPersonCardWithSearch1 = new Clinic_Manager_Proj.People.Controls.ctrlPersonCardWithSearch();
            this.pnlDoctorDetails = new CuoreUI.Controls.cuiPanel();
            this.cuiLabel7 = new CuoreUI.Controls.cuiLabel();
            this.schActive = new CuoreUI.Controls.cuiSwitch();
            this.tbxNotes = new CuoreUI.Controls.cuiTextBox();
            this.tbxCurrentEducations = new CuoreUI.Controls.cuiTextBox();
            this.tbxChronicDiseases = new CuoreUI.Controls.cuiTextBox();
            this.tbxAllergies = new CuoreUI.Controls.cuiTextBox();
            this.lblID = new CuoreUI.Controls.cuiLabel();
            this.cuiPictureBox12 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox5 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.pnlBtnClose.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.pnlDoctorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
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
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.healthy;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMainTitle.Content = "Add\\ New\\ Patient";
            this.lblMainTitle.Size = new System.Drawing.Size(897, 58);
            // 
            // pnlBtnClose
            // 
            this.pnlBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtnClose.Location = new System.Drawing.Point(850, 11);
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Location = new System.Drawing.Point(2000, 0);
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 504);
            this.cuiResizeGrip.TargetForm = null;
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
            this.cuiPanel1.TabIndex = 8;
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
            this.btnSaveUser.Content = "Save Patient";
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
            // ctrlPersonCardWithSearch1
            // 
            this.ctrlPersonCardWithSearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlPersonCardWithSearch1.Location = new System.Drawing.Point(0, 70);
            this.ctrlPersonCardWithSearch1.Name = "ctrlPersonCardWithSearch1";
            this.ctrlPersonCardWithSearch1.Size = new System.Drawing.Size(921, 364);
            this.ctrlPersonCardWithSearch1.TabIndex = 7;
            // 
            // pnlDoctorDetails
            // 
            this.pnlDoctorDetails.Controls.Add(this.cuiLabel7);
            this.pnlDoctorDetails.Controls.Add(this.schActive);
            this.pnlDoctorDetails.Controls.Add(this.tbxNotes);
            this.pnlDoctorDetails.Controls.Add(this.tbxCurrentEducations);
            this.pnlDoctorDetails.Controls.Add(this.tbxChronicDiseases);
            this.pnlDoctorDetails.Controls.Add(this.tbxAllergies);
            this.pnlDoctorDetails.Controls.Add(this.lblID);
            this.pnlDoctorDetails.Controls.Add(this.cuiPictureBox12);
            this.pnlDoctorDetails.Controls.Add(this.cuiPictureBox5);
            this.pnlDoctorDetails.Controls.Add(this.cuiPictureBox4);
            this.pnlDoctorDetails.Controls.Add(this.cuiPictureBox3);
            this.pnlDoctorDetails.Controls.Add(this.cuiPictureBox1);
            this.pnlDoctorDetails.Controls.Add(this.cuiPictureBox2);
            this.pnlDoctorDetails.Location = new System.Drawing.Point(14, 81);
            this.pnlDoctorDetails.Name = "pnlDoctorDetails";
            this.pnlDoctorDetails.OutlineThickness = 1F;
            this.pnlDoctorDetails.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlDoctorDetails.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.pnlDoctorDetails.Rounding = new System.Windows.Forms.Padding(15);
            this.pnlDoctorDetails.Size = new System.Drawing.Size(897, 340);
            this.pnlDoctorDetails.TabIndex = 9;
            // 
            // cuiLabel7
            // 
            this.cuiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel7.Content = "Active";
            this.cuiLabel7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel7.ForeColor = System.Drawing.Color.White;
            this.cuiLabel7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel7.Location = new System.Drawing.Point(54, 218);
            this.cuiLabel7.Name = "cuiLabel7";
            this.cuiLabel7.Size = new System.Drawing.Size(48, 35);
            this.cuiLabel7.TabIndex = 28;
            this.cuiLabel7.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            this.schActive.Location = new System.Drawing.Point(105, 223);
            this.schActive.MinimumSize = new System.Drawing.Size(12, 8);
            this.schActive.Name = "schActive";
            this.schActive.OutlineThickness = 1F;
            this.schActive.ShowSymbols = false;
            this.schActive.Size = new System.Drawing.Size(48, 26);
            this.schActive.TabIndex = 27;
            this.schActive.ThumbSizeModifier = new System.Drawing.Size(0, 0);
            this.schActive.UncheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.schActive.UncheckedForeground = System.Drawing.Color.White;
            this.schActive.UncheckedOutlineColor = System.Drawing.Color.Empty;
            this.schActive.UncheckedSymbolColor = System.Drawing.Color.Gray;
            // 
            // tbxNotes
            // 
            this.tbxNotes.BackColor = System.Drawing.Color.Transparent;
            this.tbxNotes.BackgroundColor = System.Drawing.Color.Black;
            this.tbxNotes.Content = "";
            this.tbxNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNotes.FocusBackgroundColor = System.Drawing.Color.Black;
            this.tbxNotes.FocusImageTint = System.Drawing.Color.White;
            this.tbxNotes.FocusOutlineColor = System.Drawing.Color.White;
            this.tbxNotes.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNotes.ForeColor = System.Drawing.Color.White;
            this.tbxNotes.Image = null;
            this.tbxNotes.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxNotes.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxNotes.Location = new System.Drawing.Point(53, 176);
            this.tbxNotes.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNotes.Multiline = false;
            this.tbxNotes.Name = "tbxNotes";
            this.tbxNotes.NormalImageTint = System.Drawing.Color.White;
            this.tbxNotes.OutlineColor = System.Drawing.Color.Black;
            this.tbxNotes.Padding = new System.Windows.Forms.Padding(16, 9, 16, 0);
            this.tbxNotes.PasswordChar = false;
            this.tbxNotes.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxNotes.PlaceholderText = "Notes";
            this.tbxNotes.Rounding = new System.Windows.Forms.Padding(17);
            this.tbxNotes.Size = new System.Drawing.Size(674, 35);
            this.tbxNotes.TabIndex = 21;
            this.tbxNotes.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxNotes.UnderlinedStyle = false;
            // 
            // tbxCurrentEducations
            // 
            this.tbxCurrentEducations.BackColor = System.Drawing.Color.Transparent;
            this.tbxCurrentEducations.BackgroundColor = System.Drawing.Color.Black;
            this.tbxCurrentEducations.Content = "";
            this.tbxCurrentEducations.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxCurrentEducations.FocusBackgroundColor = System.Drawing.Color.Black;
            this.tbxCurrentEducations.FocusImageTint = System.Drawing.Color.White;
            this.tbxCurrentEducations.FocusOutlineColor = System.Drawing.Color.White;
            this.tbxCurrentEducations.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCurrentEducations.ForeColor = System.Drawing.Color.White;
            this.tbxCurrentEducations.Image = null;
            this.tbxCurrentEducations.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxCurrentEducations.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxCurrentEducations.Location = new System.Drawing.Point(53, 135);
            this.tbxCurrentEducations.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCurrentEducations.Multiline = false;
            this.tbxCurrentEducations.Name = "tbxCurrentEducations";
            this.tbxCurrentEducations.NormalImageTint = System.Drawing.Color.White;
            this.tbxCurrentEducations.OutlineColor = System.Drawing.Color.Black;
            this.tbxCurrentEducations.Padding = new System.Windows.Forms.Padding(16, 9, 16, 0);
            this.tbxCurrentEducations.PasswordChar = false;
            this.tbxCurrentEducations.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxCurrentEducations.PlaceholderText = "Current Medications";
            this.tbxCurrentEducations.Rounding = new System.Windows.Forms.Padding(17);
            this.tbxCurrentEducations.Size = new System.Drawing.Size(674, 35);
            this.tbxCurrentEducations.TabIndex = 21;
            this.tbxCurrentEducations.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxCurrentEducations.UnderlinedStyle = false;
            // 
            // tbxChronicDiseases
            // 
            this.tbxChronicDiseases.BackColor = System.Drawing.Color.Transparent;
            this.tbxChronicDiseases.BackgroundColor = System.Drawing.Color.Black;
            this.tbxChronicDiseases.Content = "";
            this.tbxChronicDiseases.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxChronicDiseases.FocusBackgroundColor = System.Drawing.Color.Black;
            this.tbxChronicDiseases.FocusImageTint = System.Drawing.Color.White;
            this.tbxChronicDiseases.FocusOutlineColor = System.Drawing.Color.White;
            this.tbxChronicDiseases.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxChronicDiseases.ForeColor = System.Drawing.Color.White;
            this.tbxChronicDiseases.Image = null;
            this.tbxChronicDiseases.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxChronicDiseases.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxChronicDiseases.Location = new System.Drawing.Point(53, 94);
            this.tbxChronicDiseases.Margin = new System.Windows.Forms.Padding(4);
            this.tbxChronicDiseases.Multiline = false;
            this.tbxChronicDiseases.Name = "tbxChronicDiseases";
            this.tbxChronicDiseases.NormalImageTint = System.Drawing.Color.White;
            this.tbxChronicDiseases.OutlineColor = System.Drawing.Color.Black;
            this.tbxChronicDiseases.Padding = new System.Windows.Forms.Padding(16, 9, 16, 0);
            this.tbxChronicDiseases.PasswordChar = false;
            this.tbxChronicDiseases.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxChronicDiseases.PlaceholderText = "Chronic Diseases";
            this.tbxChronicDiseases.Rounding = new System.Windows.Forms.Padding(17);
            this.tbxChronicDiseases.Size = new System.Drawing.Size(674, 35);
            this.tbxChronicDiseases.TabIndex = 21;
            this.tbxChronicDiseases.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxChronicDiseases.UnderlinedStyle = false;
            // 
            // tbxAllergies
            // 
            this.tbxAllergies.BackColor = System.Drawing.Color.Transparent;
            this.tbxAllergies.BackgroundColor = System.Drawing.Color.Black;
            this.tbxAllergies.Content = "";
            this.tbxAllergies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxAllergies.FocusBackgroundColor = System.Drawing.Color.Black;
            this.tbxAllergies.FocusImageTint = System.Drawing.Color.White;
            this.tbxAllergies.FocusOutlineColor = System.Drawing.Color.White;
            this.tbxAllergies.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAllergies.ForeColor = System.Drawing.Color.White;
            this.tbxAllergies.Image = null;
            this.tbxAllergies.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxAllergies.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxAllergies.Location = new System.Drawing.Point(53, 53);
            this.tbxAllergies.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAllergies.Multiline = false;
            this.tbxAllergies.Name = "tbxAllergies";
            this.tbxAllergies.NormalImageTint = System.Drawing.Color.White;
            this.tbxAllergies.OutlineColor = System.Drawing.Color.Black;
            this.tbxAllergies.Padding = new System.Windows.Forms.Padding(16, 9, 16, 0);
            this.tbxAllergies.PasswordChar = false;
            this.tbxAllergies.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxAllergies.PlaceholderText = "Allergies";
            this.tbxAllergies.Rounding = new System.Windows.Forms.Padding(17);
            this.tbxAllergies.Size = new System.Drawing.Size(674, 35);
            this.tbxAllergies.TabIndex = 21;
            this.tbxAllergies.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxAllergies.UnderlinedStyle = false;
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
            // cuiPictureBox12
            // 
            this.cuiPictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox12.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.check__3_;
            this.cuiPictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox12.Content = null;
            this.cuiPictureBox12.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox12.Location = new System.Drawing.Point(12, 217);
            this.cuiPictureBox12.Name = "cuiPictureBox12";
            this.cuiPictureBox12.OutlineThickness = 1F;
            this.cuiPictureBox12.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox12.Rotation = 0;
            this.cuiPictureBox12.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox12.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox12.TabIndex = 9;
            // 
            // cuiPictureBox5
            // 
            this.cuiPictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox5.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.note;
            this.cuiPictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox5.Content = null;
            this.cuiPictureBox5.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox5.Location = new System.Drawing.Point(12, 176);
            this.cuiPictureBox5.Name = "cuiPictureBox5";
            this.cuiPictureBox5.OutlineThickness = 1F;
            this.cuiPictureBox5.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox5.Rotation = 0;
            this.cuiPictureBox5.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox5.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox5.TabIndex = 9;
            // 
            // cuiPictureBox4
            // 
            this.cuiPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox4.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.medicine;
            this.cuiPictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox4.Content = null;
            this.cuiPictureBox4.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox4.Location = new System.Drawing.Point(12, 135);
            this.cuiPictureBox4.Name = "cuiPictureBox4";
            this.cuiPictureBox4.OutlineThickness = 1F;
            this.cuiPictureBox4.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox4.Rotation = 0;
            this.cuiPictureBox4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox4.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox4.TabIndex = 9;
            // 
            // cuiPictureBox3
            // 
            this.cuiPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox3.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.worm;
            this.cuiPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox3.Content = null;
            this.cuiPictureBox3.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox3.Location = new System.Drawing.Point(12, 94);
            this.cuiPictureBox3.Name = "cuiPictureBox3";
            this.cuiPictureBox3.OutlineThickness = 1F;
            this.cuiPictureBox3.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox3.Rotation = 0;
            this.cuiPictureBox3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox3.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox3.TabIndex = 9;
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox1.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.bacteria;
            this.cuiPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox1.Content = null;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox1.Location = new System.Drawing.Point(12, 53);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox1.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox1.TabIndex = 9;
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
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // frmAddUpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 504);
            this.Controls.Add(this.cuiPanel1);
            this.Controls.Add(this.pnlDoctorDetails);
            this.Controls.Add(this.ctrlPersonCardWithSearch1);
            this.MaximumSize = new System.Drawing.Size(921, 504);
            this.MinimumSize = new System.Drawing.Size(921, 504);
            this.Name = "frmAddUpdatePatient";
            this.Text = "frmAddUpdatePatient";
            this.Load += new System.EventHandler(this.frmAddUpdatePatient_Load);
            this.Controls.SetChildIndex(this.ctrlPersonCardWithSearch1, 0);
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.Controls.SetChildIndex(this.pnlDoctorDetails, 0);
            this.Controls.SetChildIndex(this.cuiPanel1, 0);
            this.pnlBtnClose.ResumeLayout(false);
            this.cuiPanel1.ResumeLayout(false);
            this.pnlDoctorDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        protected CuoreUI.Controls.cuiButton btnSaveUser;
        protected CuoreUI.Controls.cuiButton btnNext;
        protected CuoreUI.Controls.cuiButton btnBack;
        private People.Controls.ctrlPersonCardWithSearch ctrlPersonCardWithSearch1;
        private CuoreUI.Controls.cuiPanel pnlDoctorDetails;
        private CuoreUI.Controls.cuiLabel cuiLabel7;
        private CuoreUI.Controls.cuiSwitch schActive;
        protected CuoreUI.Controls.cuiTextBox tbxChronicDiseases;
        protected CuoreUI.Controls.cuiTextBox tbxAllergies;
        private CuoreUI.Controls.cuiLabel lblID;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox12;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        protected CuoreUI.Controls.cuiTextBox tbxNotes;
        protected CuoreUI.Controls.cuiTextBox tbxCurrentEducations;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox5;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
    }
}