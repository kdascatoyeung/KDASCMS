using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.disc
{
    class DiscUtil
    {
        public static bool IsDiscExist(string discId)
        {
            string query = string.Format("select count(*) from TB_DISC_REQUEST where d_disc = '{0}'", discId);
            int result = (int)DataService.GetInstance().ExecuteScalar(query);

            return result == 0 ? false : true;
        }

        public static bool IsDiscExistIdle(string discId)
        {
            return false;
        }
    }
}
