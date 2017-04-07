using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.forms
{
    public partial class FormMain : UserControl
    {
        FormOverview overview = new FormOverview();
        FormView2 masterview = new FormView2();

        string _mode = "overview";
        
        public FormMain()
        {
            InitializeComponent();

            LoadControl(overview);

            tsbtnOverview.Font = new Font("Calibri", this.Font.Size, FontStyle.Bold);
            tsbtnOverview.ForeColor = Color.Cyan;
        }

        private void LoadControl(UserControl uc)
        {
            pnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void tsbtnOverview_Click(object sender, EventArgs e)
        {
            tsbtnOverview.Font = new Font("Calibri", this.Font.Size, FontStyle.Bold);
            tsbtnOverview.ForeColor = Color.Cyan;

            tsbtnMasterView.Font = new Font("Calibri", this.Font.Size, FontStyle.Regular);
            tsbtnMasterView.ForeColor = Color.White;

            _mode = "overview";

            overview = new FormOverview();
            LoadControl(overview);
        }

        private void tsbtnMasterView_Click(object sender, EventArgs e)
        {
            tsbtnMasterView.Font = new Font("Calibri", this.Font.Size, FontStyle.Bold);
            tsbtnMasterView.ForeColor = Color.Cyan;

            tsbtnOverview.Font = new Font("Calibri", this.Font.Size, FontStyle.Regular);
            tsbtnOverview.ForeColor = Color.White;

            _mode = "masterview";

            masterview = new FormView2();
            LoadControl(masterview);
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            if (_mode == "overview")
            {
                overview = new FormOverview();
                LoadControl(overview);
            }
            else
            {
                masterview = new FormView2();
                LoadControl(masterview);
            }
        }
    }
}
