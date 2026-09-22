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
    public partial class frm_UserHistory : DevExpress.XtraEditors.XtraForm
    {
        public frm_UserHistory()
        {
            InitializeComponent();
        }

        DataAccesLayer   DAC = new DataAccesLayer();

        private void grid_Search_Load(object sender, EventArgs e)
        {
            //
            cmb_User.DataSource = DAC.SelectQue("Select UserName from tbl_Users");
            cmb_User.DisplayMember = "UserName";
            cmb_User.SelectedIndex = -1;
            //
            cmb_Model.DataSource = DAC.SelectQue("Select Distinct [Model_Type] from [tbl_UserHistory]");
            cmb_Model.DisplayMember = "Model_Type";
            cmb_Model.SelectedIndex = -1;
            //
            grid_Search.DataSource = DAC.SelectQue("Select Top(500) * from vw_UserHistory order by [م] desc");
            dgv_Search.Columns["م"].Width = 50;
            dgv_Search.Columns["المستخدم"].Width = 100;
            dgv_Search.Columns["شاشة الحركة"].Width = 75;
            dgv_Search.Columns["وصف الحركة"].Width = 250;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT Top(500) * FROM vw_UserHistory WHERE 1=1 ");

            if (!string.IsNullOrWhiteSpace(cmb_Model.Text))
                sql.Append(" AND [شاشة الحركة]=N'" + cmb_Model.Text + "'");

            if (!string.IsNullOrWhiteSpace(cmb_User.Text))
                sql.Append(" AND [المستخدم]=N'" + cmb_User.Text + "'");

            sql.Append(" order by [م] desc");

            grid_Search.DataSource = DAC.SelectQue(sql.ToString());
        }
    }
}