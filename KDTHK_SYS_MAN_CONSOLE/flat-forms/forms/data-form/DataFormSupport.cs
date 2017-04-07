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
    public partial class DataFormSupport : UserControl
    {
        public event EventHandler ChangedEvent;

        string _mode = "";

        public DataFormSupport(string mode)
        {
            InitializeComponent();

            LoadData(mode, "");

            _mode = mode;

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            contextMenuStrip1.Enabled = dgvSupport.SelectedRows.Count > 0 ? true : false;

            label1.Text = "Row count: " + advancedDataGridView1.Rows.Count;
        }

        private void LoadData(string mode, string source)
        {
            DataTable table = new DataTable();
            string[] headers = { "idle", "chaseno", "st", "category", "created", "applicant", "title", "sdate", "edate", "handledby" };
            foreach (string header in headers)
                table.Columns.Add(header);

            string query = string.Format("select DATEDIFF(day, cast(s_created as datetime), getdate()) as idle, s_chaseno as chaseno, s_category as category, s_start as sdate, s_end as edate, s_status as st, s_created as created, f_applicant as applicant, f_title as title, s_handledby as handledby" +
                " from TB_FORM, TB_FORM_SUPPORT where s_refno = f_chaseno and (s_created like N'%{0}%' or f_title like N'%{0}%' or f_applicant like N'%{0}%')", source);

            if (mode == "processing")
                query = query + " and s_status != N'申請處理完成'";
            else
                query = query + " and s_status = N'申請處理完成'";

            SqlDataAdapter sda = new SqlDataAdapter(query, DataService.GetInstance().Connection);
            sda.Fill(table);

            table.DefaultView.Sort = "st asc, category asc, created asc";

            bindingSource1.DataSource = table;

            //dgvSupport.DataSource = table;

            GlobalService.MasterTable = table;

            label1.Text = "Row Count : " + advancedDataGridView1.Rows.Count;

            if (mode != "processing")
            {
                advancedDataGridView1.Columns[0].Visible = false;
            }
        }

        private void dgvSupport_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSupport.Rows.Count == 0)
                return;

            try
            {
                string chaseno = dgvSupport.SelectedRows[0].Cells[1].Value.ToString();
                //Debug.WriteLine(chaseno);

                PFormSupport form = new PFormSupport(chaseno, _mode);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData(_mode, txtFilter.Text);

                    if (ChangedEvent != null)
                        ChangedEvent(this, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + ex.StackTrace);
            }
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData(_mode, txtFilter.Text);
            }
        }

        private void dgvSupport_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvSupport.Rows.Count > 0)
            {
                if (((dgvSupport.Rows[0].Height * dgvSupport.Rows.Count) + dgvSupport.ColumnHeadersHeight) < e.Location.Y)
                    dgvSupport.ClearSelection();
                else
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        var hti = dgvSupport.HitTest(e.X, e.Y);

                        if (dgvSupport.SelectedRows.Count == 1)
                        {
                            dgvSupport.ClearSelection();

                            if (((dgvSupport.Rows[0].Height * dgvSupport.Rows.Count) + dgvSupport.ColumnHeadersHeight) >= e.Location.Y)
                                dgvSupport.Rows[hti.RowIndex].Selected = true;
                        }
                        else
                        {
                            if (((dgvSupport.Rows[0].Height * dgvSupport.Rows.Count) + dgvSupport.ColumnHeadersHeight) >= e.Location.Y)
                                dgvSupport.Rows[hti.RowIndex].Selected = true;
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

                    foreach(DataGridViewRow row in dgvSupport.SelectedRows)
                    {
                        string chaseno = row.Cells[1].Value.ToString().Trim();
                        string query = string.Format("delete from TB_FORM_SUPPORT where s_chaseno = '{0}'", chaseno);
                        DataService.GetInstance().ExecuteNonQuery(query);
                    }
                    
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            bindingSource1.Filter = advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            bindingSource1.Sort = advancedDataGridView1.SortString;
        }

        private void advancedDataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (advancedDataGridView1.Rows.Count == 0)
                return;

            try
            {
                string chaseno = advancedDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                //Debug.WriteLine(chaseno);

                PFormSupport form = new PFormSupport(chaseno, _mode);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData(_mode, txtFilter.Text);

                    if (ChangedEvent != null)
                        ChangedEvent(this, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + ex.StackTrace);
            }
        }

        private void advancedDataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (advancedDataGridView1.Rows.Count > 0)
            {
                if (((advancedDataGridView1.Rows[0].Height * advancedDataGridView1.Rows.Count) + advancedDataGridView1.ColumnHeadersHeight) < e.Location.Y)
                    advancedDataGridView1.ClearSelection();
                else
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        var hti = advancedDataGridView1.HitTest(e.X, e.Y);

                        if (advancedDataGridView1.SelectedRows.Count == 1)
                        {
                            advancedDataGridView1.ClearSelection();

                            if (((advancedDataGridView1.Rows[0].Height * advancedDataGridView1.Rows.Count) + advancedDataGridView1.ColumnHeadersHeight) >= e.Location.Y)
                                advancedDataGridView1.Rows[hti.RowIndex].Selected = true;
                        }
                        else
                        {
                            if (((advancedDataGridView1.Rows[0].Height * advancedDataGridView1.Rows.Count) + advancedDataGridView1.ColumnHeadersHeight) >= e.Location.Y)
                                advancedDataGridView1.Rows[hti.RowIndex].Selected = true;
                        }
                    }
                }
            }
        }
    }
}
