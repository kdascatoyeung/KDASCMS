using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CustomUtil.utils.export;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.disc
{
    public partial class DiscHistory : UserControl
    {
        public DiscHistory()
        {
            InitializeComponent();

            LoadData("", "", "");
        }

        private void LoadData(string filename, string user, string disc)
        {
            DataTable table = new DataTable();

            string query = string.Format("select d_filename as filename, d_requester as requester, d_disc as disc, d_finishdatetime as dt, d_finishedby as finby" +
                " from TB_DISC_REQUEST where d_status = 'Finished' and d_filename like N'%{0}%' and d_requester like N'%{1}%' and d_disc like '%{2}%'", filename, user, disc);

            SqlDataAdapter sda = new SqlDataAdapter(query, DataService.GetInstance().Connection);
            sda.Fill(table);

            dgvHistory.DataSource = table;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(txtFilename.Text, txtUser.Text, txtDiscId.Text);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataTable table = (DataTable)dgvHistory.DataSource;
            ExportCsvUtil.ExportCsv(table, "", "");
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
