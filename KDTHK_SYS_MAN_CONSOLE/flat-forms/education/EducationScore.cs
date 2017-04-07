using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.education
{
    public partial class EducationScore : UserControl
    {
        public EducationScore()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            DataTable table = new DataTable();
            string query = "select r_user as staff, r_datetime as dt, r_score as score, r_company as company from TB_IT_EDU_RECORD, TB_USER where r_user = u_staff";

            SqlDataAdapter sda = new SqlDataAdapter(query, DataServiceEdu.GetInstance().Connection);
            sda.Fill(table);

            dgvScore.DataSource = table;
        }

        private void LoadNonSubmittedData()
        {
            DataTable table = new DataTable();
            string[] headers = { "staff", "dt", "score", "company" };
            foreach (string header in headers)
                table.Columns.Add(header);

            string query = "select u_staff, u_company from TB_USER where not exists (select * from TB_IT_EDU_RECORD where r_user = u_staff)";
            using (IDataReader reader = DataServiceEdu.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string user = reader.GetString(0).Trim();
                    string company = reader.GetString(1).Trim();

                    table.Rows.Add(user, "-", "-", company);
                }
            }

            dgvScore.DataSource = table;
        }

        private void dgvScore_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvScore.Rows.Count > 0)
            {
                if (((dgvScore.Rows[0].Height * dgvScore.Rows.Count) + dgvScore.ColumnHeadersHeight) < e.Location.Y)
                    dgvScore.ClearSelection();
                else
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        var hti = dgvScore.HitTest(e.X, e.Y);

                        if (dgvScore.SelectedRows.Count == 1)
                        {
                            dgvScore.ClearSelection();

                            if (((dgvScore.Rows[0].Height * dgvScore.Rows.Count) + dgvScore.ColumnHeadersHeight) >= e.Location.Y)
                                dgvScore.Rows[hti.RowIndex].Selected = true;
                        }
                        else
                        {
                            if (((dgvScore.Rows[0].Height * dgvScore.Rows.Count) + dgvScore.ColumnHeadersHeight) >= e.Location.Y)
                                dgvScore.Rows[hti.RowIndex].Selected = true;
                        }
                    }
                }
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in dgvScore.SelectedRows)
            {
                string name = row.Cells[0].Value.ToString().Trim();

                string query = string.Format("insert into TB_IT_EDU_REDO (r_user, r_datetime) values (N'{0}', '{1}')", name, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                DataServiceEdu.GetInstance().ExecuteNonQuery(query);

                string delText = string.Format("delete from TB_IT_EDU_HISTORY where h_user = N'{0}'", name);

                string delText1 = string.Format("delete from TB_IT_EDU_RECORD where r_user = N'{0}'", name);

                string delText2 = string.Format("delete from TB_IT_EDU_REPORT where r_user = N'{0}'", name);

                DataServiceEdu.GetInstance().ExecuteNonQuery(delText);
                DataServiceEdu.GetInstance().ExecuteNonQuery(delText1);
                DataServiceEdu.GetInstance().ExecuteNonQuery(delText2);

                count += 1;
            }

            MessageBox.Show(count + " records have been reset");
            LoadData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnNonSubmit_Click(object sender, EventArgs e)
        {
            LoadNonSubmittedData();
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
    }
}
