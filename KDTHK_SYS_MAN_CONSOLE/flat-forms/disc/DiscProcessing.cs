using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using KDTHK_SYS_MAN_CONSOLE.utils;
using System.IO;
using System.Diagnostics;
using CustomUtil.utils.authentication;
using KDTHK_SYS_MAN_CONSOLE.services;
using System.Security.Permissions;
using System.Security;
using System.Security.AccessControl;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.disc
{
    public partial class DiscProcessing : UserControl
    {
        public DiscProcessing()
        {
            InitializeComponent();

            cbStatus.SelectedIndex = 0;

            LoadData("", "", "All");
        }

        private void LoadData(string filename, string user, string status)
        {
            DataTable table = new DataTable();
            string[] headers = { "filename", "requester", "requested", "path", "st", "disc", "pathcopy"};
            foreach (string header in headers)
                table.Columns.Add(header);

            table.Columns.Add("check", typeof(string));

            table.Columns["check"].DefaultValue = "-";

            string st = status == "All" ? "" : status;
            string query = string.Format("select d_datetime as requested, d_requester as requester, d_path as path, d_filename as filename, d_status as st, d_disc as disc, d_pathcopy as pathcopy"+
                " from TB_DISC_REQUEST where d_finished = 'False' and d_requester like N'%{0}%' and d_filename like N'%{1}%' and d_status like '%{2}%'", user, filename, st);
            SqlDataAdapter sda = new SqlDataAdapter(query, DataService.GetInstance().Connection);
            sda.Fill(table);

            dgvTotal.DataSource = table;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(txtFilename.Text, txtUser.Text, cbStatus.SelectedItem.ToString());
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
            List<string> list = new List<string>();
            foreach (DataGridViewRow row in dgvTotal.SelectedRows)
                list.Add(row.Cells[3].Value.ToString().Trim());

            list = list.Distinct().ToList();

            DiscSetup1 setup = new DiscSetup1(list);
            if (setup.ShowDialog() == DialogResult.OK)
                LoadData(txtFilename.Text, txtUser.Text, cbStatus.SelectedItem.ToString());
        }

        private void finishedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvTotal.SelectedRows)
            {
                string status = row.Cells[4].Value.ToString().Trim();

                if (status != "Processing")
                    continue;

                string requester = row.Cells[1].Value.ToString().Trim();
                string tableName = "TB_" + AdUtil.GetUserIdByUsername(requester, "kmhk.local");
                string path = row.Cells[3].Value.ToString().Trim();
                string pathCopy = row.Cells[6].Value.ToString().Trim();

                string newPath = path.Contains("'") ? path.Replace("'", "''") : path;

                using (var impersonation = new ImpersonatedUser("itadmin", "kmhk.local", "Ed@a*9kj"))
                {
                    if (File.Exists(path)) File.Delete(path);
                    if (File.Exists(pathCopy)) File.Delete(pathCopy);
                }

                string query = string.Format("update TB_DISC_REQUEST set d_status = 'Finished', d_finished = 'True', d_finishdatetime = '{1}', d_finishedby = N'{2}' where d_path = N'{0}'", newPath, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), GlobalService.User);
                DataService.GetInstance().ExecuteNonQuery(query);

                string text = string.Format("update " + tableName + " set r_disc = 'True' where r_path = N'{0}'", newPath);
                DataService.GetInstance().ExecuteNonQuery(text);
            }

            MessageBox.Show("Record has been saved.");

            LoadData(txtFilename.Text, txtUser.Text, cbStatus.SelectedItem.ToString());
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

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvTotal.SelectedRows)
            {
                string path = row.Cells[3].Value.ToString().Trim();

                using (var impersonation = new ImpersonatedUser("itadmin", "kmhk.local", "Ed@a*9kj"))
                {
                    if (!File.Exists(path))
                        row.Cells[7].Value = "Not exists";
                    else
                    {
                        try
                        {
                            FileSystemSecurity security = File.GetAccessControl(path);

                            row.Cells[7].Value = "OK";
                        }
                        catch
                        {
                            row.Cells[7].Value = "No Permission";
                        }
                    }
                }
            }
        }
    }
}
