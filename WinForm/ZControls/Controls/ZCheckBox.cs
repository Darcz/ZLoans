using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace ZControls
{
    public class ZCheckBox : CheckBox
    {
        [Category("ZProperty")]
        public string TableName { get; set; }
        [Category("ZProperty")]
        public string FieldName { get; set; }
    }
}
