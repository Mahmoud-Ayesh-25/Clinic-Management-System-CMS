namespace Clinic_Manager_Proj.Patients.Controls
{
    partial class ctrlPatientCardWithFilter
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
            this.btnAddPatient = new CuoreUI.Controls.cuiButton();
            this.btnSelect = new CuoreUI.Controls.cuiButton();
            this.ctrlPersonInfoCard1 = new Clinic_Manager_Proj.People.Controls.ctrlPersonInfoCard();
            this.ctrlPatientCard1 = new Clinic_Manager_Proj.Patients.Controls.ctrlPatientCard();
            this.cuiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.btnAddPatient);
            this.cuiPanel1.Controls.Add(this.btnSelect);
            this.cuiPanel1.Location = new System.Drawing.Point(12, 12);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(28);
            this.cuiPanel1.Size = new System.Drawing.Size(897, 58);
            this.cuiPanel1.TabIndex = 2;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPatient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPatient.CheckButton = false;
            this.btnAddPatient.Checked = false;
            this.btnAddPatient.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAddPatient.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddPatient.CheckedImageTint = System.Drawing.Color.White;
            this.btnAddPatient.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAddPatient.Content = "Add Patient";
            this.btnAddPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPatient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.ForeColor = System.Drawing.Color.White;
            this.btnAddPatient.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddPatient.HoverForeColor = System.Drawing.Color.White;
            this.btnAddPatient.HoverImageTint = System.Drawing.Color.White;
            this.btnAddPatient.HoverOutline = System.Drawing.Color.White;
            this.btnAddPatient.Image = null;
            this.btnAddPatient.ImageAutoCenter = true;
            this.btnAddPatient.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAddPatient.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddPatient.Location = new System.Drawing.Point(754, 8);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.NormalBackground = System.Drawing.Color.Transparent;
            this.btnAddPatient.NormalForeColor = System.Drawing.Color.White;
            this.btnAddPatient.NormalImageTint = System.Drawing.Color.White;
            this.btnAddPatient.NormalOutline = System.Drawing.Color.White;
            this.btnAddPatient.OutlineThickness = 1F;
            this.btnAddPatient.PressedBackground = System.Drawing.Color.White;
            this.btnAddPatient.PressedForeColor = System.Drawing.Color.Black;
            this.btnAddPatient.PressedImageTint = System.Drawing.Color.White;
            this.btnAddPatient.PressedOutline = System.Drawing.Color.White;
            this.btnAddPatient.Rounding = new System.Windows.Forms.Padding(19);
            this.btnAddPatient.Size = new System.Drawing.Size(134, 40);
            this.btnAddPatient.TabIndex = 22;
            this.btnAddPatient.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddPatient.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.CheckButton = false;
            this.btnSelect.Checked = false;
            this.btnSelect.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSelect.CheckedForeColor = System.Drawing.Color.White;
            this.btnSelect.CheckedImageTint = System.Drawing.Color.White;
            this.btnSelect.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSelect.Content = "Select Patient";
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelect.HoverForeColor = System.Drawing.Color.White;
            this.btnSelect.HoverImageTint = System.Drawing.Color.White;
            this.btnSelect.HoverOutline = System.Drawing.Color.White;
            this.btnSelect.Image = null;
            this.btnSelect.ImageAutoCenter = true;
            this.btnSelect.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSelect.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSelect.Location = new System.Drawing.Point(8, 8);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.NormalBackground = System.Drawing.Color.Transparent;
            this.btnSelect.NormalForeColor = System.Drawing.Color.White;
            this.btnSelect.NormalImageTint = System.Drawing.Color.White;
            this.btnSelect.NormalOutline = System.Drawing.Color.White;
            this.btnSelect.OutlineThickness = 1F;
            this.btnSelect.PressedBackground = System.Drawing.Color.White;
            this.btnSelect.PressedForeColor = System.Drawing.Color.Black;
            this.btnSelect.PressedImageTint = System.Drawing.Color.White;
            this.btnSelect.PressedOutline = System.Drawing.Color.White;
            this.btnSelect.Rounding = new System.Windows.Forms.Padding(19);
            this.btnSelect.Size = new System.Drawing.Size(134, 40);
            this.btnSelect.TabIndex = 22;
            this.btnSelect.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSelect.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // ctrlPersonInfoCard1
            // 
            this.ctrlPersonInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlPersonInfoCard1.Location = new System.Drawing.Point(0, 349);
            this.ctrlPersonInfoCard1.Name = "ctrlPersonInfoCard1";
            this.ctrlPersonInfoCard1.Size = new System.Drawing.Size(921, 294);
            this.ctrlPersonInfoCard1.TabIndex = 3;
            // 
            // ctrlPatientCard1
            // 
            this.ctrlPatientCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctrlPatientCard1.Location = new System.Drawing.Point(0, 70);
            this.ctrlPatientCard1.Name = "ctrlPatientCard1";
            this.ctrlPatientCard1.Size = new System.Drawing.Size(921, 291);
            this.ctrlPatientCard1.TabIndex = 0;
            // 
            // ctrlPatientCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.ctrlPersonInfoCard1);
            this.Controls.Add(this.cuiPanel1);
            this.Controls.Add(this.ctrlPatientCard1);
            this.Name = "ctrlPatientCardWithFilter";
            this.Size = new System.Drawing.Size(921, 643);
            this.cuiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPatientCard ctrlPatientCard1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        protected CuoreUI.Controls.cuiButton btnAddPatient;
        protected CuoreUI.Controls.cuiButton btnSelect;
        private People.Controls.ctrlPersonInfoCard ctrlPersonInfoCard1;
    }
}
