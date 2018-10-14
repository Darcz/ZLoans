namespace ZAccounting
{
    partial class ViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            this.ribbonMain = new System.Windows.Forms.Ribbon();
            this.rtMenu = new System.Windows.Forms.RibbonTab();
            this.rpMenuTools = new System.Windows.Forms.RibbonPanel();
            this.rbMenuOpen = new System.Windows.Forms.RibbonButton();
            this.rbMenuNew = new System.Windows.Forms.RibbonButton();
            this.rbMenuEdit = new System.Windows.Forms.RibbonButton();
            this.rbRefresh = new System.Windows.Forms.RibbonButton();
            this.rtMaintenance = new System.Windows.Forms.RibbonTab();
            this.MaintenanceMainPanel = new System.Windows.Forms.RibbonPanel();
            this.rtAccounting = new System.Windows.Forms.RibbonTab();
            this.AccountingMainPanel = new System.Windows.Forms.RibbonPanel();
            this.rtReport = new System.Windows.Forms.RibbonTab();
            this.ReportsMainPanel = new System.Windows.Forms.RibbonPanel();
            this.rtWindow = new System.Windows.Forms.RibbonTab();
            this.GridViewMain = new ZControls.ZSummaryGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonMain
            // 
            this.ribbonMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbonMain.Location = new System.Drawing.Point(27, 74);
            this.ribbonMain.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonMain.Minimized = false;
            this.ribbonMain.Name = "ribbonMain";
            // 
            // 
            // 
            this.ribbonMain.OrbDropDown.BorderRoundness = 8;
            this.ribbonMain.OrbDropDown.ContentButtonsMinWidth = 20;
            this.ribbonMain.OrbDropDown.ContentRecentItemsMinWidth = 20;
            this.ribbonMain.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbonMain.OrbDropDown.Name = "";
            this.ribbonMain.OrbDropDown.OptionItemsPadding = 0;
            this.ribbonMain.OrbDropDown.RecentItemsCaption = "Window";
            this.ribbonMain.OrbDropDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonMain.OrbDropDown.Size = new System.Drawing.Size(300, 500);
            this.ribbonMain.OrbDropDown.TabIndex = 0;
            this.ribbonMain.OrbImage = null;
            this.ribbonMain.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbonMain.OrbText = "View";
            // 
            // 
            // 
            this.ribbonMain.QuickAcessToolbar.Visible = false;
            this.ribbonMain.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbonMain.Size = new System.Drawing.Size(830, 185);
            this.ribbonMain.TabIndex = 0;
            this.ribbonMain.Tabs.Add(this.rtMenu);
            this.ribbonMain.Tabs.Add(this.rtMaintenance);
            this.ribbonMain.Tabs.Add(this.rtAccounting);
            this.ribbonMain.Tabs.Add(this.rtReport);
            this.ribbonMain.Tabs.Add(this.rtWindow);
            this.ribbonMain.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbonMain.Text = "RibbonMain";
            this.ribbonMain.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // rtMenu
            // 
            this.rtMenu.Panels.Add(this.rpMenuTools);
            this.rtMenu.Text = "Menu";
            // 
            // rpMenuTools
            // 
            this.rpMenuTools.Items.Add(this.rbMenuOpen);
            this.rpMenuTools.Items.Add(this.rbMenuNew);
            this.rpMenuTools.Items.Add(this.rbMenuEdit);
            this.rpMenuTools.Items.Add(this.rbRefresh);
            this.rpMenuTools.Text = "";
            // 
            // rbMenuOpen
            // 
            this.rbMenuOpen.Image = ((System.Drawing.Image)(resources.GetObject("rbMenuOpen.Image")));
            this.rbMenuOpen.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbMenuOpen.SmallImage")));
            this.rbMenuOpen.Text = "Open";
            this.rbMenuOpen.Click += new System.EventHandler(this.rbMenuOpen_Click);
            // 
            // rbMenuNew
            // 
            this.rbMenuNew.Image = ((System.Drawing.Image)(resources.GetObject("rbMenuNew.Image")));
            this.rbMenuNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbMenuNew.SmallImage")));
            this.rbMenuNew.Text = "New";
            this.rbMenuNew.Click += new System.EventHandler(this.rbMenuNew_Click);
            // 
            // rbMenuEdit
            // 
            this.rbMenuEdit.Image = ((System.Drawing.Image)(resources.GetObject("rbMenuEdit.Image")));
            this.rbMenuEdit.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbMenuEdit.SmallImage")));
            this.rbMenuEdit.Text = "Edit";
            this.rbMenuEdit.Click += new System.EventHandler(this.rbMenuEdit_Click);
            // 
            // rbRefresh
            // 
            this.rbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("rbRefresh.Image")));
            this.rbRefresh.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbRefresh.SmallImage")));
            this.rbRefresh.Text = "Refresh";
            this.rbRefresh.Click += new System.EventHandler(this.rbRefresh_Click);
            // 
            // rtMaintenance
            // 
            this.rtMaintenance.Panels.Add(this.MaintenanceMainPanel);
            this.rtMaintenance.Text = "Maintenance";
            // 
            // MaintenanceMainPanel
            // 
            this.MaintenanceMainPanel.Text = "";
            // 
            // rtAccounting
            // 
            this.rtAccounting.Panels.Add(this.AccountingMainPanel);
            this.rtAccounting.Text = "Accounting";
            // 
            // AccountingMainPanel
            // 
            this.AccountingMainPanel.Text = "";
            // 
            // rtReport
            // 
            this.rtReport.Panels.Add(this.ReportsMainPanel);
            this.rtReport.Text = "Reports";
            // 
            // ReportsMainPanel
            // 
            this.ReportsMainPanel.Text = "";
            // 
            // rtWindow
            // 
            this.rtWindow.Text = "Window";
            // 
            // GridViewMain
            // 
            this.GridViewMain.AllowUserToAddRows = false;
            this.GridViewMain.AllowUserToDeleteRows = false;
            this.GridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewMain.Location = new System.Drawing.Point(27, 259);
            this.GridViewMain.Margin = new System.Windows.Forms.Padding(4);
            this.GridViewMain.Name = "GridViewMain";
            this.GridViewMain.OpenForm = null;
            this.GridViewMain.ReadOnly = true;
            this.GridViewMain.ShowSummary = true;
            this.GridViewMain.Size = new System.Drawing.Size(830, 390);
            this.GridViewMain.SummaryColumns = null;
            this.GridViewMain.SummaryView = null;
            this.GridViewMain.TabIndex = 2;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 674);
            this.ControlBox = false;
            this.Controls.Add(this.GridViewMain);
            this.Controls.Add(this.ribbonMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Accounting";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RibbonTab rtMaintenance;
        private System.Windows.Forms.RibbonTab rtAccounting;
        private System.Windows.Forms.RibbonTab rtReport;
        private System.Windows.Forms.RibbonTab rtWindow;
        private System.Windows.Forms.RibbonPanel MaintenanceMainPanel;
        private System.Windows.Forms.RibbonPanel AccountingMainPanel;
        private System.Windows.Forms.RibbonPanel ReportsMainPanel;
        private ZControls.ZSummaryGridView GridViewMain;
        private System.Windows.Forms.RibbonTab rtMenu;
        private System.Windows.Forms.RibbonPanel rpMenuTools;
        private System.Windows.Forms.RibbonButton rbMenuOpen;
        private System.Windows.Forms.RibbonButton rbMenuEdit;
        private System.Windows.Forms.RibbonButton rbRefresh;
        public System.Windows.Forms.Ribbon ribbonMain;
        private System.Windows.Forms.RibbonButton rbMenuNew;
    }
}