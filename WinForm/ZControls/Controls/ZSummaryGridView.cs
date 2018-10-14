using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;
using System.Drawing;

namespace ZControls
{
    public class ZSummaryGridView : DataGridView
    {
        public DataGridView SummaryView { get; set; }
        public bool ShowSummary { get; set; }
        public SummaryColumn[] SummaryColumns { get; set; }
        public string OpenForm { get; set; }

        public ZSummaryGridView()
        {
            ShowSummary = true;
            RowsAdded += new DataGridViewRowsAddedEventHandler(SummaryGridView_RowsAdded);
            RowsRemoved += new DataGridViewRowsRemovedEventHandler(SummaryGridView_RowsRemoved);
            ColumnWidthChanged += new DataGridViewColumnEventHandler(SummaryGridView_ColumnWidthChanged);
            CellValueChanged += new DataGridViewCellEventHandler(SummaryGridView_CellValueChanged);
            ColumnStateChanged += new DataGridViewColumnStateChangedEventHandler(SummaryGridView_ColumnStateChanged);
            MouseClick += new MouseEventHandler(SummaryGridView_MouseClick);
        }

        static void SummaryGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int CurrentRow = ((DataGridView)sender).HitTest(e.X, e.Y).ColumnIndex;

                if (CurrentRow >= 0)
                {
                    //cm_.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", CurrentRow.ToString())));
                    ContextMenu cm_ = new ContextMenu();
                    MenuItem ColumnList_ = new MenuItem("Columns");
                    foreach (DataGridViewColumn c in ((DataGridView)sender).Columns)
                    {
                        ZColumnMenuItem Col_ = new ZColumnMenuItem();
                        Col_.Text = c.HeaderText;
                        Col_.SummaryGridView = sender as DataGridView;
                        Col_.ColumnName = c.DataPropertyName;
                        Col_.Checked = c.Visible;
                        Col_.Click += new EventHandler(ContextMenuColumnList_Click);                      
                        ColumnList_.MenuItems.Add(Col_);
                    }
                    cm_.MenuItems.Add(ColumnList_);
                   
                    cm_.Show((DataGridView)sender, new Point(e.X, e.Y));
                }
            }
        }

        private class ZColumnMenuItem : MenuItem
        {
            public DataGridView SummaryGridView { get; set; }
            public string ColumnName { get; set; }
        }

        private class ZSearchMenuItem : MenuItem
        { 
            
        }

        static void ContextMenuColumnList_Click(object sender, EventArgs e)
        {
            var Checked_ = ((ZColumnMenuItem)sender).Checked;
            var SummaryGridView_ = ((ZColumnMenuItem)sender).SummaryGridView;
            var ColumnName = ((ZColumnMenuItem)sender).ColumnName;
            SummaryGridView_.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == ColumnName).FirstOrDefault().Visible = !Checked_;
        }

        private void SummaryGridView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (SummaryView == null || SummaryView.Columns.Count == 0) return;
            var SumCol = SummaryView.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == e.Column.DataPropertyName).FirstOrDefault();

            if (SumCol != null)
            {
                SumCol.FillWeight = e.Column.FillWeight;
                SumCol.Width = e.Column.Width;
            }
        }


        private void SummaryGridView_ColumnStateChanged(object sender, DataGridViewColumnStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Visible && SummaryView != null)
            { 

                var SumCol = SummaryView.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == e.Column.DataPropertyName).Single();
                SumCol.Visible = e.Column.Visible;
            }

        }


        private void SummaryGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculateSummary();
        }


        private void SummaryGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateSummary();
        }

        private void SummaryGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateSummary();
        }

        public void CalculateSummary()
        {
            if (SummaryView == null || SummaryColumns == null || SummaryView.DataSource == null) return;

            foreach (SummaryColumn sc_ in SummaryColumns)
            {
                float FooterValue = 0;
                //  var SumCol = summaryView.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == e.Column.DataPropertyName).Single();
                
                var col_ = this.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == sc_.FieldName).FirstOrDefault();
                if (col_ != null)
                {
                    foreach (DataGridViewRow Row_ in this.Rows)
                    {
                        if (sc_.FooterType == SummaryColumn.FooterTypes.Count)
                        {
                            FooterValue += 1;
                        }
                        else
                        {
                            float t_;
                            float.TryParse(Row_.Cells[col_.Index].Value.ToString(), out t_);
                            if (Row_.Cells[col_.Index].Value != null)
                            {
                                FooterValue += t_;
                            }
                        }

                    }
                    var SumCol_ = SummaryView.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == sc_.FieldName).FirstOrDefault();

                    DataTable SumDT_ = SummaryView.DataSource as DataTable;
                    if (SumDT_ != null)
                    {
                        if (SumDT_.Columns.Contains(sc_.FieldName))
                        {
                            SumDT_.Rows[0][sc_.FieldName] = sc_.FooterType.ToString() + ": " + FooterValue.ToString(sc_.FooterFormat);
                        }
                    }
                }
            }

        }
    }
}
