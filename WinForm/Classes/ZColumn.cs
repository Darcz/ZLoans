using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAccounting
{
    public class ZColumn
    {
        public string Name { get; set; }
        public string Caption { get; set; }
        public string FieldName { get; set; }
        public string ColumnType { get; set; }
        public bool Hidden { get; set; }
        public bool Visible { get; set; }
        public int Width { get; set; }
        public bool Required { get; set; }
        public bool ReadOnly { get; set; }
        public string DataSource { get; set; }
        public string DisplayMember { get; set; }
        public string ValueMember { get; set; }
        public string DefaultValue { get; set; }
        public string FooterFieldName { get; set; }
        public string FooterType { get; set; }
        public string FooterFormat { get; set; }
    }
}
