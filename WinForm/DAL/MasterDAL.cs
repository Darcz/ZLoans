using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ZAccounting
{
    class MasterDAL
    {
        int _MasterId = -1;
        string _SqlQuery = null;
        DataAccessLayer _DAL = new DataAccessLayer();
        public List<ZTable> SourceTables = new List<ZTable>();

        public int MasterId 
        {
            get { return _MasterId; }
            set { _MasterId = value; }
        }

        public DataSet GetRecordById(int? Id_ = null)
        {
            Id_ = Id_ ?? _MasterId;
            DataSet SourceDataSet_ = new DataSet();
            string ColumnsList_ = null;

            using (SqlConnection SqlConn_ = new SqlConnection(_DAL.ConnectionString))
            {
                foreach (ZTable tc_ in SourceTables)
                {
                    ColumnsList_ = tc_.ColumnList.Select(i => i.FieldName).Aggregate((i, j) => i + ", " + j);
                    if (Id_ == -1) //New
                    {
                        _SqlQuery = "SELECT TOP 0 " + ColumnsList_ + " FROM " + tc_.TableName;
                    }
                    else
                    {
                        _SqlQuery = "SELECT " + ColumnsList_ + " FROM " + tc_.TableName + " WHERE " + tc_.ParameterFieldName + " = " + Id_.ToString();
                    }
                    SourceDataSet_.Tables.Add(_DAL.GetRecord(SqlConn_, _SqlQuery, tc_.TableName));
                }
            }
            return SourceDataSet_;
        }

        public int SaveRecord(DataSet _SourceDS)
        {
            string _ColumnList = null;
            string _ParamList = null;
            string _SqlUpdateColumnList = null;
            string _SqlDeleteIdList = null;
            //Save Master Table
            List<ZColumn> _TableColumns = SourceTables.First().ColumnList;
            string _TableName = SourceTables.First().TableName;
            using (SqlConnection SqlConn_ = new SqlConnection(_DAL.ConnectionString))
            {
                SqlConn_.Open();
                if (_MasterId == -1)
                {
                    //Insert
                    SqlCommand _SqlComm = new SqlCommand();
                    _ColumnList = _TableColumns.Where(f => f.FieldName != "Id").Select(i => i.FieldName).Aggregate((i, j) => i + ", " + j);
                    _ParamList = "@" + _TableColumns.Where(f => (f.FieldName != "Id") && (f.ReadOnly == false)).Select(i => i.FieldName).Aggregate((i, j) => i + ", @" + j);
                    _SqlQuery = "INSERT INTO " + _TableName + " (" + _ColumnList + ") OUTPUT INSERTED.ID VALUES ( " + _ParamList + ")";
                    _SqlComm.CommandText = _SqlQuery;
                    foreach (DataColumn c in _SourceDS.Tables[0].Columns)
                    {
                        _SqlComm.Parameters.AddWithValue("@" + c.ColumnName, _SourceDS.Tables[0].Rows[0][c.ColumnName].ToString());
                    }
                    _MasterId = _DAL.InsertRecord(SqlConn_, _SqlComm);
                }
                else
                {   //UPDATE
                    SqlCommand _SqlComm = new SqlCommand();
                    _SqlUpdateColumnList = "";
                    foreach (ZColumn c in _TableColumns.Where(f => (f.FieldName != "Id") && (f.ReadOnly == false)))
                    {
                        if (_SqlUpdateColumnList != "")
                        {
                            _SqlUpdateColumnList = _SqlUpdateColumnList + ", ";
                        }
                        _SqlUpdateColumnList = _SqlUpdateColumnList + c.FieldName + " = @" + c.FieldName;
                    }
                    _SqlQuery = "UPDATE " + _TableName + " SET " + _SqlUpdateColumnList + " WHERE Id = @Id";
                    _SqlComm.CommandText = _SqlQuery;
                    foreach (DataColumn c in _SourceDS.Tables[0].Columns)
                    {
                        _SqlComm.Parameters.AddWithValue("@" + c.ColumnName, _SourceDS.Tables[0].Rows[0][c.ColumnName].ToString());
                    }
                    _DAL.ExecuteQuery(SqlConn_, _SqlComm);
                }
                //Get Latest Record
                DataSet TargetDataset = GetRecordById(_MasterId);


                DataRow[] _UpdateList = null;
                DataRow[] _DeleteList = null;
                DataRow[] _InsertList = null;

                string _SourceIDList = null;
                string _TargetIdList = null;
                DataTable _TargetDetailTable = null;
                DataTable _DetailTable = null;
                foreach (ZTable cc in SourceTables.Where((v, i) => i != 0))
                {
                    _TableColumns = cc.ColumnList;
                    _DetailTable = _SourceDS.Tables[cc.TableName];
                    _DetailTable.AcceptChanges();
                    _SourceIDList = string.Join(", ", _DetailTable.AsEnumerable().Select(x => x["Id"].ToString()).ToArray());
                    _SourceIDList = _SourceIDList == ", " ? null : _SourceIDList;
                    if (!TargetDataset.Tables.Contains(cc.TableName))
                    {
                        //insert only
                    }
                    else
                    {
                        _TargetDetailTable = TargetDataset.Tables[cc.TableName];
                        _TargetIdList = string.Join(", ", _TargetDetailTable.AsEnumerable().Select(x => x["Id"].ToString()).ToArray());
                        _InsertList = (DataRow[])_DetailTable.Select("Id IS NULL");

                        if (_TargetIdList == null || _TargetIdList == "")
                            _UpdateList = new DataRow[0];
                        else
                            _UpdateList = (DataRow[])_DetailTable.Select("Id IN (" + _TargetIdList + ")");

                        if (_SourceIDList == null || _SourceIDList == "")
                            _DeleteList = new DataRow[0];
                        else
                            _DeleteList = (DataRow[])_TargetDetailTable.Select("Id NOT IN (" + _SourceIDList + ")");

                        if (_InsertList.Count() != 0)
                        {
                            //Insert
                            _ColumnList = _TableColumns.Where(f => (f.FieldName != "Id") && (f.FieldName != cc.ParameterFieldName) && (f.ReadOnly == false)).Select(i => i.FieldName).Aggregate((i, j) => i + ", " + j);
                            _ParamList = "@" + _TableColumns.Where(f => (f.FieldName != "Id") && (f.FieldName != cc.ParameterFieldName) && (f.ReadOnly == false)).Select(i => i.FieldName).Aggregate((i, j) => i + ", @" + j);
                            _SqlQuery = "INSERT INTO " + _TargetDetailTable + " (" + cc.ParameterFieldName + ", " + _ColumnList + ") OUTPUT INSERTED.ID VALUES ( " + _MasterId + ", " + _ParamList + ")";
                            foreach (DataRow r in _InsertList)
                            {
                                SqlCommand _SqlComm = new SqlCommand();
                                _SqlComm.CommandText = _SqlQuery;
                                foreach (DataColumn c in _DetailTable.Columns)
                                {
                                    _SqlComm.Parameters.AddWithValue("@" + c.ColumnName, r[c.ColumnName].ToString());
                                }
                                _DAL.InsertRecord(SqlConn_, _SqlComm);
                            }
                        }

                        if (_UpdateList.Count() != 0)
                        {
                            _SqlUpdateColumnList = "";
                            foreach (ZColumn c in _TableColumns.Where(f => (f.FieldName != "Id") && (f.ReadOnly == false)))
                            {
                                if (_SqlUpdateColumnList != "")
                                {
                                    _SqlUpdateColumnList = _SqlUpdateColumnList + ", ";
                                }
                                _SqlUpdateColumnList = _SqlUpdateColumnList + c.FieldName + " = @" + c.FieldName;
                            }
                            _SqlQuery = "UPDATE " + _TargetDetailTable + " SET " + _SqlUpdateColumnList + " WHERE Id = @Id";
                            foreach (DataRow r in _UpdateList)
                            {
                                SqlCommand _SqlComm = new SqlCommand();
                                _SqlComm.CommandText = _SqlQuery;
                                foreach (DataColumn c in _DetailTable.Columns)
                                {
                                    _SqlComm.Parameters.AddWithValue("@" + c.ColumnName, r[c.ColumnName].ToString());
                                }
                                _DAL.ExecuteQuery(SqlConn_, _SqlComm);
                            }
                        }
                        if (_DeleteList.Count() != 0)
                        {
                            SqlCommand _SqlComm = new SqlCommand();
                            _SqlDeleteIdList = string.Join(", ", _DeleteList.AsEnumerable().Select(x => x["Id"].ToString()).ToArray());
                            _SqlQuery = "DELETE FROM " + _TargetDetailTable + " WHERE ID IN (" + _SqlDeleteIdList + ")";
                            _SqlComm.CommandText = _SqlQuery;
                            _DAL.ExecuteQuery(SqlConn_, _SqlComm);
                        }
                    }
                }
            }
            return _MasterId;
        }

    }
}
