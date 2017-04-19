using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using KDTHK_SYS_MAN_CONSOLE.services;
using System.IO;
using System.Data.SqlClient;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.pop_form
{
    public partial class PFormComment : Form
    {
        string _mode = "";
        string _chaseno = "";

        public PFormComment(string chaseno, string mode)
        {
            InitializeComponent();

            _mode = mode;

            LoadApplicationData(chaseno);

            LoadData(chaseno);

            /*if (mode == "completed")
            {
                btnSave.Enabled = false;
                btnComplete.Enabled = false;
            }*/

            _chaseno = chaseno;

            /*cbAssign.Items.Add("---");

            foreach (string item in GlobalService.ITList)
                cbAssign.Items.Add(item.Trim());*/

            //cbAssign.SelectedIndex = 0;
            //btnSave.Click += new EventHandler(this.btnSave_Click);
            //btnComplete.Click += new EventHandler(this.btnComplete_Click);
            DialogResult = DialogResult.OK;
        }

        private void LoadApplicationData(string chaseno)
        {
            string refno = chaseno.StartsWith("IT-C") ? DataUtil.GetRefNo("comment", chaseno) : chaseno;

            string query = string.Format("select f_applicant, c_question, f_start, f_end, f_title, f_handleby, c_answer from TB_FORM, TB_FORM_COMMENT where f_chaseno = c_refno and f_chaseno = '{0}'", refno);
            //Debug.WriteLine("Query: " + query);

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    txtName.Text = reader.GetString(0);
                    txtQuestion.Text = reader.GetString(1);

                    txtStart.Text = reader.GetString(2);
                    txtEnd.Text = reader.GetString(3);

                    txtTitle.Text = reader.GetString(4);

                    txtAssignTo.Text = reader.GetString(5);

                    Byte[] content = new Byte[Convert.ToInt32((reader.GetBytes(6, 0, null, 0, Int32.MaxValue)))];
                    long bytesReceived = reader.GetBytes(6, 0, content, 0, content.Length);
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    txtSolution.Rtf = encoding.GetString(content, 0, Convert.ToInt32(bytesReceived));
                }
            }
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LoadData(string chaseno)
        {
            //string query = string.Format("select c_handledby from TB_FORM_COMMENT where c_chaseno = '{0}'", chaseno);
            //cbAssign.Text = DataService.GetInstance().ExecuteScalar(query).ToString().Trim();

            /* Modified By Cato Yeung on 2017/04/07 */
            /* Original:
            string query = string.Format("select c_handledby, c_answer from TB_FORM_COMMENT where c_chaseno = '{0}'", chaseno);
            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    cbAssign.Text = reader.GetString(0).Trim();
                    Byte[] content = new Byte[Convert.ToInt32((reader.GetBytes(1, 0, null, 0, Int32.MaxValue)))];
                    long bytesReceived = reader.GetBytes(1, 0, content, 0, content.Length);
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    rtbReply.Rtf = encoding.GetString(content, 0, Convert.ToInt32(bytesReceived));
                }
            }
            */
            string query = string.Format("select c_handledby, c_question, c_answer from TB_FORM_COMMENT where c_chaseno = '{0}'", chaseno);
            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    txtAssignTo.Text = reader.GetString(0).Trim();
                    txtQuestion.Text = reader.GetString(1).Trim();

                    Byte[] content = new Byte[Convert.ToInt32((reader.GetBytes(2, 0, null, 0, Int32.MaxValue)))];
                    long bytesReceived = reader.GetBytes(2, 0, content, 0, content.Length);
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    txtSolution.Rtf = encoding.GetString(content, 0, Convert.ToInt32(bytesReceived));
                }
            }
        }

        /*private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.White;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.FromArgb(58, 58, 58);
        }*/

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtSolution.SaveFile("temp.rtf");
            FileStream stream = new FileStream("temp.rtf", FileMode.Open, FileAccess.Read);
            int size = Convert.ToInt32(stream.Length);
            Byte[] rtf = new Byte[size];
            stream.Read(rtf, 0, size);

            string query = string.Format("update TB_FORM_COMMENT set c_question = N'{0}', c_answer = @Answer where c_chaseno = '{1}'", txtQuestion.Text, _chaseno);
            SqlCommand cmd = new SqlCommand(query, DataService.GetInstance().Connection);

            SqlParameter param = new SqlParameter("@Answer", SqlDbType.Image, rtf.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, rtf);
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();

            DialogResult = DialogResult.OK;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            txtSolution.SaveFile("temp.rtf");
            FileStream stream = new FileStream("temp.rtf", FileMode.Open, FileAccess.Read);
            int size = Convert.ToInt32(stream.Length);
            Byte[] rtf = new Byte[size];
            stream.Read(rtf, 0, size);

            string query = string.Format("update TB_FORM_COMMENT set c_status = N'申請處理完成', c_question = N'{0}', c_answer = @Answer where c_chaseno = '{1}'", txtQuestion.Text, _chaseno);
            SqlCommand cmd = new SqlCommand(query, DataService.GetInstance().Connection);

            SqlParameter param = new SqlParameter("@Answer", SqlDbType.Image, rtf.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, rtf);
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();

            DialogResult = DialogResult.OK;
        }
    }
}
