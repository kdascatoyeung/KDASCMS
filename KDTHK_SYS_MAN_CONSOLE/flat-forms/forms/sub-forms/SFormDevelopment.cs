using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using KDTHK_SYS_MAN_CONSOLE.services;
using System.Data.SqlClient;
using CustomUtil.utils.authentication;
using KDTHK_SYS_MAN_CONSOLE.forms.utils;
using System.Diagnostics;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms
{
    public partial class SFormDevelopment : UserControl
    {
        public event EventHandler SavedEvent;

        List<AttachmentList> _attachList = new List<AttachmentList>();

        public SFormDevelopment()
        {
            InitializeComponent();

            cbCategory.SelectedIndex = 0;

            cbItem.SelectedIndex = 0;

            cbStatus.SelectedIndex = 0;

            dtpComplete.Value = DateTime.Today.AddDays(7);

            foreach (string item in GlobalService.ITList)
                cbAssign.Items.Add(item.Trim());

            cbAssign.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string category = cbCategory.SelectedItem.ToString();
            string item = cbItem.SelectedItem.ToString();
            string date = dtpComplete.Value.ToString("yyyy/MM/dd");
            string status = cbStatus.SelectedItem.ToString();

            string assigned = cbAssign.SelectedItem.ToString().Trim();

            rtbRemarks.SaveFile("temp.rtf");
            FileStream stream = new FileStream("temp.rtf", FileMode.Open, FileAccess.Read);
            int size = Convert.ToInt32(stream.Length);
            Byte[] rtf = new Byte[size];
            stream.Read(rtf, 0, size);

            string applicant = DataUtil.GetApplicant(GlobalService.ChaseNo);

            string head = DataUtil.GetHead(applicant);
            string approval = DataUtil.IsItemApproved(GlobalService.ChaseNo) ? "Yes" : "No";

            string chaseno = DataUtil.GetDevelopChaseNo();

            string st = approval == "Yes" ? "I.T處理中" : "上司承認中";//status == "Completed" ? "申請處理完成" : status == "Processing" ? "I.T.處理中" : "取消";

            string query = string.Format("if not exists (select * from TB_FORM_DEVELOP where d_chaseno = '{0}') insert into TB_FORM_DEVELOP (d_chaseno, d_category, d_item, d_estimate, d_status, d_remarks, d_applicant, d_approver, d_approval, d_refno, d_created, d_handledby)" +
                " values ('{0}', '{1}', N'{2}', '{3}', N'{4}', @Remarks, N'{5}', N'{6}', '{7}', '{8}', '{9}', N'{10}') else update TB_FORM_DEVELOP set d_category = '{1}', d_item = N'{2}', d_estimate = '{3}', d_status = N'{4}', d_remarks = @Remarks where d_chaseno = '{0}'", chaseno, category, item, date, st, applicant, head, approval, GlobalService.ChaseNo, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), assigned);

            SqlCommand cmd = new SqlCommand(query, DataService.GetInstance().Connection);

            SqlParameter param = new SqlParameter("@Remarks", SqlDbType.Image, rtf.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, rtf);
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();

            GlobalService.SavedForm = "develop";

            if (approval == "No")
            {
                string from = AdUtil.GetEmailByUsername(applicant, "kmhk.local");
                string to = AdUtil.GetEmailByUsername(head, "kmhk.local");

                string[] attachments = _attachList.Select(x => x.FilePath).ToArray();

                EformUtil.SendApprovalEmailWithAttachment(GlobalService.ChaseNo, from, to, "Approval Required for 工具開發/修改", "工具開發/修改", applicant, attachments);
                //EformUtil.SendApprovalEmail(GlobalService.ChaseNo, from, to, "Approval Required for 權限及軟件安裝", "權限及軟件安裝", applicant);
            }

            if (SavedEvent != null)
                SavedEvent(this, new EventArgs());
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] filenames = ofd.FileNames;

                foreach (string file in filenames)
                {
                    string filename = Path.GetFileName(file);
                    string filepath = file;

                    _attachList.Add(new AttachmentList { Filename = filename, FilePath = filepath });
                }
            }

            lbAttachment.Items.Clear();

            foreach (AttachmentList item in _attachList)
                lbAttachment.Items.Add(item.Filename);
        }

        private void lbAttachment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = lbAttachment.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    Debug.WriteLine(lbAttachment.SelectedItems[i].ToString());
                    _attachList.RemoveAll(x => x.Filename == lbAttachment.SelectedItems[i]);

                    lbAttachment.Items.RemoveAt(lbAttachment.SelectedIndices[i]);
                    
                }

                foreach (string item in lbAttachment.SelectedItems)
                {
                    lbAttachment.Items.Remove(item);

                    
                }
            }
        }
    }

    public class AttachmentList
    {
        public string Filename { get; set; }

        public string FilePath { get; set; }
    }
}
