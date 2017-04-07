using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.services;
using KDTHK_SYS_MAN_CONSOLE.lists;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms
{
    public partial class FormApplication : Form
    {
        string _chaseno = "";

        public FormApplication(string chaseno)
        {
            InitializeComponent();

            LoadData(chaseno);

            _chaseno = chaseno;
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LoadData(string chaseno)
        {
            string query = string.Format("select f_applicant, f_type, f_content, f_start, f_end, f_created, f_approver from TB_FORM where f_chaseno = '{0}'", chaseno);

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string applicant = reader.GetString(0).Trim();
                    string category = reader.GetString(1).Trim();
                    Byte[] content = new Byte[Convert.ToInt32((reader.GetBytes(2, 0, null, 0, Int32.MaxValue)))];
                    long bytesReceived = reader.GetBytes(2, 0, content, 0, content.Length);
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    rtbContent.Rtf = encoding.GetString(content, 0, Convert.ToInt32(bytesReceived));
                    string start = reader.GetString(3).Trim();
                    string end = reader.GetString(4).Trim();
                    string created = reader.GetString(5).Trim();
                    string approver = reader.GetString(6).Trim();

                    txtApplicant.Text = applicant;
                    txtStart.Text = start;
                    txtEnd.Text = end;
                    txtApprover.Text = approver;

                    if (category == "技術支援")
                        ckbSupport.Checked = true;

                    if (category == "意見箱")
                        ckbComment.Checked = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GlobalService.FormList = new List<FormList>();

            int support = txtSupport.Text == "" ? 0 : Convert.ToInt32(txtSupport.Text);
            int asset = txtAsset.Text == "" ? 0 : Convert.ToInt32(txtAsset.Text);
            int permission = txtPermission.Text == "" ? 0 : Convert.ToInt32(txtPermission.Text);
            int develop = txtDevelop.Text == "" ? 0 : Convert.ToInt32(txtDevelop.Text);
            int comment = txtComment.Text == "" ? 0 : Convert.ToInt32(txtComment.Text);

            if (support == 0 && asset == 0 && permission == 0 && develop == 0 && comment == 0)
            {
                MessageBox.Show("You must assign at least 1 form");
                return;
            }

            for (int i = 0; i < support; i++)
                GlobalService.FormList.Add(new FormList { ChaseNo = _chaseno, Category = "support" });

            for (int i = 0; i < asset; i++)
                GlobalService.FormList.Add(new FormList { ChaseNo = _chaseno, Category = "asset" });

            for (int i = 0; i < permission; i++)
                GlobalService.FormList.Add(new FormList { ChaseNo = _chaseno, Category = "permission" });

            for (int i = 0; i < develop; i++)
                GlobalService.FormList.Add(new FormList { ChaseNo = _chaseno, Category = "develop" });

            for (int i = 0; i < comment; i++)
                GlobalService.FormList.Add(new FormList { ChaseNo = _chaseno, Category = "comment" });
            
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
