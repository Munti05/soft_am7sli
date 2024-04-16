using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace gyakorlas_2_zhra
{
    public partial class Form1 : Form
    {
        BindingList<EgySorFejlec> kerdesek = new();
        public Form1()
        {
            InitializeComponent();
            egySorFejlecBindingSource.DataSource = kerdesek;
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("hajozasi_szabalyzat.csv");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tomb = csv.GetRecords<EgySorFejlec>();

                foreach (var item in tomb)
                {
                    kerdesek.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(kerdesek);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (egySorFejlecBindingSource.Current == null) return;

            if (MessageBox.Show("Biztosan törölni szeretnéd a kiválasztott sort?", "PanelSzoveg", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                egySorFejlecBindingSource.RemoveCurrent();
            }
        }

        private void new_row_button_Click(object sender, EventArgs e)
        {

            FormUjSor formUjSor = new FormUjSor();
            if (formUjSor.ShowDialog() == DialogResult.OK)
            {
                
                //kerdesek.Add(FormUjSor.);
            }
        }

        private void edit_row_button_Click(object sender, EventArgs e)
        {
            if (egySorFejlecBindingSource.Current == null) return;

            FormEditRow formEditRow = new FormEditRow();
            formEditRow.ujKerdes = (EgySorFejlec)egySorFejlecBindingSource.Current;
            formEditRow.Show();
        }
    }
}
