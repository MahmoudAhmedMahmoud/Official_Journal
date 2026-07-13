 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Official_Journal
{
    class cls_Users
    {
        DataAccesLayer DAC = new DataAccesLayer();
        public DataTable GetUser(string UserID)
        {
            SqlParameter[] Par = new SqlParameter[1];
            Par[0] = new SqlParameter("@UserID", SqlDbType.NVarChar,50);
            Par[0].Value = UserID;
            DataTable Dt = new DataTable();
            Dt = DAC.Select("SP_GetUser", Par);
            return Dt;
        }
        public DataTable SelectAllUser_SuperAdmin()
        {
            DataTable Dt = new DataTable();
            Dt = DAC.Select("SP_SelectAllUser_SuperAdmin", null);
            return Dt;
        }

        public DataTable SelectAllUser()
        {
            DataTable Dt = new DataTable();
            Dt = DAC.Select("SP_SelectAllUser", null);
            return Dt;
        }
        //public DataTable SearchUser(string Search)
        //{
        //    SqlParameter[] Par = new SqlParameter[1];
        //    Par[0] = new SqlParameter("@Search", SqlDbType.NVarChar, 50);
        //    Par[0].Value = Search;            
        //    DataTable Dt = new DataTable();
        //    Dt= DAC.Select("SP_SearchUser", Par);
        //    return Dt;
        //}
        public void UpdUser(string ID,string UserID, string UserName, string UserPassword,string UserType)
        {
            SqlParameter[] Par = new SqlParameter[5];
            Par[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            Par[0].Value = ID;
            Par[1] = new SqlParameter("@UserID", SqlDbType.NVarChar, 50);
            Par[1].Value = UserID;
            Par[2] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            Par[2].Value = UserName;
            Par[3] = new SqlParameter("@UserPassword", SqlDbType.NVarChar, 50);
            Par[3].Value = UserPassword;
            Par[4] = new SqlParameter("@UserType", SqlDbType.NVarChar, 50);
            Par[4].Value = UserType;
            DAC.ExcCmd("SP_UpdUser", Par);
        }

        public void AddUser(string UserID, string UserName, string UserPassword, string UserType)
        {
            SqlParameter [] Par = new SqlParameter[4];
            Par[0] = new SqlParameter("@UserID", SqlDbType.NVarChar, 50);
            Par[0].Value = UserID;
            Par[1] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            Par[1].Value = UserName;
            Par[2] = new SqlParameter("@UserPassword", SqlDbType.NVarChar, 50);
            Par[2].Value = UserPassword;
            Par[3] = new SqlParameter("@UserType", SqlDbType.NVarChar, 50);
            Par[3].Value = UserType;
            DAC.CnOpen();
            DAC.ExcCmd("SP_Add_User", Par);
            DAC.CnClose();
        }

        public void DelUser(string UserID)
        {
            SqlParameter[] Par = new SqlParameter[1];
            Par[0] = new SqlParameter("@UserID",SqlDbType.NVarChar, 50);
            Par[0].Value=UserID;
            DAC.CnOpen();
            DAC.ExcCmd("SP_DelUser",Par);
            DAC.CnClose();
        }

        public void UserLogActivity(string Model_Type, string Action_Type,string User_ID,string Tran_Describe,string Link_ID)
        {
            SqlParameter[] Par = new SqlParameter[5];
            Par[0] = new SqlParameter("@Model_Type", SqlDbType.NVarChar, 50);
            Par[0].Value = Model_Type;
            Par[1] = new SqlParameter("@Action_Type", SqlDbType.NVarChar, 50);
            Par[1].Value = Action_Type;
            Par[2] = new SqlParameter("@User_ID", SqlDbType.NVarChar, 50);
            Par[2].Value = User_ID;
            Par[3] = new SqlParameter("@Tran_Describe", SqlDbType.NVarChar, 50);
            Par[3].Value = Tran_Describe;
            Par[4] = new SqlParameter("@Link_ID", SqlDbType.NVarChar, 50);
            Par[4].Value = Link_ID;
            DAC.CnOpen();
            DAC.ExcCmd("SP_UserLogActivity", Par);
            DAC.CnClose();
        }


        public void DownloadUser(string UserID, DateTime Action_Time, string File_ID, string File_Name)
        {
            SqlParameter[] Par = new SqlParameter[4];
            Par[0] = new SqlParameter("@UserID", SqlDbType.NVarChar, 50);
            Par[0].Value = UserID;
            Par[1] = new SqlParameter("@Action_Time", SqlDbType.DateTime);
            Par[1].Value = Action_Time;
            Par[2] = new SqlParameter("@File_ID", SqlDbType.NVarChar, 50);
            Par[2].Value = File_ID;
            Par[3] = new SqlParameter("@File_Name", SqlDbType.NVarChar, 150);
            Par[3].Value = File_Name;
            DAC.CnOpen();
            DAC.ExcCmd("SP_DownloadUser", Par);
            DAC.CnClose();
        }

        public DataTable SearchUser(string Search)
        {
            SqlParameter[] Par = new SqlParameter[1];
            Par[0] = new SqlParameter("@Search", SqlDbType.NVarChar, 50);
            Par[0].Value = Search;
            DataTable Dt = new DataTable();
            Dt = DAC.Select("SP_SearchUser", Par);
            return Dt;
        }


        //public DataTable SearchUserSuperAdmin(string Search)
        //{
        //    SqlParameter[] Par = new SqlParameter[1];
        //    Par[0] = new SqlParameter("@Search", SqlDbType.NVarChar, 50);
        //    Par[0].Value = Search;
        //    DataTable Dt = new DataTable();
        //    Dt = DAC.Select("SP_SearchUserSuperAdmin", Par);
        //    return Dt;
        //}







    }
}
