namespace Official_Journal
{
    partial class frm_UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UserLogin));
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_UserType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_DataBase = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Login = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txt_Pass
            // 
            this.txt_Pass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.Location = new System.Drawing.Point(30, 176);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(452, 26);
            this.txt_Pass.TabIndex = 2;
            this.txt_Pass.UseSystemPasswordChar = true;
            this.txt_Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Pass_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(115, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(26, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "كلمة المرور";
            // 
            // txt_UserID
            // 
            this.txt_UserID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserID.Location = new System.Drawing.Point(24, 115);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(89, 26);
            this.txt_UserID.TabIndex = 0;
            this.txt_UserID.TextChanged += new System.EventHandler(this.txt_UserID_TextChanged);
            this.txt_UserID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_UserID_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(20, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "كود المستخدم";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Enabled = false;
            this.txt_UserName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(119, 115);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(363, 26);
            this.txt_UserName.TabIndex = 5;
            // 
            // lbl_UserType
            // 
            this.lbl_UserType.AutoSize = true;
            this.lbl_UserType.Location = new System.Drawing.Point(410, 144);
            this.lbl_UserType.Name = "lbl_UserType";
            this.lbl_UserType.Size = new System.Drawing.Size(19, 13);
            this.lbl_UserType.TabIndex = 8;
            this.lbl_UserType.Text = "...";
            this.lbl_UserType.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 15);
            this.panel1.TabIndex = 9;
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(473, 19);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(24, 23);
            this.btn_Close.TabIndex = 10;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(187, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "تسجيل الدخول";
            // 
            // btn_DataBase
            // 
            this.btn_DataBase.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DataBase.ImageOptions.Image")));
            this.btn_DataBase.Location = new System.Drawing.Point(473, 251);
            this.btn_DataBase.Name = "btn_DataBase";
            this.btn_DataBase.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_DataBase.Size = new System.Drawing.Size(24, 26);
            this.btn_DataBase.TabIndex = 11;
            this.btn_DataBase.Click += new System.EventHandler(this.btn_DataBase_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Login.Appearance.Options.UseFont = true;
            this.btn_Login.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Login.ImageOptions.Image")));
            this.btn_Login.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_Login.Location = new System.Drawing.Point(204, 224);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Login.Size = new System.Drawing.Size(94, 29);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "دخول";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // frm_UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(502, 277);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_DataBase);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_UserType);
            this.Controls.Add(this.txt_UserID);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_UserLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_UserType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_DataBase;
        private DevExpress.XtraEditors.SimpleButton btn_Login;
    }
}