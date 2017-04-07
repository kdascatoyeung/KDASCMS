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
using System.Diagnostics;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms
{
    public partial class SFormSupport : UserControl
    {
        public event EventHandler SavedEvent;

        public SFormSupport()
        {
            InitializeComponent();

            LoadHardware();

            LoadSoftware();

            cbStatus.SelectedIndex = 0;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string hardware = cbHardware.SelectedItem.ToString();
            string software = cbSoftware.SelectedItem.ToString();
            string status = cbStatus.SelectedItem.ToString();

            string question = txtQuestion.Text;
            string solution = txtSolution.Text;

            string category = hardware == "---" && software == "---" ? "Others" : hardware != "---" ? "Hardware" : "Software";

            string assigned = cbAssign.SelectedItem.ToString().Trim();

            if (status == "Process") status = "I.T.處理中";
            if (status == "Completed") status = "申請處理完成";

            string start = DataUtil.GetStartDate(GlobalService.ChaseNo);
            string end = DataUtil.GetEndDate(GlobalService.ChaseNo);

            string chaseno = DataUtil.GetSupportChaseNo();

            if (question.Contains("'"))
                question = question.Replace("'", "''");

            if (solution.Contains("'"))
                solution = solution.Replace("'", "''");

            string query = string.Format("insert into TB_FORM_SUPPORT (s_refno, s_hardware, s_software, s_status, s_question, s_answer, s_created, s_createdby, s_category, s_start, s_end, s_chaseno, s_handledby)" +
                " values ('{0}', '{1}', '{2}', '{3}', N'{4}', N'{5}', '{6}', N'{7}', '{8}', '{9}', '{10}', '{11}', N'{12}')", GlobalService.ChaseNo, hardware, software, status, question, solution, DateTime.Today.ToString("yyyy/MM/dd"), GlobalService.User, category, start, end, chaseno, assigned);

            DataService.GetInstance().ExecuteNonQuery(query);

            GlobalService.SavedForm = "support";

            //string text = string.Format("update TB_FORM set f_status = N'申請處理完成' where f_chaseno = '{0}' and f_type = N'技術支援'", GlobalService.ChaseNo);
            //DataService.GetInstance().ExecuteNonQuery(text);

            if (SavedEvent != null)
                SavedEvent(this, new EventArgs());
        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            lbSuggestionQuestion.Items.Clear();
            lbSuggestionAnswer.Items.Clear();

            foreach (QaList item in GlobalService.QaList)
            {
                if (txtQuestion.Text != "")
                {
                    if (item.Question.ToLower().Contains(txtQuestion.Text.ToLower()))
                    {
                        if (!lbSuggestionQuestion.Items.Contains(item.Question))
                            lbSuggestionQuestion.Items.Add(item.Question);

                        if (!lbSuggestionAnswer.Items.Contains(item.Answer))
                            lbSuggestionAnswer.Items.Add(item.Answer);
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

                lbSuggestionAnswer.Items.Clear();

                foreach (QaList qa in GlobalService.QaList)
                {
                    if (txtQuestion.Text != "")
                    {
                        if (qa.Question.ToLower().Contains(GlobalService.SelectedQaItem.ToLower()))
                        {
                            if (!lbSuggestionAnswer.Items.Contains(qa.Answer))
                                lbSuggestionAnswer.Items.Add(qa.Answer);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + ex.StackTrace);
            }
        }

        private void lbSuggestionAnswer_DoubleClick(object sender, EventArgs e)
        {
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

        
    }
}
