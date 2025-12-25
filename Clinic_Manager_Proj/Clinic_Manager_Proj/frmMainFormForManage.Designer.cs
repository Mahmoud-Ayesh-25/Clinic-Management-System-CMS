namespace Clinic_Manager_Proj.People
{
    partial class frmMainFormForManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainFormForManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFilterContainer = new CuoreUI.Controls.cuiGradientPanel();
            this.cdpDate = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.cbxSubFilter = new CuoreUI.Controls.cuiComboBox();
            this.cbxFilter = new CuoreUI.Controls.cuiComboBox();
            this.btnAdd = new CuoreUI.Controls.cuiButton();
            this.tbxFilter = new CuoreUI.Controls.cuiTextBox();
            this.pnlDgvContainer = new CuoreUI.Controls.cuiGradientPanel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblRecordes = new CuoreUI.Controls.cuiLabel();
            this.pnlBtnClose.SuspendLayout();
            this.pnlFilterContainer.SuspendLayout();
            this.pnlDgvContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMaximized
            // 
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.vaccine;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Content = "Main\\ Form\\ For\\ Manage";
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Location = new System.Drawing.Point(1444, 0);
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 780);
            // 
            // pnlFilterContainer
            // 
            this.pnlFilterContainer.Controls.Add(this.cdpDate);
            this.pnlFilterContainer.Controls.Add(this.cbxSubFilter);
            this.pnlFilterContainer.Controls.Add(this.cbxFilter);
            this.pnlFilterContainer.Controls.Add(this.btnAdd);
            this.pnlFilterContainer.Controls.Add(this.tbxFilter);
            this.pnlFilterContainer.GradientAngle = 0F;
            this.pnlFilterContainer.Location = new System.Drawing.Point(12, 85);
            this.pnlFilterContainer.Name = "pnlFilterContainer";
            this.pnlFilterContainer.OutlineThickness = 1F;
            this.pnlFilterContainer.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlFilterContainer.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlFilterContainer.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.pnlFilterContainer.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.pnlFilterContainer.Rounding = new System.Windows.Forms.Padding(28);
            this.pnlFilterContainer.Size = new System.Drawing.Size(1432, 58);
            this.pnlFilterContainer.TabIndex = 5;
            // 
            // cdpDate
            // 
            this.cdpDate.BackColor = System.Drawing.Color.Transparent;
            this.cdpDate.Content = new System.DateTime(2025, 12, 2, 0, 0, 0, 0);
            this.cdpDate.EnableThemeChangeButton = true;
            this.cdpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cdpDate.ForeColor = System.Drawing.Color.White;
            this.cdpDate.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cdpDate.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cdpDate.Icon = ((System.Drawing.Image)(resources.GetObject("cdpDate.Icon")));
            this.cdpDate.IconTint = System.Drawing.Color.White;
            this.cdpDate.Location = new System.Drawing.Point(605, 9);
            this.cdpDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cdpDate.Name = "cdpDate";
            this.cdpDate.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cdpDate.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cdpDate.OutlineThickness = 1.5F;
            this.cdpDate.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            this.cdpDate.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cdpDate.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cdpDate.Rounding = 19;
            this.cdpDate.ShowIcon = true;
            this.cdpDate.Size = new System.Drawing.Size(221, 40);
            this.cdpDate.TabIndex = 20;
            this.cdpDate.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Dark;
            this.cdpDate.Visible = false;
            // 
            // cbxSubFilter
            // 
            this.cbxSubFilter.AutoScroll = true;
            this.cbxSubFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbxSubFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxSubFilter.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxSubFilter.ButtonHoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbxSubFilter.ButtonHoverOutline = System.Drawing.Color.Empty;
            this.cbxSubFilter.ButtonNormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbxSubFilter.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cbxSubFilter.ButtonPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbxSubFilter.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cbxSubFilter.DropDownBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbxSubFilter.DropDownOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxSubFilter.ExpandArrowColor = System.Drawing.Color.Gray;
            this.cbxSubFilter.ForeColor = System.Drawing.Color.White;
            this.cbxSubFilter.Items = new string[0];
            this.cbxSubFilter.Location = new System.Drawing.Point(233, 9);
            this.cbxSubFilter.Name = "cbxSubFilter";
            this.cbxSubFilter.NoSelectionDropdownText = "Empty";
            this.cbxSubFilter.NoSelectionText = " ";
            this.cbxSubFilter.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxSubFilter.OutlineThickness = 1F;
            this.cbxSubFilter.Rounding = 19;
            this.cbxSubFilter.Size = new System.Drawing.Size(134, 40);
            this.cbxSubFilter.TabIndex = 18;
            this.cbxSubFilter.Visible = false;
            // 
            // cbxFilter
            // 
            this.cbxFilter.AutoScroll = true;
            this.cbxFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbxFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxFilter.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxFilter.ButtonHoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbxFilter.ButtonHoverOutline = System.Drawing.Color.Empty;
            this.cbxFilter.ButtonNormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbxFilter.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cbxFilter.ButtonPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbxFilter.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cbxFilter.DropDownBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbxFilter.DropDownOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxFilter.ExpandArrowColor = System.Drawing.Color.Gray;
            this.cbxFilter.ForeColor = System.Drawing.Color.White;
            this.cbxFilter.Items = new string[0];
            this.cbxFilter.Location = new System.Drawing.Point(9, 9);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.NoSelectionDropdownText = "Empty";
            this.cbxFilter.NoSelectionText = " ";
            this.cbxFilter.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxFilter.OutlineThickness = 1F;
            this.cbxFilter.Rounding = 19;
            this.cbxFilter.Size = new System.Drawing.Size(217, 40);
            this.cbxFilter.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.CheckButton = false;
            this.btnAdd.Checked = false;
            this.btnAdd.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdd.CheckedImageTint = System.Drawing.Color.White;
            this.btnAdd.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAdd.Content = "Add Button";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.HoverForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverImageTint = System.Drawing.Color.White;
            this.btnAdd.HoverOutline = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageAutoCenter = true;
            this.btnAdd.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAdd.Location = new System.Drawing.Point(1243, 9);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormalBackground = System.Drawing.Color.Transparent;
            this.btnAdd.NormalForeColor = System.Drawing.Color.White;
            this.btnAdd.NormalImageTint = System.Drawing.Color.White;
            this.btnAdd.NormalOutline = System.Drawing.Color.White;
            this.btnAdd.OutlineThickness = 1F;
            this.btnAdd.PressedBackground = System.Drawing.Color.White;
            this.btnAdd.PressedForeColor = System.Drawing.Color.Black;
            this.btnAdd.PressedImageTint = System.Drawing.Color.White;
            this.btnAdd.PressedOutline = System.Drawing.Color.White;
            this.btnAdd.Rounding = new System.Windows.Forms.Padding(19);
            this.btnAdd.Size = new System.Drawing.Size(180, 40);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.TextOffset = new System.Drawing.Point(0, 0);
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
            this.tbxFilter.Location = new System.Drawing.Point(233, 9);
            this.tbxFilter.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFilter.Multiline = false;
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.NormalImageTint = System.Drawing.Color.White;
            this.tbxFilter.OutlineColor = System.Drawing.Color.Black;
            this.tbxFilter.Padding = new System.Windows.Forms.Padding(16, 12, 16, 0);
            this.tbxFilter.PasswordChar = false;
            this.tbxFilter.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxFilter.PlaceholderText = "Filter ...";
            this.tbxFilter.Rounding = new System.Windows.Forms.Padding(19);
            this.tbxFilter.Size = new System.Drawing.Size(217, 40);
            this.tbxFilter.TabIndex = 19;
            this.tbxFilter.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxFilter.UnderlinedStyle = false;
            // 
            // pnlDgvContainer
            // 
            this.pnlDgvContainer.Controls.Add(this.dgvData);
            this.pnlDgvContainer.GradientAngle = 0F;
            this.pnlDgvContainer.Location = new System.Drawing.Point(12, 158);
            this.pnlDgvContainer.Name = "pnlDgvContainer";
            this.pnlDgvContainer.OutlineThickness = 1F;
            this.pnlDgvContainer.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlDgvContainer.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlDgvContainer.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.pnlDgvContainer.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.pnlDgvContainer.Rounding = new System.Windows.Forms.Padding(15);
            this.pnlDgvContainer.Size = new System.Drawing.Size(1432, 578);
            this.pnlDgvContainer.TabIndex = 6;
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
            this.dgvData.Location = new System.Drawing.Point(1, 16);
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
            this.dgvData.Size = new System.Drawing.Size(1430, 546);
            this.dgvData.TabIndex = 18;
            this.dgvData.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvData_DataBindingComplete);
            // 
            // lblRecordes
            // 
            this.lblRecordes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordes.Content = "Recordes\\ :\\ 0";
            this.lblRecordes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordes.ForeColor = System.Drawing.Color.White;
            this.lblRecordes.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblRecordes.Location = new System.Drawing.Point(12, 742);
            this.lblRecordes.Name = "lblRecordes";
            this.lblRecordes.Size = new System.Drawing.Size(210, 26);
            this.lblRecordes.TabIndex = 7;
            this.lblRecordes.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmMainFormForManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 780);
            this.Controls.Add(this.lblRecordes);
            this.Controls.Add(this.pnlDgvContainer);
            this.Controls.Add(this.pnlFilterContainer);
            this.Name = "frmMainFormForManage";
            this.Text = "frmManagePeople";
            this.SizeChanged += new System.EventHandler(this.frmMainFormForManage_SizeChanged);
            this.Controls.SetChildIndex(this.pnlFilterContainer, 0);
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.Controls.SetChildIndex(this.pnlDgvContainer, 0);
            this.Controls.SetChildIndex(this.lblRecordes, 0);
            this.pnlBtnClose.ResumeLayout(false);
            this.pnlFilterContainer.ResumeLayout(false);
            this.pnlDgvContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected CuoreUI.Controls.cuiLabel lblRecordes;
        protected CuoreUI.Controls.cuiButton btnAdd;
        protected CuoreUI.Controls.cuiComboBox cbxFilter;
        protected CuoreUI.Controls.cuiTextBox tbxFilter;
        protected CuoreUI.Controls.cuiComboBox cbxSubFilter;
        protected CuoreUI.Controls.cuiCalendarDatePicker cdpDate;
        protected CuoreUI.Controls.cuiGradientPanel pnlDgvContainer;
        protected System.Windows.Forms.DataGridView dgvData;
        protected CuoreUI.Controls.cuiGradientPanel pnlFilterContainer;
    }
}