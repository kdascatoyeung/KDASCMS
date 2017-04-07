using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomUtil.utils.import;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.education
{
    public partial class EducationView : UserControl
    {
        EducationResult result = new EducationResult();
        EducationUser user = new EducationUser();
        EducationScore score = new EducationScore();
        EducationReport report = new EducationReport();

        public EducationView()
        {
            InitializeComponent();

            LoadControl(result);
        }

        private void LoadControl(UserControl control)
        {
            customPanel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            customPanel2.Controls.Add(control);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string question = row.ItemArray[0].ToString().Trim();
                    string category = row.ItemArray[1].ToString().Trim();
                    string questionjp = row.ItemArray[2].ToString().Trim();
                    string categoryjp = row.ItemArray[3].ToString().Trim();
                    string answer = row.ItemArray[4].ToString().Trim();
                    string answerjp = row.ItemArray[5].ToString().Trim();
                    string correct = row.ItemArray[6].ToString().Trim();
                    string id = row.ItemArray[7].ToString().Trim();

                    string query = string.Format("if not exists (select * from TB_IT_EDU_QUESTION where q_question = N'{0}') insert into TB_IT_EDU_QUESTION (q_question, q_questionjp, q_type, q_typejp)" +
                        " values (N'{0}', N'{1}', N'{2}', N'{3}')", question, category, questionjp, categoryjp);
                    DataServiceEdu.GetInstance().ExecuteNonQuery(query);

                    string text = string.Format("insert into TB_IT_EDU_ANSWER (a_answer, a_answerjp, a_correct, a_questionid) values (N'{0}', N'{1}', '{2}', '{3}')", answer, answerjp, correct, id);
                    DataServiceEdu.GetInstance().ExecuteNonQuery(text);
                }
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            LoadControl(user);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            LoadControl(result);
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            LoadControl(score);   
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            LoadControl(report);
        }
    }
}
