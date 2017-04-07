using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomUtil.utils.export;
using CustomUtil.utils.authentication;
using System.Diagnostics;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.disc
{
    public partial class DiscLoading : Form
    {
        public DiscLoading()
        {
            InitializeComponent();

            circularProgressBar1.Start();

            if (!worker.IsBusy)
                worker.RunWorkerAsync();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            GetIdleData(6);
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void GetIdleData(int months)
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
            string[] headers = { "lastaccess", "filename", "owner", "path", "vpath" };
            foreach (string header in headers)
                table.Columns.Add(header);

            int range = 6 + months;

            int total = tableList.Count;
            int count = 0;

            foreach (string t in tableList)
            {
                string staffid = t.Substring(3);
                string staff = AdUtil.getUsernameByUserId(staffid, "kmhk.local");
                string q1 = string.Format("select r_lastaccess, r_filename, r_owner, r_path, r_vpath from " + t + " where datediff(month, r_lastaccess, getdate()) >= {0} and r_owner = N'{1}'", range, staff);
                using (IDataReader reader = DataService.GetInstance().ExecuteReader(q1))
                {
                    while (reader.Read())
                        table.Rows.Add(new object[] { reader.GetString(0).Trim(), reader.GetString(1).Trim(), reader.GetString(2).Trim(), reader.GetString(3).Trim(), reader.GetString(4).Trim() });
                }

                SetCountText(count++ + " / " + total);
            }

            foreach (DataTable dt in CloneTableList(table, 500000))
                Invoke((Action)(() => { ExportCsvUtil.ExportCsv(dt, "", ""); }));
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

        delegate void SetCountTextCallback(string text);
        private void SetCountText(string text)
        {
            if (InvokeRequired)
            {
                SetCountTextCallback callback = new SetCountTextCallback(SetCountText);
                this.Invoke(callback, new object[] { text });
            }
            else
                lblCount.Text = text;
        }
    }
}
