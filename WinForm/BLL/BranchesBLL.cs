using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ZAccounting
{
    class BranchesBLL
    {
        int _MasterId = -1;
        BranchesDAL _DAL = new BranchesDAL();

        public int MasterId
        {
            get { return _MasterId; }
            set
            {
                _DAL.MasterId = value;
                _MasterId = value;
            }
        }

        public DataSet GetRecordById()
        {
            return _DAL.GetRecordById();
        }

        public List<ZTable> SourceTables
        {
            get { return _DAL.SourceTables; }
        }

        public int SaveRecord(DataSet _SourceDataset)
        {
            MasterId = _DAL.SaveRecord(_SourceDataset);
            return MasterId;
        }

    }
}
