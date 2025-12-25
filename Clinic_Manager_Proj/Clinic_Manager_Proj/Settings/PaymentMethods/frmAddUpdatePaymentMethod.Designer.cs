namespace Clinic_Manager_Proj.Settings.PaymentMethods
{
    partial class frmAddUpdatePaymentMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdatePaymentMethod));
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.tbxMethodTitle = new CuoreUI.Controls.cuiTextBox();
            this.lblID = new CuoreUI.Controls.cuiLabel();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.btnSaveMethod = new CuoreUI.Controls.cuiButton();
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.pnlBtnClose.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.cuiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            this.btnMaximized.Location = new System.Drawing.Point(510, 11);
            this.btnMaximized.Visible = false;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMinimized.Location = new System.Drawing.Point(510, 11);
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.dollar;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMainTitle.Content = "Add\\ Payment\\ Method";
            this.lblMainTitle.Size = new System.Drawing.Size(599, 58);
            // 
            // pnlBtnClose
            // 
            this.pnlBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBtnClose.Location = new System.Drawing.Point(552, 11);
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Location = new System.Drawing.Point(2000, 70);
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 262);
            this.cuiResizeGrip.TargetForm = null;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Controls.Add(this.tbxMethodTitle);
            this.cuiPanel1.Controls.Add(this.lblID);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox3);
            this.cuiPanel1.Controls.Add(this.cuiPictureBox2);
            this.cuiPanel1.Location = new System.Drawing.Point(12, 82);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel1.Size = new System.Drawing.Size(599, 98);
            this.cuiPanel1.TabIndex = 2;
            // 
            // tbxMethodTitle
            // 
            this.tbxMethodTitle.BackColor = System.Drawing.Color.Transparent;
            this.tbxMethodTitle.BackgroundColor = System.Drawing.Color.Black;
            this.tbxMethodTitle.Content = "";
            this.tbxMethodTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxMethodTitle.FocusBackgroundColor = System.Drawing.Color.Black;
            this.tbxMethodTitle.FocusImageTint = System.Drawing.Color.White;
            this.tbxMethodTitle.FocusOutlineColor = System.Drawing.Color.White;
            this.tbxMethodTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMethodTitle.ForeColor = System.Drawing.Color.White;
            this.tbxMethodTitle.Image = null;
            this.tbxMethodTitle.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxMethodTitle.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxMethodTitle.Location = new System.Drawing.Point(53, 53);
            this.tbxMethodTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMethodTitle.Multiline = false;
            this.tbxMethodTitle.Name = "tbxMethodTitle";
            this.tbxMethodTitle.NormalImageTint = System.Drawing.Color.White;
            this.tbxMethodTitle.OutlineColor = System.Drawing.Color.Black;
            this.tbxMethodTitle.Padding = new System.Windows.Forms.Padding(16, 9, 16, 0);
            this.tbxMethodTitle.PasswordChar = false;
            this.tbxMethodTitle.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxMethodTitle.PlaceholderText = "Payment Method Title";
            this.tbxMethodTitle.Rounding = new System.Windows.Forms.Padding(17);
            this.tbxMethodTitle.Size = new System.Drawing.Size(531, 35);
            this.tbxMethodTitle.TabIndex = 24;
            this.tbxMethodTitle.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxMethodTitle.UnderlinedStyle = false;
            this.tbxMethodTitle.Validating += new System.ComponentModel.CancelEventHandler(this.tbxMethodTitle_Validating);
            // 
            // lblID
            // 
            this.lblID.Content = "ID:\\ ";
            this.lblID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblID.Location = new System.Drawing.Point(53, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(532, 35);
            this.lblID.TabIndex = 21;
            this.lblID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiPictureBox3
            // 
            this.cuiPictureBox3.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.dollar;
            this.cuiPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox3.Content = null;
            this.cuiPictureBox3.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox3.Location = new System.Drawing.Point(12, 53);
            this.cuiPictureBox3.Name = "cuiPictureBox3";
            this.cuiPictureBox3.OutlineThickness = 1F;
            this.cuiPictureBox3.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox3.Rotation = 0;
            this.cuiPictureBox3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox3.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox3.TabIndex = 22;
            // 
            // cuiPictureBox2
            // 
            this.cuiPictureBox2.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.key_tag;
            this.cuiPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiPictureBox2.Content = null;
            this.cuiPictureBox2.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox2.Location = new System.Drawing.Point(12, 12);
            this.cuiPictureBox2.Name = "cuiPictureBox2";
            this.cuiPictureBox2.OutlineThickness = 1F;
            this.cuiPictureBox2.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox2.Rotation = 0;
            this.cuiPictureBox2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox2.Size = new System.Drawing.Size(35, 35);
            this.cuiPictureBox2.TabIndex = 23;
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel2.Controls.Add(this.btnSaveMethod);
            this.cuiPanel2.Location = new System.Drawing.Point(12, 192);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(27);
            this.cuiPanel2.Size = new System.Drawing.Size(599, 58);
            this.cuiPanel2.TabIndex = 25;
            // 
            // btnSaveMethod
            // 
            this.btnSaveMethod.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveMethod.CheckButton = false;
            this.btnSaveMethod.Checked = false;
            this.btnSaveMethod.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSaveMethod.CheckedForeColor = System.Drawing.Color.White;
            this.btnSaveMethod.CheckedImageTint = System.Drawing.Color.White;
            this.btnSaveMethod.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSaveMethod.Content = "Save Payment Method";
            this.btnSaveMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveMethod.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMethod.ForeColor = System.Drawing.Color.White;
            this.btnSaveMethod.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveMethod.HoverForeColor = System.Drawing.Color.White;
            this.btnSaveMethod.HoverImageTint = System.Drawing.Color.White;
            this.btnSaveMethod.HoverOutline = System.Drawing.Color.White;
            this.btnSaveMethod.Image = null;
            this.btnSaveMethod.ImageAutoCenter = true;
            this.btnSaveMethod.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSaveMethod.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSaveMethod.Location = new System.Drawing.Point(388, 9);
            this.btnSaveMethod.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnSaveMethod.Name = "btnSaveMethod";
            this.btnSaveMethod.NormalBackground = System.Drawing.Color.Transparent;
            this.btnSaveMethod.NormalForeColor = System.Drawing.Color.White;
            this.btnSaveMethod.NormalImageTint = System.Drawing.Color.White;
            this.btnSaveMethod.NormalOutline = System.Drawing.Color.White;
            this.btnSaveMethod.OutlineThickness = 1F;
            this.btnSaveMethod.PressedBackground = System.Drawing.Color.White;
            this.btnSaveMethod.PressedForeColor = System.Drawing.Color.Black;
            this.btnSaveMethod.PressedImageTint = System.Drawing.Color.White;
            this.btnSaveMethod.PressedOutline = System.Drawing.Color.White;
            this.btnSaveMethod.Rounding = new System.Windows.Forms.Padding(19);
            this.btnSaveMethod.Size = new System.Drawing.Size(202, 40);
            this.btnSaveMethod.TabIndex = 18;
            this.btnSaveMethod.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSaveMethod.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSaveMethod.Click += new System.EventHandler(this.btnSaveMethod_Click);
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // frmAddUpdatePaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 262);
            this.Controls.Add(this.cuiPanel2);
            this.Controls.Add(this.cuiPanel1);
            this.MaximumSize = new System.Drawing.Size(623, 262);
            this.MinimumSize = new System.Drawing.Size(623, 262);
            this.Name = "frmAddUpdatePaymentMethod";
            this.Text = "frmAddUpdatePaymentMethod";
            this.Load += new System.EventHandler(this.frmAddUpdatePaymentMethod_Load);
            this.Controls.SetChildIndex(this.cuiResizeGrip, 0);
            this.Controls.SetChildIndex(this.cuiPanel1, 0);
            this.Controls.SetChildIndex(this.cuiPanel2, 0);
            this.pnlBtnClose.ResumeLayout(false);
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        protected CuoreUI.Controls.cuiTextBox tbxMethodTitle;
        private CuoreUI.Controls.cuiLabel lblID;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiButton btnSaveMethod;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
    }
}