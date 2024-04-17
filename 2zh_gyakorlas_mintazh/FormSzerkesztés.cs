using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2zh_gyakorlas_mintazh
{
    public partial class FormSzerkesztés : Form
    {
        public Egysor Szerkesztes { get; set; }
        public FormSzerkesztés()
        {
            InitializeComponent();
        }

        private void FormSzerkesztés_Load(object sender, EventArgs e)
        {
      
            bindingSource1.DataSource = Szerkesztes;
        }
    }
}
