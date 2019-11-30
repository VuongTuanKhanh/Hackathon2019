namespace Bing_Translator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_input = new System.Windows.Forms.TextBox();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.btn_translate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbxVN = new System.Windows.Forms.PictureBox();
            this.pbxENG = new System.Windows.Forms.PictureBox();
            this.btnSpeech = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxENG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpeech)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(26, 117);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(268, 123);
            this.txt_input.TabIndex = 0;
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(365, 117);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(261, 123);
            this.txt_output.TabIndex = 1;
            // 
            // btn_translate
            // 
            this.btn_translate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_translate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_translate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_translate.Location = new System.Drawing.Point(283, 254);
            this.btn_translate.Name = "btn_translate";
            this.btn_translate.Size = new System.Drawing.Size(89, 42);
            this.btn_translate.TabIndex = 2;
            this.btn_translate.Text = "Translate";
            this.btn_translate.UseVisualStyleBackColor = false;
            this.btn_translate.Click += new System.EventHandler(this.btn_translate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(596, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 32);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMini
            // 
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.Location = new System.Drawing.Point(551, 3);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(39, 32);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMini.TabIndex = 6;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pbxVN
            // 
            this.pbxVN.Image = ((System.Drawing.Image)(resources.GetObject("pbxVN.Image")));
            this.pbxVN.Location = new System.Drawing.Point(133, 75);
            this.pbxVN.Name = "pbxVN";
            this.pbxVN.Size = new System.Drawing.Size(39, 36);
            this.pbxVN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVN.TabIndex = 8;
            this.pbxVN.TabStop = false;
            // 
            // pbxENG
            // 
            this.pbxENG.Image = ((System.Drawing.Image)(resources.GetObject("pbxENG.Image")));
            this.pbxENG.Location = new System.Drawing.Point(475, 75);
            this.pbxENG.Name = "pbxENG";
            this.pbxENG.Size = new System.Drawing.Size(39, 36);
            this.pbxENG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxENG.TabIndex = 9;
            this.pbxENG.TabStop = false;
            // 
            // btnSpeech
            // 
            this.btnSpeech.Image = ((System.Drawing.Image)(resources.GetObject("btnSpeech.Image")));
            this.btnSpeech.Location = new System.Drawing.Point(312, 12);
            this.btnSpeech.Name = "btnSpeech";
            this.btnSpeech.Size = new System.Drawing.Size(39, 36);
            this.btnSpeech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSpeech.TabIndex = 12;
            this.btnSpeech.TabStop = false;
            this.btnSpeech.Click += new System.EventHandler(this.btnSpeech_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 308);
            this.Controls.Add(this.btnSpeech);
            this.Controls.Add(this.pbxENG);
            this.Controls.Add(this.pbxVN);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_translate);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.txt_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxENG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpeech)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Button btn_translate;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMini;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbxVN;
        private System.Windows.Forms.PictureBox pbxENG;
        private System.Windows.Forms.PictureBox btnSpeech;
    }
}

