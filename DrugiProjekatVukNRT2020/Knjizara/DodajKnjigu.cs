using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjizara
{
    public partial class DodajKnjigu : Form
    {
        KnjizaraDataSet DS;
        KnjizaraDataSetTableAdapters.KnjigaTableAdapter knjigaDA;
        KnjizaraDataSetTableAdapters.ZanrTableAdapter zanrDA;
        KnjizaraDataSetTableAdapters.PripadnostTableAdapter pripadnostDA;

        public DodajKnjigu()
        {
            InitializeComponent();
            DS = new KnjizaraDataSet();
            knjigaDA = new KnjizaraDataSetTableAdapters.KnjigaTableAdapter();
            zanrDA = new KnjizaraDataSetTableAdapters.ZanrTableAdapter();
            pripadnostDA = new KnjizaraDataSetTableAdapters.PripadnostTableAdapter();
        }

        private void DodajKnjigu_Load(object sender, EventArgs e)
        {
            pripadnostDA.Fill(DS.Pripadnost);
            knjigaDA.Fill(DS.Knjiga);
            zanrDA.Fill(DS.Zanr);

            checkedListBox1.DataSource = DS.Zanr;
            checkedListBox1.ValueMember = DS.Zanr.Columns[0].ToString();
            checkedListBox1.DisplayMember = DS.Zanr.Columns[1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Morate da popunite sva polja i izaberete bar 1 zanr!");
                return;
            }

            string autor = textBox1.Text;
            string naziv = textBox2.Text;
            int cena = Convert.ToInt32(numericUpDown1.Value);
            int popust = Convert.ToInt32(numericUpDown2.Value);
            int broj_strana = Convert.ToInt32(numericUpDown3.Value);
            //dodavanje knjige u tabelu
            int dodavanje = knjigaDA.Insert(textBox1.Text, textBox2.Text, cena, popust, broj_strana);

            knjigaDA.Fill(DS.Knjiga);

            int dodavanje_zanra;
            //u slucaju uspesnog dodavanja knjige dodaje se zanr
            if (dodavanje > 0)
            {
                //petlja proverava svaki chekirani row
                foreach (DataRowView obj in checkedListBox1.CheckedItems)
                {
                    //vadi se naziv iz row-a
                    string name = obj.Row["naziv"] as string;
                    //poredi se naziv sa svim zanrovima u tabeli
                    foreach (var zanr in DS.Zanr)
                    {
                        if (name.Equals(zanr.naziv))
                            //u slucaju podudaranja zanra i naziva, u tabeli pripadnosti se dodaje id knjige i id zanra
                            dodavanje_zanra = pripadnostDA.Insert(DS.Knjiga.Last().id_knjiga, zanr.id_zanr);
                    }
                }
                MessageBox.Show("Uspesno ste dodali knjigu!");
                knjigaDA.Fill(DS.Knjiga);
                Close();
            }
            else
            {
                MessageBox.Show("Neuspesno dodavanje knjige!");
            }
        }
    }
}
