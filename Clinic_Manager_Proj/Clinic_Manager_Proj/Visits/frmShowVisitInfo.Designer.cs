namespace Clinic_Manager_Proj.Visits
{
    partial class frmShowVisitInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowVisitInfo));
            this.ctrlVisitCard1 = new Clinic_Manager_Proj.Visits.Controls.ctrlVisitCard();
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
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.doctor_visit;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMainTitle.Content = "Visit\\ Information";
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
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 772);
            this.cuiResizeGrip.TargetForm = null;
            // 
            // ctrlVisitCard1
            // 
            this.ctrlVisitCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlVisitCard1.Location = new System.Drawing.Point(0, 70);
            this.ctrlVisitCard1.Name = "ctrlVisitCard1";
            this.ctrlVisitCard1.Size = new System.Drawing.Size(921, 702);
            this.ctrlVisitCard1.TabIndex = 2;
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // frmShowVisitInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 772);
            this.Controls.Add(this.ctrlVisitCard1);
            this.MaximumSize = new System.Drawing.Size(921, 772);
            this.MinimumSize = new System.Drawing.Size(921, 772);
            this.Name = "frmShowVisitInfo";
            this.Text = "frmShowVisitInfo";
            this.Load += new System.EventHandler(this.frmShowVisitInfo_Load);
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.Controls.SetChildIndex(this.ctrlVisitCard1, 0);
            this.pnlBtnClose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlVisitCard ctrlVisitCard1;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
    }
}