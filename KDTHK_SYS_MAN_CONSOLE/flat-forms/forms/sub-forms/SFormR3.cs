using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.services;
using KDTHK_SYS_MAN_CONSOLE.forms.utils;
using Common;
using System.IO;
using KDTHK_SYS_MAN_CONSOLE.flat_forms.general;
using KDTHK_SYS_MAN_CONSOLE.utils;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms
{
    public partial class SFormR3 : UserControl
    {
        public event EventHandler SavedEvent;

        public SFormR3()
        {
            InitializeComponent();

            cbCategory.SelectedIndex = 0;
            cbR3Category.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;

            txtCmApprover.Text = "Hara Masatoshi(原雅俊)";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = cbCategory.Text + " " + cbR3Category.Text;
            string startdate = dtpStart.Value.ToString("yyyy/MM/dd");
            string comment = txtComment.Text.Trim();
            string attachment = txtAttachment.Text.Trim();
            string category = cbCategory.Text.Trim();
            string r3Category = cbR3Category.Text.Trim();

            string status = cbStatus.Text == "Completed" ? "經管承認中" : "IT處理中";

            string applicant = DataUtil.GetApplicant(GlobalService.ChaseNo);
            string head = DataUtil.GetHead(applicant);

            string chaseno = DataUtil.GetR3Chaseno();

            string cmApprover = txtCmApprover.Text.Trim();
            //string itApprover = "Chan Fai Lung(陳輝龍,Onyx)";
            string itApprover =  UserUtil.ItUserName2();

            if (cbStatus.Text == "Cancel")
            {
                string query = string.Format("delete from TB_FORM where f_chaseno = '{0}'", GlobalService.ChaseNo);
                DataService.GetInstance().ExecuteNonQuery(query);
            }
            else
            {
                string filePath = "";

                if (attachment != "")
                {
                    string filename = Path.GetFileName(attachment);
                    string directory = @"\\kdthk-dm1\project\kdthk-dm\Forms\R3 Application\IT Attachments\";

                    if (!Directory.Exists(directory))
                        Directory.CreateDirectory(directory);

                    File.Copy(attachment, directory + filename, true);

                    filePath = directory + filename;
                }

                string query = string.Format("insert into TB_FORM_R3 (r_chaseno, r_status, r_applicant, r_created, r_title, r_category, r_type, r_content, r_start" +
                    ", r_approver, r_approval, r_cmapprover, r_cmapproval, r_itapprover, r_itapproval, r_itattachment, r_itcomment, r_refno) values ('{0}', N'{1}', N'{2}'" +
                    ", '{3}', N'{4}', N'{5}', '{6}', N'{7}', '{8}', N'{9}', '{10}', N'{11}', '{12}', N'{13}', N'{14}', N'{15}', N'{16}', '{17}')", chaseno, status, applicant, DateTime.Today.ToString("yyyy/MM/dd"),
                    title, category, r3Category, "", startdate, head, "Yes", cmApprover, "No", itApprover, "Yes", filePath, comment, GlobalService.ChaseNo);

                DataService.GetInstance().ExecuteNonQuery(query);

                string from = AdUtil.GetEmailByUserId(AdUtil.GetUserIdByUsername(GlobalService.User));

                string to = AdUtil.GetEmailByUserId(AdUtil.GetUserIdByUsername(cmApprover));

                EformUtil.SendR3ApprovalEmail(title, comment, filePath, "", from, to, GlobalService.User);
            }

            if (SavedEvent != null)
                SavedEvent(this, new EventArgs());
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            BrowseFile();
        }

        private void txtAttachment_DoubleClick(object sender, EventArgs e)
        {
            BrowseFile();
        }

        private void BrowseFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtAttachment.Text = ofd.FileName;
            }
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCmApprover_DoubleClick(object sender, EventArgs e)
        {
            UserSearchForm form = new UserSearchForm();
            if (form.ShowDialog() == DialogResult.OK)
                txtCmApprover.Text = GlobalService.SelectedUser;
        }
    }
}
