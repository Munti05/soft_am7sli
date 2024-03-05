namespace gyakorla_az_elso_zhra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a = 8;
        List<string> list = new List<string>(new string[] {"a","b","c","d","e","f","g"});

        private void Form1_Load(object sender, EventArgs e)
        {
            gomb1.MouseClick += Gomb1_MouseClick;

            Button b = new Button();
            Controls.Add(b);

            List<Button> but = new List<Button>();
            for (int i = 0; i < 10; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();

                but.Add(button);
            }

            dataGridView1.DataSource = but;


            for (int i = 0;i < 9;i++)
            {
                for (int j = 0;j < 9;j++)
                {
                    Button butto = new Button();
                    butto.Top = i*30;
                    butto.Left = j*30;
                    butto.Width = 30;
                    butto.Height = 30;
                    if (j == 0)
                    {
                        if(i!=8)
                        {
                            butto.Text = a.ToString();
                            a--;
                         }                        
                    }

                    if (i% 2==0)
                    {
                        if (j % 2 == 0)
                        {
                            if (j!=0) 
                            {
                                butto.BackColor = Color.Black;
                            } 
                        }
                        
                    }
                    else
                    {
                        if (j % 2 == 1)
                        {
                            butto.BackColor = Color.Black;
                        }
                    }
                    Controls.Add(butto);
                }
            }

        }

        private void Gomb1_MouseClick(object? sender, MouseEventArgs e)
        {
            int x = int.Parse(szovegDoboz.Text);
            szovegDoboz2.Text = (x*2).ToString();
        }

       
    }
}
