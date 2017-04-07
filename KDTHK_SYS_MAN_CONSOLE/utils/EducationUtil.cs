using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using KDTHK_SYS_MAN_CONSOLE.services;
using System.Diagnostics;

namespace KDTHK_SYS_MAN_CONSOLE.utils
{
    public class EducationUtil
    {
        public static int GetEducation()
        {
            string query = "select top 1 e_id from TB_EDUCATION where e_enabled = 'True' order by e_id desc";
            object result = DataServiceEducation.GetInstance().ExecuteScalar(query);

            return (int)result;
        }

        public static bool IsTitleExist(string title)
        {
            string query = string.Format("select count(*) from TB_EDUCATION where e_title = N'{0}'", title);
            object result = DataServiceEducation.GetInstance().ExecuteScalar(query);

            if (result is DBNull || (int)result == 0)
                return false;

            return true;
        }

        public static bool IsEducationOpened()
        {
            string query = "select count(*) from TB_EDUCATION where e_enabled = 'True'";
            object result = DataServiceEducation.GetInstance().ExecuteScalar(query);

            if (result is DBNull || (int)result == 0)
                return false;

            return true;
        }

        public static List<int> GetAllTypeId()
        {
            List<int> list = new List<int>();

            string query = "select t_id from TB_MASTER_TYPE";

            using (IDataReader reader = DataServiceEducation.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    list.Add(id);
                }
            }

            return list;
        }

        public static int GetTypeId(string type)
        {
            string query = string.Format("select t_id from TB_MASTER_TYPE where t_tag = '{0}'", type);
            object result = DataService.GetInstance().ExecuteScalar(query);

            System.Diagnostics.Debug.WriteLine(query);
            return (int)result;
        }

        public static int GetEducationId(string title)
        {
            string query = string.Format("select e_id from TB_EDUCATION where e_title = N'{0}'", title);
            object result = DataServiceEducation.GetInstance().ExecuteScalar(query);

            return (int)result;
        }

        public static bool IsUserExists(string staffid)
        {
            string query = string.Format("select count(*) from TB_STAFF where st_staffid = '{0}'", staffid);
            object result = DataServiceEducation.GetInstance().ExecuteScalar(query);

            if (result is DBNull || (int)result == 0)
                return false;

            return true;
        }

        public static Int32 GetQuestionId(string content)
        {
            string query = string.Format("select q_id from TB_IT_EDU_QUESTION where q_question = N'{0}'", content);
            //string query = "select top 1 q_id from TB_QUESTION order by q_id desc";
            object result = DataServiceEdu.GetInstance().ExecuteScalar(query);

            return (int)result;
        }

        #region KDTHK Staff
        public static int GetKDTHKRecordCount(int educationid)
        {
            string query = string.Format("select count(*) from TB_RECORD where r_company = 'kdthk' and r_educationid = '{0}'", educationid);
            object result = DataServiceEducation.GetInstance().ExecuteScalar(query);

            return (int)result;
        }

        public static int GetKDTHKCount()
        {
            string query = "select count(*) from TB_STAFF where st_company = 'KDTHK'";
            object result = DataServiceEducation.GetInstance().ExecuteScalar(query);

            return (int)result;
        }
        #endregion

        #region KDAS Staff
        public static int GetKDASRecordCount(int educationid)
        {
            string query = string.Format("select count(*) from TB_RECORD where r_company = 'kdas' and r_educationid = '{0}'", educationid);
            object result = DataServiceEducation.GetInstance().ExecuteScalar(query);

            return (int)result;
        }

        public static int GetKDASCount()
        {
            string query = "select count(*) from TB_STAFF where st_company = 'KDAS'";
            object result = DataServiceEducation.GetInstance().ExecuteScalar(query);

            return (int)result;
        }
        #endregion

        #region KDHG Staff
        public static int GetKDHGRecordCount(int educationid)
        {
            string query = string.Format("select count(*) from TB_RECORD where r_company = 'kdhk' and r_educationid = '{0}'", educationid);
            object result = DataServiceEducation.GetInstance().ExecuteScalar(query);

            return (int)result;
        }

        public static int GetKDHGCount()
        {
            string query = "select count(*) from TB_STAFF where st_company = 'KDHK'";
            object result = DataServiceEducation.GetInstance().ExecuteScalar(query);

            return (int)result;
        }
        #endregion
    }
}
