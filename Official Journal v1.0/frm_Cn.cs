using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace Official_Journal
{
    public partial class frm_Cn : DevExpress.XtraEditors.XtraForm
    {
        public frm_Cn()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //ConnectionStringSettings connectionStringSettings = config.ConnectionStrings.ConnectionStrings["CNstring"];
            //connectionStringSettings.ConnectionString = txt_Cn.Text;
            //config.Save(ConfigurationSaveMode.Modified);
            //ConfigurationManager.RefreshSection("connectionStrings");          
            try
            {
                string NewCN = txt_Cn.Text;
                string CurrentCN = "CNstring";
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                // الحصول على سلسلة الاتصال
                ConnectionStringSettings settings = config.ConnectionStrings.ConnectionStrings[CurrentCN];
                settings.ConnectionString = NewCN;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");

                //Properties.Settings.Default.UserID="5";
                Properties.Settings.Default.Save();
                SqlConnection CNtest = new SqlConnection(NewCN);
                CNtest.Open();
                if (CNtest.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connection Sucsess..");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Connection Faild..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Faild.."+ '\n' + '\n'+ex.Message);
            }


        }
    }
}