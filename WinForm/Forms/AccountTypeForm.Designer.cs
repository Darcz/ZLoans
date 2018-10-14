namespace ZAccounting
{
    partial class AccountTypeForm
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
            this.zTextBox1 = new ZControls.ZTextBox();
            this.zTextBox2 = new ZControls.ZTextBox();
            this.zTextBox3 = new ZControls.ZTextBox();
            this.zCheckBox1 = new ZControls.ZCheckBox();
            this.SuspendLayout();
            // 
            // ribbonMain
            // 
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
            // 
            // 
            // 
            this.ribbonMain.QuickAcessToolbar.Visible = false;
            // 
            // zTextBox1
            // 
            this.zTextBox1.CueText = null;
            this.zTextBox1.FieldName = "Code";
            this.zTextBox1.Location = new System.Drawing.Point(133, 289);
            this.zTextBox1.Name = "zTextBox1";
            this.zTextBox1.Size = new System.Drawing.Size(204, 22);
            this.zTextBox1.TabIndex = 2;
            this.zTextBox1.TableName = "tblChartofAccountTypes";
            // 
            // zTextBox2
            // 
            this.zTextBox2.CueText = null;
            this.zTextBox2.FieldName = "Name";
            this.zTextBox2.Location = new System.Drawing.Point(133, 326);
            this.zTextBox2.Name = "zTextBox2";
            this.zTextBox2.Size = new System.Drawing.Size(204, 22);
            this.zTextBox2.TabIndex = 3;
            this.zTextBox2.TableName = "tblChartofAccountTypes";
            // 
            // zTextBox3
            // 
            this.zTextBox3.CueText = null;
            this.zTextBox3.FieldName = "Description";
            this.zTextBox3.Location = new System.Drawing.Point(133, 375);
            this.zTextBox3.Multiline = true;
            this.zTextBox3.Name = "zTextBox3";
            this.zTextBox3.Size = new System.Drawing.Size(204, 115);
            this.zTextBox3.TabIndex = 4;
            this.zTextBox3.TableName = "tblChartofAccountTypes";
            // 
            // zCheckBox1
            // 
            this.zCheckBox1.AutoSize = true;
            this.zCheckBox1.FieldName = "Active";
            this.zCheckBox1.Location = new System.Drawing.Point(133, 508);
            this.zCheckBox1.Name = "zCheckBox1";
            this.zCheckBox1.Size = new System.Drawing.Size(68, 21);
            this.zCheckBox1.TabIndex = 5;
            this.zCheckBox1.TableName = "tblChartofAccountTypes";
            this.zCheckBox1.Text = "Active";
            this.zCheckBox1.UseVisualStyleBackColor = true;
            // 
            // AccountTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 759);
            this.Controls.Add(this.zCheckBox1);
            this.Controls.Add(this.zTextBox3);
            this.Controls.Add(this.zTextBox2);
            this.Controls.Add(this.zTextBox1);
            this.Name = "AccountTypeForm";
            this.Text = "AccountTypeForm";
            this.Controls.SetChildIndex(this.ribbonMain, 0);
            this.Controls.SetChildIndex(this.zTextBox1, 0);
            this.Controls.SetChildIndex(this.zTextBox2, 0);
            this.Controls.SetChildIndex(this.zTextBox3, 0);
            this.Controls.SetChildIndex(this.zCheckBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZControls.ZTextBox zTextBox1;
        private ZControls.ZTextBox zTextBox2;
        private ZControls.ZTextBox zTextBox3;
        private ZControls.ZCheckBox zCheckBox1;
    }
}