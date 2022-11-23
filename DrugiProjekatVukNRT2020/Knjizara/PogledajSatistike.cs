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
    public partial class PogledajSatistike : Form
    {
        KnjizaraDataSet DS;
        KnjizaraDataSetTableAdapters.KnjigaTableAdapter knjigaDA;
        KnjizaraDataSetTableAdapters.RacunTableAdapter racunDA;
        KnjizaraDataSetTableAdapters.Stavka_racunaTableAdapter stavka_racunaDA;
        int sumaSvih = 0;

        public PogledajSatistike()
        {
            InitializeComponent();

            DS = new KnjizaraDataSet();
            knjigaDA = new KnjizaraDataSetTableAdapters.KnjigaTableAdapter();
            racunDA = new KnjizaraDataSetTableAdapters.RacunTableAdapter();
            stavka_racunaDA = new KnjizaraDataSetTableAdapters.Stavka_racunaTableAdapter();
        }


        private void PogledajSatistike_Load(object sender, EventArgs e)
        {
            knjigaDA.Fill(DS.Knjiga);
            racunDA.Fill(DS.Racun);
            stavka_racunaDA.Fill(DS.Stavka_racuna);

            var knjige = from knjiga in DS.Knjiga
                         select new { k_id = knjiga.id_knjiga , k_naziv = knjiga.naziv };

            foreach (var knjiga in knjige)
            {
                var kolicina = from stavka in DS.Stavka_racuna
                               join racun in DS.Racun on stavka.id_racun equals racun.id_racun
                               where stavka.id_knjiga == knjiga.k_id && DateTime.Now.Subtract(racun.datum).Days < 30
                               select stavka.kolicina;

                int suma = 0;
                foreach(int broj in kolicina)
                {
                    suma += broj;
                    sumaSvih += broj;
                }
                listBox1.Items.Add(knjiga.k_id + " ~ " + knjiga.k_naziv + " ~ " + suma);
            }
        }
        private void crtanjePite(object sender, PaintEventArgs e)
        {
            Random rnd = new Random();
            Rectangle rect = new Rectangle(275, 20, 310, 310);
            float pocetniUgao = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string[] knjiga = listBox1.Items[i].ToString().Split('~');
                float x = 360f * Int32.Parse(knjiga[2]) / sumaSvih;
                Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                SolidBrush brush = new SolidBrush(color);
                e.Graphics.FillPie(brush, rect, pocetniUgao, x);
                pocetniUgao += x;
            }
        }
    }
}
