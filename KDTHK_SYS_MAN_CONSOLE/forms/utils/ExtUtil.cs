using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KDTHK_SYS_MAN_CONSOLE.services;
using System.Diagnostics;

namespace KDTHK_SYS_MAN_CONSOLE.forms.utils
{
    public class ExtUtil
    {
        public static string GetExt(string user)
        {
            string query = string.Format("select t_ext from TB_C_EXT where t_staff = N'{0}'", user.Trim());
            //return DataServiceIT.GetInstance().ExecuteScalar(query).ToString().Trim();
            object objResult = DataServiceIT.GetInstance().ExecuteScalar(query);
            return objResult == null ? string.Empty : objResult.ToString().Trim();

        }
    }
}
