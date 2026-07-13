using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Official_Journal
{
    public partial class frm_Users : DevExpress.XtraEditors.XtraForm
    {
        public frm_Users()
        {
            InitializeComponent();
        }
        //------------------------------------ CLS --------------------------------------
        DataAccesLayer DAC = new DataAccesLayer();
        cls_Message Msg = new cls_Message();
        cls_Users Users = new cls_Users();

        //---------------------------------- Functions & Variables ----------------------------------

        public void GetData()
        {
            grid_User.DataSource = Users.SelectAllUser();
            dgv_Users.Columns[2].Visible = false;
        }

        int Add = 0;

        public void Clear()
        {
            txt_ID.Clear();
            txt_UserID.Clear();
            txt_UserName.Clear();
            txt_Password.Clear();
            cmb_UserType.Text = "";

        }

        public void Reset()
        {
            txt_UserID.Enabled = false;
            txt_UserName.Enabled = false;
            txt_Password.Enabled = false;
            cmb_UserType.Enabled = false;
            grid_User.Enabled = true;
            btn_New.Enabled = true;
            btn_Edite.Enabled = false;
            btn_Del.Enabled = false;
            btn_Save.Enabled = false;
            btn_Cancel.Enabled = false;
            btn_HidePass.Enabled = false;
            btn_ShowPass.Enabled = false;
        }

        //---------------------------------- Form Load ----------------------------------
        private void frm_Users_Load(object sender, EventArgs e)
        {
            Reset();
            GetData();
            dgv_Users.Columns[0].Width = 100;
            dgv_Users.Columns[1].Width = 250;

            cmb_UserType.DataSource = DAC.SelectQue("SELECT [UserType] FROM [tbl_UserType] where [UserType] <> 'Super Admin'");
            cmb_UserType.DisplayMember = "UserType";
            cmb_UserType.Text = "";


        }

        //------------------------------------ Btns -------------------------------------

        private void btn_New_Click(object sender, EventArgs e)
        {
            Clear();
            txt_UserID.Enabled = true;
            txt_UserName.Enabled = true;
            txt_Password.Enabled = true;
            cmb_UserType.Enabled = true;
            grid_User.Enabled = false;
            btn_New.Enabled = false;
            btn_Edite.Enabled = false;
            btn_Del.Enabled = false;
            btn_Save.Enabled = true;
            btn_Cancel.Enabled = true;
            btn_HidePass.Enabled = true;
            btn_ShowPass.Enabled = true;
            Add = 0;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Add == 0)
            {
                if (txt_UserID.Text == "" || txt_UserName.Text == "" || txt_Password.Text == "" || cmb_UserType.Text == "")
                {
                    Msg.NullField();
                }
                else
                {
                    Users.AddUser(txt_UserID.Text, txt_UserName.Text, txt_Password.Text, cmb_UserType.Text);
                    Clear();
                    Reset();
                    GetData();
                    Msg.InsertMessage();
                }
            }
            else
            {
                if (txt_UserID.Text == "" || txt_UserName.Text == "" || txt_Password.Text == "" || cmb_UserType.Text == "")
                {
                    Msg.NullField();
                }
                else
                {
                    DialogResult R;
                    R = Msg.AskUpdateMessage();
                    if (R == DialogResult.Yes)
                    {
                        Users.UpdUser(txt_ID.Text, txt_UserID.Text, txt_UserName.Text, txt_Password.Text, cmb_UserType.Text);
                        Clear();
                        Reset();
                        GetData();
                        Msg.Updatemessage();
                    }
                }
            }
        }

        private void btn_Edite_Click(object sender, EventArgs e)
        {
            txt_UserID.Enabled = true;
            txt_UserName.Enabled = true;
            txt_Password.Enabled = true;
            cmb_UserType.Enabled = true;
            grid_User.Enabled = false;
            btn_New.Enabled = false;
            btn_Edite.Enabled = false;
            btn_Del.Enabled = false;
            btn_Save.Enabled = true;
            btn_Cancel.Enabled = true;
            btn_HidePass.Enabled = true;
            btn_ShowPass.Enabled = true;
            Add = 1;
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            DialogResult R;
            R = Msg.AskDeleteMessage();
            if (R == DialogResult.Yes)
            {
                Users.DelUser(txt_UserID.Text);
                Clear();
                Reset();
                GetData();
                Msg.DeleteMessage();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Clear();
            Reset();
        }

        private void btn_HidePass_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = true;
            btn_HidePass.SendToBack();
        }

        private void btn_ShowPass_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = false;
            btn_ShowPass.SendToBack();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void txt_Search_TextChanged(object sender, EventArgs e)
        //{
        //    grid_User.DataSource = Users.SearchUser(txt_Search.Text);
        //}

        //-------------------------------- Actions ---------------------------------------
        //private void dgv_Users_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    txt_ID.Text = dgv_Users.GetFocusedRowCellValue("كود المستخدم").ToString();
        //    txt_UserID.Text = dgv_Users.GetFocusedRowCellValue("كود المستخدم").ToString();
        //    txt_UserName.Text = dgv_Users.GetFocusedRowCellValue("اسم المستخدم").ToString();
        //    txt_Password.Text = dgv_Users.GetFocusedRowCellValue("كلمة المرور").ToString();
        //    cmb_UserType.Text = dgv_Users.GetFocusedRowCellValue("نوع المستخدم").ToString();
        //    btn_Edite.Enabled = true;
        //    btn_Del.Enabled = true;
        //    btn_HidePass.Enabled = true;
        //    btn_ShowPass.Enabled = true;
        //}

        private void dgv_Users_DoubleClick(object sender, EventArgs e)
        {
            txt_ID.Text = dgv_Users.GetFocusedRowCellValue("كود المستخدم").ToString();
            txt_UserID.Text = dgv_Users.GetFocusedRowCellValue("كود المستخدم").ToString();
            txt_UserName.Text = dgv_Users.GetFocusedRowCellValue("اسم المستخدم").ToString();
            txt_Password.Text = dgv_Users.GetFocusedRowCellValue("كلمة المرور").ToString();
            cmb_UserType.Text = dgv_Users.GetFocusedRowCellValue("نوع المستخدم").ToString();
            btn_Edite.Enabled = true;
            btn_Del.Enabled = true;
            btn_HidePass.Enabled = true;
            btn_ShowPass.Enabled = true;
        }
    }
}
