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
    public partial class frm_Add_Department : DevExpress.XtraEditors.XtraForm
    {
        public frm_Add_Department()
        {
            InitializeComponent();
        }
        //------------------cls-------------------------
        DataAccesLayer DAC = new DataAccesLayer();
        cls_Message Msg = new cls_Message();

        //------------------func------------------------
        public void GetData()
        {
            grid_Dep.DataSource = DAC.SelectQue("select [Dep_ID]'كود' ,[Dep_Name]'الجهة المعنية' ,Notes'ملاحظات' from [dbo].[tbl_Department]");
            dgv_Dep.Columns[0].Width = 15;
        }

        int Add = 0;

        public void Clear()
        {
            txt_ID.Clear();
            txt_Dep.Clear();
            txt_Note.Clear();
        }

        public void Reset()
        {
            txt_Dep.Enabled = false;
            txt_Note.Enabled = false;
            grid_Dep.Enabled = true;
            btn_New.Enabled = true;
            btn_Edite.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Save.Enabled = false;
            btn_Cancel.Enabled = false;
        }

        //------------------frm load--------------------
        private void frm_Add_Department_Load(object sender, EventArgs e)
        {
            GetData();
        }
        //------------------buttons---------------------
        private void btn_New_Click(object sender, EventArgs e)
        {
            Clear();
            txt_Dep.Enabled = true;
            txt_Note.Enabled = true;
            grid_Dep.Enabled = false;
            btn_New.Enabled = false;
            btn_Edite.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Save.Enabled = true;
            btn_Cancel.Enabled = true;
            Add = 0;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Add == 0)
            {
                if (txt_Dep.Text == "" )
                {
                    Msg.NullField();
                }
                else
                {
                    DAC.ExcQue("insert into tbl_Department ([Dep_Name],[Notes])Values(N'" + txt_Dep.Text + "',N'" + txt_Note.Text + "')");
                    Clear();
                    Reset();
                    GetData();
                    Msg.InsertMessage();
                }
            }
            else
            {
                if (txt_ID.Text == "" || txt_Dep.Text == "" )
                {
                    Msg.NullField();
                }
                else
                {
                    DialogResult R;
                    R = Msg.AskUpdateMessage();
                    if (R == DialogResult.Yes)
                    {
                        DAC.ExcQue("update tbl_Department set [Dep_Name]=N'" + txt_Dep.Text + "', Notes=N'" + txt_Note.Text + "' where [Dep_ID]=N'"+txt_ID.Text+"'");
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
            txt_Dep.Enabled = true;
            txt_Note.Enabled = true;
            grid_Dep.Enabled = false;
            btn_New.Enabled = false;
            btn_Edite.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Save.Enabled = true;
            btn_Cancel.Enabled = true;
            Add = 1;
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            DialogResult R;
            R = Msg.AskDeleteMessage();
            if (R == DialogResult.Yes)
            {
                DAC.SelectQue("delete from tbl_Auth where Auth_ID=N'" + txt_ID.Text + "'");
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

        //-----------------Action-----------------------

        private void dgv_IssueAuth_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Dep.DataRowCount > 0)
            {
                txt_ID.Text = dgv_Dep.GetFocusedRowCellValue("كود").ToString();
                txt_Dep.Text = dgv_Dep.GetFocusedRowCellValue("الجهة المعنية").ToString();
                txt_Note.Text = dgv_Dep.GetFocusedRowCellValue("ملاحظات").ToString();
                btn_Edite.Enabled = true;
                btn_Delete.Enabled = true;
            }
            return;

        }
    }
}