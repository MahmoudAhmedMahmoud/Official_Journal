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

        public byte[] IssueFile;
        public void GetLaws()
        {
            grid_Law.DataSource = DAC.SelectQue("select * from Vw_Laws where [كود العدد]=N'" + txt_IssueID.Text + "'Order by [كود العدد] desc");
            dgv_Law.Columns[0].Visible=false;
            dgv_Law.Columns[6].Visible = false;
            dgv_Law.Columns[8].Visible = false;
            dgv_Law.Columns[9].Visible = false;

            gb_Laws.Enabled = true;
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
        public void ResetLawDetails()
        {
            txt_IDLaw.Clear();
            txt_LawNo.Clear();
            txt_LawYear.Clear();
            txt_Desc.Clear();
            cmb_Auth.SelectedIndex=-1;  
            cmb_Dep.SelectedIndex=-1;
            dgv_LawDep.Rows.Clear();
            rb_N.Checked = true;
            txt_Desc.Text = "لا ينطبق";
            //gb_LawDetails.Enabled = true;
            // txt_Desc.Enabled = false;
            //gb_Dep.Enabled =false;
            //gb_Desc.Enabled =false;
            dtp_LawIssueDate.Value = DateTime.Now;
        }

        //-------------------Load---------------------------
        private void frm_AddIssue_Load(object sender, EventArgs e)
        {

        }

        //-------------------Buttons-----------------------
        private void btn_SearchIssue_Click(object sender, EventArgs e)
        {
            ResetLawDetails();
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
                    gb_LawDetails.Enabled = false;
                    GetLaws();
                    txt_LawYear.Text = Spin_Year.Text;
                    txt_IssueID.Enabled = false;
                    txt_IssueNo.Enabled = false;
                    Spin_Year.Enabled = false;
                    dtp_PublishDate.Enabled = false;
                    dtp_SaveDate.Enabled = false;
                    btn_AddFile.Enabled = false;
                    btn_EditeIssue.Enabled = true;
                    btn_DeleteIssue.Enabled = true;
                    btn_CancelIssue.Enabled = false;
                    btn_AddLaw.Enabled = true;
                    btn_SaveIssue.Enabled = false;
                    btn_NewIssue.Enabled = true;
                }
                else
                {
                    DialogResult R=MSG.AskUpdateMessage();
                    if (R==DialogResult.Yes)
                    {
                        ISS.UpdateIssue(txt_IssueNo.Text, Spin_Year.Text, txt_IssueID.Text, dtp_PublishDate.Value, dtp_SaveDate.Value,
                             txt_Path.Text, IssueFile, "اعداد الجريدة", "تعديل", Properties.Settings.Default.UserID, Desc, txt_IssueID.Text, txt_ID.Text, txt_Year.Text);
                        MSG.Updatemessage();
                        gb_LawDetails.Enabled = false;
                        GetLaws();
                        txt_LawYear.Text = Spin_Year.Text;
                        txt_IssueID.Enabled = false;
                        txt_IssueNo.Enabled = false;
                        Spin_Year.Enabled = false;
                        dtp_PublishDate.Enabled = false;
                        dtp_SaveDate.Enabled = false;
                        btn_AddFile.Enabled = false;
                        btn_EditeIssue.Enabled = true;
                        btn_DeleteIssue.Enabled = true;
                        btn_CancelIssue.Enabled = false;
                        btn_AddLaw.Enabled = true;
                        btn_SaveIssue.Enabled = false;
                        btn_NewIssue.Enabled = true;
                        //
                        btn_SearchIssue.Enabled = true;
                        //
                        txt_ID.Text = txt_IssueNo.Text;
                        txt_Year.Text = Spin_Year.Text;
                    }
                    return;
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
            //cancel event check box
            rb_Y.CheckedChanged -= rb_Y_CheckedChanged;
            rb_N.CheckedChanged -= rb_N_CheckedChanged;
            
            //
            gb_Issue.Enabled = false;
            gb_LawDetails.Enabled = true;
            gb_Laws.Enabled = false;
            ResetLawDetails();
            btn_EditeLaw.Enabled = false;
            btn_DeleteLaw.Enabled = false;
            pnl_Lawbtn.Enabled = true;
            btn_SaveLaw.Enabled = true;
            btn_CancelLaw.Enabled = true;
            gb_Desc.Enabled = true;
            txt_LawYear.Text = Spin_Year.Text;

            // enable event check box
            rb_Y.CheckedChanged += rb_Y_CheckedChanged;
            rb_N.CheckedChanged += rb_N_CheckedChanged;
        }

        private void btn_NewIssue_Click(object sender, EventArgs e)
        {
            this.btn_CancelLaw_Click(sender, e);
            txt_IssueNo.Clear();
            txt_ID.Clear();
            Spin_Year.Text = "2026";
            txt_IssueID.Clear();
            dtp_PublishDate.Value = DateTime.Now;
            dtp_SaveDate.Value = DateTime.Now;
            txt_Path.Clear();
            btn_SaveIssue.Enabled = true;
            btn_EditeIssue.Enabled = false; 
            btn_DeleteIssue.Enabled = false;
            gb_Laws.Enabled = false;
            grid_Law.DataSource= null;
            txt_IssueNo.Enabled=true;
            Spin_Year.Enabled = true;
            dtp_LawIssueDate.Enabled = true;
            dtp_PublishDate.Enabled = true;
            dtp_SaveDate.Enabled = true;
            btn_NewIssue.Enabled = false;

            //gb Law Details

                 //cancel event check box
            rb_Y.CheckedChanged -= rb_Y_CheckedChanged;
            rb_N.CheckedChanged -= rb_N_CheckedChanged;
           
            ResetLawDetails();

                // enable event check box
            rb_Y.CheckedChanged += rb_Y_CheckedChanged;
            rb_N.CheckedChanged += rb_N_CheckedChanged;

            gb_LawDetails.Enabled = false;
        }

        private void btn_CancelLaw_Click(object sender, EventArgs e)
        {
            ResetLawDetails();
            //
            gb_LawDetails.Enabled = false;
            gb_Laws.Enabled = true;
            gb_Issue.Enabled = true;
            btn_SaveLaw.Enabled = false;
     
            // pnl_Lawbtn.Enabled = false; 
            btn_NewIssue.Enabled = true;
            btn_SaveIssue.Enabled = false;
            btn_EditeIssue.Enabled = true;
            btn_DeleteIssue.Enabled = true;
            btn_CancelLaw.Enabled=false;
            pnl_Lawbtn.Enabled = false;
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
            if (cmb_Dep.Text!="")
            {
                dgv_LawDep.Rows[rowIndex].Cells[1].Value = cmb_Dep.Text;
                dgv_LawDep.Rows[rowIndex].Cells[0].Value = cmb_Dep.SelectedValue.ToString();
            }
            else
            {
                return;
            }


        }

        private void btn_DelLawDep_Click(object sender, EventArgs e)
        {
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
    
                            Law_Ok, txt_Desc.Text, "قانون", "اضافة", Properties.Settings.Default.UserID, Desc, $"قانون رقم {txt_LawNo.Text} لسنة {txt_LawYear.Text}");
                    if (dgv_LawDep.RowCount > 0)
                    {
                        foreach (DataGridViewRow R in dgv_LawDep.Rows)
                        {
                            ISS.AddLawDep(R.Cells[0].Value.ToString(), txt_LawNo.Text, txt_IssueNo.Text, Spin_Year.Text
                                , "قانون", "اضافة", Properties.Settings.Default.UserID, $"الجهة المعنية :{R.Cells[1].Value.ToString()}", $"قانون رقم {txt_LawNo.Text} لسنة {txt_LawYear.Text}");
                        }
                    }
                    btn_SaveLaw.Enabled = false;
                    btn_CancelLaw.Enabled = false;
                    GetLaws();
                    ResetLawDetails();
                    gb_Issue.Enabled = true;
                    gb_LawDetails.Enabled = false;
                }
                else
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
                    ISS.UpdLaw(txt_LawNo.Text, txt_IssueNo.Text, Spin_Year.Text, $"قانون رقم {txt_LawNo.Text} لسنة {txt_LawYear.Text}", dtp_LawIssueDate.Value, int.Parse(cmb_Auth.SelectedValue.ToString()),
                    Law_Ok, txt_Desc.Text, "قانون", "تعديل", Properties.Settings.Default.UserID, Desc, $"قانون رقم {txt_LawNo.Text} لسنة {txt_LawYear.Text}",txt_IDLaw.Text);
                    DAC.ExcQue("delete from tbl_LawDep where Law_No=N'"+txt_LawNo.Text+"'");
                    if (dgv_LawDep.RowCount > 0)
                    {
                        foreach (DataGridViewRow R in dgv_LawDep.Rows)
                        {
                            ISS.AddLawDep(R.Cells[0].Value.ToString(), txt_LawNo.Text, txt_IssueNo.Text, Spin_Year.Text
                                , "قانون", "اضافة", Properties.Settings.Default.UserID, $"الجهة المعنية :{R.Cells[1].Value.ToString()}", $"قانون رقم {txt_LawNo.Text} لسنة {txt_LawYear.Text}");
                        }
                    }
                    btn_SaveLaw.Enabled = false;
                    btn_CancelLaw.Enabled = false;
                    GetLaws();
                    ResetLawDetails();
                    gb_Issue.Enabled = true;
                    gb_LawDetails.Enabled = false;
                }
            }
        }

        private void btn_DeleteLaw_Click(object sender, EventArgs e)
        {
            DialogResult R = MSG.AskDeleteMessage();
            if (R == DialogResult.Yes)
            {
                DAC.ExcQue("delete from tbl_Laws where Law_No=N'" + txt_LawNo.Text + "' and Issue_Year=N'"+txt_LawYear.Text+"'");
                MSG.DeleteMessage();
                GetLaws();
                ResetLawDetails();
                //
                gb_LawDetails.Enabled = false;
                gb_Laws.Enabled = true;
                gb_Issue.Enabled = true;
                btn_SaveLaw.Enabled = false;

                // pnl_Lawbtn.Enabled = false; 
                btn_AddFile.Enabled = true;
                btn_NewIssue.Enabled = true;
                btn_SaveIssue.Enabled = false;
                btn_EditeIssue.Enabled = true;
                btn_DeleteIssue.Enabled = true;
                btn_CancelLaw.Enabled = false;
                pnl_Lawbtn.Enabled = false;
            }
            return;
        }

        private void btn_EditeLaw_Click(object sender, EventArgs e)
        {
            Law_Add_Upd = 1;
            gb_Issue.Enabled = false;
            gb_Laws.Enabled = false;
            gb_LawDetails.Enabled = true;
            btn_SaveLaw.Enabled = true;
            btn_EditeLaw.Enabled = false;
            btn_DeleteLaw.Enabled = false;
            btn_CancelLaw.Enabled=true;
            if (rb_N.Checked==true)
            {
                txt_Desc.Enabled = false;
                gb_Dep.Enabled = false;
            }
            else
            {
                txt_Desc.Enabled = true;
                gb_Dep.Enabled = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            grid_Law.DataSource = DAC.SelectQue("select * from Vw_Laws where [كود العدد]=N'" + txt_IssueID.Text + "'Order by [كود العدد] desc");
            dgv_Law.Columns[0].Visible = false;
            dgv_Law.Columns[6].Visible = false;
            gb_Laws.Enabled = true;
        }

        private void btn_DeleteIssue_Click(object sender, EventArgs e)
        {
            DialogResult R = MSG.AskDeleteMessage(); ;
            if (R==DialogResult.Yes)
            {
                string Desc = $"العدد:{txt_IssueNo.Text} - السنة{txt_Year.Text} - النشر: {dtp_PublishDate.Text} -الحفظ:{dtp_SaveDate.Text} ";
                ISS.DeleteIssue(txt_IssueNo.Text, Spin_Year.Text, "اعداد الجريدة", "حذف", Properties.Settings.Default.UserID, Desc, txt_IssueID.Text);
                btn_NewIssue_Click(sender,e);
                MSG.DeleteMessage();
            }
            return;
        }

        private void btn_EditeIssue_Click(object sender, EventArgs e)
        {
            Add_UPd = 1;
            btn_EditeIssue.Enabled = false;
            btn_SaveIssue.Enabled = true;
            btn_CancelIssue.Enabled = true;
            btn_NewIssue.Enabled = false;
            btn_SearchIssue.Enabled = false;
            gb_Laws.Enabled = false;
            gb_LawDetails.Enabled = false;
            txt_IssueNo.Enabled = true;
            Spin_Year.Enabled = true;
            dtp_PublishDate.Enabled = true;
            dtp_SaveDate.Enabled = true;
            btn_AddFile.Enabled = true;
        }

        //------------------Actions-------------------------
        private void txt_IssueNo_TextChanged(object sender, EventArgs e)
        {
            txt_IssueID.Text = "عدد " + txt_IssueNo.Text + " لسنة " + Spin_Year.Text;
        }
        private void Spin_Year_EditValueChanged(object sender, EventArgs e)
        {
            txt_IssueID.Text = "عدد " + txt_IssueNo.Text + " لسنة " + Spin_Year.Text;
        }

        private void rb_Y_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Y.Checked == true)
            {
                txt_Desc.Enabled = true;
                txt_Desc.Text = "";
                gb_Dep.Enabled = true;
            }
        }

        private void rb_N_CheckedChanged(object sender, EventArgs e)
        {
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
            if (dgv_Law.RowCount!=0)
            {
                // btn_AddLaw
                pnl_Lawbtn.Enabled = true;
                btn_EditeLaw.Enabled = true;
                btn_DeleteLaw.Enabled = true;
                btn_SaveLaw.Enabled = false;
                btn_CancelLaw.Enabled = false;

                // txt_Desc.Clear();
                txt_LawNo.Text = dgv_Law.GetFocusedRowCellValue("رقم القانون").ToString();
                txt_IDLaw.Text = dgv_Law.GetFocusedRowCellValue("رقم القانون").ToString();
                dtp_LawIssueDate.Text = dgv_Law.GetFocusedRowCellValue("تاريخ الاصدار").ToString();
                cmb_Auth.Text = dgv_Law.GetFocusedRowCellValue("جهة الاصدار").ToString();
                txt_LawYear.Text = Spin_Year.Text;

                //cancel event check box
                rb_Y.CheckedChanged -= rb_Y_CheckedChanged;
                rb_N.CheckedChanged -= rb_N_CheckedChanged;

                //ينطبق ولا ينطبق
                if (dgv_Law.GetFocusedRowCellValue("Law_ok").ToString() == "لا ينطبق")
                {
                    rb_N.Checked = true;
                    txt_Desc.Text = dgv_Law.GetFocusedRowCellValue("Law_Desc").ToString();
                }
                else
                {
                    rb_Y.Checked = true;
                    txt_Desc.Text = dgv_Law.GetFocusedRowCellValue("Law_Desc").ToString();
                }

                //الجهة المعنية
                DataTable dt = DAC.SelectQue("SELECT *  FROM VW_LawDep where [Law_No]='" + txt_LawNo.Text + "' and [Issue_No]='" + txt_IssueNo.Text + "' and [Issue_Year]='" + txt_Year.Text + "'");
                dgv_LawDep.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int rowIndex = dgv_LawDep.Rows.Add();
                    dgv_LawDep.Rows[rowIndex].Cells[0].Value = row[0];
                    dgv_LawDep.Rows[rowIndex].Cells[1].Value = row[1];
               }

                // enable event check box
                rb_Y.CheckedChanged += rb_Y_CheckedChanged;
                rb_N.CheckedChanged += rb_N_CheckedChanged;

            }
            return;
        }


    }
}