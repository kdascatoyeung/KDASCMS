using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.services;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms
{
    public partial class FormQaSetup : Form
    {
        string _id = "";

        public FormQaSetup(string mode, string id)
        {
            InitializeComponent();

            this.Text = mode == "" ? "QA Setup - New" : "QA Setup - Modify";

            if (mode != "")
            {
                _id = id;

                string query = string.Format("select q_question, q_answer from TB_IT_QA where q_id = '{0}'", id);
                using (IDataReader reader = DataServiceIT.GetInstance().ExecuteReader(query))
                {
                    while (reader.Read())
                    {
                        txtQuestion.Text = reader.GetString(0).Trim();
                        txtAnswer.Text = reader.GetString(1).Trim();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string question = txtQuestion.Text.Trim();
            string answer = txtAnswer.Text.Trim();

            if (string.IsNullOrEmpty(question) && string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("Please input Question & Answer.");
                return;
            }

            if (_id == "")
            {
                string query = string.Format("insert into TB_IT_QA (q_question, q_answer) values (N'{0}', N'{1}')", question, answer);
                DataServiceIT.GetInstance().ExecuteNonQuery(query);
            }
            else
            {
                string query = string.Format("update TB_IT_QA set q_question = N'{0}', q_answer = N'{1}' where q_id = '{2}'", question, answer, _id);
                DataServiceIT.GetInstance().ExecuteNonQuery(query);
            }

            MessageBox.Show("Record has been saved.");

            this.DialogResult = DialogResult.OK;
        }
    }
}
