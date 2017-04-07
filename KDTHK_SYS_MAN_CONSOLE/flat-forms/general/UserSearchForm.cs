using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using KDTHK_SYS_MAN_CONSOLE.services;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.general
{
    public partial class UserSearchForm : Form
    {
        public UserSearchForm()
        {
            InitializeComponent();
        }

        private void LoadData(string source)
        {
            DataTable table = new DataTable();

            string query = string.Format("select fd_staff as name from TB_DIVISION_FOLDER where fd_staff like N'%{0}%'", source);

            SqlDataAdapter sda = new SqlDataAdapter(query, DataService.GetInstance().Connection);
            sda.Fill(table);

            dgvUser.DataSource = table;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadData(txtSearch.Text);
        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows == null)
                return;

            GlobalService.SelectedUser = dgvUser.SelectedRows[0].Cells[0].Value.ToString();

            DialogResult = DialogResult.OK;
        }
    }
}
