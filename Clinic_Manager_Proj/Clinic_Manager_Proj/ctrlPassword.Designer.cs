namespace Clinic_Manager_Proj
{
    partial class ctrlPassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPassword));
            this.tbxPassword = new CuoreUI.Controls.cuiTextBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnShow = new CuoreUI.Controls.cuiButton();
            this.SuspendLayout();
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbxPassword.BackgroundColor = System.Drawing.Color.Black;
            this.tbxPassword.Content = "";
            this.tbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPassword.FocusBackgroundColor = System.Drawing.Color.Black;
            this.tbxPassword.FocusImageTint = System.Drawing.Color.White;
            this.tbxPassword.FocusOutlineColor = System.Drawing.Color.White;
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.ForeColor = System.Drawing.Color.White;
            this.tbxPassword.Image = null;
            this.tbxPassword.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxPassword.Location = new System.Drawing.Point(0, 0);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPassword.Multiline = false;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.NormalImageTint = System.Drawing.Color.White;
            this.tbxPassword.OutlineColor = System.Drawing.Color.Black;
            this.tbxPassword.Padding = new System.Windows.Forms.Padding(16, 12, 16, 0);
            this.tbxPassword.PasswordChar = true;
            this.tbxPassword.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxPassword.PlaceholderText = "Password";
            this.tbxPassword.Rounding = new System.Windows.Forms.Padding(19);
            this.tbxPassword.Size = new System.Drawing.Size(217, 40);
            this.tbxPassword.TabIndex = 20;
            this.tbxPassword.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxPassword.UnderlinedStyle = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "show (1).png");
            this.imageList.Images.SetKeyName(1, "hide-layer.png");
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.CheckButton = false;
            this.btnShow.Checked = false;
            this.btnShow.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShow.CheckedForeColor = System.Drawing.Color.White;
            this.btnShow.CheckedImageTint = System.Drawing.Color.White;
            this.btnShow.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShow.Content = "";
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShow.HoverForeColor = System.Drawing.Color.White;
            this.btnShow.HoverImageTint = System.Drawing.Color.White;
            this.btnShow.HoverOutline = System.Drawing.Color.White;
            this.btnShow.Image = global::Clinic_Manager_Proj.Properties.Resources.show__1_;
            this.btnShow.ImageAutoCenter = true;
            this.btnShow.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnShow.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnShow.Location = new System.Drawing.Point(217, 0);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.NormalBackground = System.Drawing.Color.Transparent;
            this.btnShow.NormalForeColor = System.Drawing.Color.White;
            this.btnShow.NormalImageTint = System.Drawing.Color.White;
            this.btnShow.NormalOutline = System.Drawing.Color.White;
            this.btnShow.OutlineThickness = 1F;
            this.btnShow.PressedBackground = System.Drawing.Color.White;
            this.btnShow.PressedForeColor = System.Drawing.Color.Black;
            this.btnShow.PressedImageTint = System.Drawing.Color.White;
            this.btnShow.PressedOutline = System.Drawing.Color.White;
            this.btnShow.Rounding = new System.Windows.Forms.Padding(19);
            this.btnShow.Size = new System.Drawing.Size(40, 40);
            this.btnShow.TabIndex = 21;
            this.btnShow.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnShow.TextOffset = new System.Drawing.Point(0, 0);
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // ctrlPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.tbxPassword);
            this.Name = "ctrlPassword";
            this.Size = new System.Drawing.Size(257, 40);
            this.SizeChanged += new System.EventHandler(this.ctrlPassword_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        protected CuoreUI.Controls.cuiTextBox tbxPassword;
        private CuoreUI.Controls.cuiButton btnShow;
        private System.Windows.Forms.ImageList imageList;
    }
}
