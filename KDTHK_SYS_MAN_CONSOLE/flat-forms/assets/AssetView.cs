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

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.assets
{
    public partial class AssetView : UserControl
    {
        public event EventHandler EditEvent;

        public AssetView()
        {
            InitializeComponent();

            LoadData("");
        }

        private void LoadData(string source)
        {
            DataTable table = new DataTable();
            string[] headers = { "name", "category", "applicant", "startdate", "enddate", "longterm", "remarks", "st", "id" };
            foreach (string header in headers)
                table.Columns.Add(header);

            string query = string.Format("select l_name as name, l_category as category, l_user as applicant, l_start as startdate, l_end as enddate, l_longterm as longterm" +
                ", l_remarks as remarks, l_status as st, l_id as id from TB_FORM_LOANING where (l_name like N'%{0}%' or l_category like '%{0}%' or l_remarks like N'%{0}%' or l_status like N'%{0}%' or l_user like N'%{0}%')", source);

            SqlDataAdapter adapater = new SqlDataAdapter(query, DataService.GetInstance().Connection);
            adapater.Fill(table);

            dgvAsset.DataSource = table;

            LoadTotal();
        }

        private void LoadTotal()
        {
            List<string> list = new List<string>();
            string q1 = "select distinct l_category from TB_FORM_LOANING";
            using (IDataReader reader = DataService.GetInstance().ExecuteReader(q1))
            {
                while (reader.Read())
                    list.Add(reader.GetString(0).Trim());
            }

            foreach (string item in list)
            {
                string q2 = string.Format("select count(*) from TB_FORM_LOANING where l_category = N'{0}' and l_status = N'可借用'", item);
                int stock = (int)DataService.GetInstance().ExecuteScalar(q2);

                string q3 = string.Format("select count(*) from TB_FORM_LOANING where l_category = N'{0}' and l_status = N'借用中'", item);
                int borrow = (int)DataService.GetInstance().ExecuteScalar(q3);

                dgvTotal.Rows.Add(item, stock + borrow, stock, borrow);
            }
        }

        private void dgvAsset_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAsset.SelectedRows == null)
                return;

            GlobalService.AssetId = dgvAsset.SelectedRows[0].Cells[8].Value.ToString();

            if (EditEvent != null)
                EditEvent(this, new EventArgs());
        }
    }
}
