using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using KDTHK_SYS_MAN_CONSOLE.services;
using KDTHK_SYS_MAN_CONSOLE.utils;
using System.Net.Mail;
using CustomUtil.utils.authentication;
using System.Diagnostics;

namespace KDTHK_SYS_MAN_CONSOLE.forms.education
{
    public partial class EducationMail : UserControl
    {
        public EducationMail()
        {
            InitializeComponent();

            ReadData();

            this.LoadData("Failed", EducationUtil.GetEducation());
        }

        private void ReadData()
        {
            TextReader reader = new StreamReader(@"text\redo.txt");
            txtContent.Text = reader.ReadToEnd();

            txtSubject.Text = "不合格通知";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubject.Text) && string.IsNullOrEmpty(txtContent.Text))
            {
                MessageBox.Show("Please input Subject and Content");
                return;
            }

            string fromEmail = UserUtil.ItUserName3();
            //string fromEmail = "mingfung.lee@dthk.kyocera.com";
            string subject = txtSubject.Text;
            string content = txtContent.Text;

            foreach (DataGridViewRow row in dgvFailedList.Rows)
            {
                try
                {
                    string selected = row.Cells[3].FormattedValue.ToString();

                    string company = row.Cells[0].Value.ToString();
                    string staffid = row.Cells[1].Value.ToString();

                    string domain = company == "KDTHK" ? "kmhk.local" : "kmas.local";

                    if (selected == "True")
                    {
                        string to = AdUtil.GetEmailByUserId(staffid, domain);

                        try
                        {
                            //string hostname = staffid.StartsWith("hk") || staffid.StartsWith("HK") ? "HSP1EXHC.kmhk.local" : "ASP1EX1.kmas.local";
                            string hostname = "HSP1EXHC.kmhk.local";
                            SmtpClient client = new SmtpClient(hostname);
                            client.DeliveryMethod = SmtpDeliveryMethod.Network;

                            using (var message = new MailMessage(fromEmail, to)
                            {
                                Subject = subject,
                                Body = content
                            })
                            {
                                string path = staffid.StartsWith("hk") || staffid.StartsWith("HK") ? @"\\kdthk-dm1\project\IT System\IT Education\IT_Education.zip" : @"\\kmas-dcmain\ITuse\Education\IT_Education.zip";
                                message.Attachments.Add(new Attachment(path));
                                client.Send(message);
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message + ex.StackTrace);
                        }
                    }
                }
                catch (Exception ex)
                {
                    continue;
                }
            }

            MessageBox.Show("Mail has been sent.");
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvFailedList.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[3];
                if (chk.Value == "False")
                    chk.Value = "True";
                else
                    chk.Value = "False";
            }
        }

        private void btnFail_Click(object sender, EventArgs e)
        {
            this.LoadData("Failed", EducationUtil.GetEducation());
        }

        private void btnWaiting_Click(object sender, EventArgs e)
        {
            this.LoadData("Waiting", EducationUtil.GetEducation());
        }

        private void LoadData(string filter, int educationId)
        {
            DataTable table = new DataTable();
            string[] headers = { "company", "staffid", "name", "select" };
            foreach (string header in headers)
                table.Columns.Add(header);

            string query = filter == "Failed" ? string.Format("select st_company as company, st_staffid as staffid, st_name as name from TB_STAFF, TB_RECORD" +
                " where st_name = r_name and r_result = 'Failed' and r_locked = 'locked' and r_educationid = '{0}'", educationId) : string.Format("select st_company as company, st_staffid as staffid, st_name as name from TB_STAFF" +
                " where not exists (select * from TB_RECORD where st_name = r_name and r_educationid = '{0}')", educationId);

            using (IDataReader reader = DataServiceEducation.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string company = reader.GetString(0);
                    string staffId = reader.GetString(1);
                    string name = reader.GetString(2);

                    table.Rows.Add(new object[] { company, staffId, name, "False" });
                }
            }

            dgvFailedList.DataSource = table;
        }
    }
}
