using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using CustomUtil.utils.import;
using System.IO;
using KDTHK_SYS_MAN_CONSOLE.utils;
using CustomUtil.utils.export;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.disc
{
    public partial class DiscView : UserControl
    {
        public DiscView()
        {
            InitializeComponent();
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            DataTable errorTable = new DataTable();
            errorTable.Columns.Add("missed");

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                using (var impersonation = new ImpersonatedUser("itadmin", "kmhk.local", "Ed@a*9kj"))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        string file = row.ItemArray[0].ToString().Trim();
                        string user = row.ItemArray[1].ToString().Trim();
                        string path = row.ItemArray[2].ToString().Trim();

                        if (!File.Exists(path))
                        {
                            errorTable.Rows.Add(path);
                            continue;
                        }

                        string filename = Path.GetFileName(path);
                        string newPath = path.Replace(@"\\kdthk-dm1", "");
                        string directory = @"\\kdthk-dm1\dvdstorage$" + newPath.Substring(0, newPath.LastIndexOf(@"\") + 1);

                        if (!Directory.Exists(directory))
                            Directory.CreateDirectory(directory);

                        File.Copy(path, directory + filename, true);
                    }
                }

                if (errorTable.Rows.Count > 0)
                    ExportCsvUtil.ExportCsv(errorTable, "", "missed");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            double size = 0;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] sizes = { "B", "KB", "MB", "GB" };

                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                using (var impersonation = new ImpersonatedUser("itadmin", "kmhk.local", "Ed@a*9kj"))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        //string file = row.ItemArray[0].ToString().Trim();
                        //string user = row.ItemArray[1].ToString().Trim();
                        string path = row.ItemArray[2].ToString().Trim();

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

                MessageBox.Show(string.Format("{0:0.##} {1}", size, sizes[order]));
            }
        }
    }
}
