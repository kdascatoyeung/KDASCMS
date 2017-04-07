using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.utils;
using System.IO;
using System.Diagnostics;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.disc
{
    public partial class DiscSetupIdle : Form
    {
        List<DiscIdleList> _filePathList;

        public DiscSetupIdle(List<DiscIdleList> filePathList)
        {
            InitializeComponent();

            this.Text = "Idle File Count: " + filePathList.Count;

            _filePathList = filePathList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Assign " + _filePathList.Count + " items to Disc with ID: " + txtDiscId.Text + " ? Items will be copied to target directory immediately.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:

                    if (DiscUtil.IsDiscExist(txtDiscId.Text) || DiscUtil.IsDiscExistIdle(txtDiscId.Text))
                    {
                        MessageBox.Show("Disc Id " + txtDiscId.Text + " exists.");
                        return;
                    }

                    foreach (DiscIdleList item in _filePathList)
                    {
                        try
                        {
                            using (var impersonation = new ImpersonatedUser("itadmin", "kmhk.local", "Ed@a*9kj"))
                            {
                                string nonMapPath = "";

                                if (item.FilePath.Contains("rps$"))
                                    nonMapPath = item.FilePath.Replace("rps$", @"department\rps");
                                else if (item.FilePath.Contains("ga$"))
                                    nonMapPath = item.FilePath.Replace("ga$", @"department\ga");
                                else if (item.FilePath.Contains("cm$"))
                                    nonMapPath = item.FilePath.Replace("cm$", @"department\cm");
                                else if (item.FilePath.Contains("ipo$"))
                                    nonMapPath = item.FilePath.Replace("ipo$", @"department\ipo purchasing");
                                else if (item.FilePath.Contains("logistics$"))
                                    nonMapPath = item.FilePath.Replace("logistics$", @"department\logistics");
                                else if (item.FilePath.Contains("mcc$"))
                                    nonMapPath = item.FilePath.Replace("mcc$", @"department\mcc");
                                else
                                    nonMapPath = item.FilePath;

                                if (!File.Exists(nonMapPath))
                                {
                                    Debug.WriteLine(nonMapPath + "  is not exist");
                                    continue;
                                }
                                string filename = Path.GetFileName(item.FilePath);
                                string newPath = item.FilePath.Replace(@"\\kdthk-dm1", "");

                                string directory = txtDirectory.Text + @"\" + txtDiscId.Text + newPath.Substring(0, newPath.LastIndexOf(@"\") + 1);

                                if (!Directory.Exists(directory))
                                    Directory.CreateDirectory(directory);

                                File.Copy(nonMapPath, directory + filename, true);

                                if (filename.Contains("'")) filename = filename.Replace("'", "''");
                                string fileDirectory = directory + filename;
                                if (fileDirectory.Contains("'")) fileDirectory = fileDirectory.Replace("'", "''");

                                if (item.FilePath.Contains("'")) item.FilePath = item.FilePath.Replace("'", "''");

                                string query = string.Format("insert into TB_DISC_IDLE (di_filename, di_path, di_disc, di_status, di_pathcopy, di_lastaccess, di_user) values (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}', N'{6}')", filename, item.FilePath, txtDiscId.Text, "Processing", fileDirectory, item.LastAccess, item.User);
                                DataService.GetInstance().ExecuteNonQuery(query);
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    break;

                case DialogResult.No:
                    break;
            }

            DialogResult = DialogResult.OK;
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            double size = 0;

            string[] sizes = { "B", "KB", "MB", "GB" };

            foreach (DiscIdleList item in _filePathList)
            {
                using (var impersonation = new ImpersonatedUser("itadmin", "kmhk.local", "Ed@a*9kj"))
                {
                    if (!File.Exists(item.FilePath))
                        continue;

                    double len = new FileInfo(item.FilePath).Length;
                    size += len;
                }
            }

            int order = 0;
            while (size >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                size = size / 1024;
            }

            MessageBox.Show("Size: " + string.Format("{0:0.##} {1}", size, sizes[order]));
        }
    }
}
