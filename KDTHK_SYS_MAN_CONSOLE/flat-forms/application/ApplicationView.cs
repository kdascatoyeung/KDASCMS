using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomUtil.utils.import;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.application
{
    public partial class ApplicationView : UserControl
    {
        public ApplicationView()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string staff = row.ItemArray[0].ToString().Trim();
                    string path = row.ItemArray[1].ToString().Trim();
                    string name = row.ItemArray[2].ToString().Trim();
                    string desc = row.ItemArray[3].ToString().Trim();

                    string query = string.Format("insert into TB_APPLICATION (f_category, f_staff, f_name, f_path, f_description) values ('Application', N'{0}', N'{1}', N'{2}', N'{3}')", staff, name, path, desc);
                    DataService.GetInstance().ExecuteNonQuery(query);
                }
            }
        }
    }
}
