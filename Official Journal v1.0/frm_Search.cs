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
        cls_Issues ISS = new cls_Issues();

        //
        public string Model;

        private void frm_Search_Load(object sender, EventArgs e)
        {
            switch (Model)
            {
                case "Issue":
                    grid_Search.DataSource = DAC.SelectQue("SELECT * FROM VW_SelectAllIssues");
                    dgv_Search.Columns[6].Visible = false;
                    dgv_Search.Columns[7].Visible = false;
                    break;
                case "Auth":
                    grid_Search.DataSource = DAC.SelectQue("select Auth_ID'كود الجهة',Auth_Name'اسم جهة الاصدار' from tbl_Auth");
                    dgv_Search.Columns[0].Width = 15;
                    break;
                case "Dep":
                    grid_Search.DataSource = DAC.SelectQue("select Dep_ID'كود الجهة',Dep_Name'اسم الجهة المعنية' from tbl_Department");
                    dgv_Search.Columns[0].Width = 15;
                    break;
            }

        }

        private void dgv_Search_DoubleClick(object sender, EventArgs e)
        {
            var frm = Application.OpenForms["frm_AddIssue"] as frm_AddIssue;
            switch (Model)
            {
                case "Issue":
                    if (dgv_Search.DataRowCount > 0)
                    {
                        frm.Spin_Year.Text = dgv_Search.GetFocusedRowCellValue("السنة").ToString();
                        frm.Spin_Year.Enabled = false;
                        frm.txt_IssueNo.Text = dgv_Search.GetFocusedRowCellValue("رقم العدد").ToString();
                        frm.txt_IssueNo.Enabled = false;
                        frm.txt_IssueID.Text = "عدد " + frm.txt_IssueNo.Text + " لسنة " + frm.Spin_Year.Text;
                        frm.txt_ID.Text = dgv_Search.GetFocusedRowCellValue("رقم العدد").ToString();
                        frm.txt_Year.Text = dgv_Search.GetFocusedRowCellValue("السنة").ToString();
                        frm.dtp_PublishDate.Text = dgv_Search.GetFocusedRowCellValue("تاريخ النشر").ToString();
                        frm.dtp_PublishDate.Enabled = false;
                        frm.dtp_SaveDate.Text = dgv_Search.GetFocusedRowCellValue("تاريخ الحفظ").ToString();
                        frm.dtp_SaveDate.Enabled = false;
                        frm.txt_Path.Text = dgv_Search.GetFocusedRowCellValue("المسار").ToString();
                        frm.btn_NewIssue.Enabled = true;
                        frm.btn_SaveIssue.Enabled = false;
                        frm.btn_EditeIssue.Enabled = true;
                        frm.btn_DeleteIssue.Enabled = true;
                        frm.btn_AddFile.Enabled = false;
                        frm.GetLaws();
                        frm.gb_Laws.Enabled = true;
                        //
                        DataTable dt = ISS.GetIssueFile(dgv_Search.GetFocusedRowCellValue("رقم العدد").ToString(), dgv_Search.GetFocusedRowCellValue("السنة").ToString());
                        frm.IssueFile = (byte[])dt.Rows[0]["الملف"];
                        //
                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                    break;
                case "Auth":
                    frm.cmb_Auth.Text = dgv_Search.GetFocusedRowCellValue("اسم جهة الاصدار").ToString();
                    this.Close();
                    break;
                case "Dep":
                    frm.cmb_Dep.Text = dgv_Search.GetFocusedRowCellValue("اسم الجهة المعنية").ToString();
                    this.Close();
                    break;
            }


        }
    }
}