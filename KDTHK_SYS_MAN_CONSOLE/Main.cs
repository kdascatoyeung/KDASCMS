using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.forms.mycloud;
using KDTHK_SYS_MAN_CONSOLE.forms.education;
//using KDTHK_SYS_MAN_CONSOLE.forms.eform;
using KDTHK_SYS_MAN_CONSOLE.forms.assets;

namespace KDTHK_SYS_MAN_CONSOLE
{
    public partial class Main : Form
    {
        AssetOverview asset = new AssetOverview();

        MyCloudOverview mycloud = new MyCloudOverview();

        EducationOverview education = new EducationOverview();

        //EformOverview eform = new EformOverview();

        public Main()
        {
            InitializeComponent();

            //this.LoadControl(eform);
        }

        private void LoadControl(UserControl control)
        {
            pnlMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(control);
        }

        private void LabelClicked(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string tag = label.Tag.ToString();

            foreach (Control control in pnlMenu.Controls)
            {
                if (control is Label)
                {
                    Label lbl = (Label)control;
                    lbl.BackColor = SystemColors.ControlLightLight;
                    lbl.ForeColor = Color.DimGray;
                    lbl.Font = new Font("Calibri", lbl.Font.Size, FontStyle.Regular);
                }
            }

            label.BackColor = Color.AliceBlue;
            label.ForeColor = Color.DodgerBlue;
            label.Font = new Font("Calibri", label.Font.Size, FontStyle.Bold);

            UserControl uc = new UserControl();

            switch (tag)
            {
                case "education": uc = education;
                    break;

                case "asset": uc = asset;
                    break;

                case "mycloud": uc = mycloud;
                    break;

                //case "eform": uc = eform;
                    //break;
            }

            if (uc != null)
                this.LoadControl(uc);
        }
    }
}
