using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace ZAccounting
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            MDIClientSupport.SetBevel(this, false);

            //Show View Form            
            ViewForm ViewForm_ = new ViewForm();
            ViewForm_.MdiParent = this;
            ViewForm_.Dock = DockStyle.Fill;
            ViewForm_.Show();
            WindowList.WindowInstances.Add(new WindowList.WindowInstance { Caption = "Home", FormName = "ViewForm", WindowForm = ViewForm_ });
            ViewForm_.RefreshOrb();
        }
    }
}
