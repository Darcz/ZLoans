namespace ZAccounting
{
    partial class BranchForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zCheckBox1 = new ZControls.ZCheckBox();
            this.zTextBox2 = new ZControls.ZTextBox();
            this.zTextBox1 = new ZControls.ZTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.zCheckBox1);
            this.panel1.Controls.Add(this.zTextBox2);
            this.panel1.Controls.Add(this.zTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 387);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // zCheckBox1
            // 
            this.zCheckBox1.AutoSize = true;
            this.zCheckBox1.FieldName = "Active";
            this.zCheckBox1.Location = new System.Drawing.Point(29, 119);
            this.zCheckBox1.Name = "zCheckBox1";
            this.zCheckBox1.Size = new System.Drawing.Size(56, 17);
            this.zCheckBox1.TabIndex = 2;
            this.zCheckBox1.TableName = "tblBranches";
            this.zCheckBox1.Text = "Active";
            this.zCheckBox1.UseVisualStyleBackColor = true;
            // 
            // zTextBox2
            // 
            this.zTextBox2.CueText = "";
            this.zTextBox2.FieldName = "Name";
            this.zTextBox2.Location = new System.Drawing.Point(93, 81);
            this.zTextBox2.Name = "zTextBox2";
            this.zTextBox2.Size = new System.Drawing.Size(100, 20);
            this.zTextBox2.TabIndex = 1;
            this.zTextBox2.TableName = "tblBranches";
            // 
            // zTextBox1
            // 
            this.zTextBox1.CueText = "";
            this.zTextBox1.FieldName = "Code";
            this.zTextBox1.Location = new System.Drawing.Point(93, 55);
            this.zTextBox1.Name = "zTextBox1";
            this.zTextBox1.Size = new System.Drawing.Size(100, 20);
            this.zTextBox1.TabIndex = 0;
            this.zTextBox1.TableName = "tblBranches";
            // 
            // BranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 617);
            this.Controls.Add(this.panel1);
            this.Name = "BranchForm";
            this.Text = "Branch";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ZControls.ZTextBox zTextBox2;
        private ZControls.ZTextBox zTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ZControls.ZCheckBox zCheckBox1;
    }
}