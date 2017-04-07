using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomUtil.utils.authentication;
using CustomUtil.utils.export;
using KDTHK_SYS_MAN_CONSOLE.utils;
using System.IO;
using CustomUtil.utils.buffer;
using System.Security.AccessControl;
using System.Data.SqlClient;
using KDTHK_SYS_MAN_CONSOLE.services;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.disc
{
    public partial class DiscIdle : UserControl
    {
        DataTable _table = null;

        public DiscIdle()
        {
            InitializeComponent();

            _table = new DataTable();

            BufferUtil.DoubleBuffered(dgvTotal, true);

            LoadIdle("");

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {

        }

        private void LoadIdle(string search)
        {
            DataTable table = new DataTable();

            string[] headers = { "lastaccess", "filename", "owner", "path", "st", "disc", "pathcopy" };
            foreach (string header in headers)
                table.Columns.Add(header);

            string query = string.Format("select di_lastaccess as lastaccess, di_filename as filename, di_user as owner, di_path as path, di_status as st, di_disc as disc, di_pathcopy as pathcopy" +
                " from TB_DISC_IDLE where di_filename like N'%{0}%' or di_user like N'%{0}%' or di_path like N'%{0}%'", search);

            SqlDataAdapter sda = new SqlDataAdapter(query, DataService.GetInstance().Connection);
            sda.Fill(table);

            dgvProcessing.DataSource = table;
        }

        private void LoadData()
        {
            List<string> tableList = new List<string>();

            string query = "select table_name from information_schema.tables where table_name like 'TB_hk%'";

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                    tableList.Add(reader.GetString(0).Trim());
            }

            tableList = tableList.Distinct().ToList();

            DataTable table = new DataTable();
            string[] headers = { "lastaccess", "filename", "owner", "path", "st", "disc" };
            foreach (string header in headers)
                table.Columns.Add(header);

            table.Columns.Add("check", typeof(string));

            table.Columns["check"].DefaultValue = "-";

            int range = 9;

            List<string> idleFileList = new List<string>();
            string q2 = "select di_path from TB_DISC_IDLE";
            using (IDataReader reader = DataService.GetInstance().ExecuteReader(q2))
            {
                while (reader.Read())
                    idleFileList.Add(reader.GetString(0).Trim());
            }

            foreach (string t in tableList)
            {
                string staffid = t.Substring(3);
                string staff = AdUtil.getUsernameByUserId(staffid, "kmhk.local");
                string q1 = string.Format("select r_lastaccess, r_filename, r_owner, r_path from " + t + " where datediff(month, r_lastaccess, getdate()) >= {0} and r_owner = N'{1}'", range, staff);
                using (IDataReader reader = DataService.GetInstance().ExecuteReader(q1))
                {
                    while (reader.Read())
                        if (!idleFileList.Exists(x => x == reader.GetString(3).Trim()))
                            table.Rows.Add(new object[] { reader.GetString(0).Trim(), reader.GetString(1).Trim(), reader.GetString(2).Trim(), reader.GetString(3).Trim(), "-", "-" });
                }
            }

            _table = table;

            dgvTotal.DataSource = table;
        }

        private List<DataTable> CloneTableList(DataTable sourceTable, int limit)
        {
            List<DataTable> list = new List<DataTable>();
            int count = 0;
            DataTable copyTable = null;

            foreach (DataRow row in sourceTable.Rows)
            {
                if ((count++ % limit) == 0)
                {
                    copyTable = new DataTable();
                    copyTable = sourceTable.Clone();
                    list.Add(copyTable);
                }
                copyTable.ImportRow(row);
            }

            return list;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvProcessing.Visible = false;
            dgvTotal.Visible = true;

            LoadData();
        }

        private void dgvTotal_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvTotal.Rows.Count > 0)
            {
                if (((dgvTotal.Rows[0].Height * dgvTotal.Rows.Count) + dgvTotal.ColumnHeadersHeight) < e.Location.Y)
                    dgvTotal.ClearSelection();
                else
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        var hti = dgvTotal.HitTest(e.X, e.Y);

                        if (dgvTotal.SelectedRows.Count == 1)
                        {
                            dgvTotal.ClearSelection();

                            if (((dgvTotal.Rows[0].Height * dgvTotal.Rows.Count) + dgvTotal.ColumnHeadersHeight) >= e.Location.Y)
                                dgvTotal.Rows[hti.RowIndex].Selected = true;
                        }
                        else
                        {
                            if (((dgvTotal.Rows[0].Height * dgvTotal.Rows.Count) + dgvTotal.ColumnHeadersHeight) >= e.Location.Y)
                                dgvTotal.Rows[hti.RowIndex].Selected = true;
                        }
                    }
                }
            }
        }

        private void getSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double size = 0;

            string[] sizes = { "B", "KB", "MB", "GB" };

            foreach (DataGridViewRow row in dgvTotal.SelectedRows)
            {
                string path = row.Cells[3].Value.ToString().Trim();

                using (var impersonation = new ImpersonatedUser("itadmin", "kmhk.local", "Ed@a*9kj"))
                {
                    if (!File.Exists(path))
                        continue;

                    double len = new FileInfo(path).Length;
                    size += len;
                }
            }

            int order = 0;
            while (size >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                size = size / 1024;
            }

            MessageBox.Show("Selected items: " + dgvTotal.SelectedRows.Count + "  Size: " + string.Format("{0:0.##} {1}", size, sizes[order]));
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //List<string> list = new List<string>();
            List<DiscIdleList> list = new List<DiscIdleList>();
            foreach (DataGridViewRow row in dgvTotal.SelectedRows)
                list.Add(new DiscIdleList { LastAccess = row.Cells[0].Value.ToString().Trim(), User = row.Cells[2].Value.ToString().Trim(), FilePath = row.Cells[3].Value.ToString().Trim() });

            list = list.Distinct().ToList();

            DiscSetupIdle setup = new DiscSetupIdle(list);
            setup.ShowDialog();
            //if (setup.ShowDialog() == DialogResult.OK)
               // LoadData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.Enabled = dgvTotal.Rows.Count > 0 ? true : false;
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvTotal.SelectedRows)
            {
                string path = row.Cells[3].Value.ToString().Trim();

                using (var impersonation = new ImpersonatedUser("itadmin", "kmhk.local", "Ed@a*9kj"))
                {
                    if (!File.Exists(path))
                        row.Cells[6].Value = "Not exists";
                    else
                    {
                        try
                        {
                            FileSystemSecurity security = File.GetAccessControl(path);

                            row.Cells[6].Value = "OK";
                        }
                        catch
                        {
                            row.Cells[6].Value = "No Permission";
                        }
                    }
                }
            }
        }

        private void finishedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProcessing.SelectedRows)
            {
                string status = row.Cells[4].Value.ToString().Trim();

                if (status != "Processing")
                    continue;

                string user = row.Cells[2].Value.ToString().Trim();
                string tablename = "TB_" + AdUtil.GetUserIdByUsername(user, "kmhk.local");
                string path = row.Cells[3].Value.ToString().Trim();
                string pathCopy = row.Cells[6].Value.ToString().Trim();

                string newPath = path.Contains("'") ? path.Replace("'", "''") : path;

                using (var impersonation = new ImpersonatedUser("itadmin", "kmhk.local", "Ed@a*9kj"))
                {
                    if (File.Exists(path)) File.Delete(path);
                    if (File.Exists(pathCopy)) File.Delete(pathCopy);
                }

                string query = string.Format("update TB_DISC_IDLE set di_status = 'Finished', di_finished = 'Yes', di_finisheddatetime = '{0}', di_finishedby = N'{1}' where di_path = N'{2}'", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), GlobalService.User, newPath);
                DataService.GetInstance().ExecuteNonQuery(query);

                string text = string.Format("update " + tablename + " set r_disc = 'True' where r_path = N'{0}'", newPath);
                DataService.GetInstance().ExecuteNonQuery(text);
            }
        }

        private void btnProcessing_Click(object sender, EventArgs e)
        {
            dgvTotal.Visible = false;
            dgvProcessing.Visible = true;

            LoadIdle(txtSearch.Text.Trim());
        }

        private void dgvProcessing_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvProcessing.Rows.Count > 0)
            {
                if (((dgvProcessing.Rows[0].Height * dgvProcessing.Rows.Count) + dgvProcessing.ColumnHeadersHeight) < e.Location.Y)
                    dgvProcessing.ClearSelection();
                else
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        var hti = dgvProcessing.HitTest(e.X, e.Y);

                        if (dgvProcessing.SelectedRows.Count == 1)
                        {
                            dgvProcessing.ClearSelection();

                            if (((dgvProcessing.Rows[0].Height * dgvProcessing.Rows.Count) + dgvProcessing.ColumnHeadersHeight) >= e.Location.Y)
                                dgvProcessing.Rows[hti.RowIndex].Selected = true;
                        }
                        else
                        {
                            if (((dgvProcessing.Rows[0].Height * dgvProcessing.Rows.Count) + dgvProcessing.ColumnHeadersHeight) >= e.Location.Y)
                                dgvProcessing.Rows[hti.RowIndex].Selected = true;
                        }
                    }
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvTotal.Visible = false;
                dgvProcessing.Visible = true;

                LoadIdle(txtSearch.Text.Trim());
            }
        }

    }
}
