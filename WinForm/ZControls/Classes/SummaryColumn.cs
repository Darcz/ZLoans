using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZControls
{
    public class SummaryColumn
    {
        public string FieldName { get; set; }
        public FooterTypes FooterType { get; set; }
        public string OutputColumn { get; set; }
        public string FooterFormat { get; set; }

        public enum FooterTypes
        {
            Sum,
            Avg,
            Count,
            Min,
            Max
        }
    }
}
