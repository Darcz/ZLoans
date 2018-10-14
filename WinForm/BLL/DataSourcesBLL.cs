using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
using System.Data.SqlClient;

namespace ZAccounting
{
    class DataSourcesBLL
    {
        DataAccessLayer dal = new DataAccessLayer();
        string _SqlQuery = null;

        public DataTable CategoriesAll()
        {
            _SqlQuery = "SELECT Id, Code, Name, Active FROM tblCategories";
            using (SqlConnection SqlConn_ = new SqlConnection(ConnectionSetting.ConnectionString))
            {
                DataTable _DA = dal.GetRecord(SqlConn_, _SqlQuery, "tblCategories");
                return _DA;
            }
        }
        public DataTable AccountTypesAll()
        {
            _SqlQuery = "SELECT Id, Code, Name, Active FROM tblChartofAccountTypes";
            using (SqlConnection SqlConn_ = new SqlConnection(ConnectionSetting.ConnectionString))
            {
                DataTable _DA = dal.GetRecord(SqlConn_, _SqlQuery, "tblChartofAccountTypes");
                return _DA;
            }
        }
        public DataTable GetRecord(string DataSourceName)
        {
            Type _Type = this.GetType();
            DataTable _DA = null;
            MethodInfo DataSourceMethod = _Type.GetMethod(DataSourceName);
            _DA = (DataTable)DataSourceMethod.Invoke(this, null);
            return _DA;
        }

        public DataTable TransactionTypesAll()
        {
            _SqlQuery = "SELECT Id, Code, Name, Active FROM tblTransactionTypes";
            using (SqlConnection SqlConn_ = new SqlConnection(ConnectionSetting.ConnectionString))
            {
                DataTable _DA = dal.GetRecord(SqlConn_, _SqlQuery, "tblTransactionTypes");
                return _DA;
            }
        }

        public DataTable AccountsAll()
        {
            _SqlQuery = "SELECT Id, AccountCode, AccountName, Active FROM tblLedgerAccounts";
            using (SqlConnection SqlConn_ = new SqlConnection(ConnectionSetting.ConnectionString))
            {
                DataTable _DA = dal.GetRecord(SqlConn_, _SqlQuery, "tblLedgerAccounts");
                return _DA;
            }
        }
    }
}
