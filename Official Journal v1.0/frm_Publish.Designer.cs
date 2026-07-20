namespace Official_Journal
{
    partial class frm_Publish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Publish));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.page_NotPub = new DevExpress.XtraTab.XtraTabPage();
            this.btn_Pub = new DevExpress.XtraEditors.SimpleButton();
            this.grid_NotPub = new DevExpress.XtraGrid.GridControl();
            this.dgv_NotPub = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.page_Pub = new DevExpress.XtraTab.XtraTabPage();
            this.btn_NotPub = new DevExpress.XtraEditors.SimpleButton();
            this.grid_Pub = new DevExpress.XtraGrid.GridControl();
            this.dgv_Pub = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.page_NotPub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_NotPub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NotPub)).BeginInit();
            this.page_Pub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Pub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pub)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.page_NotPub;
            this.xtraTabControl1.Size = new System.Drawing.Size(784, 612);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.page_Pub,
            this.page_NotPub});
            this.xtraTabControl1.Click += new System.EventHandler(this.page_Pub_Click);
            // 
            // page_NotPub
            // 
            this.page_NotPub.Controls.Add(this.btn_Pub);
            this.page_NotPub.Controls.Add(this.grid_NotPub);
            this.page_NotPub.Name = "page_NotPub";
            this.page_NotPub.Size = new System.Drawing.Size(777, 584);
            this.page_NotPub.Text = "الاعداد الغير موزعة";
            this.page_NotPub.Click += new System.EventHandler(this.page_NotPub_Click);
            // 
            // btn_Pub
            // 
            this.btn_Pub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pub.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Pub.Appearance.Options.UseFont = true;
            this.btn_Pub.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pub.ImageOptions.Image")));
            this.btn_Pub.Location = new System.Drawing.Point(10, 558);
            this.btn_Pub.Name = "btn_Pub";
            this.btn_Pub.Size = new System.Drawing.Size(85, 23);
            this.btn_Pub.TabIndex = 5;
            this.btn_Pub.Text = "توزيع";
            this.btn_Pub.Click += new System.EventHandler(this.btn_Pub_Click);
            // 
            // grid_NotPub
            // 
            this.grid_NotPub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_NotPub.Location = new System.Drawing.Point(0, 0);
            this.grid_NotPub.MainView = this.dgv_NotPub;
            this.grid_NotPub.Name = "grid_NotPub";
            this.grid_NotPub.Size = new System.Drawing.Size(777, 584);
            this.grid_NotPub.TabIndex = 0;
            this.grid_NotPub.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_NotPub});
            // 
            // dgv_NotPub
            // 
            this.dgv_NotPub.GridControl = this.grid_NotPub;
            this.dgv_NotPub.Name = "dgv_NotPub";
            this.dgv_NotPub.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_NotPub.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_NotPub.OptionsBehavior.Editable = false;
            this.dgv_NotPub.OptionsBehavior.ReadOnly = true;
            this.dgv_NotPub.OptionsCustomization.AllowColumnMoving = false;
            this.dgv_NotPub.OptionsCustomization.AllowGroup = false;
            this.dgv_NotPub.OptionsFind.AlwaysVisible = true;
            this.dgv_NotPub.OptionsSelection.MultiSelect = true;
            this.dgv_NotPub.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.dgv_NotPub.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.dgv_NotPub.OptionsView.ShowFooter = true;
            this.dgv_NotPub.OptionsView.ShowGroupPanel = false;
            // 
            // page_Pub
            // 
            this.page_Pub.Controls.Add(this.btn_NotPub);
            this.page_Pub.Controls.Add(this.grid_Pub);
            this.page_Pub.Name = "page_Pub";
            this.page_Pub.Size = new System.Drawing.Size(777, 584);
            this.page_Pub.Text = "الاعداد الموزعة";
            this.page_Pub.Click += new System.EventHandler(this.page_Pub_Click);
            // 
            // btn_NotPub
            // 
            this.btn_NotPub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NotPub.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_NotPub.Appearance.Options.UseFont = true;
            this.btn_NotPub.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_NotPub.ImageOptions.Image")));
            this.btn_NotPub.Location = new System.Drawing.Point(10, 558);
            this.btn_NotPub.Name = "btn_NotPub";
            this.btn_NotPub.Size = new System.Drawing.Size(104, 23);
            this.btn_NotPub.TabIndex = 5;
            this.btn_NotPub.Text = "سحب التوزيع";
            this.btn_NotPub.Click += new System.EventHandler(this.btn_NotPub_Click);
            // 
            // grid_Pub
            // 
            this.grid_Pub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Pub.Location = new System.Drawing.Point(0, 0);
            this.grid_Pub.MainView = this.dgv_Pub;
            this.grid_Pub.Name = "grid_Pub";
            this.grid_Pub.Size = new System.Drawing.Size(777, 584);
            this.grid_Pub.TabIndex = 0;
            this.grid_Pub.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_Pub});
            // 
            // dgv_Pub
            // 
            this.dgv_Pub.GridControl = this.grid_Pub;
            this.dgv_Pub.Name = "dgv_Pub";
            this.dgv_Pub.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_Pub.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_Pub.OptionsBehavior.Editable = false;
            this.dgv_Pub.OptionsBehavior.ReadOnly = true;
            this.dgv_Pub.OptionsCustomization.AllowGroup = false;
            this.dgv_Pub.OptionsFind.AlwaysVisible = true;
            this.dgv_Pub.OptionsSelection.MultiSelect = true;
            this.dgv_Pub.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.dgv_Pub.OptionsView.ShowFooter = true;
            this.dgv_Pub.OptionsView.ShowGroupPanel = false;
            // 
            // frm_Publish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 612);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_Publish.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Publish";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "توزيع الاعداد";
            this.Load += new System.EventHandler(this.frm_Publish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.page_NotPub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_NotPub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NotPub)).EndInit();
            this.page_Pub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Pub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage page_NotPub;
        private DevExpress.XtraTab.XtraTabPage page_Pub;
        private DevExpress.XtraGrid.GridControl grid_Pub;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_Pub;
        private DevExpress.XtraGrid.GridControl grid_NotPub;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_NotPub;
        private DevExpress.XtraEditors.SimpleButton btn_Pub;
        private DevExpress.XtraEditors.SimpleButton btn_NotPub;
    }
}