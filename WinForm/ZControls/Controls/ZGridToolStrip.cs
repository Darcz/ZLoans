using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace ZControls
{
    public class ZGridToolStrip : ToolStrip
    {
        
        [Category("ZProperty")]
        public DataGridView GridView { get; set; }

    }
}
