using CsvHelper;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace _2zh_gyakorlas_mintazh
{
    public partial class Form1 : Form
    {
        BindingList<Egysor> lista = new();
        public Form1()
        {
            InitializeComponent();
            egysorBindingSource.DataSource = lista;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futoversenyzok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tomb = csv.GetRecords<Egysor>();

                foreach (var item in tomb)
                {
                    lista.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lista.Count() == 0) return;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(lista);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (lista.Count() == 0) return;
            if (MessageBox.Show("Biztosan Törölni akarod", "Kérdés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                egysorBindingSource.RemoveCurrent();
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (lista.Count() == 0) return;
            UjSor ujSor = new UjSor();
            if (ujSor.ShowDialog() == DialogResult.OK)
            {
                lista.Add(ujSor.UJSorJee);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (lista.Count() == 0) return;
            FormSzerkesztés formSzerkesztés = new();
            
            formSzerkesztés.Szerkesztes = (Egysor)egysorBindingSource.Current;
            formSzerkesztés.ShowDialog();
            
            
        }

        private void buttonGift_Click(object sender, EventArgs e)
        {

            int db = 0;
            double legjobb = double.PositiveInfinity;
            string ember = "a";
            foreach (var versenyzo in lista)
            {
                if (versenyzo.Nemzetiseg == "USA")
                {
                    db++;
                }
                if (legjobb > versenyzo.EredmenyPerc)
                {
                    legjobb = versenyzo.EredmenyPerc;
                    ember = versenyzo.Nev;
                }
            }

            MessageBox.Show($"haha USA:{db}. Legfaszabb ember: {ember}({legjobb} perc)");
        }
    }
}
