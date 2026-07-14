namespace Official_Journal
{
    partial class frm_Add_IssuingAuthorities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_IssuingAuthorities));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edite = new DevExpress.XtraEditors.SimpleButton();
            this.gb_IssueAuth = new DevExpress.XtraEditors.GroupControl();
            this.grid_IssueAuth = new DevExpress.XtraGrid.GridControl();
            this.dgv_IssueAuth = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gb_AuthDetails = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.txt_IssuAuth = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gb_IssueAuth)).BeginInit();
            this.gb_IssueAuth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_IssueAuth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IssueAuth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_AuthDetails)).BeginInit();
            this.gb_AuthDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btn_Cancel);
            this.panelControl1.Controls.Add(this.btn_Delete);
            this.panelControl1.Controls.Add(this.btn_New);
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.btn_Edite);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 352);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(585, 38);
            this.panelControl1.TabIndex = 10;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Enabled = false;
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton9.ImageOptions.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(130, 8);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(60, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "الغاء";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton8.ImageOptions.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(196, 8);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(60, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_New.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton11.ImageOptions.Image")));
            this.btn_New.Location = new System.Drawing.Point(394, 8);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(60, 23);
            this.btn_New.TabIndex = 6;
            this.btn_New.Text = "جديد";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Enabled = false;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton10.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(328, 8);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(60, 23);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edite
            // 
            this.btn_Edite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edite.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Edite.Appearance.Options.UseFont = true;
            this.btn_Edite.Enabled = false;
            this.btn_Edite.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton7.ImageOptions.Image")));
            this.btn_Edite.Location = new System.Drawing.Point(262, 8);
            this.btn_Edite.Name = "btn_Edite";
            this.btn_Edite.Size = new System.Drawing.Size(60, 23);
            this.btn_Edite.TabIndex = 8;
            this.btn_Edite.Text = "تعديل";
            this.btn_Edite.Click += new System.EventHandler(this.btn_Edite_Click);
            // 
            // gb_IssueAuth
            // 
            this.gb_IssueAuth.Controls.Add(this.grid_IssueAuth);
            this.gb_IssueAuth.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_IssueAuth.Location = new System.Drawing.Point(0, 118);
            this.gb_IssueAuth.Name = "gb_IssueAuth";
            this.gb_IssueAuth.Size = new System.Drawing.Size(585, 234);
            this.gb_IssueAuth.TabIndex = 9;
            this.gb_IssueAuth.Text = "جهات الصدار";
            // 
            // grid_IssueAuth
            // 
            this.grid_IssueAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_IssueAuth.Location = new System.Drawing.Point(2, 22);
            this.grid_IssueAuth.MainView = this.dgv_IssueAuth;
            this.grid_IssueAuth.Name = "grid_IssueAuth";
            this.grid_IssueAuth.Size = new System.Drawing.Size(581, 210);
            this.grid_IssueAuth.TabIndex = 0;
            this.grid_IssueAuth.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_IssueAuth});
            // 
            // dgv_IssueAuth
            // 
            this.dgv_IssueAuth.GridControl = this.grid_IssueAuth;
            this.dgv_IssueAuth.Name = "dgv_IssueAuth";
            this.dgv_IssueAuth.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_IssueAuth.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_IssueAuth.OptionsBehavior.Editable = false;
            this.dgv_IssueAuth.OptionsBehavior.ReadOnly = true;
            this.dgv_IssueAuth.OptionsCustomization.AllowColumnMoving = false;
            this.dgv_IssueAuth.OptionsCustomization.AllowGroup = false;
            this.dgv_IssueAuth.OptionsFind.AlwaysVisible = true;
            this.dgv_IssueAuth.DoubleClick += new System.EventHandler(this.dgv_IssueAuth_DoubleClick);
            // 
            // gb_AuthDetails
            // 
            this.gb_AuthDetails.Controls.Add(this.labelControl3);
            this.gb_AuthDetails.Controls.Add(this.labelControl2);
            this.gb_AuthDetails.Controls.Add(this.labelControl1);
            this.gb_AuthDetails.Controls.Add(this.txt_Note);
            this.gb_AuthDetails.Controls.Add(this.txt_IssuAuth);
            this.gb_AuthDetails.Controls.Add(this.txt_ID);
            this.gb_AuthDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_AuthDetails.Location = new System.Drawing.Point(0, 0);
            this.gb_AuthDetails.Name = "gb_AuthDetails";
            this.gb_AuthDetails.Size = new System.Drawing.Size(585, 118);
            this.gb_AuthDetails.TabIndex = 8;
            this.gb_AuthDetails.Text = "بيانات جهات الاصدار";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(527, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "ملاحظات";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(385, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "اسم جهة اصدار";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(555, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "كود";
            // 
            // txt_Note
            // 
            this.txt_Note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Note.Enabled = false;
            this.txt_Note.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txt_Note.Location = new System.Drawing.Point(18, 73);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(503, 20);
            this.txt_Note.TabIndex = 1;
            this.txt_Note.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_IssuAuth
            // 
            this.txt_IssuAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_IssuAuth.Enabled = false;
            this.txt_IssuAuth.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txt_IssuAuth.Location = new System.Drawing.Point(18, 36);
            this.txt_IssuAuth.Name = "txt_IssuAuth";
            this.txt_IssuAuth.Size = new System.Drawing.Size(361, 20);
            this.txt_IssuAuth.TabIndex = 0;
            this.txt_IssuAuth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ID.Enabled = false;
            this.txt_ID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txt_ID.Location = new System.Drawing.Point(486, 36);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(63, 20);
            this.txt_ID.TabIndex = 7;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_Add_IssuingAuthorities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 389);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gb_IssueAuth);
            this.Controls.Add(this.gb_AuthDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_Add_IssuingAuthorities.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_IssuingAuthorities";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جهات الاصدار";
            this.Load += new System.EventHandler(this.frm_Add_IssuingAuthorities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gb_IssueAuth)).EndInit();
            this.gb_IssueAuth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_IssueAuth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IssueAuth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_AuthDetails)).EndInit();
            this.gb_AuthDetails.ResumeLayout(false);
            this.gb_AuthDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_New;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Edite;
        private DevExpress.XtraEditors.GroupControl gb_IssueAuth;
        private DevExpress.XtraGrid.GridControl grid_IssueAuth;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_IssueAuth;
        private DevExpress.XtraEditors.GroupControl gb_AuthDetails;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.TextBox txt_IssuAuth;
        private System.Windows.Forms.TextBox txt_ID;
    }
}