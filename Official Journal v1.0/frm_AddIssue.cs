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
           grid_Law.DataSource = DAC.SelectQue("select * from Vw_Laws where [كودالعدد]=N'"+txt_IssueID.Text+"'");
        }
        public void Reset()
        {   
            txt_IssueNo.Text = "";
            txt_IssueID.Text = "";
            txt_Year.Text = "";
            txt_ID.Text = "";
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
            if (txt_IssueNo.Text==""|| Spin_Year.Text == ""||txt_Path.Text==""||dtp_PublishDate.Text==""||dtp_SaveDate.Text=="")
            {
                MSG.NullField();
            }
            else
            {
                if (Add_UPd == 0)
                {
                    ISS.AddIssue(txt_IssueNo.Text, Spin_Year.Text, txt_IssueID.Text, dtp_PublishDate.Value, dtp_SaveDate.Value,
                        txt_Path.Text, IssueFile, "اعداد الجريدة", "اضافة", Properties.Settings.Default.UserID, Desc,txt_IssueID.Text);
                    MSG.InsertMessage();
                    gb_LawDetails.Enabled = true;
                    gb_Laws.Enabled = true;
                    GetLaws();
                    txt_LawYear.Text=Spin_Year.Text;
                    txt_IssueID.Enabled=false;
                    Spin_Year.Enabled = false;
                    dtp_PublishDate.Enabled = false;
                    dtp_SaveDate.Enabled = false;
                    btn_AddFile.Enabled = false;
                    btn_EditeIssue.Enabled=false;
                    btn_DeleteIssue.Enabled = false;
                    btn_CancelIssue.Enabled = false;
                }
            }

        }


        //------------------Actions-------------------------
        private void txt_IssueNo_TextChanged(object sender, EventArgs e)
        {
            txt_IssueID.Text = "عدد " + txt_IssueNo.Text + "لسنة " + Spin_Year.Text;
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
                txt_Path.Text = Path.GetFileNameWithoutExtension(OFD.FileName);
            }
        }
    }
}