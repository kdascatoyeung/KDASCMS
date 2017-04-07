using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.flat_forms.forms.data_form;
using CustomUtil.utils.export;
using KDTHK_SYS_MAN_CONSOLE.services;
using System.Diagnostics;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms
{
    public partial class FormView2 : UserControl
    {
        public event EventHandler DetailEvent;

        public FormView2()
        {
            InitializeComponent();

            InitializeList();

            //dgvProcessing.DefaultCellStyle.SelectionBackColor = dgvProcessing.DefaultCellStyle.BackColor;
            //dgvProcessing.DefaultCellStyle.SelectionForeColor = dgvProcessing.DefaultCellStyle.ForeColor;

            dgvCompleted.DefaultCellStyle.SelectionBackColor = SystemColors.ControlLightLight;
            dgvCompleted.DefaultCellStyle.SelectionForeColor = Color.Black;

            DataFormSupport form = new DataFormSupport("processing");
            form.ChangedEvent += new EventHandler(form_ChangedEvent);
            LoadControl(form);

            dgvProcessing.Rows[0].Selected = true;

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            btnExport.Enabled = GlobalService.MasterTable == null ? false : true;
        }

        private void LoadProcessing(List<string> categoryList)
        {
            dgvProcessing.Rows.Clear();

            foreach(string item in categoryList)
            {
                string query = item == "IT技術支援" ? "select count(*) from TB_FORM_SUPPORT where s_status != N'申請處理完成'"
                    : item == "資產外借" ? "select count(*) from TB_FORM_LOANING where l_status != N'申請處理完成'"
                    : item == "權限及軟件安裝" ? "select count(*) from TB_FORM_PERMISSION where p_status != N'申請處理完成'"
                    : item == "工具開發/修改" ? "select count(*) from TB_FORM_DEVELOP where d_status != N'申請處理完成'"
                    : item == "IT意見箱" ? "select count(*) from TB_FORM_COMMENT where c_status != N'申請處理完成'"
                    : item == "R3申請" ? "select count(*) from TB_FORM_R3 where r_status != N'申請處理完成'" : "";
                //string query = string.Format("select count(*) from TB_FORM where f_type = N'{0}' and f_status != N'完成'", item.Trim());
                int result = (int)DataService.GetInstance().ExecuteScalar(query);

                dgvProcessing.Rows.Add(item, result);
            }
        }

        private void LoadCompleted(List<string> categoryList)
        {
            dgvCompleted.Rows.Clear();

            foreach (string item in categoryList)
            {
                string query = item == "IT技術支援" ? "select count(*) from TB_FORM_SUPPORT where s_status = N'申請處理完成'"
                    : item == "資產外借" ? "select count(*) from TB_FORM_LOANING where l_status = N'申請處理完成'"
                    : item == "權限及軟件安裝" ? "select count(*) from TB_FORM_PERMISSION where p_status = N'申請處理完成'"
                    : item == "工具開發/修改" ? "select count(*) from TB_FORM_DEVELOP where d_status = N'申請處理完成'"
                    : item == "IT意見箱" ? "select count(*) from TB_FORM_COMMENT where c_status = N'申請處理完成'"
                    : item == "R3申請" ? "select count(*) from TB_FORM_R3 where r_status = N'申請處理完成'" : "";
                int result = (int)DataService.GetInstance().ExecuteScalar(query);

                dgvCompleted.Rows.Add(item, result);
            }
        }

        private void LoadControl(UserControl uc)
        {
            pnlRecord.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlRecord.Controls.Add(uc);
        }

        private void dgvProcessing_DoubleClick(object sender, EventArgs e)
        {
            /*if (dgvProcessing.SelectedRows == null)
                return;

            string category = dgvProcessing.SelectedRows[0].Cells[0].Value.ToString();

            if (category == "技術支援")
            {
                DataFormSupport form = new DataFormSupport("processing");
                form.ChangedEvent += new EventHandler(form_ChangedEvent);
                LoadControl(form);
            }
            else if (category == "資產外借")
            {
                DataFormAsset form = new DataFormAsset("processing");
                form.ReloadEvent+= new EventHandler(form_ReloadEvent);
                LoadControl(form);
            }
            else if (category == "權限及軟件安裝")
            {
                DataFormPermission form = new DataFormPermission("processing");
                LoadControl(form);
            }
            else if (category == "工具開發/修改")
            {
                DataFormDevelop form = new DataFormDevelop("processing");
                LoadControl(form);
            }
            else if (category == "意見箱")
            {
                DataFormComment form = new DataFormComment("processing");
                LoadControl(form);
            }
            else
                return;*/
        }

        private void dgvCompleted_DoubleClick(object sender, EventArgs e)
        {
            /*if (dgvCompleted.SelectedRows == null)
                return;

            string category = dgvCompleted.SelectedRows[0].Cells[0].Value.ToString();

            if (category == "技術支援")
            {
                DataFormSupport form = new DataFormSupport("completed");
                form.ChangedEvent += new EventHandler(form_ChangedEvent);
                LoadControl(form);
            }
            else if (category == "資產外借")
            {
                DataFormAsset form = new DataFormAsset("completed");
                LoadControl(form);
            }
            else if (category == "權限及軟件安裝")
            {
                DataFormPermission form = new DataFormPermission("completed");
                LoadControl(form);
            }
            else if (category == "工具開發/修改")
            {
                DataFormDevelop form = new DataFormDevelop("completed");
                LoadControl(form);
            }
            else if (category == "意見箱")
            {
                DataFormComment form = new DataFormComment("completed");
                LoadControl(form);
            }
            else
                return;*/
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportCsvUtil.ExportCsv(GlobalService.MasterTable, "", "DL_" + DateTime.Today.ToString("yyyyMMdd"));
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

        private void InitializeList()
        {
            List<string> categoryList = new List<string>();

            string query = "select fm_category from TB_FORM_MASTER";
            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                    categoryList.Add(reader.GetString(0).Trim());
            }

            LoadProcessing(categoryList);

            LoadCompleted(categoryList);
        }

        private void form_ChangedEvent(object sender, EventArgs e)
        {
            InitializeList();
        }

        private void form_ReloadEvent(object sender, EventArgs e)
        {
            InitializeList();
        }

        private void dgvProcessing_Click(object sender, EventArgs e)
        {
            //dgvCompleted.SelectionChanged -= new EventHandler(dgvCompleted_SelectionChanged);

            //dgvCompleted.ClearSelection();

            //dgvProcessing.SelectionChanged += new EventHandler(dgvProcessing_SelectionChanged);
            
            //dgvProcessing.Select();
        }

        private void dgvCompleted_Click(object sender, EventArgs e)
        {
            dgvCompleted.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvCompleted.DefaultCellStyle.SelectionForeColor = Color.White;

            //dgvProcessing.SelectionChanged -= new EventHandler(dgvProcessing_SelectionChanged);

            //dgvProcessing.ClearSelection();

            //dgvCompleted.SelectionChanged += new EventHandler(dgvCompleted_SelectionChanged);
            
            //dgvCompleted.Select();
        }

        private void dgvProcessing_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCompleted.SelectedRows.Count > 0)
                dgvCompleted.ClearSelection();

            try
            {
                string category = dgvProcessing.SelectedRows[0].Cells[0].Value.ToString();

                Debug.WriteLine(category);

                if (category == "IT技術支援")
                {
                    DataFormSupport form = new DataFormSupport("processing");
                    form.ChangedEvent += new EventHandler(form_ChangedEvent);
                    LoadControl(form);
                }
                else if (category == "資產外借")
                {
                    DataFormAsset form = new DataFormAsset("processing");
                    form.ReloadEvent += new EventHandler(form_ReloadEvent);
                    LoadControl(form);
                }
                else if (category == "權限及軟件安裝")
                {
                    DataFormPermission form = new DataFormPermission("processing");
                    LoadControl(form);
                }
                else if (category == "工具開發/修改")
                {
                    Debug.WriteLine("aaa");
                    DataFormDevelop form = new DataFormDevelop("processing");
                    LoadControl(form);
                }
                else if (category == "IT意見箱")
                {
                    DataFormComment form = new DataFormComment("processing");
                    LoadControl(form);
                }
                else if (category == "R3申請")
                {
                    DataFormR3 form = new DataFormR3("processing");
                    LoadControl(form);
                }
                else
                    return;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message + ex.StackTrace);
                //dgvProcessing.ClearSelection();
            }
        }

        private void dgvCompleted_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProcessing.SelectedRows.Count > 0)
                dgvProcessing.ClearSelection();

            try
            {
                string category = dgvCompleted.SelectedRows[0].Cells[0].Value.ToString();
                
                if (category == "IT技術支援")
                {
                    DataFormSupport form = new DataFormSupport("completed");
                    form.ChangedEvent += new EventHandler(form_ChangedEvent);
                    LoadControl(form);
                }
                else if (category == "資產外借")
                {
                    DataFormAsset form = new DataFormAsset("completed");
                    LoadControl(form);
                }
                else if (category == "權限及軟件安裝")
                {
                    DataFormPermission form = new DataFormPermission("completed");
                    LoadControl(form);
                }
                else if (category == "工具開發/修改")
                {
                    DataFormDevelop form = new DataFormDevelop("completed");
                    LoadControl(form);
                }
                else if (category == "IT意見箱")
                {
                    DataFormComment form = new DataFormComment("completed");
                    LoadControl(form);
                }
                else if (category == "R3申請")
                {
                    DataFormR3 form = new DataFormR3("completed");
                    LoadControl(form);
                }
                else
                    return;
            }
            catch
            {
                //dgvCompleted.ClearSelection();
            }
        }

        private void dgvProcessing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvCompleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
