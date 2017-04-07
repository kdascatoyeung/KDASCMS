using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KDTHK_SYS_MAN_CONSOLE.services;
using System.Data;

namespace KDTHK_SYS_MAN_CONSOLE.utils
{
    public class DataUtil
    {
        public static List<string> TableList()
        {
            List<string> list = new List<string>();

            string query = "select table_name from information_schema.tables where table_name like 'TB_hk%'";

            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                {
                    string tablename = GlobalService.Reader.GetString(0);
                    list.Add(tablename);
                }
            }

            list = list.Distinct().ToList();

            return list;
        }

        public static List<string> ItemList()
        {
            List<string> list = new List<string>();

            string query = "select i_item from TB_IT_ITEMS";

            using (IDataReader reader = DataServiceIT.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                    list.Add(reader.GetString(0).Trim());
            }

            return list;
        }

        public static bool IsItemExist(string item)
        {
            string query = string.Format("select count(*) from TB_IT_ITEMS where i_item = N'{0}'", item);
            int result = (int)DataServiceIT.GetInstance().ExecuteScalar(query);

            if (result == 0)
                return false;
            else
                return true;
        }

        public static bool IsHardwareExist(string hardware)
        {
            string query = string.Format("select count(*) from TB_IT_HARDWARE where h_name = N'{0}'", hardware);
            int result = (int)DataServiceIT.GetInstance().ExecuteScalar(query);

            if (result == 0)
                return false;
            else
                return true;
        }

        public static bool IsSoftwareExist(string hardware)
        {
            string query = string.Format("select count(*) from TB_IT_SOFTWARE where s_name = N'{0}'", hardware);
            int result = (int)DataServiceIT.GetInstance().ExecuteScalar(query);

            if (result == 0)
                return false;
            else
                return true;
        }
    }
}
