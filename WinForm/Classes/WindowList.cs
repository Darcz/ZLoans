using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZAccounting
{
    public static class WindowList
    {
        public static List<WindowInstance> WindowInstances = new List<WindowInstance>();

        public class WindowInstance
        {
            public string Caption { get; set; }
            public string FormName { get; set; }
            public Form WindowForm { get; set; }
        }
    }
}
