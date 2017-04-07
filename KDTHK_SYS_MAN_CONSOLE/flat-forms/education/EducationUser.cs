using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CustomUtil.utils.import;
using CustomUtil.utils.authentication;
using KDTHK_SYS_MAN_CONSOLE.forms.utils;
using System.Diagnostics;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.education
{
    public partial class EducationUser : UserControl
    {
        public EducationUser()
        {
            InitializeComponent();

            LoadData("");

            /*List<string> list = new List<string>();

            string query = "select u_staffid from TB_USER";
            using (IDataReader reader = DataServiceEdu.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                    list.Add(reader.GetString(0).Trim());
            }

            foreach (string id in list)
            {
                string staff = id.ToLower().StartsWith("hk") ? AdUtil.getUsernameByUserId(id, "kmhk.local") : AdUtil.getUsernameByUserId(id, "kmas.local");
                string text = string.Format("update TB_USER set u_staff = N'{0}' where u_staffid = '{1}'", staff, id);
                DataServiceEdu.GetInstance().ExecuteNonQuery(text);
            }*/
        }

        private void LoadData(string company)
        {
            string query = string.Format("select u_staffid as id, u_staff as name, u_company as company from TB_USER where u_company like '%{0}%'", company);

            DataTable table = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter(query, DataServiceEdu.GetInstance().Connection);
            sda.Fill(table);

            dgvUser.DataSource = table;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable tb1 = ImportExcel2007.TranslateToTable(ofd.FileName, "KDTHK");
                foreach (DataRow row in tb1.Rows)
                {
                    string id = row.ItemArray[0].ToString().Trim();
                    string name = row.ItemArray[1].ToString().Trim();

                    string query = string.Format("insert into TB_USER (u_staffid, u_staff, u_company) values ('{0}', N'{1}', '{2}')", id, name, "KDTHK");
                    DataServiceEdu.GetInstance().ExecuteNonQuery(query);
                }

                DataTable tb2 = ImportExcel2007.TranslateToTable(ofd.FileName, "KDHK");
                foreach (DataRow row in tb2.Rows)
                {
                    string id = row.ItemArray[0].ToString().Trim();
                    string name = row.ItemArray[1].ToString().Trim();

                    string query = string.Format("insert into TB_USER (u_staffid, u_staff, u_company) values ('{0}', N'{1}', '{2}')", id, name, "KDHK");
                    DataServiceEdu.GetInstance().ExecuteNonQuery(query);
                }

                DataTable tb3 = ImportExcel2007.TranslateToTable(ofd.FileName, "KDAS");
                foreach (DataRow row in tb3.Rows)
                {
                    string id = row.ItemArray[0].ToString().Trim();
                    string name = row.ItemArray[1].ToString().Trim();

                    string query = string.Format("insert into TB_USER (u_staffid, u_staff, u_company) values ('{0}', N'{1}', '{2}')", id, name, "KDAS");
                    DataServiceEdu.GetInstance().ExecuteNonQuery(query);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<UserData> list = new List<UserData>();

            string query = "select u_staffid, u_staff, u_company from TB_USER";
            using (IDataReader reader = DataServiceEdu.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string staffid = reader.GetString(0).Trim();
                    string name = reader.GetString(1).Trim();
                    string company = reader.GetString(2).Trim();

                    list.Add(new UserData { id = staffid, name = name, company = company });
                }
            }

            foreach (UserData data in list)
            {
                string q1 = string.Format("update TB_IT_EDU_RECORD set r_company = '{0}' where r_user = N'{1}'", data.company, data.name);
                DataServiceEdu.GetInstance().ExecuteNonQuery(q1);

                string q2 = string.Format("update TB_IT_EDU_REPORT set  r_company = '{0}' where r_user = N'{1}'", data.company, data.name);
                DataServiceEdu.GetInstance().ExecuteNonQuery(q2);
            }
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

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadData("");
        }

        private void btnKDTHK_Click(object sender, EventArgs e)
        {
            LoadData("KDTHK");
        }

        private void btnKDAS_Click(object sender, EventArgs e)
        {
            LoadData("KDAS");
        }

        private void btnKDHK_Click(object sender, EventArgs e)
        {
            LoadData("KDHK");
        }
    }

    public class UserData
    {
        public string id { get; set; }
        public string name { get; set; }
        public string company { get; set; }
    }
}
