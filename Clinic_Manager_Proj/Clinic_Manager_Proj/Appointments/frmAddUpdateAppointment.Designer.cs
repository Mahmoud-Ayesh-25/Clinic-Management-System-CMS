namespace Clinic_Manager_Proj.Appointments
{
    partial class frmAddUpdateAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateAppointment));
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.btnSaveAppointment = new CuoreUI.Controls.cuiButton();
            this.btnNext = new CuoreUI.Controls.cuiButton();
            this.btnBack = new CuoreUI.Controls.cuiButton();
            this.pnlAppointmentDetails = new CuoreUI.Controls.cuiPanel();
            this.cbxStatus = new CuoreUI.Controls.cuiComboBox();
            this.cbxDoctor = new CuoreUI.Controls.cuiComboBox();
            this.btnAM = new CuoreUI.Controls.cuiButtonGroup();
            this.btnPM = new CuoreUI.Controls.cuiButtonGroup();
            this.cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel6 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.cdpDate = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.tbxMin = new CuoreUI.Controls.cuiTextBox();
            this.tbxHours = new CuoreUI.Controls.cuiTextBox();
            this.tbxNotes = new CuoreUI.Controls.cuiTextBox();
            this.lblID = new CuoreUI.Controls.cuiLabel();
            this.cuiPictureBox6 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox10 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
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
            this.btnMaximized.Location = new System.Drawing.Point(806, 11);
            this.btnMaximized.Visible = false;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMinimized.Location = new System.Drawing.Point(806, 11);
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.appointment__1_;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMainTitle.Content = "Add\\ New\\ Appointment";
            this.lblMainTitle.Size = new System.Drawing.Size(895, 58);
            // 
            // pnlBtnClose
            // 
            this.pnlBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtnClose.Location = new System.Drawing.Point(848, 11);
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Location = new System.Drawing.Point(2000, 0);
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 783);
            this.cuiResizeGrip.TargetForm = null;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.btnSaveAppointment);
            this.cuiPanel1.Controls.Add(this.btnNext);
            this.cuiPanel1.Controls.Add(this.btnBack);
            this.cuiPanel1.Location = new System.Drawing.Point(12, 713);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(28);
            this.cuiPanel1.Size = new System.Drawing.Size(897, 58);
            this.cuiPanel1.TabIndex = 8;
            // 
            // btnSaveAppointment
            // 
            this.btnSaveAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAppointment.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveAppointment.CheckButton = false;
            this.btnSaveAppointment.Checked = false;
            this.btnSaveAppointment.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSaveAppointment.CheckedForeColor = System.Drawing.Color.White;
            this.btnSaveAppointment.CheckedImageTint = System.Drawing.Color.White;
            this.btnSaveAppointment.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSaveAppointment.Content = "Save Appointment";
            this.btnSaveAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAppointment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAppointment.ForeColor = System.Drawing.Color.White;
            this.btnSaveAppointment.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveAppointment.HoverForeColor = System.Drawing.Color.White;
            this.btnSaveAppointment.HoverImageTint = System.Drawing.Color.White;
            this.btnSaveAppointment.HoverOutline = System.Drawing.Color.White;
            this.btnSaveAppointment.Image = null;
            this.btnSaveAppointment.ImageAutoCenter = true;
            this.btnSaveAppointment.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSaveAppointment.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSaveAppointment.Location = new System.Drawing.Point(585, 9);
            this.btnSaveAppointment.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnSaveAppointment.Name = "btnSaveAppointment";
            this.btnSaveAppointment.NormalBackground = System.Drawing.Color.Transparent;
            this.btnSaveAppointment.NormalForeColor = System.Drawing.Color.White;
            this.btnSaveAppointment.NormalImageTint = System.Drawing.Color.White;
            this.btnSaveAppointment.NormalOutline = System.Drawing.Color.White;
            this.btnSaveAppointment.OutlineThickness = 1F;
            this.btnSaveAppointment.PressedBackground = System.Drawing.Color.White;
            this.btnSaveAppointment.PressedForeColor = System.Drawing.Color.Black;
            this.btnSaveAppointment.PressedImageTint = System.Drawing.Color.White;
            this.btnSaveAppointment.PressedOutline = System.Drawing.Color.White;
            this.btnSaveAppointment.Rounding = new System.Windows.Forms.Padding(19);
            this.btnSaveAppointment.Size = new System.Drawing.Size(166, 40);
            this.btnSaveAppointment.TabIndex = 23;
            this.btnSaveAppointment.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSaveAppointment.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSaveAppointment.Visible = false;
            this.btnSaveAppointment.Click += new System.EventHandler(this.btnSaveAppointment_Click);
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
            this.pnlAppointmentDetails.Controls.Add(this.cbxStatus);
            this.pnlAppointmentDetails.Controls.Add(this.cbxDoctor);
            this.pnlAppointmentDetails.Controls.Add(this.btnAM);
            this.pnlAppointmentDetails.Controls.Add(this.btnPM);
            this.pnlAppointmentDetails.Controls.Add(this.cuiLabel3);
            this.pnlAppointmentDetails.Controls.Add(this.cuiLabel4);
            this.pnlAppointmentDetails.Controls.Add(this.cuiLabel2);
            this.pnlAppointmentDetails.Controls.Add(this.cuiLabel6);
            this.pnlAppointmentDetails.Controls.Add(this.cuiLabel5);
            this.pnlAppointmentDetails.Controls.Add(this.cuiLabel1);
            this.pnlAppointmentDetails.Controls.Add(this.cdpDate);
            this.pnlAppointmentDetails.Controls.Add(this.tbxMin);
            this.pnlAppointmentDetails.Controls.Add(this.tbxHours);
            this.pnlAppointmentDetails.Controls.Add(this.tbxNotes);
            this.pnlAppointmentDetails.Controls.Add(this.lblID);
            this.pnlAppointmentDetails.Controls.Add(this.cuiPictureBox6);
            this.pnlAppointmentDetails.Controls.Add(this.cuiPictureBox10);
            this.pnlAppointmentDetails.Controls.Add(this.cuiPictureBox3);
            this.pnlAppointmentDetails.Controls.Add(this.cuiPictureBox4);
            this.pnlAppointmentDetails.Controls.Add(this.cuiPictureBox1);
            this.pnlAppointmentDetails.Controls.Add(this.cuiPictureBox2);
            this.pnlAppointmentDetails.Location = new System.Drawing.Point(12, 82);
            this.pnlAppointmentDetails.Name = "pnlAppointmentDetails";
            this.pnlAppointmentDetails.OutlineThickness = 1F;
            this.pnlAppointmentDetails.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlAppointmentDetails.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.pnlAppointmentDetails.Rounding = new System.Windows.Forms.Padding(15);
            this.pnlAppointmentDetails.Size = new System.Drawing.Size(897, 619);
            this.pnlAppointmentDetails.TabIndex = 9;
            // 
            // cbxStatus
            // 
            this.cbxStatus.AutoScroll = true;
            this.cbxStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbxStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxStatus.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxStatus.ButtonHoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbxStatus.ButtonHoverOutline = System.Drawing.Color.Empty;
            this.cbxStatus.ButtonNormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbxStatus.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cbxStatus.ButtonPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbxStatus.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cbxStatus.DropDownBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbxStatus.DropDownOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxStatus.ExpandArrowColor = System.Drawing.Color.Gray;
            this.cbxStatus.ForeColor = System.Drawing.Color.White;
            this.cbxStatus.Items = new string[] {
        "Scheduled",
        "Completed",
        "Cancelled",
        "No Show"};
            this.cbxStatus.Location = new System.Drawing.Point(191, 176);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.NoSelectionDropdownText = "Empty";
            this.cbxStatus.NoSelectionText = " Scheduled";
            this.cbxStatus.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxStatus.OutlineThickness = 1F;
            this.cbxStatus.Rounding = 17;
            this.cbxStatus.Size = new System.Drawing.Size(175, 35);
            this.cbxStatus.TabIndex = 26;
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
            this.cbxDoctor.NoSelectionText = " Doctor";
            this.cbxDoctor.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxDoctor.OutlineThickness = 1F;
            this.cbxDoctor.Rounding = 17;
            this.cbxDoctor.Size = new System.Drawing.Size(175, 35);
            this.cbxDoctor.TabIndex = 26;
            // 
            // btnAM
            // 
            this.btnAM.BackColor = System.Drawing.Color.Transparent;
            this.btnAM.Checked = true;
            this.btnAM.CheckedBackground = System.Drawing.Color.White;
            this.btnAM.CheckedForeColor = System.Drawing.Color.Black;
            this.btnAM.CheckedImageTint = System.Drawing.Color.Black;
            this.btnAM.CheckedOutline = System.Drawing.Color.White;
            this.btnAM.Content = "AM";
            this.btnAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAM.ForeColor = System.Drawing.Color.White;
            this.btnAM.Group = 1;
            this.btnAM.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAM.HoverForeColor = System.Drawing.Color.White;
            this.btnAM.HoverImageTint = System.Drawing.Color.White;
            this.btnAM.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAM.Image = null;
            this.btnAM.ImageAutoCenter = true;
            this.btnAM.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAM.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAM.Location = new System.Drawing.Point(374, 135);
            this.btnAM.Name = "btnAM";
            this.btnAM.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAM.NormalForeColor = System.Drawing.Color.White;
            this.btnAM.NormalImageTint = System.Drawing.Color.White;
            this.btnAM.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAM.OutlineThickness = 1F;
            this.btnAM.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAM.PressedForeColor = System.Drawing.Color.White;
            this.btnAM.PressedImageTint = System.Drawing.Color.White;
            this.btnAM.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAM.Rounding = new System.Windows.Forms.Padding(17);
            this.btnAM.Size = new System.Drawing.Size(35, 35);
            this.btnAM.TabIndex = 23;
            this.btnAM.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAM.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // btnPM
            // 
            this.btnPM.BackColor = System.Drawing.Color.Transparent;
            this.btnPM.Checked = false;
            this.btnPM.CheckedBackground = System.Drawing.Color.White;
            this.btnPM.CheckedForeColor = System.Drawing.Color.Black;
            this.btnPM.CheckedImageTint = System.Drawing.Color.Black;
            this.btnPM.CheckedOutline = System.Drawing.Color.White;
            this.btnPM.Content = "PM";
            this.btnPM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnPM.ForeColor = System.Drawing.Color.White;
            this.btnPM.Group = 1;
            this.btnPM.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPM.HoverForeColor = System.Drawing.Color.White;
            this.btnPM.HoverImageTint = System.Drawing.Color.White;
            this.btnPM.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPM.Image = null;
            this.btnPM.ImageAutoCenter = true;
            this.btnPM.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnPM.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPM.Location = new System.Drawing.Point(415, 135);
            this.btnPM.Name = "btnPM";
            this.btnPM.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPM.NormalForeColor = System.Drawing.Color.White;
            this.btnPM.NormalImageTint = System.Drawing.Color.White;
            this.btnPM.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPM.OutlineThickness = 1F;
            this.btnPM.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPM.PressedForeColor = System.Drawing.Color.White;
            this.btnPM.PressedImageTint = System.Drawing.Color.White;
            this.btnPM.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPM.Rounding = new System.Windows.Forms.Padding(17);
            this.btnPM.Size = new System.Drawing.Size(35, 35);
            this.btnPM.TabIndex = 24;
            this.btnPM.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPM.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiLabel3
            // 
            this.cuiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel3.Content = "Date";
            this.cuiLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel3.ForeColor = System.Drawing.Color.White;
            this.cuiLabel3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel3.Location = new System.Drawing.Point(53, 93);
            this.cuiLabel3.Name = "cuiLabel3";
            this.cuiLabel3.Size = new System.Drawing.Size(89, 35);
            this.cuiLabel3.TabIndex = 25;
            this.cuiLabel3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel4
            // 
            this.cuiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel4.Content = "Status";
            this.cuiLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel4.ForeColor = System.Drawing.Color.White;
            this.cuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel4.Location = new System.Drawing.Point(53, 176);
            this.cuiLabel4.Name = "cuiLabel4";
            this.cuiLabel4.Size = new System.Drawing.Size(89, 35);
            this.cuiLabel4.TabIndex = 25;
            this.cuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            // cuiLabel6
            // 
            this.cuiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel6.Content = "Time";
            this.cuiLabel6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel6.ForeColor = System.Drawing.Color.White;
            this.cuiLabel6.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel6.Location = new System.Drawing.Point(53, 135);
            this.cuiLabel6.Name = "cuiLabel6";
            this.cuiLabel6.Size = new System.Drawing.Size(89, 35);
            this.cuiLabel6.TabIndex = 25;
            this.cuiLabel6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel5
            // 
            this.cuiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel5.Content = ":";
            this.cuiLabel5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel5.ForeColor = System.Drawing.Color.White;
            this.cuiLabel5.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel5.Location = new System.Drawing.Point(246, 135);
            this.cuiLabel5.Name = "cuiLabel5";
            this.cuiLabel5.Size = new System.Drawing.Size(15, 35);
            this.cuiLabel5.TabIndex = 24;
            this.cuiLabel5.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel1.Content = " ";
            this.cuiLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.ForeColor = System.Drawing.Color.White;
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel1.Location = new System.Drawing.Point(52, 94);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(131, 35);
            this.cuiLabel1.TabIndex = 23;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cdpDate
            // 
            this.cdpDate.BackColor = System.Drawing.Color.Transparent;
            this.cdpDate.Content = new System.DateTime(2025, 12, 2, 0, 0, 0, 0);
            this.cdpDate.EnableThemeChangeButton = true;
            this.cdpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cdpDate.ForeColor = System.Drawing.Color.White;
            this.cdpDate.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cdpDate.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cdpDate.Icon = ((System.Drawing.Image)(resources.GetObject("cdpDate.Icon")));
            this.cdpDate.IconTint = System.Drawing.Color.White;
            this.cdpDate.Location = new System.Drawing.Point(192, 94);
            this.cdpDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cdpDate.Name = "cdpDate";
            this.cdpDate.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cdpDate.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cdpDate.OutlineThickness = 1.5F;
            this.cdpDate.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            this.cdpDate.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cdpDate.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cdpDate.Rounding = 17;
            this.cdpDate.ShowIcon = true;
            this.cdpDate.Size = new System.Drawing.Size(175, 35);
            this.cdpDate.TabIndex = 22;
            this.cdpDate.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Dark;
            // 
            // tbxMin
            // 
            this.tbxMin.BackColor = System.Drawing.Color.Transparent;
            this.tbxMin.BackgroundColor = System.Drawing.Color.Black;
            this.tbxMin.Content = "";
            this.tbxMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxMin.FocusBackgroundColor = System.Drawing.Color.Black;
            this.tbxMin.FocusImageTint = System.Drawing.Color.White;
            this.tbxMin.FocusOutlineColor = System.Drawing.Color.White;
            this.tbxMin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMin.ForeColor = System.Drawing.Color.White;
            this.tbxMin.Image = null;
            this.tbxMin.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxMin.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxMin.Location = new System.Drawing.Point(268, 135);
            this.tbxMin.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMin.Multiline = false;
            this.tbxMin.Name = "tbxMin";
            this.tbxMin.NormalImageTint = System.Drawing.Color.White;
            this.tbxMin.OutlineColor = System.Drawing.Color.Black;
            this.tbxMin.Padding = new System.Windows.Forms.Padding(16, 9, 16, 0);
            this.tbxMin.PasswordChar = false;
            this.tbxMin.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxMin.PlaceholderText = "Minutes";
            this.tbxMin.Rounding = new System.Windows.Forms.Padding(17);
            this.tbxMin.Size = new System.Drawing.Size(98, 35);
            this.tbxMin.TabIndex = 21;
            this.tbxMin.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxMin.UnderlinedStyle = false;
            this.tbxMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHours_KeyPress);
            this.tbxMin.Validating += new System.ComponentModel.CancelEventHandler(this.tbxHours_Validating);
            // 
            // tbxHours
            // 
            this.tbxHours.BackColor = System.Drawing.Color.Transparent;
            this.tbxHours.BackgroundColor = System.Drawing.Color.Black;
            this.tbxHours.Content = "";
            this.tbxHours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxHours.FocusBackgroundColor = System.Drawing.Color.Black;
            this.tbxHours.FocusImageTint = System.Drawing.Color.White;
            this.tbxHours.FocusOutlineColor = System.Drawing.Color.White;
            this.tbxHours.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHours.ForeColor = System.Drawing.Color.White;
            this.tbxHours.Image = null;
            this.tbxHours.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxHours.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxHours.Location = new System.Drawing.Point(141, 135);
            this.tbxHours.Margin = new System.Windows.Forms.Padding(4);
            this.tbxHours.Multiline = false;
            this.tbxHours.Name = "tbxHours";
            this.tbxHours.NormalImageTint = System.Drawing.Color.White;
            this.tbxHours.OutlineColor = System.Drawing.Color.Black;
            this.tbxHours.Padding = new System.Windows.Forms.Padding(16, 9, 16, 0);
            this.tbxHours.PasswordChar = false;
            this.tbxHours.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxHours.PlaceholderText = "Hours";
            this.tbxHours.Rounding = new System.Windows.Forms.Padding(17);
            this.tbxHours.Size = new System.Drawing.Size(98, 35);
            this.tbxHours.TabIndex = 21;
            this.tbxHours.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxHours.UnderlinedStyle = false;
            this.tbxHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHours_KeyPress);
            this.tbxHours.Validating += new System.ComponentModel.CancelEventHandler(this.tbxHours_Validating);
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
            this.tbxNotes.Location = new System.Drawing.Point(53, 217);
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
            this.tbxNotes.Size = new System.Drawing.Size(675, 35);
            this.tbxNotes.TabIndex = 21;
            this.tbxNotes.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxNotes.UnderlinedStyle = false;
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
            // cuiPictureBox6
            // 
            this.cuiPictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox6.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.calendar__3_;
            this.cuiPictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox6.Content = null;
            this.cuiPictureBox6.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox6.Location = new System.Drawing.Point(12, 94);
            this.cuiPictureBox6.Name = "cuiPictureBox6";
            this.cuiPictureBox6.OutlineThickness = 1F;
            this.cuiPictureBox6.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox6.Rotation = 0;
            this.cuiPictureBox6.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox6.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox6.TabIndex = 9;
            // 
            // cuiPictureBox10
            // 
            this.cuiPictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox10.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.clock;
            this.cuiPictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox10.Content = null;
            this.cuiPictureBox10.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox10.Location = new System.Drawing.Point(12, 135);
            this.cuiPictureBox10.Name = "cuiPictureBox10";
            this.cuiPictureBox10.OutlineThickness = 1F;
            this.cuiPictureBox10.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox10.Rotation = 0;
            this.cuiPictureBox10.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox10.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox10.TabIndex = 9;
            // 
            // cuiPictureBox3
            // 
            this.cuiPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox3.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.note;
            this.cuiPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox3.Content = null;
            this.cuiPictureBox3.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox3.Location = new System.Drawing.Point(12, 217);
            this.cuiPictureBox3.Name = "cuiPictureBox3";
            this.cuiPictureBox3.OutlineThickness = 1F;
            this.cuiPictureBox3.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox3.Rotation = 0;
            this.cuiPictureBox3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox3.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox3.TabIndex = 9;
            // 
            // cuiPictureBox4
            // 
            this.cuiPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox4.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.status__1_;
            this.cuiPictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox4.Content = null;
            this.cuiPictureBox4.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox4.Location = new System.Drawing.Point(12, 176);
            this.cuiPictureBox4.Name = "cuiPictureBox4";
            this.cuiPictureBox4.OutlineThickness = 1F;
            this.cuiPictureBox4.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox4.Rotation = 0;
            this.cuiPictureBox4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox4.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox4.TabIndex = 9;
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
            this.ctrlPatientCardWithFilter1.TabIndex = 10;
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // frmAddUpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 783);
            this.Controls.Add(this.cuiPanel1);
            this.Controls.Add(this.pnlAppointmentDetails);
            this.Controls.Add(this.ctrlPatientCardWithFilter1);
            this.MaximumSize = new System.Drawing.Size(921, 783);
            this.MinimumSize = new System.Drawing.Size(921, 783);
            this.Name = "frmAddUpdateAppointment";
            this.Text = "frmAddUpdateAppointment";
            this.Load += new System.EventHandler(this.frmAddUpdateAppointment_Load);
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
        protected CuoreUI.Controls.cuiButton btnSaveAppointment;
        private CuoreUI.Controls.cuiPanel pnlAppointmentDetails;
        private CuoreUI.Controls.cuiButtonGroup btnAM;
        private CuoreUI.Controls.cuiButtonGroup btnPM;
        private CuoreUI.Controls.cuiLabel cuiLabel6;
        private CuoreUI.Controls.cuiLabel cuiLabel5;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiCalendarDatePicker cdpDate;
        protected CuoreUI.Controls.cuiTextBox tbxMin;
        protected CuoreUI.Controls.cuiTextBox tbxHours;
        protected CuoreUI.Controls.cuiTextBox tbxNotes;
        private CuoreUI.Controls.cuiLabel lblID;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox6;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox10;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private Patients.Controls.ctrlPatientCardWithFilter ctrlPatientCardWithFilter1;
        protected CuoreUI.Controls.cuiButton btnNext;
        protected CuoreUI.Controls.cuiButton btnBack;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Controls.cuiComboBox cbxDoctor;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiComboBox cbxStatus;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
    }
}