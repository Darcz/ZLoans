﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;


namespace ZControls
{
    public class ZTextBox : TextBox
    {
        public event EventHandler CueTextChanged;
        private string _cueText;

        [Category("ZProperty")]
        public string TableName { get; set; }
        [Category("ZProperty")]
        public string FieldName { get; set; }

        [Category("ZProperty")]
        public string CueText
        {
            get { return _cueText; }
            set
            {
                value = value ?? string.Empty;
                if (value != _cueText)
                {
                    _cueText = value;
                    OnCueTextChanged(EventArgs.Empty);
                }
            }
        }


        protected virtual void OnCueTextChanged(EventArgs e)
        {
            this.Invalidate(true);
            if (this.CueTextChanged != null)
                this.CueTextChanged(this, e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (string.IsNullOrEmpty(this.Text.Trim()) && !string.IsNullOrEmpty(this.CueText) && !this.Focused)
            {
                Point startingPoint = new Point(0, 0);
                StringFormat format = new StringFormat();
                Font font = new Font(this.Font.FontFamily.Name, this.Font.Size, FontStyle.Italic);
                if (this.RightToLeft == RightToLeft.Yes)
                {
                    format.LineAlignment = StringAlignment.Far;
                    format.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                }
                e.Graphics.DrawString(CueText, font, Brushes.Gray, this.ClientRectangle, format);
            }
            else
            { 
                
            }
        }

        const int WM_PAINT = 0x000F;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                using (Graphics g = Graphics.FromHwnd(m.HWnd))
                {
                    this.OnPaint(new PaintEventArgs(g, this.ClientRectangle));
                }

                //this.OnPaint(new PaintEventArgs(Graphics.FromHwnd(m.HWnd), this.ClientRectangle));
            }
        }


    }
}
