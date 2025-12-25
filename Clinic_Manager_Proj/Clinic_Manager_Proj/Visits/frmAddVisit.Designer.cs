namespace Clinic_Manager_Proj.Visits
{
    partial class frmAddVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddVisit));
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.btnSaveVisit = new CuoreUI.Controls.cuiButton();
            this.btnNext = new CuoreUI.Controls.cuiButton();
            this.btnBack = new CuoreUI.Controls.cuiButton();
            this.pnlAppointmentDetails = new CuoreUI.Controls.cuiPanel();
            this.cuiLabel7 = new CuoreUI.Controls.cuiLabel();
            this.schEMERG = new CuoreUI.Controls.cuiSwitch();
            this.cuiPictureBox12 = new CuoreUI.Controls.cuiPictureBox();
            this.cbxPaymentMethod = new CuoreUI.Controls.cuiComboBox();
            this.cbxVisitReason = new CuoreUI.Controls.cuiComboBox();
            this.cbxDoctor = new CuoreUI.Controls.cuiComboBox();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel8 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.tbxPaid = new CuoreUI.Controls.cuiTextBox();
            this.lblAID = new CuoreUI.Controls.cuiLabel();
            this.lblPayment = new CuoreUI.Controls.cuiLabel();
            this.lblVID = new CuoreUI.Controls.cuiLabel();
            this.cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox6 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox7 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox5 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.ctrlPatientCardWithFilter1 = new Clinic_Manager_Proj.Patients.Controls.ctrlPatientCardWithFilter();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.pnlBtnClose.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.pnlAppointmentDetails.SuspendLayout();
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
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.doctor_visit;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMainTitle.Content = "Add\\ New\\ Visit";
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
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 783);
            this.cuiResizeGrip.TargetForm = null;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.btnSaveVisit);
            this.cuiPanel1.Controls.Add(this.btnNext);
            this.cuiPanel1.Controls.Add(this.btnBack);
            this.cuiPanel1.Location = new System.Drawing.Point(12, 713);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(28);
            this.cuiPanel1.Size = new System.Drawing.Size(897, 58);
            this.cuiPanel1.TabIndex = 11;
            // 
            // btnSaveVisit
            // 
            this.btnSaveVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveVisit.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveVisit.CheckButton = false;
            this.btnSaveVisit.Checked = false;
            this.btnSaveVisit.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSaveVisit.CheckedForeColor = System.Drawing.Color.White;
            this.btnSaveVisit.CheckedImageTint = System.Drawing.Color.White;
            this.btnSaveVisit.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSaveVisit.Content = "Save Visit";
            this.btnSaveVisit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveVisit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveVisit.ForeColor = System.Drawing.Color.White;
            this.btnSaveVisit.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveVisit.HoverForeColor = System.Drawing.Color.White;
            this.btnSaveVisit.HoverImageTint = System.Drawing.Color.White;
            this.btnSaveVisit.HoverOutline = System.Drawing.Color.White;
            this.btnSaveVisit.Image = null;
            this.btnSaveVisit.ImageAutoCenter = true;
            this.btnSaveVisit.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSaveVisit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSaveVisit.Location = new System.Drawing.Point(585, 9);
            this.btnSaveVisit.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnSaveVisit.Name = "btnSaveVisit";
            this.btnSaveVisit.NormalBackground = System.Drawing.Color.Transparent;
            this.btnSaveVisit.NormalForeColor = System.Drawing.Color.White;
            this.btnSaveVisit.NormalImageTint = System.Drawing.Color.White;
            this.btnSaveVisit.NormalOutline = System.Drawing.Color.White;
            this.btnSaveVisit.OutlineThickness = 1F;
            this.btnSaveVisit.PressedBackground = System.Drawing.Color.White;
            this.btnSaveVisit.PressedForeColor = System.Drawing.Color.Black;
            this.btnSaveVisit.PressedImageTint = System.Drawing.Color.White;
            this.btnSaveVisit.PressedOutline = System.Drawing.Color.White;
            this.btnSaveVisit.Rounding = new System.Windows.Forms.Padding(19);
            this.btnSaveVisit.Size = new System.Drawing.Size(166, 40);
            this.btnSaveVisit.TabIndex = 23;
            this.btnSaveVisit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSaveVisit.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSaveVisit.Visible = false;
            this.btnSaveVisit.Click += new System.EventHandler(this.btnSaveVisit_Click);
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
            this.btnNext.Location = new System.Drawing.Point(757, 9);
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
            this.btnNext.TabIndex = 25;
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
            this.btnBack.Location = new System.Drawing.Point(757, 9);
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
            this.btnBack.TabIndex = 26;
            this.btnBack.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBack.TextOffset = new System.Drawing.Point(0, 0);
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlAppointmentDetails
            // 
            this.pnlAppointmentDetails.Controls.Add(this.cuiLabel7);
            this.pnlAppointmentDetails.Controls.Add(this.schEMERG);
            this.pnlAppointmentDetails.Controls.Add(this.cuiPictureBox12);
            this.pnlAppointmentDetails.Controls.Add(this.cbxPaymentMethod);
            this.pnlAppointmentDetails.Controls.Add(this.cbxVisitReason);
            this.pnlAppointmentDetails.Controls.Add(this.cbxDoctor);
            this.pnlAppointmentDetails.Controls.Add(this.cuiLabel1);
            this.pnlAppointmentDetails.Controls.Add(this.cuiLabel8);
            this.pnlAppointmentDetails.Controls.Add(this.cuiLabel2);
            this.pnlAppointmentDetails.Controls.Add(this.tbxPaid);
            this.pnlAppointmentDetails.Controls.Add(this.lblAID);
            this.pnlAppointmentDetails.Controls.Add(this.lblPayment);
            this.pnlAppointmentDetails.Controls.Add(this.lblVID);
            this.pnlAppointmentDetails.Controls.Add(this.cuiPictureBox4);
            this.pnlAppointmentDetails.Controls.Add(this.cuiPictureBox3);
            this.pnlAppointmentDetails.Controls.Add(this.cuiPictureBox6);
            this.pnlAppointmentDetails.Controls.Add(this.cuiPictureBox7);
            this.pnlAppointmentDetails.Controls.Add(this.cuiPictureBox1);
            this.pnlAppointmentDetails.Controls.Add(this.cuiPictureBox5);
            this.pnlAppointmentDetails.Controls.Add(this.cuiPictureBox2);
            this.pnlAppointmentDetails.Location = new System.Drawing.Point(12, 82);
            this.pnlAppointmentDetails.Name = "pnlAppointmentDetails";
            this.pnlAppointmentDetails.OutlineThickness = 1F;
            this.pnlAppointmentDetails.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlAppointmentDetails.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.pnlAppointmentDetails.Rounding = new System.Windows.Forms.Padding(15);
            this.pnlAppointmentDetails.Size = new System.Drawing.Size(897, 619);
            this.pnlAppointmentDetails.TabIndex = 12;
            // 
            // cuiLabel7
            // 
            this.cuiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel7.Content = "Emergency\\ Income";
            this.cuiLabel7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel7.ForeColor = System.Drawing.Color.White;
            this.cuiLabel7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel7.Location = new System.Drawing.Point(416, 95);
            this.cuiLabel7.Name = "cuiLabel7";
            this.cuiLabel7.Size = new System.Drawing.Size(140, 35);
            this.cuiLabel7.TabIndex = 34;
            this.cuiLabel7.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // schEMERG
            // 
            this.schEMERG.BackColor = System.Drawing.Color.Transparent;
            this.schEMERG.Checked = false;
            this.schEMERG.CheckedBackground = System.Drawing.Color.Green;
            this.schEMERG.CheckedForeground = System.Drawing.Color.White;
            this.schEMERG.CheckedOutlineColor = System.Drawing.Color.Empty;
            this.schEMERG.CheckedSymbolColor = System.Drawing.Color.Green;
            this.schEMERG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.schEMERG.Location = new System.Drawing.Point(560, 100);
            this.schEMERG.MinimumSize = new System.Drawing.Size(12, 8);
            this.schEMERG.Name = "schEMERG";
            this.schEMERG.OutlineThickness = 1F;
            this.schEMERG.ShowSymbols = false;
            this.schEMERG.Size = new System.Drawing.Size(48, 26);
            this.schEMERG.TabIndex = 33;
            this.schEMERG.ThumbSizeModifier = new System.Drawing.Size(0, 0);
            this.schEMERG.UncheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.schEMERG.UncheckedForeground = System.Drawing.Color.White;
            this.schEMERG.UncheckedOutlineColor = System.Drawing.Color.Empty;
            this.schEMERG.UncheckedSymbolColor = System.Drawing.Color.Gray;
            // 
            // cuiPictureBox12
            // 
            this.cuiPictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox12.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.siren;
            this.cuiPictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox12.Content = null;
            this.cuiPictureBox12.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox12.Location = new System.Drawing.Point(374, 94);
            this.cuiPictureBox12.Name = "cuiPictureBox12";
            this.cuiPictureBox12.OutlineThickness = 1F;
            this.cuiPictureBox12.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox12.Rotation = 0;
            this.cuiPictureBox12.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox12.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox12.TabIndex = 32;
            // 
            // cbxPaymentMethod
            // 
            this.cbxPaymentMethod.AutoScroll = true;
            this.cbxPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.cbxPaymentMethod.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxPaymentMethod.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxPaymentMethod.ButtonHoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbxPaymentMethod.ButtonHoverOutline = System.Drawing.Color.Empty;
            this.cbxPaymentMethod.ButtonNormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbxPaymentMethod.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cbxPaymentMethod.ButtonPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbxPaymentMethod.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cbxPaymentMethod.DropDownBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbxPaymentMethod.DropDownOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxPaymentMethod.ExpandArrowColor = System.Drawing.Color.Gray;
            this.cbxPaymentMethod.ForeColor = System.Drawing.Color.White;
            this.cbxPaymentMethod.Items = new string[0];
            this.cbxPaymentMethod.Location = new System.Drawing.Point(553, 135);
            this.cbxPaymentMethod.Name = "cbxPaymentMethod";
            this.cbxPaymentMethod.NoSelectionDropdownText = "Empty";
            this.cbxPaymentMethod.NoSelectionText = " ";
            this.cbxPaymentMethod.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxPaymentMethod.OutlineThickness = 1F;
            this.cbxPaymentMethod.Rounding = 17;
            this.cbxPaymentMethod.Size = new System.Drawing.Size(175, 35);
            this.cbxPaymentMethod.TabIndex = 26;
            // 
            // cbxVisitReason
            // 
            this.cbxVisitReason.AutoScroll = true;
            this.cbxVisitReason.BackColor = System.Drawing.Color.Transparent;
            this.cbxVisitReason.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxVisitReason.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxVisitReason.ButtonHoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbxVisitReason.ButtonHoverOutline = System.Drawing.Color.Empty;
            this.cbxVisitReason.ButtonNormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbxVisitReason.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cbxVisitReason.ButtonPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbxVisitReason.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cbxVisitReason.DropDownBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbxVisitReason.DropDownOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxVisitReason.ExpandArrowColor = System.Drawing.Color.Gray;
            this.cbxVisitReason.ForeColor = System.Drawing.Color.White;
            this.cbxVisitReason.Items = new string[] {
        "New Examination",
        "Follow Up"};
            this.cbxVisitReason.Location = new System.Drawing.Point(553, 53);
            this.cbxVisitReason.Name = "cbxVisitReason";
            this.cbxVisitReason.NoSelectionDropdownText = "Empty";
            this.cbxVisitReason.NoSelectionText = " ";
            this.cbxVisitReason.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxVisitReason.OutlineThickness = 1F;
            this.cbxVisitReason.Rounding = 17;
            this.cbxVisitReason.Size = new System.Drawing.Size(175, 35);
            this.cbxVisitReason.TabIndex = 26;
            this.cbxVisitReason.SelectedIndexChanged += new System.EventHandler(this.cbxVisitReason_SelectedIndexChanged);
            // 
            // cbxDoctor
            // 
            this.cbxDoctor.AutoScroll = true;
            this.cbxDoctor.BackColor = System.Drawing.Color.Transparent;
            this.cbxDoctor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxDoctor.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxDoctor.ButtonHoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbxDoctor.ButtonHoverOutline = System.Drawing.Color.Empty;
            this.cbxDoctor.ButtonNormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbxDoctor.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cbxDoctor.ButtonPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbxDoctor.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cbxDoctor.DropDownBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbxDoctor.DropDownOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxDoctor.ExpandArrowColor = System.Drawing.Color.Gray;
            this.cbxDoctor.ForeColor = System.Drawing.Color.White;
            this.cbxDoctor.Items = new string[0];
            this.cbxDoctor.Location = new System.Drawing.Point(191, 53);
            this.cbxDoctor.Name = "cbxDoctor";
            this.cbxDoctor.NoSelectionDropdownText = "Empty";
            this.cbxDoctor.NoSelectionText = " ";
            this.cbxDoctor.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxDoctor.OutlineThickness = 1F;
            this.cbxDoctor.Rounding = 17;
            this.cbxDoctor.Size = new System.Drawing.Size(175, 35);
            this.cbxDoctor.TabIndex = 26;
            this.cbxDoctor.SelectedIndexChanged += new System.EventHandler(this.cbxDoctor_SelectedIndexChanged);
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel1.Content = "Payment\\ Method";
            this.cuiLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.ForeColor = System.Drawing.Color.White;
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel1.Location = new System.Drawing.Point(415, 135);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(132, 35);
            this.cuiLabel1.TabIndex = 25;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel8
            // 
            this.cuiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel8.Content = "Visit\\ Reason";
            this.cuiLabel8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel8.ForeColor = System.Drawing.Color.White;
            this.cuiLabel8.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel8.Location = new System.Drawing.Point(415, 53);
            this.cuiLabel8.Name = "cuiLabel8";
            this.cuiLabel8.Size = new System.Drawing.Size(98, 35);
            this.cuiLabel8.TabIndex = 25;
            this.cuiLabel8.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel2.Content = "Doctor";
            this.cuiLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.ForeColor = System.Drawing.Color.White;
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel2.Location = new System.Drawing.Point(53, 53);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(89, 35);
            this.cuiLabel2.TabIndex = 25;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tbxPaid
            // 
            this.tbxPaid.BackColor = System.Drawing.Color.Transparent;
            this.tbxPaid.BackgroundColor = System.Drawing.Color.Black;
            this.tbxPaid.Content = "";
            this.tbxPaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPaid.FocusBackgroundColor = System.Drawing.Color.Black;
            this.tbxPaid.FocusImageTint = System.Drawing.Color.White;
            this.tbxPaid.FocusOutlineColor = System.Drawing.Color.White;
            this.tbxPaid.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPaid.ForeColor = System.Drawing.Color.White;
            this.tbxPaid.Image = null;
            this.tbxPaid.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxPaid.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxPaid.Location = new System.Drawing.Point(53, 135);
            this.tbxPaid.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPaid.Multiline = false;
            this.tbxPaid.Name = "tbxPaid";
            this.tbxPaid.NormalImageTint = System.Drawing.Color.White;
            this.tbxPaid.OutlineColor = System.Drawing.Color.Black;
            this.tbxPaid.Padding = new System.Windows.Forms.Padding(16, 9, 16, 0);
            this.tbxPaid.PasswordChar = false;
            this.tbxPaid.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxPaid.PlaceholderText = "Paid Amount";
            this.tbxPaid.Rounding = new System.Windows.Forms.Padding(17);
            this.tbxPaid.Size = new System.Drawing.Size(313, 35);
            this.tbxPaid.TabIndex = 21;
            this.tbxPaid.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxPaid.UnderlinedStyle = false;
            this.tbxPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPaid_KeyPress);
            this.tbxPaid.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPaid_Validating);
            // 
            // lblAID
            // 
            this.lblAID.BackColor = System.Drawing.Color.Transparent;
            this.lblAID.Content = "Appointment\\ ID:";
            this.lblAID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAID.ForeColor = System.Drawing.Color.White;
            this.lblAID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblAID.Location = new System.Drawing.Point(414, 12);
            this.lblAID.Name = "lblAID";
            this.lblAID.Size = new System.Drawing.Size(314, 35);
            this.lblAID.TabIndex = 3;
            this.lblAID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblPayment
            // 
            this.lblPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment.Content = "Payment\\ Amount:";
            this.lblPayment.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.White;
            this.lblPayment.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblPayment.Location = new System.Drawing.Point(52, 94);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(314, 35);
            this.lblPayment.TabIndex = 3;
            this.lblPayment.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblVID
            // 
            this.lblVID.BackColor = System.Drawing.Color.Transparent;
            this.lblVID.Content = "Visit\\ ID:";
            this.lblVID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVID.ForeColor = System.Drawing.Color.White;
            this.lblVID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblVID.Location = new System.Drawing.Point(53, 12);
            this.lblVID.Name = "lblVID";
            this.lblVID.Size = new System.Drawing.Size(314, 35);
            this.lblVID.TabIndex = 3;
            this.lblVID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiPictureBox4
            // 
            this.cuiPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox4.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.dollar;
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
            this.cuiPictureBox3.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.dollar;
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
            // cuiPictureBox6
            // 
            this.cuiPictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox6.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.dollar;
            this.cuiPictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox6.Content = null;
            this.cuiPictureBox6.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox6.Location = new System.Drawing.Point(374, 135);
            this.cuiPictureBox6.Name = "cuiPictureBox6";
            this.cuiPictureBox6.OutlineThickness = 1F;
            this.cuiPictureBox6.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox6.Rotation = 0;
            this.cuiPictureBox6.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox6.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox6.TabIndex = 9;
            // 
            // cuiPictureBox7
            // 
            this.cuiPictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox7.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.question_mark;
            this.cuiPictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox7.Content = null;
            this.cuiPictureBox7.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox7.Location = new System.Drawing.Point(374, 53);
            this.cuiPictureBox7.Name = "cuiPictureBox7";
            this.cuiPictureBox7.OutlineThickness = 1F;
            this.cuiPictureBox7.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox7.Rotation = 0;
            this.cuiPictureBox7.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox7.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox7.TabIndex = 9;
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox1.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.doctor;
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
            // cuiPictureBox5
            // 
            this.cuiPictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox5.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.key_tag;
            this.cuiPictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox5.Content = null;
            this.cuiPictureBox5.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox5.Location = new System.Drawing.Point(373, 12);
            this.cuiPictureBox5.Name = "cuiPictureBox5";
            this.cuiPictureBox5.OutlineThickness = 1F;
            this.cuiPictureBox5.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox5.Rotation = 0;
            this.cuiPictureBox5.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox5.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox5.TabIndex = 9;
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
            // ctrlPatientCardWithFilter1
            // 
            this.ctrlPatientCardWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlPatientCardWithFilter1.Location = new System.Drawing.Point(0, 70);
            this.ctrlPatientCardWithFilter1.Name = "ctrlPatientCardWithFilter1";
            this.ctrlPatientCardWithFilter1.Size = new System.Drawing.Size(921, 643);
            this.ctrlPatientCardWithFilter1.TabIndex = 13;
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // frmAddVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 783);
            this.Controls.Add(this.cuiPanel1);
            this.Controls.Add(this.pnlAppointmentDetails);
            this.Controls.Add(this.ctrlPatientCardWithFilter1);
            this.MaximumSize = new System.Drawing.Size(921, 783);
            this.MinimumSize = new System.Drawing.Size(921, 783);
            this.Name = "frmAddVisit";
            this.Text = "frmAddUpdateVisit";
            this.Load += new System.EventHandler(this.frmAddVisit_Load);
            this.Controls.SetChildIndex(this.ctrlPatientCardWithFilter1, 0);
            this.Controls.SetChildIndex(this.pnlAppointmentDetails, 0);
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.Controls.SetChildIndex(this.cuiPanel1, 0);
            this.pnlBtnClose.ResumeLayout(false);
            this.cuiPanel1.ResumeLayout(false);
            this.pnlAppointmentDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        protected CuoreUI.Controls.cuiButton btnSaveVisit;
        protected CuoreUI.Controls.cuiButton btnNext;
        protected CuoreUI.Controls.cuiButton btnBack;
        private CuoreUI.Controls.cuiPanel pnlAppointmentDetails;
        private CuoreUI.Controls.cuiComboBox cbxDoctor;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel lblVID;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private Patients.Controls.ctrlPatientCardWithFilter ctrlPatientCardWithFilter1;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Controls.cuiLabel lblAID;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox5;
        private CuoreUI.Controls.cuiComboBox cbxVisitReason;
        private CuoreUI.Controls.cuiLabel cuiLabel8;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox7;
        protected CuoreUI.Controls.cuiTextBox tbxPaid;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
        private CuoreUI.Controls.cuiLabel lblPayment;
        private CuoreUI.Controls.cuiComboBox cbxPaymentMethod;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox6;
        private CuoreUI.Controls.cuiLabel cuiLabel7;
        private CuoreUI.Controls.cuiSwitch schEMERG;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox12;
    }
}