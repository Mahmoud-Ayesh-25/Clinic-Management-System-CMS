namespace Clinic_Manager_Proj.Appointments
{
    partial class frmManageAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageAppointment));
            this.schDateFilter = new CuoreUI.Controls.cuiSwitch();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.makeVisitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCancelledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNoShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.logsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.pnlFilterContainer.SuspendLayout();
            this.pnlBtnClose.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Content = "Add Appointment";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxFilter
            // 
            this.cbxFilter.Items = new string[] {
        "Filter",
        "Appointment ID",
        "Patient Name",
        "Doctor Name",
        "Status"};
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
        "Status",
        "Scheduled",
        "Completed",
        "Cancelled",
        "No Show"};
            this.cbxSubFilter.SelectedItem = "Status";
            this.cbxSubFilter.SelectedIndexChanged += new System.EventHandler(this.cbxSubFilter_SelectedIndexChanged);
            // 
            // cdpDate
            // 
            this.cdpDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.appointment__1_;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Content = "Appointments";
            // 
            // schDateFilter
            // 
            this.schDateFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.schDateFilter.TabIndex = 29;
            this.schDateFilter.ThumbSizeModifier = new System.Drawing.Size(0, 0);
            this.schDateFilter.UncheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.schDateFilter.UncheckedForeground = System.Drawing.Color.White;
            this.schDateFilter.UncheckedOutlineColor = System.Drawing.Color.Empty;
            this.schDateFilter.UncheckedSymbolColor = System.Drawing.Color.Gray;
            this.schDateFilter.CheckedChanged += new System.EventHandler(this.schDateFilter_CheckedChanged);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripMenuItem1,
            this.editToolStripMenuItem2,
            this.deleteToolStripMenuItem2,
            this.toolStripMenuItem2,
            this.makeVisitToolStripMenuItem,
            this.setCancelledToolStripMenuItem,
            this.setNoShowToolStripMenuItem,
            this.toolStripMenuItem3,
            this.logsHistoryToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 192);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // showInfoToolStripMenuItem1
            // 
            this.showInfoToolStripMenuItem1.Image = global::Clinic_Manager_Proj.Properties.Resources.eye;
            this.showInfoToolStripMenuItem1.Name = "showInfoToolStripMenuItem1";
            this.showInfoToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.showInfoToolStripMenuItem1.Text = " Show Info";
            this.showInfoToolStripMenuItem1.Click += new System.EventHandler(this.showInfoToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.Image = global::Clinic_Manager_Proj.Properties.Resources.creative;
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.editToolStripMenuItem2.Text = "Edit";
            this.editToolStripMenuItem2.Click += new System.EventHandler(this.editToolStripMenuItem2_Click);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Image = global::Clinic_Manager_Proj.Properties.Resources.delete;
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.deleteToolStripMenuItem2.Text = "Delete";
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.deleteToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(142, 6);
            // 
            // makeVisitToolStripMenuItem
            // 
            this.makeVisitToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.arrival_time;
            this.makeVisitToolStripMenuItem.Name = "makeVisitToolStripMenuItem";
            this.makeVisitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makeVisitToolStripMenuItem.Text = "Arrived / Make Visit";
            this.makeVisitToolStripMenuItem.Click += new System.EventHandler(this.makeVisitToolStripMenuItem_Click);
            // 
            // setCancelledToolStripMenuItem
            // 
            this.setCancelledToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.close;
            this.setCancelledToolStripMenuItem.Name = "setCancelledToolStripMenuItem";
            this.setCancelledToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setCancelledToolStripMenuItem.Text = "Cancel";
            this.setCancelledToolStripMenuItem.Click += new System.EventHandler(this.setCancelledToolStripMenuItem_Click);
            // 
            // setNoShowToolStripMenuItem
            // 
            this.setNoShowToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.eye__2_;
            this.setNoShowToolStripMenuItem.Name = "setNoShowToolStripMenuItem";
            this.setNoShowToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.setNoShowToolStripMenuItem.Text = "Set No Show";
            this.setNoShowToolStripMenuItem.Click += new System.EventHandler(this.setNoShowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(142, 6);
            // 
            // logsHistoryToolStripMenuItem
            // 
            this.logsHistoryToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.time__1_1;
            this.logsHistoryToolStripMenuItem.Name = "logsHistoryToolStripMenuItem";
            this.logsHistoryToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.logsHistoryToolStripMenuItem.Text = "Logs History";
            this.logsHistoryToolStripMenuItem.Click += new System.EventHandler(this.logsHistoryToolStripMenuItem_Click);
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // frmManageAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 780);
            this.Name = "frmManageAppointment";
            this.Text = "frmManageAppointment";
            this.Load += new System.EventHandler(this.frmManageAppointment_Load);
            this.SizeChanged += new System.EventHandler(this.frmManageAppointment_SizeChanged);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logsHistoryToolStripMenuItem;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private System.Windows.Forms.ToolStripMenuItem makeVisitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCancelledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNoShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    }
}