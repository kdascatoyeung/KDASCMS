using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.lists;
using System.Diagnostics;
using KDTHK_SYS_MAN_CONSOLE.services;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.sub_forms
{
    public partial class FormITUsage : Form
    {
        SFormSupport supportForm = new SFormSupport();
        SFormAsset assetForm = new SFormAsset();
        SFormPermission permissionForm = new SFormPermission();
        SFormDevelopment developForm = new SFormDevelopment();
        SFormComment commentForm = new SFormComment();

        int _support = 0;
        int _asset = 0;
        int _permission = 0;
        int _develop = 0;
        int _comment = 0;

        string _mode = "";

        public FormITUsage(List<FormList> list)
        {
            InitializeComponent();

            var groupedList = list.GroupBy(x => x.Category.Trim()).Select(g => new
            {
                Category = g.Key,
                Count = g.Count()
            });

            foreach (var g in groupedList)
            {
                if (g.Category == "support")
                    txtSupport.Text = g.Count.ToString();

                if (g.Category == "asset")
                    txtAsset.Text = g.Count.ToString();

                if (g.Category == "permission")
                    txtPermission.Text = g.Count.ToString();

                if (g.Category == "develop")
                    txtDevelop.Text = g.Count.ToString();

                if (g.Category == "comment")
                    txtComment.Text = g.Count.ToString();
            }

            LoadData(GlobalService.ChaseNo);

            if (txtSupport.Text == "") txtSupport.Text = "0";
            if (txtAsset.Text == "") txtAsset.Text = "0";
            if (txtPermission.Text == "") txtPermission.Text = "0";
            if (txtDevelop.Text == "") txtDevelop.Text = "0";
            if (txtComment.Text == "") txtComment.Text = "0";

            _support = Convert.ToInt32(txtSupport.Text);
            _asset = Convert.ToInt32(txtAsset.Text);
            _permission = Convert.ToInt32(txtPermission.Text);
            _develop = Convert.ToInt32(txtDevelop.Text);
            _comment = Convert.ToInt32(txtComment.Text);

            Application.Idle += new EventHandler(Application_Idle);

            if (_support > 0)
            {
                _mode = "support";
                _support -= 1;
                supportForm.SavedEvent += new EventHandler(Form_SavedEvent);
                LoadControl(supportForm);
            }
            else if (_asset > 0)
            {
                _mode = "asset";
                _asset -= 1;
                assetForm.SavedEvent += new EventHandler(Form_SavedEvent);
                LoadControl(assetForm);
            }
            else if (_permission > 0)
            {
                _mode = "permission";
                _permission -= 1;
                permissionForm.SavedEvent += new EventHandler(Form_SavedEvent);
                LoadControl(permissionForm);
            }
            else if (_develop > 0)
            {
                _mode = "develop";
                _develop -= 1;
                developForm.SavedEvent += new EventHandler(Form_SavedEvent);
                LoadControl(developForm);
            }
            else
            {
                _mode = "comment";
                _comment -= 1;
                commentForm.SavedEvent += new EventHandler(Form_SavedEvent);
                LoadControl(commentForm);
            }
        }

        void Application_Idle(object sender, EventArgs e)
        {
            /*pbSupport.Image = _support + 1 == 0 ? Properties.Resources.tick_icon : null;
            pbAsset.Image = _asset + 1 == 0 ? Properties.Resources.tick_icon : null;
            pbPermission.Image = _permission + 1 == 0 ? Properties.Resources.tick_icon : null;
            pbDevelop.Image = _develop + 1 == 0 ? Properties.Resources.tick_icon : null;
            pbComment.Image = _comment + 1 == 0 ? Properties.Resources.tick_icon : null;*/
        }

        private void LoadControl(UserControl uc)
        {
            pnlForm.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlForm.Controls.Add(uc);
        }

        private void LoadData(string chaseno)
        {
            string query = string.Format("select f_applicant, f_content, f_type, f_start, f_end, f_approver from TB_FORM where f_chaseno = '{0}'", chaseno);
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
                    if (category == "技術支援")
                        ckbSupport.Checked = true;
                    if (category == "意見箱")
                        ckbComment.Checked = true;

                    txtStart.Text = reader.GetString(3);
                    txtEnd.Text = reader.GetString(4);
                    txtApprover.Text = reader.GetString(5);
                }
            }
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Form_SavedEvent(object sender, EventArgs e)
        {
            if (_support > 0)
            {
                _support -= 1;
                supportForm = new SFormSupport();
                supportForm.SavedEvent += new EventHandler(Form_SavedEvent);
                LoadControl(supportForm);
            }
            else if (_asset > 0)
            {
                _asset -= 1;
                assetForm = new SFormAsset();
                assetForm.SavedEvent += new EventHandler(Form_SavedEvent);
                LoadControl(assetForm);
            }
            else if (_permission > 0)
            {
                _permission -= 1;
                permissionForm = new SFormPermission();
                permissionForm.SavedEvent += new EventHandler(Form_SavedEvent);
                LoadControl(permissionForm);
            }
            else if (_develop > 0)
            {
                _develop -= 1;
                developForm = new SFormDevelopment();
                developForm.SavedEvent += new EventHandler(Form_SavedEvent);
                LoadControl(developForm);
            }
            else if (_comment > 0)
            {
                _comment -= 1;
                commentForm = new SFormComment();
                commentForm.SavedEvent += new EventHandler(Form_SavedEvent);
                LoadControl(commentForm);
            }
            else
            {
                string query = string.Format("update TB_FORM set f_status = N'完成' where f_chaseno = '{0}'", GlobalService.ChaseNo);
                DataService.GetInstance().ExecuteNonQuery(query);

                MessageBox.Show("Record has been saved.");
                DialogResult = DialogResult.OK;
            }
        }
    }
}
