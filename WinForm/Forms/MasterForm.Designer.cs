namespace ZAccounting
{
    partial class MasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonMain = new System.Windows.Forms.Ribbon();
            this.rtManu = new System.Windows.Forms.RibbonTab();
            this.rpMain = new System.Windows.Forms.RibbonPanel();
            this.rbNew = new System.Windows.Forms.RibbonButton();
            this.rbEdit = new System.Windows.Forms.RibbonButton();
            this.rbSave = new System.Windows.Forms.RibbonButton();
            this.rbCancel = new System.Windows.Forms.RibbonButton();
            this.rpOthers = new System.Windows.Forms.RibbonPanel();
            this.rbClose = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Text = "ribbonTab1";
            // 
            // ribbonMain
            // 
            this.ribbonMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbonMain.Location = new System.Drawing.Point(20, 60);
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
            this.ribbonMain.OrbDropDown.RecentItemsCaption = "Window";
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
            this.ribbonMain.Size = new System.Drawing.Size(628, 150);
            this.ribbonMain.TabIndex = 1;
            this.ribbonMain.Tabs.Add(this.rtManu);
            this.ribbonMain.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbonMain.Text = "RibbonMain";
            this.ribbonMain.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // rtManu
            // 
            this.rtManu.Panels.Add(this.rpMain);
            this.rtManu.Panels.Add(this.rpOthers);
            this.rtManu.Text = "Menu";
            // 
            // rpMain
            // 
            this.rpMain.Items.Add(this.rbNew);
            this.rpMain.Items.Add(this.rbEdit);
            this.rpMain.Items.Add(this.rbSave);
            this.rpMain.Items.Add(this.rbCancel);
            this.rpMain.Text = "";
            // 
            // rbNew
            // 
            this.rbNew.Image = ((System.Drawing.Image)(resources.GetObject("rbNew.Image")));
            this.rbNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbNew.SmallImage")));
            this.rbNew.Text = "New";
            this.rbNew.Click += new System.EventHandler(this.rbNew_Click);
            // 
            // rbEdit
            // 
            this.rbEdit.Image = ((System.Drawing.Image)(resources.GetObject("rbEdit.Image")));
            this.rbEdit.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbEdit.SmallImage")));
            this.rbEdit.Text = "Edit";
            this.rbEdit.Click += new System.EventHandler(this.rbEdit_Click);
            // 
            // rbSave
            // 
            this.rbSave.Image = ((System.Drawing.Image)(resources.GetObject("rbSave.Image")));
            this.rbSave.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbSave.SmallImage")));
            this.rbSave.Text = "Save";
            this.rbSave.Click += new System.EventHandler(this.rbSave_Click);
            // 
            // rbCancel
            // 
            this.rbCancel.Image = ((System.Drawing.Image)(resources.GetObject("rbCancel.Image")));
            this.rbCancel.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbCancel.SmallImage")));
            this.rbCancel.Text = "Cancel";
            this.rbCancel.Click += new System.EventHandler(this.rbCancel_Click);
            // 
            // rpOthers
            // 
            this.rpOthers.Items.Add(this.rbClose);
            this.rpOthers.Text = "";
            // 
            // rbClose
            // 
            this.rbClose.Image = ((System.Drawing.Image)(resources.GetObject("rbClose.Image")));
            this.rbClose.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbClose.SmallImage")));
            this.rbClose.Text = "Close";
            this.rbClose.Click += new System.EventHandler(this.rbClose_Click);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 617);
            this.ControlBox = false;
            this.Controls.Add(this.ribbonMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MasterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MasterForm";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonTab rtManu;
        private System.Windows.Forms.RibbonPanel rpMain;
        private System.Windows.Forms.RibbonButton rbNew;
        private System.Windows.Forms.RibbonButton rbEdit;
        private System.Windows.Forms.RibbonButton rbSave;
        private System.Windows.Forms.RibbonButton rbCancel;
        private System.Windows.Forms.RibbonPanel rpOthers;
        private System.Windows.Forms.RibbonButton rbClose;
        public System.Windows.Forms.Ribbon ribbonMain;

    }
}