using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using CustomUtil.utils.import;

namespace KDTHK_SYS_MAN_CONSOLE.flat_forms.education
{
    public partial class EducationReport : UserControl
    {
        int _kdthk = 0; int _kdas = 0; int _kdhk = 0;
        int _kdthkS = 0; int _kdasS = 0; int _kdhkS = 0;
        int _kdthkSum = 0; int _kdasSum = 0; int _kdhkSum = 0;

        public EducationReport()
        {
            InitializeComponent();

            _kdthk = kdthkTotal();
            _kdas = kdasTotal();
            _kdhk = kdhkTotal();

            GetKdthkSubmitted();
            GetKdasSubmitted();
            GetKdhkSubmitted();

            decimal kdthkAvg = Math.Round(Convert.ToDecimal(_kdthkSum) / Convert.ToDecimal(_kdthk), 2);
            decimal kdasAvg = Math.Round(Convert.ToDecimal(_kdasSum) / Convert.ToDecimal(_kdas), 2);
            decimal kdhkAvg = Math.Round(Convert.ToDecimal(_kdhkSum) / Convert.ToDecimal(_kdhk), 2);

            decimal kdthkAvgS = Math.Round(Convert.ToDecimal(_kdthkSum) / Convert.ToDecimal(_kdthkS), 2);
            decimal kdasAvgS = Math.Round(Convert.ToDecimal(_kdasSum) / Convert.ToDecimal(_kdasS), 2);
            decimal kdhkAvgS = Math.Round(Convert.ToDecimal(_kdhkSum) / Convert.ToDecimal(_kdhkS), 2);

            Debug.WriteLine("KDTHK - Total: " + _kdthk + " Avg: " + kdthkAvg + " Submitted: " + _kdthkS + " Avg: " + kdthkAvgS);
            Debug.WriteLine("KDAS - Total: " + _kdas + " Avg: " + kdasAvg + " Submitted: " + _kdasS + " Avg: " + kdasAvgS);
            Debug.WriteLine("KDHK - Total: " + _kdhk + " Avg: " + kdhkAvg + " Submitted: " + _kdhkS + " Avg: " + kdhkAvgS);

            string[] companies = { "KDTHK", "KDAS", "KDHK" };
            decimal[] average = { kdthkAvg, kdasAvg, kdhkAvg };
            
        }

        private int kdthkTotal()
        {
            string query = "select count(*) from TB_USER where u_company = 'KDTHK'";
            return (int)DataServiceEdu.GetInstance().ExecuteScalar(query);
        }

        private int kdasTotal()
        {
            string query = "select count(*) from TB_USER where u_company = 'KDAS'";
            return (int)DataServiceEdu.GetInstance().ExecuteScalar(query);
        }

        private int kdhkTotal()
        {
            string query = "select count(*) from TB_USER where u_company = 'KDHK'";
            return (int)DataServiceEdu.GetInstance().ExecuteScalar(query);
        }

        private void GetKdthkSubmitted()
        {
            string query = "select count(*), sum(cast(r_score as int)) from TB_IT_EDU_RECORD where r_company = 'KDTHK'";
            using (IDataReader reader = DataServiceEdu.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    _kdthkS = reader.GetInt32(0);
                    _kdthkSum = reader.GetInt32(1);
                }
            }
        }

        private void GetKdasSubmitted()
        {
            string query = "select count(*), sum(cast(r_score as int)) from TB_IT_EDU_RECORD where r_company = 'KDAS'";
            using (IDataReader reader = DataServiceEdu.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    _kdasS = reader.GetInt32(0);
                    _kdasSum = reader.GetInt32(1);
                }
            }
        }

        private void GetKdhkSubmitted()
        {
            string query = "select count(*), sum(cast(r_score as int)) from TB_IT_EDU_RECORD where r_company = 'KDHK'";
            using (IDataReader reader = DataServiceEdu.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    _kdhkS = reader.GetInt32(0);
                    _kdhkSum = reader.GetInt32(1);
                }
            }
        }

    }
}
