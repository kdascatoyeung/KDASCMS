using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.services;
using System.Diagnostics;
using KDTHK_SYS_MAN_CONSOLE.forms.utils;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms
{
    public partial class FormITUsage2 : Form
    {
        SFormSupport support;
        SFormAsset asset;
        SFormPermission permission;
        SFormDevelopment develop;
        SFormComment comment;
        SFormR3 r3;

        string _chaseno = "";

        public FormITUsage2(string chaseno)
        {
            InitializeComponent();

            LoadData(chaseno);

            _chaseno = chaseno;

            LoadFormCount(chaseno);
        }

        private void LoadControl(UserControl uc)
        {
            pnlForm.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlForm.Controls.Add(uc);
        }

        private void LoadFormCount(string chaseno)
        {
            string q1 = string.Format("select count(*) from TB_FORM_SUPPORT where s_refno = '{0}'", chaseno);
            int r1 = (int)DataService.GetInstance().ExecuteScalar(q1);
            txtSupport.Text = r1.ToString();

            string q2 = string.Format("select count(*) from TB_FORM_PERMISSION where p_refno = '{0}'", chaseno);
            int r2 = (int)DataService.GetInstance().ExecuteScalar(q2);
            txtPermission.Text = r2.ToString();

            string q3 = string.Format("select count(*) from TB_FORM_DEVELOP where d_refno = '{0}'", chaseno);
            int r3 = (int)DataService.GetInstance().ExecuteScalar(q3);
            txtDevelop.Text = r3.ToString();

            string q4 = string.Format("select count(*) from TB_FORM_LOANING where l_refno = '{0}'", chaseno);
            int r4 = (int)DataService.GetInstance().ExecuteScalar(q4);
            txtAsset.Text = r4.ToString();

            string q5 = string.Format("select count(*) from TB_FORM_COMMENT where c_refno = '{0}'", chaseno);
            int r5 = (int)DataService.GetInstance().ExecuteScalar(q5);
            txtComment.Text = r5.ToString();

            string q6 = string.Format("select count(*) from TB_FORM_R3 where r_refno = '{0}'", chaseno);
            int r6 = (int)DataService.GetInstance().ExecuteScalar(q6);
            txtR3.Text = r6.ToString();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tag = btn.Tag.ToString();

            if (tag == "support")
            {
                support = new SFormSupport();
                support.SavedEvent += new EventHandler(SavedEvent);
                LoadControl(support);
            }
            if (tag == "asset")
            {
                asset = new SFormAsset();
                asset.SavedEvent += new EventHandler(SavedEvent);
                LoadControl(asset);
            }
            if (tag == "permission")
            {
                permission = new SFormPermission();
                permission.SavedEvent += new EventHandler(SavedEvent);
                LoadControl(permission);
            }
            if (tag == "develop")
            {
                develop = new SFormDevelopment();
                develop.SavedEvent += new EventHandler(SavedEvent);
                LoadControl(develop);
            }
            if (tag == "comment")
            {
                comment = new SFormComment();
                comment.SavedEvent += new EventHandler(SavedEvent);
                LoadControl(comment);
            }
            if (tag == "r3")
            {
                r3 = new SFormR3();
                r3.SavedEvent += new EventHandler(SavedEvent);
                LoadControl(r3);
            }
        }

        private void SavedEvent(object sender, EventArgs e)
        {
            pnlForm.Controls.Clear();

            if (GlobalService.SavedForm == "support") txtSupport.Text = (Convert.ToInt32(txtSupport.Text) + 1).ToString();
            if (GlobalService.SavedForm == "asset") txtAsset.Text = (Convert.ToInt32(txtAsset.Text) + 1).ToString();
            if (GlobalService.SavedForm == "permission") txtPermission.Text = (Convert.ToInt32(txtPermission.Text) + 1).ToString();
            if (GlobalService.SavedForm == "develop") txtDevelop.Text = (Convert.ToInt32(txtDevelop.Text) + 1).ToString();
            if (GlobalService.SavedForm == "comment") txtComment.Text = (Convert.ToInt32(txtComment.Text) + 1).ToString();
            if (GlobalService.SavedForm == "r3") txtR3.Text = (Convert.ToInt32(txtR3.Text) + 1).ToString();
        }

        private void LoadData(string chaseno)
        {
            string query = string.Format("select f_applicant, f_content, f_type, f_start, f_end, f_approver, f_title from TB_FORM where f_chaseno = '{0}'", chaseno);
            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    txtName.Text = reader.GetString(0);
                    Byte[] content = new Byte[Convert.ToInt32((reader.GetBytes(1, 0, null, 0, Int32.MaxValue)))];
                    long bytesReceived = reader.GetBytes(1, 0, content, 0, content.Length);
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    rtbContent.Rtf = encoding.GetString(content, 0, Convert.ToInt32(bytesReceived));

                    string category = reader.GetString(2);
                    if (category == "IT技術支援")
                        ckbSupport.Checked = true;
                    if (category == "IT意見箱")
                        ckbComment.Checked = true;

                    txtStart.Text = reader.GetString(3);
                    txtEnd.Text = reader.GetString(4);
                    txtApprover.Text = reader.GetString(5);
                    txtTitle.Text = reader.GetString(6);
                }
            }

            lblExt.Text = "Ext. : " + ExtUtil.GetExt(txtName.Text.Trim());
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void btnFinish_Click(object sender, EventArgs e)
        {
            string query = string.Format("update TB_FORM set f_status = N'申請處理完成' where f_chaseno = '{0}'", _chaseno);
            DataService.GetInstance().ExecuteNonQuery(query);

            DialogResult = DialogResult.OK;
        }

        private void btnKeep_Click(object sender, EventArgs e)
        {
            string query = string.Format("update TB_FORM set f_status = N'Hold' where f_chaseno = '{0}'", _chaseno);
            Debug.WriteLine(query);

            DataService.GetInstance().ExecuteNonQuery(query);

            DialogResult = DialogResult.OK;
        }
    }
}
