namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        int mbox = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    SzinezoGomb b = new SzinezoGomb();
                    b.Height = mbox;
                    b.Width = mbox;
                    b.Left = oszlop * mbox; 
                    b.Top = sor * mbox;
                    b.Text = ((sor + 1) * (oszlop + 1)).ToString();
                    Controls.Add(b);
                }
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}