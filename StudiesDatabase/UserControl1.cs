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
    public partial class UserControl1 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl1()
        {
            InitializeComponent();
            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void FillDataSource()
        {
            listBox1.DataSource = (from x in context.Instructors where x.Name.StartsWith(textBox1.Text) select x).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems == null) return;
            Instructor selectedInstructor = listBox1.SelectedItem as Instructor;
            var lessons = from xd in context.Lessons
                          where xd.InstructorFk == selectedInstructor.InstructorSk
                          select new
                          {
                              Kurzus = xd.CourseFkNavigation.Name,
                              Nap = xd.DayFkNavigation.Name,
                              Sav = xd.TimeFkNavigation.Name
                          };
            dataGridView1.DataSource = lessons.ToList();
        }

    }
}
