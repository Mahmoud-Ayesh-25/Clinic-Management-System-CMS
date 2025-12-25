namespace Clinic_Manager_Proj.Doctors
{
    partial class frmShowDoctorInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowDoctorInfo));
            this.ctrlDoctorCard1 = new Clinic_Manager_Proj.Doctors.ctrlDoctorCard();
            this.ctrlPersonInfoCard1 = new Clinic_Manager_Proj.People.Controls.ctrlPersonInfoCard();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.pnlBtnClose.SuspendLayout();
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
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.doctor;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMainTitle.Content = "Doctor\\ Information";
            this.lblMainTitle.Size = new System.Drawing.Size(897, 58);
            // 
            // pnlBtnClose
            // 
            this.pnlBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtnClose.Location = new System.Drawing.Point(850, 11);
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Location = new System.Drawing.Point(2000, -96);
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 684);
            this.cuiResizeGrip.TargetForm = null;
            // 
            // ctrlDoctorCard1
            // 
            this.ctrlDoctorCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlDoctorCard1.Location = new System.Drawing.Point(0, 70);
            this.ctrlDoctorCard1.Name = "ctrlDoctorCard1";
            this.ctrlDoctorCard1.Size = new System.Drawing.Size(921, 332);
            this.ctrlDoctorCard1.TabIndex = 2;
            // 
            // ctrlPersonInfoCard1
            // 
            this.ctrlPersonInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlPersonInfoCard1.Location = new System.Drawing.Point(0, 390);
            this.ctrlPersonInfoCard1.Name = "ctrlPersonInfoCard1";
            this.ctrlPersonInfoCard1.Size = new System.Drawing.Size(921, 294);
            this.ctrlPersonInfoCard1.TabIndex = 3;
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // frmShowDoctorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 684);
            this.Controls.Add(this.ctrlPersonInfoCard1);
            this.Controls.Add(this.ctrlDoctorCard1);
            this.MaximumSize = new System.Drawing.Size(921, 684);
            this.MinimumSize = new System.Drawing.Size(921, 684);
            this.Name = "frmShowDoctorInfo";
            this.Text = "frmShowDoctorInfo";
            this.Load += new System.EventHandler(this.frmShowDoctorInfo_Load);
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.Controls.SetChildIndex(this.ctrlDoctorCard1, 0);
            this.Controls.SetChildIndex(this.ctrlPersonInfoCard1, 0);
            this.pnlBtnClose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDoctorCard ctrlDoctorCard1;
        private People.Controls.ctrlPersonInfoCard ctrlPersonInfoCard1;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
    }
}