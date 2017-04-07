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
using System.Diagnostics;
using KDTHK_SYS_MAN_CONSOLE.utils;

namespace KDTHK_SYS_MAN_CONSOLE.forms.education
{
    public partial class EducationNew : UserControl
    {
        public EducationNew()
        {
            InitializeComponent();

            SearchData("");
        }

        private void SearchData(string type)
        {
            DataTable table = new DataTable();

            string query = string.Format("select q_id as id, q_content as content, t_type as type" +
                " from TB_QUESTION, TB_MASTER_TYPE where q_type = t_tag and q_type like '%{0}%'", type);

            SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query, DataServiceEducation.GetInstance().Connection);
            sda.Fill(table);

            dgvQuestion.DataSource = table;
        }

        private void LinkClicked(object sender, EventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;

            string tag = link.Tag.ToString();

            if (tag == "all")
                SearchData("");
            else
                SearchData(tag);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string enabled = ckbEnabled.Checked ? "True" : "False";
            string title = txtTitle.Text;
            string from = dpFrom.Value.ToString("yyyy/MM/dd");
            string to = dpTo.Value.ToString("yyyy/MM/dd");

            if (EducationUtil.IsTitleExist(title))
            {
                MessageBox.Show("Title has been used before.");
                return;
            }

            if (EducationUtil.IsEducationOpened() && ckbEnabled.Checked)
            {
                switch (MessageBox.Show("There is another enabled education. Do you want to replace it?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        string updatetext = "update TB_EDUCATION set e_enabled = 'False'";
                        DataService.GetInstance().ExecuteNonQuery(updatetext);
                        break;

                    case DialogResult.No:
                        enabled = "False";
                        break;
                }
            }

            List<int> typelist = new List<int>();

            if (ckbAll.Checked)
                typelist = EducationUtil.GetAllTypeId();
            else
            {
                foreach (CheckBox ckb in panel1.Controls)
                {
                    if (ckb.Checked)
                    {
                        int id = EducationUtil.GetTypeId(ckb.Tag.ToString());
                        typelist.Add(id);
                    }
                }
            }

            string query = string.Format("insert into TB_EDUCATION (e_title, e_from, e_to, e_enabled, e_noticedate, e_notice)" +
                " values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", title, from, to, enabled, "#N/A", "#N/A");

            DataService.GetInstance().ExecuteNonQuery(query);

            foreach (int id in typelist)
            {
                string text = string.Format("insert into TB_RELATIONS (r_educationid, r_typeid) values ('{0}', '{1}')",
                    EducationUtil.GetEducationId(title), id);

                DataService.GetInstance().ExecuteNonQuery(text);
            }

            MessageBox.Show("Record has been saved.");
        }
    }
}
