using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ZAccounting
{
    public partial class MasterForm : MetroFramework.Forms.MetroForm
    {
        public int _MasterId = -1;
        public DataSet SourceDataSet = null;
        public List<ZTable> SourceTables = null;

        public MasterForm()
        {
            InitializeComponent();
            FormMode = FormModes.New;
        }
        

        public bool IsView()
        {
            return FormMode == FormModes.View;
        }

        public bool IsNew()
        {
            return FormMode == FormModes.New;
        }
        public bool IsEdit()
        {
            return FormMode == FormModes.Edit;
        }

        public FormModes FormMode = FormModes.View;

        public enum FormModes { 
            View,
            Edit,
            New
        }

        protected virtual void TLoad()
        {
            GetRecord();
            TLoadRecord();
            TUpdateControls();
        }

        public void TForm_Load()
        {
            TLoad();
        }

        private static IEnumerable<Control> ControlsList(Control c)
        {
            var _ControlStack = new Stack<Control>();
            _ControlStack.Push(c);
            while (_ControlStack.Any())
            {
                var _Next = _ControlStack.Pop();
                foreach (Control _ChildControl in _Next.Controls)
                {
                    _ControlStack.Push(_ChildControl);
                }
                yield return _Next;
            }

        }

        protected virtual void GetRecord()
        { 
            //Placeholder
        }

        public void TGetRecord()
        {
            GetRecord();
        }

        public void TLoadRecord()
        {               
            
            PropertyInfo propTableName = null;
            PropertyInfo propFieldName = null;
            string TableName_ = null;
            string FieldName_ = null;
            List<ZColumn> ColumnList_ = null;
            ZColumn CurrCol_ = null;
            DataSourcesBLL _DataSourcesBLL = new DataSourcesBLL();

            foreach (Control c_ in ControlsList(this))
            {
                propTableName = c_.GetType().GetProperty("TableName");
                propFieldName = c_.GetType().GetProperty("FieldName");

                if (propTableName != null)
                {

                    TableName_ = propTableName.GetValue(c_).ToString();
                    if (SourceDataSet.Tables.Contains(TableName_))
                    {
                        if (c_ is DataGridView)
                        {

                        }
                        else
                        {
                            FieldName_ = propFieldName.GetValue(c_).ToString();

                            ColumnList_ = SourceTables.FirstOrDefault(x => x.TableName == TableName_).ColumnList;
                            CurrCol_ = ColumnList_.FirstOrDefault(x => x.FieldName == FieldName_);

                            DataRow CurrRec_ = SourceDataSet.Tables[TableName_].Rows[0];//GetValue

                            PropertyInfo propText = c_.GetType().GetProperty("Text");
                            PropertyInfo propEnabled = c_.GetType().GetProperty("Enabled");
                            PropertyInfo propSelectedValue = c_.GetType().GetProperty("SelectedValue");
                            PropertyInfo propChecked = c_.GetType().GetProperty("Checked");
                            PropertyInfo propDataSource = c_.GetType().GetProperty("DataSource");
                            PropertyInfo propDisplayMember = c_.GetType().GetProperty("DisplayMember");
                            PropertyInfo propValueMember = c_.GetType().GetProperty("ValueMember");

                            if (c_ is TextBox)
                            {
                                if (CurrRec_ != null)
                                {
                                    propText.SetValue(c_, CurrRec_[FieldName_].ToString());
                                }
                                else
                                {
                                    propText.SetValue(c_, "");
                                }
                            }
                            else if (c_ is CheckBox)
                            {
                                if (CurrRec_ != null)
                                {
                                    propChecked.SetValue(c_, CurrRec_[FieldName_]);
                                }
                                else
                                {
                                    propChecked.SetValue(c_, Convert.ToBoolean(CurrCol_.DefaultValue));
                                }
                            }
                            else if (propSelectedValue != null && propSelectedValue.CanWrite)
                            {
                                DataTable _DataSource = _DataSourcesBLL.GetRecord(CurrCol_.DataSource);
                                propDataSource.SetValue(c_, _DataSource);
                                propDisplayMember.SetValue(c_, CurrCol_.DisplayMember.ToString());
                                propValueMember.SetValue(c_, CurrCol_.ValueMember.ToString());

                                if (CurrRec_ != null)
                                {
                                    propSelectedValue.SetValue(c_, CurrRec_[FieldName_]);
                                }
                                else if (CurrCol_.DefaultValue != "" && CurrCol_.DefaultValue != null)
                                {
                                    propSelectedValue.SetValue(c_, CurrCol_.DefaultValue);
                                }
                            }

                        }
                    }
                }
            }
        }

        private void comboBox_DisableKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void TUpdateControls()
        {
            string _TableName = null;
            string _FieldName = null;
            List<ZColumn> _ColumnList = null;
            PropertyInfo propTableName = null;
            PropertyInfo propFieldName = null;

            rbNew.Visible = IsView();
            rbEdit.Visible = IsView();
            rbSave.Visible = !IsView();
            rbCancel.Visible = !IsView();
            //Loop thought all controls
            if (SourceTables == null) return;
            if (SourceTables.Count == 0)
            {
                return;
            }
            foreach (Control c in ControlsList(this))
            {
                propTableName = c.GetType().GetProperty("TableName");
                propFieldName = c.GetType().GetProperty("FieldName");

                if (propTableName != null)
                {
                    if (c is DataGridView)
                    {

                        //(DataGridView)c.DataSource = _SourceDataset.Tables[_TableName];          
                        DataGridView gv = c as DataGridView;
                        //  gv.AllowUserToAddRows = !_FormMode.IsView;
                        gv.AllowUserToDeleteRows = !IsView();
                        gv.ReadOnly = IsView();
                        foreach (DataGridViewColumn gvc in gv.Columns)
                        {
                            if (gvc is DataGridViewComboBoxColumn)
                            {

                                PropertyInfo propDisplayStyle = gvc.GetType().GetProperty("DisplayStyle");

                                //Set DropdownStyle
                                if (propDisplayStyle != null && IsView())
                                {
                                    propDisplayStyle.SetValue(gvc, DataGridViewComboBoxDisplayStyle.Nothing);
                                }
                                else if (propDisplayStyle != null)
                                {
                                    propDisplayStyle.SetValue(gvc, DataGridViewComboBoxDisplayStyle.DropDownButton);
                                }
                            }

                        }

                    }
                    else
                    {
                        _TableName = propTableName.GetValue(c).ToString();
                        _FieldName = propFieldName.GetValue(c).ToString();

                        _ColumnList = SourceTables.FirstOrDefault(x => x.TableName == _TableName).ColumnList;
                        ZColumn _CurrCol = _ColumnList.FirstOrDefault(x => x.FieldName == _FieldName);

                        PropertyInfo propReadOnly = c.GetType().GetProperty("ReadOnly");
                        PropertyInfo propBackColor = c.GetType().GetProperty("BackColor");
                        PropertyInfo propBorderColor = c.GetType().GetProperty("BorderColor");
                        PropertyInfo propEnabled = c.GetType().GetProperty("Enabled");
                        PropertyInfo propSelectedValue = c.GetType().GetProperty("SelectedValue");
                        PropertyInfo propDropDownStyle = c.GetType().GetProperty("DropDownStyle");
                        PropertyInfo propAutoCheck = c.GetType().GetProperty("AutoCheck");

                        //Set ReadOnly
                        if (propReadOnly != null && propReadOnly.CanWrite)
                        {
                            propReadOnly.SetValue(c, IsView());
                        }
                        else if (c is ComboBox)
                        {
                            c.KeyPress += new KeyPressEventHandler(comboBox_DisableKeyPress);
                            //propEnabled.SetValue(c, !_FormMode.IsView);
                        }

                        //Set BGColor
                        if (_CurrCol.Required && !IsView())
                        {
                            propBackColor.SetValue(c, Color.Orange);
                        }
                        else
                        {
                            propBackColor.SetValue(c, Color.White);
                        }

                        //Set BorderColor
                        if (propBorderColor != null && _CurrCol.Required && !IsView())
                        {
                            propBorderColor.SetValue(c, Color.Orange);
                        }
                        else if (propBorderColor != null)
                        {
                            propBorderColor.SetValue(c, Color.White);
                        }

                        //Set DropdownStyle
                        if (propDropDownStyle != null && IsView())
                        {
                            propDropDownStyle.SetValue(c, ComboBoxStyle.Simple);
                        }
                        else if (propDropDownStyle != null)
                        {
                            propDropDownStyle.SetValue(c, ComboBoxStyle.DropDownList);
                        }

                        //Set Enabled ( for checkbox )
                        if (c is CheckBox)
                        {
                            propAutoCheck.SetValue(c, !IsView());
                        }
                    }
                }
            }
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
                TUpdateControls();
        }

        private void rbEdit_Click(object sender, EventArgs e)
        {
            FormMode = FormModes.Edit;
            TLoadRecord();
            TUpdateControls();
        }

        private void rbSave_Click(object sender, EventArgs e)
        {
            SaveRecord();
        }

        protected virtual void SaveRecord()
        {
            UpdateDataset();
        }
        private void rbCancel_Click(object sender, EventArgs e)
        {
            FormMode = FormModes.View;
            TLoadRecord();
            TUpdateControls();
        }

        private void UpdateDataset()
        {
            string _FieldName = null;
            string _TableName = null;
            List<ZColumn> _ColumnList = null;
            PropertyInfo propTableName = null;
            PropertyInfo propFieldName = null;

            foreach (Control c in ControlsList(this))
            {
                propTableName = c.GetType().GetProperty("TableName");
                propFieldName = c.GetType().GetProperty("FieldName");

                if (propTableName != null)
                {
                    _TableName = propTableName.GetValue(c).ToString();

                    if (propFieldName != null)
                        _FieldName = propFieldName.GetValue(c).ToString();

                    _ColumnList = SourceTables.FirstOrDefault(x => x.TableName == _TableName).ColumnList;
                    ZColumn _CurrCol = _ColumnList.FirstOrDefault(x => x.FieldName == _FieldName);
                    DataTable _Rec = SourceDataSet.Tables[_TableName]; //GetValue

                    PropertyInfo propText = c.GetType().GetProperty("Text");
                    PropertyInfo propSelectedValue = c.GetType().GetProperty("SelectedValue");
                    PropertyInfo propChecked = c.GetType().GetProperty("Checked");
                    if (_Rec.Columns.Contains(_FieldName))
                    {
                        if (c is ComboBox)
                        {
                            if ((_ColumnList.FirstOrDefault(x => x.FieldName == _FieldName).Required) && (propSelectedValue.GetValue(c) == null))
                            {
                                throw new Exception("Please fill up all required fields");
                            }
                            _Rec.Rows[0][_FieldName] = propSelectedValue.GetValue(c) ?? DBNull.Value;
                        }
                        else if (c is CheckBox)
                        {
                            _Rec.Rows[0][_FieldName] = propChecked.GetValue(c);
                        }
                        else
                        {
                            if ((_ColumnList.FirstOrDefault(x => x.FieldName == _FieldName).Required) && (propText.GetValue(c).ToString().Trim() == "" || propText.GetValue(c) == null))
                            {
                                throw new Exception("Please fill up all required fields");
                            }
                            _Rec.Rows[0][_FieldName] = propText.GetValue(c).ToString().Trim();
                        }
                    }
                }
            }
        }

        private void rbClose_Click(object sender, EventArgs e)
        {
            MainForm MdiParent_ = this.MdiParent as MainForm;
            foreach (Form F_ in MdiParent.MdiChildren)
            {
                if (F_ is ViewForm)
                {
                    F_.Show();                    
                    Dispose();
                }
            }
        }

        public void AddDefaultRecord()
        {
            DataTable _MasterDT = SourceDataSet.Tables[0];
            _MasterDT.Rows.Add("-1");
            List<ZColumn> _ColumnList = SourceTables.FirstOrDefault(x => x.TableName == SourceDataSet.Tables[0].TableName).ColumnList;
            foreach (ZColumn c in _ColumnList)
            {
                if (c.DefaultValue != null)
                {
                    _MasterDT.Rows[0][c.FieldName] = c.DefaultValue;
                }
            }
        }
        private void rbNew_Click(object sender, EventArgs e)
        {
            FormMode = FormModes.New;
            _MasterId = -1;
            GetRecord();
            AddDefaultRecord();
            TLoadRecord();
            TUpdateControls();
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

    }
}
