using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomUtil.utils.import;
using CustomUtil.utils.authentication;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using CustomUtil.utils.export;
using KDTHK_SYS_MAN_CONSOLE.services;
using KDTHK_SYS_MAN_CONSOLE.utils;

namespace KDTHK_SYS_MAN_CONSOLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUploadDesc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                /* Internal
                foreach (DataRow row in table.Rows)
                {
                    string dept = row.ItemArray[0].ToString().Trim();
                    string level = row.ItemArray[1].ToString().Trim();
                    string type = row.ItemArray[2].ToString().Trim();
                    string desc = row.ItemArray[3].ToString().Trim();

                    string query = string.Format("insert into TB_HR_I_REFERENCE (r_dept, r_level, r_type, r_desc)" +
                        " values (N'{0}', N'{1}', N'{2}', N'{3}')", dept, level, type, desc);

                    DataService.GetInstance().ExecuteNonQuery(query);
                }*/

                foreach (DataRow row in table.Rows)
                {
                    string dept = row.ItemArray[0].ToString().Trim();
                    string level = row.ItemArray[1].ToString().Trim();
                    string type = row.ItemArray[2].ToString().Trim();
                    string desc = row.ItemArray[3].ToString().Trim();
                    if (desc.Contains("'"))
                        desc = desc.Replace("'", "''");
                    string title = row.ItemArray[4].ToString().Trim();

                    string query = string.Format("insert into TB_HR_E_REFERENCE (r_dept, r_level, r_type, r_desc, r_title)" +
                        " values (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')", dept, level, type, desc, title);

                    DataService.GetInstance().ExecuteNonQuery(query);
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                int rowcount = 0;

                foreach (DataRow row in table.Rows)
                {
                    double d;
                    DateTime dt;

                    Debug.WriteLine("Row: " + rowcount++);

                    string filename = row.ItemArray[0].ToString();
                    if (filename.Contains("'"))
                        filename = filename.Replace("'", "''");

                    string extension = row.ItemArray[1].ToString();
                    string keyword = row.ItemArray[2].ToString();
                    if (keyword.Contains("'"))
                        keyword = keyword.Replace("'", "''");

                    /*if (keyword.StartsWith("42"))
                    {
                        d = double.Parse(row.ItemArray[2].ToString());
                        dt = DateTime.FromOADate(d);
                        keyword = dt.ToString("yyyy/MM/dd");
                    }*/

                    d = double.Parse(row.ItemArray[3].ToString());
                    dt = DateTime.FromOADate(d);
                    string lastaccess = dt.ToString("yyyy/MM/dd HH:mm:ss");

                    d = double.Parse(row.ItemArray[4].ToString());
                    dt = DateTime.FromOADate(d);
                    string lastmodified = dt.ToString("yyyy/MM/dd HH:mm:ss");

                    string owner = row.ItemArray[5].ToString();
                    //string shared = row.ItemArray[6].ToString();
                    string favorite = row.ItemArray[7].ToString();
                    string path = row.ItemArray[8].ToString();
                    if (path.Contains("'"))
                        path = path.Replace("'", "''");
                    string vpath = row.ItemArray[9].ToString();
                    if (vpath.Contains("'"))
                        vpath = vpath.Replace("'", "''");
                    string count = row.ItemArray[10].ToString();
                    string check = row.ItemArray[11].ToString();

                    d = double.Parse(row.ItemArray[12].ToString());
                    dt = DateTime.FromOADate(d);
                    string deletedate = dt.ToString("yyyy/MM/dd");

                    string shared = row.ItemArray[15].ToString();

                    string query = string.Format("if not exists (select * from TB_hk130005 where r_path = N'{8}') insert into TB_hk130005 (r_filename, r_extension, r_keyword, r_lastaccess, r_lastmodified" +
                        ", r_owner, r_shared, r_favorite, r_path, r_vpath, r_count, r_checked, r_deletedate) values (N'{0}', '{1}', N'{2}', '{3}', '{4}'" +
                        ", N'{5}', N'{6}', '{7}', N'{8}', N'{9}', '{10}', '{11}', '{12}')", filename, extension, keyword, lastaccess, lastmodified, owner, shared,
                        favorite, path, vpath, count, check, deletedate);

                    try
                    {
                        DataService.GetInstance().ExecuteNonQuery(query);
                    }
                    catch(Exception ex)
                    {
                        Debug.WriteLine(ex.Message + ex.StackTrace);
                        continue;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = AdUtil.getUsername("kmhk.local");

            List<StoredList> list = new List<StoredList>();

            string query = string.Format("select r_filename, r_shared from TB_hk120027 where r_shared != '-' and r_shared != '{0}'", user);
            using (SqlDataReader Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (Reader.Read())
                {
                    string filename = Reader.GetString(0);
                    string shared = Reader.GetString(1);

                    list.Add(new StoredList { Filename = filename, Shared = shared });
                }
            }


        }

        private void btnDivisionfolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string dept = row.ItemArray[0].ToString().Trim();
                    string folder = row.ItemArray[1].ToString().Trim();
                    string staff = row.ItemArray[2].ToString().Trim();
                    string deptFolder = row.ItemArray[3].ToString().Trim();

                    string query = string.Format("insert into TB_DIVISION_FOLDER (fd_dept, fd_name, fd_staff, fd_dept_folder)" +
                        " values ('{0}', '{1}', N'{2}', '{3}')", dept, folder, staff, deptFolder);
                    DataService.GetInstance().ExecuteNonQuery(query);
                }
            }
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string dept = row.ItemArray[0].ToString();
                    string level = row.ItemArray[1].ToString();
                    string title = row.ItemArray[2].ToString();
                    string course = row.ItemArray[3].ToString();
                    string organization = row.ItemArray[4].ToString();
                    string link = row.ItemArray[5].ToString();

                    string query = string.Format("insert into TB_HR_COURSE (e_dept, e_level, e_title, e_course, e_organization, e_link)" +
                        " values (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')", dept, level, title, course, organization, link);
                    DataService.GetInstance().ExecuteNonQuery(query);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            DataTable errorTable = new DataTable();
            errorTable.Columns.Add("path");

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string file = row.ItemArray[0].ToString().Trim();
                    //string user = row.ItemArray[1].ToString().Trim();

                    //string staffid = @"kmhk\" + AdUtil.GetUserIdByUsername(user, "kmhk.local");
                    string staffid = @"kmhk\hk850065";

                    if (!File.Exists(file))
                        continue;

                    FileInfo info = new FileInfo(file);
                    try
                    {
                        using (var impersonation = new ImpersonatedUser("itadmin", "kmhk.local", "Ed@a*9kj"))
                        {
                            FileSecurity fs = info.GetAccessControl();
                            AuthorizationRuleCollection rules = fs.GetAccessRules(true, true, typeof(NTAccount));

                            fs.SetAccessRuleProtection(true, false);
                            fs.AddAccessRule(new FileSystemAccessRule(staffid, FileSystemRights.FullControl, AccessControlType.Allow));

                            File.SetAccessControl(file, fs);
                        }
                    }
                    catch
                    {
                        errorTable.Rows.Add(file);
                        continue;
                    }
                }
            }

            if (errorTable.Rows.Count > 0)
                ExportCsvUtil.ExportCsv(errorTable, "", "Error");
        }

        private void btnOwnerChange_Click(object sender, EventArgs e)
        {
            //to Caleb
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string filename = row.ItemArray[0].ToString();
                    string extension = row.ItemArray[1].ToString();
                    string keyword = row.ItemArray[2].ToString();
                    string lastaccess = ImportExcel2007.ParseDateTime(row.ItemArray[3].ToString()).ToString("yyyy/MM/dd HH:mm:dd");
                    string lastmodified = ImportExcel2007.ParseDateTime(row.ItemArray[4].ToString()).ToString("yyyy/MM/dd HH:mm:ss");
                    string owner = row.ItemArray[5].ToString().Trim();
                    string shared = row.ItemArray[6].ToString().Trim();
                    string favorite = row.ItemArray[7].ToString();
                    string path = row.ItemArray[8].ToString().Trim();
                    string vpath = row.ItemArray[9].ToString().Trim();
                    string count = row.ItemArray[10].ToString();
                    string check = row.ItemArray[11].ToString();
                    string deletedate = row.ItemArray[12].ToString();

                    if (!File.Exists(path))
                        continue;

                    if (filename.Contains("'"))
                        filename = filename.Replace("'", "''");

                    if (keyword.Contains("'"))
                        keyword = keyword.Replace("'", "''");

                    if (path.Contains("'"))
                        path = path.Replace("'", "''");

                    if (vpath.Contains("'"))
                        vpath = vpath.Replace("'", "''");

                    if (!DataUtil.IsDataExist(path))
                    {
                        string query = string.Format("insert into TB_hk960164 (r_filename, r_extension, r_keyword, r_lastaccess, r_lastmodified" +
                            ", r_owner, r_shared, r_favorite, r_path, r_vpath, r_count, r_checked, r_deletedate) values (N'{0}', '{1}', N'{2}', '{3}', '{4}'" +
                            ", N'{5}', N'{6}', '{7}', N'{8}', N'{9}', '{10}', '{11}', '{12}')", filename, extension, keyword, lastaccess, lastmodified, "Yau Kwok Keung, Thomas(丘國強)",
                            "Fuh Ka Lok(傅嘉楽,Caleb)", favorite, path, vpath, count, check, deletedate);

                        DataService.GetInstance().ExecuteNonQuery(query);

                        string q2 = string.Format("insert into TB_hk130005 (r_filename, r_extension, r_keyword, r_lastaccess, r_lastmodified" +
                            ", r_owner, r_shared, r_favorite, r_path, r_vpath, r_count, r_checked, r_deletedate) values (N'{0}', '{1}', N'{2}', '{3}', '{4}'" +
                            ", N'{5}', N'{6}', '{7}', N'{8}', N'{9}', '{10}', '{11}', '{12}')", filename, extension, keyword, lastaccess, lastmodified, "Yau Kwok Keung, Thomas(丘國強)",
                            "Fuh Ka Lok(傅嘉楽,Caleb)", favorite, path, vpath, count, check, deletedate);

                        DataService.GetInstance().ExecuteNonQuery(q2);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string filename = row.ItemArray[0].ToString();
                    string extension = row.ItemArray[1].ToString();
                    string keyword = row.ItemArray[2].ToString();
                    string lastaccess = ImportExcel2007.ParseDateTime(row.ItemArray[3].ToString()).ToString("yyyy/MM/dd HH:mm:ss");
                    string lastmodified = ImportExcel2007.ParseDateTime(row.ItemArray[4].ToString()).ToString("yyyy/MM/dd HH:mm:ss");
                    string owner = row.ItemArray[5].ToString().Trim();
                    string shared = row.ItemArray[6].ToString().Trim();
                    string tableName = "TB_hk130005";//"TB_" + AdUtil.GetUserIdByUsername(shared, "kmhk.local");
                    string favorite = row.ItemArray[7].ToString();
                    string path = row.ItemArray[8].ToString().Trim();
                    string vpath = row.ItemArray[9].ToString().Trim();
                    string count = row.ItemArray[10].ToString();
                    string check = row.ItemArray[11].ToString();
                    string deletedate = ImportExcel2007.ParseDateTime(row.ItemArray[12].ToString()).ToString("yyyy/MM/dd HH:mm:ss");
                    string disc = row.ItemArray[13].ToString();

                    if (filename.Contains("'"))
                        filename = filename.Replace("'", "''");

                    if (keyword.Contains("'"))
                        keyword = keyword.Replace("'", "''");

                    if (path.Contains("'"))
                        path = path.Replace("'", "''");

                    if (vpath.Contains("'"))
                        vpath = vpath.Replace("'", "''");

                    string query = string.Format("if not exists (select * from " + tableName + " where r_path = N'{8}') insert into " + tableName + " (r_filename, r_extension, r_keyword, r_lastaccess, r_lastmodified" +
                        ", r_owner, r_shared, r_favorite, r_path, r_vpath, r_count, r_checked, r_deletedate, r_disc) values (N'{0}', '{1}', N'{2}', '{3}', '{4}'" +
                        ", N'{5}', N'{6}', '{7}', N'{8}', N'{9}', '{10}', '{11}', '{12}', '{13}')", filename, extension, keyword, lastaccess, lastmodified, owner,
                        shared, favorite, path, vpath, count, check, deletedate, disc);

                    Debug.WriteLine("Query: " + query);

                    DataService.GetInstance().ExecuteNonQuery(query);
                }
            }
        }

        private void btnTmpImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    double d;
                    DateTime dt;

                    string filename = row.ItemArray[0].ToString().Trim();
                    string extension = row.ItemArray[1].ToString().Trim();
                    string keyword = row.ItemArray[2].ToString().Trim();

                    d = double.Parse(row.ItemArray[3].ToString());
                    dt = DateTime.FromOADate(d);
                    string lastaccess = dt.ToString("yyyy/MM/dd HH:mm:ss");

                    d = double.Parse(row.ItemArray[4].ToString());
                    dt = DateTime.FromOADate(d);
                    string lastmodified = dt.ToString("yyyy/MM/dd HH:mm:ss");

                    string owner = row.ItemArray[5].ToString().Trim();
                    string shared = row.ItemArray[6].ToString().Trim();
                    string favorite = row.ItemArray[7].ToString().Trim();
                    string path = row.ItemArray[8].ToString().Trim();
                    string vpath = @"\Documents" + row.ItemArray[9].ToString().Trim();

                    d = double.Parse(row.ItemArray[12].ToString());
                    dt = DateTime.FromOADate(d);
                    string deletedate = dt.ToString("yyyy/MM/dd");

                    List<string> list = shared.Split(';').ToList();

                    foreach (string item in list)
                    {
                        string tableName = "TB_" + AdUtil.GetUserIdByUsername(item.Trim(), "kmhk.local");

                        string query = string.Format("insert into "+ tableName+" (r_filename, r_extension, r_keyword, r_lastaccess, r_lastmodified" +
                        ", r_owner, r_shared, r_favorite, r_path, r_vpath, r_deletedate) values (N'{0}', '{1}', N'{2}', '{3}', '{4}'" +
                        ", N'{5}', N'{6}', '{7}', N'{8}', N'{9}', '{10}')", filename, extension, keyword, lastaccess, lastmodified, owner, item.Trim(),
                        favorite, path, vpath, deletedate);

                        //Debug.WriteLine("Query: " + query);
                        try
                        {
                            DataService.GetInstance().ExecuteNonQuery(query);
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message + ex.StackTrace);
                            continue;
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string id = row.ItemArray[0].ToString();
                    string content = row.ItemArray[2].ToString();

                    string query = string.Format("update tb_ringi set rg_content = N'{0}' where rg_id = '{1}'", content, id);
                    DataService.GetInstance().ExecuteNonQuery(query);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                int rowcount = 0;

                foreach (DataRow row in table.Rows)
                {
                    Debug.WriteLine("Row: " + rowcount++);

                    string path = row.ItemArray[0].ToString().Trim();
                    string shared = row.ItemArray[1].ToString().Trim();

                    if (path.Contains("'"))
                        path = path.Replace("'", "''");

                    string query = string.Format("update TB_hk110033 set r_shared = N'{0}' where r_path = N'{1}'", shared, path);

                    try
                    {
                        DataService.GetInstance().ExecuteNonQuery(query);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message + ex.StackTrace);
                        continue;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    double d;
                    DateTime dt;

                    string filename = row.ItemArray[0].ToString().Trim();
                    string extension = row.ItemArray[1].ToString().Trim();
                    string keyword = row.ItemArray[2].ToString().Trim();

                    d = double.Parse(row.ItemArray[3].ToString());
                    dt = DateTime.FromOADate(d);
                    string lastaccess = dt.ToString("yyyy/MM/dd HH:mm:ss");

                    d = double.Parse(row.ItemArray[4].ToString());
                    dt = DateTime.FromOADate(d);
                    string lastmodified = dt.ToString("yyyy/MM/dd HH:mm:ss");

                    string owner = row.ItemArray[5].ToString().Trim();
                    string shared = row.ItemArray[6].ToString().Trim();
                    string favorite = row.ItemArray[7].ToString().Trim();
                    string path = row.ItemArray[8].ToString().Trim();
                    string vpath = row.ItemArray[9].ToString().Trim();
                    string count = row.ItemArray[10].ToString().Trim();

                    d = double.Parse(row.ItemArray[12].ToString());
                    dt = DateTime.FromOADate(d);
                    string deletedate = dt.ToString("yyyy/MM/dd");

                    if (path.Contains("'"))
                        path = path.Replace("'", "''");

                    if (vpath.Contains("'"))
                        vpath = vpath.Replace("'", "''");

                    if (filename.Contains("'"))
                        filename = filename.Replace("'", "''");

                    if (keyword.Contains("'"))
                        keyword = keyword.Replace("'", "''");

                    string query = string.Format("if not exists (select * from TB_hk850065 where r_path = N'{9}') insert into TB_hk850065 (r_filename, r_extension, r_keyword, r_lastaccess, r_lastmodified" +
                        ", r_owner, r_shared, r_favorite, r_path, r_vpath, r_deletedate, r_count, r_checked) values (N'{0}', '{1}', N'{2}', '{3}', '{4}'" +
                        ", N'{5}', N'{6}', '{7}', N'{8}', N'{9}', '{10}', '{11}', '{12}')", filename, extension, keyword, lastaccess, lastmodified, owner, shared.Trim(),
                        favorite, path, vpath, deletedate, count, "True");

                    DataService.GetInstance().ExecuteNonQuery(query);
                    //string ownedShared = row.ItemArray[13].ToString().Trim();

                    //List<string> list = shared.Split(';').ToList();

                    /*string query = "";

                    if (shared != "-")
                    {
                        string tableName = "TB_" + AdUtil.GetUserIdByUsername(shared.Trim(), "kmhk.local");

                        query = string.Format("insert into " + tableName + " (r_filename, r_extension, r_keyword, r_lastaccess, r_lastmodified" +
                        ", r_owner, r_shared, r_favorite, r_path, r_vpath, r_deletedate, r_count) values (N'{0}', '{1}', N'{2}', '{3}', '{4}'" +
                        ", N'{5}', N'{6}', '{7}', N'{8}', N'{9}', '{10}', '{11}')", filename, extension, keyword, lastaccess, lastmodified, owner, shared.Trim(),
                        favorite, path, vpath, deletedate, count);
                    }
                    else
                    {
                        string tableName = "TB_" + AdUtil.GetUserIdByUsername(owner.Trim(), "kmhk.local");

                        query = string.Format("insert into " + tableName + " (r_filename, r_extension, r_keyword, r_lastaccess, r_lastmodified" +
                        ", r_owner, r_shared, r_favorite, r_path, r_vpath, r_deletedate, r_count) values (N'{0}', '{1}', N'{2}', '{3}', '{4}'" +
                        ", N'{5}', N'{6}', '{7}', N'{8}', N'{9}', '{10}', '{11}')", filename, extension, keyword, lastaccess, lastmodified, owner, ownedShared.Trim(),
                        favorite, path, vpath, deletedate, count);
                    }

                    try
                    {
                        DataService.GetInstance().ExecuteNonQuery(query);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message + ex.StackTrace);
                        continue;
                    }*/
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string group = row.ItemArray[0].ToString().Trim();
                    string owner = row.ItemArray[1].ToString().Trim();
                    string shared = row.ItemArray[2].ToString().Trim();

                    string query = string.Format("if not exists (select * from TB_CUSTOM_GROUP where g_name = N'{0}' and g_owner = N'{1}' and g_member = N'{2}')" +
                        " insert into TB_CUSTOM_GROUP (g_name, g_owner, g_member) values (N'{0}', N'{1}', N'{2}')", group, owner, shared);
                    DataService.GetInstance().ExecuteNonQuery(query);
                }
            }
        }

        private void btnDataChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    double d;
                    DateTime dt;

                    string filename = row.ItemArray[0].ToString().Trim();
                    string extension = row.ItemArray[1].ToString().Trim();
                    string keyword = row.ItemArray[2].ToString().Trim();

                    d = double.Parse(row.ItemArray[3].ToString());
                    dt = DateTime.FromOADate(d);
                    string lastaccess = dt.ToString("yyyy/MM/dd HH:mm:ss");

                    d = double.Parse(row.ItemArray[4].ToString());
                    dt = DateTime.FromOADate(d);
                    string lastmodified = dt.ToString("yyyy/MM/dd HH:mm:ss");

                    string owner = row.ItemArray[5].ToString().Trim();
                    string shared = row.ItemArray[6].ToString().Trim();
                    string favorite = row.ItemArray[7].ToString().Trim();
                    string path = row.ItemArray[8].ToString().Trim();
                    string vpath = @"\Documents" + row.ItemArray[9].ToString().Trim();
                    string count = row.ItemArray[10].ToString().Trim();

                    d = double.Parse(row.ItemArray[12].ToString());
                    dt = DateTime.FromOADate(d);
                    string deletedate = dt.ToString("yyyy/MM/dd");

                    string ownedShared = row.ItemArray[14].ToString().Trim();

                    List<string> list = shared.Split(';').ToList();

                    string ownerTable = "TB_" + AdUtil.GetUserIdByUsername(ownedShared, "kmhk.local");

                    if (filename.Contains("'"))
                        filename = filename.Replace("'", "''");

                    if (keyword.Contains("'"))
                        keyword = keyword.Replace("'", "''");

                    if (path.Contains("'"))
                        path = path.Replace("'", "''");

                    if (vpath.Contains("'"))
                        vpath = vpath.Replace("'", "''");

                    if (shared == "-")
                    {
                        string query = string.Format("if not exists (select * from " + ownerTable + " where r_path = N'{7}') insert into " + ownerTable + " (r_filename, r_extension, r_keyword, r_lastaccess" +
                            ", r_lastmodified, r_owner, r_shared, r_path, r_vpath, r_deletedate) values (N'{0}', '{1}', N'{2}', '{3}', '{4}', N'{5}', N'{6}', N'{7}', N'{8}', '{9}') else update " + ownerTable + " set r_owner = N'{5}'" +
                            ", r_shared = '-' where r_path = N'{7}'", filename, extension, keyword, lastaccess, lastmodified, ownedShared, shared, path, vpath, deletedate);

                        DataService.GetInstance().ExecuteNonQuery(query);
                    }
                    else
                    {
                        string ownerText = string.Format("if not exists (select * from " + ownerTable + " where r_path = N'{7}') insert into " + ownerTable + " (r_filename, r_extension, r_keyword, r_lastaccess" +
                            ", r_lastmodified, r_owner, r_shared, r_path, r_vpath, r_deletedate) values (N'{0}', '{1}', N'{2}', '{3}', '{4}', N'{5}', N'{6}', N'{7}', N'{8}', '{9}') else update " + ownerTable + " set r_owner = N'{5}'" +
                            ", r_shared = N'{6}' where r_path = N'{7}'", filename, extension, keyword, lastaccess, lastmodified, ownedShared, shared, path, vpath, deletedate);
                        DataService.GetInstance().ExecuteNonQuery(ownerText);

                        if (shared.Contains(";"))
                        {
                            foreach (string item in list)
                            {
                                string sharedTable = "TB_" + AdUtil.GetUserIdByUsername(item.Trim(), "kmhk.local");

                                string sharedText = string.Format("if not exists (select * from " + sharedTable + " where r_path = N'{7}') insert into " + sharedTable + " (r_filename, r_extension, r_keyword, r_lastaccess" +
                                    ", r_lastmodified, r_owner, r_shared, r_path, r_vpath, r_deletedate) values (N'{0}', '{1}', N'{2}', '{3}', '{4}', N'{5}', N'{6}', N'{7}', N'{8}', '{9}') else update " + sharedTable + " set r_owner = N'{5}'" +
                                    " where r_path = N'{7}'", filename, extension, keyword, lastaccess, lastmodified, ownedShared, shared, path, vpath, deletedate);

                                DataService.GetInstance().ExecuteNonQuery(sharedText);
                            }
                        }
                        else
                        {
                            string sharedTable = "TB_" + AdUtil.GetUserIdByUsername(shared.Trim(), "kmhk.local");

                            string sharedText = string.Format("if not exists (select * from " + sharedTable + " where r_path = N'{7}') insert into " + sharedTable + " (r_filename, r_extension, r_keyword, r_lastaccess" +
                                ", r_lastmodified, r_owner, r_shared, r_path, r_vpath, r_deletedate) values (N'{0}', '{1}', N'{2}', '{3}', '{4}', N'{5}', N'{6}', N'{7}', N'{8}', '{9}') else update " + sharedTable + " set r_owner = N'{5}'" +
                                " where r_path = N'{7}'", filename, extension, keyword, lastaccess, lastmodified, ownedShared, shared, path, vpath, deletedate);

                            DataService.GetInstance().ExecuteNonQuery(sharedText);
                        }
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            string query = "select table_name from information_schema.tables where table_name like 'TB_hk%'";

            GlobalService.Reader = DataService.GetInstance().ExecuteReader(query);

            while (GlobalService.Reader.Read())
            {
                string tablename = GlobalService.Reader.GetString(0);
                list.Add(tablename);
            }
            GlobalService.Reader.Close();

            list = list.Distinct().ToList();

            List<DiscData> discList = new List<DiscData>();

            DataTable tb = new DataTable();
            string[] headers = { "filename", "owner", "path", "vpath" };
            foreach (string header in headers)
                tb.Columns.Add(header);

            foreach (string table in list)
            {
                Debug.WriteLine("Reading " + table + "...");
                string q1 = "select r_filename, r_owner, r_path, r_vpath from " + table + " where r_disc != 'False'";
                using (IDataReader reader = DataService.GetInstance().ExecuteReader(q1))
                {
                    while (reader.Read())
                        tb.Rows.Add(new object[] { reader.GetString(0).Trim(), reader.GetString(1).Trim(), reader.GetString(2).Trim(), reader.GetString(3).Trim() });
                }
            }

            ExportCsvUtil.ExportCsv(tb, "", "");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            string query = "select table_name from information_schema.tables where table_name like 'TB_hk%'";

            GlobalService.Reader = DataService.GetInstance().ExecuteReader(query);

            while (GlobalService.Reader.Read())
            {
                string tablename = GlobalService.Reader.GetString(0);
                list.Add(tablename);
            }
            GlobalService.Reader.Close();

            list = list.Distinct().ToList();

            DataTable tb = new DataTable();
            string[] headers = { "lastaccess", "filename", "owner", "path", "vpath" };
            foreach (string header in headers)
                tb.Columns.Add(header);

            foreach (string table in list)
            {
                Debug.WriteLine("Reading " + table + "...");
                string staffid = table.Substring(3);
                Debug.WriteLine(staffid);
                string staff = AdUtil.getUsernameByUserId(staffid, "kmhk.local");
                string q1 = string.Format("select r_lastaccess, r_filename, r_owner, r_path, r_vpath from " + table + " where datediff(month, r_lastaccess, getdate()) > 6 and r_owner = N'{0}'", staff) ;
                using (IDataReader reader = DataService.GetInstance().ExecuteReader(q1))
                {
                    while (reader.Read())
                        tb.Rows.Add(new object[] { reader.GetString(0).Trim(), reader.GetString(1).Trim(), reader.GetString(2).Trim(), reader.GetString(3).Trim(), reader.GetString(4).Trim() });
                }
            }

            foreach (DataTable dt in CloneTableList(tb, 500000))
                ExportCsvUtil.ExportCsv(dt, "", "");
        }

        private List<DataTable> CloneTableList(DataTable sourceTable, int limit)
        {
            List<DataTable> list = new List<DataTable>();
            int count = 0;
            DataTable copyTable = null;

            foreach (DataRow row in sourceTable.Rows)
            {
                if ((count++ % limit) == 0)
                {
                    copyTable = new DataTable();
                    copyTable = sourceTable.Clone();
                    list.Add(copyTable);
                }
                copyTable.ImportRow(row);
            }

            return list;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string path = row.ItemArray[0].ToString().Trim();
                    string vpath = row.ItemArray[1].ToString().Trim();

                    if (path.Contains("'"))
                        path = path.Replace("'", "''");

                    if (vpath.Contains("'"))
                        vpath = vpath.Replace("'", "''");

                    string query = string.Format("update TB_hk942350 set r_vpath = N'{0}' where r_path = N'{1}'", vpath, path);
                    DataService.GetInstance().ExecuteNonQuery(query);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string filename = row.ItemArray[0].ToString().Trim();
                    string keyword = row.ItemArray[1].ToString().Trim();
                    string path = row.ItemArray[2].ToString().Trim();
                    string vpath = row.ItemArray[3].ToString().Trim();
                    string path1 = row.ItemArray[4].ToString().Trim();

                    if (path.Contains("'"))
                        path = path.Replace("'", "''");

                    if (vpath.Contains("'"))
                        vpath = vpath.Replace("'", "''");

                    if (path1.Contains("'"))
                        path1 = path1.Replace("'", "''");

                    string query = string.Format("update TB_hk110017 set r_filename = N'{0}', r_keyword = N'{1}', r_path = N'{2}', r_vpath = N'{3}' where r_path = N'{4}'", filename, keyword, path, vpath, path1);
                    DataService.GetInstance().ExecuteNonQuery(query);
                }
            }*/

            DataTable errorTable = new DataTable();
            errorTable.Columns.Add("path");

            string staffid = @"kmhk\hk110017";

            using (var impersonation = new ImpersonatedUser("itadmin", "kmhk.local", "Ed@a*9kj"))
            {
                string[] files = Directory.GetFiles(@"\\kdthk-dm1\ga$\23100\3. Personnel\09 Staff Photo\", "*.*", SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    FileInfo info = new FileInfo(file);
                    try
                    {

                        FileSecurity fs = info.GetAccessControl();
                        AuthorizationRuleCollection rules = fs.GetAccessRules(true, true, typeof(NTAccount));

                        fs.SetAccessRuleProtection(true, false);
                        fs.AddAccessRule(new FileSystemAccessRule(staffid, FileSystemRights.FullControl, AccessControlType.Allow));

                        File.SetAccessControl(file, fs);

                    }
                    catch
                    {
                        errorTable.Rows.Add(file);
                        continue;
                    }
                }
            }

            if (errorTable.Rows.Count > 0)
                ExportCsvUtil.ExportCsv(errorTable, "", "Error");
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string name = row.ItemArray[0].ToString().Trim();
                    string ext = row.ItemArray[1].ToString().Trim();
                    string dept = row.ItemArray[2].ToString().Trim();

                    string query = string.Format("insert into TB_C_EXT (t_staff, t_ext, t_division) values (N'{0}', '{1}', N'{2}')", name, ext, dept);
                    DataServiceEdu.GetInstance().ExecuteNonQuery(query);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string folder = row.ItemArray[0].ToString().Trim();
                    string staff = row.ItemArray[1].ToString().Trim();
                    string path = row.ItemArray[2].ToString().Trim();

                    string query = string.Format("insert into TB_SHARED_FOLDER (share_folder, share_staffid, share_path) values (N'{0}', N'{1}', N'{2}')", folder, staff, path);
                    DataService.GetInstance().ExecuteNonQuery(query);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string delText = "delete from TB_DIVISION_FOLDER dbcc checkident ('TB_DIVISION_FOLDER', reseed, 0)";
                DataService.GetInstance().ExecuteNonQuery(delText);

                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string dept = row.ItemArray[0].ToString().Trim();
                    string div = row.ItemArray[1].ToString().Trim();
                    string staff = row.ItemArray[2].ToString().Trim();
                    string folder = row.ItemArray[3].ToString().Trim();

                    string query = string.Format("insert into TB_DIVISION_FOLDER (fd_dept, fd_name, fd_staff, fd_dept_folder) values ('{0}', '{1}', N'{2}', '{3}')", dept, div, staff, folder);

                    DataService.GetInstance().ExecuteNonQuery(query);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string id = row.ItemArray[0].ToString().Trim();
                    string shared = row.ItemArray[7].ToString().Trim();

                    string query = string.Format("update TB_hk070022 set r_shared = N'{0}' where r_id = '{1}'", shared, id);
                    DataService.GetInstance().ExecuteNonQuery(query);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string filename = row.ItemArray[0].ToString().Trim();
                    string extension = row.ItemArray[1].ToString().Trim();
                    string keyword = row.ItemArray[2].ToString().Trim();
                    string lastaccess = ImportExcel2007.ParseDateTime(row.ItemArray[3].ToString().Trim()).ToString("yyyy/MM/dd HH:mm:ss");
                    string lastmodified = ImportExcel2007.ParseDateTime(row.ItemArray[4].ToString().Trim()).ToString("yyyy/MM/dd HH:mm:ss");
                    string owner = row.ItemArray[5].ToString().Trim();
                    string shared = "Lai King Ho(黎景豪,Ken)";//row.ItemArray[6].ToString().Trim();
                    string path = row.ItemArray[8].ToString().Trim();
                    string vpath = row.ItemArray[9].ToString().Trim();

                    if (filename.Contains("'")) filename = filename.Replace("'", "''");

                    if (keyword.Contains("'")) keyword = keyword.Replace("'", "''");

                    if (path.Contains("'")) path = path.Replace("'", "''");

                    if (vpath.Contains("'")) vpath = vpath.Replace("'", "''");

                    string query = string.Format("if not exists (select * from TB_hk070001 where r_path = N'{7}') insert into TB_hk070001 (r_filename, r_extension, r_keyword, r_lastaccess, r_lastmodified, r_owner, r_shared, r_path, r_vpath, r_deletedate)"+
                        " values (N'{0}', '{1}', N'{2}', '{3}', '{4}', N'{5}', N'{6}', N'{7}', N'{8}', '2099/12/31')", filename, extension, keyword, lastaccess, lastmodified, owner, shared, path, vpath);

                    DataService.GetInstance().ExecuteNonQuery(query);
                }
            }
        }

        private void btnExists_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                DataTable tb = new DataTable();
                string[] headers = { "filename", "owner", "shared", "path", "status" };
                foreach (string header in headers)
                    tb.Columns.Add(header);

                foreach (DataRow row in table.Rows)
                {
                    string filename = row.ItemArray[0].ToString().Trim();
                    string owner = row.ItemArray[1].ToString().Trim();
                    string shared = row.ItemArray[2].ToString().Trim();
                    string path = row.ItemArray[3].ToString().Trim();

                    using (var impersonation = new ImpersonatedUser("itadmin", "kmhk.local", "Ed@a*9kj"))
                    {
                        try
                        {
                            if (File.Exists(path))
                                tb.Rows.Add(filename, owner, shared, path, "ok");
                            else
                                tb.Rows.Add(filename, owner, shared, path, "not exists");
                        }
                        catch
                        {
                            tb.Rows.Add(filename, owner, shared, path, "error");
                            continue;
                        }
                    }
                }

                ExportExcelUtil.SaveAsExcel(tb, "record");
            }
        }

        private void btnMigration_Click(object sender, EventArgs e)
        {
            int count = 0;

            string query = string.Format("select di_path, di_pathcopy from TB_DISC_IDLE where di_user = N'{0}' and di_id > 10743", "Yu Siu Mei(余筱薇,Connie)");

            List<RestoreDisc> list = new List<RestoreDisc>();

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    count += 1;
                    string path = reader.GetString(0).Trim();
                    string copypath = reader.GetString(1).Trim();

                    copypath = copypath.Replace(@"\\kdthk-dm1\dvdstorage$", @"\\leemingfung\d$\DVD Burn");

                    list.Add(new RestoreDisc { Path = path, SourcePath = copypath });
                }
            }

            foreach (RestoreDisc item in list)
            {
                using (var impersonation = new ImpersonatedUser("itadmin", "kmhk.local", "Ed@a*9kj"))
                {
                    try
                    {
                        if (!File.Exists(item.Path))
                        {
                            File.Copy(item.SourcePath, item.Path, false);
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
        }
    }

    public class RestoreDisc
    {
        public string Path { get; set; }
        public string SourcePath { get; set; }
    }

    public class StoredList
    {
        public string Filename { get; set; }
        public string Shared { get; set; }
    }

    public class DiscData
    {
        public string Filename { get; set; }

        public string Owner { get; set; }

        public string FilePath { get; set; }

        public string VirtualPath { get; set; }
    }
}
