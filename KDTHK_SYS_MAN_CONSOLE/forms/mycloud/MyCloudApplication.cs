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

namespace KDTHK_SYS_MAN_CONSOLE.forms.mycloud
{
    public partial class MyCloudApplication : UserControl
    {
        public MyCloudApplication()
        {
            InitializeComponent();

            this.LoadData();

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            tsbtnDelete.Enabled = dgvApplication.SelectedRows.Count > 0 ? true : false;
        }

        private void LoadData()
        {
            DataTable table = new DataTable();

            string query = "select f_category as category, f_staff as staff, f_name as name, f_path as spath, f_description as description, f_lastaccess as lastaccess from TB_APPLICATION order by f_staff";

            SqlDataAdapter sda = new SqlDataAdapter(query, DataServiceMyCloud.GetInstance().Connection);
            sda.Fill(table);

            dgvApplication.DataSource = table;
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            MyCloudApplicationNew form = new MyCloudApplicationNew();
            if (form.ShowDialog() == DialogResult.OK)
                this.LoadData();
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvApplication.SelectedRows)
            {
                string staff = row.Cells[1].Value.ToString().Trim();
                string path = row.Cells[3].Value.ToString().Trim();

                string query = string.Format("delete from TB_APPLICATION where f_staff = N'{0}' and f_path = N'{1}'", staff, path);
                DataServiceMyCloud.GetInstance().ExecuteNonQuery(query);
            }

            this.LoadData();
        }
    }
}
