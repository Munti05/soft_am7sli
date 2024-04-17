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
    public partial class UjSor : Form
    {
        public Egysor UJSorJee { get; set; }
        public UjSor()
        {
            InitializeComponent();
            UJSorJee = new Egysor();
            bindingSource1.DataSource = UJSorJee;
            
        }

       
    }
}
