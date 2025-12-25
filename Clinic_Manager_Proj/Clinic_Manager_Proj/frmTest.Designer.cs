namespace Clinic_Manager_Proj
{
    partial class frmTest
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
            this.tbxBeforEn = new System.Windows.Forms.TextBox();
            this.tbxAfterEn = new System.Windows.Forms.TextBox();
            this.tbxBeforDe = new System.Windows.Forms.TextBox();
            this.tbxAfterDe = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxBeforEn
            // 
            this.tbxBeforEn.Location = new System.Drawing.Point(250, 123);
            this.tbxBeforEn.Name = "tbxBeforEn";
            this.tbxBeforEn.Size = new System.Drawing.Size(215, 20);
            this.tbxBeforEn.TabIndex = 0;
            // 
            // tbxAfterEn
            // 
            this.tbxAfterEn.Location = new System.Drawing.Point(250, 149);
            this.tbxAfterEn.Name = "tbxAfterEn";
            this.tbxAfterEn.ReadOnly = true;
            this.tbxAfterEn.Size = new System.Drawing.Size(215, 20);
            this.tbxAfterEn.TabIndex = 0;
            // 
            // tbxBeforDe
            // 
            this.tbxBeforDe.Location = new System.Drawing.Point(250, 220);
            this.tbxBeforDe.Name = "tbxBeforDe";
            this.tbxBeforDe.Size = new System.Drawing.Size(215, 20);
            this.tbxBeforDe.TabIndex = 0;
            // 
            // tbxAfterDe
            // 
            this.tbxAfterDe.Location = new System.Drawing.Point(250, 246);
            this.tbxAfterDe.Name = "tbxAfterDe";
            this.tbxAfterDe.ReadOnly = true;
            this.tbxAfterDe.Size = new System.Drawing.Size(215, 20);
            this.tbxAfterDe.TabIndex = 0;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(487, 123);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(487, 220);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbxAfterDe);
            this.Controls.Add(this.tbxBeforDe);
            this.Controls.Add(this.tbxAfterEn);
            this.Controls.Add(this.tbxBeforEn);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBeforEn;
        private System.Windows.Forms.TextBox tbxAfterEn;
        private System.Windows.Forms.TextBox tbxBeforDe;
        private System.Windows.Forms.TextBox tbxAfterDe;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
    }
}