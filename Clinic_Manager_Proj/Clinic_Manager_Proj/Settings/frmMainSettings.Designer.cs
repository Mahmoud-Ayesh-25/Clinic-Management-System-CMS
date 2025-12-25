namespace Clinic_Manager_Proj.Settings
{
    partial class frmMainSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainSettings));
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.btnPaymentMethods = new CuoreUI.Controls.cuiButton();
            this.btnNotifications = new CuoreUI.Controls.cuiButton();
            this.btnEditCurrentUser = new CuoreUI.Controls.cuiButton();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.pnlBtnClose.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            this.btnMaximized.Location = new System.Drawing.Point(287, 11);
            this.btnMaximized.Visible = false;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMinimized.Location = new System.Drawing.Point(287, 11);
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.settings;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMainTitle.Content = "Settings";
            this.lblMainTitle.Size = new System.Drawing.Size(376, 58);
            // 
            // pnlBtnClose
            // 
            this.pnlBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtnClose.Location = new System.Drawing.Point(329, 11);
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Location = new System.Drawing.Point(2000, -277);
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 323);
            this.cuiResizeGrip.TargetForm = null;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Controls.Add(this.btnPaymentMethods);
            this.cuiPanel1.Controls.Add(this.btnNotifications);
            this.cuiPanel1.Controls.Add(this.btnEditCurrentUser);
            this.cuiPanel1.Location = new System.Drawing.Point(12, 82);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel1.Size = new System.Drawing.Size(376, 230);
            this.cuiPanel1.TabIndex = 2;
            // 
            // btnPaymentMethods
            // 
            this.btnPaymentMethods.BackColor = System.Drawing.Color.Transparent;
            this.btnPaymentMethods.CheckButton = false;
            this.btnPaymentMethods.Checked = false;
            this.btnPaymentMethods.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnPaymentMethods.CheckedForeColor = System.Drawing.Color.White;
            this.btnPaymentMethods.CheckedImageTint = System.Drawing.Color.White;
            this.btnPaymentMethods.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnPaymentMethods.Content = "Payment Mehtods Management";
            this.btnPaymentMethods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaymentMethods.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPaymentMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentMethods.ForeColor = System.Drawing.Color.White;
            this.btnPaymentMethods.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPaymentMethods.HoverForeColor = System.Drawing.Color.White;
            this.btnPaymentMethods.HoverImageTint = System.Drawing.Color.White;
            this.btnPaymentMethods.HoverOutline = System.Drawing.Color.White;
            this.btnPaymentMethods.Image = null;
            this.btnPaymentMethods.ImageAutoCenter = true;
            this.btnPaymentMethods.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnPaymentMethods.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPaymentMethods.Location = new System.Drawing.Point(25, 161);
            this.btnPaymentMethods.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnPaymentMethods.Name = "btnPaymentMethods";
            this.btnPaymentMethods.NormalBackground = System.Drawing.Color.Transparent;
            this.btnPaymentMethods.NormalForeColor = System.Drawing.Color.White;
            this.btnPaymentMethods.NormalImageTint = System.Drawing.Color.White;
            this.btnPaymentMethods.NormalOutline = System.Drawing.Color.White;
            this.btnPaymentMethods.OutlineThickness = 1F;
            this.btnPaymentMethods.PressedBackground = System.Drawing.Color.White;
            this.btnPaymentMethods.PressedForeColor = System.Drawing.Color.Black;
            this.btnPaymentMethods.PressedImageTint = System.Drawing.Color.White;
            this.btnPaymentMethods.PressedOutline = System.Drawing.Color.White;
            this.btnPaymentMethods.Rounding = new System.Windows.Forms.Padding(22);
            this.btnPaymentMethods.Size = new System.Drawing.Size(326, 45);
            this.btnPaymentMethods.TabIndex = 15;
            this.btnPaymentMethods.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPaymentMethods.TextOffset = new System.Drawing.Point(0, 0);
            this.btnPaymentMethods.Click += new System.EventHandler(this.btnPaymentMethods_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.BackColor = System.Drawing.Color.Transparent;
            this.btnNotifications.CheckButton = false;
            this.btnNotifications.Checked = false;
            this.btnNotifications.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnNotifications.CheckedForeColor = System.Drawing.Color.White;
            this.btnNotifications.CheckedImageTint = System.Drawing.Color.White;
            this.btnNotifications.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnNotifications.Content = "Notifications Management";
            this.btnNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotifications.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.ForeColor = System.Drawing.Color.White;
            this.btnNotifications.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNotifications.HoverForeColor = System.Drawing.Color.White;
            this.btnNotifications.HoverImageTint = System.Drawing.Color.White;
            this.btnNotifications.HoverOutline = System.Drawing.Color.White;
            this.btnNotifications.Image = null;
            this.btnNotifications.ImageAutoCenter = true;
            this.btnNotifications.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnNotifications.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNotifications.Location = new System.Drawing.Point(25, 93);
            this.btnNotifications.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.NormalBackground = System.Drawing.Color.Transparent;
            this.btnNotifications.NormalForeColor = System.Drawing.Color.White;
            this.btnNotifications.NormalImageTint = System.Drawing.Color.White;
            this.btnNotifications.NormalOutline = System.Drawing.Color.White;
            this.btnNotifications.OutlineThickness = 1F;
            this.btnNotifications.PressedBackground = System.Drawing.Color.White;
            this.btnNotifications.PressedForeColor = System.Drawing.Color.Black;
            this.btnNotifications.PressedImageTint = System.Drawing.Color.White;
            this.btnNotifications.PressedOutline = System.Drawing.Color.White;
            this.btnNotifications.Rounding = new System.Windows.Forms.Padding(22);
            this.btnNotifications.Size = new System.Drawing.Size(326, 45);
            this.btnNotifications.TabIndex = 15;
            this.btnNotifications.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnNotifications.TextOffset = new System.Drawing.Point(0, 0);
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // btnEditCurrentUser
            // 
            this.btnEditCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.btnEditCurrentUser.CheckButton = false;
            this.btnEditCurrentUser.Checked = false;
            this.btnEditCurrentUser.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnEditCurrentUser.CheckedForeColor = System.Drawing.Color.White;
            this.btnEditCurrentUser.CheckedImageTint = System.Drawing.Color.White;
            this.btnEditCurrentUser.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnEditCurrentUser.Content = "Edit Current User";
            this.btnEditCurrentUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCurrentUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCurrentUser.ForeColor = System.Drawing.Color.White;
            this.btnEditCurrentUser.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditCurrentUser.HoverForeColor = System.Drawing.Color.White;
            this.btnEditCurrentUser.HoverImageTint = System.Drawing.Color.White;
            this.btnEditCurrentUser.HoverOutline = System.Drawing.Color.White;
            this.btnEditCurrentUser.Image = null;
            this.btnEditCurrentUser.ImageAutoCenter = true;
            this.btnEditCurrentUser.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnEditCurrentUser.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnEditCurrentUser.Location = new System.Drawing.Point(25, 25);
            this.btnEditCurrentUser.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnEditCurrentUser.Name = "btnEditCurrentUser";
            this.btnEditCurrentUser.NormalBackground = System.Drawing.Color.Transparent;
            this.btnEditCurrentUser.NormalForeColor = System.Drawing.Color.White;
            this.btnEditCurrentUser.NormalImageTint = System.Drawing.Color.White;
            this.btnEditCurrentUser.NormalOutline = System.Drawing.Color.White;
            this.btnEditCurrentUser.OutlineThickness = 1F;
            this.btnEditCurrentUser.PressedBackground = System.Drawing.Color.White;
            this.btnEditCurrentUser.PressedForeColor = System.Drawing.Color.Black;
            this.btnEditCurrentUser.PressedImageTint = System.Drawing.Color.White;
            this.btnEditCurrentUser.PressedOutline = System.Drawing.Color.White;
            this.btnEditCurrentUser.Rounding = new System.Windows.Forms.Padding(22);
            this.btnEditCurrentUser.Size = new System.Drawing.Size(326, 45);
            this.btnEditCurrentUser.TabIndex = 15;
            this.btnEditCurrentUser.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEditCurrentUser.TextOffset = new System.Drawing.Point(0, 0);
            this.btnEditCurrentUser.Click += new System.EventHandler(this.btnEditCurrentUser_Click);
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // frmMainSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 323);
            this.Controls.Add(this.cuiPanel1);
            this.MaximumSize = new System.Drawing.Size(400, 323);
            this.MinimumSize = new System.Drawing.Size(400, 323);
            this.Name = "frmMainSettings";
            this.Text = "frmMainSettings";
            this.Load += new System.EventHandler(this.frmMainSettings_Load);
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.Controls.SetChildIndex(this.cuiPanel1, 0);
            this.pnlBtnClose.ResumeLayout(false);
            this.cuiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButton btnEditCurrentUser;
        private CuoreUI.Controls.cuiButton btnPaymentMethods;
        private CuoreUI.Controls.cuiButton btnNotifications;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
    }
}