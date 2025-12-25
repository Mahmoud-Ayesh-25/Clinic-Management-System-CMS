namespace Clinic_Manager_Proj.Users
{
    partial class frmShowUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowUserInfo));
            this.ctrlUserCard1 = new Clinic_Manager_Proj.Users.ctrlUserCard();
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
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.user__4_;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMainTitle.Content = "User\\ Information";
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
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 476);
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlUserCard1.Location = new System.Drawing.Point(0, 70);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(921, 124);
            this.ctrlUserCard1.TabIndex = 2;
            // 
            // ctrlPersonInfoCard1
            // 
            this.ctrlPersonInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlPersonInfoCard1.Location = new System.Drawing.Point(0, 182);
            this.ctrlPersonInfoCard1.Name = "ctrlPersonInfoCard1";
            this.ctrlPersonInfoCard1.Size = new System.Drawing.Size(921, 294);
            this.ctrlPersonInfoCard1.TabIndex = 3;
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // frmShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 476);
            this.Controls.Add(this.ctrlPersonInfoCard1);
            this.Controls.Add(this.ctrlUserCard1);
            this.MaximumSize = new System.Drawing.Size(921, 476);
            this.MinimumSize = new System.Drawing.Size(921, 476);
            this.Name = "frmShowUserInfo";
            this.Text = "frmShowUserInfo";
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.Controls.SetChildIndex(this.ctrlUserCard1, 0);
            this.Controls.SetChildIndex(this.ctrlPersonInfoCard1, 0);
            this.pnlBtnClose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUserCard ctrlUserCard1;
        private People.Controls.ctrlPersonInfoCard ctrlPersonInfoCard1;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
    }
}