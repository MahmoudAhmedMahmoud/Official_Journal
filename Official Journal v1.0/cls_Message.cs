using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Official_Journal
{
    class cls_Message
    {
        public void InsertMessage()
        {
            MessageBox.Show(" „ «œŒ«· «·»Ì«‰«  »‰Ã«Õ ..", " ‰›Ì– √Ã—«¡", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult AskUpdateMessage()
        {
           DialogResult R;
           R = MessageBox.Show("Â·  —Ìœ «· ⁄œÌ·ø" + "\n" + " !!!·« Ì„ﬂ‰ «·—ÃÊ⁄ ··»Ì«‰«  ﬁ»· «· ⁄œÌ·", " ‰›Ì– √Ã—«¡", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
            return R;
        }

        public void Updatemessage()
        {
             MessageBox.Show(" „ «· ⁄œÌ· ...!", " ‰›Ì– √Ã—«¡", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        public DialogResult AskDeleteMessage()
        {
            DialogResult R;
            R = MessageBox.Show("Â·  —Ìœ «·Õ–› ø" + "\n" + " !!!·« Ì„ﬂ‰ «·—ÃÊ⁄ ··»Ì«‰«  «·„Õ–Ê›…", " ‰›Ì– √Ã—«¡", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
            return R;
        }

        public void DeleteMessage()
        {
            MessageBox.Show(" „ «·Õ–› ...!", " ‰›Ì– √Ã—«¡", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        public void Null()
        {
            MessageBox.Show("·« ÌÊÃœ »Ì«‰« ", "Œÿ√", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        public void NullField()
        {
            MessageBox.Show(" «ﬂœ „‰ «œŒ«· ﬂ«›… «·»Ì«‰« ", "Œÿ√", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        public void Exception(String Msg)
        {
            MessageBox.Show(Msg, "Œÿ√", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }
    }
}