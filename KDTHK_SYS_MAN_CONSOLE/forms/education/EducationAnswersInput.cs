using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.services;

namespace KDTHK_SYS_MAN_CONSOLE.forms.education
{
    public partial class EducationAnswersInput : Form
    {
        string _id;

        public EducationAnswersInput(string id)
        {
            InitializeComponent();

            _id = id;

            this.LoadQuestion(id);

            this.LoadAnswer(id);
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LoadQuestion(string id)
        {
            string query = string.Format("select q_mgtno, q_content, q_contentjp from TB_QUESTION where q_id = '{0}'", id);

            using (IDataReader reader = DataServiceEducation.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string mgtno = reader.GetString(0);
                    string content = reader.GetString(1);
                    string contentjp = reader.GetString(2);

                    txtRef.Text = mgtno;
                    txtContent.Text = content;
                    txtContentJp.Text = contentjp;
                }
            }
        }

        private void LoadAnswer(string id)
        {
            string query = string.Format("select a_symbol, a_answer, a_answerjp, a_correct from TB_ANSWER where a_questionid = '{0}'", id);

            using (IDataReader reader = DataServiceEducation.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string symbol = reader.GetString(0);
                    string answer = reader.GetString(1);
                    string answerjp = reader.GetString(2);
                    string correct = reader.GetString(3);

                    if (symbol == "A.")
                    {
                        txtAnsA.Text = answer;
                        txtAnsJpA.Text = answerjp;
                        ckbAnsA.Checked = correct == "True" ? true : false;
                        ckbAnsJpA.Checked = correct == "True" ? true : false;
                    }

                    else if (symbol == "B.")
                    {
                        txtAnsB.Text = answer;
                        txtAnsJpB.Text = answerjp;
                        ckbAnsB.Checked = correct == "True" ? true : false;
                        ckbAnsJpB.Checked = correct == "True" ? true : false;
                    }

                    else if (symbol == "C.")
                    {
                        txtAnsC.Text = answer;
                        txtAnsJpC.Text = answerjp;
                        ckbAnsC.Checked = correct == "True" ? true : false;
                        ckbAnsJpC.Checked = correct == "True" ? true : false;
                    }

                    else
                    {
                        txtAnsD.Text = answer;
                        txtAnsJpD.Text = answerjp;
                        ckbAnsD.Checked = correct == "True" ? true : false;
                        ckbAnsJpD.Checked = correct == "True" ? true : false;
                    }
                }
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;

            string tag = checkbox.Tag.ToString();

            if (tag == "ansa" || tag == "ansjpa")
            {
                if (checkbox.Checked)
                    foreach (CheckBox control in panel1.Controls)
                        control.Checked = control.Tag != "ansa" && control.Tag != "ansjpa" ? false : true;
            }
            else if (tag == "ansb" || tag == "ansjpb")
            {
                if (checkbox.Checked)
                    foreach (CheckBox control in panel1.Controls)
                        control.Checked = control.Tag != "ansb" && control.Tag != "ansjpb" ? false : true;
            }
            else if (tag == "ansc" || tag == "ansjpc")
            {
                if (checkbox.Checked)
                    foreach (CheckBox control in panel1.Controls)
                        control.Checked = control.Tag != "ansc" && control.Tag != "ansjpc" ? false : true;
            }
            else
            {
                if (checkbox.Checked)
                    foreach (CheckBox control in panel1.Controls)
                        control.Checked = control.Tag != "ansd" && control.Tag != "ansjpd" ? false : true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string mgtno = txtRef.Text;
            string content = txtContent.Text;
            string contentjp = txtContentJp.Text;

            string ansA = txtAnsA.Text;
            string ansB = txtAnsB.Text;
            string ansC = txtAnsC.Text;
            string ansD = txtAnsD.Text;

            string ansJpA = txtAnsJpA.Text;
            string ansJpB = txtAnsJpB.Text;
            string ansJpC = txtAnsJpC.Text;
            string ansJpD = txtAnsJpD.Text;

            string correctA = ckbAnsA.Checked ? "True" : "False";
            string correctB = ckbAnsB.Checked ? "True" : "False";
            string correctC = ckbAnsC.Checked ? "True" : "False";
            string correctD = ckbAnsD.Checked ? "True" : "False";

            string qText = string.Format("update TB_QUESTION set q_mgtno = '{0}', q_content = N'{1}'" +
                ", q_contentjp = N'{2}' where q_id = '{3}'", mgtno, content, contentjp, _id);

            DataServiceEducation.GetInstance().ExecuteNonQuery(qText);

            UpdateAnsA(ansA, ansJpA, correctA, _id);
            UpdateAnsB(ansB, ansJpB, correctB, _id);
            UpdateAnsC(ansC, ansJpC, correctC, _id);
            UpdateAnsD(ansD, ansJpD, correctD, _id);

            MessageBox.Show("Record has been saved");

            this.DialogResult = DialogResult.OK;
        }

        private void UpdateAnsA(string ansA, string ansjpA, string correct, string id)
        {
            string query = string.Format("update TB_ANSWER set a_answer = N'{0}', a_answerjp = N'{1}'" +
                ", a_correct = '{2}' where a_questionid = '{3}' and a_symbol = 'A.'", ansA, ansjpA, correct, id);

            DataServiceEducation.GetInstance().ExecuteNonQuery(query);
        }

        private void UpdateAnsB(string ansB, string ansjpB, string correct, string id)
        {
            string query = string.Format("update TB_ANSWER set a_answer = N'{0}', a_answerjp = N'{1}'" +
                ", a_correct = '{2}' where a_questionid = '{3}' and a_symbol = 'B.'", ansB, ansjpB, correct, id);

            DataServiceEducation.GetInstance().ExecuteNonQuery(query);
        }

        private void UpdateAnsC(string ansC, string ansjpC, string correct, string id)
        {
            string query = string.Format("update TB_ANSWER set a_answer = N'{0}', a_answerjp = N'{1}'" +
                ", a_correct = '{2}' where a_questionid = '{3}' and a_symbol = 'C.'", ansC, ansjpC, correct, id);

            DataServiceEducation.GetInstance().ExecuteNonQuery(query);
        }

        private void UpdateAnsD(string ansD, string ansjpD, string correct, string id)
        {
            string query = string.Format("update TB_ANSWER set a_answer = N'{0}', a_answerjp = N'{1}'" +
                ", a_correct = '{2}' where a_questionid = '{3}' and a_symbol = 'D.'", ansD, ansjpD, correct, id);

            DataServiceEducation.GetInstance().ExecuteNonQuery(query);
        }
    }
}
