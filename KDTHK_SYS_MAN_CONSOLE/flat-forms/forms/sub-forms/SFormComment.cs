using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.services;
using System.Data.SqlClient;
using System.IO;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms
{
    public partial class SFormComment : UserControl
    {
        public event EventHandler SavedEvent;

        public SFormComment()
        {
            InitializeComponent();

            cbItem.SelectedIndex = 0;

            cbStatus.SelectedIndex = 1;

            foreach (string item in GlobalService.ITList)
                cbAssign.Items.Add(item.Trim());

            cbAssign.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string item = cbItem.SelectedItem.ToString();
            string status = cbStatus.SelectedItem.ToString();
            string question = txtQuestion.Text;
            string solution = txtSolution.Text;

            string assigned = cbAssign.SelectedItem.ToString().Trim();

            string applicant = DataUtil.GetApplicant(GlobalService.ChaseNo);

            string chaseno = DataUtil.GetCommentChaseNo();

            string st = status == "Completed" ? "申請處理完成" : "I.T處理中";

            /* Start of Add by Cato Yeung on 2017/04/07 */
            string query = string.Format("insert into TB_FORM_COMMENT (c_chaseno, c_item, c_status, c_question, c_answer, c_applicant, c_created, c_createdby, c_refno, c_handledby)" +
                " values ('{0}', N'{1}', '{2}', N'{3}', @Answer, N'{4}', '{5}', N'{6}', '{7}', N'{8}')", chaseno, item, st, question, applicant, DateTime.Today.ToString("yyyy/MM/dd"), GlobalService.User, GlobalService.ChaseNo, assigned);

            
            txtSolution.SaveFile("temp.rtf");
            FileStream stream = new FileStream("temp.rtf", FileMode.Open, FileAccess.Read);
            int size = Convert.ToInt32(stream.Length);
            Byte[] rtf = new Byte[size];
            stream.Read(rtf, 0, size);

            SqlCommand cmd = new SqlCommand(query, DataService.GetInstance().Connection);
            SqlParameter param = new SqlParameter("@Answer", SqlDbType.Image, rtf.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, rtf);
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            /* End of Add by Cato Yeung on 2017/04/07 */

            //DataService.GetInstance().ExecuteNonQuery(query); /* Commented out by Cato Yeung on 2017/04/07 */

            //GlobalService.SavedForm = "comment";

            if (SavedEvent != null)
                SavedEvent(this, new EventArgs());
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
    }
}
