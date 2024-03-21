namespace KigyosJatek
{
    public partial class Form1 : Form
    {

        int fejX = 100;
        int fejY = 100;
        int iranyX = 1;
        int iranyY = 0;
        int lepesszam = 0;
        int hossz = 10;

        List<KigyoElem> kigyo = new List<KigyoElem>();
        List<Kaja> kajas = new List<Kaja>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            lepesszam++;
            fejX += iranyX * KigyoElem.meret;
            fejY += iranyY * KigyoElem.meret;

            foreach (object item in Controls)
            {
                if (item is KigyoElem)
                {
                    KigyoElem k = (KigyoElem)item;

                    if (k.Top == fejY && k.Left == fejX)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            KigyoElem kigyoElem = new KigyoElem();
            kigyoElem.Top = fejY;
            kigyoElem.Left = fejX;

            Random rnd = new Random();

            if (lepesszam ==0)
            {
                Kaja etel = new Kaja();
                Controls.Add(etel);
            }

            

            kigyo.Add(kigyoElem);
            Controls.Add(kigyoElem);


            

            if (Controls.Count > hossz)
            {
                KigyoElem levagni = kigyo[0];
                kigyo.RemoveAt(0);
                Controls.Remove(levagni);
            }

            if (lepesszam % 2 == 0)
            {
                kigyoElem.BackColor = Color.Blue;
            }


        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                iranyX = 0;
                iranyY = -1;
            }
            if (e.KeyCode == Keys.Down)
            {
                iranyX = 0;
                iranyY = 1;
            }
            if (e.KeyCode == Keys.Left)
            {
                iranyX = -1;
                iranyY = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                iranyX = 1;
                iranyY = 0;
            }
        }

    }
}