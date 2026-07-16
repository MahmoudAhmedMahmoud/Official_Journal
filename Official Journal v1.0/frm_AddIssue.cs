using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        byte[] IssueFile;

        public void GetLaws()
        {
            grid_Law.DataSource = DAC.SelectQue("select * from Vw_Laws where [كود العدد]=N'" + txt_IssueID.Text + "'");
            gb_Laws.Enabled = true;
            //
            cmb_Auth.DataSource = DAC.SelectQue("select Auth_ID,Auth_Name from tbl_Auth");
            cmb_Auth.DisplayMember = "Auth_Name";
            cmb_Auth.ValueMember = "Auth_ID";
            //
            cmb_Dep.DataSource = DAC.SelectQue("select Dep_ID,Dep_Name from tbl_Department");
            cmb_Dep.DisplayMember = "Dep_Name";
            cmb_Dep.ValueMember = "Dep_ID";
        }
        public void Reset()
        {

        }
        //-------------------Load---------------------------
        private void frm_AddIssue_Load(object sender, EventArgs e)
        {

        }

        //-------------------Buttons-----------------------
        private void btn_SearchIssue_Click(object sender, EventArgs e)
        {
            frm_Search frm = new frm_Search();
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
                    gb_LawDetails.Enabled = true;
                    gb_Laws.Enabled = true;
                    GetLaws();
                    txt_LawYear.Text = Spin_Year.Text;
                    txt_IssueID.Enabled = false;
                    Spin_Year.Enabled = false;
                    dtp_PublishDate.Enabled = false;
                    dtp_SaveDate.Enabled = false;
                    btn_AddFile.Enabled = false;
                    btn_EditeIssue.Enabled = false;
                    btn_DeleteIssue.Enabled = false;
                    btn_CancelIssue.Enabled = false;
                }
            }
        }

        private void btn_AddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "PDF|*.pdf";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                FileStream FS = new FileStream(OFD.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(FS);
                IssueFile = br.ReadBytes((int)FS.Length);
                //txt_Path.Text = OFD.FileName;
                txt_Path.Text = Path.GetFullPath(OFD.FileName);
            }
        }

        private void btn_AddLaw_Click(object sender, EventArgs e)
        {
            gb_Issue.Enabled = false;
            gb_LawDetails.Enabled = true;
            gb_Laws.Enabled = false;
            txt_LawYear.Text = Spin_Year.Text;
            btn_NewLaw.Enabled = false;
            btn_EditeLaw.Enabled = false;
            btn_DeleteLaw.Enabled = false;
        }

        private void btn_CancelLaw_Click(object sender, EventArgs e)
        {
            gb_LawDetails.Enabled = false;
            gb_Laws.Enabled = true;
            gb_Issue.Enabled = true;
        }

        //------------------Actions-------------------------
        private void txt_IssueNo_TextChanged(object sender, EventArgs e)
        {
            txt_IssueID.Text = "عدد " + txt_IssueNo.Text + "لسنة " + Spin_Year.Text;
        }

        private void rb_Y_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Y.Checked == true)
            {
                txt_Desc.Enabled = true;
                txt_Desc.Text = "";
            }
        }

        private void rb_N_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_N.Checked == true)
            {
                if (txt_Desc.Text != "")
                {
                    DialogResult R = MessageBox.Show("يوجد وصف فى مضمون القانون هل انت متاكد من الحذف", "تحذير..!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (R == DialogResult.Yes)
                    {
                        txt_Desc.Text = "لا بنطبق";
                        txt_Desc.Enabled = false;
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
                }
            }

        }

        private void btn_AddLawDep_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow R in dgv_LawDep.Rows)
            {
                if (R.IsNewRow) continue;

                if (R.Cells[0].Value != null &&
                    R.Cells[0].Value.ToString() == cmb_Dep.SelectedValue.ToString())
                {
                    MSG.Exception("تم إضافة هذه الجهة الرسمية من قبل");
                    return;
                }
            }
            int rowIndex = dgv_LawDep.Rows.Add();

            dgv_LawDep.Rows[rowIndex].Cells[1].Value = cmb_Dep.Text;
            dgv_LawDep.Rows[rowIndex].Cells[0].Value = cmb_Dep.SelectedValue.ToString();
        }

        private void btn_DelLawDep_Click(object sender, EventArgs e)
        {
            dgv_LawDep.Rows.RemoveAt(dgv_LawDep.CurrentRow.Index);
        }
    }
}