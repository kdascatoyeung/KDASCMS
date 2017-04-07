using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.services;
using KDTHK_SYS_MAN_CONSOLE.lists;
using KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.setup
{
    public partial class SetupView : UserControl
    {
        string _item = "";
        string _hardware = "";
        string _software = "";

        public SetupView()
        {
            InitializeComponent();

            LoadData();

            LoadHardware();

            LoadSoftware();

            LoadQAData();
        }

        private void LoadData()
        {
            dgvItems.Rows.Clear();

            string query = "select i_id, i_item from TB_IT_ITEMS";
            using (IDataReader reader = DataServiceIT.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                    dgvItems.Rows.Add(reader.GetInt32(0), reader.GetString(1).Trim());
            }
        }

        private void LoadHardware()
        {
            dgvHardware.Rows.Clear();

            string query = "select h_id, h_name from TB_IT_HARDWARE";
            using (IDataReader reader = DataServiceIT.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                    dgvHardware.Rows.Add(reader.GetInt32(0), reader.GetString(1).Trim());
            }
        }

        private void LoadSoftware()
        {
            dgvSoftware.Rows.Clear();

            string query = "select s_id, s_name from TB_IT_SOFTWARE";
            using (IDataReader reader = DataServiceIT.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                    dgvSoftware.Rows.Add(reader.GetInt32(0), reader.GetString(1).Trim());
            }
        }

        private void dgvItems_DoubleClick(object sender, EventArgs e)
        {
            string item = dgvItems.SelectedRows[0].Cells[1].Value.ToString().Trim();
            txtItems.Text = item;

            _item = item;
        }

        private void btnItemSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void dgvItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in dgvItems.SelectedRows)
                {
                    string id = row.Cells[0].Value.ToString().Trim();

                    string query = string.Format("delete from TB_IT_ITEMS where i_id = '{0}'", id);
                    DataServiceIT.GetInstance().ExecuteNonQuery(query);
                }

                LoadData();
            }
        }

        private void txtItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SaveData();
        }

        private void SaveData()
        {
            if (txtItems.Text == "")
            {
                MessageBox.Show("Please input Item");
                return;
            }

            string item = txtItems.Text.Trim();

            if (_item != "")
            {
                if (utils.DataUtil.IsItemExist(_item))
                {
                    string query = string.Format("update TB_IT_ITEMS set i_item = N'{0}' where i_item = N'{1}'", item, _item);
                    DataServiceIT.GetInstance().ExecuteNonQuery(query);
                }
                else
                {
                    string query = string.Format("insert into TB_IT_ITEMS (i_item) values (N'{0}')", item);
                    DataServiceIT.GetInstance().ExecuteNonQuery(query);
                }
            }
            else
            {
                string query = string.Format("insert into TB_IT_ITEMS (i_item) values (N'{0}')", item);
                DataServiceIT.GetInstance().ExecuteNonQuery(query);
            }

            LoadData();
        }

        private void txtHardware_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SaveHardware();
        }

        private void btnHardwareSave_Click(object sender, EventArgs e)
        {
            SaveHardware();
        }

        private void SaveHardware()
        {
            if (txtHardware.Text == "")
            {
                MessageBox.Show("Please input hardware");
                return;
            }

            string hardware = txtHardware.Text.Trim();

            if (_hardware != "")
            {
                if (utils.DataUtil.IsHardwareExist(_hardware))
                {
                    string query = string.Format("update TB_IT_HARDWARE set h_name = N'{0}' where h_name = N'{1}'", hardware, _hardware);
                    DataServiceIT.GetInstance().ExecuteNonQuery(query);
                }
                else
                {
                    string query = string.Format("insert into TB_IT_HARDWARE (h_name) values (N'{0}')", hardware);
                    DataServiceIT.GetInstance().ExecuteNonQuery(query);
                }
            }
            else
            {
                string query = string.Format("insert into TB_IT_HARDWARE (h_name) values (N'{0}')", hardware);
                DataServiceIT.GetInstance().ExecuteNonQuery(query);
            }

            LoadHardware();
        }

        private void dgvHardware_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in dgvHardware.SelectedRows)
                {
                    string id = row.Cells[0].Value.ToString().Trim();

                    string query = string.Format("delete from TB_IT_HARDWARE where h_id = '{0}'", id);
                    DataServiceIT.GetInstance().ExecuteNonQuery(query);
                }

                LoadHardware();
            }
        }

        private void txtSoftware_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SaveSoftware();
        }

        private void btnSoftwareSave_Click(object sender, EventArgs e)
        {
            SaveSoftware();
        }

        private void SaveSoftware()
        {
            if (txtSoftware.Text == "")
            {
                MessageBox.Show("Please input software");
                return;
            }

            string software = txtSoftware.Text.Trim();

            if (_software != "")
            {
                if (utils.DataUtil.IsSoftwareExist(_software))
                {
                    string query = string.Format("update TB_IT_SOFTWARE set s_name = N'{0}' where s_name = N'{1}'", software, _software);
                    DataServiceIT.GetInstance().ExecuteNonQuery(query);
                }
                else
                {
                    string query = string.Format("insert into TB_IT_SOFTWARE (s_name) values (N'{0}')", software);
                    DataServiceIT.GetInstance().ExecuteNonQuery(query);
                }
            }
            else
            {
                string query = string.Format("insert into TB_IT_SOFTWARE (s_name) values (N'{0}')", software);
                DataServiceIT.GetInstance().ExecuteNonQuery(query);
            }

            LoadHardware();
        }

        private void dgvSoftware_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow row in dgvSoftware.SelectedRows)
                {
                    string id = row.Cells[0].Value.ToString().Trim();

                    string query = string.Format("delete from TB_IT_SOFTWARE where s_id = '{0}'", id);
                    DataServiceIT.GetInstance().ExecuteNonQuery(query);
                }

                LoadSoftware();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormQaSetup setup = new FormQaSetup("", "");
            if (setup.ShowDialog() == DialogResult.OK)
            {
                LoadQAData();
            }
        }

        private void dgvQa_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvQa.SelectedRows == null)
                    return;

                FormQaSetup setup = new FormQaSetup("edit", dgvQa.SelectedRows[0].Cells[2].Value.ToString().Trim());
                if (setup.ShowDialog() == DialogResult.OK)
                    LoadQAData();
            }
            catch
            {

            }
        }

        private void dgvQa_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvQa.Rows.Count > 0)
            {
                if (((dgvQa.Rows[0].Height * dgvQa.Rows.Count) + dgvQa.ColumnHeadersHeight) < e.Location.Y)
                    dgvQa.ClearSelection();
                else
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        var hti = dgvQa.HitTest(e.X, e.Y);

                        if (dgvQa.SelectedRows.Count == 1)
                        {
                            dgvQa.ClearSelection();

                            if (((dgvQa.Rows[0].Height * dgvQa.Rows.Count) + dgvQa.ColumnHeadersHeight) >= e.Location.Y)
                                dgvQa.Rows[hti.RowIndex].Selected = true;
                        }
                        else
                        {
                            if (((dgvQa.Rows[0].Height * dgvQa.Rows.Count) + dgvQa.ColumnHeadersHeight) >= e.Location.Y)
                                dgvQa.Rows[hti.RowIndex].Selected = true;
                        }
                    }
                }
            }
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQaSetup setup = new FormQaSetup("edit", dgvQa.SelectedRows[0].Cells[2].Value.ToString().Trim());
            if (setup.ShowDialog() == DialogResult.OK)
                LoadQAData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvQa.SelectedRows)
            {
                string id = row.Cells[2].Value.ToString();

                string query = string.Format("delete from TB_IT_QA where q_id = '{0}'", id);
                DataServiceIT.GetInstance().ExecuteNonQuery(query);
            }

            LoadQAData();
        }

        private void LoadQAData()
        {
            dgvQa.Rows.Clear();

            GlobalService.QaList = DataUtil.GetQaList();

            foreach (QaList item in GlobalService.QaList)
                dgvQa.Rows.Add(item.Question, item.Answer, item.Id);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            var cms = (ContextMenuStrip)sender;
            var mousePos = Control.MousePosition;

            if (cms != null)
            {
                var pos = cms.PointToClient(mousePos);
                if (cms.ClientRectangle.Contains(pos))
                {
                    var relpos = dgvQa.PointToClient(mousePos);
                    var hti = dgvQa.HitTest(relpos.X, relpos.Y);
                    if (hti.RowIndex == -1)
                    {
                        //e.Cancel = true;
                        foreach (var item in contextMenuStrip1.Items.OfType<ToolStripMenuItem>())
                            item.Enabled = false;
                    }
                    else
                    {
                        foreach (var item in contextMenuStrip1.Items.OfType<ToolStripMenuItem>())
                            item.Enabled = true;

                        if (dgvQa.SelectedRows.Count > 1)
                            modifyToolStripMenuItem.Enabled = false;
                    }
                }
            }
            else
                e.Cancel = true;
        }
    }
}
