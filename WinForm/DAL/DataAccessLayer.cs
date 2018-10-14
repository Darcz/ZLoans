using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ZAccounting
{
    class DataAccessLayer
    {
        //string _SqlConnectionString = "Data Source=MNL1WS70288;Initial Catalog=Accounting;Integrated Security=True;";
        string _SqlConnectionString = ConnectionSetting.ConnectionString;

        public string ConnectionString { 
            get { return _SqlConnectionString; }
        }

        public DataTable GetRecord(SqlConnection SqlConn_, string _SqlQuery, string _TableName = null)
        {
            DataTable dt = new DataTable(_TableName);
            using (SqlCommand _SqlComm = new SqlCommand(_SqlQuery, SqlConn_))
            {
                SqlDataAdapter da = new SqlDataAdapter(_SqlComm);
                da.Fill(dt);
            }
            return dt;
        }

        public int InsertRecord(SqlConnection SqlConn, SqlCommand _SqlCommand)
        {
            _SqlCommand.Connection = SqlConn;
            int _MasterId = (int)_SqlCommand.ExecuteScalar();
            return _MasterId;
        }

        public void ExecuteQuery(SqlConnection SqlConn, SqlCommand _SqlCommand)
        {
            _SqlCommand.Connection = SqlConn;
            _SqlCommand.ExecuteScalar();

        }
    }
}
