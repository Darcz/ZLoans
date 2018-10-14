using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZAccounting
{
    public partial class ViewForm : MetroFramework.Forms.MetroForm
    {
        ViewDAL DAL_ = new ViewDAL();
        string CurrViewName = null;

        public ViewForm()
        {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            ReloadViews();        
            this.ResumeLayout();
        }

        private void ReloadViews()
        {
            foreach (ZView V_ in ZViewList.ViewList)
            {
                foreach (RibbonTab RT_ in ribbonMain.Tabs)
                {
                    if (RT_.Text == V_.Category)
                    {
                        RibbonButton RB_ = new RibbonButton();
                        RB_.Text = V_.Caption;
                        RB_.Tag =V_.Name;
                        RB_.Click += new EventHandler(RibbonButton_Click);
                        RT_.Panels[0].Items.Add(RB_);
                        break;
                    }
                }
            }
            ribbonMain.ActiveTab = ribbonMain.Tabs[0];            
        }

        private void RibbonButton_Click(object sender, EventArgs e)
        {
            //GET CORRESPONDING VIEW
            CurrViewName = ((RibbonButton)sender).Tag.ToString();
            ZView V_ = ZViewList.ViewList.FirstOrDefault(x => x.Name == CurrViewName);


            //CREATE COLUMNS
            GridViewMain.AutoGenerateColumns = false;
            GridViewMain.Columns.Clear();
            GridViewMain.VirtualMode = true;
            foreach (ZColumn col_ in V_.Columns.Where(x => x.Hidden != true))
            {
                if (col_.ColumnType.ToLower() == "bool" || col_.ColumnType.ToLower() == "boolean")
                {
                    GridViewMain.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = col_.Caption, FillWeight = col_.Width, Visible = !col_.Visible, DataPropertyName = col_.FieldName });
                }
                else
                {
                    GridViewMain.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = col_.Caption, FillWeight = col_.Width, Visible = !col_.Visible, DataPropertyName = col_.FieldName });
                }
            }

            GridViewMain.OpenForm = V_.Name;

            ReloadData();

            //ToDo Custom Summary Column

            int i_ = 0;

            ZControls.SummaryColumn[] _SummaryColumn = new ZControls.SummaryColumn[i_];
            foreach (ZColumn col_ in V_.Columns.Where(x => x.FooterType != null))
            {
                i_ += 1;
                Array.Resize(ref _SummaryColumn, i_);
                ZControls.SummaryColumn.FooterTypes FType_ = (ZControls.SummaryColumn.FooterTypes)System.Enum.Parse(typeof(ZControls.SummaryColumn.FooterTypes), col_.FooterType);
                _SummaryColumn[i_ - 1] = new ZControls.SummaryColumn { FieldName = col_.FooterFieldName, FooterType = FType_, OutputColumn = col_.FieldName };                
            }
           // ZControls.SummaryColumn[] _SummaryColumn = new ZControls.SummaryColumn[] { new ZControls.SummaryColumn { FieldName = "Name", FooterType = ZControls.SummaryColumn.FooterTypes.Count, OutputColumn = "Name"} };
            GridViewMain.SummaryColumns = _SummaryColumn;
            ZControls.SummarySupport.AddSummary(GridViewMain);


            //Rehide columns
            foreach (DataGridViewColumn col_ in GridViewMain.Columns)
            {
               col_.Visible = !V_.Columns.FirstOrDefault(x => x.FieldName == col_.DataPropertyName).Hidden; 
            }
            GridViewMain.VirtualMode = false;

            ribbonMain.ActiveTab = rtMenu;
            this.Text = V_.Caption;
            WindowList.WindowInstances.FirstOrDefault(x => x.FormName == "ViewForm").Caption = "Home";
            RefreshOrb();
        }

        public void ReloadData()
        {
            //CREATE SOURCE
            ZView V_ = ZViewList.ViewList.FirstOrDefault(x => x.Name == CurrViewName);
            BindingSource BS_ = new BindingSource();
            BS_.DataSource = DAL_.LoadView(V_.CommandText);
            GridViewMain.DataSource = BS_;
            
        }

        private void rbMenuOpen_Click(object sender, EventArgs e)
        {
            string FormName_ = GridViewMain.OpenForm;
            if (WindowList.WindowInstances.Any(x=>x.FormName == FormName_))
            {
                MasterForm OpenForm_ = WindowList.WindowInstances.FirstOrDefault(x => x.FormName == FormName_).WindowForm as MasterForm;
                if (OpenForm_.FormMode == MasterForm.FormModes.View)
                { 
                    int Id_ = Convert.ToInt16(GridViewMain.Rows[GridViewMain.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    if (Id_ != -1)
                    {
                        OpenForm_._MasterId = Id_;
                        OpenForm_.TForm_Load();
                    }
                }
                OpenForm_.Show();
                this.Hide();
            } else if (FormName_ != null)
            {
                var NewFrm = Activator.CreateInstance(Type.GetType("ZAccounting." + FormName_ + "Form")) as MasterForm;
                DataRowView currentView = (DataRowView)((BindingSource)GridViewMain.DataSource).Current;
                int Id_ = (int)currentView.Row["Id"];

                //int Id_ = Convert.ToInt16(GridViewMain.Rows[GridViewMain.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                if (Id_ != -1)
                {
                    Form MainForm_ = this.MdiParent as Form;
                    MainForm_.SuspendLayout();
                    NewFrm.MdiParent = MainForm_;
                    NewFrm.Dock = DockStyle.Fill;
                    NewFrm.FormMode = MasterForm.FormModes.View;
                    NewFrm._MasterId = Id_;
                    NewFrm.TForm_Load();
                    NewFrm.Show();
                    WindowList.WindowInstances.Add(new WindowList.WindowInstance { Caption = NewFrm.Text, FormName = FormName_, WindowForm = NewFrm });
                    RefreshAllOrbs();
                    Hide();
                    MainForm_.ResumeLayout();
                }
            }
        }

        private void rbRefresh_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void rbMenuEdit_Click(object sender, EventArgs e)
        {
            string FormName_ = GridViewMain.OpenForm;
                        if (WindowList.WindowInstances.Any(x=>x.FormName == FormName_))
            {
                MasterForm OpenForm_ = WindowList.WindowInstances.FirstOrDefault(x => x.FormName == FormName_).WindowForm as MasterForm;
                if (OpenForm_.FormMode == MasterForm.FormModes.View)
                { 
                    int Id_ = Convert.ToInt16(GridViewMain.Rows[GridViewMain.CurrentCell.RowIndex].Cells["Id"].Value.ToString());
                    if (Id_ != -1)
                    {
                        OpenForm_._MasterId = Id_;
                        OpenForm_.TForm_Load();
                    }
                }
                OpenForm_.Show();
                this.Hide();
            } else if (FormName_ != null)
            {
                var NewFrm = Activator.CreateInstance(Type.GetType("ZAccounting." + FormName_ + "Form")) as MasterForm;
                int Id_ = Convert.ToInt16(GridViewMain.Rows[GridViewMain.CurrentCell.RowIndex].Cells["Id"].Value.ToString());
                if (Id_ != -1)
                {
                    Form MainForm_ = this.MdiParent as Form;
                    MainForm_.SuspendLayout();
                    NewFrm.MdiParent = MainForm_;
                    NewFrm.Dock = DockStyle.Fill;
                    NewFrm.FormMode = MasterForm.FormModes.Edit;
                    NewFrm._MasterId = Id_;
                    NewFrm.TForm_Load();
                    NewFrm.Show();
                    WindowList.WindowInstances.Add(new WindowList.WindowInstance { Caption = NewFrm.Text, FormName = FormName_, WindowForm = NewFrm });
                    RefreshAllOrbs();
                    Hide();
                    MainForm_.ResumeLayout();
                }
            }
        }

        private void RefreshAllOrbs()
        {
            foreach (WindowList.WindowInstance wi_ in WindowList.WindowInstances)
            {
                if (wi_.FormName == "ViewForm")
                {
                    ViewForm WindowForm_ = wi_.WindowForm as ViewForm;
                    WindowForm_.RefreshOrb();
                    
                }
                else if (wi_.WindowForm is MasterForm)
                {
                    MasterForm WindowForm_ = wi_.WindowForm as MasterForm;
                    WindowForm_.RefreshOrb();
                }
            }
        }

        public void RefreshOrb()
        {
            ribbonMain.OrbDropDown.RecentItems.Clear();
            foreach (WindowList.WindowInstance wi_ in WindowList.WindowInstances)
            {  
                RibbonButton WindowRecentButton_ = new RibbonButton();
                WindowRecentButton_.Text = wi_.Caption;
                WindowRecentButton_.Tag = wi_.FormName;
                WindowRecentButton_.Click += new EventHandler(WindowRecentButton_Click);
                ribbonMain.OrbDropDown.RecentItems.Add(WindowRecentButton_);
            }
        }

        private void WindowRecentButton_Click(object sender, EventArgs e)
        {
            Form ShowForm_ = WindowList.WindowInstances.FirstOrDefault(x => x.FormName == ((RibbonButton)sender).Tag.ToString()).WindowForm;
            if (ShowForm_ != this)
            {
                ShowForm_.Show();
                this.Hide();
            }
        }

        private void rbMenuNew_Click(object sender, EventArgs e)
        {
            string FormName_ = GridViewMain.OpenForm;
            if (WindowList.WindowInstances.Any(x => x.FormName == FormName_))
            {
                MasterForm OpenForm_ = WindowList.WindowInstances.FirstOrDefault(x => x.FormName == FormName_).WindowForm as MasterForm;
                if (OpenForm_.FormMode == MasterForm.FormModes.View)
                {
                    OpenForm_._MasterId = -1;
                    OpenForm_.TForm_Load();

                }
                OpenForm_.Show();
                this.Hide();
            }
            else if (FormName_ != null)
            {
                var NewFrm = Activator.CreateInstance(Type.GetType("ZAccounting." + FormName_ + "Form")) as MasterForm;
                Form MainForm_ = this.MdiParent as Form;
                MainForm_.SuspendLayout();
                NewFrm.MdiParent = MainForm_;
                NewFrm.Dock = DockStyle.Fill;
                NewFrm.FormMode = MasterForm.FormModes.New;
                NewFrm.TGetRecord();
                NewFrm.AddDefaultRecord();
                NewFrm.TLoadRecord();
                NewFrm.TUpdateControls();
                //NewFrm.TForm_Load();
                NewFrm.Show();
                WindowList.WindowInstances.Add(new WindowList.WindowInstance { Caption = NewFrm.Text, FormName = FormName_, WindowForm = NewFrm });
                RefreshAllOrbs();
                Hide();
                MainForm_.ResumeLayout();

            }
        }
    }
}
