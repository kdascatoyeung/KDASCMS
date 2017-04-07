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
    public partial class DiscSetup1 : Form
    {
        List<string> _filePathList = new List<string>();

        public DiscSetup1(List<string> filePathList)
        {
            InitializeComponent();

            this.Text = "File Count: " + filePathList.Count;

            _filePathList = filePathList;
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            double size = 0;

            string[] sizes = { "B", "KB", "MB", "GB" };

            foreach (string path in _filePathList)
            {
                using (var impersonation = new ImpersonatedUser("itadmin", "kmhk.local", "Ed@a*9kj"))
                {
                    if (!File.Exists(path))
                        continue;

                    double len = new FileInfo(path).Length;
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

                    foreach (string filePath in _filePathList)
                    {
                        using (var impersonation = new ImpersonatedUser("itadmin", "kmhk.local", "Ed@a*9kj"))
                        {
                            string nonMapPath = "";

                            if (filePath.Contains("rps$"))
                                nonMapPath = filePath.Replace("rps$", @"department\rps");
                            else if (filePath.Contains("ga$"))
                                nonMapPath = filePath.Replace("ga$", @"department\ga");
                            else if (filePath.Contains("cm$"))
                                nonMapPath = filePath.Replace("cm$", @"department\cm");
                            else if (filePath.Contains("ipo$"))
                                nonMapPath = filePath.Replace("ipo$", @"department\ipo purchasing");
                            else if (filePath.Contains("logistics$"))
                                nonMapPath = filePath.Replace("logistics$", @"department\logistics");
                            else if (filePath.Contains("mcc$"))
                                nonMapPath = filePath.Replace("mcc$", @"department\mcc");
                            else
                                nonMapPath = filePath;

                            if (!File.Exists(nonMapPath))
                            {
                                Debug.WriteLine(nonMapPath + "  is not exist");
                                continue;
                            }
                            string filename = Path.GetFileName(filePath);
                            string newPath = filePath.Replace(@"\\kdthk-dm1", "");

                            string directory = txtDirectory.Text + @"\" + txtDiscId.Text + newPath.Substring(0, newPath.LastIndexOf(@"\") + 1);

                            if (!Directory.Exists(directory))
                                Directory.CreateDirectory(directory);

                            File.Copy(nonMapPath, directory + filename, true);

                            string query = string.Format("update TB_DISC_REQUEST set d_disc = '{0}', d_status = 'Processing', d_pathcopy = N'{2}' where d_path = N'{1}'", txtDiscId.Text, filePath, directory + filename);
                            DataService.GetInstance().ExecuteNonQuery(query);
                        }
                    }
                    break;

                case DialogResult.No:
                    break;
            }

            DialogResult = DialogResult.OK;
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
    }
}
