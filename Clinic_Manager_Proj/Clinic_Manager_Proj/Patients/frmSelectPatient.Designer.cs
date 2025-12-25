namespace Clinic_Manager_Proj.Patients
{
    partial class frmSelectPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectPatient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.btnAddPerson = new CuoreUI.Controls.cuiButton();
            this.cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            this.tbxFilter = new CuoreUI.Controls.cuiTextBox();
            this.pnlBtnClose.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.cuiPanel2.SuspendLayout();
            this.cuiPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            this.btnMaximized.Location = new System.Drawing.Point(257, 11);
            this.btnMaximized.Visible = false;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMinimized.Location = new System.Drawing.Point(215, 11);
            this.btnMinimized.Visible = false;
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.healthy;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMainTitle.Content = "Select\\ Patient";
            this.lblMainTitle.Size = new System.Drawing.Size(346, 58);
            // 
            // pnlBtnClose
            // 
            this.pnlBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtnClose.Location = new System.Drawing.Point(299, 11);
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Location = new System.Drawing.Point(32767, 0);
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 700);
            this.cuiResizeGrip.TargetForm = null;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Controls.Add(this.dgvData);
            this.cuiPanel1.Location = new System.Drawing.Point(12, 152);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel1.Size = new System.Drawing.Size(346, 469);
            this.cuiPanel1.TabIndex = 2;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvData.Location = new System.Drawing.Point(0, 15);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData.RowTemplate.Height = 30;
            this.dgvData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(346, 439);
            this.dgvData.TabIndex = 19;
            this.dgvData.DoubleClick += new System.EventHandler(this.dgvData_DoubleClick);
            this.dgvData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvData_KeyPress);
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel2.Controls.Add(this.btnAddPerson);
            this.cuiPanel2.Location = new System.Drawing.Point(12, 633);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(28);
            this.cuiPanel2.Size = new System.Drawing.Size(346, 58);
            this.cuiPanel2.TabIndex = 2;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPerson.CheckButton = false;
            this.btnAddPerson.Checked = false;
            this.btnAddPerson.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAddPerson.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddPerson.CheckedImageTint = System.Drawing.Color.White;
            this.btnAddPerson.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAddPerson.Content = "Select Patient";
            this.btnAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPerson.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddPerson.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddPerson.HoverForeColor = System.Drawing.Color.White;
            this.btnAddPerson.HoverImageTint = System.Drawing.Color.White;
            this.btnAddPerson.HoverOutline = System.Drawing.Color.White;
            this.btnAddPerson.Image = null;
            this.btnAddPerson.ImageAutoCenter = true;
            this.btnAddPerson.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAddPerson.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddPerson.Location = new System.Drawing.Point(177, 9);
            this.btnAddPerson.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.NormalBackground = System.Drawing.Color.Transparent;
            this.btnAddPerson.NormalForeColor = System.Drawing.Color.White;
            this.btnAddPerson.NormalImageTint = System.Drawing.Color.White;
            this.btnAddPerson.NormalOutline = System.Drawing.Color.White;
            this.btnAddPerson.OutlineThickness = 1F;
            this.btnAddPerson.PressedBackground = System.Drawing.Color.White;
            this.btnAddPerson.PressedForeColor = System.Drawing.Color.Black;
            this.btnAddPerson.PressedImageTint = System.Drawing.Color.White;
            this.btnAddPerson.PressedOutline = System.Drawing.Color.White;
            this.btnAddPerson.Rounding = new System.Windows.Forms.Padding(19);
            this.btnAddPerson.Size = new System.Drawing.Size(158, 40);
            this.btnAddPerson.TabIndex = 23;
            this.btnAddPerson.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddPerson.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // cuiPanel3
            // 
            this.cuiPanel3.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel3.Controls.Add(this.tbxFilter);
            this.cuiPanel3.Location = new System.Drawing.Point(12, 82);
            this.cuiPanel3.Name = "cuiPanel3";
            this.cuiPanel3.OutlineThickness = 1F;
            this.cuiPanel3.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel3.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel3.Rounding = new System.Windows.Forms.Padding(28);
            this.cuiPanel3.Size = new System.Drawing.Size(346, 58);
            this.cuiPanel3.TabIndex = 2;
            // 
            // tbxFilter
            // 
            this.tbxFilter.BackColor = System.Drawing.Color.Transparent;
            this.tbxFilter.BackgroundColor = System.Drawing.Color.Black;
            this.tbxFilter.Content = "";
            this.tbxFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxFilter.FocusBackgroundColor = System.Drawing.Color.Black;
            this.tbxFilter.FocusImageTint = System.Drawing.Color.White;
            this.tbxFilter.FocusOutlineColor = System.Drawing.Color.White;
            this.tbxFilter.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFilter.ForeColor = System.Drawing.Color.White;
            this.tbxFilter.Image = null;
            this.tbxFilter.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxFilter.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxFilter.Location = new System.Drawing.Point(9, 9);
            this.tbxFilter.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFilter.Multiline = false;
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.NormalImageTint = System.Drawing.Color.White;
            this.tbxFilter.OutlineColor = System.Drawing.Color.Black;
            this.tbxFilter.Padding = new System.Windows.Forms.Padding(16, 12, 16, 0);
            this.tbxFilter.PasswordChar = false;
            this.tbxFilter.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxFilter.PlaceholderText = "Search By Name ...";
            this.tbxFilter.Rounding = new System.Windows.Forms.Padding(19);
            this.tbxFilter.Size = new System.Drawing.Size(328, 40);
            this.tbxFilter.TabIndex = 22;
            this.tbxFilter.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxFilter.UnderlinedStyle = false;
            this.tbxFilter.ContentChanged += new System.EventHandler(this.tbxFilter_ContentChanged);
            // 
            // frmSelectPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 700);
            this.Controls.Add(this.cuiPanel3);
            this.Controls.Add(this.cuiPanel2);
            this.Controls.Add(this.cuiPanel1);
            this.MaximumSize = new System.Drawing.Size(370, 700);
            this.MinimumSize = new System.Drawing.Size(370, 700);
            this.Name = "frmSelectPatient";
            this.Text = "frmSelectPatient";
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.Controls.SetChildIndex(this.cuiPanel1, 0);
            this.Controls.SetChildIndex(this.cuiPanel2, 0);
            this.Controls.SetChildIndex(this.cuiPanel3, 0);
            this.pnlBtnClose.ResumeLayout(false);
            this.cuiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.cuiPanel2.ResumeLayout(false);
            this.cuiPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        protected CuoreUI.Controls.cuiTextBox tbxFilter;
        protected CuoreUI.Controls.cuiButton btnAddPerson;
        protected System.Windows.Forms.DataGridView dgvData;
    }
}