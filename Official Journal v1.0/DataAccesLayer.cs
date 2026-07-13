using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;



namespace Official_Journal
{
    class DataAccesLayer
    {
        SqlConnection Cn = new SqlConnection();
        string Server, DataBase, User, Password;

        public DataAccesLayer()
        {
             // Server = Properties.Settings.Default.Server;
            Server = "192.168.1.50"; //"196.202.64.114";
            //  DataBase = Properties.Settings.Default.Database;
            DataBase = "QODS_DB";
            //  User = Properties.Settings.Default.UserName;
            User = "sa";
            //  Password = Properties.Settings.Default.Password;
            Password = "ghhgihghhggi";
           // Cn = new SqlConnection("Server="+Server+";DataBase="+DataBase+";Uid="+User+";Pwd="+Password+";");
            //Cn = new SqlConnection(Properties.Settings.Default.CNstring);

           // string connectionString = ConfigurationManager.ConnectionStrings["CNstring"].ConnectionString;
           Cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CNstring"].ConnectionString);


        }//Server=192.168.1.50;DataBase=QODS_DB;Uid=sa;Pwd=ghhgihghhggi

        public void CnOpen()
        {
            if (Cn.State==ConnectionState.Closed)
            {
                Cn.Open();
            }
        }

        public void CnClose()
        {
            if (Cn.State==ConnectionState.Open)
            {
                Cn.Close();
            }
        }

        public DataTable Select(string SP, SqlParameter[] Par)
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = SP;
            Cmd.Connection = Cn;
            if (Par!=null)
            {
                Cmd.Parameters.AddRange(Par);
            }
            SqlDataAdapter Da = new SqlDataAdapter(Cmd);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            return Dt;
        }

        public DataTable SelectQue(string Que)
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = Que;
            Cmd.Connection = Cn;
            SqlDataAdapter Da = new SqlDataAdapter(Cmd);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            return Dt;
        }

        public void ExcCmd(String SP, SqlParameter[] Par)
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = SP;
            Cmd.Connection = Cn;
            if (Par!=null)
            {
                Cmd.Parameters.AddRange(Par);
            }
            CnOpen();
            Cmd.ExecuteNonQuery();
            CnClose();
        }

        public void ExcQue(string Que)
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = Que;
            Cmd.Connection = Cn;
            CnOpen();
            Cmd.ExecuteNonQuery();
            CnClose();
        }

    }
}
