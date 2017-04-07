using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomUtil.utils.authentication;
using KDTHK_SYS_MAN_CONSOLE.utils;
using KDTHK_SYS_MAN_CONSOLE.services;

namespace KDTHK_SYS_MAN_CONSOLE.forms.education
{
    public partial class EducationStaffNew : Form
    {
        public EducationStaffNew()
        {
            InitializeComponent();
        }

        private void txtStaffId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    lblUsername.Text = GetUsername(txtStaffId.Text);
                    lblCompany.Text = txtStaffId.Text.StartsWith("hk") || txtStaffId.Text.StartsWith("HK") ? "KDTHK"
                        : txtStaffId.Text.StartsWith("as") || txtStaffId.Text.StartsWith("AS") ? "KDAS"
                        : txtStaffId.Text.StartsWith("cn") ? "KDTCN" : "KDHK";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Staff Id");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EducationUtil.IsUserExists(txtStaffId.Text))
            {
                MessageBox.Show("User already exists.");
                return;
            }

            string staffId = txtStaffId.Text;
            string userName = lblUsername.Text;
            string company = lblCompany.Text;

            string query = string.Format("insert into TB_STAFF (st_staffid, st_name, st_company)" +
                " values ('{0}', N'{1}', '{2}')", staffId, userName, company);

            DataServiceEducation.GetInstance().ExecuteNonQuery(query);

            MessageBox.Show("Record has been saved.");

            this.DialogResult = DialogResult.OK;
        }

        private string GetUsername(string staffid)
        {
            string id = staffid.ToLower();

            string domain = id.StartsWith("hk") ? "kmhk.local"
                : id.StartsWith("cn") ? "kmcn.local" : "kmas.local";

            return AdUtil.getUsernameByUserId(staffid, domain);
        }
    }
}
