namespace Official_Journal
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_frmUser = new DevExpress.XtraBars.BarButtonItem();
            this.btn_frmDepartment = new DevExpress.XtraBars.BarButtonItem();
            this.btn_frmIssuingAuth = new DevExpress.XtraBars.BarButtonItem();
            this.btn_frmAddIssue = new DevExpress.XtraBars.BarButtonItem();
            this.btn_frmPub = new DevExpress.XtraBars.BarButtonItem();
            this.btn = new DevExpress.XtraBars.BarButtonItem();
            this.StaticItem_User = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_frmSearch = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_frmUser,
            this.btn_frmDepartment,
            this.btn_frmIssuingAuth,
            this.btn_frmAddIssue,
            this.btn_frmPub,
            this.btn,
            this.StaticItem_User,
            this.btn_frmSearch});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.StaticItem_User);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(1177, 140);
            // 
            // btn_frmUser
            // 
            this.btn_frmUser.Caption = "بيانات المستخدمين";
            this.btn_frmUser.Id = 1;
            this.btn_frmUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_frmUser.ImageOptions.Image")));
            this.btn_frmUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_frmUser.ImageOptions.LargeImage")));
            this.btn_frmUser.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btn_frmUser.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_frmUser.Name = "btn_frmUser";
            this.btn_frmUser.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_frmUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_frmUser_ItemClick);
            // 
            // btn_frmDepartment
            // 
            this.btn_frmDepartment.Caption = "الجهات المعنية";
            this.btn_frmDepartment.Id = 2;
            this.btn_frmDepartment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_frmDepartment.ImageOptions.Image")));
            this.btn_frmDepartment.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_frmDepartment.ImageOptions.LargeImage")));
            this.btn_frmDepartment.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btn_frmDepartment.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_frmDepartment.Name = "btn_frmDepartment";
            this.btn_frmDepartment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_frmDepartment_ItemClick);
            // 
            // btn_frmIssuingAuth
            // 
            this.btn_frmIssuingAuth.Caption = "جهة الاصدار";
            this.btn_frmIssuingAuth.Id = 3;
            this.btn_frmIssuingAuth.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_frmIssuingAuth.ImageOptions.Image")));
            this.btn_frmIssuingAuth.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_frmIssuingAuth.ImageOptions.LargeImage")));
            this.btn_frmIssuingAuth.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btn_frmIssuingAuth.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_frmIssuingAuth.Name = "btn_frmIssuingAuth";
            this.btn_frmIssuingAuth.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_frmIssuingAuth_ItemClick);
            // 
            // btn_frmAddIssue
            // 
            this.btn_frmAddIssue.Caption = "تسجيل عدد جريدة";
            this.btn_frmAddIssue.Id = 4;
            this.btn_frmAddIssue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_frmAddIssue.ImageOptions.Image")));
            this.btn_frmAddIssue.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_frmAddIssue.ImageOptions.LargeImage")));
            this.btn_frmAddIssue.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btn_frmAddIssue.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_frmAddIssue.ItemInMenuAppearance.Normal.Options.UseTextOptions = true;
            this.btn_frmAddIssue.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btn_frmAddIssue.Name = "btn_frmAddIssue";
            this.btn_frmAddIssue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_frmAddIssue_ItemClick);
            // 
            // btn_frmPub
            // 
            this.btn_frmPub.Caption = "نشر الاعداد";
            this.btn_frmPub.Id = 5;
            this.btn_frmPub.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_frmPub.ImageOptions.Image")));
            this.btn_frmPub.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_frmPub.ImageOptions.LargeImage")));
            this.btn_frmPub.Name = "btn_frmPub";
            this.btn_frmPub.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_frmPub_ItemClick);
            // 
            // btn
            // 
            this.btn.Caption = "حركة المستخدمين";
            this.btn.Id = 6;
            this.btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.btn.Name = "btn";
            // 
            // StaticItem_User
            // 
            this.StaticItem_User.Caption = ".";
            this.StaticItem_User.Id = 7;
            this.StaticItem_User.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("StaticItem_User.ImageOptions.Image")));
            this.StaticItem_User.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("StaticItem_User.ImageOptions.LargeImage")));
            this.StaticItem_User.Name = "StaticItem_User";
            this.StaticItem_User.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "تسجيل البيانات الاساسية";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_frmUser);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "المستخدمين";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_frmDepartment);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_frmIssuingAuth);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "الجهات";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "تسجيل العمليات";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_frmAddIssue);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_frmPub);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "التقارير";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_frmSearch);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Official_Journal.Properties.Resources.Official_Journal;
            this.pictureBox1.Location = new System.Drawing.Point(0, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1177, 527);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_frmSearch
            // 
            this.btn_frmSearch.Caption = "البحث";
            this.btn_frmSearch.Id = 8;
            this.btn_frmSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btn_frmSearch.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btn_frmSearch.Name = "btn_frmSearch";
            this.btn_frmSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_frmSearch_ItemClick);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 667);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_Main.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة متابعة استدامة الخطة - جريدة الوقائع المصرية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Main_FormClosed);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btn_frmUser;
        private DevExpress.XtraBars.BarButtonItem btn_frmDepartment;
        private DevExpress.XtraBars.BarButtonItem btn_frmIssuingAuth;
        private DevExpress.XtraBars.BarButtonItem btn_frmAddIssue;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btn_frmPub;
        private DevExpress.XtraBars.BarButtonItem btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.BarStaticItem StaticItem_User;
        private DevExpress.XtraBars.BarButtonItem btn_frmSearch;
    }
}