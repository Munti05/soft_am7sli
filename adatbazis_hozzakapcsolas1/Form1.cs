using adatbazis_hozzakapcsolas1.Models;

namespace adatbazis_hozzakapcsolas1
{
    public partial class Form1 : Form
    {
        Models.StudentContext studentContext = new Models.StudentContext();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = studentContext.Students.ToList();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                studentContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //var er = from x in studentContext.Students  
            //        where x.Name.StartsWith(textBox1.Text)
            //        select x;

            //studentBindingSource.DataSource = er.ToString();
            //vmi nem jo az utolso sorba
        }
    }
}