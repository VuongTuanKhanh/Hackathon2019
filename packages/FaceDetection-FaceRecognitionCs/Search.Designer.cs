namespace MultiFaceRec
{
    partial class Search
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
            this.wb_Video = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wb_Video
            // 
            this.wb_Video.Location = new System.Drawing.Point(12, 12);
            this.wb_Video.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_Video.Name = "wb_Video";
            this.wb_Video.Size = new System.Drawing.Size(1359, 736);
            this.wb_Video.TabIndex = 22;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.wb_Video);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser wb_Video;
    }
}