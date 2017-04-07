using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Diagnostics;
using KDTHK_SYS_MAN_CONSOLE.services;
using System.Data;
using KDTHK_SYS_MAN_CONSOLE.lists;

namespace KDTHK_SYS_MAN_CONSOLE
{
    public class DataUtil
    {
        public static bool IsDataExist(string path)
        {
            string query = string.Format("select r_id from TB_hk960164 where r_path = N'{0}'", path);

            using (SqlDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                if (reader.HasRows)
                    return true;
            }

            return false;
        }

        public static string GetApplicant(string chaseno)
        {
            string query = string.Format("select f_applicant from TB_FORM where f_chaseno = '{0}'", chaseno);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetHead(string staff)
        {
            string query = string.Format("select s_head from TB_C_STAFF where s_name = N'{0}'", staff.Trim());
            return DataServiceMaster.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetApprovalDate(string strChaseno)
        {
            string strQuery = string.Format("SELECT ISNULL(f_approvaldate, '') FROM TB_FORM WHERE f_chaseno = N'{0}'", strChaseno);
            return DataService.GetInstance().ExecuteScalar(strQuery).ToString();
        }

        public static bool IsItemApproved(string chaseno)
        {
            string query = string.Format("select f_approval from TB_FORM where f_chaseno = '{0}'", chaseno);
            string result = DataService.GetInstance().ExecuteScalar(query).ToString();
            return result == "Approve" ? true : false;
        }

        public static List<string> GetHardwareList()
        {
            List<string> list = new List<string>();

            string query = "select h_name from TB_IT_HARDWARE";

            using (IDataReader reader = DataServiceIT.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    list.Add(reader.GetString(0).Trim());
                }
            }

            return list;
        }

        public static List<string> GetSoftwareList()
        {
            List<string> list = new List<string>();

            string query = "select s_name from TB_IT_SOFTWARE";

            using (IDataReader reader = DataServiceIT.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    list.Add(reader.GetString(0).Trim());
                }
            }

            return list;
        }

        public static List<QaList> GetQaList()
        {
            List<QaList> list = new List<QaList>();

            string query = "select q_question, q_answer, q_id from TB_IT_QA";

            using (IDataReader reader = DataServiceIT.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                    list.Add(new QaList { Question = reader.GetString(0), Answer = reader.GetString(1), Id = reader.GetInt32(2) });
            }

            return list;
        }

