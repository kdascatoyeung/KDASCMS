using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.pop_form
{
    public partial class PFormR3 : Form
    {
        string _path = "";
        string _chaseno = "";

        public PFormR3(string chaseno)
        {
            InitializeComponent();

            _chaseno = chaseno;

            LoadApplicationData(chaseno);

            LoadData(chaseno);
        }

        private void LoadApplicationData(string chaseno)
        {
            string refno = DataUtil.GetRefNo("r3", chaseno);

            string query = string.Format("select f_applicant, f_content, f_approver, f_title, f_approvaldate from TB_FORM where f_chaseno = '{0}'", refno);

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    txtName.Text = reader.GetString(0);
                    Byte[] content = new Byte[Convert.ToInt32((reader.GetBytes(1, 0, null, 0, Int32.MaxValue)))];
                    long bytesReceived = reader.GetBytes(1, 0, content, 0, content.Length);
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    rtbContent.Rtf = encoding.GetString(content, 0, Convert.ToInt32(bytesReceived));

                    txtApprover.Text = reader.GetString(2);
                    txtTitle.Text = reader.GetString(3);

                    lblApprovalDate.Text = "At " + reader.GetString(4);
                }
            }
        }

        private void LoadData(string chaseno)
        {
            string query = string.Format("select r_start, r_itcomment, r_itattachment, r_cmapprover, r_cmapproval, r_cmappdate from TB_FORM_R3 where r_chaseno = '{0}'", chaseno);

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    txtStart.Text = reader.GetString(0).Trim();
                    txtComment.Text = reader.GetString(1).Trim();
                    string path = reader.GetString(2).Trim();
                    lklAttachment.Text = Path.GetFileName(path);
                    _path = path;

                    txtCmApprover.Text = reader.GetString(3).Trim();
                    string cmapp = reader.GetString(4).Trim();

                    Image img = cmapp == "Yes" ? Properties.Resources.tick_icon : Properties.Resources.cross_icon;
                    pbCm.Image = img;

                    lblITApprovalDate.Text = "At " + reader.GetString(5).Trim();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure to delete this application?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:

                    string query = string.Format("delete from TB_FORM_R3 where r_chaseno = '{0}'", _chaseno);
                    DataService.GetInstance().ExecuteNonQuery(query);

                    break;

                case DialogResult.No:

                    break;
            }

            DialogResult = DialogResult.OK;
        }

        private void lklAttachment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_path);
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
