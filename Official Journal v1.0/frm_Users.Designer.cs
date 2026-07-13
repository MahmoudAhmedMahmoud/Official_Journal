namespace Official_Journal
{
    partial class frm_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Users));
            this.gb_AddFile = new DevExpress.XtraEditors.GroupControl();
            this.btn_ShowPass = new DevExpress.XtraEditors.SimpleButton();
            this.btn_HidePass = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_UserType = new System.Windows.Forms.ComboBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edite = new DevExpress.XtraEditors.SimpleButton();
            this.grid_User = new DevExpress.XtraGrid.GridControl();
            this.dgv_Users = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gb_AddFile)).BeginInit();
            this.gb_AddFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_AddFile
            // 
            this.gb_AddFile.Controls.Add(this.btn_ShowPass);
            this.gb_AddFile.Controls.Add(this.btn_HidePass);
            this.gb_AddFile.Controls.Add(this.cmb_UserType);
            this.gb_AddFile.Controls.Add(this.txt_UserName);
            this.gb_AddFile.Controls.Add(this.txt_ID);
            this.gb_AddFile.Controls.Add(this.txt_Password);
            this.gb_AddFile.Controls.Add(this.txt_UserID);
            this.gb_AddFile.Controls.Add(this.label3);
            this.gb_AddFile.Controls.Add(this.label4);
            this.gb_AddFile.Controls.Add(this.label2);
            this.gb_AddFile.Controls.Add(this.label1);
            this.gb_AddFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_AddFile.Location = new System.Drawing.Point(0, 0);
            this.gb_AddFile.Name = "gb_AddFile";
            this.gb_AddFile.Size = new System.Drawing.Size(767, 145);
            this.gb_AddFile.TabIndex = 0;
            this.gb_AddFile.Text = "بيانات المستخدم";
            // 
            // btn_ShowPass
            // 
            this.btn_ShowPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ShowPass.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ShowPass.ImageOptions.Image")));
            this.btn_ShowPass.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_ShowPass.Location = new System.Drawing.Point(587, 104);
            this.btn_ShowPass.Name = "btn_ShowPass";
            this.btn_ShowPass.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_ShowPass.Size = new System.Drawing.Size(28, 23);
            this.btn_ShowPass.TabIndex = 15;
            this.btn_ShowPass.Click += new System.EventHandler(this.btn_ShowPass_Click);
            // 
            // btn_HidePass
            // 
            this.btn_HidePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_HidePass.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_HidePass.ImageOptions.Image")));
            this.btn_HidePass.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_HidePass.Location = new System.Drawing.Point(586, 104);
            this.btn_HidePass.Name = "btn_HidePass";
            this.btn_HidePass.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_HidePass.Size = new System.Drawing.Size(28, 23);
            this.btn_HidePass.TabIndex = 16;
            this.btn_HidePass.Click += new System.EventHandler(this.btn_HidePass_Click);
            // 
            // cmb_UserType
            // 
            this.cmb_UserType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_UserType.Enabled = false;
            this.cmb_UserType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_UserType.FormattingEnabled = true;
            this.cmb_UserType.Location = new System.Drawing.Point(434, 103);
            this.cmb_UserType.Name = "cmb_UserType";
            this.cmb_UserType.Size = new System.Drawing.Size(136, 24);
            this.cmb_UserType.TabIndex = 14;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UserName.Enabled = false;
            this.txt_UserName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_UserName.Location = new System.Drawing.Point(145, 55);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(469, 23);
            this.txt_UserName.TabIndex = 11;
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ID.Location = new System.Drawing.Point(7, 29);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(64, 23);
            this.txt_ID.TabIndex = 12;
            this.txt_ID.Visible = false;
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Password.Enabled = false;
            this.txt_Password.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Password.Location = new System.Drawing.Point(620, 104);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(137, 23);
            this.txt_Password.TabIndex = 13;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_UserID
            // 
            this.txt_UserID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UserID.Enabled = false;
            this.txt_UserID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_UserID.Location = new System.Drawing.Point(620, 55);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(137, 23);
            this.txt_UserID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(688, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "كلمة المرور";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(493, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "نوع المستخدم";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(537, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "اسم المستخدم";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(682, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "كود المستخدم";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grid_User);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 145);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(767, 287);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "المستخدمين";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Cancel);
            this.groupBox2.Controls.Add(this.btn_Del);
            this.groupBox2.Controls.Add(this.btn_New);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.btn_Edite);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 41);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(216, 12);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(60, 23);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "الغاء";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Del.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Del.Appearance.Options.UseFont = true;
            this.btn_Del.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Del.ImageOptions.Image")));
            this.btn_Del.Location = new System.Drawing.Point(282, 12);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(60, 23);
            this.btn_Del.TabIndex = 10;
            this.btn_Del.Text = "حذف";
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_New.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.ImageOptions.Image")));
            this.btn_New.Location = new System.Drawing.Point(480, 12);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(60, 23);
            this.btn_New.TabIndex = 11;
            this.btn_New.Text = "جديد";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(414, 12);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(60, 23);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edite
            // 
            this.btn_Edite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edite.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Edite.Appearance.Options.UseFont = true;
            this.btn_Edite.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edite.ImageOptions.Image")));
            this.btn_Edite.Location = new System.Drawing.Point(348, 12);
            this.btn_Edite.Name = "btn_Edite";
            this.btn_Edite.Size = new System.Drawing.Size(60, 23);
            this.btn_Edite.TabIndex = 13;
            this.btn_Edite.Text = "تعديل";
            this.btn_Edite.Click += new System.EventHandler(this.btn_Edite_Click);
            // 
            // grid_User
            // 
            this.grid_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_User.Location = new System.Drawing.Point(2, 22);
            this.grid_User.MainView = this.dgv_Users;
            this.grid_User.Name = "grid_User";
            this.grid_User.Size = new System.Drawing.Size(763, 263);
            this.grid_User.TabIndex = 0;
            this.grid_User.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_Users});
            // 
            // dgv_Users
            // 
            this.dgv_Users.GridControl = this.grid_User;
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_Users.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_Users.OptionsBehavior.Editable = false;
            this.dgv_Users.OptionsLayout.Columns.AddNewColumns = false;
            this.dgv_Users.OptionsLayout.Columns.RemoveOldColumns = false;
            this.dgv_Users.OptionsLayout.StoreDataSettings = false;
            this.dgv_Users.DoubleClick += new System.EventHandler(this.dgv_Users_DoubleClick);
            // 
            // frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gb_AddFile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Users";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المستخدمين";
            this.Load += new System.EventHandler(this.frm_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gb_AddFile)).EndInit();
            this.gb_AddFile.ResumeLayout(false);
            this.gb_AddFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gb_AddFile;
        private DevExpress.XtraEditors.SimpleButton btn_ShowPass;
        private DevExpress.XtraEditors.SimpleButton btn_HidePass;
        private System.Windows.Forms.ComboBox cmb_UserType;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Del;
        private DevExpress.XtraEditors.SimpleButton btn_New;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Edite;
        private DevExpress.XtraGrid.GridControl grid_User;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_Users;
    }
}