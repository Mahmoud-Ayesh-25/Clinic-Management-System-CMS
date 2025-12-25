using System.Windows.Forms;

namespace Clinic_Manager_Proj
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenu = new CuoreUI.Controls.cuiGradientPanel();
            this.cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cbxDoctor = new CuoreUI.Controls.cuiComboBox();
            this.cdpDate = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.flpMenuOptionsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPeopleMang = new CuoreUI.Controls.cuiButton();
            this.btnUsersMang = new CuoreUI.Controls.cuiButton();
            this.btnDoctorsMang = new CuoreUI.Controls.cuiButton();
            this.btnPatientsMang = new CuoreUI.Controls.cuiButton();
            this.btnPaymentsMang = new CuoreUI.Controls.cuiButton();
            this.btnVisitsMang = new CuoreUI.Controls.cuiButton();
            this.btnAppointmantsMang = new CuoreUI.Controls.cuiButton();
            this.btnSettingsMang = new CuoreUI.Controls.cuiButton();
            this.btnLogout = new CuoreUI.Controls.cuiButton();
            this.pnlAppointmants = new CuoreUI.Controls.cuiGradientPanel();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.cuiLabel15 = new CuoreUI.Controls.cuiLabel();
            this.btnAddAppointment = new CuoreUI.Controls.cuiButton();
            this.pnlVisits = new CuoreUI.Controls.cuiGradientPanel();
            this.sepVisits = new CuoreUI.Controls.cuiSeparator();
            this.dgvWaitingVisits = new System.Windows.Forms.DataGridView();
            this.btnAddVisit = new CuoreUI.Controls.cuiButton();
            this.dgvInProgressVisits = new System.Windows.Forms.DataGridView();
            this.lblWatitingVisits = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel17 = new CuoreUI.Controls.cuiLabel();
            this.flpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEmergancyCases = new CuoreUI.Controls.cuiGradientPanel();
            this.lblEmergencyCases = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.pnlCompleteVisits = new CuoreUI.Controls.cuiGradientPanel();
            this.lblCompleteVisits = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            this.pnlUpcommingAppointments = new CuoreUI.Controls.cuiGradientPanel();
            this.lblAppointment = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel6 = new CuoreUI.Controls.cuiLabel();
            this.pnlTodayPatients = new CuoreUI.Controls.cuiGradientPanel();
            this.lblTodayPatients = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel8 = new CuoreUI.Controls.cuiLabel();
            this.pnlRemaining = new CuoreUI.Controls.cuiGradientPanel();
            this.lblRemainingPayments = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel10 = new CuoreUI.Controls.cuiLabel();
            this.pnlNumberOfReceipts = new CuoreUI.Controls.cuiGradientPanel();
            this.lblNumberOfReceipts = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel12 = new CuoreUI.Controls.cuiLabel();
            this.pnlTodayPayments = new CuoreUI.Controls.cuiGradientPanel();
            this.lblTodayPayments = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel14 = new CuoreUI.Controls.cuiLabel();
            this.pnlNotifications = new CuoreUI.Controls.cuiGradientPanel();
            this.lblUnreadableMessage = new CuoreUI.Controls.cuiLabel();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.lblNotifyMessage = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel16 = new CuoreUI.Controls.cuiLabel();
            this.cmsAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.makeVisitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCancelledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNoShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsWaitingVisits = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.setInProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToEmergencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.payToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInProgressVisits = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.payToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NotificationsTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlBtnClose.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.flpMenuOptionsContainer.SuspendLayout();
            this.pnlAppointmants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.pnlVisits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInProgressVisits)).BeginInit();
            this.flpContainer.SuspendLayout();
            this.pnlEmergancyCases.SuspendLayout();
            this.pnlCompleteVisits.SuspendLayout();
            this.pnlUpcommingAppointments.SuspendLayout();
            this.pnlTodayPatients.SuspendLayout();
            this.pnlRemaining.SuspendLayout();
            this.pnlNumberOfReceipts.SuspendLayout();
            this.pnlTodayPayments.SuspendLayout();
            this.pnlNotifications.SuspendLayout();
            this.cmsAppointments.SuspendLayout();
            this.cmsWaitingVisits.SuspendLayout();
            this.cmsInProgressVisits.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMaximized
            // 
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            this.btnMaximized.Visible = false;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Location = new System.Drawing.Point(1343, 11);
            // 
            // btnClose
            // 
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.dashboard__1_;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Content = "Dashboard";
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Location = new System.Drawing.Point(1444, 0);
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 780);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.Controls.Add(this.cuiLabel3);
            this.pnlMenu.Controls.Add(this.cuiLabel2);
            this.pnlMenu.Controls.Add(this.cbxDoctor);
            this.pnlMenu.Controls.Add(this.cdpDate);
            this.pnlMenu.Controls.Add(this.flpMenuOptionsContainer);
            this.pnlMenu.GradientAngle = 0F;
            this.pnlMenu.Location = new System.Drawing.Point(1183, 87);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.OutlineThickness = 1F;
            this.pnlMenu.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlMenu.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlMenu.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.pnlMenu.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.pnlMenu.Rounding = new System.Windows.Forms.Padding(15);
            this.pnlMenu.Size = new System.Drawing.Size(261, 681);
            this.pnlMenu.TabIndex = 2;
            // 
            // cuiLabel3
            // 
            this.cuiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel3.Content = "Data\\ By\\ Doctor\\ :";
            this.cuiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel3.ForeColor = System.Drawing.Color.White;
            this.cuiLabel3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel3.Location = new System.Drawing.Point(20, 105);
            this.cuiLabel3.Name = "cuiLabel3";
            this.cuiLabel3.Size = new System.Drawing.Size(210, 20);
            this.cuiLabel3.TabIndex = 19;
            this.cuiLabel3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel2.Content = "Data\\ By\\ Date\\ :";
            this.cuiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.ForeColor = System.Drawing.Color.White;
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel2.Location = new System.Drawing.Point(20, 20);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(210, 20);
            this.cuiLabel2.TabIndex = 18;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            this.cbxDoctor.Location = new System.Drawing.Point(20, 125);
            this.cbxDoctor.Name = "cbxDoctor";
            this.cbxDoctor.NoSelectionDropdownText = "Empty";
            this.cbxDoctor.NoSelectionText = " Doctor";
            this.cbxDoctor.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxDoctor.OutlineThickness = 1F;
            this.cbxDoctor.Rounding = 22;
            this.cbxDoctor.Size = new System.Drawing.Size(217, 45);
            this.cbxDoctor.TabIndex = 17;
            this.cbxDoctor.SelectedIndexChanged += new System.EventHandler(this.cbxDoctor_SelectedIndexChanged);
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
            this.cdpDate.Location = new System.Drawing.Point(20, 40);
            this.cdpDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cdpDate.Name = "cdpDate";
            this.cdpDate.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cdpDate.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cdpDate.OutlineThickness = 1.5F;
            this.cdpDate.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            this.cdpDate.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cdpDate.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cdpDate.Rounding = 22;
            this.cdpDate.ShowIcon = true;
            this.cdpDate.Size = new System.Drawing.Size(221, 45);
            this.cdpDate.TabIndex = 16;
            this.cdpDate.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Dark;
            this.cdpDate.DateChanged += new System.EventHandler(this.cdpDate_DateChanged);
            // 
            // flpMenuOptionsContainer
            // 
            this.flpMenuOptionsContainer.BackColor = System.Drawing.Color.Transparent;
            this.flpMenuOptionsContainer.Controls.Add(this.btnPeopleMang);
            this.flpMenuOptionsContainer.Controls.Add(this.btnUsersMang);
            this.flpMenuOptionsContainer.Controls.Add(this.btnDoctorsMang);
            this.flpMenuOptionsContainer.Controls.Add(this.btnPatientsMang);
            this.flpMenuOptionsContainer.Controls.Add(this.btnPaymentsMang);
            this.flpMenuOptionsContainer.Controls.Add(this.btnVisitsMang);
            this.flpMenuOptionsContainer.Controls.Add(this.btnAppointmantsMang);
            this.flpMenuOptionsContainer.Controls.Add(this.btnSettingsMang);
            this.flpMenuOptionsContainer.Controls.Add(this.btnLogout);
            this.flpMenuOptionsContainer.Location = new System.Drawing.Point(13, 44);
            this.flpMenuOptionsContainer.Name = "flpMenuOptionsContainer";
            this.flpMenuOptionsContainer.Size = new System.Drawing.Size(232, 627);
            this.flpMenuOptionsContainer.TabIndex = 15;
            // 
            // btnPeopleMang
            // 
            this.btnPeopleMang.BackColor = System.Drawing.Color.Transparent;
            this.btnPeopleMang.CheckButton = false;
            this.btnPeopleMang.Checked = false;
            this.btnPeopleMang.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnPeopleMang.CheckedForeColor = System.Drawing.Color.White;
            this.btnPeopleMang.CheckedImageTint = System.Drawing.Color.White;
            this.btnPeopleMang.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnPeopleMang.Content = "People Management";
            this.btnPeopleMang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeopleMang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPeopleMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeopleMang.ForeColor = System.Drawing.Color.White;
            this.btnPeopleMang.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPeopleMang.HoverForeColor = System.Drawing.Color.White;
            this.btnPeopleMang.HoverImageTint = System.Drawing.Color.White;
            this.btnPeopleMang.HoverOutline = System.Drawing.Color.White;
            this.btnPeopleMang.Image = null;
            this.btnPeopleMang.ImageAutoCenter = true;
            this.btnPeopleMang.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnPeopleMang.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPeopleMang.Location = new System.Drawing.Point(3, 20);
            this.btnPeopleMang.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnPeopleMang.Name = "btnPeopleMang";
            this.btnPeopleMang.NormalBackground = System.Drawing.Color.Transparent;
            this.btnPeopleMang.NormalForeColor = System.Drawing.Color.White;
            this.btnPeopleMang.NormalImageTint = System.Drawing.Color.White;
            this.btnPeopleMang.NormalOutline = System.Drawing.Color.White;
            this.btnPeopleMang.OutlineThickness = 1F;
            this.btnPeopleMang.PressedBackground = System.Drawing.Color.White;
            this.btnPeopleMang.PressedForeColor = System.Drawing.Color.Black;
            this.btnPeopleMang.PressedImageTint = System.Drawing.Color.White;
            this.btnPeopleMang.PressedOutline = System.Drawing.Color.White;
            this.btnPeopleMang.Rounding = new System.Windows.Forms.Padding(22);
            this.btnPeopleMang.Size = new System.Drawing.Size(221, 45);
            this.btnPeopleMang.TabIndex = 14;
            this.btnPeopleMang.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPeopleMang.TextOffset = new System.Drawing.Point(0, 0);
            this.btnPeopleMang.Click += new System.EventHandler(this.btnPeopleMang_Click);
            // 
            // btnUsersMang
            // 
            this.btnUsersMang.BackColor = System.Drawing.Color.Transparent;
            this.btnUsersMang.CheckButton = false;
            this.btnUsersMang.Checked = false;
            this.btnUsersMang.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnUsersMang.CheckedForeColor = System.Drawing.Color.White;
            this.btnUsersMang.CheckedImageTint = System.Drawing.Color.White;
            this.btnUsersMang.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnUsersMang.Content = "Users Management";
            this.btnUsersMang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsersMang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUsersMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersMang.ForeColor = System.Drawing.Color.White;
            this.btnUsersMang.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUsersMang.HoverForeColor = System.Drawing.Color.White;
            this.btnUsersMang.HoverImageTint = System.Drawing.Color.White;
            this.btnUsersMang.HoverOutline = System.Drawing.Color.White;
            this.btnUsersMang.Image = null;
            this.btnUsersMang.ImageAutoCenter = true;
            this.btnUsersMang.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnUsersMang.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnUsersMang.Location = new System.Drawing.Point(3, 88);
            this.btnUsersMang.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnUsersMang.Name = "btnUsersMang";
            this.btnUsersMang.NormalBackground = System.Drawing.Color.Transparent;
            this.btnUsersMang.NormalForeColor = System.Drawing.Color.White;
            this.btnUsersMang.NormalImageTint = System.Drawing.Color.White;
            this.btnUsersMang.NormalOutline = System.Drawing.Color.White;
            this.btnUsersMang.OutlineThickness = 1F;
            this.btnUsersMang.PressedBackground = System.Drawing.Color.White;
            this.btnUsersMang.PressedForeColor = System.Drawing.Color.Black;
            this.btnUsersMang.PressedImageTint = System.Drawing.Color.White;
            this.btnUsersMang.PressedOutline = System.Drawing.Color.White;
            this.btnUsersMang.Rounding = new System.Windows.Forms.Padding(22);
            this.btnUsersMang.Size = new System.Drawing.Size(221, 45);
            this.btnUsersMang.TabIndex = 14;
            this.btnUsersMang.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnUsersMang.TextOffset = new System.Drawing.Point(0, 0);
            this.btnUsersMang.Click += new System.EventHandler(this.btnUsersMang_Click);
            // 
            // btnDoctorsMang
            // 
            this.btnDoctorsMang.BackColor = System.Drawing.Color.Transparent;
            this.btnDoctorsMang.CheckButton = false;
            this.btnDoctorsMang.Checked = false;
            this.btnDoctorsMang.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnDoctorsMang.CheckedForeColor = System.Drawing.Color.White;
            this.btnDoctorsMang.CheckedImageTint = System.Drawing.Color.White;
            this.btnDoctorsMang.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnDoctorsMang.Content = "Doctors Management";
            this.btnDoctorsMang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctorsMang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDoctorsMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorsMang.ForeColor = System.Drawing.Color.White;
            this.btnDoctorsMang.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDoctorsMang.HoverForeColor = System.Drawing.Color.White;
            this.btnDoctorsMang.HoverImageTint = System.Drawing.Color.White;
            this.btnDoctorsMang.HoverOutline = System.Drawing.Color.White;
            this.btnDoctorsMang.Image = null;
            this.btnDoctorsMang.ImageAutoCenter = true;
            this.btnDoctorsMang.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnDoctorsMang.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDoctorsMang.Location = new System.Drawing.Point(3, 156);
            this.btnDoctorsMang.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnDoctorsMang.Name = "btnDoctorsMang";
            this.btnDoctorsMang.NormalBackground = System.Drawing.Color.Transparent;
            this.btnDoctorsMang.NormalForeColor = System.Drawing.Color.White;
            this.btnDoctorsMang.NormalImageTint = System.Drawing.Color.White;
            this.btnDoctorsMang.NormalOutline = System.Drawing.Color.White;
            this.btnDoctorsMang.OutlineThickness = 1F;
            this.btnDoctorsMang.PressedBackground = System.Drawing.Color.White;
            this.btnDoctorsMang.PressedForeColor = System.Drawing.Color.Black;
            this.btnDoctorsMang.PressedImageTint = System.Drawing.Color.White;
            this.btnDoctorsMang.PressedOutline = System.Drawing.Color.White;
            this.btnDoctorsMang.Rounding = new System.Windows.Forms.Padding(22);
            this.btnDoctorsMang.Size = new System.Drawing.Size(221, 45);
            this.btnDoctorsMang.TabIndex = 14;
            this.btnDoctorsMang.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDoctorsMang.TextOffset = new System.Drawing.Point(0, 0);
            this.btnDoctorsMang.Click += new System.EventHandler(this.btnDoctorsMang_Click);
            // 
            // btnPatientsMang
            // 
            this.btnPatientsMang.BackColor = System.Drawing.Color.Transparent;
            this.btnPatientsMang.CheckButton = false;
            this.btnPatientsMang.Checked = false;
            this.btnPatientsMang.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnPatientsMang.CheckedForeColor = System.Drawing.Color.White;
            this.btnPatientsMang.CheckedImageTint = System.Drawing.Color.White;
            this.btnPatientsMang.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnPatientsMang.Content = "Patients Management";
            this.btnPatientsMang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientsMang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPatientsMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientsMang.ForeColor = System.Drawing.Color.White;
            this.btnPatientsMang.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPatientsMang.HoverForeColor = System.Drawing.Color.White;
            this.btnPatientsMang.HoverImageTint = System.Drawing.Color.White;
            this.btnPatientsMang.HoverOutline = System.Drawing.Color.White;
            this.btnPatientsMang.Image = null;
            this.btnPatientsMang.ImageAutoCenter = true;
            this.btnPatientsMang.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnPatientsMang.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPatientsMang.Location = new System.Drawing.Point(3, 224);
            this.btnPatientsMang.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnPatientsMang.Name = "btnPatientsMang";
            this.btnPatientsMang.NormalBackground = System.Drawing.Color.Transparent;
            this.btnPatientsMang.NormalForeColor = System.Drawing.Color.White;
            this.btnPatientsMang.NormalImageTint = System.Drawing.Color.White;
            this.btnPatientsMang.NormalOutline = System.Drawing.Color.White;
            this.btnPatientsMang.OutlineThickness = 1F;
            this.btnPatientsMang.PressedBackground = System.Drawing.Color.White;
            this.btnPatientsMang.PressedForeColor = System.Drawing.Color.Black;
            this.btnPatientsMang.PressedImageTint = System.Drawing.Color.White;
            this.btnPatientsMang.PressedOutline = System.Drawing.Color.White;
            this.btnPatientsMang.Rounding = new System.Windows.Forms.Padding(22);
            this.btnPatientsMang.Size = new System.Drawing.Size(221, 45);
            this.btnPatientsMang.TabIndex = 14;
            this.btnPatientsMang.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPatientsMang.TextOffset = new System.Drawing.Point(0, 0);
            this.btnPatientsMang.Click += new System.EventHandler(this.btnPatientsMang_Click);
            // 
            // btnPaymentsMang
            // 
            this.btnPaymentsMang.BackColor = System.Drawing.Color.Transparent;
            this.btnPaymentsMang.CheckButton = false;
            this.btnPaymentsMang.Checked = false;
            this.btnPaymentsMang.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnPaymentsMang.CheckedForeColor = System.Drawing.Color.White;
            this.btnPaymentsMang.CheckedImageTint = System.Drawing.Color.White;
            this.btnPaymentsMang.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnPaymentsMang.Content = "Payments Management";
            this.btnPaymentsMang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaymentsMang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPaymentsMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentsMang.ForeColor = System.Drawing.Color.White;
            this.btnPaymentsMang.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPaymentsMang.HoverForeColor = System.Drawing.Color.White;
            this.btnPaymentsMang.HoverImageTint = System.Drawing.Color.White;
            this.btnPaymentsMang.HoverOutline = System.Drawing.Color.White;
            this.btnPaymentsMang.Image = null;
            this.btnPaymentsMang.ImageAutoCenter = true;
            this.btnPaymentsMang.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnPaymentsMang.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPaymentsMang.Location = new System.Drawing.Point(3, 292);
            this.btnPaymentsMang.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnPaymentsMang.Name = "btnPaymentsMang";
            this.btnPaymentsMang.NormalBackground = System.Drawing.Color.Transparent;
            this.btnPaymentsMang.NormalForeColor = System.Drawing.Color.White;
            this.btnPaymentsMang.NormalImageTint = System.Drawing.Color.White;
            this.btnPaymentsMang.NormalOutline = System.Drawing.Color.White;
            this.btnPaymentsMang.OutlineThickness = 1F;
            this.btnPaymentsMang.PressedBackground = System.Drawing.Color.White;
            this.btnPaymentsMang.PressedForeColor = System.Drawing.Color.Black;
            this.btnPaymentsMang.PressedImageTint = System.Drawing.Color.White;
            this.btnPaymentsMang.PressedOutline = System.Drawing.Color.White;
            this.btnPaymentsMang.Rounding = new System.Windows.Forms.Padding(22);
            this.btnPaymentsMang.Size = new System.Drawing.Size(221, 45);
            this.btnPaymentsMang.TabIndex = 14;
            this.btnPaymentsMang.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPaymentsMang.TextOffset = new System.Drawing.Point(0, 0);
            this.btnPaymentsMang.Click += new System.EventHandler(this.btnPaymentsMang_Click);
            // 
            // btnVisitsMang
            // 
            this.btnVisitsMang.BackColor = System.Drawing.Color.Transparent;
            this.btnVisitsMang.CheckButton = false;
            this.btnVisitsMang.Checked = false;
            this.btnVisitsMang.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnVisitsMang.CheckedForeColor = System.Drawing.Color.White;
            this.btnVisitsMang.CheckedImageTint = System.Drawing.Color.White;
            this.btnVisitsMang.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnVisitsMang.Content = "Visits Management";
            this.btnVisitsMang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisitsMang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVisitsMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitsMang.ForeColor = System.Drawing.Color.White;
            this.btnVisitsMang.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVisitsMang.HoverForeColor = System.Drawing.Color.White;
            this.btnVisitsMang.HoverImageTint = System.Drawing.Color.White;
            this.btnVisitsMang.HoverOutline = System.Drawing.Color.White;
            this.btnVisitsMang.Image = null;
            this.btnVisitsMang.ImageAutoCenter = true;
            this.btnVisitsMang.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnVisitsMang.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnVisitsMang.Location = new System.Drawing.Point(3, 360);
            this.btnVisitsMang.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnVisitsMang.Name = "btnVisitsMang";
            this.btnVisitsMang.NormalBackground = System.Drawing.Color.Transparent;
            this.btnVisitsMang.NormalForeColor = System.Drawing.Color.White;
            this.btnVisitsMang.NormalImageTint = System.Drawing.Color.White;
            this.btnVisitsMang.NormalOutline = System.Drawing.Color.White;
            this.btnVisitsMang.OutlineThickness = 1F;
            this.btnVisitsMang.PressedBackground = System.Drawing.Color.White;
            this.btnVisitsMang.PressedForeColor = System.Drawing.Color.Black;
            this.btnVisitsMang.PressedImageTint = System.Drawing.Color.White;
            this.btnVisitsMang.PressedOutline = System.Drawing.Color.White;
            this.btnVisitsMang.Rounding = new System.Windows.Forms.Padding(22);
            this.btnVisitsMang.Size = new System.Drawing.Size(221, 45);
            this.btnVisitsMang.TabIndex = 14;
            this.btnVisitsMang.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnVisitsMang.TextOffset = new System.Drawing.Point(0, 0);
            this.btnVisitsMang.Click += new System.EventHandler(this.btnVisitsMang_Click);
            // 
            // btnAppointmantsMang
            // 
            this.btnAppointmantsMang.BackColor = System.Drawing.Color.Transparent;
            this.btnAppointmantsMang.CheckButton = false;
            this.btnAppointmantsMang.Checked = false;
            this.btnAppointmantsMang.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAppointmantsMang.CheckedForeColor = System.Drawing.Color.White;
            this.btnAppointmantsMang.CheckedImageTint = System.Drawing.Color.White;
            this.btnAppointmantsMang.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAppointmantsMang.Content = "Appointments Management";
            this.btnAppointmantsMang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppointmantsMang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAppointmantsMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointmantsMang.ForeColor = System.Drawing.Color.White;
            this.btnAppointmantsMang.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAppointmantsMang.HoverForeColor = System.Drawing.Color.White;
            this.btnAppointmantsMang.HoverImageTint = System.Drawing.Color.White;
            this.btnAppointmantsMang.HoverOutline = System.Drawing.Color.White;
            this.btnAppointmantsMang.Image = null;
            this.btnAppointmantsMang.ImageAutoCenter = true;
            this.btnAppointmantsMang.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAppointmantsMang.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAppointmantsMang.Location = new System.Drawing.Point(3, 428);
            this.btnAppointmantsMang.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnAppointmantsMang.Name = "btnAppointmantsMang";
            this.btnAppointmantsMang.NormalBackground = System.Drawing.Color.Transparent;
            this.btnAppointmantsMang.NormalForeColor = System.Drawing.Color.White;
            this.btnAppointmantsMang.NormalImageTint = System.Drawing.Color.White;
            this.btnAppointmantsMang.NormalOutline = System.Drawing.Color.White;
            this.btnAppointmantsMang.OutlineThickness = 1F;
            this.btnAppointmantsMang.PressedBackground = System.Drawing.Color.White;
            this.btnAppointmantsMang.PressedForeColor = System.Drawing.Color.Black;
            this.btnAppointmantsMang.PressedImageTint = System.Drawing.Color.White;
            this.btnAppointmantsMang.PressedOutline = System.Drawing.Color.White;
            this.btnAppointmantsMang.Rounding = new System.Windows.Forms.Padding(22);
            this.btnAppointmantsMang.Size = new System.Drawing.Size(221, 45);
            this.btnAppointmantsMang.TabIndex = 14;
            this.btnAppointmantsMang.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAppointmantsMang.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAppointmantsMang.Click += new System.EventHandler(this.btnAppointmantsMang_Click);
            // 
            // btnSettingsMang
            // 
            this.btnSettingsMang.BackColor = System.Drawing.Color.Transparent;
            this.btnSettingsMang.CheckButton = false;
            this.btnSettingsMang.Checked = false;
            this.btnSettingsMang.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSettingsMang.CheckedForeColor = System.Drawing.Color.White;
            this.btnSettingsMang.CheckedImageTint = System.Drawing.Color.White;
            this.btnSettingsMang.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSettingsMang.Content = "Settings";
            this.btnSettingsMang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettingsMang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettingsMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsMang.ForeColor = System.Drawing.Color.White;
            this.btnSettingsMang.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSettingsMang.HoverForeColor = System.Drawing.Color.White;
            this.btnSettingsMang.HoverImageTint = System.Drawing.Color.White;
            this.btnSettingsMang.HoverOutline = System.Drawing.Color.White;
            this.btnSettingsMang.Image = null;
            this.btnSettingsMang.ImageAutoCenter = true;
            this.btnSettingsMang.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSettingsMang.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSettingsMang.Location = new System.Drawing.Point(3, 496);
            this.btnSettingsMang.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnSettingsMang.Name = "btnSettingsMang";
            this.btnSettingsMang.NormalBackground = System.Drawing.Color.Transparent;
            this.btnSettingsMang.NormalForeColor = System.Drawing.Color.White;
            this.btnSettingsMang.NormalImageTint = System.Drawing.Color.White;
            this.btnSettingsMang.NormalOutline = System.Drawing.Color.White;
            this.btnSettingsMang.OutlineThickness = 1F;
            this.btnSettingsMang.PressedBackground = System.Drawing.Color.White;
            this.btnSettingsMang.PressedForeColor = System.Drawing.Color.Black;
            this.btnSettingsMang.PressedImageTint = System.Drawing.Color.White;
            this.btnSettingsMang.PressedOutline = System.Drawing.Color.White;
            this.btnSettingsMang.Rounding = new System.Windows.Forms.Padding(22);
            this.btnSettingsMang.Size = new System.Drawing.Size(221, 45);
            this.btnSettingsMang.TabIndex = 14;
            this.btnSettingsMang.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSettingsMang.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSettingsMang.Click += new System.EventHandler(this.btnSettingsMang_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.CheckButton = false;
            this.btnLogout.Checked = false;
            this.btnLogout.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLogout.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogout.CheckedImageTint = System.Drawing.Color.White;
            this.btnLogout.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLogout.Content = "Log out";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.HoverForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverImageTint = System.Drawing.Color.White;
            this.btnLogout.HoverOutline = System.Drawing.Color.White;
            this.btnLogout.Image = null;
            this.btnLogout.ImageAutoCenter = true;
            this.btnLogout.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnLogout.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogout.Location = new System.Drawing.Point(3, 564);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NormalBackground = System.Drawing.Color.Transparent;
            this.btnLogout.NormalForeColor = System.Drawing.Color.White;
            this.btnLogout.NormalImageTint = System.Drawing.Color.White;
            this.btnLogout.NormalOutline = System.Drawing.Color.White;
            this.btnLogout.OutlineThickness = 1F;
            this.btnLogout.PressedBackground = System.Drawing.Color.White;
            this.btnLogout.PressedForeColor = System.Drawing.Color.Black;
            this.btnLogout.PressedImageTint = System.Drawing.Color.White;
            this.btnLogout.PressedOutline = System.Drawing.Color.White;
            this.btnLogout.Rounding = new System.Windows.Forms.Padding(22);
            this.btnLogout.Size = new System.Drawing.Size(221, 45);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLogout.TextOffset = new System.Drawing.Point(0, 0);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlAppointmants
            // 
            this.pnlAppointmants.Controls.Add(this.dgvAppointments);
            this.pnlAppointmants.Controls.Add(this.cuiLabel15);
            this.pnlAppointmants.Controls.Add(this.btnAddAppointment);
            this.pnlAppointmants.GradientAngle = 0F;
            this.pnlAppointmants.Location = new System.Drawing.Point(766, 169);
            this.pnlAppointmants.Name = "pnlAppointmants";
            this.pnlAppointmants.OutlineThickness = 1F;
            this.pnlAppointmants.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlAppointmants.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlAppointmants.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.pnlAppointmants.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.pnlAppointmants.Rounding = new System.Windows.Forms.Padding(15);
            this.pnlAppointmants.Size = new System.Drawing.Size(392, 347);
            this.pnlAppointmants.TabIndex = 3;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToResizeColumns = false;
            this.dgvAppointments.AllowUserToResizeRows = false;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointments.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointments.EnableHeadersVisualStyles = false;
            this.dgvAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvAppointments.Location = new System.Drawing.Point(10, 51);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointments.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAppointments.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppointments.RowTemplate.Height = 30;
            this.dgvAppointments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(363, 293);
            this.dgvAppointments.TabIndex = 17;
            // 
            // cuiLabel15
            // 
            this.cuiLabel15.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel15.Content = "Upcoming\\ Appointments";
            this.cuiLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel15.ForeColor = System.Drawing.Color.White;
            this.cuiLabel15.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel15.Location = new System.Drawing.Point(10, 10);
            this.cuiLabel15.Name = "cuiLabel15";
            this.cuiLabel15.Size = new System.Drawing.Size(237, 40);
            this.cuiLabel15.TabIndex = 2;
            this.cuiLabel15.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAppointment.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAppointment.CheckButton = false;
            this.btnAddAppointment.Checked = false;
            this.btnAddAppointment.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAddAppointment.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.CheckedImageTint = System.Drawing.Color.White;
            this.btnAddAppointment.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAddAppointment.Content = "Add Appointment";
            this.btnAddAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAppointment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddAppointment.HoverForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.HoverImageTint = System.Drawing.Color.White;
            this.btnAddAppointment.HoverOutline = System.Drawing.Color.White;
            this.btnAddAppointment.Image = null;
            this.btnAddAppointment.ImageAutoCenter = true;
            this.btnAddAppointment.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAddAppointment.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddAppointment.Location = new System.Drawing.Point(203, 10);
            this.btnAddAppointment.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.NormalBackground = System.Drawing.Color.Transparent;
            this.btnAddAppointment.NormalForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.NormalImageTint = System.Drawing.Color.White;
            this.btnAddAppointment.NormalOutline = System.Drawing.Color.White;
            this.btnAddAppointment.OutlineThickness = 1F;
            this.btnAddAppointment.PressedBackground = System.Drawing.Color.White;
            this.btnAddAppointment.PressedForeColor = System.Drawing.Color.Black;
            this.btnAddAppointment.PressedImageTint = System.Drawing.Color.White;
            this.btnAddAppointment.PressedOutline = System.Drawing.Color.White;
            this.btnAddAppointment.Rounding = new System.Windows.Forms.Padding(19);
            this.btnAddAppointment.Size = new System.Drawing.Size(180, 40);
            this.btnAddAppointment.TabIndex = 15;
            this.btnAddAppointment.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddAppointment.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // pnlVisits
            // 
            this.pnlVisits.Controls.Add(this.sepVisits);
            this.pnlVisits.Controls.Add(this.dgvWaitingVisits);
            this.pnlVisits.Controls.Add(this.btnAddVisit);
            this.pnlVisits.Controls.Add(this.dgvInProgressVisits);
            this.pnlVisits.Controls.Add(this.lblWatitingVisits);
            this.pnlVisits.Controls.Add(this.cuiLabel17);
            this.pnlVisits.GradientAngle = 0F;
            this.pnlVisits.Location = new System.Drawing.Point(3, 169);
            this.pnlVisits.Name = "pnlVisits";
            this.pnlVisits.OutlineThickness = 1F;
            this.pnlVisits.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlVisits.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlVisits.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.pnlVisits.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.pnlVisits.Rounding = new System.Windows.Forms.Padding(15);
            this.pnlVisits.Size = new System.Drawing.Size(757, 347);
            this.pnlVisits.TabIndex = 4;
            // 
            // sepVisits
            // 
            this.sepVisits.BackColor = System.Drawing.Color.Transparent;
            this.sepVisits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.sepVisits.Location = new System.Drawing.Point(350, 9);
            this.sepVisits.Name = "sepVisits";
            this.sepVisits.SeparatorMargin = 8;
            this.sepVisits.Size = new System.Drawing.Size(4, 41);
            this.sepVisits.TabIndex = 19;
            this.sepVisits.Thickness = 0.5F;
            this.sepVisits.Vertical = true;
            // 
            // dgvWaitingVisits
            // 
            this.dgvWaitingVisits.AllowUserToAddRows = false;
            this.dgvWaitingVisits.AllowUserToDeleteRows = false;
            this.dgvWaitingVisits.AllowUserToResizeColumns = false;
            this.dgvWaitingVisits.AllowUserToResizeRows = false;
            this.dgvWaitingVisits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvWaitingVisits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWaitingVisits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvWaitingVisits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvWaitingVisits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvWaitingVisits.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWaitingVisits.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvWaitingVisits.EnableHeadersVisualStyles = false;
            this.dgvWaitingVisits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvWaitingVisits.Location = new System.Drawing.Point(374, 36);
            this.dgvWaitingVisits.MultiSelect = false;
            this.dgvWaitingVisits.Name = "dgvWaitingVisits";
            this.dgvWaitingVisits.ReadOnly = true;
            this.dgvWaitingVisits.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWaitingVisits.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvWaitingVisits.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvWaitingVisits.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvWaitingVisits.RowTemplate.Height = 30;
            this.dgvWaitingVisits.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvWaitingVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWaitingVisits.Size = new System.Drawing.Size(363, 293);
            this.dgvWaitingVisits.TabIndex = 18;
            // 
            // btnAddVisit
            // 
            this.btnAddVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddVisit.BackColor = System.Drawing.Color.Transparent;
            this.btnAddVisit.CheckButton = false;
            this.btnAddVisit.Checked = false;
            this.btnAddVisit.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAddVisit.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddVisit.CheckedImageTint = System.Drawing.Color.White;
            this.btnAddVisit.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAddVisit.Content = "Add Visit";
            this.btnAddVisit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddVisit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVisit.ForeColor = System.Drawing.Color.White;
            this.btnAddVisit.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddVisit.HoverForeColor = System.Drawing.Color.White;
            this.btnAddVisit.HoverImageTint = System.Drawing.Color.White;
            this.btnAddVisit.HoverOutline = System.Drawing.Color.White;
            this.btnAddVisit.Image = null;
            this.btnAddVisit.ImageAutoCenter = true;
            this.btnAddVisit.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAddVisit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddVisit.Location = new System.Drawing.Point(568, 10);
            this.btnAddVisit.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnAddVisit.Name = "btnAddVisit";
            this.btnAddVisit.NormalBackground = System.Drawing.Color.Transparent;
            this.btnAddVisit.NormalForeColor = System.Drawing.Color.White;
            this.btnAddVisit.NormalImageTint = System.Drawing.Color.White;
            this.btnAddVisit.NormalOutline = System.Drawing.Color.White;
            this.btnAddVisit.OutlineThickness = 1F;
            this.btnAddVisit.PressedBackground = System.Drawing.Color.White;
            this.btnAddVisit.PressedForeColor = System.Drawing.Color.Black;
            this.btnAddVisit.PressedImageTint = System.Drawing.Color.White;
            this.btnAddVisit.PressedOutline = System.Drawing.Color.White;
            this.btnAddVisit.Rounding = new System.Windows.Forms.Padding(19);
            this.btnAddVisit.Size = new System.Drawing.Size(180, 40);
            this.btnAddVisit.TabIndex = 15;
            this.btnAddVisit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddVisit.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAddVisit.Click += new System.EventHandler(this.btnAddVisit_Click);
            // 
            // dgvInProgressVisits
            // 
            this.dgvInProgressVisits.AllowUserToAddRows = false;
            this.dgvInProgressVisits.AllowUserToDeleteRows = false;
            this.dgvInProgressVisits.AllowUserToResizeColumns = false;
            this.dgvInProgressVisits.AllowUserToResizeRows = false;
            this.dgvInProgressVisits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvInProgressVisits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInProgressVisits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInProgressVisits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInProgressVisits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInProgressVisits.ColumnHeadersHeight = 35;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInProgressVisits.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvInProgressVisits.EnableHeadersVisualStyles = false;
            this.dgvInProgressVisits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvInProgressVisits.Location = new System.Drawing.Point(5, 36);
            this.dgvInProgressVisits.MultiSelect = false;
            this.dgvInProgressVisits.Name = "dgvInProgressVisits";
            this.dgvInProgressVisits.ReadOnly = true;
            this.dgvInProgressVisits.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInProgressVisits.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvInProgressVisits.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInProgressVisits.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvInProgressVisits.RowTemplate.Height = 30;
            this.dgvInProgressVisits.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvInProgressVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInProgressVisits.Size = new System.Drawing.Size(363, 293);
            this.dgvInProgressVisits.TabIndex = 18;
            // 
            // lblWatitingVisits
            // 
            this.lblWatitingVisits.BackColor = System.Drawing.Color.Transparent;
            this.lblWatitingVisits.Content = "Waiting\\ Visits";
            this.lblWatitingVisits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatitingVisits.ForeColor = System.Drawing.Color.White;
            this.lblWatitingVisits.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblWatitingVisits.Location = new System.Drawing.Point(374, 10);
            this.lblWatitingVisits.Name = "lblWatitingVisits";
            this.lblWatitingVisits.Size = new System.Drawing.Size(200, 40);
            this.lblWatitingVisits.TabIndex = 2;
            this.lblWatitingVisits.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel17
            // 
            this.cuiLabel17.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel17.Content = "In\\ Progress\\ Visits";
            this.cuiLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel17.ForeColor = System.Drawing.Color.White;
            this.cuiLabel17.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel17.Location = new System.Drawing.Point(10, 10);
            this.cuiLabel17.Name = "cuiLabel17";
            this.cuiLabel17.Size = new System.Drawing.Size(200, 40);
            this.cuiLabel17.TabIndex = 2;
            this.cuiLabel17.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // flpContainer
            // 
            this.flpContainer.Controls.Add(this.pnlEmergancyCases);
            this.flpContainer.Controls.Add(this.pnlCompleteVisits);
            this.flpContainer.Controls.Add(this.pnlUpcommingAppointments);
            this.flpContainer.Controls.Add(this.pnlTodayPatients);
            this.flpContainer.Controls.Add(this.pnlVisits);
            this.flpContainer.Controls.Add(this.pnlAppointmants);
            this.flpContainer.Controls.Add(this.pnlRemaining);
            this.flpContainer.Controls.Add(this.pnlNumberOfReceipts);
            this.flpContainer.Controls.Add(this.pnlTodayPayments);
            this.flpContainer.Controls.Add(this.pnlNotifications);
            this.flpContainer.Location = new System.Drawing.Point(12, 87);
            this.flpContainer.Name = "flpContainer";
            this.flpContainer.Size = new System.Drawing.Size(1165, 681);
            this.flpContainer.TabIndex = 5;
            // 
            // pnlEmergancyCases
            // 
            this.pnlEmergancyCases.Controls.Add(this.lblEmergencyCases);
            this.pnlEmergancyCases.Controls.Add(this.cuiLabel1);
            this.pnlEmergancyCases.GradientAngle = 40F;
            this.pnlEmergancyCases.Location = new System.Drawing.Point(3, 3);
            this.pnlEmergancyCases.Name = "pnlEmergancyCases";
            this.pnlEmergancyCases.OutlineThickness = 1F;
            this.pnlEmergancyCases.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.pnlEmergancyCases.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlEmergancyCases.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.pnlEmergancyCases.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.pnlEmergancyCases.Rounding = new System.Windows.Forms.Padding(15);
            this.pnlEmergancyCases.Size = new System.Drawing.Size(282, 160);
            this.pnlEmergancyCases.TabIndex = 6;
            // 
            // lblEmergencyCases
            // 
            this.lblEmergencyCases.BackColor = System.Drawing.Color.Transparent;
            this.lblEmergencyCases.Content = "0";
            this.lblEmergencyCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergencyCases.ForeColor = System.Drawing.Color.White;
            this.lblEmergencyCases.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblEmergencyCases.Location = new System.Drawing.Point(5, 41);
            this.lblEmergencyCases.Name = "lblEmergencyCases";
            this.lblEmergencyCases.Size = new System.Drawing.Size(272, 116);
            this.lblEmergencyCases.TabIndex = 1;
            this.lblEmergencyCases.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel1.Content = "Emergency\\ Cases";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.ForeColor = System.Drawing.Color.White;
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel1.Location = new System.Drawing.Point(10, 0);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(272, 45);
            this.cuiLabel1.TabIndex = 0;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pnlCompleteVisits
            // 
            this.pnlCompleteVisits.Controls.Add(this.lblCompleteVisits);
            this.pnlCompleteVisits.Controls.Add(this.cuiLabel4);
            this.pnlCompleteVisits.GradientAngle = 40F;
            this.pnlCompleteVisits.Location = new System.Drawing.Point(291, 3);
            this.pnlCompleteVisits.Name = "pnlCompleteVisits";
            this.pnlCompleteVisits.OutlineThickness = 1F;
            this.pnlCompleteVisits.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.pnlCompleteVisits.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(10)))));
            this.pnlCompleteVisits.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.pnlCompleteVisits.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.pnlCompleteVisits.Rounding = new System.Windows.Forms.Padding(15);
            this.pnlCompleteVisits.Size = new System.Drawing.Size(282, 160);
            this.pnlCompleteVisits.TabIndex = 5;
            // 
            // lblCompleteVisits
            // 
            this.lblCompleteVisits.BackColor = System.Drawing.Color.Transparent;
            this.lblCompleteVisits.Content = "0";
            this.lblCompleteVisits.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleteVisits.ForeColor = System.Drawing.Color.White;
            this.lblCompleteVisits.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblCompleteVisits.Location = new System.Drawing.Point(5, 41);
            this.lblCompleteVisits.Name = "lblCompleteVisits";
            this.lblCompleteVisits.Size = new System.Drawing.Size(272, 116);
            this.lblCompleteVisits.TabIndex = 3;
            this.lblCompleteVisits.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel4
            // 
            this.cuiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel4.Content = "Complete\\ Visits";
            this.cuiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel4.ForeColor = System.Drawing.Color.White;
            this.cuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel4.Location = new System.Drawing.Point(10, 0);
            this.cuiLabel4.Name = "cuiLabel4";
            this.cuiLabel4.Size = new System.Drawing.Size(272, 45);
            this.cuiLabel4.TabIndex = 2;
            this.cuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pnlUpcommingAppointments
            // 
            this.pnlUpcommingAppointments.Controls.Add(this.lblAppointment);
            this.pnlUpcommingAppointments.Controls.Add(this.cuiLabel6);
            this.pnlUpcommingAppointments.GradientAngle = 40F;
            this.pnlUpcommingAppointments.Location = new System.Drawing.Point(579, 3);
            this.pnlUpcommingAppointments.Name = "pnlUpcommingAppointments";
            this.pnlUpcommingAppointments.OutlineThickness = 1F;
            this.pnlUpcommingAppointments.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.pnlUpcommingAppointments.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.pnlUpcommingAppointments.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.pnlUpcommingAppointments.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.pnlUpcommingAppointments.Rounding = new System.Windows.Forms.Padding(15);
            this.pnlUpcommingAppointments.Size = new System.Drawing.Size(282, 160);
            this.pnlUpcommingAppointments.TabIndex = 6;
            // 
            // lblAppointment
            // 
            this.lblAppointment.BackColor = System.Drawing.Color.Transparent;
            this.lblAppointment.Content = "0";
            this.lblAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointment.ForeColor = System.Drawing.Color.White;
            this.lblAppointment.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblAppointment.Location = new System.Drawing.Point(5, 41);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(272, 116);
            this.lblAppointment.TabIndex = 5;
            this.lblAppointment.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel6
            // 
            this.cuiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel6.Content = "Appointments";
            this.cuiLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel6.ForeColor = System.Drawing.Color.White;
            this.cuiLabel6.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel6.Location = new System.Drawing.Point(10, 0);
            this.cuiLabel6.Name = "cuiLabel6";
            this.cuiLabel6.Size = new System.Drawing.Size(272, 45);
            this.cuiLabel6.TabIndex = 4;
            this.cuiLabel6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pnlTodayPatients
            // 
            this.pnlTodayPatients.Controls.Add(this.lblTodayPatients);
            this.pnlTodayPatients.Controls.Add(this.cuiLabel8);
            this.pnlTodayPatients.GradientAngle = 40F;
            this.pnlTodayPatients.Location = new System.Drawing.Point(867, 3);
            this.pnlTodayPatients.Name = "pnlTodayPatients";
            this.pnlTodayPatients.OutlineThickness = 1F;
            this.pnlTodayPatients.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.pnlTodayPatients.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.pnlTodayPatients.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.pnlTodayPatients.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.pnlTodayPatients.Rounding = new System.Windows.Forms.Padding(15);
            this.pnlTodayPatients.Size = new System.Drawing.Size(282, 160);
            this.pnlTodayPatients.TabIndex = 6;
            // 
            // lblTodayPatients
            // 
            this.lblTodayPatients.BackColor = System.Drawing.Color.Transparent;
            this.lblTodayPatients.Content = "0";
            this.lblTodayPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayPatients.ForeColor = System.Drawing.Color.White;
            this.lblTodayPatients.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblTodayPatients.Location = new System.Drawing.Point(5, 41);
            this.lblTodayPatients.Name = "lblTodayPatients";
            this.lblTodayPatients.Size = new System.Drawing.Size(272, 116);
            this.lblTodayPatients.TabIndex = 7;
            this.lblTodayPatients.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel8
            // 
            this.cuiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel8.Content = "Today\'s\\ New\\ Patients";
            this.cuiLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel8.ForeColor = System.Drawing.Color.White;
            this.cuiLabel8.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel8.Location = new System.Drawing.Point(10, 0);
            this.cuiLabel8.Name = "cuiLabel8";
            this.cuiLabel8.Size = new System.Drawing.Size(272, 45);
            this.cuiLabel8.TabIndex = 6;
            this.cuiLabel8.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pnlRemaining
            // 
            this.pnlRemaining.Controls.Add(this.lblRemainingPayments);
            this.pnlRemaining.Controls.Add(this.cuiLabel10);
            this.pnlRemaining.GradientAngle = 40F;
            this.pnlRemaining.Location = new System.Drawing.Point(3, 522);
            this.pnlRemaining.Name = "pnlRemaining";
            this.pnlRemaining.OutlineThickness = 1F;
            this.pnlRemaining.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.pnlRemaining.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.pnlRemaining.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.pnlRemaining.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.pnlRemaining.Rounding = new System.Windows.Forms.Padding(15);
            this.pnlRemaining.Size = new System.Drawing.Size(282, 160);
            this.pnlRemaining.TabIndex = 7;
            // 
            // lblRemainingPayments
            // 
            this.lblRemainingPayments.BackColor = System.Drawing.Color.Transparent;
            this.lblRemainingPayments.Content = "0";
            this.lblRemainingPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingPayments.ForeColor = System.Drawing.Color.White;
            this.lblRemainingPayments.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblRemainingPayments.Location = new System.Drawing.Point(5, 41);
            this.lblRemainingPayments.Name = "lblRemainingPayments";
            this.lblRemainingPayments.Size = new System.Drawing.Size(272, 116);
            this.lblRemainingPayments.TabIndex = 5;
            this.lblRemainingPayments.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel10
            // 
            this.cuiLabel10.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel10.Content = "Remaining\\ Payments";
            this.cuiLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel10.ForeColor = System.Drawing.Color.White;
            this.cuiLabel10.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel10.Location = new System.Drawing.Point(10, 0);
            this.cuiLabel10.Name = "cuiLabel10";
            this.cuiLabel10.Size = new System.Drawing.Size(272, 45);
            this.cuiLabel10.TabIndex = 4;
            this.cuiLabel10.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pnlNumberOfReceipts
            // 
            this.pnlNumberOfReceipts.Controls.Add(this.lblNumberOfReceipts);
            this.pnlNumberOfReceipts.Controls.Add(this.cuiLabel12);
            this.pnlNumberOfReceipts.GradientAngle = 40F;
            this.pnlNumberOfReceipts.Location = new System.Drawing.Point(291, 522);
            this.pnlNumberOfReceipts.Name = "pnlNumberOfReceipts";
            this.pnlNumberOfReceipts.OutlineThickness = 1F;
            this.pnlNumberOfReceipts.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(70)))));
            this.pnlNumberOfReceipts.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.pnlNumberOfReceipts.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.pnlNumberOfReceipts.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.pnlNumberOfReceipts.Rounding = new System.Windows.Forms.Padding(15);
            this.pnlNumberOfReceipts.Size = new System.Drawing.Size(282, 160);
            this.pnlNumberOfReceipts.TabIndex = 7;
            // 
            // lblNumberOfReceipts
            // 
            this.lblNumberOfReceipts.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfReceipts.Content = "0";
            this.lblNumberOfReceipts.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfReceipts.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfReceipts.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblNumberOfReceipts.Location = new System.Drawing.Point(5, 41);
            this.lblNumberOfReceipts.Name = "lblNumberOfReceipts";
            this.lblNumberOfReceipts.Size = new System.Drawing.Size(272, 116);
            this.lblNumberOfReceipts.TabIndex = 7;
            this.lblNumberOfReceipts.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel12
            // 
            this.cuiLabel12.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel12.Content = "Number\\ Of\\ Receipts";
            this.cuiLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel12.ForeColor = System.Drawing.Color.White;
            this.cuiLabel12.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel12.Location = new System.Drawing.Point(10, 0);
            this.cuiLabel12.Name = "cuiLabel12";
            this.cuiLabel12.Size = new System.Drawing.Size(272, 45);
            this.cuiLabel12.TabIndex = 6;
            this.cuiLabel12.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pnlTodayPayments
            // 
            this.pnlTodayPayments.Controls.Add(this.lblTodayPayments);
            this.pnlTodayPayments.Controls.Add(this.cuiLabel14);
            this.pnlTodayPayments.GradientAngle = 40F;
            this.pnlTodayPayments.Location = new System.Drawing.Point(579, 522);
            this.pnlTodayPayments.Name = "pnlTodayPayments";
            this.pnlTodayPayments.OutlineThickness = 1F;
            this.pnlTodayPayments.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pnlTodayPayments.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlTodayPayments.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.pnlTodayPayments.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.pnlTodayPayments.Rounding = new System.Windows.Forms.Padding(15);
            this.pnlTodayPayments.Size = new System.Drawing.Size(282, 160);
            this.pnlTodayPayments.TabIndex = 7;
            // 
            // lblTodayPayments
            // 
            this.lblTodayPayments.BackColor = System.Drawing.Color.Transparent;
            this.lblTodayPayments.Content = "0";
            this.lblTodayPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayPayments.ForeColor = System.Drawing.Color.White;
            this.lblTodayPayments.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblTodayPayments.Location = new System.Drawing.Point(5, 41);
            this.lblTodayPayments.Name = "lblTodayPayments";
            this.lblTodayPayments.Size = new System.Drawing.Size(272, 116);
            this.lblTodayPayments.TabIndex = 9;
            this.lblTodayPayments.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel14
            // 
            this.cuiLabel14.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel14.Content = "Today\'s\\ Payments";
            this.cuiLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel14.ForeColor = System.Drawing.Color.White;
            this.cuiLabel14.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel14.Location = new System.Drawing.Point(10, 0);
            this.cuiLabel14.Name = "cuiLabel14";
            this.cuiLabel14.Size = new System.Drawing.Size(272, 45);
            this.cuiLabel14.TabIndex = 8;
            this.cuiLabel14.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pnlNotifications
            // 
            this.pnlNotifications.Controls.Add(this.lblUnreadableMessage);
            this.pnlNotifications.Controls.Add(this.cuiButton1);
            this.pnlNotifications.Controls.Add(this.lblNotifyMessage);
            this.pnlNotifications.Controls.Add(this.cuiLabel16);
            this.pnlNotifications.GradientAngle = 40F;
            this.pnlNotifications.Location = new System.Drawing.Point(867, 522);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.OutlineThickness = 1F;
            this.pnlNotifications.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.pnlNotifications.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlNotifications.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.pnlNotifications.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.pnlNotifications.Rounding = new System.Windows.Forms.Padding(15);
            this.pnlNotifications.Size = new System.Drawing.Size(282, 160);
            this.pnlNotifications.TabIndex = 7;
            this.pnlNotifications.Click += new System.EventHandler(this.pnlNotifications_Click);
            this.pnlNotifications.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlNotifications_MouseDown);
            this.pnlNotifications.MouseEnter += new System.EventHandler(this.pnlNotifications_MouseEnter);
            this.pnlNotifications.MouseLeave += new System.EventHandler(this.pnlNotifications_MouseLeave);
            this.pnlNotifications.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlNotifications_MouseUp);
            // 
            // lblUnreadableMessage
            // 
            this.lblUnreadableMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblUnreadableMessage.Content = "0\\ Unreadable";
            this.lblUnreadableMessage.Enabled = false;
            this.lblUnreadableMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnreadableMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblUnreadableMessage.HorizontalAlignment = System.Drawing.StringAlignment.Far;
            this.lblUnreadableMessage.Location = new System.Drawing.Point(147, 0);
            this.lblUnreadableMessage.Name = "lblUnreadableMessage";
            this.lblUnreadableMessage.Size = new System.Drawing.Size(125, 35);
            this.lblUnreadableMessage.TabIndex = 13;
            this.lblUnreadableMessage.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiButton1
            // 
            this.cuiButton1.BackColor = System.Drawing.Color.Transparent;
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.Content = "Show All Notifications";
            this.cuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton1.ForeColor = System.Drawing.Color.White;
            this.cuiButton1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cuiButton1.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton1.HoverImageTint = System.Drawing.Color.White;
            this.cuiButton1.HoverOutline = System.Drawing.Color.White;
            this.cuiButton1.Image = null;
            this.cuiButton1.ImageAutoCenter = true;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Location = new System.Drawing.Point(10, 104);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton1.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton1.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton1.NormalOutline = System.Drawing.Color.White;
            this.cuiButton1.OutlineThickness = 1F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.White;
            this.cuiButton1.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.White;
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(22);
            this.cuiButton1.Size = new System.Drawing.Size(262, 45);
            this.cuiButton1.TabIndex = 12;
            this.cuiButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Click += new System.EventHandler(this.cuiButtonShowAllNotifications_Click);
            // 
            // lblNotifyMessage
            // 
            this.lblNotifyMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblNotifyMessage.Content = "No\\ Notifications";
            this.lblNotifyMessage.Enabled = false;
            this.lblNotifyMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifyMessage.ForeColor = System.Drawing.Color.White;
            this.lblNotifyMessage.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblNotifyMessage.Location = new System.Drawing.Point(5, 41);
            this.lblNotifyMessage.Name = "lblNotifyMessage";
            this.lblNotifyMessage.Size = new System.Drawing.Size(272, 57);
            this.lblNotifyMessage.TabIndex = 11;
            this.lblNotifyMessage.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel16
            // 
            this.cuiLabel16.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel16.Content = "Notifications";
            this.cuiLabel16.Enabled = false;
            this.cuiLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel16.ForeColor = System.Drawing.Color.White;
            this.cuiLabel16.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel16.Location = new System.Drawing.Point(10, 0);
            this.cuiLabel16.Name = "cuiLabel16";
            this.cuiLabel16.Size = new System.Drawing.Size(136, 45);
            this.cuiLabel16.TabIndex = 10;
            this.cuiLabel16.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cmsAppointments
            // 
            this.cmsAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripMenuItem1,
            this.editToolStripMenuItem,
            this.toolStripMenuItem2,
            this.makeVisitToolStripMenuItem,
            this.setCancelledToolStripMenuItem,
            this.setNoShowToolStripMenuItem});
            this.cmsAppointments.Name = "contextMenuStrip";
            this.cmsAppointments.Size = new System.Drawing.Size(178, 120);
            // 
            // showInfoToolStripMenuItem1
            // 
            this.showInfoToolStripMenuItem1.Image = global::Clinic_Manager_Proj.Properties.Resources.eye;
            this.showInfoToolStripMenuItem1.Name = "showInfoToolStripMenuItem1";
            this.showInfoToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.showInfoToolStripMenuItem1.Text = "Show Info";
            this.showInfoToolStripMenuItem1.Click += new System.EventHandler(this.showInfoToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.creative;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(174, 6);
            // 
            // makeVisitToolStripMenuItem
            // 
            this.makeVisitToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.arrival_time;
            this.makeVisitToolStripMenuItem.Name = "makeVisitToolStripMenuItem";
            this.makeVisitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.makeVisitToolStripMenuItem.Text = "Arrived / Make Visit";
            this.makeVisitToolStripMenuItem.Click += new System.EventHandler(this.makeVisitToolStripMenuItem_Click);
            // 
            // setCancelledToolStripMenuItem
            // 
            this.setCancelledToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.close;
            this.setCancelledToolStripMenuItem.Name = "setCancelledToolStripMenuItem";
            this.setCancelledToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.setCancelledToolStripMenuItem.Text = "Cancel";
            this.setCancelledToolStripMenuItem.Click += new System.EventHandler(this.setCancelledToolStripMenuItem_Click);
            // 
            // setNoShowToolStripMenuItem
            // 
            this.setNoShowToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.eye__2_;
            this.setNoShowToolStripMenuItem.Name = "setNoShowToolStripMenuItem";
            this.setNoShowToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.setNoShowToolStripMenuItem.Text = "Set No Show";
            this.setNoShowToolStripMenuItem.Click += new System.EventHandler(this.setNoShowToolStripMenuItem_Click);
            // 
            // cmsWaitingVisits
            // 
            this.cmsWaitingVisits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.setInProgressToolStripMenuItem,
            this.toolStripMenuItem4,
            this.sendToEmergencyToolStripMenuItem,
            this.toolStripMenuItem9,
            this.payToolStripMenuItem});
            this.cmsWaitingVisits.Name = "contextMenuStrip";
            this.cmsWaitingVisits.Size = new System.Drawing.Size(178, 126);
            this.cmsWaitingVisits.Opening += new System.ComponentModel.CancelEventHandler(this.cmsWaitingVisits_Opening);
            // 
            // showInfoToolStripMenuItem
            // 
            this.showInfoToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.eye;
            this.showInfoToolStripMenuItem.Name = "showInfoToolStripMenuItem";
            this.showInfoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.showInfoToolStripMenuItem.Text = "Show Info";
            this.showInfoToolStripMenuItem.Click += new System.EventHandler(this.showInfoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(174, 6);
            // 
            // setInProgressToolStripMenuItem
            // 
            this.setInProgressToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.work_in_progress;
            this.setInProgressToolStripMenuItem.Name = "setInProgressToolStripMenuItem";
            this.setInProgressToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.setInProgressToolStripMenuItem.Text = "Set In Progress";
            this.setInProgressToolStripMenuItem.Click += new System.EventHandler(this.setInProgressToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::Clinic_Manager_Proj.Properties.Resources.close;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItem4.Text = "Cancel";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.WaitingVisit_toolStripMenuItem_Cancel_Click);
            // 
            // sendToEmergencyToolStripMenuItem
            // 
            this.sendToEmergencyToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.siren;
            this.sendToEmergencyToolStripMenuItem.Name = "sendToEmergencyToolStripMenuItem";
            this.sendToEmergencyToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.sendToEmergencyToolStripMenuItem.Text = "Send To Emergency";
            this.sendToEmergencyToolStripMenuItem.Click += new System.EventHandler(this.sendToEmergencyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(174, 6);
            // 
            // payToolStripMenuItem
            // 
            this.payToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.dollar;
            this.payToolStripMenuItem.Name = "payToolStripMenuItem";
            this.payToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.payToolStripMenuItem.Text = "Pay";
            this.payToolStripMenuItem.Click += new System.EventHandler(this.payToolStripMenuItem_Click);
            // 
            // cmsInProgressVisits
            // 
            this.cmsInProgressVisits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem10,
            this.payToolStripMenuItem1});
            this.cmsInProgressVisits.Name = "contextMenuStrip";
            this.cmsInProgressVisits.Size = new System.Drawing.Size(178, 126);
            this.cmsInProgressVisits.Opening += new System.ComponentModel.CancelEventHandler(this.cmsInProgressVisits_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::Clinic_Manager_Proj.Properties.Resources.eye;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItem1.Text = "Show Info";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem_ShowInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = global::Clinic_Manager_Proj.Properties.Resources.checkmark;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItem5.Text = "Complete";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem_Complete_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = global::Clinic_Manager_Proj.Properties.Resources.close;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItem6.Text = "Cancel";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem_Cancel_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = global::Clinic_Manager_Proj.Properties.Resources.siren;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItem7.Text = "Send To Emergency";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem_SendToEmergency_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(174, 6);
            // 
            // payToolStripMenuItem1
            // 
            this.payToolStripMenuItem1.Image = global::Clinic_Manager_Proj.Properties.Resources.dollar;
            this.payToolStripMenuItem1.Name = "payToolStripMenuItem1";
            this.payToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.payToolStripMenuItem1.Text = "Pay";
            this.payToolStripMenuItem1.Click += new System.EventHandler(this.payToolStripMenuItem1_Click);
            // 
            // NotificationsTimer
            // 
            this.NotificationsTimer.Enabled = true;
            this.NotificationsTimer.Interval = 60000;
            this.NotificationsTimer.Tick += new System.EventHandler(this.NotificationsTimer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipTitle = "Notification From CMS";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1456, 780);
            this.Controls.Add(this.flpContainer);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.SizeChanged += new System.EventHandler(this.frmDashboard_SizeChanged);
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.flpContainer, 0);
            this.pnlBtnClose.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.flpMenuOptionsContainer.ResumeLayout(false);
            this.pnlAppointmants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.pnlVisits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaitingVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInProgressVisits)).EndInit();
            this.flpContainer.ResumeLayout(false);
            this.pnlEmergancyCases.ResumeLayout(false);
            this.pnlCompleteVisits.ResumeLayout(false);
            this.pnlUpcommingAppointments.ResumeLayout(false);
            this.pnlTodayPatients.ResumeLayout(false);
            this.pnlRemaining.ResumeLayout(false);
            this.pnlNumberOfReceipts.ResumeLayout(false);
            this.pnlTodayPayments.ResumeLayout(false);
            this.pnlNotifications.ResumeLayout(false);
            this.cmsAppointments.ResumeLayout(false);
            this.cmsWaitingVisits.ResumeLayout(false);
            this.cmsInProgressVisits.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiGradientPanel pnlMenu;
        private CuoreUI.Controls.cuiGradientPanel pnlAppointmants;
        private CuoreUI.Controls.cuiGradientPanel pnlVisits;
        private CuoreUI.Controls.cuiGradientPanel pnlCompleteVisits;
        private CuoreUI.Controls.cuiGradientPanel pnlEmergancyCases;
        private CuoreUI.Controls.cuiGradientPanel pnlUpcommingAppointments;
        private CuoreUI.Controls.cuiGradientPanel pnlTodayPatients;
        private CuoreUI.Controls.cuiGradientPanel pnlRemaining;
        private CuoreUI.Controls.cuiGradientPanel pnlNumberOfReceipts;
        private CuoreUI.Controls.cuiGradientPanel pnlTodayPayments;
        private CuoreUI.Controls.cuiGradientPanel pnlNotifications;
        private System.Windows.Forms.FlowLayoutPanel flpContainer;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel lblEmergencyCases;
        private CuoreUI.Controls.cuiLabel lblCompleteVisits;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel lblAppointment;
        private CuoreUI.Controls.cuiLabel cuiLabel6;
        private CuoreUI.Controls.cuiLabel lblTodayPatients;
        private CuoreUI.Controls.cuiLabel cuiLabel8;
        private CuoreUI.Controls.cuiLabel lblRemainingPayments;
        private CuoreUI.Controls.cuiLabel cuiLabel10;
        private CuoreUI.Controls.cuiLabel lblNumberOfReceipts;
        private CuoreUI.Controls.cuiLabel cuiLabel12;
        private CuoreUI.Controls.cuiLabel lblTodayPayments;
        private CuoreUI.Controls.cuiLabel cuiLabel14;
        private CuoreUI.Controls.cuiLabel lblNotifyMessage;
        private CuoreUI.Controls.cuiLabel cuiLabel16;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiLabel lblUnreadableMessage;
        private CuoreUI.Controls.cuiButton btnPeopleMang;
        private CuoreUI.Controls.cuiButton btnLogout;
        private CuoreUI.Controls.cuiButton btnSettingsMang;
        private CuoreUI.Controls.cuiButton btnPaymentsMang;
        private CuoreUI.Controls.cuiButton btnVisitsMang;
        private CuoreUI.Controls.cuiButton btnAppointmantsMang;
        private CuoreUI.Controls.cuiButton btnDoctorsMang;
        private CuoreUI.Controls.cuiButton btnPatientsMang;
        private CuoreUI.Controls.cuiButton btnUsersMang;
        private System.Windows.Forms.FlowLayoutPanel flpMenuOptionsContainer;
        private CuoreUI.Controls.cuiCalendarDatePicker cdpDate;
        private CuoreUI.Controls.cuiComboBox cbxDoctor;
        private CuoreUI.Controls.cuiLabel cuiLabel15;
        private CuoreUI.Controls.cuiLabel cuiLabel17;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private CuoreUI.Controls.cuiButton btnAddAppointment;
        private System.Windows.Forms.DataGridView dtWaitingVisitsdgvWaitingVisits;
        private System.Windows.Forms.DataGridView dgvInProgressVisits;
        private DataGridView dgvWaitingVisits;
        private CuoreUI.Controls.cuiLabel lblWatitingVisits;
        private CuoreUI.Controls.cuiSeparator sepVisits;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiButton btnAddVisit;
        private ContextMenuStrip cmsAppointments;
        private ToolStripMenuItem showInfoToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem makeVisitToolStripMenuItem;
        private ToolStripMenuItem setCancelledToolStripMenuItem;
        private ToolStripMenuItem setNoShowToolStripMenuItem;
        private ContextMenuStrip cmsWaitingVisits;
        private ToolStripMenuItem setInProgressToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem showInfoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem sendToEmergencyToolStripMenuItem;
        private ContextMenuStrip cmsInProgressVisits;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem payToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem9;
        private ToolStripSeparator toolStripMenuItem10;
        private ToolStripMenuItem payToolStripMenuItem1;
        private NotifyIcon notifyIcon;
        private Timer NotificationsTimer;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}