using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomUtil.utils.buffer;
using KDTHK_SYS_MAN_CONSOLE.services;
using System.Data.SqlClient;
using System.Collections;
using CustomUtil.utils.export;

namespace KDTHK_SYS_MAN_CONSOLE.forms.education
{
    public partial class EducationReport : UserControl
    {
        public EducationReport()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvRecord, true);

            this.LoadData("");
        }

        private void LoadData(string source)
        {
            DataTable table = new DataTable();
            string[] headers = { "education", "company", "name", "score", "id" };
            foreach (string header in headers)
                table.Columns.Add(header);

            string query = string.Format("select e_title, st_company, st_name, r_score, st_id" +
                " from TB_EDUCATION, TB_RECORD, TB_STAFF where e_id = r_educationid and r_name = st_name and (e_title like '%{0}%' or st_company like '%{0}%')", source);

            using (IDataReader reader = DataServiceEducation.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string title = reader.GetString(0);
                    string company = reader.GetString(1);
                    string name = reader.GetString(2);
                    string score = reader.GetString(3);
                    int id = reader.GetInt32(4);

                    table.Rows.Add(new object[] { title, company, name, score, id });
                }
            }

            string text = string.Format("select e_title, st_company, st_name, st_id from TB_EDUCATION, TB_STAFF, TB_RECORD" +
                " where (e_title like '%{0}%' or st_company like '%{0}%') and r_educationid = e_id and not exists" +
                " (select * from TB_RECORD where r_name = st_name and (e_title like '%{0}%' or st_company like '%{0}%'))", source);

            using (IDataReader reader = DataServiceEducation.GetInstance().ExecuteReader(text))
            {
                while (reader.Read())
                {
                    string title = reader.GetString(0);
                    string company = reader.GetString(1);
                    string name = reader.GetString(2);
                    int id = reader.GetInt32(3);

                    table.Rows.Add(new object[] { title, company, name, "Waiting", id });
                }
            }

            DataTable tb = DeleteDuplicateFromDataTable(table, "id");
            dgvRecord.DataSource = tb;
        }

        protected DataTable DeleteDuplicateFromDataTable(DataTable dt, string columnName)
        {
            Hashtable hashT = new Hashtable();
            ArrayList arrDuplicate = new ArrayList();

            foreach (DataRow row in dt.Rows)
            {
                if (hashT.Contains(row[columnName]))
                    arrDuplicate.Add(row);
                else
                    hashT.Add(row[columnName], string.Empty);
            }

            foreach (DataRow row in arrDuplicate)
                dt.Rows.Remove(row);

            return dt;
        }

        private void tsbtnDownload_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string[] headers = { "Education", "Company", "Name", "Marks" };

            foreach (string header in headers)
                table.Columns.Add(header);

            foreach (DataGridViewRow row in dgvRecord.Rows)
            {
                string education = row.Cells[0].Value.ToString();
                string related = row.Cells[1].Value.ToString();
                string name = row.Cells[2].Value.ToString();
                string score = row.Cells[3].Value.ToString();

                table.Rows.Add(new object[] { education, related, name, score });
            }
            ExportExcelUtil.ExportExcel(table);
        }
    }
}
