﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAccounting
{
    class BranchesDAL : MasterDAL
    {
        public BranchesDAL()
        {
            List<ZColumn> _MasterColumnsList = new List<ZColumn>();
            _MasterColumnsList.Add(new ZColumn { Name = "Id", FieldName = "Id", Required = false, ReadOnly = true, ColumnType = "int" });
            _MasterColumnsList.Add(new ZColumn { Name = "Code", FieldName = "Code", Required = true, ReadOnly = false, ColumnType = "string" });
            _MasterColumnsList.Add(new ZColumn { Name = "Name", FieldName = "Name", Required = true, ReadOnly = false, ColumnType = "string" });
            _MasterColumnsList.Add(new ZColumn { Name = "Active", FieldName = "Active", Required = true, ReadOnly = false, ColumnType = "bool", DefaultValue = "true" });

            SourceTables.Add(new ZTable { TableName = "tblBranches", ParameterFieldName = "Id", ColumnList = _MasterColumnsList });
        }
    }
}
