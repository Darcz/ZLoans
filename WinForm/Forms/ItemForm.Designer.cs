namespace ZAccounting
{
    partial class ItemForm
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
            this.SuspendLayout();
            // 
            // ribbonMain
            // 
            this.ribbonMain.Location = new System.Drawing.Point(36, 91);
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
            this.ribbonMain.Size = new System.Drawing.Size(625, 185);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 516);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ItemForm";
            this.Padding = new System.Windows.Forms.Padding(36, 91, 36, 31);
            this.Text = "Item";
            this.ResumeLayout(false);

        }

        #endregion
    }
}