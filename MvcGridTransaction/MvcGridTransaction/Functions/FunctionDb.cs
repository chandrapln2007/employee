using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TEMS_SAP.Functions
{

    public class FunctionDb
    {
        //public SqlConnection connectionStringDefault = new SqlConnection(ConfigurationManager.ConnectionStrings["DRAINTPLUS"].ConnectionString);
        public string connectionStringDefault = ConfigurationManager.ConnectionStrings["TEMS_SAP"].ConnectionString.ToString();
        private SqlConnection connection;
        private SqlCommand command = new SqlCommand();
        private string query = "";

        public FunctionDb(string connectionString)
        {
            //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DRAINTPLUS"].ConnectionString);
            connection = new SqlConnection(connectionString);

        }


        public FunctionDb()
        {
            // TODO: Complete member initialization
        }

        public DataTable GetDataTable(string strConnect, string strSql)
        //public DataTable GetDataTable(string strSql)
        {
            SqlConnection cn = new SqlConnection(strConnect);
            SqlCommand cmd = new SqlCommand(strSql, cn);
            DataTable tb = new DataTable(); // New data table.
            SqlDataAdapter adp = new SqlDataAdapter();

            adp.SelectCommand = cmd;
            tb.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adp.Fill(tb);

            return tb;
        }

        public DataTable ExecuteQuery()
        {
            DataTable dtResult = new DataTable();
            dtResult.Load(ExecuteReader());
            return dtResult;
        }

        public IDataReader ExecuteReader()
        {
            SqlDataReader reader = command.ExecuteReader();

            // SqlDataReader reader;
            //try
            //{
            //     reader = command.ExecuteReader();

            //}
            //catch (Exception e)
            //{
            //}

            return reader;
        }

        public void Open()
        {
            connection.Open();
            //conn.iscon = True
        }

        public void Close()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void SetQuery(string query)
        {
            SetQuery(query, CommandType.Text, 30);
        }

        public void SetQuery(string query, int timeOut)
        {
            SetQuery(query, CommandType.Text, timeOut);
        }

        public void SetQuery(string query, CommandType commandType, int timeOut)
        {
            this.query = query;
            command = new SqlCommand(query, connection);
            command.CommandType = commandType;
            command.CommandTimeout = timeOut;
        }

        public void AddParameter(string parameter, SqlDbType dataType, ParameterDirection paramDirect)
        {
            command.Parameters.Add(parameter, dataType);
            command.Parameters[parameter].Direction = paramDirect;
        }


        public void AddParameter(string parameter, object value)
        {
            command.Parameters.AddWithValue(parameter, value);
        }


    }

}