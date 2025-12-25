namespace Clinic_Manager_Proj.Payments
{
    partial class frmManagePayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePayments));
            this.schDateFilter = new CuoreUI.Controls.cuiSwitch();
            this.schCompletedOnly = new CuoreUI.Controls.cuiSwitch();
            this.lblCompleted = new CuoreUI.Controls.cuiLabel();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlFilterContainer.SuspendLayout();
            this.pnlBtnClose.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Visible = false;
            // 
            // cbxFilter
            // 
            this.cbxFilter.Items = new string[] {
        "Filter",
        "Payment ID",
        "Visit ID",
        "Payment Method"};
            this.cbxFilter.SelectedItem = "Filter";
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // tbxFilter
            // 
            this.tbxFilter.Visible = false;
            this.tbxFilter.ContentChanged += new System.EventHandler(this.tbxFilter_ContentChanged);
            this.tbxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFilter_KeyPress);
            // 
            // cbxSubFilter
            // 
            this.cbxSubFilter.Items = new string[] {
        "Payment Method"};
            this.cbxSubFilter.SelectedItem = "Payment Method";
            this.cbxSubFilter.Size = new System.Drawing.Size(217, 40);
            this.cbxSubFilter.SelectedIndexChanged += new System.EventHandler(this.cbxSubFilter_SelectedIndexChanged);
            // 
            // cdpDate
            // 
            this.cdpDate.Visible = true;
            // 
            // pnlFilterContainer
            // 
            this.pnlFilterContainer.Controls.Add(this.lblCompleted);
            this.pnlFilterContainer.Controls.Add(this.schCompletedOnly);
            this.pnlFilterContainer.Controls.Add(this.schDateFilter);
            this.pnlFilterContainer.Controls.SetChildIndex(this.tbxFilter, 0);
            this.pnlFilterContainer.Controls.SetChildIndex(this.btnAdd, 0);
            this.pnlFilterContainer.Controls.SetChildIndex(this.cbxFilter, 0);
            this.pnlFilterContainer.Controls.SetChildIndex(this.cbxSubFilter, 0);
            this.pnlFilterContainer.Controls.SetChildIndex(this.cdpDate, 0);
            this.pnlFilterContainer.Controls.SetChildIndex(this.schDateFilter, 0);
            this.pnlFilterContainer.Controls.SetChildIndex(this.schCompletedOnly, 0);
            this.pnlFilterContainer.Controls.SetChildIndex(this.lblCompleted, 0);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.wallet;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Content = "Payments";
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
            this.schDateFilter.Location = new System.Drawing.Point(833, 16);
            this.schDateFilter.MinimumSize = new System.Drawing.Size(12, 8);
            this.schDateFilter.Name = "schDateFilter";
            this.schDateFilter.OutlineThickness = 1F;
            this.schDateFilter.ShowSymbols = false;
            this.schDateFilter.Size = new System.Drawing.Size(48, 26);
            this.schDateFilter.TabIndex = 28;
            this.schDateFilter.ThumbSizeModifier = new System.Drawing.Size(0, 0);
            this.schDateFilter.UncheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.schDateFilter.UncheckedForeground = System.Drawing.Color.White;
            this.schDateFilter.UncheckedOutlineColor = System.Drawing.Color.Empty;
            this.schDateFilter.UncheckedSymbolColor = System.Drawing.Color.Gray;
            this.schDateFilter.CheckedChanged += new System.EventHandler(this.schDateFilter_CheckedChanged);
            // 
            // schCompletedOnly
            // 
            this.schCompletedOnly.BackColor = System.Drawing.Color.Transparent;
            this.schCompletedOnly.Checked = true;
            this.schCompletedOnly.CheckedBackground = System.Drawing.Color.Green;
            this.schCompletedOnly.CheckedForeground = System.Drawing.Color.White;
            this.schCompletedOnly.CheckedOutlineColor = System.Drawing.Color.Empty;
            this.schCompletedOnly.CheckedSymbolColor = System.Drawing.Color.Green;
            this.schCompletedOnly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.schCompletedOnly.Location = new System.Drawing.Point(1375, 16);
            this.schCompletedOnly.MinimumSize = new System.Drawing.Size(12, 8);
            this.schCompletedOnly.Name = "schCompletedOnly";
            this.schCompletedOnly.OutlineThickness = 1F;
            this.schCompletedOnly.ShowSymbols = false;
            this.schCompletedOnly.Size = new System.Drawing.Size(48, 26);
            this.schCompletedOnly.TabIndex = 28;
            this.schCompletedOnly.ThumbSizeModifier = new System.Drawing.Size(0, 0);
            this.schCompletedOnly.UncheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.schCompletedOnly.UncheckedForeground = System.Drawing.Color.White;
            this.schCompletedOnly.UncheckedOutlineColor = System.Drawing.Color.Empty;
            this.schCompletedOnly.UncheckedSymbolColor = System.Drawing.Color.Gray;
            this.schCompletedOnly.CheckedChanged += new System.EventHandler(this.schCompletedOnly_CheckedChanged);
            // 
            // lblCompleted
            // 
            this.lblCompleted.BackColor = System.Drawing.Color.Transparent;
            this.lblCompleted.Content = "Completed\\ Only";
            this.lblCompleted.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.ForeColor = System.Drawing.Color.White;
            this.lblCompleted.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblCompleted.Location = new System.Drawing.Point(1253, 9);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(116, 40);
            this.lblCompleted.TabIndex = 29;
            this.lblCompleted.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.showLogsToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 76);
            // 
            // showInfoToolStripMenuItem1
            // 
            this.showInfoToolStripMenuItem1.Image = global::Clinic_Manager_Proj.Properties.Resources.eye;
            this.showInfoToolStripMenuItem1.Name = "showInfoToolStripMenuItem1";
            this.showInfoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.showInfoToolStripMenuItem1.Text = "Show Info";
            this.showInfoToolStripMenuItem1.Click += new System.EventHandler(this.showInfoToolStripMenuItem1_Click);
            // 
            // showLogsToolStripMenuItem
            // 
            this.showLogsToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.time__1_;
            this.showLogsToolStripMenuItem.Name = "showLogsToolStripMenuItem";
            this.showLogsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showLogsToolStripMenuItem.Text = "Logs History";
            this.showLogsToolStripMenuItem.Click += new System.EventHandler(this.showLogsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // frmManagePayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 780);
            this.Name = "frmManagePayments";
            this.Text = "frmManagePayments";
            this.Load += new System.EventHandler(this.frmManagePayments_Load);
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
        private CuoreUI.Controls.cuiSwitch schCompletedOnly;
        private CuoreUI.Controls.cuiLabel lblCompleted;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}