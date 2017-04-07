using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KDTHK_SYS_MAN_CONSOLE.forms.education
{
    public partial class EducationOverview : UserControl
    {
        public EducationOverview()
        {
            InitializeComponent();
        }

        private void LoadControl(UserControl control)
        {
            pnlControl.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlControl.Controls.Add(control);
        }
        
        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            EducationNew form = new EducationNew();
            this.LoadControl(form);
        }

        private void tsbtnEducation_Click(object sender, EventArgs e)
        {
            EducationList form = new EducationList();
            this.LoadControl(form);
        }

        private void tsbtnStaff_Click(object sender, EventArgs e)
        {
            EducationStaff form = new EducationStaff();
            this.LoadControl(form);
        }

        private void tsbtnAnswers_Click(object sender, EventArgs e)
        {
            EducationAnswers form = new EducationAnswers();
            this.LoadControl(form);
        }

        private void tsbtnEmail_Click(object sender, EventArgs e)
        {
            EducationMail form = new EducationMail();
            this.LoadControl(form);
        }

        private void tsbtnReport_Click(object sender, EventArgs e)
        {
            EducationReport form = new EducationReport();
            this.LoadControl(form);
        }

        
    }
}
