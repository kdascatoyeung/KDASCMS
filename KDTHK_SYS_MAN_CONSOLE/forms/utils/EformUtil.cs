using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Net.Mail;
using System.Net.Mime;
using System.Diagnostics;

namespace KDTHK_SYS_MAN_CONSOLE.forms.utils
{
    public class EformUtil
    {
        public static List<string> GetItemList(string category)
        {
            List<string> list = new List<string>();

            string query = string.Format("select l_name from TB_FORM_LOANING where l_category = '{0}' and l_status != N'已借出'", category);

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string name = reader.GetString(0).Trim();
                    list.Add(name);
                }
            }
            return list;
        }

        public static void SendNotificationMail(string refNo, string to)
        {
            string hostname = "Kdmail.km.local";

            string from = "itadmin@dthk.kyocera.com";

            string subject = "Application finished. Ref No. : " + refNo;

            string body = "Your item is ready. Please come and pick up";

            SmtpClient client = new SmtpClient(hostname);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            MailMessage mail = new MailMessage(from, to);
            mail.Subject = subject;
            mail.Body = body;

            client.Send(mail);
        }

        public static void SendApprovalEmail(string chaseno, string from, string to, string content, string category, string sender)
        {
            string hostname = "Kdmail.km.local";

            string subject = "Approval Required. Content: " + category;

            SmtpClient client = new SmtpClient(hostname);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            var img = new LinkedResource("images/imgemail.png");
            img.ContentId = Guid.NewGuid().ToString();

            content = content + string.Format(@"<br />Approval Instruction<br /><p></p><img src =""cid:{0}""/>", img.ContentId);

            var view = AlternateView.CreateAlternateViewFromString(content, null, MediaTypeNames.Text.Html);
            view.LinkedResources.Add(img);

            MailMessage mail = new MailMessage(from, to);
            mail.Subject = subject;
            //mail.Body = content;
            mail.AlternateViews.Add(view);
            mail.IsBodyHtml = true;
            client.Send(mail);
        }

        public static void SendApprovalEmailWithAttachment(string chaseno, string from, string to, string content, string category, string sender, string[] attachments)
        {
            string hostname = "Kdmail.km.local";

            string subject = "Approval Required. Content: " + category;

            SmtpClient client = new SmtpClient(hostname);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            var img = new LinkedResource("images/imgemail.png");
            img.ContentId = Guid.NewGuid().ToString();

            content = content + string.Format(@"<br />Approval Instruction<br /><p></p><img src =""cid:{0}""/>", img.ContentId);

            var view = AlternateView.CreateAlternateViewFromString(content, null, MediaTypeNames.Text.Html);
            view.LinkedResources.Add(img);

            MailMessage mail = new MailMessage(from, to);
            mail.Subject = subject;

            foreach (string attachment in attachments)
                mail.Attachments.Add(new Attachment(attachment));
            //mail.Body = content;
            mail.AlternateViews.Add(view);
            mail.IsBodyHtml = true;
            client.Send(mail);
        }

        public static void SendR3ApprovalEmail(string title, string comment, string attachment, string content, string from, string to, string sender)
        {
            try
            {
                string hostname = "Kdmail.km.local";

                string subject = "Approval Required. Content: R3申請 - " + title;

                SmtpClient client = new SmtpClient(hostname);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                var img = new LinkedResource("images/imgemail.png");
                img.ContentId = Guid.NewGuid().ToString();

                string html = "IT Comment: " + comment + "<br/>";

                string body = html + string.Format(@"Approval Instruction<br /><p></p><img src =""cid:{0}""/>", img.ContentId);

                var view = AlternateView.CreateAlternateViewFromString(body, null, MediaTypeNames.Text.Html);
                view.LinkedResources.Add(img);

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, sender, Encoding.UTF8);
                mail.To.Add(to);
                mail.Subject = subject;
                if (attachment != "") mail.Attachments.Add(new Attachment(attachment));
                mail.AlternateViews.Add(view);
                mail.IsBodyHtml = true;
                client.Send(mail);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message + ex.StackTrace);
            }
        }
    }
}
