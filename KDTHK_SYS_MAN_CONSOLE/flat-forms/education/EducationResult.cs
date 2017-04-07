using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.utils;
using System.Diagnostics;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.education
{
    public partial class EducationResult : UserControl
    {
        public EducationResult()
        {
            InitializeComponent();

            LoadData(QuestionList());
        }

        private List<string> QuestionList()
        {
            List<string> list = new List<string>();

            string query = "select q_question from TB_IT_EDU_QUESTION where q_id != 7";
            using (IDataReader reader = DataServiceEdu.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                    list.Add(reader.GetString(0).Trim());
            }

            return list;
        }

        private void LoadData(List<string> list)
        {
            DataTable table = new DataTable();
            string[] headers = { "question", "kdthk", "kdthkno", "kdhk", "kdhkno", "kdas", "kdasno", "total" };
            foreach (string header in headers)
                table.Columns.Add(header);

            List<ResultList> resultList = new List<ResultList>();

            foreach (string question in list)
                table.Rows.Add(question, "0", "0", "0", "0", "0", "0", "0");

            foreach (DataRow row in table.Rows)
            {
                int totalCount = 0;
                int correctCount = 0;
 
                int questionId = EducationUtil.GetQuestionId(row.ItemArray[0].ToString().Trim());

                string query = string.Format("select count(*), sum(case when r_correct = 'Yes' then 1 else 0 end), r_company from TB_IT_EDU_REPORT where r_questionid = '{0}' group by r_company", questionId);
                using (IDataReader reader = DataServiceEdu.GetInstance().ExecuteReader(query))
                {
                    while (reader.Read())
                    {
                        int total = reader.GetInt32(0);
                        int correct = reader.GetInt32(1);

                        double rate = (double)correct / (double)total;
                        rate = Math.Round(rate, 2) * 100;
                        string company = reader.GetString(2).Trim();

                        totalCount = totalCount + total;
                        correctCount = correctCount + correct;

                        if (company == "KDTHK")
                        {
                            row["kdthk"] = correct + "/" + total + " (" + rate + "%)";
                            row["kdthkno"] = total;
                        }

                        if (company == "KDHK")
                        {
                            row["kdhk"] = correct + "/" + total + " (" + rate + "%)";
                            row["kdhkno"] = total;
                        }

                        if (company == "KDAS")
                        {
                            row["kdas"] = correct + "/" + total + " (" + rate + "%)";
                            row["kdasno"] = total;
                        }
                    }
                }

                //Debug.WriteLine("Correct Count: " + correctCount);

                int kdthk = Convert.ToInt32(row["kdthkno"]);
                int kdhk = Convert.ToInt32(row["kdhkno"]);
                int kdas = Convert.ToInt32(row["kdasno"]);

                int sum = kdthk + kdhk + kdas;

                double totalRate = (double)correctCount / (double)sum;
                totalRate = Math.Round(totalRate, 2) * 100;

                row["total"] = correctCount + "/" + sum + " (" + totalRate + "%)";
            }

            dgvResult.DataSource = table;
        }
    }

    public class ResultList
    {
        public string Question { get; set; }
        public int Correct { get; set; }
        public int Total { get; set; }
        public string Company { get; set; }
    }
}
