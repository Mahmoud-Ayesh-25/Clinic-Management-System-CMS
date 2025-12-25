namespace Clinic_Manager_Proj.Settings.Notifications
{
    partial class frmManageNotifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageNotifications));
            this.schDateFilter = new CuoreUI.Controls.cuiSwitch();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFilterContainer.SuspendLayout();
            this.pnlBtnClose.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Content = "Add ";
            this.btnAdd.Visible = false;
            // 
            // cbxFilter
            // 
            this.cbxFilter.Items = new string[0];
            this.cbxFilter.Visible = false;
            // 
            // tbxFilter
            // 
            this.tbxFilter.Location = new System.Drawing.Point(507, 9);
            this.tbxFilter.Visible = false;
            // 
            // cbxSubFilter
            // 
            this.cbxSubFilter.Items = new string[0];
            this.cbxSubFilter.Location = new System.Drawing.Point(507, 9);
            // 
            // cdpDate
            // 
            this.cdpDate.Location = new System.Drawing.Point(9, 9);
            this.cdpDate.Visible = true;
            // 
            // pnlFilterContainer
            // 
            this.pnlFilterContainer.Controls.Add(this.schDateFilter);
            this.pnlFilterContainer.Controls.SetChildIndex(this.tbxFilter, 0);
            this.pnlFilterContainer.Controls.SetChildIndex(this.btnAdd, 0);
            this.pnlFilterContainer.Controls.SetChildIndex(this.cbxFilter, 0);
            this.pnlFilterContainer.Controls.SetChildIndex(this.cbxSubFilter, 0);
            this.pnlFilterContainer.Controls.SetChildIndex(this.cdpDate, 0);
            this.pnlFilterContainer.Controls.SetChildIndex(this.schDateFilter, 0);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.notification_bell;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Content = "Notifications";
            // 
            // schDateFilter
            // 
            this.schDateFilter.BackColor = System.Drawing.Color.Transparent;
            this.schDateFilter.Checked = true;
            this.schDateFilter.CheckedBackground = System.Drawing.Color.Green;
            this.schDateFilter.CheckedForeground = System.Drawing.Color.White;
            this.schDateFilter.CheckedOutlineColor = System.Drawing.Color.Empty;
            this.schDateFilter.CheckedSymbolColor = System.Drawing.Color.Green;
            this.schDateFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.schDateFilter.Location = new System.Drawing.Point(237, 16);
            this.schDateFilter.MinimumSize = new System.Drawing.Size(12, 8);
            this.schDateFilter.Name = "schDateFilter";
            this.schDateFilter.OutlineThickness = 1F;
            this.schDateFilter.ShowSymbols = false;
            this.schDateFilter.Size = new System.Drawing.Size(48, 26);
            this.schDateFilter.TabIndex = 29;
            this.schDateFilter.ThumbSizeModifier = new System.Drawing.Size(0, 0);
            this.schDateFilter.UncheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.schDateFilter.UncheckedForeground = System.Drawing.Color.White;
            this.schDateFilter.UncheckedOutlineColor = System.Drawing.Color.Empty;
            this.schDateFilter.UncheckedSymbolColor = System.Drawing.Color.Gray;
            this.schDateFilter.CheckedChanged += new System.EventHandler(this.schDateFilter_CheckedChanged);
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // showInfoToolStripMenuItem1
            // 
            this.showInfoToolStripMenuItem1.Image = global::Clinic_Manager_Proj.Properties.Resources.eye;
            this.showInfoToolStripMenuItem1.Name = "showInfoToolStripMenuItem1";
            this.showInfoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.showInfoToolStripMenuItem1.Text = "Show Info";
            this.showInfoToolStripMenuItem1.Click += new System.EventHandler(this.showInfoToolStripMenuItem1_Click);
            // 
            // frmManageNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 780);
            this.Name = "frmManageNotifications";
            this.Text = "frmManageNotifications";
            this.Load += new System.EventHandler(this.frmManageNotifications_Load);
            this.SizeChanged += new System.EventHandler(this.frmManageNotifications_SizeChanged);
            this.Controls.SetChildIndex(this.pnlFilterContainer, 0);
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.Controls.SetChildIndex(this.pnlDgvContainer, 0);
            this.Controls.SetChildIndex(this.lblRecordes, 0);
            this.pnlFilterContainer.ResumeLayout(false);
            this.pnlBtnClose.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiSwitch schDateFilter;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showInfoToolStripMenuItem1;
    }
}