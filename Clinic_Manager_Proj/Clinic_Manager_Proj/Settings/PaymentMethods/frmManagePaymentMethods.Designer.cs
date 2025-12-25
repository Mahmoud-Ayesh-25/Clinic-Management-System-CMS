namespace Clinic_Manager_Proj.Settings.PaymentMethods
{
    partial class frmManagePaymentMethods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePaymentMethods));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.logsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFilterContainer.SuspendLayout();
            this.pnlBtnClose.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Content = "Add Payment Method";
            this.btnAdd.Location = new System.Drawing.Point(544, 9);
            this.btnAdd.Size = new System.Drawing.Size(217, 40);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxFilter
            // 
            this.cbxFilter.Items = new string[0];
            this.cbxFilter.Visible = false;
            // 
            // tbxFilter
            // 
            this.tbxFilter.Visible = false;
            // 
            // cbxSubFilter
            // 
            this.cbxSubFilter.Items = new string[0];
            // 
            // cdpDate
            // 
            this.cdpDate.Location = new System.Drawing.Point(146, 9);
            // 
            // pnlDgvContainer
            // 
            this.pnlDgvContainer.Size = new System.Drawing.Size(770, 578);
            // 
            // pnlFilterContainer
            // 
            this.pnlFilterContainer.Size = new System.Drawing.Size(770, 58);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            this.btnMaximized.Location = new System.Drawing.Point(681, 11);
            this.btnMaximized.Visible = false;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMinimized.Location = new System.Drawing.Point(681, 11);
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.dollar;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMainTitle.Content = "Payment\\ Methods";
            this.lblMainTitle.Size = new System.Drawing.Size(770, 58);
            // 
            // pnlBtnClose
            // 
            this.pnlBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtnClose.Location = new System.Drawing.Point(723, 11);
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Location = new System.Drawing.Point(2000, 0);
            this.cuiResizeGrip.TargetForm = null;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem2,
            this.deleteToolStripMenuItem2,
            this.toolStripMenuItem2,
            this.logsHistoryToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 98);
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
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // logsHistoryToolStripMenuItem
            // 
            this.logsHistoryToolStripMenuItem.Image = global::Clinic_Manager_Proj.Properties.Resources.time__1_;
            this.logsHistoryToolStripMenuItem.Name = "logsHistoryToolStripMenuItem";
            this.logsHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logsHistoryToolStripMenuItem.Text = "Logs History";
            this.logsHistoryToolStripMenuItem.Click += new System.EventHandler(this.logsHistoryToolStripMenuItem_Click);
            // 
            // frmManagePaymentMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 780);
            this.MaximumSize = new System.Drawing.Size(794, 780);
            this.MinimumSize = new System.Drawing.Size(794, 780);
            this.Name = "frmManagePaymentMethods";
            this.Text = "frmManagePaymentMethods";
            this.Load += new System.EventHandler(this.frmManagePaymentMethods_Load);
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

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logsHistoryToolStripMenuItem;
    }
}