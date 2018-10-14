using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAccounting
{
    public class ZView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CommandText { get; set; }
        public string Caption { get; set; }
        public string Category { get; set; }
        public string XMLCode { get; set; }
        public bool Active { get; set; }
        public List<ZColumn> Columns { get; set; }
    }
}
