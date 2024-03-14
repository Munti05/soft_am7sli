namespace HajosKviz
{
    public partial class Form1 : Form
    {
        List<Kerdes> osszKerdes;
        List<Kerdes> aktivKerdes;
        int aktualisKerdes = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            osszKerdes = kerdesBetoltes();
            aktivKerdes = new List<Kerdes>();
            for (int i = 0; i < 7; i++)
            {
                aktivKerdes.Add(osszKerdes[0]);
                osszKerdes.RemoveAt(0);
            }

            dataGridView1.DataSource = aktivKerdes;

            KerdesMegjelenites(aktivKerdes[aktualisKerdes]);
        }


        void KerdesMegjelenites(Kerdes kerdes)
        {
            label1.Text = kerdes.K�rd�sSz�veg;
            valaszGomb1.Text = kerdes.V�lasz1;
            valaszGomb2.Text = kerdes.V�lasz2;
            valaszGomb3.Text = kerdes.V�lasz3;

            if (string.IsNullOrEmpty(kerdes.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kerdes.URL);
            }
        }

        List<Kerdes> kerdesBetoltes()
        {
            List<Kerdes> kerdesek = new List<Kerdes>();
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine() ?? "";
                string[] tomb = sor.Split("\t");
                //if (tomb.Length !=7) continue;

                Kerdes kerdes = new Kerdes();
                kerdes.K�rd�sSz�veg = tomb[1];
                kerdes.V�lasz1 = tomb[2];
                kerdes.V�lasz2 = tomb[3];
                kerdes.V�lasz3 = tomb[4];
                kerdes.URL = tomb[5];

                //hibakezeles a szamma alakitasnal
                int x = 0;
                int.TryParse(tomb[6], out x);
                kerdes.HelyesV�lasz = x;

                kerdesek.Add(kerdes);
            }
            sr.Close();


            return kerdesek;
        }

        private void valaszGomb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}