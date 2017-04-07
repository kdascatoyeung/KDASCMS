using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using KDTHK_SYS_MAN_CONSOLE.services;
using CustomUtil.utils.authentication;
using KDTHK_SYS_MAN_CONSOLE.forms.utils;
using KDTHK_SYS_MAN_CONSOLE.utils;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms
{
    public partial class SFormAsset : UserControl
    {
        public event EventHandler SavedEvent;

        public SFormAsset()
        {
            InitializeComponent();

            DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)dgvAsset.Columns[1];
            col.DataSource = ItemColumn("Notebook");
        }

        private List<string> CategoryColumn()
        {
            List<string> list = new List<string>();

            string query = "select distinct a_category from TB_IT_ASSET";

            using (IDataReader reader = DataServiceIT.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                    list.Add(reader.GetString(0).Trim());
            }

            return list;
        }

        private List<string> ItemColumn(string category)
        {
            List<string> list = new List<string>();

            string query = string.Format("select a_name from TB_IT_ASSET where a_category = '{0}' and a_status = N'可借用'", category);

            using (IDataReader reader = DataServiceIT.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                    list.Add(reader.GetString(0).Trim());
            }

            return list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvAsset.EndEdit();

            if (!IsDataValid(dgvAsset))
            {
                MessageBox.Show("Invalid input found.");
                return;
            }

            string applicant = DataUtil.GetApplicant(GlobalService.ChaseNo);

            string head = DataUtil.GetHead(applicant);

            string approval = DataUtil.IsItemApproved(GlobalService.ChaseNo) ? "Yes" : "No";

            string chaseno = DataUtil.GetAssetChaseNo();

            string status = approval == "Yes" ? "I.T.處理中" : "上司承認中";

            foreach (DataGridViewRow row in dgvAsset.Rows)
            {
                if (row.IsNewRow) continue;

                string category = row.Cells[0].Value.ToString().Trim();
                string name = row.Cells[1].Value.ToString().Trim();
                string start = row.Cells[2].Value.ToString().Trim();
                string preReturn = row.Cells[3].Value.ToString().Trim();
                string inout = row.Cells[4].Value.ToString().Trim();
                string assigned = row.Cells[5].Value.ToString().Trim();

                string query = string.Format("insert into TB_FORM_LOANING (l_name, l_category, l_start, l_end, l_created, l_applicant, l_status, l_refno, l_approval, l_approver, l_chaseno, l_remarks, l_handledby)" +
                    " values (N'{0}', N'{1}', '{2}', '{3}', '{4}', N'{5}', N'{6}', '{7}', '{8}', N'{9}', '{10}', '{11}', N'{12}')", name, category, start, preReturn, DateTime.Today.ToString("yyyy/MM/dd"), applicant, status, GlobalService.ChaseNo, approval, head, chaseno, inout, assigned);
                DataService.GetInstance().ExecuteNonQuery(query);

                //string text = string.Format("update TB_IT_ASSET set a_status = N'借用中', a_refno = '{0}' where a_name = '{1}'", GlobalService.ChaseNo, name);
                //DataServiceIT.GetInstance().ExecuteNonQuery(text);
            }

            if (approval == "No")
            {
                string from = AdUtil.GetEmailByUsername(applicant, "kmhk.local");
                string to = AdUtil.GetEmailByUsername(head, "kmhk.local");

                EformUtil.SendApprovalEmail(GlobalService.ChaseNo, from, to, "Approval Required for 資產外借", "資產外借", applicant);
            }

            GlobalService.SavedForm = "asset";

            if (SavedEvent != null)
                SavedEvent(this, new EventArgs());
        }

        private bool IsDataValid(DataGridView dgv)
        {
            bool valid = true;

            List<string> tmplist = new List<string>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                string item = row.Cells[1].Value.ToString();
                string start = row.Cells[2].Value == null ? "" : row.Cells[2].Value.ToString();
                string preReturn = row.Cells[3].Value == null ? "" : row.Cells[3].Value.ToString();
                string inout = row.Cells[4].Value == null ? "" : row.Cells[4].Value.ToString();

                if (!tmplist.Contains(item))
                    tmplist.Add(item);
                else
                    valid = false;

                if (start == "" || preReturn == "" || inout == "")
                    valid = false;
            }

            return valid;
        }

        private void dgvAsset_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = e.Control as ComboBox;

            if (dgvAsset.CurrentCell.ColumnIndex == 0)
            {
                if (combo != null)
                {
                    //combo.SelectedIndexChanged -= new EventHandler(combo_SelectedIndexChanged);
                    combo.SelectedIndexChanged += new EventHandler(combo_SelectedIndexChanged);
                }
            }
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvAsset.CurrentCell.ColumnIndex == 0)
            {
                ComboBox cb = (ComboBox)sender;
                string item = cb.Text;
                if (item != null && item != "")
                {
                    //MessageBox.Show(item);
                    DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dgvAsset[1, dgvAsset.CurrentRow.Index];
                    cell.DataSource = ItemColumn(item);
                    //DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)dgvAsset.Columns[1];
                    //col.DataSource = ItemColumn(item);
                }
            }
        }

        private void dgvAsset_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAsset_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Debug.WriteLine(e.Context.ToString());
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
            //dgvAsset.Rows.Add("Notebook", ItemColumn("Notebook")[0], DateTime.Today.ToString("yyyy/MM/dd"), DateTime.Today.ToString("yyyy/MM/dd"), "Inside", "Yeung Wai, Gabriel (楊偉)", Properties.Resources.cross_icon);
            dgvAsset.Rows.Add("Notebook", ItemColumn("Notebook")[0], DateTime.Today.ToString("yyyy/MM/dd"), DateTime.Today.ToString("yyyy/MM/dd"), "Inside", UserUtil.ItUserName1(), Properties.Resources.cross_icon);
        }

        private void dgvAsset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                dgvAsset.Rows.Remove(dgvAsset.CurrentRow);
            }
        }

        private void dgvAsset_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }
    }
}
