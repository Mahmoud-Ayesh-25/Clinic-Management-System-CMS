namespace Clinic_Manager_Proj
{
    partial class frmMain
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
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.pnlTopContainer = new CuoreUI.Controls.cuiPanel();
            this.pbxMainIcon = new CuoreUI.Controls.cuiPictureBox();
            this.btnMinimized = new CuoreUI.Controls.cuiButton();
            this.btnMaximized = new CuoreUI.Controls.cuiButton();
            this.pnlBtnClose = new CuoreUI.Controls.cuiPanel();
            this.btnClose = new CuoreUI.Controls.cuiPictureBox();
            this.lblMainTitle = new CuoreUI.Controls.cuiLabel();
            this.cuiResizeGrip = new CuoreUI.Controls.cuiResizeGrip();
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.pnlTopContainer.SuspendLayout();
            this.pnlBtnClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuiFormAnimator
            // 
            this.cuiFormAnimator.AnimateOnStart = true;
            this.cuiFormAnimator.Duration = 200;
            this.cuiFormAnimator.EasingType = CuoreUI.Helpers.DrawingHelper.EasingTypes.QuartIn;
            this.cuiFormAnimator.StartOpacity = 0D;
            this.cuiFormAnimator.TargetForm = this;
            this.cuiFormAnimator.TargetOpacity = 1D;
            // 
            // pnlTopContainer
            // 
            this.pnlTopContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTopContainer.Controls.Add(this.pbxMainIcon);
            this.pnlTopContainer.Controls.Add(this.btnMinimized);
            this.pnlTopContainer.Controls.Add(this.btnMaximized);
            this.pnlTopContainer.Controls.Add(this.pnlBtnClose);
            this.pnlTopContainer.Controls.Add(this.lblMainTitle);
            this.pnlTopContainer.Location = new System.Drawing.Point(12, 12);
            this.pnlTopContainer.Name = "pnlTopContainer";
            this.pnlTopContainer.OutlineThickness = 1F;
            this.pnlTopContainer.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlTopContainer.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.pnlTopContainer.Rounding = new System.Windows.Forms.Padding(28);
            this.pnlTopContainer.Size = new System.Drawing.Size(1432, 58);
            this.pnlTopContainer.TabIndex = 0;
            // 
            // pbxMainIcon
            // 
            this.pbxMainIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxMainIcon.BackgroundImage = global::Clinic_Manager_Proj.Properties.Resources.vaccine;
            this.pbxMainIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxMainIcon.Content = null;
            this.pbxMainIcon.ImageTint = System.Drawing.Color.White;
            this.pbxMainIcon.Location = new System.Drawing.Point(12, 7);
            this.pbxMainIcon.Name = "pbxMainIcon";
            this.pbxMainIcon.OutlineThickness = 1F;
            this.pbxMainIcon.PanelOutlineColor = System.Drawing.Color.Empty;
            this.pbxMainIcon.Rotation = 0;
            this.pbxMainIcon.Rounding = new System.Windows.Forms.Padding(8);
            this.pbxMainIcon.Size = new System.Drawing.Size(44, 44);
            this.pbxMainIcon.TabIndex = 1;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.CheckButton = false;
            this.btnMinimized.Checked = false;
            this.btnMinimized.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnMinimized.CheckedForeColor = System.Drawing.Color.White;
            this.btnMinimized.CheckedImageTint = System.Drawing.Color.White;
            this.btnMinimized.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnMinimized.Content = "";
            this.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimized.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnMinimized.ForeColor = System.Drawing.Color.Black;
            this.btnMinimized.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(180)))));
            this.btnMinimized.HoverForeColor = System.Drawing.Color.Black;
            this.btnMinimized.HoverImageTint = System.Drawing.Color.White;
            this.btnMinimized.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(180)))));
            this.btnMinimized.Image = global::Clinic_Manager_Proj.Properties.Resources.down_chevron;
            this.btnMinimized.ImageAutoCenter = true;
            this.btnMinimized.ImageExpand = new System.Drawing.Point(3, 3);
            this.btnMinimized.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnMinimized.Location = new System.Drawing.Point(1301, 11);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(180)))));
            this.btnMinimized.NormalForeColor = System.Drawing.Color.Black;
            this.btnMinimized.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(180)))));
            this.btnMinimized.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(180)))));
            this.btnMinimized.OutlineThickness = 1F;
            this.btnMinimized.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(180)))));
            this.btnMinimized.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnMinimized.PressedImageTint = System.Drawing.Color.White;
            this.btnMinimized.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(180)))));
            this.btnMinimized.Rounding = new System.Windows.Forms.Padding(17);
            this.btnMinimized.Size = new System.Drawing.Size(36, 36);
            this.btnMinimized.TabIndex = 2;
            this.btnMinimized.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMinimized.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximized.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximized.CheckButton = false;
            this.btnMaximized.Checked = false;
            this.btnMaximized.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnMaximized.CheckedForeColor = System.Drawing.Color.White;
            this.btnMaximized.CheckedImageTint = System.Drawing.Color.White;
            this.btnMaximized.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnMaximized.Content = "";
            this.btnMaximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximized.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMaximized.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnMaximized.ForeColor = System.Drawing.Color.Black;
            this.btnMaximized.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(180)))));
            this.btnMaximized.HoverForeColor = System.Drawing.Color.Black;
            this.btnMaximized.HoverImageTint = System.Drawing.Color.White;
            this.btnMaximized.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(180)))));
            this.btnMaximized.Image = global::Clinic_Manager_Proj.Properties.Resources.expand;
            this.btnMaximized.ImageAutoCenter = true;
            this.btnMaximized.ImageExpand = new System.Drawing.Point(3, 3);
            this.btnMaximized.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnMaximized.Location = new System.Drawing.Point(1343, 11);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(180)))));
            this.btnMaximized.NormalForeColor = System.Drawing.Color.Black;
            this.btnMaximized.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(180)))));
            this.btnMaximized.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(180)))));
            this.btnMaximized.OutlineThickness = 1F;
            this.btnMaximized.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(180)))));
            this.btnMaximized.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnMaximized.PressedImageTint = System.Drawing.Color.White;
            this.btnMaximized.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(180)))));
            this.btnMaximized.Rounding = new System.Windows.Forms.Padding(17);
            this.btnMaximized.Size = new System.Drawing.Size(36, 36);
            this.btnMaximized.TabIndex = 1;
            this.btnMaximized.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMaximized.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // pnlBtnClose
            // 
            this.pnlBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.pnlBtnClose.Controls.Add(this.btnClose);
            this.pnlBtnClose.Location = new System.Drawing.Point(1385, 11);
            this.pnlBtnClose.Name = "pnlBtnClose";
            this.pnlBtnClose.OutlineThickness = 0F;
            this.pnlBtnClose.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlBtnClose.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlBtnClose.Rounding = new System.Windows.Forms.Padding(18);
            this.pnlBtnClose.Size = new System.Drawing.Size(36, 36);
            this.pnlBtnClose.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Content = global::Clinic_Manager_Proj.Properties.Resources.cross__1_;
            this.btnClose.ImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(5, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.OutlineThickness = 1F;
            this.btnClose.PanelOutlineColor = System.Drawing.Color.Empty;
            this.btnClose.Rotation = 0;
            this.btnClose.Rounding = new System.Windows.Forms.Padding(8);
            this.btnClose.Size = new System.Drawing.Size(26, 26);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMainTitle.Content = "Main\\ Title";
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.White;
            this.lblMainTitle.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblMainTitle.Location = new System.Drawing.Point(0, 0);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(1432, 58);
            this.lblMainTitle.TabIndex = 1;
            this.lblMainTitle.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiResizeGrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cuiResizeGrip.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.cuiResizeGrip.GripColor = System.Drawing.Color.Gray;
            this.cuiResizeGrip.GripSize = 2;
            this.cuiResizeGrip.GripTexture = true;
            this.cuiResizeGrip.Location = new System.Drawing.Point(1444, 264);
            this.cuiResizeGrip.Name = "cuiResizeGrip";
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 516);
            this.cuiResizeGrip.SkipBottomRightSquare = true;
            this.cuiResizeGrip.TabIndex = 1;
            this.cuiResizeGrip.TargetForm = this;
            this.cuiResizeGrip.TextureOffset = new System.Drawing.Size(-2, -2);
            // 
            // cuiFormRounder
            // 
            this.cuiFormRounder.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiFormRounder.Rounding = 15;
            this.cuiFormRounder.TargetForm = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1456, 780);
            this.Controls.Add(this.cuiResizeGrip);
            this.Controls.Add(this.pnlTopContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1456, 780);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.frmDashboard_SizeChanged);
            this.pnlTopContainer.ResumeLayout(false);
            this.pnlBtnClose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
        private CuoreUI.Controls.cuiPanel pnlTopContainer;
        protected CuoreUI.Controls.cuiButton btnMaximized;
        protected CuoreUI.Controls.cuiButton btnMinimized;
        protected CuoreUI.Controls.cuiPictureBox btnClose;
        public CuoreUI.Controls.cuiPictureBox pbxMainIcon;
        public CuoreUI.Controls.cuiLabel lblMainTitle;
        protected CuoreUI.Controls.cuiPanel pnlBtnClose;
        public CuoreUI.Controls.cuiResizeGrip cuiResizeGrip;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
    }
}

