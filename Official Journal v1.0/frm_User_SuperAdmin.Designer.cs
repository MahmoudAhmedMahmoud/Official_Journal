namespace Official_Journal
{
    partial class frm_User_SuperAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_User_SuperAdmin));
            this.pnl_Head = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.gb_AddFile = new System.Windows.Forms.GroupBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edite = new DevExpress.XtraEditors.SimpleButton();
            this.pnl_Head.SuspendLayout();
            this.gb_AddFile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Head
            // 
            this.pnl_Head.BackColor = System.Drawing.Color.LightGray;
            this.pnl_Head.Controls.Add(this.btn_Close);
            this.pnl_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Head.Location = new System.Drawing.Point(0, 0);
            this.pnl_Head.Name = "pnl_Head";
            this.pnl_Head.Size = new System.Drawing.Size(800, 25);
            this.pnl_Head.TabIndex = 8;
            this.pnl_Head.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Head_MouseDown);
            this.pnl_Head.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Head_MouseMove);
            this.pnl_Head.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Head_MouseUp);
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(3, 1);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(24, 23);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
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
            this.gb_AddFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_AddFile.Location = new System.Drawing.Point(12, 31);
            this.gb_AddFile.Name = "gb_AddFile";
            this.gb_AddFile.Size = new System.Drawing.Size(776, 145);
            this.gb_AddFile.TabIndex = 9;
            this.gb_AddFile.TabStop = false;
            this.gb_AddFile.Text = "بيانات المستخدم";
            // 
            // btn_ShowPass
            // 
            this.btn_ShowPass.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ShowPass.ImageOptions.Image")));
            this.btn_ShowPass.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_ShowPass.Location = new System.Drawing.Point(586, 95);
            this.btn_ShowPass.Name = "btn_ShowPass";
            this.btn_ShowPass.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_ShowPass.Size = new System.Drawing.Size(28, 23);
            this.btn_ShowPass.TabIndex = 5;
            this.btn_ShowPass.Click += new System.EventHandler(this.btn_ShowPass_Click);
            // 
            // btn_HidePass
            // 
            this.btn_HidePass.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_HidePass.ImageOptions.Image")));
            this.btn_HidePass.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_HidePass.Location = new System.Drawing.Point(585, 95);
            this.btn_HidePass.Name = "btn_HidePass";
            this.btn_HidePass.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_HidePass.Size = new System.Drawing.Size(28, 23);
            this.btn_HidePass.TabIndex = 5;
            this.btn_HidePass.Click += new System.EventHandler(this.btn_HidePass_Click);
            // 
            // cmb_UserType
            // 
            this.cmb_UserType.Enabled = false;
            this.cmb_UserType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_UserType.FormattingEnabled = true;
            this.cmb_UserType.Location = new System.Drawing.Point(433, 94);
            this.cmb_UserType.Name = "cmb_UserType";
            this.cmb_UserType.Size = new System.Drawing.Size(136, 24);
            this.cmb_UserType.TabIndex = 3;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Enabled = false;
            this.txt_UserName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_UserName.Location = new System.Drawing.Point(144, 46);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(469, 23);
            this.txt_UserName.TabIndex = 1;
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ID.Location = new System.Drawing.Point(6, 20);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(64, 23);
            this.txt_ID.TabIndex = 1;
            this.txt_ID.Visible = false;
            // 
            // txt_Password
            // 
            this.txt_Password.Enabled = false;
            this.txt_Password.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Password.Location = new System.Drawing.Point(619, 95);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(137, 23);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_UserID
            // 
            this.txt_UserID.Enabled = false;
            this.txt_UserID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_UserID.Location = new System.Drawing.Point(619, 46);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(137, 23);
            this.txt_UserID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(687, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "كلمة المرور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(492, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "نوع المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(536, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "اسم المستخدم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(681, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "كود المستخدم";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Search);
            this.groupBox1.Controls.Add(this.dgv_Users);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 287);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المستخدمين";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(739, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "بحث";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(6, 25);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(727, 26);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // dgv_Users
            // 
            this.dgv_Users.AllowUserToAddRows = false;
            this.dgv_Users.AllowUserToDeleteRows = false;
            this.dgv_Users.AllowUserToResizeRows = false;
            this.dgv_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Users.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Users.Location = new System.Drawing.Point(6, 57);
            this.dgv_Users.MultiSelect = false;
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.ReadOnly = true;
            this.dgv_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Users.Size = new System.Drawing.Size(764, 224);
            this.dgv_Users.TabIndex = 0;
            this.dgv_Users.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Users_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Cancel);
            this.groupBox2.Controls.Add(this.btn_Del);
            this.groupBox2.Controls.Add(this.btn_New);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.btn_Edite);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 474);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 41);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(225, 12);
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
            this.btn_Del.Location = new System.Drawing.Point(291, 12);
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
            this.btn_New.Location = new System.Drawing.Point(489, 12);
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
            this.btn_Save.Location = new System.Drawing.Point(423, 12);
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
            this.btn_Edite.Location = new System.Drawing.Point(357, 12);
            this.btn_Edite.Name = "btn_Edite";
            this.btn_Edite.Size = new System.Drawing.Size(60, 23);
            this.btn_Edite.TabIndex = 13;
            this.btn_Edite.Text = "تعديل";
            this.btn_Edite.Click += new System.EventHandler(this.btn_Edite_Click);
            // 
            // frm_User_SuperAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_AddFile);
            this.Controls.Add(this.pnl_Head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_User_SuperAdmin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_User_SuperAdmin";
            this.Load += new System.EventHandler(this.frm_User_SuperAdmin_Load);
            this.pnl_Head.ResumeLayout(false);
            this.gb_AddFile.ResumeLayout(false);
            this.gb_AddFile.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Head;    
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.GroupBox gb_AddFile;
        private System.Windows.Forms.ComboBox cmb_UserType;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Users;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btn_ShowPass;
        private DevExpress.XtraEditors.SimpleButton btn_HidePass;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Del;
        private DevExpress.XtraEditors.SimpleButton btn_New;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Edite;
    }
}