namespace Clinic_Manager_Proj.Payments
{
    partial class frmAddPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPayment));
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.cbxPaymentMethod = new CuoreUI.Controls.cuiComboBox();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.lblPatientName = new CuoreUI.Controls.cuiLabel();
            this.lblDoctorName = new CuoreUI.Controls.cuiLabel();
            this.tbxPaid = new CuoreUI.Controls.cuiTextBox();
            this.lblRemaining = new CuoreUI.Controls.cuiLabel();
            this.lblPayment = new CuoreUI.Controls.cuiLabel();
            this.lblVisitID = new CuoreUI.Controls.cuiLabel();
            this.lblPaymentID = new CuoreUI.Controls.cuiLabel();
            this.cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox8 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox6 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox7 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox5 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.btnSavePayment = new CuoreUI.Controls.cuiButton();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.pnlBtnClose.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.cuiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            this.btnMaximized.Location = new System.Drawing.Point(808, 11);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMinimized.Location = new System.Drawing.Point(808, 11);
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.wallet;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMainTitle.Content = "Add\\ Payment";
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
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 344);
            this.cuiResizeGrip.TargetForm = null;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.cbxPaymentMethod);
            this.cuiPanel1.Controls.Add(this.cuiLabel1);
            this.cuiPanel1.Controls.Add(this.lblPatientName);
            this.cuiPanel1.Controls.Add(this.lblDoctorName);
            this.cuiPanel1.Controls.Add(this.tbxPaid);
            this.cuiPanel1.Controls.Add(this.lblRemaining);
            this.cuiPanel1.Controls.Add(this.lblPayment);
            this.cuiPanel1.Controls.Add(this.lblVisitID);
            this.cuiPanel1.Controls.Add(this.lblPaymentID);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox4);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox8);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox3);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox6);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox7);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox1);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox5);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox2);
            this.cuiPanel1.Location = new System.Drawing.Point(12, 82);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel1.Size = new System.Drawing.Size(897, 180);
            this.cuiPanel1.TabIndex = 2;
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
            this.cbxPaymentMethod.Location = new System.Drawing.Point(561, 135);
            this.cbxPaymentMethod.Name = "cbxPaymentMethod";
            this.cbxPaymentMethod.NoSelectionDropdownText = "Empty";
            this.cbxPaymentMethod.NoSelectionText = " ";
            this.cbxPaymentMethod.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxPaymentMethod.OutlineThickness = 1F;
            this.cbxPaymentMethod.Rounding = 17;
            this.cbxPaymentMethod.Size = new System.Drawing.Size(175, 35);
            this.cbxPaymentMethod.TabIndex = 37;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel1.Content = "Payment\\ Method";
            this.cuiLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.ForeColor = System.Drawing.Color.White;
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel1.Location = new System.Drawing.Point(423, 135);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(132, 35);
            this.cuiLabel1.TabIndex = 35;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblPatientName
            // 
            this.lblPatientName.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientName.Content = "Patient\\ Name:";
            this.lblPatientName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.Color.White;
            this.lblPatientName.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblPatientName.Location = new System.Drawing.Point(424, 53);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(313, 35);
            this.lblPatientName.TabIndex = 36;
            this.lblPatientName.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctorName.Content = "Doctor\\ Name:";
            this.lblDoctorName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.ForeColor = System.Drawing.Color.White;
            this.lblDoctorName.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblDoctorName.Location = new System.Drawing.Point(53, 53);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(313, 35);
            this.lblDoctorName.TabIndex = 36;
            this.lblDoctorName.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            this.tbxPaid.TabIndex = 34;
            this.tbxPaid.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxPaid.UnderlinedStyle = false;
            this.tbxPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPaid_KeyPress);
            this.tbxPaid.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPaid_Validating);
            // 
            // lblRemaining
            // 
            this.lblRemaining.BackColor = System.Drawing.Color.Transparent;
            this.lblRemaining.Content = "Remaining\\ Amount:";
            this.lblRemaining.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.ForeColor = System.Drawing.Color.White;
            this.lblRemaining.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblRemaining.Location = new System.Drawing.Point(423, 94);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(314, 35);
            this.lblRemaining.TabIndex = 27;
            this.lblRemaining.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            this.lblPayment.TabIndex = 27;
            this.lblPayment.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblVisitID
            // 
            this.lblVisitID.BackColor = System.Drawing.Color.Transparent;
            this.lblVisitID.Content = "Visit\\ ID:";
            this.lblVisitID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitID.ForeColor = System.Drawing.Color.White;
            this.lblVisitID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblVisitID.Location = new System.Drawing.Point(424, 12);
            this.lblVisitID.Name = "lblVisitID";
            this.lblVisitID.Size = new System.Drawing.Size(314, 35);
            this.lblVisitID.TabIndex = 28;
            this.lblVisitID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentID.Content = "Payment\\ ID:";
            this.lblPaymentID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentID.ForeColor = System.Drawing.Color.White;
            this.lblPaymentID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblPaymentID.Location = new System.Drawing.Point(53, 12);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(314, 35);
            this.lblPaymentID.TabIndex = 28;
            this.lblPaymentID.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            this.cuiPictureBox4.TabIndex = 29;
            // 
            // cuiPictureBox8
            // 
            this.cuiPictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox8.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.dollar;
            this.cuiPictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox8.Content = null;
            this.cuiPictureBox8.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox8.Location = new System.Drawing.Point(383, 94);
            this.cuiPictureBox8.Name = "cuiPictureBox8";
            this.cuiPictureBox8.OutlineThickness = 1F;
            this.cuiPictureBox8.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox8.Rotation = 0;
            this.cuiPictureBox8.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox8.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox8.TabIndex = 30;
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
            this.cuiPictureBox3.TabIndex = 30;
            // 
            // cuiPictureBox6
            // 
            this.cuiPictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox6.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.dollar;
            this.cuiPictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox6.Content = null;
            this.cuiPictureBox6.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox6.Location = new System.Drawing.Point(383, 135);
            this.cuiPictureBox6.Name = "cuiPictureBox6";
            this.cuiPictureBox6.OutlineThickness = 1F;
            this.cuiPictureBox6.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox6.Rotation = 0;
            this.cuiPictureBox6.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox6.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox6.TabIndex = 31;
            // 
            // cuiPictureBox7
            // 
            this.cuiPictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox7.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.healthy;
            this.cuiPictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox7.Content = null;
            this.cuiPictureBox7.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox7.Location = new System.Drawing.Point(383, 53);
            this.cuiPictureBox7.Name = "cuiPictureBox7";
            this.cuiPictureBox7.OutlineThickness = 1F;
            this.cuiPictureBox7.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox7.Rotation = 0;
            this.cuiPictureBox7.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox7.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox7.TabIndex = 32;
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
            this.cuiPictureBox1.TabIndex = 32;
            // 
            // cuiPictureBox5
            // 
            this.cuiPictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox5.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.key_tag;
            this.cuiPictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox5.Content = null;
            this.cuiPictureBox5.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox5.Location = new System.Drawing.Point(383, 12);
            this.cuiPictureBox5.Name = "cuiPictureBox5";
            this.cuiPictureBox5.OutlineThickness = 1F;
            this.cuiPictureBox5.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox5.Rotation = 0;
            this.cuiPictureBox5.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox5.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox5.TabIndex = 33;
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
            this.cuiPictureBox2.TabIndex = 33;
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.Controls.Add(this.btnSavePayment);
            this.cuiPanel2.Location = new System.Drawing.Point(12, 274);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(28);
            this.cuiPanel2.Size = new System.Drawing.Size(897, 58);
            this.cuiPanel2.TabIndex = 3;
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePayment.BackColor = System.Drawing.Color.Transparent;
            this.btnSavePayment.CheckButton = false;
            this.btnSavePayment.Checked = false;
            this.btnSavePayment.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSavePayment.CheckedForeColor = System.Drawing.Color.White;
            this.btnSavePayment.CheckedImageTint = System.Drawing.Color.White;
            this.btnSavePayment.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSavePayment.Content = "Save Payment";
            this.btnSavePayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePayment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSavePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePayment.ForeColor = System.Drawing.Color.White;
            this.btnSavePayment.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSavePayment.HoverForeColor = System.Drawing.Color.White;
            this.btnSavePayment.HoverImageTint = System.Drawing.Color.White;
            this.btnSavePayment.HoverOutline = System.Drawing.Color.White;
            this.btnSavePayment.Image = null;
            this.btnSavePayment.ImageAutoCenter = true;
            this.btnSavePayment.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSavePayment.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSavePayment.Location = new System.Drawing.Point(738, 9);
            this.btnSavePayment.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.NormalBackground = System.Drawing.Color.Transparent;
            this.btnSavePayment.NormalForeColor = System.Drawing.Color.White;
            this.btnSavePayment.NormalImageTint = System.Drawing.Color.White;
            this.btnSavePayment.NormalOutline = System.Drawing.Color.White;
            this.btnSavePayment.OutlineThickness = 1F;
            this.btnSavePayment.PressedBackground = System.Drawing.Color.White;
            this.btnSavePayment.PressedForeColor = System.Drawing.Color.Black;
            this.btnSavePayment.PressedImageTint = System.Drawing.Color.White;
            this.btnSavePayment.PressedOutline = System.Drawing.Color.White;
            this.btnSavePayment.Rounding = new System.Windows.Forms.Padding(19);
            this.btnSavePayment.Size = new System.Drawing.Size(149, 40);
            this.btnSavePayment.TabIndex = 25;
            this.btnSavePayment.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSavePayment.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click);
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // frmAddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 344);
            this.Controls.Add(this.cuiPanel2);
            this.Controls.Add(this.cuiPanel1);
            this.MaximumSize = new System.Drawing.Size(921, 344);
            this.MinimumSize = new System.Drawing.Size(921, 344);
            this.Name = "frmAddPayment";
            this.Text = "frmAddPayment";
            this.Load += new System.EventHandler(this.frmAddPayment_Load);
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.Controls.SetChildIndex(this.cuiPanel1, 0);
            this.Controls.SetChildIndex(this.cuiPanel2, 0);
            this.pnlBtnClose.ResumeLayout(false);
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiComboBox cbxPaymentMethod;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel lblDoctorName;
        protected CuoreUI.Controls.cuiTextBox tbxPaid;
        private CuoreUI.Controls.cuiLabel lblRemaining;
        private CuoreUI.Controls.cuiLabel lblPayment;
        private CuoreUI.Controls.cuiLabel lblVisitID;
        private CuoreUI.Controls.cuiLabel lblPaymentID;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox8;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox6;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox5;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiLabel lblPatientName;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox7;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        protected CuoreUI.Controls.cuiButton btnSavePayment;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
    }
}