using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.assets
{
    public partial class AssetDetail : UserControl
    {
        public event EventHandler SavedEvent;
        public event EventHandler CancelEvent;

        string _id = "";

        public AssetDetail(string id)
        {
            InitializeComponent();

            _id = id;

            LoadData(id);
        }

        private void LoadData(string id)
        {
            string query = string.Format("select l_name, l_category, l_longterm, l_start, l_end, l_remarks, l_status, l_user, l_refno, l_os, l_office, l_indate, l_warranty from TB_FORM_LOANING where l_id = '{0}'", id);
            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    txtName.Text = reader.GetString(0).Trim();
                    txtCategory.Text = reader.GetString(1).Trim();
                    cbLongTerm.Text = reader.GetString(2).Trim();
                    txtStartDate.Text = reader.GetString(3).Trim();
                    txtEndDate.Text = reader.GetString(4).Trim();
                    txtRemarks.Text = reader.GetString(5).Trim();
                    cbStatus.Text = reader.GetString(6).Trim();
                    txtUser.Text = reader.GetString(7).Trim();
                    txtRefno.Text = reader.GetString(8).Trim();
                    txtOs.Text = reader.GetString(9).Trim();
                    txtOffice.Text = reader.GetString(10).Trim();
                    txtInDate.Text = reader.GetString(11).Trim();
                    txtWarranty.Text = reader.GetString(12).Trim();
                }
            }
        }

        private void ButtonMouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.White;
        }

        private void ButtonMouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.FromArgb(58, 58, 58);
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string category = txtCategory.Text;
            string os = txtOs.Text;
            string office = txtOffice.Text;
            string indate = txtInDate.Text;
            string warranty = txtWarranty.Text;
            string remarks = txtRemarks.Text;
            string longterm = cbLongTerm.SelectedItem.ToString();
            string startdate = txtStartDate.Text;
            string enddate = txtEndDate.Text;
            string status = cbStatus.SelectedItem.ToString();

            string user = txtUser.Text;
            string refno = txtRefno.Text;

            if (status == "可借用")
            {
                user = "---";
                refno = "---";
                startdate = "---";
                enddate = "---";
                longterm = "No";
            }

            string query = string.Format("update TB_FORM_LOANING set l_name = N'{0}', l_category = N'{1}', l_longterm = '{2}', l_start = '{3}', l_end = '{4}', l_remarks = N'{5}'" +
                ", l_status = N'{6}', l_user = N'{7}', l_refno = '{8}', l_os = N'{9}', l_office = N'{10}', l_indate = '{11}', l_warranty = '{12}' where l_id = '{13}'", name, category, longterm,
                startdate, enddate, remarks, status, user, refno, os, office, indate, warranty, _id);

            DataService.GetInstance().ExecuteNonQuery(query);

            if (SavedEvent != null)
                SavedEvent(this, new EventArgs());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (CancelEvent != null)
                CancelEvent(this, new EventArgs());
        }
    }
}
