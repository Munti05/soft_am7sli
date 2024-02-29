using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillogoGomb
{
    public partial class Form2 : Form
    {

        int x = 20;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    SzamoloGomb sz = new SzamoloGomb();
                    sz.Top = i*sz.Width;
                    sz.Left = j*sz.Width;
                    Controls.Add(sz);

                }
            }
        }
    }
}
