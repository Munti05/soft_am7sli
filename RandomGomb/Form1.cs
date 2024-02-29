namespace RandomGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                Button button = new Button();
                button.Height = random.Next(1,101);
                button.Width = random.Next(1, 101);
                button.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                button.Top = random.Next(0, ClientRectangle.Height-button.Height);
                button.Left = random.Next(0, ClientRectangle.Width-button.Width);
                Controls.Add(button);
            }
        }
    }
}