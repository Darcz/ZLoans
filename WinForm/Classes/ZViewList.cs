using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.SqlClient;
using Dapper;

namespace ZAccounting
{
    public static class ZViewList
    {
        static List<ZView> _ViewList = null;

        public static List<ZView> ViewList
        { 
            get { return _ViewList; } 
        }

        static ZViewList()
        {
            ReloadViews();
        }

        private static void ReloadViews()
        {
            _ViewList = GetAllViews();

            foreach (ZView V_ in _ViewList)
            {
                XDocument XMLCode_ = XDocument.Parse(V_.XMLCode);
                List<ZColumn> Columns_ = new List<ZColumn>(); //Holder
                var ColumnsElement_ = XMLCode_.Root.Element("Columns");
                foreach (XElement col_ in ColumnsElement_.Descendants("Column"))
                {
                    Columns_.Add(new ZColumn
                    {
                        Name = GetElementValue(col_, "Name"),
                        Caption = GetElementValue(col_, "Caption", "Name"),
                        FieldName = GetElementValue(col_, "FieldName", "Name"),
                        ColumnType = GetElementValue(col_, "Type"),
                        Width = Convert.ToInt16(GetElementValue(col_, "Width", null, "100")),
                        Hidden = Convert.ToBoolean(GetElementValue(col_, "Hidden", null, "False")),
                        DataSource = GetElementValue(col_, "DataSource"),
                        DisplayMember = GetElementValue(col_, "DisplayMember"),
                        ValueMember = GetElementValue(col_, "ValueMember"),
                        DefaultValue = GetElementValue(col_, "DefaultValue"),
                        FooterFieldName = GetElementValue(col_, "FooterFieldName"),
                        FooterFormat = GetElementValue(col_, "FooterFormat"),
                        FooterType = GetElementValue(col_, "FooterType")
                    });
                }
                V_.Columns = Columns_;
                V_.CommandText = XMLCode_.Root.Element("CommandText").Value;
            }

        }

        private static List<ZView> GetAllViews()
        {
            string SqlQuery_ = "SELECT Id, Name, Caption, Category, XMLCode, Active FROM tblZViews";
            using (SqlConnection SqlConn_ = new SqlConnection(ConnectionSetting.ConnectionString))
            {
                return SqlConn_.Query<ZView>(SqlQuery_).ToList();
            }
        }

        static string GetElementValue(XElement _XElem, string _Elem, string _RepElem = null, string _DefValue = null)
        {
            string _Result = null;
            if (_XElem.Element(_Elem) != null)
            {
                _Result = _XElem.Element(_Elem).Value;
            }
            else if (_XElem.Element(_RepElem) != null)
            {
                _Result = _XElem.Element(_RepElem).Value;
            }
            else
            {
                _Result = _DefValue;
            }
            return _Result;
        }

    }
}
