namespace Clinic_Manager_Proj.Visits
{
    partial class frmEditVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditVisit));
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.cuiLabel7 = new CuoreUI.Controls.cuiLabel();
            this.schEMERG = new CuoreUI.Controls.cuiSwitch();
            this.cuiPictureBox12 = new CuoreUI.Controls.cuiPictureBox();
            this.tbxPrescription = new CuoreUI.Controls.cuiTextBox();
            this.tbxNotes = new CuoreUI.Controls.cuiTextBox();
            this.tbxDiagnosis = new CuoreUI.Controls.cuiTextBox();
            this.cuiPictureBox7 = new CuoreUI.Controls.cuiPictureBox();
            this.tbxSymptoms = new CuoreUI.Controls.cuiTextBox();
            this.cuiPictureBox6 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox5 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.lblDoctorName = new CuoreUI.Controls.cuiLabel();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.lblPatientName = new CuoreUI.Controls.cuiLabel();
            this.lblID = new CuoreUI.Controls.cuiLabel();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.btnSave = new CuoreUI.Controls.cuiButton();
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
            this.btnMaximized.Location = new System.Drawing.Point(688, 11);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMinimized.Location = new System.Drawing.Point(688, 11);
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.doctor_visit;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMainTitle.Content = "Edit\\ Visit";
            this.lblMainTitle.Size = new System.Drawing.Size(777, 58);
            // 
            // pnlBtnClose
            // 
            this.pnlBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtnClose.Location = new System.Drawing.Point(730, 11);
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Location = new System.Drawing.Point(2000, -12);
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 656);
            this.cuiResizeGrip.TargetForm = null;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.cuiLabel7);
            this.cuiPanel1.Controls.Add(this.schEMERG);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox12);
            this.cuiPanel1.Controls.Add(this.tbxPrescription);
            this.cuiPanel1.Controls.Add(this.tbxNotes);
            this.cuiPanel1.Controls.Add(this.tbxDiagnosis);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox7);
            this.cuiPanel1.Controls.Add(this.tbxSymptoms);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox6);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox5);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox4);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox3);
            this.cuiPanel1.Controls.Add(this.lblDoctorName);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox1);
            this.cuiPanel1.Controls.Add(this.lblPatientName);
            this.cuiPanel1.Controls.Add(this.lblID);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox2);
            this.cuiPanel1.Location = new System.Drawing.Point(12, 82);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel1.Size = new System.Drawing.Size(777, 492);
            this.cuiPanel1.TabIndex = 2;
            // 
            // cuiLabel7
            // 
            this.cuiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.cuiLabel7.Content = "Emergency\\ Income";
            this.cuiLabel7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel7.ForeColor = System.Drawing.Color.White;
            this.cuiLabel7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel7.Location = new System.Drawing.Point(54, 446);
            this.cuiLabel7.Name = "cuiLabel7";
            this.cuiLabel7.Size = new System.Drawing.Size(140, 35);
            this.cuiLabel7.TabIndex = 31;
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
            this.schEMERG.Location = new System.Drawing.Point(198, 451);
            this.schEMERG.MinimumSize = new System.Drawing.Size(12, 8);
            this.schEMERG.Name = "schEMERG";
            this.schEMERG.OutlineThickness = 1F;
            this.schEMERG.ShowSymbols = false;
            this.schEMERG.Size = new System.Drawing.Size(48, 26);
            this.schEMERG.TabIndex = 30;
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
            this.cuiPictureBox12.Location = new System.Drawing.Point(12, 445);
            this.cuiPictureBox12.Name = "cuiPictureBox12";
            this.cuiPictureBox12.OutlineThickness = 1F;
            this.cuiPictureBox12.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox12.Rotation = 0;
            this.cuiPictureBox12.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox12.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox12.TabIndex = 29;
            // 
            // tbxPrescription
            // 
            this.tbxPrescription.BackColor = System.Drawing.Color.Transparent;
            this.tbxPrescription.BackgroundColor = System.Drawing.Color.Black;
            this.tbxPrescription.Content = "";
            this.tbxPrescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPrescription.FocusBackgroundColor = System.Drawing.Color.Black;
            this.tbxPrescription.FocusImageTint = System.Drawing.Color.White;
            this.tbxPrescription.FocusOutlineColor = System.Drawing.Color.White;
            this.tbxPrescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrescription.ForeColor = System.Drawing.Color.White;
            this.tbxPrescription.Image = null;
            this.tbxPrescription.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxPrescription.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxPrescription.Location = new System.Drawing.Point(53, 369);
            this.tbxPrescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPrescription.Multiline = true;
            this.tbxPrescription.Name = "tbxPrescription";
            this.tbxPrescription.NormalImageTint = System.Drawing.Color.White;
            this.tbxPrescription.OutlineColor = System.Drawing.Color.Black;
            this.tbxPrescription.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.tbxPrescription.PasswordChar = false;
            this.tbxPrescription.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxPrescription.PlaceholderText = "Prescription";
            this.tbxPrescription.Rounding = new System.Windows.Forms.Padding(17);
            this.tbxPrescription.Size = new System.Drawing.Size(710, 70);
            this.tbxPrescription.TabIndex = 23;
            this.tbxPrescription.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxPrescription.UnderlinedStyle = false;
            this.tbxPrescription.Validating += new System.ComponentModel.CancelEventHandler(this.tbxSymptoms_Validating);
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
            this.tbxNotes.Location = new System.Drawing.Point(53, 291);
            this.tbxNotes.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNotes.Multiline = true;
            this.tbxNotes.Name = "tbxNotes";
            this.tbxNotes.NormalImageTint = System.Drawing.Color.White;
            this.tbxNotes.OutlineColor = System.Drawing.Color.Black;
            this.tbxNotes.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.tbxNotes.PasswordChar = false;
            this.tbxNotes.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxNotes.PlaceholderText = "Notes";
            this.tbxNotes.Rounding = new System.Windows.Forms.Padding(17);
            this.tbxNotes.Size = new System.Drawing.Size(710, 70);
            this.tbxNotes.TabIndex = 23;
            this.tbxNotes.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxNotes.UnderlinedStyle = false;
            // 
            // tbxDiagnosis
            // 
            this.tbxDiagnosis.BackColor = System.Drawing.Color.Transparent;
            this.tbxDiagnosis.BackgroundColor = System.Drawing.Color.Black;
            this.tbxDiagnosis.Content = "";
            this.tbxDiagnosis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxDiagnosis.FocusBackgroundColor = System.Drawing.Color.Black;
            this.tbxDiagnosis.FocusImageTint = System.Drawing.Color.White;
            this.tbxDiagnosis.FocusOutlineColor = System.Drawing.Color.White;
            this.tbxDiagnosis.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiagnosis.ForeColor = System.Drawing.Color.White;
            this.tbxDiagnosis.Image = null;
            this.tbxDiagnosis.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxDiagnosis.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxDiagnosis.Location = new System.Drawing.Point(53, 213);
            this.tbxDiagnosis.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDiagnosis.Multiline = true;
            this.tbxDiagnosis.Name = "tbxDiagnosis";
            this.tbxDiagnosis.NormalImageTint = System.Drawing.Color.White;
            this.tbxDiagnosis.OutlineColor = System.Drawing.Color.Black;
            this.tbxDiagnosis.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.tbxDiagnosis.PasswordChar = false;
            this.tbxDiagnosis.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxDiagnosis.PlaceholderText = "Diagnosis";
            this.tbxDiagnosis.Rounding = new System.Windows.Forms.Padding(17);
            this.tbxDiagnosis.Size = new System.Drawing.Size(710, 70);
            this.tbxDiagnosis.TabIndex = 23;
            this.tbxDiagnosis.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxDiagnosis.UnderlinedStyle = false;
            this.tbxDiagnosis.Validating += new System.ComponentModel.CancelEventHandler(this.tbxSymptoms_Validating);
            // 
            // cuiPictureBox7
            // 
            this.cuiPictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox7.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.prescription;
            this.cuiPictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox7.Content = null;
            this.cuiPictureBox7.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox7.Location = new System.Drawing.Point(12, 369);
            this.cuiPictureBox7.Name = "cuiPictureBox7";
            this.cuiPictureBox7.OutlineThickness = 1F;
            this.cuiPictureBox7.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox7.Rotation = 0;
            this.cuiPictureBox7.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox7.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox7.TabIndex = 22;
            // 
            // tbxSymptoms
            // 
            this.tbxSymptoms.BackColor = System.Drawing.Color.Transparent;
            this.tbxSymptoms.BackgroundColor = System.Drawing.Color.Black;
            this.tbxSymptoms.Content = "";
            this.tbxSymptoms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSymptoms.FocusBackgroundColor = System.Drawing.Color.Black;
            this.tbxSymptoms.FocusImageTint = System.Drawing.Color.White;
            this.tbxSymptoms.FocusOutlineColor = System.Drawing.Color.White;
            this.tbxSymptoms.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSymptoms.ForeColor = System.Drawing.Color.White;
            this.tbxSymptoms.Image = null;
            this.tbxSymptoms.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxSymptoms.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxSymptoms.Location = new System.Drawing.Point(53, 135);
            this.tbxSymptoms.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSymptoms.Multiline = true;
            this.tbxSymptoms.Name = "tbxSymptoms";
            this.tbxSymptoms.NormalImageTint = System.Drawing.Color.White;
            this.tbxSymptoms.OutlineColor = System.Drawing.Color.Black;
            this.tbxSymptoms.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.tbxSymptoms.PasswordChar = false;
            this.tbxSymptoms.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxSymptoms.PlaceholderText = "Symptoms";
            this.tbxSymptoms.Rounding = new System.Windows.Forms.Padding(17);
            this.tbxSymptoms.Size = new System.Drawing.Size(710, 70);
            this.tbxSymptoms.TabIndex = 23;
            this.tbxSymptoms.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxSymptoms.UnderlinedStyle = false;
            this.tbxSymptoms.Validating += new System.ComponentModel.CancelEventHandler(this.tbxSymptoms_Validating);
            // 
            // cuiPictureBox6
            // 
            this.cuiPictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox6.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.note;
            this.cuiPictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox6.Content = null;
            this.cuiPictureBox6.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox6.Location = new System.Drawing.Point(12, 291);
            this.cuiPictureBox6.Name = "cuiPictureBox6";
            this.cuiPictureBox6.OutlineThickness = 1F;
            this.cuiPictureBox6.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox6.Rotation = 0;
            this.cuiPictureBox6.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox6.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox6.TabIndex = 22;
            // 
            // cuiPictureBox5
            // 
            this.cuiPictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox5.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.diagnosis;
            this.cuiPictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox5.Content = null;
            this.cuiPictureBox5.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox5.Location = new System.Drawing.Point(12, 213);
            this.cuiPictureBox5.Name = "cuiPictureBox5";
            this.cuiPictureBox5.OutlineThickness = 1F;
            this.cuiPictureBox5.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox5.Rotation = 0;
            this.cuiPictureBox5.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox5.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox5.TabIndex = 22;
            // 
            // cuiPictureBox4
            // 
            this.cuiPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox4.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.symptoms;
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
            this.cuiPictureBox4.TabIndex = 22;
            // 
            // cuiPictureBox3
            // 
            this.cuiPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox3.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.id_card__2_;
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
            this.cuiPictureBox3.TabIndex = 6;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctorName.Content = "Doctor\\ Name:\\ ";
            this.lblDoctorName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.ForeColor = System.Drawing.Color.White;
            this.lblDoctorName.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblDoctorName.Location = new System.Drawing.Point(53, 94);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(680, 35);
            this.lblDoctorName.TabIndex = 2;
            this.lblDoctorName.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox1.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.id_card__2_;
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
            this.cuiPictureBox1.TabIndex = 7;
            // 
            // lblPatientName
            // 
            this.lblPatientName.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientName.Content = "Patient\\ Name:";
            this.lblPatientName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.Color.White;
            this.lblPatientName.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblPatientName.Location = new System.Drawing.Point(53, 53);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(680, 35);
            this.lblPatientName.TabIndex = 3;
            this.lblPatientName.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Content = "Visit\\ ID:";
            this.lblID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblID.Location = new System.Drawing.Point(53, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(314, 35);
            this.lblID.TabIndex = 5;
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
            // cuiPanel2
            // 
            this.cuiPanel2.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel2.Controls.Add(this.btnSave);
            this.cuiPanel2.Location = new System.Drawing.Point(12, 586);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(28);
            this.cuiPanel2.Size = new System.Drawing.Size(777, 58);
            this.cuiPanel2.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.CheckButton = false;
            this.btnSave.Checked = false;
            this.btnSave.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSave.CheckedForeColor = System.Drawing.Color.White;
            this.btnSave.CheckedImageTint = System.Drawing.Color.White;
            this.btnSave.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSave.Content = "Save Visit";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.HoverForeColor = System.Drawing.Color.White;
            this.btnSave.HoverImageTint = System.Drawing.Color.White;
            this.btnSave.HoverOutline = System.Drawing.Color.White;
            this.btnSave.Image = null;
            this.btnSave.ImageAutoCenter = true;
            this.btnSave.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSave.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSave.Location = new System.Drawing.Point(607, 9);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.NormalBackground = System.Drawing.Color.Transparent;
            this.btnSave.NormalForeColor = System.Drawing.Color.White;
            this.btnSave.NormalImageTint = System.Drawing.Color.White;
            this.btnSave.NormalOutline = System.Drawing.Color.White;
            this.btnSave.OutlineThickness = 1F;
            this.btnSave.PressedBackground = System.Drawing.Color.White;
            this.btnSave.PressedForeColor = System.Drawing.Color.Black;
            this.btnSave.PressedImageTint = System.Drawing.Color.White;
            this.btnSave.PressedOutline = System.Drawing.Color.White;
            this.btnSave.Rounding = new System.Windows.Forms.Padding(19);
            this.btnSave.Size = new System.Drawing.Size(161, 40);
            this.btnSave.TabIndex = 26;
            this.btnSave.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSave.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // frmEditVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 656);
            this.Controls.Add(this.cuiPanel2);
            this.Controls.Add(this.cuiPanel1);
            this.MaximumSize = new System.Drawing.Size(801, 656);
            this.MinimumSize = new System.Drawing.Size(801, 656);
            this.Name = "frmEditVisit";
            this.Text = "frmEditVisit";
            this.Load += new System.EventHandler(this.frmEditVisit_Load);
            this.Controls.SetChildIndex(this.cuiPanel1, 0);
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.Controls.SetChildIndex(this.cuiPanel2, 0);
            this.pnlBtnClose.ResumeLayout(false);
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiLabel lblDoctorName;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiLabel lblPatientName;
        private CuoreUI.Controls.cuiLabel lblID;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        protected CuoreUI.Controls.cuiTextBox tbxSymptoms;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
        protected CuoreUI.Controls.cuiTextBox tbxPrescription;
        protected CuoreUI.Controls.cuiTextBox tbxNotes;
        protected CuoreUI.Controls.cuiTextBox tbxDiagnosis;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox7;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox6;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox5;
        private CuoreUI.Controls.cuiLabel cuiLabel7;
        private CuoreUI.Controls.cuiSwitch schEMERG;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox12;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        protected CuoreUI.Controls.cuiButton btnSave;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
    }
}