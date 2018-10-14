namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.GridViewList = new System.Windows.Forms.DataGridView();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCommandText = new System.Windows.Forms.TextBox();
            this.txtXMLName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.txtActive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtcolDisplayMember = new System.Windows.Forms.TextBox();
            this.txtcolValueMember = new System.Windows.Forms.TextBox();
            this.txtcolDataSource = new System.Windows.Forms.TextBox();
            this.txtcolFooterType = new System.Windows.Forms.ComboBox();
            this.txtcolFooterName = new System.Windows.Forms.TextBox();
            this.txtcolDefaultValue = new System.Windows.Forms.TextBox();
            this.txtcolWidth = new System.Windows.Forms.TextBox();
            this.txtcolCaption = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcolType = new System.Windows.Forms.ComboBox();
            this.txtcolName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GridViewColumns = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.cbVisible = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewList
            // 
            this.GridViewList.AllowUserToAddRows = false;
            this.GridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewList.Location = new System.Drawing.Point(16, 52);
            this.GridViewList.Margin = new System.Windows.Forms.Padding(4);
            this.GridViewList.Name = "GridViewList";
            this.GridViewList.Size = new System.Drawing.Size(1119, 270);
            this.GridViewList.TabIndex = 0;
            this.GridViewList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewList_CellClick);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(75, 20);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(192, 22);
            this.txtServer.TabIndex = 1;
            this.txtServer.Text = ".\\SQL2014";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(368, 20);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(192, 22);
            this.txtDatabase.TabIndex = 4;
            this.txtDatabase.Text = "Loans";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 329);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 329);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 28);
            this.button3.TabIndex = 14;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 380);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1135, 415);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtCommandText);
            this.tabPage1.Controls.Add(this.txtXMLName);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtCategory);
            this.tabPage1.Controls.Add(this.txtCaption);
            this.tabPage1.Controls.Add(this.txtActive);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1127, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "XML";
            // 
            // txtCommandText
            // 
            this.txtCommandText.Location = new System.Drawing.Point(457, 96);
            this.txtCommandText.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommandText.Multiline = true;
            this.txtCommandText.Name = "txtCommandText";
            this.txtCommandText.Size = new System.Drawing.Size(616, 185);
            this.txtCommandText.TabIndex = 41;
            // 
            // txtXMLName
            // 
            this.txtXMLName.Location = new System.Drawing.Point(457, 57);
            this.txtXMLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtXMLName.Name = "txtXMLName";
            this.txtXMLName.Size = new System.Drawing.Size(184, 22);
            this.txtXMLName.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "CommandText";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Name";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(111, 91);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(132, 22);
            this.txtCategory.TabIndex = 37;
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(111, 63);
            this.txtCaption.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(132, 22);
            this.txtCaption.TabIndex = 36;
            // 
            // txtActive
            // 
            this.txtActive.AutoSize = true;
            this.txtActive.Location = new System.Drawing.Point(15, 132);
            this.txtActive.Margin = new System.Windows.Forms.Padding(4);
            this.txtActive.Name = "txtActive";
            this.txtActive.Size = new System.Drawing.Size(68, 21);
            this.txtActive.TabIndex = 35;
            this.txtActive.Text = "Active";
            this.txtActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Caption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 33);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 31;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbVisible);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.txtcolDisplayMember);
            this.tabPage2.Controls.Add(this.txtcolValueMember);
            this.tabPage2.Controls.Add(this.txtcolDataSource);
            this.tabPage2.Controls.Add(this.txtcolFooterType);
            this.tabPage2.Controls.Add(this.txtcolFooterName);
            this.tabPage2.Controls.Add(this.txtcolDefaultValue);
            this.tabPage2.Controls.Add(this.txtcolWidth);
            this.tabPage2.Controls.Add(this.txtcolCaption);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtcolType);
            this.tabPage2.Controls.Add(this.txtcolName);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.GridViewColumns);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1127, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Columns";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(873, 235);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 76;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(873, 194);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 75;
            this.button4.Text = "New";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtcolDisplayMember
            // 
            this.txtcolDisplayMember.Location = new System.Drawing.Point(628, 326);
            this.txtcolDisplayMember.Margin = new System.Windows.Forms.Padding(4);
            this.txtcolDisplayMember.Name = "txtcolDisplayMember";
            this.txtcolDisplayMember.Size = new System.Drawing.Size(191, 22);
            this.txtcolDisplayMember.TabIndex = 74;
            // 
            // txtcolValueMember
            // 
            this.txtcolValueMember.Location = new System.Drawing.Point(628, 294);
            this.txtcolValueMember.Margin = new System.Windows.Forms.Padding(4);
            this.txtcolValueMember.Name = "txtcolValueMember";
            this.txtcolValueMember.Size = new System.Drawing.Size(191, 22);
            this.txtcolValueMember.TabIndex = 73;
            // 
            // txtcolDataSource
            // 
            this.txtcolDataSource.Location = new System.Drawing.Point(628, 262);
            this.txtcolDataSource.Margin = new System.Windows.Forms.Padding(4);
            this.txtcolDataSource.Name = "txtcolDataSource";
            this.txtcolDataSource.Size = new System.Drawing.Size(191, 22);
            this.txtcolDataSource.TabIndex = 72;
            // 
            // txtcolFooterType
            // 
            this.txtcolFooterType.FormattingEnabled = true;
            this.txtcolFooterType.Items.AddRange(new object[] {
            "Count",
            "Sum",
            "Avg",
            "MAX",
            "MIN"});
            this.txtcolFooterType.Location = new System.Drawing.Point(628, 229);
            this.txtcolFooterType.Margin = new System.Windows.Forms.Padding(4);
            this.txtcolFooterType.Name = "txtcolFooterType";
            this.txtcolFooterType.Size = new System.Drawing.Size(191, 24);
            this.txtcolFooterType.TabIndex = 71;
            // 
            // txtcolFooterName
            // 
            this.txtcolFooterName.Location = new System.Drawing.Point(628, 197);
            this.txtcolFooterName.Margin = new System.Windows.Forms.Padding(4);
            this.txtcolFooterName.Name = "txtcolFooterName";
            this.txtcolFooterName.Size = new System.Drawing.Size(191, 22);
            this.txtcolFooterName.TabIndex = 70;
            // 
            // txtcolDefaultValue
            // 
            this.txtcolDefaultValue.Location = new System.Drawing.Point(133, 326);
            this.txtcolDefaultValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtcolDefaultValue.Name = "txtcolDefaultValue";
            this.txtcolDefaultValue.Size = new System.Drawing.Size(188, 22);
            this.txtcolDefaultValue.TabIndex = 69;
            // 
            // txtcolWidth
            // 
            this.txtcolWidth.Location = new System.Drawing.Point(133, 294);
            this.txtcolWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtcolWidth.Name = "txtcolWidth";
            this.txtcolWidth.Size = new System.Drawing.Size(188, 22);
            this.txtcolWidth.TabIndex = 68;
            // 
            // txtcolCaption
            // 
            this.txtcolCaption.Location = new System.Drawing.Point(133, 262);
            this.txtcolCaption.Margin = new System.Windows.Forms.Padding(4);
            this.txtcolCaption.Name = "txtcolCaption";
            this.txtcolCaption.Size = new System.Drawing.Size(188, 22);
            this.txtcolCaption.TabIndex = 67;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 334);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 17);
            this.label16.TabIndex = 66;
            this.label16.Text = "Default Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 272);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 65;
            this.label9.Text = "Caption";
            // 
            // txtcolType
            // 
            this.txtcolType.FormattingEnabled = true;
            this.txtcolType.Items.AddRange(new object[] {
            "String",
            "Int32",
            "Boolean",
            "DateTime"});
            this.txtcolType.Location = new System.Drawing.Point(133, 229);
            this.txtcolType.Margin = new System.Windows.Forms.Padding(4);
            this.txtcolType.Name = "txtcolType";
            this.txtcolType.Size = new System.Drawing.Size(188, 24);
            this.txtcolType.TabIndex = 64;
            // 
            // txtcolName
            // 
            this.txtcolName.Location = new System.Drawing.Point(133, 197);
            this.txtcolName.Margin = new System.Windows.Forms.Padding(4);
            this.txtcolName.Name = "txtcolName";
            this.txtcolName.Size = new System.Drawing.Size(188, 22);
            this.txtcolName.TabIndex = 63;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(460, 233);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 17);
            this.label18.TabIndex = 62;
            this.label18.Text = "Footer Type";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(460, 201);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 17);
            this.label17.TabIndex = 61;
            this.label17.Text = "Footer Field Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(460, 329);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 17);
            this.label15.TabIndex = 59;
            this.label15.Text = "Display Member";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(460, 297);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 17);
            this.label14.TabIndex = 58;
            this.label14.Text = "ValueMember";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(460, 265);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 57;
            this.label13.Text = "DataSource";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 303);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 56;
            this.label12.Text = "Width";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 241);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 55;
            this.label11.Text = "Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 210);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 54;
            this.label10.Text = "Name";
            // 
            // GridViewColumns
            // 
            this.GridViewColumns.AllowUserToAddRows = false;
            this.GridViewColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewColumns.Location = new System.Drawing.Point(11, 7);
            this.GridViewColumns.Margin = new System.Windows.Forms.Padding(4);
            this.GridViewColumns.Name = "GridViewColumns";
            this.GridViewColumns.Size = new System.Drawing.Size(1103, 174);
            this.GridViewColumns.TabIndex = 53;
            this.GridViewColumns.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewColumns_CellClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(376, 329);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 16;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(132, 329);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 28);
            this.button7.TabIndex = 17;
            this.button7.Text = "Add";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // cbVisible
            // 
            this.cbVisible.AutoSize = true;
            this.cbVisible.Checked = true;
            this.cbVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVisible.Location = new System.Drawing.Point(133, 358);
            this.cbVisible.Name = "cbVisible";
            this.cbVisible.Size = new System.Drawing.Size(71, 21);
            this.cbVisible.TabIndex = 77;
            this.cbVisible.Text = "Visible";
            this.cbVisible.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 808);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.GridViewList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "View Editor";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewList;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCommandText;
        private System.Windows.Forms.TextBox txtXMLName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.CheckBox txtActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtcolDisplayMember;
        private System.Windows.Forms.TextBox txtcolValueMember;
        private System.Windows.Forms.TextBox txtcolDataSource;
        private System.Windows.Forms.ComboBox txtcolFooterType;
        private System.Windows.Forms.TextBox txtcolFooterName;
        private System.Windows.Forms.TextBox txtcolDefaultValue;
        private System.Windows.Forms.TextBox txtcolWidth;
        private System.Windows.Forms.TextBox txtcolCaption;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtcolType;
        private System.Windows.Forms.TextBox txtcolName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView GridViewColumns;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox cbVisible;
    }
}

