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
using CustomUtil.utils.authentication;
using CustomUtil.utils.import;

namespace KDTHK_SYS_MAN_CONSOLE.forms.education
{
    public partial class EducationStaff : UserControl
    {
        public EducationStaff()
        {
            InitializeComponent();

            this.LoadData("");
        }

        private void LoadData(string company)
        {
            DataTable table = new DataTable();

            string query = string.Format("select st_staffid as staffid, st_name as name, st_company as company from TB_STAFF where st_company like '%{0}%'", company);

            SqlDataAdapter sda = new SqlDataAdapter(query, DataServiceEducation.GetInstance().Connection);
            sda.Fill(table);

            dgvStaff.DataSource = table;
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            EducationStaffNew form = new EducationStaffNew();
            if (form.ShowDialog() == DialogResult.OK)
                this.LoadData("");
        }

        private void tsbtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable tmptable = new DataTable();

                tmptable = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in tmptable.Rows)
                {
                    string staffid = row.ItemArray[0].ToString();
                    staffid = staffid.ToLower();

                    string name = staffid.StartsWith("hk") ? AdUtil.getUsernameByUserId(staffid, "kmhk.local") : AdUtil.getUsernameByUserId(staffid, "kmas.local");
                    string company = staffid.StartsWith("hk") ? "KDTHK" : staffid.StartsWith("as") ? "KDAS" : "KDHK";

                    string query = string.Format("if exists (select * from TB_STAFF where st_staffid = '{0}')" +
                        " update TB_STAFF set st_name = N'{1}', st_company = '{2}' where st_staffid = '{0}' else" +
                        " insert into TB_STAFF (st_staffid, st_name, st_company) values ('{0}', N'{1}', '{2}')", staffid, name, company);
                    DataServiceEducation.GetInstance().ExecuteNonQuery(query);
                }
            }
            MessageBox.Show("Record has been saved.");
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadData("");
        }

        private void kDTHKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadData("KDTHK");
        }

        private void kDASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadData("KDAS");
        }

        private void kDHKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadData("KDHK");
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Delete user " + dgvStaff.SelectedRows[0].Cells[0].Value.ToString() + " ? All related record will be deleted.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    string query = string.Format("delete from TB_STAFF where st_staffid = '{0}'", dgvStaff.SelectedRows[0].Cells[0].Value.ToString());
                    DataServiceEducation.GetInstance().ExecuteNonQuery(query);
                    MessageBox.Show("Record has been saved");
                    this.LoadData("");
                    break;

                case DialogResult.No:
                    break;
            }
        }
    }
}
