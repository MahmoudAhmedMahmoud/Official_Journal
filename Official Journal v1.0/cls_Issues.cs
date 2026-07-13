using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Controls;

namespace Official_Journal
{
    internal class cls_Issues
    {
        DataAccesLayer DAC = new DataAccesLayer();
        public void AddIssue(string Issue_No, string Issue_Year, string Issue_ID, DateTime Issue_PublishDate,DateTime Issue_SaveDate,
            string Issue_Path, byte[] Issue_File,string Model_Type,string Action_Type,string User_ID,string Tran_Describe,string Link_ID)
        {
            SqlParameter[] Par = new SqlParameter[12];
            Par[0] = new SqlParameter("@Issue_No", SqlDbType.NVarChar, 50);
            Par[0].Value = Issue_No;
            Par[1] = new SqlParameter("@Issue_Year", SqlDbType.NVarChar, 50);
            Par[1].Value = Issue_Year;
            Par[2] = new SqlParameter("@Issue_ID", SqlDbType.NVarChar, 50);
            Par[2].Value = Issue_ID;
            Par[3] = new SqlParameter("@Issue_PublishDate", SqlDbType.DateTime);
            Par[3].Value = Issue_PublishDate;
            Par[4] = new SqlParameter("@Issue_SaveDate", SqlDbType.DateTime);
            Par[4].Value = Issue_SaveDate;
            Par[5] = new SqlParameter("@Issue_Path", SqlDbType.NVarChar, 50);
            Par[5].Value = Issue_Path;
            Par[6] = new SqlParameter("@Issue_File", SqlDbType.VarBinary);
            Par[6].Value = Issue_File;
            Par[7] = new SqlParameter("@Model_Type", SqlDbType.NVarChar, 50);
            Par[7].Value = Model_Type;
            Par[8] = new SqlParameter("@Action_Type", SqlDbType.NVarChar, 50);
            Par[8].Value = Action_Type;
            Par[9] = new SqlParameter("@User_ID", SqlDbType.NVarChar, 50);
            Par[9].Value = User_ID;
            Par[10] = new SqlParameter("@Tran_Describe", SqlDbType.NVarChar, 50);
            Par[10].Value = Tran_Describe;
            Par[11] = new SqlParameter("@Link_ID", SqlDbType.NVarChar, 50);
            Par[11].Value = Link_ID;
            DAC.CnOpen();
            DAC.ExcCmd("SP_AddIssue", Par);
            DAC.CnClose();
        }

        public void UpdateIssue(string Issue_No, string Issue_Year, string Issue_ID, DateTime Issue_PublishDate, DateTime Issue_SaveDate,
            string Issue_Path, byte[] Issue_File, string Model_Type, string Action_Type, string User_ID, string Tran_Describe, string Link_ID,
            string ID , string Year)
        {
            SqlParameter[] Par = new SqlParameter[14];
            Par[0] = new SqlParameter("@Issue_No", SqlDbType.NVarChar, 50);
            Par[0].Value = Issue_No;
            Par[1] = new SqlParameter("@Issue_Year", SqlDbType.NVarChar, 50);
            Par[1].Value = Issue_Year;
            Par[2] = new SqlParameter("@Issue_ID", SqlDbType.NVarChar, 50);
            Par[2].Value = Issue_ID;
            Par[3] = new SqlParameter("@Issue_PublishDate", SqlDbType.DateTime);
            Par[3].Value = Issue_PublishDate;
            Par[4] = new SqlParameter("@Issue_SaveDate", SqlDbType.DateTime);
            Par[4].Value = Issue_SaveDate;
            Par[5] = new SqlParameter("@Issue_Path", SqlDbType.NVarChar, 50);
            Par[5].Value = Issue_Path;
            Par[6] = new SqlParameter("@Issue_File", SqlDbType.VarBinary);
            Par[6].Value = Issue_File;
            Par[7] = new SqlParameter("@Model_Type", SqlDbType.NVarChar, 50);
            Par[7].Value = Model_Type;
            Par[8] = new SqlParameter("@Action_Type", SqlDbType.NVarChar, 50);
            Par[8].Value = Action_Type;
            Par[9] = new SqlParameter("@User_ID", SqlDbType.NVarChar, 50);
            Par[9].Value = User_ID;
            Par[10] = new SqlParameter("@Tran_Describe", SqlDbType.NVarChar, 50);
            Par[10].Value = Tran_Describe;
            Par[11] = new SqlParameter("@Link_ID", SqlDbType.NVarChar, 50);
            Par[11].Value = Link_ID;
            Par[12] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            Par[12].Value = ID;
            Par[13] = new SqlParameter("@Year", SqlDbType.NVarChar, 50);
            Par[13].Value = Year;
            DAC.CnOpen();
            DAC.ExcCmd("SP_UpdateIssue", Par);
            DAC.CnClose();
        }

        public void deleteIssue(string Issue_No, string Issue_Year)
        {
            SqlParameter[] Par = new SqlParameter[2];
            Par[0] = new SqlParameter("@Issue_No", SqlDbType.NVarChar, 50);
            Par[0].Value = Issue_No;
            Par[1] = new SqlParameter("@Issue_Year", SqlDbType.NVarChar, 50);
            Par[1].Value = Issue_Year;
            DAC.CnOpen();
            DAC.ExcCmd("SP_DeleteIssue", Par);
            DAC.CnClose();
        }

        public void GetIssueFile(string Issue_No, string Issue_Year)
        {
            SqlParameter[] Par = new SqlParameter[2];
            Par[0] = new SqlParameter("@Issue_No", SqlDbType.NVarChar, 50);
            Par[0].Value = Issue_No;
            Par[1] = new SqlParameter("@Issue_Year", SqlDbType.NVarChar, 50);
            Par[1].Value = Issue_Year;
            DAC.CnOpen();
            DAC.ExcCmd("SP_DeleteIssue", Par);
            DAC.CnClose();
        }


    }
}
