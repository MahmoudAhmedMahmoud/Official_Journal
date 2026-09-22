namespace Official_Journal
{
    partial class frm_UserHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UserHistory));
            this.grid_Search = new DevExpress.XtraGrid.GridControl();
            this.dgv_Search = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmb_Model = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_User = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_Search
            // 
            this.grid_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.grid_Search.Location = new System.Drawing.Point(0, 64);
            this.grid_Search.MainView = this.dgv_Search;
            this.grid_Search.Name = "grid_Search";
            this.grid_Search.Size = new System.Drawing.Size(732, 540);
            this.grid_Search.TabIndex = 4;
            this.grid_Search.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_Search});
            this.grid_Search.Load += new System.EventHandler(this.grid_Search_Load);
            // 
            // dgv_Search
            // 
            this.dgv_Search.Appearance.Row.Options.UseTextOptions = true;
            this.dgv_Search.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.dgv_Search.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgv_Search.GridControl = this.grid_Search;
            this.dgv_Search.Name = "dgv_Search";
            this.dgv_Search.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_Search.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_Search.OptionsBehavior.Editable = false;
            this.dgv_Search.OptionsBehavior.ReadOnly = true;
            this.dgv_Search.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgv_Search.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmb_Model);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.cmb_User);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.btn_Search);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(732, 64);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "معايير البحث";
            // 
            // cmb_Model
            // 
            this.cmb_Model.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Model.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Model.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.cmb_Model.FormattingEnabled = true;
            this.cmb_Model.Location = new System.Drawing.Point(104, 31);
            this.cmb_Model.Name = "cmb_Model";
            this.cmb_Model.Size = new System.Drawing.Size(231, 21);
            this.cmb_Model.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(341, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "شاشة الحركة";
            // 
            // cmb_User
            // 
            this.cmb_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_User.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_User.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.cmb_User.FormattingEnabled = true;
            this.cmb_User.Location = new System.Drawing.Point(426, 31);
            this.cmb_User.Name = "cmb_User";
            this.cmb_User.Size = new System.Drawing.Size(231, 21);
            this.cmb_User.TabIndex = 12;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(663, 35);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(55, 13);
            this.labelControl8.TabIndex = 11;
            this.labelControl8.Text = "المستخدمين";
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Location = new System.Drawing.Point(22, 30);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(60, 23);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "بحث";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_UserHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 605);
            this.Controls.Add(this.grid_Search);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::Official_Journal.Properties.Resources.Journal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_UserHistory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "حركة المستخدمين";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_Search;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_Search;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cmb_Model;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cmb_User;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
    }
}