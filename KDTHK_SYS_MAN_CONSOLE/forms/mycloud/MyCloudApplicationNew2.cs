using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CustomUtil.utils.authentication;
using KDTHK_SYS_MAN_CONSOLE.services;

namespace KDTHK_SYS_MAN_CONSOLE.forms.mycloud
{
    public partial class MyCloudApplicationNew2 : UserControl
    {
        public MyCloudApplicationNew2()
        {
            InitializeComponent();
        }

        private void txtDirectory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtDirectory_DoubleClick(object sender, EventArgs e)
        {
            txtDirectory.Text = SelectedDirectory();

            if (txtDirectory.Text != "")
                txtName.Text = FileName(txtDirectory.Text);
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            txtDirectory.Text = SelectedDirectory();

            if (txtDirectory.Text != "")
                txtName.Text = FileName(txtDirectory.Text);
        }

        private string SelectedDirectory()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            string directory = "";

            if (ofd.ShowDialog() == DialogResult.OK)
                directory = ofd.FileName;
            else
                directory = txtDirectory.Text;

            return directory;
        }

        private string FileName(string filePath)
        {
            return Path.GetFileNameWithoutExtension(filePath);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStaff();
        }

        private void AddStaff()
        {
            string staffName = StaffName(txtStaffId.Text);

            if (staffName == "")
            {
                MessageBox.Show("Invalid Staff Id.");
                return;
            }

            lbStaff.Items.Add(staffName);
        }

        private string StaffName(string staffId)
        {
            try
            {
                return AdUtil.getUsernameByUserId(staffId.Trim(), "kmhk.local");
            }
            catch
            {
                return "";
            }
        }

        private void txtStaffId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddStaff();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string category = rbtnApplication.Checked? "Application"
                :rbtnTools.Checked?"Tools"
                :rbtnForms.Checked?"Forms":"Others";
            string directory = txtDirectory.Text.Trim();
            string name = txtName.Text.Trim();
            string description = txtDesc.Text.Trim();
            string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            foreach (string item in lbStaff.Items)
            {
                string staff = item.Trim();

                string query = string.Format("insert into TB_APPLICATION (f_category, f_staff, f_name, f_path, f_description, f_lastaccess) values" +
                    " ('{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}')", category, staff, name, directory, description, now);

                DataServiceMyCloud.GetInstance().ExecuteNonQuery(query);
            }
        }
    }
}
