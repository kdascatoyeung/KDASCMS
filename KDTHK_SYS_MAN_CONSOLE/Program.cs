using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KDTHK_SYS_MAN_CONSOLE.services;
using CustomUtil.utils.authentication;
using KDTHK_SYS_MAN_CONSOLE.utils;

namespace KDTHK_SYS_MAN_CONSOLE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //GlobalService.User = AdUtil.getUsername("kmhk.local");
            if (Environment.UserName.Substring(0, 2).ToLower() == "hk")
            {
                GlobalService.User = AdUtil.getUsername("kmhk.local");
            }
            else
            {
                GlobalService.User = AdUtil.getUsername("kmas.local");
            }
            GlobalService.HardwareList = DataUtil.GetHardwareList();
            GlobalService.SoftwareList = DataUtil.GetSoftwareList();
            GlobalService.QaList = DataUtil.GetQaList();

            GlobalService.ITList = new List<string>();
            GlobalService.ITList.AddRange(new string[] { UserUtil.ItUserName1(), UserUtil.ItUserName3(), UserUtil.ItUserName2(), UserUtil.ItUserName4() });
            //GlobalService.ITList.AddRange(new string[] { "Yeung Wai, Gabriel (楊偉)", "Lee Ming Fung(李銘峯)", "Ho Kin Hang(何健恒,Ken)", "Chan Fai Lung(陳輝龍,Onyx)" });

            //Application.Run(new Form2());
            //Application.Run(new Main());
            
            Application.Run(new Main2());
        }
    }
}
