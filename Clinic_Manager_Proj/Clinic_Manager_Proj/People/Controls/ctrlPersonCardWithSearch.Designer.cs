namespace Clinic_Manager_Proj.People.Controls
{
    partial class ctrlPersonCardWithSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.btnAddPerson = new CuoreUI.Controls.cuiButton();
            this.btnFind = new CuoreUI.Controls.cuiButton();
            this.cbxFilter = new CuoreUI.Controls.cuiComboBox();
            this.tbxFilter = new CuoreUI.Controls.cuiTextBox();
            this.ctrlPersonInfoCard1 = new Clinic_Manager_Proj.People.Controls.ctrlPersonInfoCard();
            this.cuiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.btnAddPerson);
            this.cuiPanel1.Controls.Add(this.btnFind);
            this.cuiPanel1.Controls.Add(this.cbxFilter);
            this.cuiPanel1.Controls.Add(this.tbxFilter);
            this.cuiPanel1.Location = new System.Drawing.Point(12, 12);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(28);
            this.cuiPanel1.Size = new System.Drawing.Size(897, 58);
            this.cuiPanel1.TabIndex = 1;
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
            this.btnAddPerson.Content = "Add Person";
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
            this.btnAddPerson.Location = new System.Drawing.Point(754, 8);
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
            this.btnAddPerson.Size = new System.Drawing.Size(134, 40);
            this.btnAddPerson.TabIndex = 22;
            this.btnAddPerson.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddPerson.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.CheckButton = false;
            this.btnFind.Checked = false;
            this.btnFind.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnFind.CheckedForeColor = System.Drawing.Color.White;
            this.btnFind.CheckedImageTint = System.Drawing.Color.White;
            this.btnFind.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnFind.Content = "Find";
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFind.HoverForeColor = System.Drawing.Color.White;
            this.btnFind.HoverImageTint = System.Drawing.Color.White;
            this.btnFind.HoverOutline = System.Drawing.Color.White;
            this.btnFind.Image = null;
            this.btnFind.ImageAutoCenter = true;
            this.btnFind.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnFind.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnFind.Location = new System.Drawing.Point(456, 8);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.NormalBackground = System.Drawing.Color.Transparent;
            this.btnFind.NormalForeColor = System.Drawing.Color.White;
            this.btnFind.NormalImageTint = System.Drawing.Color.White;
            this.btnFind.NormalOutline = System.Drawing.Color.White;
            this.btnFind.OutlineThickness = 1F;
            this.btnFind.PressedBackground = System.Drawing.Color.White;
            this.btnFind.PressedForeColor = System.Drawing.Color.Black;
            this.btnFind.PressedImageTint = System.Drawing.Color.White;
            this.btnFind.PressedOutline = System.Drawing.Color.White;
            this.btnFind.Rounding = new System.Windows.Forms.Padding(19);
            this.btnFind.Size = new System.Drawing.Size(109, 40);
            this.btnFind.TabIndex = 22;
            this.btnFind.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnFind.TextOffset = new System.Drawing.Point(0, 0);
            this.btnFind.Visible = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
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
            this.cbxFilter.Items = new string[] {
        "Search",
        "Person ID",
        "National No"};
            this.cbxFilter.Location = new System.Drawing.Point(8, 8);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.NoSelectionDropdownText = "Empty";
            this.cbxFilter.NoSelectionText = " Search";
            this.cbxFilter.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbxFilter.OutlineThickness = 1F;
            this.cbxFilter.Rounding = 19;
            this.cbxFilter.Size = new System.Drawing.Size(217, 40);
            this.cbxFilter.TabIndex = 20;
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
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
            this.tbxFilter.Location = new System.Drawing.Point(232, 8);
            this.tbxFilter.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFilter.Multiline = false;
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.NormalImageTint = System.Drawing.Color.White;
            this.tbxFilter.OutlineColor = System.Drawing.Color.Black;
            this.tbxFilter.Padding = new System.Windows.Forms.Padding(16, 12, 16, 0);
            this.tbxFilter.PasswordChar = false;
            this.tbxFilter.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxFilter.PlaceholderText = "Search ...";
            this.tbxFilter.Rounding = new System.Windows.Forms.Padding(19);
            this.tbxFilter.Size = new System.Drawing.Size(217, 40);
            this.tbxFilter.TabIndex = 21;
            this.tbxFilter.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxFilter.UnderlinedStyle = false;
            this.tbxFilter.Visible = false;
            this.tbxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFilter_KeyPress);
            // 
            // ctrlPersonInfoCard1
            // 
            this.ctrlPersonInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlPersonInfoCard1.Location = new System.Drawing.Point(0, 70);
            this.ctrlPersonInfoCard1.Name = "ctrlPersonInfoCard1";
            this.ctrlPersonInfoCard1.Size = new System.Drawing.Size(921, 294);
            this.ctrlPersonInfoCard1.TabIndex = 0;
            // 
            // ctrlPersonCardWithSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.cuiPanel1);
            this.Controls.Add(this.ctrlPersonInfoCard1);
            this.Name = "ctrlPersonCardWithSearch";
            this.Size = new System.Drawing.Size(921, 364);
            this.cuiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonInfoCard ctrlPersonInfoCard1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        protected CuoreUI.Controls.cuiComboBox cbxFilter;
        protected CuoreUI.Controls.cuiTextBox tbxFilter;
        protected CuoreUI.Controls.cuiButton btnFind;
        protected CuoreUI.Controls.cuiButton btnAddPerson;
    }
}
