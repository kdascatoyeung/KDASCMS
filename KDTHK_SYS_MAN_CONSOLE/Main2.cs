using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.flat_forms.assets;
using KDTHK_SYS_MAN_CONSOLE.services;
using KDTHK_SYS_MAN_CONSOLE.flat_forms.disc;
using KDTHK_SYS_MAN_CONSOLE.flat_forms.forms;
using KDTHK_SYS_MAN_CONSOLE.flat_forms.education;
using KDTHK_SYS_MAN_CONSOLE.flat_forms.application;
using KDTHK_SYS_MAN_CONSOLE.flat_forms.setup;
using CustomUtil.utils.authentication;
using KDTHK_SYS_MAN_CONSOLE.forms.utils;

namespace KDTHK_SYS_MAN_CONSOLE
{
    public partial class Main2 : Form
    {
        AssetView assetView = new AssetView();
        //DiscView discView = new DiscView();
        DiscOverview discView = new DiscOverview();
        //FormView formView = new FormView();
        //FormView2 formView = new FormView2();
        //FormOverview formView = new FormOverview();
        FormMain formView = new FormMain();
        EducationView eduView = new EducationView();
        ApplicationView appView = new ApplicationView();
        SetupView setupView = new SetupView();

        public Main2()
        {
            InitializeComponent();

            LoadControl(formView);
        }

        private void LoadControl(UserControl uc)
        {
            pnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void ToolStripButtonClicked(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;
            string tag = button.Tag.ToString();

            if (tag == "asset")
            {
                assetView.EditEvent += new EventHandler(assetView_EditEvent);
                LoadControl(assetView);
            }

            if (tag == "disc")
            {
                LoadControl(discView);
            }

            if (tag == "forms")
            {
                //formView.DetailEvent += new EventHandler(formView_DetailEvent);
                LoadControl(formView);
            }

            if (tag == "edu")
            {
                LoadControl(eduView);
            }

            if (tag == "app")
            {
                LoadControl(appView);
            }

            if (tag == "setup")
            {
                LoadControl(setupView);
            }
        }

        private void assetView_EditEvent(object sender, EventArgs e)
        {
            AssetDetail view = new AssetDetail(GlobalService.AssetId);
            view.SavedEvent += new EventHandler(view_SavedEvent);
            view.CancelEvent += new EventHandler(view_CancelEvent);
            LoadControl(view);
        }

        private void view_SavedEvent(object sender, EventArgs e)
        {
            assetView = new AssetView();
            assetView.EditEvent += new EventHandler(assetView_EditEvent);
            LoadControl(assetView);
        }

        private void view_CancelEvent(object sender, EventArgs e)
        {
            LoadControl(assetView);
        }

        private void formView_DetailEvent(object sender, EventArgs e)
        {
            FormSupport form = new FormSupport();
            LoadControl(form);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {//
            string from = AdUtil.GetEmailByUserId(AdUtil.GetUserIdByUsername("Lai Sui Mei(黎少薇,Olive)", "kmhk.local"), "kmhk.local");

            string to = AdUtil.GetEmailByUserId(AdUtil.GetUserIdByUsername("Hara Masatoshi(原雅俊)", "kmhk.local"), "kmhk.local");

            EformUtil.SendR3ApprovalEmail("IT-R-0000031", "New User R/3 ID Request,Authority same as  Katty Zhang ID: H160004", "", "", from, to, "Lai Sui Mei(黎少薇,Olive)");
        }
    }
}
