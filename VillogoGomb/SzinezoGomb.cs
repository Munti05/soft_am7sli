using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class SzinezoGomb : Button
    {
        public SzinezoGomb()
        {
            MouseClick += SzinezoGomb_MouseClick;
            MouseDoubleClick += SzinezoGomb_MouseDoubleClick;
        }

        private void SzinezoGomb_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
        }

      

        private void SzinezoGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
