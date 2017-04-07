using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.flat_forms.general;
using KDTHK_SYS_MAN_CONSOLE.services;
using CustomUtil.utils.authentication;
using KDTHK_SYS_MAN_CONSOLE.forms.utils;
using KDTHK_SYS_MAN_CONSOLE.utils;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms
{
    public partial class SFormPermission : UserControl
    {
        public event EventHandler SavedEvent;

        List<string> _itemList;

        public SFormPermission()
        {
            InitializeComponent();

            _itemList = new List<string>();

            foreach (string item in utils.DataUtil.ItemList())
                _itemList.Add(item);

            DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn)dgvPermission.Columns[0];
            column.DataSource = _itemList;

            dgvPermission.Rows.Add("MES", "", DateTime.Today.ToString("yyyy/MM/dd"), "New", "", UserUtil.ItUserName1(), Properties.Resources.cross_icon);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvPermission.Rows.Count == 0)
            {
                MessageBox.Show("No record found.");
                return;
            }

            dgvPermission.EndEdit();

            if (!IsDataValid(dgvPermission))
            {
                MessageBox.Show("Invalid input found.");
                return;
            }

            string applicant = DataUtil.GetApplicant(GlobalService.ChaseNo);

            string head = DataUtil.GetHead(applicant);
            string approval = DataUtil.IsItemApproved(GlobalService.ChaseNo) ? "Yes" : "No";
            string strApprovalDate = DataUtil.GetApprovalDate(GlobalService.ChaseNo);

            string st = approval == "Yes" ? "I.T處理中" : "上司承認中";

            string chaseno = DataUtil.GetPermissionChaseNo();

            foreach (DataGridViewRow row in dgvPermission.Rows)
            {
                if (row.IsNewRow) continue;

                string item = row.Cells[0].Value.ToString();
                string user = row.Cells[1].Value.ToString();
                string start = row.Cells[2].Value.ToString();
                string status = row.Cells[3].Value.ToString();
                string remarks = row.Cells[4].Value ==null? "": row.Cells[4].Value.ToString();
                string assigned = row.Cells[5].Value.ToString().Trim();

                //string query = string.Format("insert into TB_FORM_PERMISSION (p_type, p_user, p_item, p_created, p_createdby, p_start, p_remarks, p_chaseno, p_approver, p_approval, p_refno, p_applicant, p_status, p_handledby)" +
                //    " values ('{0}', N'{1}', N'{2}', '{3}', N'{4}', '{5}', N'{6}', '{7}', N'{8}', '{9}', '{10}', N'{11}', N'{12}', N'{13}')", status, user, item, DateTime.Today.ToString("yyyy/MM/dd"), GlobalService.Creator, start, remarks, chaseno, head, approval, GlobalService.ChaseNo, GlobalService.Creator, st, assigned);
                string query = string.Format("insert into TB_FORM_PERMISSION (p_type, p_user, p_item, p_created, p_createdby, p_start, p_remarks, p_chaseno, p_approver, p_approval, p_refno, p_applicant, p_status, p_handledby, p_itapproval, p_approvaldate)" +
                    " values ('{0}', N'{1}', N'{2}', '{3}', N'{4}', '{5}', N'{6}', '{7}', N'{8}', '{9}', '{10}', N'{11}', N'{12}', N'{13}', N'{14}', N'{15}')",
                    status, user, item, DateTime.Today.ToString("yyyy/MM/dd"), GlobalService.Creator, start, remarks, chaseno, head, approval, GlobalService.ChaseNo, GlobalService.Creator, st, assigned, UserUtil.ItManagerName(), strApprovalDate);

                DataService.GetInstance().ExecuteNonQuery(query);
            }

            GlobalService.SavedForm = "permission";

            /*if (st == "上司承認中")
            {
                string from = AdUtil.GetEmailByUserId(AdUtil.GetUserIdByUsername(GlobalService.User, "kmhk.local"), "kmhk.local");

                string to = AdUtil.GetEmailByUserId(AdUtil.GetUserIdByUsername(head, "kmhk.local"), "kmhk.local");

                string text = "IT Application Approval required. Please click <a href=\"\\\\kdthk-dm1\\project\\it system\\MyCloud Beta\\KDTHK-DM-SP.application\">HERE</a> to approval process.";
                string body = "<p><span style=\"font-family: Calibri;\">" + text + "</span></p>";
                //EformUtil.SendApprovalEmail(chaseno, from, to, body);
            }*/

            if (approval == "No")
            {
                string from = AdUtil.GetEmailByUsername(applicant, "kmhk.local");
                string to = AdUtil.GetEmailByUsername(head, "kmhk.local");

                EformUtil.SendApprovalEmail(GlobalService.ChaseNo, from, to, "Approval Required for 權限及軟件安裝", "權限及軟件安裝", applicant);
            }

            if (SavedEvent != null)
                SavedEvent(this, new EventArgs());
        }

        private bool IsDataValid(DataGridView dgv)
        {
            bool valid = true;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                string item = row.Cells[0].Value.ToString();
                string user = row.Cells[1].Value.ToString();
                string start = row.Cells[2].Value.ToString();
                string status = row.Cells[3].Value.ToString();

                if (item == "" || user == "" || start == "" || status == "")
                    valid = false;
            }

            return valid;
        }

        private void dgvPermission_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //e.Row.Cells[0].Value = "MES";
            //e.Row.Cells[2].Value = DateTime.Today.ToString("yyyy/MM/dd");
            //e.Row.Cells[3].Value = "New";
        }

        private void dgvPermission_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                UserSearchForm form = new UserSearchForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dgvPermission.CurrentCell.Value = GlobalService.SelectedUser;
                    dgvPermission.CurrentCell = dgvPermission[2, dgvPermission.CurrentRow.Index];
                }
            }
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvPermission.Rows.Add("MES", "", DateTime.Today.ToString("yyyy/MM/dd"), "New", "", UserUtil.ItUserName1(), Properties.Resources.cross_icon);
            //dgvPermission.Rows.Add("MES", "", DateTime.Today.ToString("yyyy/MM/dd"), "New", "", "Yeung Wai, Gabriel (楊偉)", Properties.Resources.cross_icon);
        }

        private void dgvPermission_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                dgvPermission.Rows.Remove(dgvPermission.CurrentRow);
            }
        }
    }
}
