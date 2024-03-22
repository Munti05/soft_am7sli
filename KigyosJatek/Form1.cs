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
                        label1.Text ="Game Over";
                        label1.Top = ClientRectangle.Height/2-label1.Height/2;
                        label1.Left = ClientRectangle.Width/2-label1.Width/2;
                        return;
                    }
                }
            }

            KigyoElem kigyoElem = new KigyoElem();
            kigyoElem.Top = fejY;
            kigyoElem.Left = fejX;        

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
                kigyoElem.BackColor = Color.Green;
            }

            if (fejX == 200 && fejY == 100)
            {
                
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