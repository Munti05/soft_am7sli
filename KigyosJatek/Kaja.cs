using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigyosJatek
{
    internal class Kaja : PictureBox
    {
        public Kaja()
        {
            Width = 20;
            Height = 20;
            BackColor = Color.Red;
            Random rnd = new Random();
            Top = rnd.Next(0, ClientRectangle.Height - 20);
            Left = rnd.Next(0, ClientRectangle.Width - 20);
        }
    }
}
