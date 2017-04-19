using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms;
using KDTHK_SYS_MAN_CONSOLE.services;
using KDTHK_SYS_MAN_CONSOLE.lists;
using System.Diagnostics;
using CustomUtil.utils.buffer;
using KDTHK_SYS_MAN_CONSOLE.forms.utils;
using KDTHK_SYS_MAN_CONSOLE.utils;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms
{
    public partial class FormOverview : UserControl
    {
        public event EventHandler DetailEvent;

        string _mode = "";

        DataTable tb1;
        DataTable tb2;

        public FormOverview()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvOverview, true);

            DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)dgvOverview.Columns[12];
            if (col.Items.Count == 0)
            {
                col.Items.Add("---");
                col.Items.Add(UserUtil.ItUserName1());
                col.Items.Add(UserUtil.ItUserName2());
                col.Items.Add(UserUtil.ItUserName3());
                col.Items.Add(UserUtil.ItUserName5());
            } 
            
            LoadData("");
        }

        private void LoadData(string mode)
        {
            dgvOverview.Rows.Clear();

            string query = mode == "" ? "select f_chaseno, f_type, f_created, f_start, f_end, f_approval, f_applicant, f_title, f_status, f_handleby from TB_FORM where f_status != N'申請處理完成' and f_status != N'上司已拒絕' order by f_created desc"
                : "select f_chaseno, f_type, f_created, f_start, f_end, f_approval, f_applicant, f_title, f_status, f_handleby from TB_FORM order by f_created desc";

            tb1 = new DataTable();
            tb2 = new DataTable();
            string[] headers = { "idle", "chaseno", "st", "type", "created", "applicant", "title", "start", "end", "approval" };
            foreach (string header in headers)
            {
                tb1.Columns.Add(header);
                tb2.Columns.Add(header);
            }
            tb1.Columns.Add("app", typeof(Image));
            tb2.Columns.Add("app", typeof(Image));
            tb1.Columns.Add("handle", typeof(string));
            tb2.Columns.Add("handle", typeof(string));

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string chaseno = reader.GetString(0).Trim();
                    string category = reader.GetString(1).Trim();
                    string created = Convert.ToDateTime(reader.GetString(2).Trim()).ToString("yyyy/MM/dd");
                    string start = reader.GetString(3).Trim();
                    string end = reader.GetString(4).Trim();
                    string approval = reader.GetString(5).Trim();
                    string applicant = reader.GetString(6).Trim();
                    string title = reader.GetString(7).Trim();
                    string status = reader.GetString(8).Trim();
                    string handleby = reader.GetString(9).Trim();

                    int diff = (int)(DateTime.Today - Convert.ToDateTime(created)).TotalDays;

                    //if (diff != 0) diff += 1;

                    string dt = Convert.ToDateTime(created).ToString("yyyy/MM/dd");

                    Image app = approval == "---" && (category == "IT技術支援" || category == "IT意見箱") ? Properties.Resources.bullet_grey24
                        : approval == "---" && category != "IT技術支援" && category != "IT意見箱" ? Properties.Resources.bullet_yellow24
                        : approval == "Reject" ? Properties.Resources.bullet_red24 : Properties.Resources.bullet_green24;

                    //tb1.Rows.Add(diff, chaseno, status, category, created, applicant, title, start, end, approval, app);

                    if (diff == 0)
                        tb1.Rows.Add(diff, chaseno, status, category, dt, applicant, title, start, end, approval, app, handleby);
                    else
                        tb2.Rows.Add(diff, chaseno, status, category, dt, applicant, title, start, end, approval, app, handleby);

                    //dgvOverview.Rows.Add(diff,"",  category, title, applicant, dt, start, end, app, chaseno, approval);
                }
            }

            /*string r3Text = "select r_chaseno, r_created, r_start, r_title, r_applicant, r_approval, r_status from TB_FORM_R3 where r_status != N'申請處理完成' and r_status != N'經管承認中' and r_status != N'經管已拒絕'";
            using (IDataReader reader = DataService.GetInstance().ExecuteReader(r3Text))
            {
                while (reader.Read())
                {
                    string chaseno = reader.GetString(0).Trim();
                    string created = reader.GetString(1);
                    string start = reader.GetString(2);
                    string title = reader.GetString(3);
                    string applicant = reader.GetString(4);
                    string approval = reader.GetString(5);
                    string status = reader.GetString(6);

                    int diff = (int)(DateTime.Today - Convert.ToDateTime(created)).TotalDays;

                    //if (diff != 0) diff += 1;

                    string dt = Convert.ToDateTime(created).ToString("yyyy/MM/dd");

                    Image app = approval == "Yes" ? Properties.Resources.bullet_green24
                        : approval == "No" ? Properties.Resources.bullet_yellow24 : Properties.Resources.bullet_red24;

                    if (diff == 0)
                        tb1.Rows.Add(diff, chaseno, status, "R3申請", dt, applicant, title, start, "-", approval, app, Properties.Resources.tick_icon);
                    else
                        tb2.Rows.Add(diff, chaseno, status, "R3申請", dt, applicant, title, start, "-", approval, app, Properties.Resources.tick_icon);
                }
            }*/

            foreach (DataRow row in tb1.Rows)
                dgvOverview.Rows.Add(row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), row.ItemArray[4].ToString(),
                    row.ItemArray[5].ToString(), ExtUtil.GetExt(row.ItemArray[5].ToString().Trim()), row.ItemArray[6].ToString(), row.ItemArray[7].ToString(), row.ItemArray[8].ToString(), row.ItemArray[10], row.ItemArray[9], row.ItemArray[11]);

            if (tb2.Rows.Count > 0)
            {
                tb2 = tb2.AsEnumerable().OrderByDescending(x => x.ItemArray[0]).CopyToDataTable();

                foreach (DataRow row in tb2.Rows)
                    dgvOverview.Rows.Add(row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), row.ItemArray[4].ToString(),
                        row.ItemArray[5].ToString(), ExtUtil.GetExt(row.ItemArray[5].ToString().Trim()), row.ItemArray[6].ToString(), row.ItemArray[7].ToString(), row.ItemArray[8].ToString(), row.ItemArray[10], row.ItemArray[9], row.ItemArray[11]);
            }
        }

        private void dgvOverview_DoubleClick(object sender, EventArgs e)
        {
            if (dgvOverview.SelectedRows == null)
                return;

            string category = dgvOverview.SelectedRows[0].Cells[3].Value.ToString().Trim();
            string approval = dgvOverview.SelectedRows[0].Cells[10].Value.ToString();

            /*if (approval != "Approve" && category != "IT技術支援" && category != "IT意見箱")
            {
                MessageBox.Show("Form is not approved.");
                return;
            }*/

            GlobalService.FormList = new List<FormList>();

            GlobalService.ChaseNo = dgvOverview.SelectedRows[0].Cells[1].Value.ToString();
            GlobalService.Creator = dgvOverview.SelectedRows[0].Cells[5].Value.ToString();

            if (category.StartsWith("R3"))
            {
                FormR3 form = new FormR3(GlobalService.ChaseNo);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadData(_mode);
            }
            else
            {
                FormITUsage2 form = new FormITUsage2(GlobalService.ChaseNo);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData(_mode);
                }
            }
            /*FormApplication form = new FormApplication(GlobalService.ChaseNo);
            form.ShowDialog();

            if (GlobalService.FormList.Count > 0)
            {
                FormITUsage ituse = new FormITUsage(GlobalService.FormList);
                if (ituse.ShowDialog() == DialogResult.OK)
                {

                }
            }*/
        }

        private void dgvOverview_DataError(object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e)
        {
            //For erasing DefaultErrorDialog 
        }


        private void ckbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAll.Checked)
            {
                _mode = "all";
                LoadData(_mode);
            }
            else
            {
                _mode = "";
                LoadData(_mode);
            }
        }

        private void dgvOverview_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dgvOverview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvOverview_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox cb = e.Control as ComboBox;

            if (cb != null)
            {
                cb.SelectedIndexChanged -= new EventHandler(cb_SelectedIndexChanged);
                cb.SelectedIndexChanged += new EventHandler(cb_SelectedIndexChanged);
            }
        }

        void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string chaseno = dgvOverview.CurrentRow.Cells[1].Value.ToString().Trim();

                string selected = ((ComboBox)sender).SelectedItem.ToString().Trim();

                string query = string.Format("update TB_FORM set f_handleby = N'{0}' where f_chaseno = '{1}'", selected, chaseno);
                Debug.WriteLine(query);
                DataService.GetInstance().ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + ex.StackTrace);
                MessageBox.Show("Error occurs.");
            }
        }

        private void dgvOverview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }


    }
}
