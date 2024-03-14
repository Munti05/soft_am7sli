using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace HajosKviz
{
    internal class ValaszGomb : TextBox
    {
        public ValaszGomb()
        {
            BackColor = Color.Fuchsia;
            Multiline = true;
            ReadOnly = true;

            MouseEnter += ValaszGomb_MouseEnter;
            MouseLeave += ValaszGomb_MouseLeave;

            BorderStyle = BorderStyle.None;
            Cursor = Cursors.Hand;
        }

        private void ValaszGomb_MouseLeave(object? sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }

        private void ValaszGomb_MouseEnter(object? sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
