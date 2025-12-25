namespace Clinic_Manager_Proj.Users
{
    partial class frmManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.logsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBtnClose.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Content = "Add User";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxFilter
            // 
            this.cbxFilter.Items = new string[] {
        "Filter",
        "ID",
        "Person Name",
        "Username",
        "Permission Type",
        "Is Active"};
            this.cbxFilter.NoSelectionText = " Filter By ...";
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
        "IsActive",
        "No",
        "Yes"};
            this.cbxSubFilter.SelectedItem = "IsActive";
            this.cbxSubFilter.SelectedIndexChanged += new System.EventHandler(this.cbxSubFilter_SelectedIndexChanged);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.user__3_;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Content = "Users";
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
            this.activeToolStripMenuItem,
            this.deactiveToolStripMenuItem,
            this.toolStripMenuItem3,
            this.logsHistoryToolStripMenuItem,
            this.userLogsToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 192);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // showInfoToolStripMenuItem1
            // 
            this.showInfoToolStripMenuItem1.Image = global::Clinic_Manager_Proj.Properties.Resources.eye;
            this.showInfoToolStripMenuItem1.Name = "showInfoToolStripMenuItem1";
            this.showInfoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.showInfoToolStripMenuItem1.Text = " Show Info";
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
            // activeToolStripMenuItem
            // 
            this.activeToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.check__4_;
            this.activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            this.activeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.activeToolStripMenuItem.Text = "Activate";
            this.activeToolStripMenuItem.Click += new System.EventHandler(this.activeToolStripMenuItem_Click);
            // 
            // deactiveToolStripMenuItem
            // 
            this.deactiveToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources._switch;
            this.deactiveToolStripMenuItem.Name = "deactiveToolStripMenuItem";
            this.deactiveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deactiveToolStripMenuItem.Text = "Deactivate";
            this.deactiveToolStripMenuItem.Click += new System.EventHandler(this.deactiveToolStripMenuItem_Click);
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
            // userLogsToolStripMenuItem
            // 
            this.userLogsToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.time__1_;
            this.userLogsToolStripMenuItem.Name = "userLogsToolStripMenuItem";
            this.userLogsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userLogsToolStripMenuItem.Text = "User Logs";
            this.userLogsToolStripMenuItem.Click += new System.EventHandler(this.userLogsToolStripMenuItem_Click);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 780);
            this.Name = "frmManageUsers";
            this.Text = "frmManageUsers";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            this.SizeChanged += new System.EventHandler(this.frmManageUsers_SizeChanged);
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.Controls.SetChildIndex(this.pnlDgvContainer, 0);
            this.Controls.SetChildIndex(this.lblRecordes, 0);
            this.pnlBtnClose.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logsHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem userLogsToolStripMenuItem;
    }
}