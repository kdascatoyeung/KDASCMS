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

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.data_form
{
    public partial class DataFormAsset : UserControl
    {
        public event EventHandler ReloadEvent;

        string _mode = "";

        public DataFormAsset(string mode)
        {
            InitializeComponent();

            _mode = mode;

            LoadData(mode);

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            contextMenuStrip1.Enabled = dgvAsset.SelectedRows.Count > 0 ? true : false;
        }

        private void LoadData(string mode)
        {
            dgvAsset.Rows.Clear();

            string query = "select l_applicant, l_created, l_category, l_start, l_end, l_name, l_approval, l_chaseno, l_remarks, l_status, l_handledby from TB_FORM_LOANING";

            if (mode == "processing")
                query = query + " where l_status != N'申請處理完成'";
            else
                query = query + " where l_status = N'申請處理完成'";

            List<AssetList> list = new List<AssetList>();

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string applicant = reader.GetString(0).Trim();
                    string created = reader.GetString(1).Trim();
                    string category = reader.GetString(2).Trim();
                    string start = reader.GetString(3).Trim();
                    string end = reader.GetString(4).Trim();
                    string name = reader.GetString(5).Trim();
                    string approval = reader.GetString(6).Trim();
                    string chaseno = reader.GetString(7).Trim();
                    string remarks = reader.GetString(8).Trim();
                    string status = reader.GetString(9).Trim();
                    string assigned = reader.GetString(10).Trim();

                    list.Add(new AssetList { Applicant = applicant, Created = created, Category = category, Start = start, End = end, Device = name, Approval = approval, ChaseNo = chaseno, Remarks = remarks, Status = status, HandledBy = assigned});
                }
            }

            foreach (AssetList item in list)
            {
                Image app = item.Approval == "Yes" ? Properties.Resources.bullet_green24 : Properties.Resources.bullet_grey24;

                //string status = DataUtil.GetDeviceStatus(item.Device);

                //string text = status == "借用中" ? "Return" : "Out";

                int diff = (int)(DateTime.Today - Convert.ToDateTime(item.Created)).TotalDays;

                dgvAsset.Rows.Add(diff, item.ChaseNo, item.Status, item.Category, item.Created, item.Applicant, item.Start, item.End, item.Device, item.Remarks, app, "Return", item.HandledBy);
                //dgvAsset.Rows.Add(item.ChaseNo, item.Applicant, item.Created, item.Category, item.Start, item.End, item.Device, app, "Return");
            }

            if (_mode == "completed")
            {
                dgvAsset.Columns[0].Visible = false;
                dgvAsset.Columns[11].Visible = false;
            }
        }

        private void LoadLoaningData()
        {
            string query = "select l_refno, l_name, l_category, l_start, l_end, l_approval, l_user, l_created from TB_FORM_LOANING where l_status = N'借用中'";

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string chaseno = reader.GetString(0).Trim();
                    string device = reader.GetString(1).Trim();
                    string category = reader.GetString(2).Trim();
                    string start = reader.GetString(3);
                    string end = reader.GetString(4);
                    //string 
                }
            }
        }

        private void dgvAsset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                string device = dgvAsset.CurrentRow.Cells[8].Value.ToString().Trim();
  
                string query = string.Format("update TB_IT_ASSET set a_status = N'可借用' where a_name = '{0}'", device);
                DataServiceIT.GetInstance().ExecuteNonQuery(query);

                string chaseno = dgvAsset.CurrentRow.Cells[1].Value.ToString().Trim();

                string query1 = string.Format("update TB_FORM_LOANING set l_status = N'申請處理完成' where l_chaseno = '{0}'", chaseno);
                DataService.GetInstance().ExecuteNonQuery(query1);

                LoadData(_mode);

                if (ReloadEvent != null)
                    ReloadEvent(this, new EventArgs());
            }
        }

        private void dgvAsset_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvAsset.Rows.Count > 0)
            {
                if (((dgvAsset.Rows[0].Height * dgvAsset.Rows.Count) + dgvAsset.ColumnHeadersHeight) < e.Location.Y)
                    dgvAsset.ClearSelection();
                else
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        var hti = dgvAsset.HitTest(e.X, e.Y);

                        if (dgvAsset.SelectedRows.Count == 1)
                        {
                            dgvAsset.ClearSelection();

                            if (((dgvAsset.Rows[0].Height * dgvAsset.Rows.Count) + dgvAsset.ColumnHeadersHeight) >= e.Location.Y)
                                dgvAsset.Rows[hti.RowIndex].Selected = true;
                        }
                        else
                        {
                            if (((dgvAsset.Rows[0].Height * dgvAsset.Rows.Count) + dgvAsset.ColumnHeadersHeight) >= e.Location.Y)
                                dgvAsset.Rows[hti.RowIndex].Selected = true;
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

                    foreach (DataGridViewRow row in dgvAsset.SelectedRows)
                    {
                        string chaseno = row.Cells[1].Value.ToString().Trim();
                        string query = string.Format("delete from TB_FORM_LOANING where l_chaseno = '{0}'", chaseno);
                        DataService.GetInstance().ExecuteNonQuery(query);
                    }

                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void dgvAsset_DoubleClick(object sender, EventArgs e)
        {
            string chaseno = dgvAsset.SelectedRows[0].Cells[1].Value.ToString().Trim();

            PFormAsset asset = new PFormAsset(chaseno);
            asset.ShowDialog();

        }
    }

    public class AssetList
    {
        public string Applicant { get; set; }
        public string Created { get; set; }
        public string Category { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Device { get; set; }
        public string Approval { get; set; }
        public string ChaseNo { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public string HandledBy { get; set; }
    }
}
