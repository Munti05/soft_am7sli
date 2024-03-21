using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigyosJatek
{
    internal class KigyoElem: PictureBox
    {
        public static int meret = 20;

        public KigyoElem()
        {
            Width = KigyoElem.meret;
            Height = KigyoElem.meret;
            BackColor = Color.DarkGreen;
        }
    }
}
