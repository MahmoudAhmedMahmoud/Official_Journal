namespace Official_Journal
{
    partial class frm_Search
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
            this.grid_Search = new DevExpress.XtraGrid.GridControl();
            this.dgv_Search = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Search
            // 
            this.grid_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Search.Location = new System.Drawing.Point(0, 0);
            this.grid_Search.MainView = this.dgv_Search;
            this.grid_Search.Name = "grid_Search";
            this.grid_Search.Size = new System.Drawing.Size(586, 350);
            this.grid_Search.TabIndex = 0;
            this.grid_Search.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_Search});
            // 
            // dgv_Search
            // 
            this.dgv_Search.GridControl = this.grid_Search;
            this.dgv_Search.Name = "dgv_Search";
            this.dgv_Search.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_Search.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_Search.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_Search.OptionsBehavior.AllowPartialGroups = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_Search.OptionsBehavior.Editable = false;
            this.dgv_Search.OptionsBehavior.ReadOnly = true;
            this.dgv_Search.OptionsCustomization.AllowGroup = false;
            this.dgv_Search.OptionsFind.AlwaysVisible = true;
            this.dgv_Search.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_Search.DoubleClick += new System.EventHandler(this.dgv_Search_DoubleClick);
            // 
            // frm_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 350);
            this.Controls.Add(this.grid_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Search";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بحث عن عدد جريدة";
            this.Load += new System.EventHandler(this.frm_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_Search;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_Search;
    }
}