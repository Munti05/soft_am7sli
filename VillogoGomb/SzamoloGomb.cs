using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class SzamoloGomb : Button
    {
        int szam = 0;

        public SzamoloGomb()
        {
            MouseClick += SzamoloGomb_MouseClick;
            Width = 20;
            Height = 20;
           
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            szam++;
            Text = szam.ToString();
            if (szam == 5)
            {
                szam = 0;
            }
        }
    }
}
