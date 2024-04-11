using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace AdatKotes
{
    public partial class Form1 : Form
    {

        BindingList<CountryData> countryList = new();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = countryDataBindingSource;
            countryDataBindingSource.DataSource = countryList;

        }

        private void Megnyit�s_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("european_countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var t�mb = csv.GetRecords<CountryData>();
            foreach (var item in t�mb)
            {
                countryList.Add(item);
            }
            sr.Close();
        }

        private void T�rl�s_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void Szerkeszt�s_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.CountryData = countryDataBindingSource.Current as CountryData;
            f2.Show();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            var writer = new StreamWriter("european_countries.csv");
            var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

            csv.WriteRecords(countryList);
            writer.Close();

        }

    }
}