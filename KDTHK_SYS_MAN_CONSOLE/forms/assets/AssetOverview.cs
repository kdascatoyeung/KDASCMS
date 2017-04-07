using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KDTHK_SYS_MAN_CONSOLE.forms.assets
{
    public partial class AssetOverview : UserControl
    {
        public AssetOverview()
        {
            InitializeComponent();

            LoadData("");
        }

        private void LoadData(string source)
        {
            DataTable table = new DataTable();
            string[] headers = { "name", "category", "applicant", "startdate", "enddate", "longterm", "remarks", "st" };
            foreach (string header in headers)
                table.Columns.Add(header);

            string query = string.Format("select l_name as name, l_category as category, l_user as applicant, l_start as startdate, l_end as enddate, l_longterm as longterm" +
                ", l_remarks as remarks, l_status as st from TB_FORM_LOANING where (l_name like N'%{0}%' or l_category like '%{0}%' or l_remarks like N'%{0}%' or l_status like N'%{0}%' or l_user like N'%{0}%')", source);

            SqlDataAdapter adapater = new SqlDataAdapter(query, DataService.GetInstance().Connection);
            adapater.Fill(table);

            dgvAsset.DataSource = table;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadData(txtSearch.Text);
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadData(txtSearch.Text);
        }
    }
}
