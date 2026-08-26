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
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace Official_Journal
{
    public partial class frm_SearchAll : DevExpress.XtraEditors.XtraForm
    {
        public frm_SearchAll()
        {
            InitializeComponent();
        }
        //--------------------- cls -------------------------
        DataAccesLayer DAC = new DataAccesLayer();

        //------------------------- Load ----------------
        private void frm_SearchAll_Load(object sender, EventArgs e)
        {
            //
            cmb_Auth.DataSource = DAC.SelectQue("select Auth_ID,Auth_Name from tbl_Auth");
            cmb_Auth.DisplayMember = "Auth_Name";
            cmb_Auth.ValueMember = "Auth_ID";
            cmb_Auth.SelectedIndex = -1;
            //
            cmb_Dep.DataSource = DAC.SelectQue("select Dep_ID,Dep_Name from tbl_Department");
            cmb_Dep.DisplayMember = "Dep_Name";
            cmb_Dep.ValueMember = "Dep_ID";
            cmb_Dep.SelectedIndex = -1;
            //
        }
        //------------------------- fun --------------------

        private void Search()  // محتاج فيو خاص 
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT * FROM VW_Dep_Pub_Law WHERE [Issue_DebPubStatus]=1 ");

            if (!string.IsNullOrWhiteSpace(txt_IssueNo.Text))
                sql.Append(" AND [رقم العدد] LIKE N'%" + txt_IssueNo.Text + "%'");

            if (!string.IsNullOrWhiteSpace(txt_LawNo.Text))
                sql.Append(" AND [رقم القانون] LIKE N'%" + txt_LawNo.Text + "%'");

            if (spin_Year.Value > 0)
                sql.Append(" AND [سنة العدد]=" + spin_Year.Value);

            if (dtp_PubDate.Checked)
                sql.Append(" AND CAST([تاريخ النشر] AS DATE)=CAST('" +
                           dtp_PubDate.Value.ToString("yyyy-MM-dd") + "' AS DATE)");

            if (dtp_SaveDate.Checked)
                sql.Append(" AND CAST([تاريخ الحفظ] AS DATE)=CAST('" +
                           dtp_SaveDate.Value.ToString("yyyy-MM-dd") + "' AS DATE)");

            if (cmb_.Text != null)
                sql.Append(" AND [الجهة المصدرة]=N'" + cmb_.Text + "'");

            if (cmb_Dep.Text != null)
                sql.Append(" AND [الجهة المعنية]=N'" + cmb_Dep.Text + "'");

            if (cmb_Auth.Text != null)
                sql.Append(" AND [مطابقة القرار]=N'" + cmb_Auth.Text + "'");

            grid_Search.DataSource = DAC.SelectQue(sql.ToString());
        }

        //------------------------- btn ---------------------
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }


    }
}