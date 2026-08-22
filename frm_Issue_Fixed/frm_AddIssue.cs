using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Export.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Official_Journal
{
    public partial class frm_AddIssue : DevExpress.XtraEditors.XtraForm
    {
        public frm_AddIssue()
        {
            InitializeComponent();
        }
        //------------------------Cls-----------------------
        DataAccesLayer DAC = new DataAccesLayer();
        cls_Message MSG = new cls_Message();
        cls_Issues ISS = new cls_Issues();
        //----------------------Func-----------------------
        int Add_UPd = 0;     //Add=0 , Upd=1
        int Law_Add_Upd = 0;

        byte[] IssueFile;
        private bool _isExistingIssue = false;
        private bool _loadingLaw = false;

        private void UpdateIssueID()
        {
            txt_IssueID.Text = $"عدد {txt_IssueNo.Text} لسنة {Spin_Year.Text}";
        }

        private void SetIssueMode(bool existingIssue)
        {
            _isExistingIssue = existingIssue;

            if (existingIssue)
            {
                txt_IssueNo.Enabled = false;
                txt_IssueID.Enabled = false;
                Spin_Year.Enabled = false;
                dtp_PublishDate.Enabled = false;
                dtp_SaveDate.Enabled = false;
                txt_Path.Enabled = false;

                btn_NewIssue.Enabled = true;
                btn_SaveIssue.Enabled = false;
                btn_EditeIssue.Enabled = true;
                btn_DeleteIssue.Enabled = true;
                btn_CancelIssue.Enabled = true;
                btn_AddFile.Enabled = false;
                gb_Laws.Enabled = true;
            }
            else
            {
                txt_IssueNo.Enabled = true;
                txt_IssueID.Enabled = false;
                Spin_Year.Enabled = true;
                dtp_PublishDate.Enabled = true;
                dtp_SaveDate.Enabled = true;
                txt_Path.Enabled = false;

                btn_NewIssue.Enabled = false;
                btn_SaveIssue.Enabled = true;
                btn_EditeIssue.Enabled = false;
                btn_DeleteIssue.Enabled = false;
                btn_CancelIssue.Enabled = false;
                btn_AddFile.Enabled = true;
                gb_Laws.Enabled = false;
            }
        }
        public void SetExistingIssueFromSearch()
        {
            SetIssueMode(true);
            ResetLawDetails();
            gb_LawDetails.Enabled = false;
            pnl_Lawbtn.Enabled = false;
            btn_SaveLaw.Enabled = false;
            btn_CancelLaw.Enabled = false;
        }

        public void GetLaws()
        {
            UpdateIssueID();

            DataTable laws = DAC.SelectQue(
                "select * from Vw_Laws where [كود العدد]=N'" +
                txt_IssueID.Text.Replace("'", "''") +
                "' Order by [كود العدد] desc");

            grid_Law.DataSource = laws;

            if (dgv_Law.Columns.Count > 0) dgv_Law.Columns[0].Visible = false;
            if (dgv_Law.Columns.Count > 6) dgv_Law.Columns[6].Visible = false;
            if (dgv_Law.Columns.Count > 8) dgv_Law.Columns[8].Visible = false;
            if (dgv_Law.Columns.Count > 9) dgv_Law.Columns[9].Visible = false;

            gb_Laws.Enabled = true;

            cmb_Auth.DataSource = DAC.SelectQue("select Auth_ID,Auth_Name from tbl_Auth");
            cmb_Auth.DisplayMember = "Auth_Name";
            cmb_Auth.ValueMember = "Auth_ID";
            cmb_Auth.SelectedIndex = -1;

            cmb_Dep.DataSource = DAC.SelectQue("select Dep_ID,Dep_Name from tbl_Department");
            cmb_Dep.DisplayMember = "Dep_Name";
            cmb_Dep.ValueMember = "Dep_ID";
            cmb_Dep.SelectedIndex = -1;

            // لا نمسح dgv_LawDep هنا؛ هذا الجريد خاص بالقانون المحدد.
            // يتم تحميله عند DoubleClick على القانون.
        }

        public void ResetLawDetails()
        {
            _loadingLaw = true;
            txt_IDLaw.Clear();
            txt_LawNo.Clear();
            txt_LawYear.Clear();
            txt_Desc.Text = "لا ينطبق";
            cmb_Auth.SelectedIndex = -1;
            cmb_Dep.SelectedIndex = -1;
            dgv_LawDep.Rows.Clear();
            rb_N.Checked = true;
            _loadingLaw = false;

            txt_Desc.Enabled = false;
            gb_Dep.Enabled = false;
            gb_Desc.Enabled = false;
        }
        //-------------------Load---------------------------
        private void frm_AddIssue_Load(object sender, EventArgs e)
        {

        }

        //-------------------Buttons-----------------------
        private void btn_SearchIssue_Click(object sender, EventArgs e)
        {
            frm_Search frm = new frm_Search(this);
            frm.ShowDialog();
        }

        private void btn_SaveIssue_Click(object sender, EventArgs e)
        {
            string Desc = $"العدد:{txt_IssueNo.Text} - السنة{txt_Year.Text} - النشر: {dtp_PublishDate.Text} -الحفظ:{dtp_SaveDate.Text} ";
            if (txt_IssueNo.Text == "" || Spin_Year.Text == "" || txt_Path.Text == "" || dtp_PublishDate.Text == "" || dtp_SaveDate.Text == "")
            {
                MSG.NullField();
            }
            else
            {
                if (Add_UPd == 0)
                {
                    ISS.AddIssue(txt_IssueNo.Text, Spin_Year.Text, txt_IssueID.Text, dtp_PublishDate.Value, dtp_SaveDate.Value,
                        txt_Path.Text, IssueFile, "اعداد الجريدة", "اضافة", Properties.Settings.Default.UserID, Desc, txt_IssueID.Text);
                    MSG.InsertMessage();
                    gb_LawDetails.Enabled = false;
                    txt_LawYear.Text = Spin_Year.Text;
                    SetIssueMode(true);
                    GetLaws();
                }
            }
        }

        private void btn_AddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "PDF|*.pdf";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                using (FileStream FS = new FileStream(OFD.FileName, FileMode.Open, FileAccess.Read))
                using (BinaryReader br = new BinaryReader(FS))
                {
                    IssueFile = br.ReadBytes((int)FS.Length);
                }
                txt_Path.Text = Path.GetFullPath(OFD.FileName);
            }
        }

        private void btn_AddLaw_Click(object sender, EventArgs e)
        {
            gb_Issue.Enabled = false;
            gb_LawDetails.Enabled = true;
            gb_Laws.Enabled = false;
            btn_AddAuth.Enabled = true;
            cmb_Auth.Enabled = true;
            dtp_LawIssueDate.Enabled = true;
            btn_SearchAuth.Enabled = true;
            txt_LawYear.Text = Spin_Year.Text;
            txt_IDLaw.Clear();
            txt_LawNo.Clear();
            cmb_Auth.SelectedIndex = -1;
            cmb_Dep.SelectedIndex = -1;
            dgv_LawDep.Rows.Clear();

            _loadingLaw = true;
            rb_Y.Checked = true;
            _loadingLaw = false;
            txt_Desc.Text = "";
            txt_Desc.Enabled = true;
            gb_Dep.Enabled = true;
            Law_Add_Upd = 0;
            btn_EditeLaw.Enabled = false;
            btn_DeleteLaw.Enabled = false;
            pnl_Lawbtn.Enabled = true;
            btn_SaveLaw.Enabled = true;
        }

        private void btn_NewIssue_Click(object sender, EventArgs e)
        {
            // إلغاء أي حالة سابقة للقانون أولاً
            gb_LawDetails.Enabled = false;
            pnl_Lawbtn.Enabled = false;
            btn_SaveLaw.Enabled = false;
            btn_CancelLaw.Enabled = false;
            dgv_LawDep.Rows.Clear();

            txt_IssueNo.Clear();
            txt_ID.Clear();
            Spin_Year.Text = DateTime.Now.Year.ToString();
            txt_Year.Text = Spin_Year.Text;
            txt_IssueID.Clear();
            dtp_PublishDate.Value = DateTime.Now;
            dtp_SaveDate.Value = DateTime.Now;
            txt_Path.Clear();
            IssueFile = null;
            grid_Law.DataSource = null;

            SetIssueMode(false);
        }

        private void btn_CancelLaw_Click(object sender, EventArgs e)
        {
            ResetLawDetails();

            gb_LawDetails.Enabled = false;
            gb_Laws.Enabled = _isExistingIssue;
            gb_Issue.Enabled = true;
            btn_SaveLaw.Enabled = false;
            btn_CancelLaw.Enabled = false;
            pnl_Lawbtn.Enabled = false;

            // إعادة حالة العدد نفسها بدون تغييرها بسبب إلغاء القانون
            SetIssueMode(_isExistingIssue);
        }

        private void btn_AddLawDep_Click(object sender, EventArgs e)
        {
            if (cmb_Dep.SelectedValue == null || string.IsNullOrWhiteSpace(cmb_Dep.Text))
                return;

            string depId = cmb_Dep.SelectedValue.ToString();

            foreach (DataGridViewRow R in dgv_LawDep.Rows)
            {
                if (R.IsNewRow) continue;

                if (R.Cells[0].Value != null &&
                    R.Cells[0].Value.ToString() == depId)
                {
                    MSG.Exception("تم إضافة هذه الجهة الرسمية من قبل");
                    return;
                }
            }

            int rowIndex = dgv_LawDep.Rows.Add();
            dgv_LawDep.Rows[rowIndex].Cells[0].Value = depId;
            dgv_LawDep.Rows[rowIndex].Cells[1].Value = cmb_Dep.Text;
        }

        private void btn_DelLawDep_Click(object sender, EventArgs e)
        {
            if (dgv_LawDep.CurrentRow != null && !dgv_LawDep.CurrentRow.IsNewRow)
                dgv_LawDep.Rows.RemoveAt(dgv_LawDep.CurrentRow.Index);
        }

        private void btn_SaveLaw_Click(object sender, EventArgs e)
        {
            if (txt_LawNo.Text == "" || dtp_LawIssueDate.Text == "" || cmb_Auth.Text == "" || txt_Desc.Text == "")
            {
                MSG.NullField();
            }
            else if (rb_Y.Checked == true && dgv_LawDep.RowCount == 0)
            {
                MSG.Exception("تاكد من ادخال الجهات المعنية");
            }
            else
            {
                if (Law_Add_Upd == 0)
                {
                    string Desc = $"رقم القانون: {txt_LawNo.Text}-سنة:{txt_LawYear.Text}- تاريخ الاصدار:{dtp_LawIssueDate.Text}- جهة الاصدار:{cmb_Auth.Text}- مضمون القرار:{txt_Desc.Text}";
                    string Law_Ok;
                    if (rb_N.Checked)
                    {
                        Law_Ok = "لا ينطبق";
                    }
                    else
                    {
                        Law_Ok = "ينطبق";  
                    }
                        ISS.AddLaw(txt_LawNo.Text, txt_IssueNo.Text, Spin_Year.Text, $"قانون رقم {txt_LawNo.Text} لسنة {txt_LawYear.Text}", dtp_LawIssueDate.Value, int.Parse(cmb_Auth.SelectedValue.ToString()),
    
                            Law_Ok, txt_Desc.Text, "اعداد الجريدة", "اضافة", Properties.Settings.Default.UserID, Desc, $"قانون رقم {txt_LawNo.Text} لسنة {txt_LawYear.Text}");
                    if (dgv_LawDep.RowCount > 0)
                    {
                        foreach (DataGridViewRow R in dgv_LawDep.Rows)
                        {
                            ISS.AddLawDep(R.Cells[0].Value.ToString(), txt_LawNo.Text, txt_IssueNo.Text, Spin_Year.Text
                                , "اعداد الجريدة", "اضافة", Properties.Settings.Default.UserID, $"الجهة المعنية :{R.Cells[1].Value.ToString()}", $"قانون رقم {txt_LawNo.Text} لسنة {txt_LawYear.Text}");
                        }
                    }
                    GetLaws();
                    ResetLawDetails();

                    gb_LawDetails.Enabled = false;
                    gb_Laws.Enabled = true;
                    gb_Issue.Enabled = true;
                    pnl_Lawbtn.Enabled = false;
                    btn_SaveLaw.Enabled = false;
                    btn_CancelLaw.Enabled = false;
                    SetIssueMode(true);
                }
                else
                {
                    //
                }
            }
        }

        private void btn_DeleteLaw_Click(object sender, EventArgs e)
        {

        }

        private void btn_EditeLaw_Click(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            GetLaws();
        }

        private void btn_DeleteIssue_Click(object sender, EventArgs e)
        {
            DialogResult R = MSG.AskDeleteMessage(); ;
            if (R==DialogResult.Yes)
            {
                ISS.deleteIssue(txt_IssueNo.Text, Spin_Year.Text);
                btn_NewIssue_Click(sender,e);
                MSG.DeleteMessage();
            }
            return;
        }

        private void btn_EditeIssue_Click(object sender, EventArgs e)
        {

        }

        //------------------Actions-------------------------
        private void txt_IssueNo_TextChanged(object sender, EventArgs e)
        {
            UpdateIssueID();
        }

        private void rb_Y_CheckedChanged(object sender, EventArgs e)
        {
            if (_loadingLaw) return;

            if (rb_Y.Checked == true)
            {
                txt_Desc.Enabled = true;
                txt_Desc.Text = "";
                gb_Dep.Enabled = true;
            }
        }

        private void rb_N_CheckedChanged(object sender, EventArgs e)
        {
            if (_loadingLaw) return;

            if (rb_N.Checked == true)
            {
                if (txt_Desc.Text != ""||dgv_LawDep.RowCount>0)
                {
                    DialogResult R = MessageBox.Show("يوجد وصف فى مضمون القرار او الجهات المعنية هل انت متاكد من الحذف", "تحذير..!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (R == DialogResult.Yes)
                    {
                        txt_Desc.Text = "لا بنطبق";
                        txt_Desc.Enabled = false;
                        dgv_LawDep.Rows.Clear();
                        cmb_Dep.SelectedIndex = -1;
                        gb_Dep.Enabled = false;
                    }
                    else
                    {
                        string X  = txt_Desc.Text;
                        rb_Y.Checked = true;
                        txt_Desc.Text = X;
                    }
                }
                else
                {
                    txt_Desc.Text = "لا بنطبق";
                    txt_Desc.Enabled = false;
                    dgv_LawDep.Rows.Clear();
                    cmb_Dep.SelectedIndex = -1;
                    gb_Dep.Enabled = false;
                }
            }

        }

        private void dgv_Law_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_Law.FocusedRowHandle < 0)
                return;

            object lawNoValue = dgv_Law.GetFocusedRowCellValue("رقم القانون");
            if (lawNoValue == null || lawNoValue == DBNull.Value)
                return;

            string lawNo = lawNoValue.ToString();
            string lawOk = Convert.ToString(dgv_Law.GetFocusedRowCellValue("Law_ok"));
            string lawDesc = Convert.ToString(dgv_Law.GetFocusedRowCellValue("Law_Desc"));

            gb_Issue.Enabled = false;
            gb_Laws.Enabled = true;
            gb_LawDetails.Enabled = true;

            btn_AddAuth.Enabled = false;
            cmb_Auth.Enabled = false;
            dtp_LawIssueDate.Enabled = false;
            btn_SearchAuth.Enabled = false;
            btn_EditeLaw.Enabled = true;
            btn_DeleteLaw.Enabled = true;
            btn_SaveLaw.Enabled = false;
            btn_CancelLaw.Enabled = true;

            txt_LawNo.Text = lawNo;
            txt_IDLaw.Text = lawNo;
            dtp_LawIssueDate.Text = Convert.ToString(dgv_Law.GetFocusedRowCellValue("تاريخ الاصدار"));
            cmb_Auth.Text = Convert.ToString(dgv_Law.GetFocusedRowCellValue("جهة الاصدار"));
            _loadingLaw = true;
            txt_Desc.Text = lawDesc;
            if (lawOk == "لا ينطبق")
                rb_N.Checked = true;
            else
                rb_Y.Checked = true;
            _loadingLaw = false;

            txt_Desc.Enabled = lawOk != "لا ينطبق";
            gb_Dep.Enabled = lawOk != "لا ينطبق";

            DataTable dt = DAC.SelectQue(
                "SELECT * FROM VW_LawDep WHERE [Law_No]='" + lawNo.Replace("'", "''") +
                "' AND [Issue_No]='" + txt_IssueNo.Text.Replace("'", "''") +
                "' AND [Issue_Year]='" + txt_Year.Text.Replace("'", "''") + "'");

            dgv_LawDep.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dgv_LawDep.Rows.Add();
                dgv_LawDep.Rows[rowIndex].Cells[0].Value = row[0];
                dgv_LawDep.Rows[rowIndex].Cells[1].Value = row[1];
            }
        }
    }
}