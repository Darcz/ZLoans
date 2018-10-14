using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace ZControls
{
    public static class SummarySupport
    {
        private class ZColumnListIndex
        {
            public string ColumnName { get; set; }
            public int ColumnIndex { get; set; }
            public bool ColumnVisible { get; set; }
        }

        public static void AddSummary(ZSummaryGridView DGV_)
        {
            //Create new panel
            var CurrIndex = DGV_.Parent.Controls.IndexOf(DGV_);
            List<ZColumnListIndex> ColumnListIndex_ = new List<ZColumnListIndex>();

            foreach (DataGridViewColumn c in DGV_.Columns)
            {
                ColumnListIndex_.Add(new ZColumnListIndex { ColumnName = c.DataPropertyName, ColumnIndex = c.Index, ColumnVisible = c.Visible });
            }


            Panel Panel_ = new Panel();
            Panel_.Dock = DGV_.Dock;
            Panel_.Top = DGV_.Top;
            Panel_.Left = DGV_.Left;
            Panel_.Height = DGV_.Height;
            Panel_.Width = DGV_.Width;
            DGV_.Parent.Controls.Add(Panel_);
            Panel_.Parent.Controls.SetChildIndex(Panel_, CurrIndex);

            DGV_.Parent = Panel_;
            DGV_.Dock = DockStyle.Fill;

            DataGridView SummaryView = null;
            if (DGV_.SummaryView == null)
                SummaryView = new DataGridView();
            else
                SummaryView = DGV_.SummaryView;

            SummaryView.ColumnHeadersVisible = false;
            SummaryView.Dock = DockStyle.Bottom;
            SummaryView.AutoGenerateColumns = false;
            SummaryView.AllowUserToAddRows = false;
            SummaryView.AllowUserToDeleteRows = false;
            SummaryView.AllowUserToOrderColumns = false;
            SummaryView.AllowUserToResizeColumns = false;
            SummaryView.ReadOnly = true;
            SummaryView.ScrollBars = ScrollBars.Vertical;        
            SummaryView.Height = 21;
            SummaryView.MouseClick += new MouseEventHandler(SummaryGridView_MouseClick);
            SummaryView.Visible = DGV_.SummaryColumns != null;
            DGV_.SummaryView = SummaryView;
            RecreateSummaryColumns(DGV_);
            Panel_.Controls.Add(SummaryView);

            //RearrangeColumns
            foreach (ZColumnListIndex cli_ in ColumnListIndex_.OrderBy(x => x.ColumnIndex).ToList())
            {
                DGV_.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == cli_.ColumnName).FirstOrDefault().DisplayIndex = cli_.ColumnIndex;
                DGV_.SummaryView.Columns.Cast<DataGridViewColumn>().Where(c => c.DataPropertyName == cli_.ColumnName).FirstOrDefault().DisplayIndex = cli_.ColumnIndex;              

            }
        }

        static void RecreateSummaryColumns(ZSummaryGridView DGV_)
        {
            DataGridView SummaryView = DGV_.SummaryView;
            DataTable SummaryDT = null;

            SummaryView.DataSource = null;
           
            SummaryDT = new DataTable();

            SummaryView.Columns.Clear();
            SummaryDT.Rows.Clear();
            SummaryDT.Columns.Clear();
            foreach (DataGridViewColumn c in DGV_.Columns)
            {

                DataGridViewColumn NCol = new DataGridViewTextBoxColumn();
                NCol.HeaderText = c.HeaderText;
                NCol.DataPropertyName = c.DataPropertyName;
                NCol.Visible = c.Visible;
                NCol.Width = c.Width;
                NCol.FillWeight = c.FillWeight;
               // NCol.CellTemplate = c.CellTemplate;
                SummaryView.Columns.Add(NCol);
                SummaryDT.Columns.Add(c.DataPropertyName, typeof(System.String));
            }

            SummaryDT.Rows.Add();
            SummaryView.DataSource = SummaryDT;
            SummaryView.Visible = true;
            DGV_.CalculateSummary();
            
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
                    cm_.MenuItems.Add("Sum", new EventHandler(ContextMenuSum_Click));
                    //cm.MenuItems.Add("Item 1", new EventHandler(Removepicture_Click));   
                    cm_.MenuItems.Add("Avg");
                    cm_.MenuItems.Add("Count");
                    cm_.Show((DataGridView)sender, new Point(e.X, e.Y));                    
                }
            }
        }

        static void ContextMenuSum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sum is clicked");
        }
    }
}
