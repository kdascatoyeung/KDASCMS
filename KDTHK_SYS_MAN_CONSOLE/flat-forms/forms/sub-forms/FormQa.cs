using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.lists;
using KDTHK_SYS_MAN_CONSOLE.services;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms
{
    public partial class FormQa : Form
    {
        string _mode = "";

        public FormQa(string item, string mode)
        {
            InitializeComponent();

            this.Text = mode == "question" ? "Item List - Question" : "Item List - Answer";

            txtItem.Text = item;

            _mode = mode;

            GlobalService.QaList = GlobalService.QaList.Distinct().ToList();

            foreach (QaList qa in GlobalService.QaList)
            {
                if (mode == "question")
                    if (qa.Question == item)
                        dgvQa.Rows.Add(qa.Question, qa.Answer, qa.Id);
                    else
                        continue;
                else
                    if (qa.Answer == item)
                        dgvQa.Rows.Add(qa.Question, qa.Answer, qa.Id);
                    else
                        continue;
            }

            for (int i = 0; i < dgvQa.Rows.Count; i++)
            {
                var rowCompare = dgvQa.Rows[i];

                foreach (DataGridViewRow row in dgvQa.Rows)
                {
                    if (rowCompare.Equals(row)) continue;

                    bool duplicated = true;

                    for (int index = 0; index < row.Cells.Count; index++)
                    {
                        if ((null != rowCompare.Cells[index].Value) && (!rowCompare.Cells[index].Value.Equals(row.Cells[index].Value)))
                        {
                            duplicated = false;
                            break;
                        }
                    }

                    if (duplicated)
                        dgvQa.Rows.Remove(row);
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            GlobalService.SelectedQaItem = txtItem.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnReference_Click(object sender, EventArgs e)
        {
            GlobalService.SelectedQaItem = txtItem.Text;
            DialogResult = DialogResult.Ignore;
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvQa.Rows.Clear();

            foreach (QaList item in GlobalService.QaList)
            {
                if (_mode == "question")
                {
                    if (item.Question.ToLower().Contains(txtItem.Text.ToLower()))
                        dgvQa.Rows.Add(item.Question, item.Answer, item.Id);
                }
                else
                {
                    if (item.Answer.ToLower().Contains(txtItem.Text.ToLower()))
                        dgvQa.Rows.Add(item.Question, item.Answer, item.Id);
                }
            }
        }

        private void dgvQa_DoubleClick(object sender, EventArgs e)
        {
            if (dgvQa.SelectedRows == null)
                return;

            txtItem.Text = _mode == "question" ? dgvQa.SelectedRows[0].Cells[0].Value.ToString() : dgvQa.SelectedRows[0].Cells[1].Value.ToString();

            FormQaSetup setup = new FormQaSetup("edit", dgvQa.SelectedRows[0].Cells[2].Value.ToString().Trim());
            if (setup.ShowDialog() == DialogResult.OK)
                LoadData();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormQaSetup setup = new FormQaSetup("", "");
            if (setup.ShowDialog() == DialogResult.OK)
            {
                LoadData();
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
                        if (dgvQa.SelectedRows.Count > 1)
                            modifyToolStripMenuItem.Enabled = false;
                    }
                }
            }
            else
                e.Cancel = true;
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQaSetup setup = new FormQaSetup("edit", dgvQa.SelectedRows[0].Cells[2].Value.ToString().Trim());
            if (setup.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvQa.SelectedRows)
            {
                string id = row.Cells[2].Value.ToString();

                string query = string.Format("delete from TB_IT_QA where q_id = '{0}'", id);
                DataServiceIT.GetInstance().ExecuteNonQuery(query);
            }

            LoadData();
        }
    }
}
