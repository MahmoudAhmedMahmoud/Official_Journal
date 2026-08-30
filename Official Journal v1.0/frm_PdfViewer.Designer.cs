namespace Official_Journal
{
    partial class frm_PdfViewer
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
            this.pdfVie = new DevExpress.XtraPdfViewer.PdfViewer();
            this.SuspendLayout();
            // 
            // pdfVie
            // 
            this.pdfVie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfVie.Location = new System.Drawing.Point(0, 0);
            this.pdfVie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pdfVie.Name = "pdfVie";
            this.pdfVie.Size = new System.Drawing.Size(765, 823);
            this.pdfVie.TabIndex = 0;
            // 
            // frm_PdfViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 823);
            this.Controls.Add(this.pdfVie);
            this.IconOptions.Image = global::Official_Journal.Properties.Resources.Journal;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_PdfViewer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_PdfViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraPdfViewer.PdfViewer pdfVie;
    }
}