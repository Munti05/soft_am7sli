using StudiesDatabase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudiesDatabase
{
    public partial class UserControl3 : UserControl
    {
        StudiesContext sc = new StudiesContext();   
        public UserControl3()
        {
            InitializeComponent();
            listBox1.DataSource = (from k in sc.Employements where k.Name.StartsWith(textBox1.Text) select k).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
