using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using CustomUtil.utils.authentication;
using KDTHK_SYS_MAN_CONSOLE.forms.utils;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms
{
    public partial class FormR3 : Form
    {
        string _attachment = "";
        string _chaseno = "";
        string _cmApprover = "";

        public FormR3(string chaseno)
        {
            InitializeComponent();

            _chaseno = chaseno;

            LoadData(chaseno);
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LoadData(string chaseno)
        {
            string query = string.Format("select r_category, r_type, r_r3id, r_request, r_reason, r_start, r_attachment, r_status, r_applicant, r_title, r_cmapprover from TB_FORM_R3 where r_chaseno = '{0}'", chaseno);
            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    txtType.Text = reader.GetString(0);
                    txtR3Type.Text = reader.GetString(1);
                    txtR3Id.Text = reader.GetString(2);
                    txtRequest.Text = reader.GetString(3);
                    txtReason.Text = reader.GetString(4);
                    txtStart.Text = reader.GetString(5);
                    txtApplicant.Text = reader.GetString(8);
                    string attachment = reader.GetString(6);
                    _cmApprover = reader.GetString(10);

                    if (attachment != "")
                    {
                        lklAttachment.Text = Path.GetFileName(attachment);
                        _attachment = attachment;
                    }
                    else
                        lklAttachment.Text = "No Attachment";
                }
            }
        }

        private void lklAttachment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_attachment != "")
                Process.Start(_attachment);
        }

        private void txtAttachment_DoubleClick(object sender, EventArgs e)
        {
            BrowseFile();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            BrowseFile();
        }

        private void BrowseFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtAttachment.Text = ofd.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAttachment.Text == "")
            {
                switch (MessageBox.Show("No Attachment found. Continue?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        string query = string.Format("update TB_FORM_R3 set r_itattachment = N'{0}', r_status = N'經管承認中' where r_chaseno = '{1}'", "", _chaseno);
                        DataService.GetInstance().ExecuteNonQuery(query);

                        break;

                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                string query = string.Format("update TB_FORM_R3 set r_itattachment = N'{0}', r_status = N'經管承認中' where r_chaseno = '{1}'", txtAttachment.Text.Trim(), _chaseno);
                DataService.GetInstance().ExecuteNonQuery(query);
            }

            string from = AdUtil.GetEmailByUsername(txtApplicant.Text.Trim(), "kmhk.local");

            string to = AdUtil.GetEmailByUsername(_cmApprover, "kmhk.local");

            string text = "IT Application Approval required. Please click <a href=\"\\\\kdthk-dm1\\project\\it system\\MyCloud Beta\\KDTHK-DM-SP.application\">HERE</a> to approval process.";
            string body = "<p><span style=\"font-family: Calibri;\">" + text + "</span></p>";
            EformUtil.SendApprovalEmail(_chaseno, from, to, body, "R3申請", txtApplicant.Text.Trim());


        }
    }
}
