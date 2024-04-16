using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyakorlas_2_zhra
{
    public partial class FormEditRow : Form
    {
        public EgySorFejlec ujKerdes = new();


        public FormEditRow()
        {
            InitializeComponent();
            
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditRow_Load(object sender, EventArgs e)
        {
            egySorFejlecBindingSource.DataSource = ujKerdes;
        }
    }
}
