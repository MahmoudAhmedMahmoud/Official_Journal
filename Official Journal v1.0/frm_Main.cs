using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace Official_Journal
{
    public partial class frm_Main : DevExpress.XtraEditors.XtraForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        //------------------------- Cls ----------------------------------
        DataAccesLayer DAC = new DataAccesLayer();
        cls_Users Users = new cls_Users();
        cls_Message MSG = new cls_Message();
        //----------------------------Function-------------------------------
        public void UserRules()
        {
            string UserType = Properties.Settings.Default.UserType;
            switch (UserType)
                {
                case "Admin":
                    btn_frmUser.Visibility = BarItemVisibility.Never;
                    break;
                case "Super Admin":
                    btn_frmUser.Enabled = true;
                    break;
                case "User":
                    //btn_frmUser.Enabled = false;
                    break;
                }
       }

        //------------------------- Btns ----------------------------

        private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Users.UserLogActivity("LOGIN","تسجيل خروج", Properties.Settings.Default.UserID, "تسجيل خروج","0");
            Application.Exit();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserType == "Admin" || Properties.Settings.Default.UserType == "Super Admin")
            {
                btn_frmUser.Enabled = true;
            }
            else
            {
                btn_frmUser.Enabled = false;
            }
            StaticItem_User.Caption = Properties.Settings.Default.UserName;
        }

        private void btn_frmUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            var Open_frm = Application.OpenForms["frm_Users"] as frm_Users;
            if (Open_frm == null)
            {
                frm_Users frm = new frm_Users();
               // frm.MdiParent = this;
                frm.BringToFront();
                frm.ShowDialog();
            }
            else
            {
                frm_Users frm = new frm_Users();
                frm.BringToFront();
            }
        }

        private void btn_frmDepartment_ItemClick(object sender, ItemClickEventArgs e)
        {
            var Open_frm = Application.OpenForms["frm_Add_Department"] as frm_Add_Department;
            if (Open_frm == null)
            {
                frm_Add_Department frm = new frm_Add_Department();
                //frm.MdiParent = this;
                frm.ShowDialog();
                
            }
            else
            {
                frm_Add_Department frm = new frm_Add_Department();
                frm.BringToFront();
            }
        }

        private void btn_frmIssuingAuth_ItemClick(object sender, ItemClickEventArgs e)
        {
            var Open_frm = Application.OpenForms["frm_Add_IssuingAuthorities"] as frm_Add_IssuingAuthorities;
            if (Open_frm == null)
            {
                frm_Add_IssuingAuthorities frm = new frm_Add_IssuingAuthorities();
               // frm.MdiParent = this;
                frm.ShowDialog();
            }
            else
            {
                frm_Add_IssuingAuthorities frm = new frm_Add_IssuingAuthorities();
                frm.BringToFront();
            }
        }

        private void btn_frmAddIssue_ItemClick(object sender, ItemClickEventArgs e)
        {
            var Open_frm = Application.OpenForms["frm_AddIssue"] as frm_AddIssue;
            if (Open_frm == null)
            {
                frm_AddIssue frm = new frm_AddIssue();
                //frm.MdiParent = this;
                frm.ShowDialog();
            }
            else
            {
                frm_AddIssue frm = new frm_AddIssue();
                frm.BringToFront();
            }
        }

    }
}