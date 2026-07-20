using DevExpress.ClipboardSource.SpreadsheetML;
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
    public partial class frm_Publish : DevExpress.XtraEditors.XtraForm
    {
        public frm_Publish()
        {
            InitializeComponent();
        }

        //-----------------------cls-------------------------
        DataAccesLayer DAC = new DataAccesLayer();
        cls_Message MSG = new cls_Message();

        //-------------------fun------------------------------
        public void GetPub()
        {
            grid_Pub.DataSource= DAC.SelectQue("SELECT * FROM VW_IssuePub WHERE [حالة التوزيع] = 1");
            dgv_Pub.Columns[5].Visible = false;
            dgv_Pub.RefreshData();
        }

        public void GetNotPub()
        {
           grid_NotPub.DataSource= DAC.SelectQue("SELECT * FROM VW_IssuePub WHERE [حالة التوزيع] = 0");
            dgv_NotPub.Columns[5].Visible = false;
            dgv_NotPub.Columns[6].Visible = false;
            dgv_NotPub.RefreshData();
        }


        //------------------- Load ---------------------------
        private void frm_Publish_Load(object sender, EventArgs e)
        {
            GetPub();
            GetNotPub();
        }
        //-------------------------------------------------------
        private void page_Pub_Click(object sender, EventArgs e)
        {
            GetPub();
        }

        private void page_NotPub_Click(object sender, EventArgs e)
        {
            GetNotPub();
        }

        private void btn_NotPub_Click(object sender, EventArgs e)
        {
            if (dgv_Pub.GetSelectedRows().Length>=0)
            {
                foreach (int R in dgv_Pub.GetSelectedRows())
                {
                    DAC.ExcQue("UPDATE tbl_Issues SET [Issue_DebPubStatus]='0',Issue_DebPubDate= Getdate() where Issue_ID=N'" + dgv_Pub.GetRowCellValue(R, "كود العدد").ToString() + "'");
                }
                GetPub();
                MessageBox.Show("تم إلغاء نشر العدد بنجاح");
            }
            else
            {
                MSG.Exception("لم يتم تحديد أي عدد لإلغاء نشره");
            }

        }

        private void btn_Pub_Click(object sender, EventArgs e)
        {
            if (dgv_NotPub.GetSelectedRows().Length>=0)
            {
                foreach (int R in dgv_NotPub.GetSelectedRows())
                {
                    DAC.ExcQue("UPDATE tbl_Issues SET [Issue_DebPubStatus]='1',Issue_DebPubDate= Getdate() where Issue_ID= N'" + dgv_NotPub.GetRowCellValue(R, "كود العدد").ToString() + "'");
                }
                GetNotPub();
                MessageBox.Show("تم نشرالاعداد بنجاح");
            }
            else
            {
                MSG.Exception("لم يتم تحديد أي عدد لنشره");
            }

        }


        //-------------------------------------------------------
    }
}