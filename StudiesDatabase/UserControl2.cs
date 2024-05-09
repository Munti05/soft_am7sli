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
    public partial class UserControl2 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl2()
        {
            InitializeComponent();
            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void FillDataSource()
        {
            listBox1.DataSource = (from e in context.Courses where e.Name.StartsWith(textBox1.Text) select e).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems == null) return;
            Course c = listBox1.SelectedItem as Course;
            dataGridView1.DataSource = (from ha in context.Lessons
                                        where ha.CourseFk == c.CourseSk
                                        select new
                                        {
                                            Nap = ha.DayFkNavigation.Name,
                                            Oktato = ha.InstructorFkNavigation.Name,
                                            Sav = ha.TimeFkNavigation.Name
                                        }).ToList();
        }
    }
}
