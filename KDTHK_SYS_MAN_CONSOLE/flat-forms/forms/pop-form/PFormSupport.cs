using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.services;
using KDTHK_SYS_MAN_CONSOLE.lists;
using KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms;
using System.Diagnostics;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.pop_form
{
    public partial class PFormSupport : Form
    {
        string _chaseno = "";
        string _mode = "";

        public PFormSupport(string chaseno, string mode)
        {
            InitializeComponent();

            LoadApplicationData(chaseno);

            LoadHardware();
            LoadSoftware();

            LoadData(chaseno);

            _chaseno = chaseno;

            LoadQuestions();
            LoadAnswers();

            if (mode == "completed")
            {
                ckbComplete.Visible = false;
                txtQuestion.KeyPress += new KeyPressEventHandler(KeyPressed);
                txtSolution.KeyPress += new KeyPressEventHandler(KeyPressed);
                btnAdd.Enabled = false;
                cbHardware.Enabled = false;
                cbSoftware.Enabled = false;
            }

            _mode = mode;

            foreach (string item in GlobalService.ITList)
                cbAssign.Items.Add(item.Trim());

            cbAssign.SelectedIndex = 0;
        }

        private void LoadHardware()
        {
            cbHardware.Items.Add("---");

            foreach (string item in GlobalService.HardwareList)
                if (!cbHardware.Items.Contains(item))
                    cbHardware.Items.Add(item);

            cbHardware.SelectedIndex = 0;
        }

        private void LoadSoftware()
        {
            cbSoftware.Items.Add("---");

            foreach (string item in GlobalService.SoftwareList)
                if (!cbSoftware.Items.Contains(item))
                    cbSoftware.Items.Add(item);

            cbSoftware.SelectedIndex = 0;
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LoadApplicationData(string chaseno)
        {
            //Debug.WriteLine(chaseno);
            string refno = DataUtil.GetRefNo("support", chaseno);

            string query = string.Format("select f_applicant, f_content, f_start, f_end, f_title from TB_FORM where f_chaseno = '{0}'", refno);
            //Debug.WriteLine("Query : " + query);

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    txtName.Text = reader.GetString(0);
                    Byte[] content = new Byte[Convert.ToInt32((reader.GetBytes(1, 0, null, 0, Int32.MaxValue)))];
                    long bytesReceived = reader.GetBytes(1, 0, content, 0, content.Length);
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    rtbContent.Rtf = encoding.GetString(content, 0, Convert.ToInt32(bytesReceived));

                    txtStart.Text = reader.GetString(2);
                    txtEnd.Text = reader.GetString(3);
                    txtTitle.Text = reader.GetString(4);
                }
            }
        }

        private void LoadData(string chaseno)
        {
            string query = chaseno.StartsWith("IT-S") ? string.Format("select s_hardware, s_software, s_question, s_answer from TB_FORM_SUPPORT where s_chaseno = '{0}'", chaseno)
                : string.Format("select s_hardware, s_software, s_question, s_answer from TB_FORM_SUPPORT where s_refno = '{0}'", chaseno);

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string hardware = reader.GetString(0);
                    string software = reader.GetString(1);
                    string question = reader.GetString(2);
                    string answer = reader.GetString(3);

                    cbHardware.Text = hardware;
                    cbSoftware.Text = software;
                    txtQuestion.Text = question;
                    txtSolution.Text = answer;
                }
            }
        }

        private void LoadQuestions()
        {
            string query = "select q_question from TB_IT_QA order by q_question";
            using (IDataReader reader = DataServiceIT.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string item = reader.GetString(0).Trim();
                    if (!lbSuggestionQuestion.Items.Contains(item))
                        lbSuggestionQuestion.Items.Add(item);
                }
            }
        }

        private void LoadAnswers()
        {
            string query = "select q_answer from TB_IT_QA order by q_answer";
            using (IDataReader reader = DataServiceIT.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string item = reader.GetString(0).Trim();
                    if (!lbSuggestionAnswer.Items.Contains(item))
                        lbSuggestionAnswer.Items.Add(item);
                }
            }
        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            lbSuggestionQuestion.Items.Clear();

            foreach (QaList item in GlobalService.QaList)
            {
                if (txtQuestion.Text != "")
                {
                    if (item.Question.ToLower().Contains(txtQuestion.Text.ToLower()))
                    {
                        if (!lbSuggestionQuestion.Items.Contains(item.Question))
                            lbSuggestionQuestion.Items.Add(item.Question);
                    }
                }
            }
        }

        private void txtSolution_TextChanged(object sender, EventArgs e)
        {
            lbSuggestionAnswer.Items.Clear();

            foreach (QaList item in GlobalService.QaList)
            {
                if (txtSolution.Text != "")
                {
                    if (item.Answer.ToLower().Contains(txtSolution.Text.ToLower()))
                    {
                        if (!lbSuggestionAnswer.Items.Contains(item.Answer))
                            lbSuggestionAnswer.Items.Add(item.Answer);
                    }
                }
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

        private void lbSuggestionQuestion_DoubleClick(object sender, EventArgs e)
        {
            if (lbSuggestionQuestion.Items.Count == 0)
                return;

            try
            {
                string item = lbSuggestionQuestion.SelectedItem.ToString();

                FormQa form = new FormQa(item, "question");
                switch (form.ShowDialog())
                {
                    case DialogResult.OK:
                        txtQuestion.Text = GlobalService.SelectedQaItem;
                        break;

                    case DialogResult.Ignore:
                        txtQuestion.Text = txtQuestion.Text + " Ref: ( " + GlobalService.SelectedQaItem + " )";
                        break;

                    default: break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + ex.StackTrace);
            }
            //lbSuggestionAnswer.Items.Clear();

            /*foreach (QaList qa in GlobalService.QaList)
            {
                if (txtQuestion.Text != "")
                {
                    if (qa.Question.ToLower().Contains(GlobalService.SelectedQaItem.ToLower()))
                    {
                        if (!lbSuggestionAnswer.Items.Contains(qa.Answer))
                            lbSuggestionAnswer.Items.Add(qa.Answer);
                    }
                }
            }*/
        }

        private void lbSuggestionAnswer_DoubleClick(object sender, EventArgs e)
        {
            if (lbSuggestionAnswer.Items.Count == 0)
                return;

            try
            {
                string item = lbSuggestionAnswer.SelectedItem.ToString();

                FormQa form = new FormQa(item, "answer");
                switch (form.ShowDialog())
                {
                    case DialogResult.OK:
                        txtSolution.Text = GlobalService.SelectedQaItem;
                        break;

                    case DialogResult.Ignore:
                        txtSolution.Text = txtSolution.Text + " Ref: ( " + GlobalService.SelectedQaItem + " )";
                        break;

                    default: break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + ex.StackTrace);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string question = txtQuestion.Text;
            string solution = txtSolution.Text;

            switch (MessageBox.Show("Store following information as permanent item?\n\nQuestion: " + question + "\nSolution: " + solution + "\n", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    string query = string.Format("if not exists (select * from TB_IT_QA where q_question = N'{0}' and q_answer = N'{1}')" +
                        " insert into TB_IT_QA (q_question, q_answer) values (N'{0}', N'{1}')", question, solution);
                    DataServiceIT.GetInstance().ExecuteNonQuery(query);

                    MessageBox.Show("Record has been added.");
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == "completed")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                string hardware = cbHardware.SelectedItem.ToString();
                string software = cbSoftware.SelectedItem.ToString();

                string question = txtQuestion.Text;
                string solution = txtSolution.Text;

                string assigned = cbAssign.SelectedItem.ToString().Trim();

                string category = hardware == "---" && software == "---" ? "Others" : hardware != "---" ? "Hardware" : "Software";

                string query = string.Format("update TB_FORM_SUPPORT set s_hardware = '{0}', s_software = '{1}', s_question = N'{2}', s_answer = N'{3}', s_category = '{4}', s_handledby = N'{6}' where s_chaseno = '{5}'", hardware, software, question, solution, category, _chaseno, assigned);
                DataService.GetInstance().ExecuteNonQuery(query);

                if (ckbComplete.Checked)
                {
                    string text = string.Format("update TB_FORM_SUPPORT set s_status = N'申請處理完成' where s_chaseno = '{0}'", _chaseno);
                    DataService.GetInstance().ExecuteNonQuery(text);
                }

                DialogResult = DialogResult.OK;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure to delete this item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:

                    string query = string.Format("delete from TB_FORM_SUPPORT where s_chaseno = '{0}'", _chaseno);
                    DataService.GetInstance().ExecuteNonQuery(query);

                    DialogResult = DialogResult.OK;

                    break;

                case DialogResult.No:
                    break;
            }
        }
    }
}
