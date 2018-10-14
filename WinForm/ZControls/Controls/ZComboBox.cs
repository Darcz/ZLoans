using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace ZControls
{
    public class ZComboBox : ComboBox
    {
        [Category("ZProperty")]
        public string TableName { get; set; }
        [Category("ZProperty")]
        public string FieldName { get; set; }

    }
}
