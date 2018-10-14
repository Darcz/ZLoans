using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ZAccounting
{
    public partial class BranchForm : MasterForm
    {
        BranchesBLL _BLL = new BranchesBLL();

        public BranchForm()
        {
            InitializeComponent();
            SourceTables = _BLL.SourceTables;
        }

        protected override void GetRecord()
        {
            _BLL.MasterId = _MasterId;
            SourceDataSet = _BLL.GetRecordById();
        }

        protected override void SaveRecord()
        {
            try
            {
                base.SaveRecord();
                _MasterId = _BLL.SaveRecord(SourceDataSet);
                FormMode = FormModes.View;
                TLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
