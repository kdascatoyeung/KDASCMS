using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms
{
    public partial class FormView : UserControl
    {
        public event EventHandler DetailEvent;

        public FormView()
        {
            InitializeComponent();

            LoadTotal();

            LoadInCharge();

            dgvTotal.DefaultCellStyle.SelectionBackColor = dgvTotal.DefaultCellStyle.BackColor;
            dgvTotal.DefaultCellStyle.SelectionForeColor = dgvTotal.DefaultCellStyle.ForeColor;

            dgvIncharge.DefaultCellStyle.SelectionBackColor = dgvTotal.DefaultCellStyle.BackColor;
            dgvIncharge.DefaultCellStyle.SelectionForeColor = dgvIncharge.DefaultCellStyle.ForeColor;

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
        }

        private void LoadTotal()
        {
            List<string> categoryList = new List<string>();

            string query = "select fm_category from TB_FORM_MASTER";
            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                    categoryList.Add(reader.GetString(0).Trim());
            }

            foreach (string item in categoryList)
            {
                string q1 = string.Format("select count(*) from TB_FORM where f_type = N'{0}' and f_status = N'已接收'", item);
                int received = (int)DataService.GetInstance().ExecuteScalar(q1);

                string q2 = string.Format("select count(*) from TB_FORM where f_type = N'{0}' and f_status = N'處理中'", item);
                int processing = (int)DataService.GetInstance().ExecuteScalar(q2);

                string q3 = string.Format("select count(*) from TB_FORM where f_type = N'{0}' and f_status = N'申請處理完成'", item);
                int finished = (int)DataService.GetInstance().ExecuteScalar(q3);

                dgvTotal.Rows.Add(item, received + processing + finished, finished, processing, received);
            }
        }

        private void LoadInCharge()
        {
            List<string> inchargeList = new List<string>();

            string query = "select distinct fm_name from TB_FORM_MASTER";
            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                    inchargeList.Add(reader.GetString(0).Trim());
            }

            foreach (string item in inchargeList)
            {
                string q1 = string.Format("select count(*) from TB_FORM where f_handleby = N'{0}' and f_status = N'已接收'", item);
                int received = (int)DataService.GetInstance().ExecuteScalar(q1);

                string q2 = string.Format("select count(*) from TB_FORM where f_handleby = N'{0}' and f_status = N'處理中'", item);
                int processing = (int)DataService.GetInstance().ExecuteScalar(q2);

                string q3 = string.Format("select count(*) from TB_FORM where f_handleby = N'{0}' and f_status = N'完成'", item);
                int finished = (int)DataService.GetInstance().ExecuteScalar(q3);

                dgvIncharge.Rows.Add(item, GetNickName(item), received + processing + finished, finished, processing, received);
            }
        }

        private string GetNickName(string name)
        {
            string query = string.Format("select fm_nickname from TB_FORM_MASTER where fm_name = N'{0}'", name);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        private void LoadDataByCategory(string category)
        {
            DataTable table = new DataTable();
            string query = string.Format("select f_status as st, f_type as category, f_createdby as applicant, f_created as created, f_start as sdate, f_end as edate, f_approval as approval, f_handleby as incharge from TB_FORM where f_type = N'{0}' and f_status != N'完成' order by f_status, f_category, f_created", category);
            SqlDataAdapter sda = new SqlDataAdapter(query, DataService.GetInstance().Connection);
            sda.Fill(table);

            dgvOverview.DataSource = table;
        }

        private void LoadDataByInCharge(string incharge)
        {
            DataTable table = new DataTable();
            string query = string.Format("select f_status as st, f_type as category, f_createdby as applicant, f_created as created, f_start as sdate, f_end as edate, f_approval as approval, f_handleby as incharge from TB_FORM where f_handleby = N'{0}' and f_status != N'完成' order by f_status, f_category, f_created", incharge);
            SqlDataAdapter sda = new SqlDataAdapter(query, DataService.GetInstance().Connection);
            sda.Fill(table);

            dgvOverview.DataSource = table;
        }

        private void dgvTotal_DoubleClick(object sender, EventArgs e)
        {
            dgvIncharge.ClearSelection();

            dgvTotal.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvTotal.DefaultCellStyle.SelectionForeColor = Color.White;

            string category = dgvTotal.SelectedRows[0].Cells[0].Value.ToString().Trim();

            LoadDataByCategory(category);
        }

        private void dgvIncharge_DoubleClick(object sender, EventArgs e)
        {
            dgvTotal.ClearSelection();

            dgvIncharge.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvIncharge.DefaultCellStyle.SelectionForeColor = Color.White;

            string name = dgvIncharge.SelectedRows[0].Cells[0].Value.ToString().Trim();

            LoadDataByInCharge(name);
        }

        private void ButtonMouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.White;
        }

        private void ButtonMouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.FromArgb(58, 58, 58);
        }

        private void btnAllRecord_Click(object sender, EventArgs e)
        {
            dgvIncharge.ClearSelection();
            dgvTotal.ClearSelection();

            dgvOverview.Select();


            DataTable table = new DataTable();
            string query = "select f_status as st, f_type as category, f_createdby as applicant, f_created as created, f_start as sdate, f_end as edate, f_approval as approval, f_handleby as incharge from TB_FORM where f_status != N'完成' order by f_status, f_category, f_created";
            SqlDataAdapter sda = new SqlDataAdapter(query, DataService.GetInstance().Connection);
            sda.Fill(table);

            dgvOverview.DataSource = table;

        }

        private void dgvOverview_DoubleClick(object sender, EventArgs e)
        {
            if (DetailEvent != null)
                DetailEvent(this, new EventArgs());
        }
    }
}
