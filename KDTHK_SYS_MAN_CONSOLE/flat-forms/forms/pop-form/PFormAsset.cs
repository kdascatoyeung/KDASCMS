using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.services;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.pop_form
{
    public partial class PFormAsset : Form
    {
        string _chaseno;

        public PFormAsset(string chaseno)
        {
            InitializeComponent();

            LoadApplicationData(chaseno);

            foreach (string item in GlobalService.ITList)
                cbAssign.Items.Add(item.Trim());

            cbAssign.SelectedIndex = 0;

            _chaseno = chaseno;
        }

        private void LoadApplicationData(string chaseno)
        {
            string refno = DataUtil.GetRefNo("loaning", chaseno);

            string query = string.Format("select f_applicant, f_content, f_start, f_end, l_approver, l_approval, f_title, l_handledby from TB_FORM, TB_FORM_LOANING where f_chaseno = l_refno and f_chaseno = '{0}'", refno);

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    txtName.Text = reader.GetString(0);
                    Byte[] content = new Byte[Convert.ToInt32((reader.GetBytes(1, 0, null, 0, Int32.MaxValue)))];
                    long bytesReceived = reader.GetBytes(1, 0, content, 0, content.Length);
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    rtbContent.Rtf = encoding.GetString(content, 0, Convert.ToInt32(bytesReceived));

                    txtStart.Text = reader.GetString(2);
                    txtEnd.Text = reader.GetString(3);
                    txtApprover.Text = reader.GetString(4);

                    string approval = reader.GetString(5);
                    Image img = approval == "Yes" ? Properties.Resources.tick_icon : Properties.Resources.cross_icon;
                    pbApproval.Image = img;

                    txtTitle.Text = reader.GetString(6);

                    cbAssign.Text = reader.GetString(7);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = string.Format("update TB_FORM_LOANING set l_handledby = N'{0}' where l_chaseno = '{1}'", cbAssign.SelectedItem.ToString().Trim(), _chaseno);
            DataService.GetInstance().ExecuteNonQuery(query);

            DialogResult = DialogResult.OK;
        }
    }
}
