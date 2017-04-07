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
    public partial class DataFormDevelop : UserControl
    {
        string _mode = "";

        public DataFormDevelop(string mode)
        {
            InitializeComponent();

            LoadData(mode);

            _mode = mode;
        }

        private void LoadData(string mode)
        {
            dgvDevelop.Rows.Clear();

            DataTable table = new DataTable();
            string[] headers = { "Idle", "ChaseNo", "Applicant", "Created", "Category", "Item", "Estimated", "Status", "Approval", "HandledBy" };
            foreach (string header in headers)
                table.Columns.Add(header);

            string query = "select d_chaseno, d_category, d_item, d_estimate, d_status, d_applicant, d_approval, d_created, d_handledby from TB_FORM_DEVELOP";

            if (mode == "processing")
                query = query + " where d_status != N'申請處理完成'";
            else
                query = query + " where d_status = N'申請處理完成'";

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string chaseno = reader.GetString(0).Trim();
                    string category = reader.GetString(1);
                    string item = reader.GetString(2);
                    string estimate = reader.GetString(3);
                    string status = reader.GetString(4);
                    string applicant = reader.GetString(5);
                    string approval = reader.GetString(6);
                    string created = reader.GetString(7);
                    string assigned = reader.GetString(8);

                    Image app = approval == "Yes" ? Properties.Resources.bullet_green24 : Properties.Resources.bullet_grey24;

                    int diff = (int)(DateTime.Today - Convert.ToDateTime(created)).TotalDays;

                    dgvDevelop.Rows.Add(diff, applicant, created, category, item, estimate, status, app, chaseno, assigned);
                    table.Rows.Add(diff, chaseno, applicant, created, category, item, estimate, status, approval, assigned);
                }
            }
            
            GlobalService.MasterTable = table;

            if (mode != "processing")
                dgvDevelop.Columns[0].Visible = false;
        }

        private void dgvDevelop_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string chaseno = dgvDevelop.SelectedRows[0].Cells[8].Value.ToString().Trim();

                PFormDevelop form = new PFormDevelop(chaseno, _mode);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadData(_mode);

            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message + ex.StackTrace);
            }
        }
    }
}
