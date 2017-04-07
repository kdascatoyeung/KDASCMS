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
    public partial class PFormPermission : Form
    {
        string _chaseno = "";

        public PFormPermission(string chaseno, string category)
        {
            InitializeComponent();

            LoadApplicationData(chaseno);

            LoadData(chaseno, category);

            this.Text = "Permission - " + chaseno;

            _chaseno = chaseno;

            foreach (string item in GlobalService.ITList)
                cbAssign.Items.Add(item.Trim());

            cbAssign.SelectedIndex = 0;
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LoadApplicationData(string chaseno)
        {
            string refno = DataUtil.GetRefNo("permission", chaseno);

            string query = string.Format("select f_applicant, f_content, f_start, f_end, p_approver, p_approval, f_title from TB_FORM, TB_FORM_PERMISSION where f_chaseno = p_refno and f_chaseno = '{0}'", refno);

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

        private void LoadData(string chaseno, string category)
        {
            string query = string.Format("select p_item, p_user, p_start, p_type, p_remarks, p_detail, p_handledby, p_approvaldate, p_itapproval, p_itapprovaldate from TB_FORM_PERMISSION where p_chaseno = '{0}' and p_item = '{1}'", chaseno, category);

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string item = reader.GetString(0);
                    string user = reader.GetString(1);
                    string start = reader.GetString(2);
                    string type = reader.GetString(3);
                    string remarks = reader.GetString(4);
                    string assigned = reader.GetString(6);

                    lblApprovalDate.Text = "At " + reader.GetString(7);

                    if (item == "MES")
                    {
                        lblITApprover.Text = reader.GetString(8);
                        lblITApprovalDate.Text = "At " + reader.GetString(9);
                        pbIt.Image = Properties.Resources.tick_icon;
                    }
                    dgvPermission.Rows.Add(item, user, start, type, remarks);

                    cbAssign.Text = assigned;
                    try
                    {
                        Byte[] content = new Byte[Convert.ToInt32((reader.GetBytes(5, 0, null, 0, Int32.MaxValue)))];
                        long bytesReceived = reader.GetBytes(5, 0, content, 0, content.Length);
                        ASCIIEncoding encoding = new ASCIIEncoding();
                        rtbDetail.Rtf = encoding.GetString(content, 0, Convert.ToInt32(bytesReceived));
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
        }

        private void LoadMesData(string chaseno)
        {
            
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            SaveData();

            string query = string.Format("update TB_FORM_PERMISSION set p_status = N'申請處理完成' where p_chaseno = '{0}'", _chaseno);
            DataService.GetInstance().ExecuteNonQuery(query);

            DialogResult = DialogResult.OK;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();

            DialogResult = DialogResult.OK;
        }

        private void SaveData()
        {
            rtbDetail.SaveFile("temp.rtf");
            FileStream stream = new FileStream("temp.rtf", FileMode.Open, FileAccess.Read);
            int size = Convert.ToInt32(stream.Length);
            Byte[] rtf = new Byte[size];
            stream.Read(rtf, 0, size);

            string query = string.Format("update TB_FORM_PERMISSION set p_detail = @Detail where p_chaseno = '{0}'", _chaseno);
            Debug.WriteLine(query);

            SqlCommand cmd = new SqlCommand(query, DataService.GetInstance().Connection);

            SqlParameter param = new SqlParameter("@Detail", SqlDbType.Image, rtf.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, rtf);
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure to delete this item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:

                    string query = string.Format("delete from TB_FORM_SUPPORT where s_chaseno = '{0}'", _chaseno);
                    DataService.GetInstance().ExecuteNonQuery(query);

                    DialogResult = DialogResult.OK;

                    break;

                case DialogResult.No:
                    break;
            }
        }
    }
}
