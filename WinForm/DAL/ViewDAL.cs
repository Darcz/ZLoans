using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace ZAccounting 
{
    class ViewDAL : DataAccessLayer
    {
        public DataTable LoadView(string CommandText)
        {            
            using (SqlConnection SqlConn_ = new SqlConnection(ConnectionSetting.ConnectionString))
            {
                using (SqlCommand _SqlComm = new SqlCommand(CommandText, SqlConn_))
                {
                    DataTable DS_ = new DataTable();
                    SqlConn_.Open();
                    SqlDataAdapter da = new SqlDataAdapter(_SqlComm);
                    da.Fill(DS_);
                    return DS_;
                }
            }
        }

    }
}