        public static string GetStartDate(string chaseno)
        {
            string query = string.Format("select f_start from TB_FORM where f_chaseno = '{0}'", chaseno);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetEndDate(string chaseno)
        {
            string query = string.Format("select f_end from TB_FORM where f_chaseno = '{0}'", chaseno);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static bool IsApplicationCompleted(string chaseno)
        {
            string text1 = string.Format("select count(*) from TB_FORM_SUPPORT where s_chaseno = '{0}' and s_status != N'申請處理完成'", chaseno);
            int support = (int)DataService.GetInstance().ExecuteScalar(text1);

            string text2 = string.Format("select count(*) from TB_FORM_LOANING where l_refno = '{0}' and l_status != N'申請處理完成'", chaseno);
            int asset = (int)DataService.GetInstance().ExecuteScalar(text2);

            string text3 = string.Format("select count(*) from TB_FORM_PERMISSION where p_chaseno = '{0}' and p_status != N'申請處理完成'", chaseno);
            int permission = (int)DataService.GetInstance().ExecuteScalar(text3);

            string text4 = string.Format("select count(*) from TB_FORM_DEVELOP where d_chaseno = '{0}' and d_status != N'申請處理完成'", chaseno);
            int develop = (int)DataService.GetInstance().ExecuteScalar(text4);

            string text5 = string.Format("select count(*) from TB_FORM_COMMENT where c_chaseno = '{0}' and c_status != N'申請處理完成'", chaseno);
            int comment = (int)DataService.GetInstance().ExecuteScalar(text5);

            if (support + asset + permission + develop + comment > 0)
                return false;

            return true;
        }

        public static bool IsFormApproved(string chaseno)
        {
            string query = string.Format("select count(*) from TB_FORM where f_chaseno = '{0}' and f_approval = 'Yes'", chaseno);
            int result = (int)DataService.GetInstance().ExecuteScalar(query);

            if (result > 0)
                return true;

            return false;
        }

        public static string GetSupportChaseNo()
        {
            string query = "select top 1 s_chaseno from TB_FORM_SUPPORT order by s_id desc";

            string result = "", chaseno = "";

            try
            {
                result = DataService.GetInstance().ExecuteScalar(query).ToString().Substring(5);
                int number = Convert.ToInt32(result) + 1;
                chaseno = "IT-S-" + number.ToString("D7");
            }
            catch
            {
                chaseno = "IT-S-0000001";
            }
            return chaseno;
        }

        public static string GetAssetChaseNo()
        {
            string query = "select top 1 l_chaseno from TB_FORM_LOANING order by l_id desc";

            string result = "", chaseno = "";

            try
            {
                result = DataService.GetInstance().ExecuteScalar(query).ToString().Substring(5);
                int number = Convert.ToInt32(result) + 1;
                chaseno = "IT-L-" + number.ToString("D7");
            }
            catch
            {
                chaseno = "IT-L-0000001";
            }
            return chaseno;
        }

        public static string GetPermissionChaseNo()
        {
            string query = "select top 1 p_chaseno from TB_FORM_PERMISSION order by p_id desc";

            string result = "", chaseno = "";

            try
            {
                result = DataService.GetInstance().ExecuteScalar(query).ToString().Substring(5);
                int number = Convert.ToInt32(result) + 1;
                chaseno = "IT-P-" + number.ToString("D7");
            }
            catch
            {
                chaseno = "IT-P-0000001";
            }
            return chaseno;
        }

        public static string GetDevelopChaseNo()
        {
            string query = "select top 1 d_chaseno from TB_FORM_DEVELOP order by d_id desc";

            string result = "", chaseno = "";

            try
            {
                result = DataService.GetInstance().ExecuteScalar(query).ToString().Substring(5);
                int number = Convert.ToInt32(result) + 1;
                chaseno = "IT-D-" + number.ToString("D7");
            }
            catch
            {
                chaseno = "IT-D-0000001";
            }
            return chaseno;
        }

        public static string GetCommentChaseNo()
        {
            string query = "select top 1 c_chaseno from TB_FORM_COMMENT order by c_id desc";

            string result = "", chaseno = "";

            try
            {
                result = DataService.GetInstance().ExecuteScalar(query).ToString().Substring(5);
                int number = Convert.ToInt32(result) + 1;
                chaseno = "IT-C-" + number.ToString("D7");
            }
            catch
            {
                chaseno = "IT-C-0000001";
            }
            return chaseno;
        }

        public static string GetR3Chaseno()
        {
            string query = "select top 1 r_chaseno from TB_FORM_R3 order by r_chaseno desc";

            string result = "";

            string chaseno = "";
            try
            {
                result = DataService.GetInstance().ExecuteScalar(query).ToString();

                result = result.Substring(5);

                int number = Convert.ToInt32(result) + 1;

                chaseno = "IT-R-" + number.ToString("D7");
            }
            catch
            {
                chaseno = "IT-R-0000001";
            }


            return chaseno;
        }

        public static string GetRefNo(string type, string chaseno)
        {
            string query = type == "permission" ? string.Format("select p_refno from TB_FORM_PERMISSION where p_chaseno = '{0}'", chaseno)
                : type == "loaning" ? string.Format("select l_refno from TB_FORM_LOANING where l_chaseno = '{0}'", chaseno)
                : type == "develop" ? string.Format("select d_refno from TB_FORM_DEVELOP where d_chaseno = '{0}'", chaseno)
                : type == "comment" ? string.Format("select c_refno from TB_FORM_COMMENT where c_chaseno = '{0}'", chaseno)
                : type == "r3" ? string.Format("select r_refno from TB_FORM_R3 where r_chaseno = '{0}'", chaseno) : string.Format("select s_refno from TB_FORM_SUPPORT where s_chaseno = '{0}'", chaseno);

            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetDeviceStatus(string device)
        {
            string query = string.Format("select a_status from TB_IT_ASSET where a_name = '{0}'", device);
            return DataServiceIT.GetInstance().ExecuteScalar(query).ToString();
        }
    }
}
