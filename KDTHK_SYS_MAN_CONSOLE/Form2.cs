using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomUtil.utils.import;
using KDTHK_SYS_MAN_CONSOLE.utils;
using System.Security.AccessControl;
using System.Security.Principal;
using System.IO;
using CustomUtil.utils.export;
using CustomUtil.utils.authentication;

namespace KDTHK_SYS_MAN_CONSOLE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                DataTable errorTable = new DataTable();
                errorTable.Columns.Add("error");

                foreach (DataRow row in table.Rows)
                {
                    //string owner = row.ItemArray[0].ToString().Trim();
                    string path = row.ItemArray[0].ToString().Trim();

                    FileInfo info = new FileInfo(path);

                    try
                    {
                        using (var impersonation = new ImpersonatedUser("itadmin", "kmhk.local", "Cv%^yHfv"))
                        {
                            FileSecurity fs = info.GetAccessControl();
                            AuthorizationRuleCollection rules = fs.GetAccessRules(true, true, typeof(NTAccount));

                            fs.SetAccessRuleProtection(true, false);
                            //if (owner == "Ho Kin Hang(何健恒,Ken)")
                                //fs.AddAccessRule(new FileSystemAccessRule(@"kmas\as1600055", FileSystemRights.FullControl, AccessControlType.Allow));
                            //else
                                fs.AddAccessRule(new FileSystemAccessRule(@"kmas\as1600048", FileSystemRights.FullControl, AccessControlType.Allow));

                            File.SetAccessControl(path, fs);
                        }
                    }
                    catch
                    {
                        errorTable.Rows.Add(path);
                        continue;
                    }
                }

                if (errorTable.Rows.Count > 0)
                    ExportCsvUtil.ExportCsv(errorTable, "", "");
            }
        }

        private void btnKdas_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string id = row.ItemArray[0].ToString().Trim();

                    string name = AdUtil.getUsernameByUserId(id, "kmas.local");

                    string dept = row.ItemArray[2].ToString().Trim();

                    string sect = row.ItemArray[3].ToString().Trim();

                    string div = row.ItemArray[4].ToString().Trim();

                    string query = string.Format("insert into TB_USER_AS (u_staffid, u_name, u_dept, u_sect, u_div) values ('{0}', N'{1}', '{2}', N'{3}', N'{4}')", id, name, dept, sect, div);
                    DataServiceM.GetInstance().ExecuteNonQuery(query);
                }
            }
        }
    }
}
