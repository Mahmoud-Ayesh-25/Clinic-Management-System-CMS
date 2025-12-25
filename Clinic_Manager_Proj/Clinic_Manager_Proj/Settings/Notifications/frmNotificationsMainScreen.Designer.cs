namespace Clinic_Manager_Proj.Settings.Notifications
{
    partial class frmNotificationsMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotificationsMainScreen));
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.lblCompleted = new CuoreUI.Controls.cuiLabel();
            this.schNotifications = new CuoreUI.Controls.cuiSwitch();
            this.btnShow = new CuoreUI.Controls.cuiButton();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.pnlBtnClose.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            this.btnMaximized.Location = new System.Drawing.Point(560, 11);
            this.btnMaximized.Visible = false;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMinimized.Location = new System.Drawing.Point(560, 11);
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.notification_bell;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMainTitle.Content = "Notifications\\ Management";
            this.lblMainTitle.Size = new System.Drawing.Size(649, 58);
            // 
            // pnlBtnClose
            // 
            this.pnlBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtnClose.Location = new System.Drawing.Point(602, 11);
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Location = new System.Drawing.Point(2000, 0);
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 152);
            this.cuiResizeGrip.TargetForm = null;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Controls.Add(this.lblCompleted);
            this.cuiPanel1.Controls.Add(this.schNotifications);
            this.cuiPanel1.Controls.Add(this.btnShow);
            this.cuiPanel1.Location = new System.Drawing.Point(12, 82);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(27);
            this.cuiPanel1.Size = new System.Drawing.Size(649, 58);
            this.cuiPanel1.TabIndex = 2;
            // 
            // lblCompleted
            // 
            this.lblCompleted.BackColor = System.Drawing.Color.Transparent;
            this.lblCompleted.Content = "Enable\\ Notifications";
            this.lblCompleted.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.ForeColor = System.Drawing.Color.White;
            this.lblCompleted.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblCompleted.Location = new System.Drawing.Point(9, 9);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(146, 40);
            this.lblCompleted.TabIndex = 31;
            this.lblCompleted.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // schNotifications
            // 
            this.schNotifications.BackColor = System.Drawing.Color.Transparent;
            this.schNotifications.Checked = true;
            this.schNotifications.CheckedBackground = System.Drawing.Color.Green;
            this.schNotifications.CheckedForeground = System.Drawing.Color.White;
            this.schNotifications.CheckedOutlineColor = System.Drawing.Color.Empty;
            this.schNotifications.CheckedSymbolColor = System.Drawing.Color.Green;
            this.schNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.schNotifications.Location = new System.Drawing.Point(161, 16);
            this.schNotifications.MinimumSize = new System.Drawing.Size(12, 8);
            this.schNotifications.Name = "schNotifications";
            this.schNotifications.OutlineThickness = 1F;
            this.schNotifications.ShowSymbols = false;
            this.schNotifications.Size = new System.Drawing.Size(48, 26);
            this.schNotifications.TabIndex = 30;
            this.schNotifications.ThumbSizeModifier = new System.Drawing.Size(0, 0);
            this.schNotifications.UncheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.schNotifications.UncheckedForeground = System.Drawing.Color.White;
            this.schNotifications.UncheckedOutlineColor = System.Drawing.Color.Empty;
            this.schNotifications.UncheckedSymbolColor = System.Drawing.Color.Gray;
            this.schNotifications.CheckedChanged += new System.EventHandler(this.schCompletedOnly_CheckedChanged);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.CheckButton = false;
            this.btnShow.Checked = false;
            this.btnShow.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShow.CheckedForeColor = System.Drawing.Color.White;
            this.btnShow.CheckedImageTint = System.Drawing.Color.White;
            this.btnShow.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShow.Content = "Show All Notifications";
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShow.HoverForeColor = System.Drawing.Color.White;
            this.btnShow.HoverImageTint = System.Drawing.Color.White;
            this.btnShow.HoverOutline = System.Drawing.Color.White;
            this.btnShow.Image = null;
            this.btnShow.ImageAutoCenter = true;
            this.btnShow.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnShow.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnShow.Location = new System.Drawing.Point(411, 9);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.NormalBackground = System.Drawing.Color.Transparent;
            this.btnShow.NormalForeColor = System.Drawing.Color.White;
            this.btnShow.NormalImageTint = System.Drawing.Color.White;
            this.btnShow.NormalOutline = System.Drawing.Color.White;
            this.btnShow.OutlineThickness = 1F;
            this.btnShow.PressedBackground = System.Drawing.Color.White;
            this.btnShow.PressedForeColor = System.Drawing.Color.Black;
            this.btnShow.PressedImageTint = System.Drawing.Color.White;
            this.btnShow.PressedOutline = System.Drawing.Color.White;
            this.btnShow.Rounding = new System.Windows.Forms.Padding(19);
            this.btnShow.Size = new System.Drawing.Size(230, 40);
            this.btnShow.TabIndex = 17;
            this.btnShow.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnShow.TextOffset = new System.Drawing.Point(0, 0);
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // frmNotificationsMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 152);
            this.Controls.Add(this.cuiPanel1);
            this.MaximumSize = new System.Drawing.Size(673, 152);
            this.MinimumSize = new System.Drawing.Size(673, 152);
            this.Name = "frmNotificationsMainScreen";
            this.Text = "frmNotificationsMainScreen";
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.Controls.SetChildIndex(this.cuiPanel1, 0);
            this.pnlBtnClose.ResumeLayout(false);
            this.cuiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        protected CuoreUI.Controls.cuiButton btnShow;
        private CuoreUI.Controls.cuiLabel lblCompleted;
        private CuoreUI.Controls.cuiSwitch schNotifications;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
    }
}