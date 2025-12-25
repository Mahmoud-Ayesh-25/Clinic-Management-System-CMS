namespace Clinic_Manager_Proj.Visits
{
    partial class frmManageVisits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageVisits));
            this.schDateFilter = new CuoreUI.Controls.cuiSwitch();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.setInProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToEmergencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.logsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlFilterContainer.SuspendLayout();
            this.pnlBtnClose.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Content = "Add Visit";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxFilter
            // 
            this.cbxFilter.Items = new string[] {
        "Filter",
        "Visit ID",
        "Patient Name",
        "Doctor Name",
        "Visit Status"};
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
        "Waiting",
        "In Progress",
        "Completed",
        "Cancelled"};
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
            this.pnlFilterContainer.Controls.SetChildIndex(this.schDateFilter, 0);
            this.pnlFilterContainer.Controls.SetChildIndex(this.tbxFilter, 0);
            this.pnlFilterContainer.Controls.SetChildIndex(this.btnAdd, 0);
            this.pnlFilterContainer.Controls.SetChildIndex(this.cbxFilter, 0);
            this.pnlFilterContainer.Controls.SetChildIndex(this.cbxSubFilter, 0);
            this.pnlFilterContainer.Controls.SetChildIndex(this.cdpDate, 0);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.doctor_visit;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Content = "Visits";
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
            this.schDateFilter.TabIndex = 30;
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
            this.showInfoToolStripMenuItem1,
            this.editToolStripMenuItem2,
            this.deleteToolStripMenuItem2,
            this.toolStripMenuItem2,
            this.setInProgressToolStripMenuItem,
            this.completeToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.sendToEmergencyToolStripMenuItem,
            this.toolStripMenuItem3,
            this.payToolStripMenuItem,
            this.toolStripMenuItem4,
            this.logsHistoryToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 242);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // showInfoToolStripMenuItem1
            // 
            this.showInfoToolStripMenuItem1.Image = global::Clinic_Manager_Proj.Properties.Resources.eye;
            this.showInfoToolStripMenuItem1.Name = "showInfoToolStripMenuItem1";
            this.showInfoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.showInfoToolStripMenuItem1.Text = "Show Info";
            this.showInfoToolStripMenuItem1.Click += new System.EventHandler(this.showInfoToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.Image = global::Clinic_Manager_Proj.Properties.Resources.creative;
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem2.Text = "Edit";
            this.editToolStripMenuItem2.Click += new System.EventHandler(this.editToolStripMenuItem2_Click);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Image = global::Clinic_Manager_Proj.Properties.Resources.delete;
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem2.Text = "Delete";
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.deleteToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // setInProgressToolStripMenuItem
            // 
            this.setInProgressToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.work_in_progress;
            this.setInProgressToolStripMenuItem.Name = "setInProgressToolStripMenuItem";
            this.setInProgressToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setInProgressToolStripMenuItem.Text = "Set In Progress";
            this.setInProgressToolStripMenuItem.Click += new System.EventHandler(this.setInProgressToolStripMenuItem_Click);
            // 
            // completeToolStripMenuItem
            // 
            this.completeToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.checkmark;
            this.completeToolStripMenuItem.Name = "completeToolStripMenuItem";
            this.completeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.completeToolStripMenuItem.Text = "Complete";
            this.completeToolStripMenuItem.Click += new System.EventHandler(this.completeToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.close;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // sendToEmergencyToolStripMenuItem
            // 
            this.sendToEmergencyToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.siren;
            this.sendToEmergencyToolStripMenuItem.Name = "sendToEmergencyToolStripMenuItem";
            this.sendToEmergencyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sendToEmergencyToolStripMenuItem.Text = "Send To Emergency";
            this.sendToEmergencyToolStripMenuItem.Click += new System.EventHandler(this.sendToEmergencyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // logsHistoryToolStripMenuItem
            // 
            this.logsHistoryToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.time__1_1;
            this.logsHistoryToolStripMenuItem.Name = "logsHistoryToolStripMenuItem";
            this.logsHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logsHistoryToolStripMenuItem.Text = "Logs History";
            this.logsHistoryToolStripMenuItem.Click += new System.EventHandler(this.logsHistoryToolStripMenuItem_Click);
            // 
            // payToolStripMenuItem
            // 
            this.payToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.dollar;
            this.payToolStripMenuItem.Name = "payToolStripMenuItem";
            this.payToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.payToolStripMenuItem.Text = "Pay";
            this.payToolStripMenuItem.Click += new System.EventHandler(this.payToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 6);
            // 
            // frmManageVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 780);
            this.Name = "frmManageVisits";
            this.Text = "frmManageVisits";
            this.Load += new System.EventHandler(this.frmManageVisits_Load);
            this.SizeChanged += new System.EventHandler(this.frmManageVisits_SizeChanged);
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
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logsHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setInProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToEmergencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem payToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
    }
}