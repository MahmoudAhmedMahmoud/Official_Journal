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
    public partial class frm_Add_Department : DevExpress.XtraEditors.XtraForm
    {
        public frm_Add_Department()
        {
            InitializeComponent();
        }
        //------------------------------------ Moving Form --------------------------------
        int X, Y;
        int M = 0;
        private void pnl_Head_MouseDown(object sender, MouseEventArgs e)
        {
            M = 1;
            X = e.X;
            Y = e.Y;
        }

        private void pnl_Head_MouseUp(object sender, MouseEventArgs e)
        {
            M = 0;
        }

        private void pnl_Head_MouseMove(object sender, MouseEventArgs e)
        {
            var frm = Application.OpenForms["frm_Main"] as frm_Main;
            int XX = frm.Location.X;
            int YY = frm.Location.Y;
            if (M == 1)
            {
                this.SetDesktopLocation(MousePosition.X - X - 1, MousePosition.Y - Y - 150);
            }
        }
        //-------------------------------------------------------------------------------------
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}