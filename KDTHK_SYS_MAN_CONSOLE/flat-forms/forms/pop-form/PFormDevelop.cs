using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data.SqlClient;
using KDTHK_SYS_MAN_CONSOLE.services;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.pop_form
{
    public partial class PFormDevelop : Form
    {
        string _mode = "";
        string _chaseno = "";

        public PFormDevelop(string chaseno, string mode)
        {
            InitializeComponent();

            _mode = mode;

            _chaseno = chaseno;

            LoadApplicationData(chaseno);

            LoadData(chaseno);

            cbStatus.Visible = mode == "completed" ? false : true;

            if (mode != "completed") cbStatus.SelectedIndex = 1;

            foreach (string item in GlobalService.ITList)
                cbAssign.Items.Add(item.Trim());
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LoadApplicationData(string chaseno)
        {
            Debug.WriteLine("ChaseNo: " + chaseno);
            string refno = DataUtil.GetRefNo("develop", chaseno);

            string query = string.Format("select f_applicant, f_content, f_start, f_end, d_approver, d_approval, f_title from TB_FORM, TB_FORM_DEVELOP where f_chaseno = d_refno and f_chaseno = '{0}'", refno);

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
                }
            }
        }

        private void LoadData(string chaseno)
        {
            string query = string.Format("select d_category, d_item, d_estimate, d_remarks, d_handledby from TB_FORM_DEVELOP where d_chaseno = '{0}'", chaseno);

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    cbCategory.Text = reader.GetString(0).Trim();
                    cbItem.Text = reader.GetString(1).Trim();
                    dtpComplete.Value = Convert.ToDateTime(reader.GetString(2).Trim());

                    Byte[] content = new Byte[Convert.ToInt32((reader.GetBytes(3, 0, null, 0, Int32.MaxValue)))];
                    long bytesReceived = reader.GetBytes(3, 0, content, 0, content.Length);
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    rtbRemarks.Rtf = encoding.GetString(content, 0, Convert.ToInt32(bytesReceived));

                    cbAssign.Text = reader.GetString(4).Trim();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string category = cbCategory.SelectedItem.ToString().Trim();
            string estimated = dtpComplete.Value.ToString("yyyy/MM/dd");
            string item = cbItem.SelectedItem.ToString().Trim();
            string status = cbStatus.SelectedItem.ToString().Trim();

            rtbRemarks.SaveFile("temp.rtf");
            FileStream stream = new FileStream("temp.rtf", FileMode.Open, FileAccess.Read);
            int size = Convert.ToInt32(stream.Length);
            Byte[] rtf = new Byte[size];
            stream.Read(rtf, 0, size);

            string assigned = cbAssign.Text;

            string st = status == "Completed" ? "申請處理完成" : "I.T處理中";

            string query = string.Format("update TB_FORM_DEVELOP set d_category = '{0}', d_item = '{1}', d_estimate = '{2}', d_status = N'{3}', d_remarks = @remarks, d_handledby = N'{4}' where d_chaseno = '{5}'", category, item, estimated, st, assigned, _chaseno);

            SqlCommand cmd = new SqlCommand(query, DataService.GetInstance().Connection);

            SqlParameter param = new SqlParameter("@Remarks", SqlDbType.Image, rtf.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, rtf);
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();

            DialogResult = DialogResult.OK;
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.White;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.FromArgb(58, 58, 58);
        }
    }
}
