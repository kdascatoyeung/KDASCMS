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
using KDTHK_SYS_MAN_CONSOLE.services;

namespace KDTHK_SYS_MAN_CONSOLE.forms.education
{
    public partial class EducationList : UserControl
    {
        public EducationList()
        {
            InitializeComponent();

            this.LoadData();
        }

        private void LoadData()
        {
            dgvQuestion.Rows.Clear();

            DataTable table = new DataTable();

            string query = "select e_id, e_title, e_from, e_to, e_enabled, e_notice from TB_EDUCATION";

            SqlDataAdapter sda = new SqlDataAdapter(query, DataServiceEducation.GetInstance().Connection);
            sda.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                string id = row.ItemArray[0].ToString();
                string title = row.ItemArray[1].ToString();
                string from = row.ItemArray[2].ToString();
                string to = row.ItemArray[3].ToString();
                string enabled = row.ItemArray[4].ToString();
                string notice = row.ItemArray[5].ToString();
                Image img = enabled == "True" ? Properties.Resources.tick_icon : Properties.Resources.cross_icon;

                string kdthk = EducationUtil.GetKDTHKRecordCount(Convert.ToInt32(id)) + " / " + EducationUtil.GetKDTHKCount();
                string kdas = EducationUtil.GetKDASRecordCount(Convert.ToInt32(id)) + " / " + EducationUtil.GetKDASCount();
                string kdhg = EducationUtil.GetKDHGRecordCount(Convert.ToInt32(id)) + " / " + EducationUtil.GetKDHGCount();

                dgvQuestion.Rows.Add(id, title, from, to, enabled, img, notice, kdthk, kdas, kdhg);
            }
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvQuestion.SelectedRows[0].Cells[0].Value);

            string query = "update TB_EDUCATION set e_enabled = 'False'";
            DataServiceEducation.GetInstance().ExecuteNonQuery(query);

            string text = string.Format("update TB_EDUCATION set e_enabled = 'True' where e_id = '{0}'", id);
            DataServiceEducation.GetInstance().ExecuteNonQuery(text);

            this.LoadData();
        }
    }
}
