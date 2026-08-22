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
        private readonly frm_AddIssue _issueForm;

        public frm_Search(frm_AddIssue issueForm)
        {
            InitializeComponent();
            _issueForm = issueForm;
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
            if (dgv_Search.FocusedRowHandle < 0 || _issueForm == null)
                return;

            object issueNoValue = dgv_Search.GetFocusedRowCellValue("رقم العدد");
            object yearValue = dgv_Search.GetFocusedRowCellValue("السنة");

            if (issueNoValue == null || yearValue == null ||
                issueNoValue == DBNull.Value || yearValue == DBNull.Value)
                return;

            string issueNo = issueNoValue.ToString();
            string year = yearValue.ToString();

            // نضبط السنة ورقم العدد أولاً، ثم نبني IssueID بشكل صريح
            _issueForm.Spin_Year.Text = year;
            _issueForm.txt_IssueNo.Text = issueNo;
            _issueForm.txt_Year.Text = year;
            _issueForm.txt_IssueID.Text = $"عدد {issueNo} لسنة {year}";
            _issueForm.txt_ID.Text = issueNo;

            _issueForm.dtp_PublishDate.Text =
                Convert.ToString(dgv_Search.GetFocusedRowCellValue("تاريخ النشر"));
            _issueForm.dtp_SaveDate.Text =
                Convert.ToString(dgv_Search.GetFocusedRowCellValue("تاريخ الحفظ"));
            _issueForm.txt_Path.Text =
                Convert.ToString(dgv_Search.GetFocusedRowCellValue("المسار"));

            _issueForm.SetExistingIssueFromSearch();
            _issueForm.GetLaws();

            Close();
        }
    }
}