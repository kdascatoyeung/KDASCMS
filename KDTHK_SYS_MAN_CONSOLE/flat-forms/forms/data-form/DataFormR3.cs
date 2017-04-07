using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using KDTHK_SYS_MAN_CONSOLE.services;
using KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.pop_form;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.data_form
{
    public partial class DataFormR3 : UserControl
    {
        string _mode = "";

        public DataFormR3(string mode)
        {
            InitializeComponent();

            _mode = mode;

            LoadData(mode);

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            contextMenuStrip1.Enabled = dgvR3.SelectedRows.Count > 0 ? true : false;
        }

        private void LoadData(string mode)
        {
            DataTable table = new DataTable();
            string[] headers = { "refno", "chaseno", "st", "category", "created", "applicant", "sdate", "type" };
            foreach (string header in headers)
                table.Columns.Add(header);

            string query = "select r_refno as refno, r_chaseno as chaseno, r_status as st, r_created as created, r_applicant as applicant" +
                ", r_start as sdate, r_category as category, r_type as type from TB_FORM_R3";

            if (mode == "processing")
                query = query + " where r_status != N'申請處理完成'";
            else
                query = query + " where r_status = N'申請處理完成'";

            SqlDataAdapter sda = new SqlDataAdapter(query, DataService.GetInstance().Connection);
            sda.Fill(table);

            GlobalService.MasterTable = table;

            dgvR3.DataSource = table;
        }

        private void dgvPermission_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvR3.Rows.Count > 0)
            {
                if (((dgvR3.Rows[0].Height * dgvR3.Rows.Count) + dgvR3.ColumnHeadersHeight) < e.Location.Y)
                    dgvR3.ClearSelection();
                else
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        var hti = dgvR3.HitTest(e.X, e.Y);

                        if (dgvR3.SelectedRows.Count == 1)
                        {
                            dgvR3.ClearSelection();

                            if (((dgvR3.Rows[0].Height * dgvR3.Rows.Count) + dgvR3.ColumnHeadersHeight) >= e.Location.Y)
                                dgvR3.Rows[hti.RowIndex].Selected = true;
                        }
                        else
                        {
                            if (((dgvR3.Rows[0].Height * dgvR3.Rows.Count) + dgvR3.ColumnHeadersHeight) >= e.Location.Y)
                                dgvR3.Rows[hti.RowIndex].Selected = true;
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

                    foreach (DataGridViewRow row in dgvR3.SelectedRows)
                    {
                        string chaseno = row.Cells[0].Value.ToString().Trim();
                        string query = string.Format("delete from TB_FORM_R3 where r_chaseno = '{0}'", chaseno);
                        DataService.GetInstance().ExecuteNonQuery(query);
                    }

                    LoadData(_mode);
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void dgvR3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string chaseno = dgvR3.SelectedRows[0].Cells[1].Value.ToString().Trim();

                PFormR3 form = new PFormR3(chaseno);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadData(_mode);

            }
            catch (Exception ex)
            {

            }
        }
    }
}
