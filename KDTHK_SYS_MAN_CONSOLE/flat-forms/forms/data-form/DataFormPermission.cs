using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.services;
using KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.pop_form;
using System.Diagnostics;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.data_form
{
    public partial class DataFormPermission : UserControl
    {
        string _mode = "";

        public DataFormPermission(string mode)
        {
            InitializeComponent();

            LoadData(mode);

            _mode = mode;

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            contextMenuStrip1.Enabled = dgvPermission.SelectedRows.Count > 0 ? true : false;
        }

        private void LoadData(string mode)
        {
            dgvPermission.Rows.Clear();

            DataTable table = new DataTable();
            string[] headers = { "Idle", "ChaseNo", "Status", "Category", "Created", "Applicant", "Start", "Type", "User", "Approval", "HandledBy" };
            foreach (string header in headers)
                table.Columns.Add(header);

            string query = "select p_chaseno, p_created, p_user, p_applicant, p_start, p_status, p_approval, p_item, p_type, p_handledby from TB_FORM_PERMISSION";

            if (mode == "processing")
                query = query + " where p_status != N'申請處理完成'";
            else
                query = query + " where p_status = N'申請處理完成'";

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string chaseno = reader.GetString(0).Trim();
                    string created = reader.GetString(1);
                    string user = reader.GetString(2);
                    string applicant = reader.GetString(3);
                    string start = reader.GetString(4);
                    string status = reader.GetString(5);
                    string approval = reader.GetString(6);
                    string item = reader.GetString(7);
                    string type = reader.GetString(8);
                    string assigned = reader.GetString(9);

                    int diff = (int)(DateTime.Today - Convert.ToDateTime(created)).TotalDays;

                    Image app = approval == "Yes" ? Properties.Resources.bullet_green24 : Properties.Resources.bullet_grey24;

                    dgvPermission.Rows.Add(diff, chaseno, status, item, created, applicant, start, type, user, app, assigned);
                    table.Rows.Add(diff, chaseno, status, item, created, applicant, start, type, user, approval, assigned);
                }
            }

            GlobalService.MasterTable = table;

            if (mode != "processing")
                dgvPermission.Columns[0].Visible = false;
        }

        private void dgvPermission_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPermission.SelectedRows == null)
                return;

            try
            {
                string category = dgvPermission.SelectedRows[0].Cells[3].Value.ToString();
                string chaseno = dgvPermission.SelectedRows[0].Cells[1].Value.ToString();

                PFormPermission form = new PFormPermission(chaseno, category);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData(_mode);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + ex.StackTrace);
            }
        }

        private void dgvPermission_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvPermission.Rows.Count > 0)
            {
                if (((dgvPermission.Rows[0].Height * dgvPermission.Rows.Count) + dgvPermission.ColumnHeadersHeight) < e.Location.Y)
                    dgvPermission.ClearSelection();
                else
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        var hti = dgvPermission.HitTest(e.X, e.Y);

                        if (dgvPermission.SelectedRows.Count == 1)
                        {
                            dgvPermission.ClearSelection();

                            if (((dgvPermission.Rows[0].Height * dgvPermission.Rows.Count) + dgvPermission.ColumnHeadersHeight) >= e.Location.Y)
                                dgvPermission.Rows[hti.RowIndex].Selected = true;
                        }
                        else
                        {
                            if (((dgvPermission.Rows[0].Height * dgvPermission.Rows.Count) + dgvPermission.ColumnHeadersHeight) >= e.Location.Y)
                                dgvPermission.Rows[hti.RowIndex].Selected = true;
                        }
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure to delete selected item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:

                    foreach (DataGridViewRow row in dgvPermission.SelectedRows)
                    {
                        string chaseno = row.Cells[1].Value.ToString().Trim();
                        string query = string.Format("delete from TB_FORM_PERMISSION where p_chaseno = '{0}'", chaseno);
                        Debug.WriteLine(query);
                        DataService.GetInstance().ExecuteNonQuery(query);
                    }

                    break;

                case DialogResult.No:
                    break;
            }
        }
    }
}
