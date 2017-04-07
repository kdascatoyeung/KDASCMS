using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomUtil.utils.buffer;
using System.Data.SqlClient;
using KDTHK_SYS_MAN_CONSOLE.services;
using KDTHK_SYS_MAN_CONSOLE.utils;
using System.Diagnostics;
using CustomUtil.utils.import;

namespace KDTHK_SYS_MAN_CONSOLE.forms.education
{
    public partial class EducationAnswers : UserControl
    {
        public EducationAnswers()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvQuestion, true);

            this.LoadData();
        }

        private void LoadData()
        {
            string query = "select q_id as id, q_content as content, q_contentjp as contentjp" +
                ", q_mgtno as mgtno from TB_QUESTION order by q_mgtno";

            DataTable table = new DataTable();

            SqlDataAdapter sda = new System.Data.SqlClient.SqlDataAdapter(query, DataServiceEducation.GetInstance().Connection);
            sda.Fill(table);

            dgvQuestion.DataSource = table;
        }

        private void dgvQuestion_DoubleClick(object sender, EventArgs e)
        {
            if (dgvQuestion.SelectedRows == null)
                return;

            string id = dgvQuestion.SelectedRows[0].Cells[0].Value.ToString();

            EducationAnswersInput form = new EducationAnswersInput(id);
            if (form.ShowDialog() == DialogResult.OK)
                this.LoadData();
        }

        private void tsbtnTemplate_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Excel Files |*.xls"
            };

            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                    foreach (DataRow row in table.Rows)
                    {
                        string refno = row.ItemArray[1].ToString();
                        string type = row.ItemArray[3].ToString();
                        string question = row.ItemArray[4].ToString();
                        string ansA = row.ItemArray[5].ToString();
                        string ansB = row.ItemArray[6].ToString();
                        string ansC = row.ItemArray[7].ToString();
                        string ansD = row.ItemArray[8].ToString();
                        string correct = row.ItemArray[9].ToString();
                        string questionjp = row.ItemArray[10].ToString();
                        string ansAjp = row.ItemArray[11].ToString();
                        string ansBjp = row.ItemArray[12].ToString();
                        string ansCjp = row.ItemArray[13].ToString();
                        string ansDjp = row.ItemArray[14].ToString();
                        string path = row.ItemArray[15].ToString();
                        string pathjpy = row.ItemArray[16].ToString();
                        string aspath = row.ItemArray[17].ToString();
                        string aspathjpy = row.ItemArray[18].ToString();

                        int typeid = EducationUtil.GetTypeId(type);

                        int count = 0;

                        string questiontext = string.Format("insert into TB_QUESTION (q_content, q_type" +
                            ", q_typeid, q_contentjp, q_mgtno, q_path, q_pathjpy, q_aspath, q_aspathjpy)" +
                            " values (N'{0}', '{1}', '{2}', N'{3}', '{4}', N'{5}', N'{6}', N'{7}', N'{8}')", question,
                            type, typeid, questionjp, refno, path, pathjpy, aspath, aspathjpy);

                        DataService.GetInstance().ExecuteNonQuery(questiontext);

                        int questionid = EducationUtil.GetQuestionId(question);

                        string[] array = { "A.", "B.", "C.", "D." };

                        for (int i = 0; i < 4; i++)
                        {
                            string symbol = array[i];
                            string ans = symbol == "A." ? ansA : symbol == "B." ? ansB : symbol == "C." ? ansC : ansD;
                            string ansjp = symbol == "A." ? ansAjp : symbol == "B." ? ansBjp : symbol == "C." ? ansCjp : ansDjp;
                            string cor = correct == symbol ? "True" : "False";
                            string answertext = string.Format("insert into TB_ANSWER (a_questionid, a_symbol, a_answer" +
                                ", a_answerjp, a_correct) values ('{0}', '{1}', N'{2}', N'{3}', '{4}')", questionid, symbol, ans, ansjp, cor);

                            DataService.GetInstance().ExecuteNonQuery(answertext);
                        }
                    }
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + ex.StackTrace);
            }
        }
    }
}
