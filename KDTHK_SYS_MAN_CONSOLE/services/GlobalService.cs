using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using KDTHK_SYS_MAN_CONSOLE.lists;
using System.Data;

namespace KDTHK_SYS_MAN_CONSOLE.services
{
    public class GlobalService
    {
        public static string User { get; set; }

        public static SqlDataReader Reader { get; set; }

        public static String AssetId { get; set; }

        public static String ApplicationType { get; set; }

        public static List<FormList> FormList { get; set; }

        public static String ChaseNo { get; set; }

        public static String SelectedUser { get; set; }

        public static List<String> HardwareList { get; set; }

        public static List<String> SoftwareList { get; set; }

        public static List<QaList> QaList { get; set; }

        public static String SelectedQaItem { get; set; }

        public static DataTable MasterTable { get; set; }

        public static String SavedForm { get; set; }

        public static String Creator { get; set; }

        public static List<string> ITList { get; set; }
    }
}
