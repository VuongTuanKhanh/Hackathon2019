namespace Hackathon
{
    partial class frmSignin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignin));
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.QR_Picturebox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Barcode_Picturebox = new System.Windows.Forms.PictureBox();
            this.btnSignin = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QR_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barcode_Picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGmail
            // 
            this.txtGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGmail.Location = new System.Drawing.Point(49, 226);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(323, 27);
            this.txtGmail.TabIndex = 3;
            this.txtGmail.Text = "Gmail";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(49, 184);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(323, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(48, 144);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(132, 27);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "MSSV";
            // 
            // QR_Picturebox
            // 
            this.QR_Picturebox.InitialImage = global::Hackathon.Properties.Resources.Google_Station_free_wifi_1280x720;
            this.QR_Picturebox.Location = new System.Drawing.Point(211, 25);
            this.QR_Picturebox.Name = "QR_Picturebox";
            this.QR_Picturebox.Size = new System.Drawing.Size(161, 154);
            this.QR_Picturebox.TabIndex = 4;
            this.QR_Picturebox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sign In";
            // 
            // Barcode_Picturebox
            // 
            this.Barcode_Picturebox.InitialImage = ((System.Drawing.Image)(resources.GetObject("Barcode_Picturebox.InitialImage")));
            this.Barcode_Picturebox.Location = new System.Drawing.Point(399, 25);
            this.Barcode_Picturebox.Name = "Barcode_Picturebox";
            this.Barcode_Picturebox.Size = new System.Drawing.Size(275, 146);
            this.Barcode_Picturebox.TabIndex = 6;
            this.Barcode_Picturebox.TabStop = false;
            // 
            // btnSignin
            // 
            this.btnSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.Location = new System.Drawing.Point(398, 184);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(119, 32);
            this.btnSignin.TabIndex = 7;
            this.btnSignin.Text = "Sign In";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSingin_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(523, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(399, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(265, 32);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmSignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 266);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.Barcode_Picturebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QR_Picturebox);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "frmSignin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSignIn";
            ((System.ComponentModel.ISupportInitialize)(this.QR_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barcode_Picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox QR_Picturebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Barcode_Picturebox;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}