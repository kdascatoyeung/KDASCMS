using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KDTHK_SYS_MAN_CONSOLE.forms.mycloud
{
    public partial class MyCloudOverview : UserControl
    {
        public MyCloudOverview()
        {
            InitializeComponent();
        }

        private void LoadControl(UserControl control)
        {
            pnlControl.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlControl.Controls.Add(control);
        }

        private void tsbtnApplication_Click(object sender, EventArgs e)
        {
            MyCloudApplication form = new MyCloudApplication();
            this.LoadControl(form);
        }
    }
}
