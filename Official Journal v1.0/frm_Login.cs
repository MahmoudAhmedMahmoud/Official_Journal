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
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        //------------------------- Cls ----------------------------------

        cls_Users Users = new cls_Users();
        cls_Message MSG = new cls_Message();
        //-----------------------------------------------------------

        //------------------------- Btns ----------------------------
        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_UserName.Text == "" && txt_Pass.Text == "")
                {
                    MessageBox.Show("يرجى ادخال اسم المستخدم و كلمة المرور لتتمكن من الدخول", "Login Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataTable Dt = new DataTable();
                    Dt = Users.GetUser(txt_UserID.Text);
                    if (Dt.Rows.Count > 0)
                    {
                        txt_UserName.Text = Dt.Rows[0][1].ToString();
                        lbl_UserType.Text = Dt.Rows[0][3].ToString();
                        if (Dt.Rows[0][2].ToString() == txt_Pass.Text)
                        {
                            Properties.Settings.Default.UserID = Dt.Rows[0][0].ToString();
                            Properties.Settings.Default.UserName = Dt.Rows[0][1].ToString();
                            Properties.Settings.Default.UserType = Dt.Rows[0][3].ToString();
                            Users.UserLogActivity("LOGIN", "تسجيل الدخول", Dt.Rows[0][0].ToString(), "تسجيل دخول", "0");
                            if (lbl_UserType.Text == "Admin" || lbl_UserType.Text == "Super Admin")
                            {
                                frm_Main frm = new frm_Main();
                                frm.Show();
                            }
                            else
                            {
                                frm_Main frm = new frm_Main();
                                frm.Show();
                            }
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("برجاء التاكد من كلمة المرور", "Login Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("برجاء التاكد من اسم المستخدم", "Login Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MSG.Exception("يرجى التاكد من وجود اتصال.......");
            }
        }

        private void txt_UserID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable Dt = new DataTable();
                Dt = Users.GetUser(txt_UserID.Text);
                if (Dt.Rows.Count > 0)
                {
                    txt_UserName.Text = Dt.Rows[0][1].ToString();
                    lbl_UserType.Text = Dt.Rows[0][3].ToString();
                }
                else if (txt_UserID.Text == "")
                {
                    txt_UserName.Text = "";
                }
                else
                {
                    txt_UserName.Text = "";
                }
            }
            catch (Exception ex)
            {
                string X = ex.Message;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------------------ Actions -----------------------------
        private void txt_UserID_KeyDown(object sender, KeyEventArgs e)
        {
            Control ctrl = (Control)sender;
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(ctrl, true, false, false, false);
            }
        }

        private void txt_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            Control ctrl = (Control)sender;
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(ctrl, true, false, false, false);
            }
        }

        private void btn_DataBase_Click(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "ghhgihghhggi")
            {
                frm_Cn frm = new frm_Cn();
                frm.ShowDialog();
            }
            else
            {
                MSG.Exception("ليس لديك الصلاحية للدخول");
            }

        }
    }
}
