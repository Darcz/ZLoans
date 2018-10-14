using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public static string ConnectionString = "Data Source=MNL1WS70288;Initial Catalog=Accounting;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionString = "Data Source=" + txtServer.Text.Trim() + ";Initial Catalog=" + txtDatabase.Text.Trim() + ";Integrated Security=True;";

        }

        private void GetViews()
        { 
            DataTable dt = new DataTable("tblZViews");
            using (SqlConnection SqlConn_ = new SqlConnection(ConnectionString))
            {
                using (SqlCommand SqlComm_ = new SqlCommand("SELECT * FROM tblZViews", SqlConn_))
                {
                    SqlDataAdapter da = new SqlDataAdapter(SqlComm_);
                    da.Fill(dt);
                }
            }
            GridViewList.DataSource = dt;

            DataTable coldt = new DataTable("Columns");
            coldt.Columns.Add("Name");
            coldt.Columns.Add("Caption");
            coldt.Columns.Add("Type");
            coldt.Columns.Add("Width");
            coldt.Columns.Add("DefaultValue");
            coldt.Columns.Add("DataSource");
            coldt.Columns.Add("ValueMember");
            coldt.Columns.Add("DisplayMember");
            coldt.Columns.Add("FooterFieldName");
            coldt.Columns.Add("FooterType");
            coldt.Columns.Add("Visible");
            GridViewColumns.DataSource = coldt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetViews();
        }

        private void GridViewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = GridViewList.Rows[GridViewList.SelectedCells[0].RowIndex].Cells["Name"].Value.ToString();
            txtCaption.Text = GridViewList.Rows[GridViewList.SelectedCells[0].RowIndex].Cells["Caption"].Value.ToString();
            txtCategory.Text = GridViewList.Rows[GridViewList.SelectedCells[0].RowIndex].Cells["Category"].Value.ToString();
            txtActive.Checked = Convert.ToBoolean(GridViewList.Rows[GridViewList.SelectedCells[0].RowIndex].Cells["Active"].Value);

            DataTable coldt = (DataTable)GridViewColumns.DataSource;
            coldt.Rows.Clear();
            string XMLCode = GridViewList.Rows[GridViewList.SelectedCells[0].RowIndex].Cells["XMLCode"].Value.ToString();
            XDocument ViewXML = XDocument.Parse(XMLCode);
            var ColumnsElement_ = ViewXML.Root.Element("Columns");

            txtCommandText.Text = ViewXML.Root.Element("CommandText").Value;
            txtXMLName.Text = ViewXML.Root.Element("Name").Value;
            foreach (XElement col_ in ColumnsElement_.Descendants("Column"))
            {
                DataRow dr = coldt.NewRow();
                dr["Name"] = GetElementValue(col_, "Name");
                dr["Type"] = GetElementValue(col_, "Type");
                dr["Caption"] = GetElementValue(col_, "Caption");
                dr["Width"] = GetElementValue(col_, "Width");
                dr["DefaultValue"] = GetElementValue(col_, "DefaultValue");
                dr["DataSource"] = GetElementValue(col_, "DataSource");
                dr["ValueMember"] = GetElementValue(col_, "ValueMember");
                dr["DisplayMember"] = GetElementValue(col_, "DisplayMember");
                dr["FooterFieldName"] = GetElementValue(col_, "FooterFieldName");
                dr["FooterType"] = GetElementValue(col_, "FooterType");
                dr["Visible"] = GetElementValue(col_, "Visible");
                coldt.Rows.Add(dr);
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

        private void GridViewColumns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcolName.Text = GridViewColumns.Rows[GridViewColumns.SelectedCells[0].RowIndex].Cells["Name"].Value.ToString();
            txtcolCaption.Text = GridViewColumns.Rows[GridViewColumns.SelectedCells[0].RowIndex].Cells["Caption"].Value.ToString();
            txtcolType.Text = GridViewColumns.Rows[GridViewColumns.SelectedCells[0].RowIndex].Cells["Type"].Value.ToString();
            txtcolWidth.Text = GridViewColumns.Rows[GridViewColumns.SelectedCells[0].RowIndex].Cells["Width"].Value.ToString();
            txtcolDefaultValue.Text = GridViewColumns.Rows[GridViewColumns.SelectedCells[0].RowIndex].Cells["DefaultValue"].Value.ToString();
            txtcolDataSource.Text = GridViewColumns.Rows[GridViewColumns.SelectedCells[0].RowIndex].Cells["DataSource"].Value.ToString();
            txtcolValueMember.Text = GridViewColumns.Rows[GridViewColumns.SelectedCells[0].RowIndex].Cells["ValueMember"].Value.ToString();
            txtcolDisplayMember.Text = GridViewColumns.Rows[GridViewColumns.SelectedCells[0].RowIndex].Cells["DisplayMember"].Value.ToString();
            txtcolFooterName.Text = GridViewColumns.Rows[GridViewColumns.SelectedCells[0].RowIndex].Cells["FooterFieldName"].Value.ToString();
            txtcolFooterType.Text = GridViewColumns.Rows[GridViewColumns.SelectedCells[0].RowIndex].Cells["FooterType"].Value.ToString();
            cbVisible.Checked = GridViewColumns.Rows[GridViewColumns.SelectedCells[0].RowIndex].Cells["Visible"].Value.ToString() == "1";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = GridViewColumns.DataSource as DataTable;
            DataRow dr = dt.NewRow();
            txtcolName.Text = "";
            txtcolCaption.Text = "";
            txtcolType.Text = "";
            txtcolWidth.Text = "";
            txtcolDefaultValue.Text = "";
            txtcolDataSource.Text = "";
            txtcolValueMember.Text = "";
            txtcolDisplayMember.Text = "";
            txtcolFooterName.Text = "";
            txtcolFooterType.Text = "";
            dt.Rows.Add(dr);
            GridViewColumns.ClearSelection();
            GridViewColumns.CurrentCell = GridViewColumns.Rows[GridViewColumns.Rows.Count - 1].Cells[0];
            //GridViewColumns.Rows[GridViewColumns.Rows.Count - 1].Selected = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = GridViewColumns.DataSource as DataTable;
            DataRowView currentDataRowView = (DataRowView)GridViewColumns.CurrentRow.DataBoundItem;
            DataRow dr = currentDataRowView.Row;
            dr["Name"] = txtcolName.Text.Trim();
            dr["Type"] = txtcolType.Text.Trim();
            dr["Caption"] = txtcolCaption.Text.Trim();
            dr["Width"] = txtcolWidth.Text.Trim();
            dr["DefaultValue"] = txtcolDefaultValue.Text.Trim();
            dr["DataSource"] = txtcolDataSource.Text.Trim();
            dr["ValueMember"] = txtcolValueMember.Text.Trim();
            dr["DisplayMember"] = txtcolDisplayMember.Text.Trim();
            dr["FooterFieldName"] = txtcolFooterName.Text.Trim();
            dr["FooterType"] = txtcolFooterType.Text.Trim();
            dr["Visible"] = cbVisible.Checked.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string XMLCode;

            XMLCode = "<Root>";
            XMLCode += "<Name>" + txtXMLName.Text.Trim() + "</Name>";
            XMLCode += "<CommandText>" + txtCommandText.Text.Trim() + "</CommandText>";
            XMLCode += "<Columns>";
            DataTable dt = GridViewColumns.DataSource as DataTable;
            foreach (DataRow dr in dt.Rows)
            {
                XMLCode += "<Column>";
                XMLCode += dr["Name"].ToString() == "" ? "" : "<Name>" + dr["Name"] + "</Name>";
                XMLCode += dr["Type"].ToString() == "" ? "" : "<Type>" + dr["Type"] + "</Type>";
                XMLCode += dr["Caption"].ToString() == "" ? "" : "<Caption>" + dr["Caption"] + "</Caption>";
                XMLCode += dr["Width"].ToString() == "" ? "" : "<Width>" + dr["Width"] + "</Width>";
                XMLCode += dr["DefaultValue"].ToString() == "" ? "" : "<DefaultValue>" + dr["DefaultValue"] + "</DefaultValue>";
                XMLCode += dr["DataSource"].ToString() == "" ? "" : "<DataSource>" + dr["DataSource"] + "</DataSource>";
                XMLCode += dr["ValueMember"].ToString() == "" ? "" : "<ValueMember>" + dr["ValueMember"] + "</ValueMember>";
                XMLCode += dr["DisplayMember"].ToString() == "" ? "" : "<DisplayMember>" + dr["DisplayMember"] + "</DisplayMember>";
                XMLCode += dr["FooterFieldName"].ToString() == "" ? "" : "<FooterFieldName>" + dr["FooterFieldName"] + "</FooterFieldName>";
                XMLCode += dr["FooterType"].ToString() == "" ? "" : "<FooterType>" + dr["FooterType"] + "</FooterType>";
                XMLCode += dr["Visible"].ToString() == "" ? "" : "<Visible>" + dr["Visible"] + "</Visible>";
                XMLCode += "</Column>";
            }
            XMLCode += "</Columns>";
            XMLCode += "</Root>";

            DataTable dt2 = GridViewList.DataSource as DataTable;
            DataRowView currentDataRowView = (DataRowView)GridViewList.CurrentRow.DataBoundItem;
            DataRow dr2 = currentDataRowView.Row;
            dr2["Name"] = txtName.Text.Trim();
            dr2["Caption"] = txtCaption.Text.Trim();
            dr2["Category"] = txtCategory.Text.Trim();
            dr2["Active"] = txtActive.Checked;
            dr2["XMLCode"] = XMLCode;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlConn_ = new SqlConnection(ConnectionString))
            {
                SqlConn_.Open();
                SqlCommand SqlComm_ = new SqlCommand("DELETE FROM tblZViews");
                SqlComm_.Connection = SqlConn_;
                SqlComm_.ExecuteScalar();
                
                DataTable dt = GridViewList.DataSource as DataTable;
                dt.AcceptChanges();
                foreach (DataRow dr in dt.Rows)
                {
                    string Query_ = "INSERT INTO tblZViews";
                    Query_ += " VALUES (";
                    Query_ += "'" + dr["Name"] + "',";
                    Query_ += "'" + dr["Caption"] + "',";
                    Query_ += "'" + dr["Category"] + "',";
                    Query_ += "'" + dr["XMLCode"] + "',";
                    Query_ += "'" + dr["Active"] + "'";
                    Query_ += ")";

                    using (SqlCommand SC_ = new SqlCommand(Query_))
                    {
                        SC_.Connection = SqlConn_;
                        SC_.ExecuteScalar();
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)GridViewList.DataSource;
            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);
            GridViewList.ClearSelection();
            GridViewList.CurrentCell = GridViewList.Rows[GridViewList.Rows.Count - 1].Cells[0];

            DataTable dt2 = (DataTable)GridViewColumns.DataSource;
            dt2.Rows.Clear();
            txtName.Text = "";
            txtCommandText.Text = "";
            txtCaption.Text = "";
            txtCategory.Text = "";
            txtXMLName.Text = "";

            txtcolName.Text = "";
            txtcolCaption.Text = "";
            txtcolType.Text = "";
            txtcolWidth.Text = "";
            txtcolDefaultValue.Text = "";
            txtcolDataSource.Text = "";
            txtcolValueMember.Text = "";
            txtcolDisplayMember.Text = "";
            txtcolFooterName.Text = "";
            txtcolFooterType.Text = ""; ;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
