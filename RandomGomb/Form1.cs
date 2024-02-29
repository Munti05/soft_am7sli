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
                button.Height = 10;
                button.Width = 10;
                button.Top = random.Next(0, ClientRectangle.Height);
                button.Left = random.Next(0, ClientRectangle.Width);
                Controls.Add(button);
            }
        }
    }
}