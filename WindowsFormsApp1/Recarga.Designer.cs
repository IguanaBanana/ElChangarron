namespace WindowsFormsApp1
{
    partial class Recarga
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
            this.webBrowserRecarga = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserRecarga
            // 
            this.webBrowserRecarga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserRecarga.Location = new System.Drawing.Point(0, 0);
            this.webBrowserRecarga.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserRecarga.Name = "webBrowserRecarga";
            this.webBrowserRecarga.Size = new System.Drawing.Size(800, 450);
            this.webBrowserRecarga.TabIndex = 1;
            this.webBrowserRecarga.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowserRecarga.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowserRecarga_Navigating);
            // 
            // Recarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowserRecarga);
            this.Name = "Recarga";
            this.Text = "Recarga";
            this.Load += new System.EventHandler(this.Recarga_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowserRecarga;
    }
}