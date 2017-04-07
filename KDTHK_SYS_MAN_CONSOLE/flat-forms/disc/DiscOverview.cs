using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.disc
{
    public partial class DiscOverview : UserControl
    {
        DiscProcessing processing = new DiscProcessing();
        DiscHistory history = new DiscHistory();
        DiscIdle idle = new DiscIdle();

        public DiscOverview()
        {
            InitializeComponent();

            LoadControl(processing);
        }

        private void LoadControl(UserControl uc)
        {
            pnlDiscMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlDiscMain.Controls.Add(uc);
        }

        private void tsbtnRequest_Click(object sender, EventArgs e)
        {
            tsbtnHistory.ForeColor = Color.Black;
            tsbtnRequest.ForeColor = Color.Red;

            processing = new DiscProcessing();
            LoadControl(processing);
        }

        private void tsbtnHistory_Click(object sender, EventArgs e)
        {
            tsbtnRequest.ForeColor = Color.Black;
            tsbtnHistory.ForeColor = Color.Red;

            LoadControl(history);
        }

        private void tsbtnIdle_Click(object sender, EventArgs e)
        {
            
            LoadControl(idle);

        }
    }
}
