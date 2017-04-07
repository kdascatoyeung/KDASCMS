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
using System.Diagnostics;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.data_form
{
    public partial class DataFormComment : UserControl
    {
        string _mode = "";

        public DataFormComment(string mode)
        {
            InitializeComponent();

            _mode = mode;

            LoadData(mode);

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            dgvComment.Enabled = dgvComment.SelectedRows.Count > 0 ? true : false;
        }

        private void LoadData(string mode)
        {
            DataTable table = new DataTable();

            string query = "select DATEDIFF(day, cast(c_created as datetime), getdate()) as idle, c_chaseno as chaseno, c_item as category, c_created as created, c_applicant as applicant, c_status as st, c_handledby as handledby from TB_FORM_COMMENT";

            if (mode == "processing")
                query = query + " where c_status != N'申請處理完成'";
            else
                query = query + " where c_status = N'申請處理完成'";

            SqlDataAdapter sda = new SqlDataAdapter(query, DataService.GetInstance().Connection);
            sda.Fill(table);

            dgvComment.DataSource = table;

            GlobalService.MasterTable = table;

            if (mode != "processing")
                dgvComment.Columns[0].Visible = false;
        }

        private void dgvComment_DoubleClick(object sender, EventArgs e)
        {
            if (dgvComment.SelectedRows == null)
                return;

            string chaseno = dgvComment.SelectedRows[0].Cells[1].Value.ToString();
            PFormComment form = new PFormComment(chaseno, _mode);
            if (form.ShowDialog() == DialogResult.OK)
                LoadData(_mode);
        }

        private void dgvComment_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvComment.Rows.Count > 0)
            {
                if (((dgvComment.Rows[0].Height * dgvComment.Rows.Count) + dgvComment.ColumnHeadersHeight) < e.Location.Y)
                    dgvComment.ClearSelection();
                else
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        var hti = dgvComment.HitTest(e.X, e.Y);

                        if (dgvComment.SelectedRows.Count == 1)
                        {
                            dgvComment.ClearSelection();

                            if (((dgvComment.Rows[0].Height * dgvComment.Rows.Count) + dgvComment.ColumnHeadersHeight) >= e.Location.Y)
                                dgvComment.Rows[hti.RowIndex].Selected = true;
                        }
                        else
                        {
                            if (((dgvComment.Rows[0].Height * dgvComment.Rows.Count) + dgvComment.ColumnHeadersHeight) >= e.Location.Y)
                                dgvComment.Rows[hti.RowIndex].Selected = true;
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

                    foreach (DataGridViewRow row in dgvComment.SelectedRows)
                    {
                        string chaseno = row.Cells[1].Value.ToString().Trim();
                        string query = string.Format("delete from TB_FORM_COMMENT where c_chaseno = '{0}'", chaseno);
                        DataService.GetInstance().ExecuteNonQuery(query);
                    }

                    break;

                case DialogResult.No:
                    break;
            }
        }
    }
}
