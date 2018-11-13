using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1660662.DataDPOAccess
{
    public class Provider
    {
        private string ConnectionString = @"Data Source=DESKTOP-H6J9M44\QTCSDL;
                                            Initial Catalog=QLSanPham;
                                            Integrated Security=True;
                                            Connect Timeout=30;
                                            Encrypt=False;
                                            TrustServerCertificate=False;
                                            ApplicationIntent=ReadWrite;
                                            MultiSubnetFailover=False;
                                            MultipleActiveResultSets=true";
        private SqlConnection Connection;
        public Provider()
        {
            Connection = new SqlConnection(ConnectionString);
        }
        public void ConnectToServer()
        {
            try
            {
                if (Connection == null)
                    Connection = new SqlConnection(ConnectionString);
                if (Connection.State == ConnectionState.Closed)
                    Connection.Open();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        public void DisConnectToServer()
        {
            try
            {
                if (Connection.State == ConnectionState.Open && Connection != null)
                    Connection.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }

        }
        public int ExecuteNonQuery(CommandType cmdType, string strSql)
        {
            try
            {
                SqlCommand cmd = Connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.CommandType = cmdType;

                int nRow = cmd.ExecuteNonQuery();
                return nRow;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        public int ExecuteNonQuery(CommandType cmdType, string strSql,
                                   params SqlParameter[] sqlParameters)
        {
            try
            {
                SqlCommand cmd = Connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.CommandType = cmdType;
                if (sqlParameters != null && sqlParameters.Length > 0)
                    cmd.Parameters.AddRange(sqlParameters);
                int nRow = cmd.ExecuteNonQuery();
                return nRow;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        public bool checkConnect()
        {
            if (Connection.State == ConnectionState.Open)
                return true;
            else
                return false;
        }
        public SqlDataReader GetReader(CommandType cmdType, string strSql)
        {
            try
            {
                SqlCommand cmd = Connection.CreateCommand();
                cmd.CommandType = cmdType;
                cmd.CommandText = strSql;
                return cmd.ExecuteReader();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        public DataTable Select(CommandType cmdType, string strSql)
        {
            try
            {
                SqlCommand cmd = Connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.CommandType = cmdType;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}
