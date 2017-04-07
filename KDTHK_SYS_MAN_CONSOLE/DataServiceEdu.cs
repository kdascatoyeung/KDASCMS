﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace KDTHK_SYS_MAN_CONSOLE
{
    class DataServiceEdu
    {
        private SqlConnection connection;
        private static DataServiceEdu _dataService = null;
        private SqlCommand command;

        private DataServiceEdu()
        {
            //string connectionString = "server=KDTHK-INTDB\\KDTHK_DB;database=KDTHK_SYS_DB;user id=sa;password=Aa123456";
            string connectionString = "server=KDTHK-INTDB\\KDTHK_DB;database=KDTHK_DB;user id=sa;password=Aa123456";
            //string connectionString = "server=KDTHK-INTDB\\KDTHK_DB;database=db_mould;user id=sa;password=Aa123456";
            //string connectionString = "server=HSP1DB01\\KM_SQUARE;database=KDTHK_DMV2;user id=general;password=JLgj2007";
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
        }

        public static DataServiceEdu GetInstance()
        {
            if (_dataService == null)
                _dataService = new DataServiceEdu();

            return _dataService;
        }

        public SqlConnection Connection
        {
            get { return connection; }
        }

        public SqlDataReader ExecuteReader(string query)
        {
            command.CommandText = query;
            return command.ExecuteReader();
        }

        public object ExecuteScalar(string query)
        {
            command.CommandText = query;
            return command.ExecuteScalar();
        }

        public SqlCommand CreateCommand(string query)
        {
            return connection.CreateCommand();
        }

        public int ExecuteNonQuery(string commandText)
        {
            command.CommandText = commandText;
            return command.ExecuteNonQuery();
        }

        public SqlTransaction BeginTransaction()
        {
            return Connection.BeginTransaction();
        }
    }
}
