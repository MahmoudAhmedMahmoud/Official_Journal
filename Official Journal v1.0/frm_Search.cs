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
    public partial class frm_Search : DevExpress.XtraEditors.XtraForm
    {
        public frm_Search()
        {
            InitializeComponent();
        }
        DataAccesLayer DAC = new DataAccesLayer();
        private void frm_Search_Load(object sender, EventArgs e)
        {
            grid_Search.DataSource=DAC.SelectQue("SELECT * FROM VW_SelectAllIssues");
            dgv_Search.Columns[6].Visible=false;
            dgv_Search.Columns[7].Visible = false;
        }

        private void dgv_Search_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Search.DataRowCount > 0)
            {
                var frm = Application.OpenForms["frm_AddIssue"] as frm_AddIssue;
                frm.txt_IssueNo.Text = dgv_Search.GetFocusedRowCellValue("رقم العدد").ToString();
                frm.txt_ID.Text = dgv_Search.GetFocusedRowCellValue("رقم العدد").ToString();
                frm.Spin_Year.Text = dgv_Search.GetFocusedRowCellValue("السنة").ToString();
                frm.txt_Year.Text = dgv_Search.GetFocusedRowCellValue("السنة").ToString();
                frm.dtp_PublishDate.Text = dgv_Search.GetFocusedRowCellValue("تاريخ النشر").ToString();
                frm.dtp_SaveDate.Text = dgv_Search.GetFocusedRowCellValue("تاريخ الحفظ").ToString();
                frm.txt_Path.Text = dgv_Search.GetFocusedRowCellValue("المسار").ToString();
                frm.btn_NewIssue.Enabled = true;
                frm.btn_SaveIssue.Enabled = false;
                frm.btn_EditeIssue.Enabled = true;
                frm.btn_DeleteIssue.Enabled = true;
                frm.GetLaws();
                this.Close();
            }
            return;
        }
    }
}