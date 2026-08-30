namespace Official_Journal
{
    partial class frm_SearchAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SearchAll));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.dtp_SaveDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_dtpSave = new DevExpress.XtraEditors.LabelControl();
            this.dtp_PubDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_dtpPub = new DevExpress.XtraEditors.LabelControl();
            this.cmb_ = new System.Windows.Forms.ComboBox();
            this.cmb_Dep = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_Auth = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.spin_Year = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_LawNo = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_IssueNo = new System.Windows.Forms.TextBox();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_OpenFile = new DevExpress.XtraEditors.SimpleButton();
            this.grid_Search = new DevExpress.XtraGrid.GridControl();
            this.dgv_Search = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chk_dtp_Pub = new System.Windows.Forms.CheckBox();
            this.chk_dtp_Save = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spin_Year.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chk_dtp_Save);
            this.groupControl1.Controls.Add(this.chk_dtp_Pub);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.dtp_SaveDate);
            this.groupControl1.Controls.Add(this.lbl_dtpSave);
            this.groupControl1.Controls.Add(this.dtp_PubDate);
            this.groupControl1.Controls.Add(this.lbl_dtpPub);
            this.groupControl1.Controls.Add(this.cmb_);
            this.groupControl1.Controls.Add(this.cmb_Dep);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.cmb_Auth);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.spin_Year);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_LawNo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txt_IssueNo);
            this.groupControl1.Controls.Add(this.btn_Search);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(854, 183);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "معايير البحث";
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl10.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(138, 46);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(78, 19);
            this.labelControl10.TabIndex = 17;
            this.labelControl10.Text = "مطابقة القرار";
            // 
            // dtp_SaveDate
            // 
            this.dtp_SaveDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_SaveDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_SaveDate.Enabled = false;
            this.dtp_SaveDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dtp_SaveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_SaveDate.Location = new System.Drawing.Point(250, 71);
            this.dtp_SaveDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_SaveDate.Name = "dtp_SaveDate";
            this.dtp_SaveDate.RightToLeftLayout = true;
            this.dtp_SaveDate.Size = new System.Drawing.Size(116, 24);
            this.dtp_SaveDate.TabIndex = 16;
            // 
            // lbl_dtpSave
            // 
            this.lbl_dtpSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dtpSave.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.lbl_dtpSave.Appearance.Options.UseFont = true;
            this.lbl_dtpSave.Enabled = false;
            this.lbl_dtpSave.Location = new System.Drawing.Point(273, 46);
            this.lbl_dtpSave.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_dtpSave.Name = "lbl_dtpSave";
            this.lbl_dtpSave.Size = new System.Drawing.Size(69, 19);
            this.lbl_dtpSave.TabIndex = 15;
            this.lbl_dtpSave.Text = "تاريخ الحفظ";
            // 
            // dtp_PubDate
            // 
            this.dtp_PubDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_PubDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_PubDate.Enabled = false;
            this.dtp_PubDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dtp_PubDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_PubDate.Location = new System.Drawing.Point(373, 71);
            this.dtp_PubDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_PubDate.Name = "dtp_PubDate";
            this.dtp_PubDate.RightToLeftLayout = true;
            this.dtp_PubDate.Size = new System.Drawing.Size(116, 24);
            this.dtp_PubDate.TabIndex = 14;
            // 
            // lbl_dtpPub
            // 
            this.lbl_dtpPub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dtpPub.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.lbl_dtpPub.Appearance.Options.UseFont = true;
            this.lbl_dtpPub.Enabled = false;
            this.lbl_dtpPub.Location = new System.Drawing.Point(397, 46);
            this.lbl_dtpPub.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_dtpPub.Name = "lbl_dtpPub";
            this.lbl_dtpPub.Size = new System.Drawing.Size(64, 19);
            this.lbl_dtpPub.TabIndex = 13;
            this.lbl_dtpPub.Text = "تاريخ النشر";
            // 
            // cmb_
            // 
            this.cmb_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.cmb_.FormattingEnabled = true;
            this.cmb_.Items.AddRange(new object[] {
            "ينطبق",
            "لا ينطبق"});
            this.cmb_.Location = new System.Drawing.Point(112, 71);
            this.cmb_.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_.Name = "cmb_";
            this.cmb_.Size = new System.Drawing.Size(130, 24);
            this.cmb_.TabIndex = 12;
            // 
            // cmb_Dep
            // 
            this.cmb_Dep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Dep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Dep.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.cmb_Dep.FormattingEnabled = true;
            this.cmb_Dep.Location = new System.Drawing.Point(112, 123);
            this.cmb_Dep.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Dep.Name = "cmb_Dep";
            this.cmb_Dep.Size = new System.Drawing.Size(269, 24);
            this.cmb_Dep.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(388, 128);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 19);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "الجهة المعنية";
            // 
            // cmb_Auth
            // 
            this.cmb_Auth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Auth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Auth.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.cmb_Auth.FormattingEnabled = true;
            this.cmb_Auth.Location = new System.Drawing.Point(488, 123);
            this.cmb_Auth.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Auth.Name = "cmb_Auth";
            this.cmb_Auth.Size = new System.Drawing.Size(269, 24);
            this.cmb_Auth.TabIndex = 12;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(764, 128);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(70, 19);
            this.labelControl8.TabIndex = 11;
            this.labelControl8.Text = "جهة الاصدار";
            // 
            // spin_Year
            // 
            this.spin_Year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spin_Year.EditValue = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.spin_Year.EnterMoveNextControl = true;
            this.spin_Year.Location = new System.Drawing.Point(497, 71);
            this.spin_Year.Margin = new System.Windows.Forms.Padding(4);
            this.spin_Year.Name = "spin_Year";
            this.spin_Year.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.spin_Year.Properties.Appearance.Options.UseFont = true;
            this.spin_Year.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_Year.Properties.EditFormat.FormatString = "yyyy";
            this.spin_Year.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.spin_Year.Properties.MaskSettings.Set("mask", "0000");
            this.spin_Year.Size = new System.Drawing.Size(89, 24);
            this.spin_Year.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(523, 46);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 19);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "السنة";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(620, 46);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 19);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "رقم القانون";
            // 
            // txt_LawNo
            // 
            this.txt_LawNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_LawNo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txt_LawNo.Location = new System.Drawing.Point(593, 71);
            this.txt_LawNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LawNo.Name = "txt_LawNo";
            this.txt_LawNo.Size = new System.Drawing.Size(122, 24);
            this.txt_LawNo.TabIndex = 7;
            this.txt_LawNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(752, 46);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 19);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "رقم العدد";
            // 
            // txt_IssueNo
            // 
            this.txt_IssueNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_IssueNo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txt_IssueNo.Location = new System.Drawing.Point(722, 71);
            this.txt_IssueNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IssueNo.Name = "txt_IssueNo";
            this.txt_IssueNo.Size = new System.Drawing.Size(116, 24);
            this.txt_IssueNo.TabIndex = 5;
            this.txt_IssueNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.ImageOptions.Image")));
            this.btn_Search.Location = new System.Drawing.Point(16, 123);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(70, 30);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "بحث";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OpenFile.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_OpenFile.Appearance.Options.UseFont = true;
            this.btn_OpenFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_OpenFile.ImageOptions.Image")));
            this.btn_OpenFile.Location = new System.Drawing.Point(30, 4);
            this.btn_OpenFile.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(100, 30);
            this.btn_OpenFile.TabIndex = 4;
            this.btn_OpenFile.Text = "فتح الملف";
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // grid_Search
            // 
            this.grid_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.grid_Search.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grid_Search.Location = new System.Drawing.Point(0, 183);
            this.grid_Search.MainView = this.dgv_Search;
            this.grid_Search.Margin = new System.Windows.Forms.Padding(4);
            this.grid_Search.Name = "grid_Search";
            this.grid_Search.Size = new System.Drawing.Size(854, 571);
            this.grid_Search.TabIndex = 2;
            this.grid_Search.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_Search});
            // 
            // dgv_Search
            // 
            this.dgv_Search.DetailHeight = 458;
            this.dgv_Search.GridControl = this.grid_Search;
            this.dgv_Search.Name = "dgv_Search";
            this.dgv_Search.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_Search.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_Search.OptionsBehavior.Editable = false;
            this.dgv_Search.OptionsBehavior.ReadOnly = true;
            this.dgv_Search.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgv_Search.OptionsView.ColumnAutoWidth = false;
            this.dgv_Search.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_OpenFile);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 754);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(854, 37);
            this.panelControl1.TabIndex = 3;
            // 
            // chk_dtp_Pub
            // 
            this.chk_dtp_Pub.AutoSize = true;
            this.chk_dtp_Pub.Location = new System.Drawing.Point(468, 48);
            this.chk_dtp_Pub.Name = "chk_dtp_Pub";
            this.chk_dtp_Pub.Size = new System.Drawing.Size(18, 17);
            this.chk_dtp_Pub.TabIndex = 18;
            this.chk_dtp_Pub.UseVisualStyleBackColor = true;
            this.chk_dtp_Pub.CheckedChanged += new System.EventHandler(this.chk_dtp_Pub_CheckedChanged);
            // 
            // chk_dtp_Save
            // 
            this.chk_dtp_Save.AutoSize = true;
            this.chk_dtp_Save.Location = new System.Drawing.Point(348, 48);
            this.chk_dtp_Save.Name = "chk_dtp_Save";
            this.chk_dtp_Save.Size = new System.Drawing.Size(18, 17);
            this.chk_dtp_Save.TabIndex = 18;
            this.chk_dtp_Save.UseVisualStyleBackColor = true;
            this.chk_dtp_Save.CheckedChanged += new System.EventHandler(this.chk_dtp_Save_CheckedChanged);
            // 
            // frm_SearchAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 791);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.grid_Search);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::Official_Journal.Properties.Resources.Journal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_SearchAll";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بحث القوانين";
            this.Load += new System.EventHandler(this.frm_SearchAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spin_Year.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txt_IssueNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txt_LawNo;
        private DevExpress.XtraEditors.SpinEdit spin_Year;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cmb_Auth;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.ComboBox cmb_Dep;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dtp_PubDate;
        private DevExpress.XtraEditors.LabelControl lbl_dtpPub;
        private System.Windows.Forms.DateTimePicker dtp_SaveDate;
        private DevExpress.XtraEditors.LabelControl lbl_dtpSave;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.ComboBox cmb_;
        private DevExpress.XtraEditors.SimpleButton btn_OpenFile;
        private DevExpress.XtraGrid.GridControl grid_Search;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_Search;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.CheckBox chk_dtp_Save;
        private System.Windows.Forms.CheckBox chk_dtp_Pub;
    }
}