using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace Official_Journal
{
    public partial class frm_Add_IssuingAuthorities : DevExpress.XtraEditors.XtraForm
    {
        public frm_Add_IssuingAuthorities()
        {
            InitializeComponent();
        }
        //------------------cls-------------------------
        DataAccesLayer DAC = new DataAccesLayer();
        cls_Message Msg = new cls_Message();

        //------------------func------------------------
        public void GetData()
        {
            grid_IssueAuth.DataSource = DAC.SelectQue("select Auth_ID'كود' ,Auth_Name'جهة الاصدار' ,Notes'ملاحظات' from tbl_Auth");
            dgv_IssueAuth.Columns[0].Width = 15;
        }

        int Add = 0;

        public void Clear()
        {
            txt_ID.Clear();
            txt_IssuAuth.Clear();
            txt_Note.Clear();
        }

        public void Reset()
        {
            txt_IssuAuth.Enabled = false;
            txt_Note.Enabled = false;
            grid_IssueAuth.Enabled = true;
            btn_New.Enabled = true;
            btn_Edite.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Save.Enabled = false;
            btn_Cancel.Enabled = false;
        }

        //------------------frm load--------------------
        private void frm_Add_IssuingAuthorities_Load(object sender, EventArgs e)
        {
            GetData();
        }
        //------------------buttons---------------------
        private void btn_New_Click(object sender, EventArgs e)
        {
            Clear();
            txt_IssuAuth.Enabled = true;
            txt_Note.Enabled = true;
            grid_IssueAuth.Enabled = false;
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
                if (txt_IssuAuth.Text == "" )
                {
                    Msg.NullField();
                }
                else
                {
                    DAC.ExcQue("insert into tbl_Auth([Auth_Name], [Notes])Values(N'"+txt_IssuAuth.Text+"',N'"+txt_Note.Text+"')");
                    Clear();
                    Reset();
                    GetData();
                    Msg.InsertMessage();
                }
            }
            else
            {
                if (txt_ID.Text == "" || txt_IssuAuth.Text == ""  )
                {
                    Msg.NullField();
                }
                else
                {
                    DialogResult R;
                    R = Msg.AskUpdateMessage();
                    if (R == DialogResult.Yes)
                    {
                        DAC.ExcQue("update tbl_Auth set Auth_Name=N'" + txt_IssuAuth.Text + "', Notes=N'" + txt_Note.Text + "' where Auth_ID=N'" + txt_ID.Text + "'");
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
            txt_IssuAuth.Enabled = true;
            txt_Note.Enabled = true;
            grid_IssueAuth.Enabled = false;
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
            if (dgv_IssueAuth.DataRowCount>0)
            {
                txt_ID.Text = dgv_IssueAuth.GetFocusedRowCellValue("كود").ToString();
                txt_IssuAuth.Text = dgv_IssueAuth.GetFocusedRowCellValue("جهة الاصدار").ToString();
                txt_Note.Text = dgv_IssueAuth.GetFocusedRowCellValue("ملاحظات").ToString();
                btn_Edite.Enabled = true;
                btn_Delete.Enabled = true;
            }
            return;

        }


    }
}