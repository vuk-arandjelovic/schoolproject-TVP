using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjizara
{
    public partial class Form1 : Form
    {
        KnjizaraDataSet DS;
        KnjizaraDataSetTableAdapters.KnjigaTableAdapter knjigaDA;
        KnjizaraDataSetTableAdapters.ZanrTableAdapter zanrDA;
        KnjizaraDataSetTableAdapters.PripadnostTableAdapter pripadnostDA;
        KnjizaraDataSetTableAdapters.RacunTableAdapter racunDA;
        KnjizaraDataSetTableAdapters.Stavka_racunaTableAdapter stavka_racunaDA;
        ListSortDirection direction;
        Thread nit;
        Thread nit2;
        Stopwatch timer;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            DS = new KnjizaraDataSet();
            knjigaDA = new KnjizaraDataSetTableAdapters.KnjigaTableAdapter();
            zanrDA = new KnjizaraDataSetTableAdapters.ZanrTableAdapter();
            pripadnostDA = new KnjizaraDataSetTableAdapters.PripadnostTableAdapter();
            racunDA = new KnjizaraDataSetTableAdapters.RacunTableAdapter();
            stavka_racunaDA = new KnjizaraDataSetTableAdapters.Stavka_racunaTableAdapter();
            timer = new Stopwatch();

            direction = ListSortDirection.Ascending;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //punjenje combobox-a zanrovima
            zanrDA.Fill(DS.Zanr);
            comboBox1.DataSource = DS.Zanr;
            comboBox1.ValueMember = DS.Zanr.Columns[0].ToString();
            comboBox1.DisplayMember = DS.Zanr.Columns[1].ToString();
            comboBox1.SelectedItem = null;

            //punjenje datagrid-a knjigama
            knjigaDA.Fill(DS.Knjiga);
            dataGridView1.DataSource = DS.Knjiga;
            dataGridView1.Sort(dataGridView1.Columns[2], direction);


            pripadnostDA.Fill(DS.Pripadnost);
            Thread.Sleep(10);
            //thread

            nit = new Thread(animacija2);
            nit.IsBackground = true;
            nit.Start();

            nit2 = new Thread(animacijaTop3Knjige);
            nit2.IsBackground = true;
            nit2.Start();
        }

        private void animacija2()
        {
            Point tacka = new Point(label5.Location.X, label5.Location.Y);
            bool spustanje = false;
            while (true)
            {
                if (label5.Location.Y > 1)
                {
                    tacka.Y -= 1;
                    this.BeginInvoke(new Action(() => { label5.Location = tacka; }));
                    Thread.Sleep(10);
                }
                else if (label5.Location.Y == 1)
                {
                    tacka.Y += 1;
                    this.BeginInvoke(new Action(() => { label5.Location = tacka; }));
                    spustanje = true;
                    Thread.Sleep(10);
                }
                while (spustanje)
                {
                    tacka.Y += 1;
                    this.BeginInvoke(new Action(() => { label5.Location = tacka; }));
                    Thread.Sleep(10);
                    if (label5.Location.Y == 24)
                        spustanje = !spustanje;
                }
            }

        }

        private void animacijaTop3Knjige()
        {
            int top1 = 0, top2 = 0, top3 = 0;

            //thread
            while (true)
            {
                Thread.Sleep(10000);
                try
                {
                    var knjige = from knjiga in DS.Knjiga
                                 select new { k_id = knjiga.id_knjiga, k_naziv = knjiga.naziv };

                    foreach (var knjiga in knjige)
                    {
                        var kolicina = from stavka in DS.Stavka_racuna
                                       join racun in DS.Racun on stavka.id_racun equals racun.id_racun
                                       where stavka.id_knjiga == knjiga.k_id && racun.datum.Day == DateTime.Now.Day
                                       select stavka.kolicina;

                        int suma = 0;
                        foreach (int broj in kolicina)
                        {
                            suma += broj;
                        }
                        if (suma > top1)
                        {
                            top1 = suma;
                            this.BeginInvoke(new Action(() => { textBox4.Text = textBox3.Text; }));
                            this.BeginInvoke(new Action(() => { textBox3.Text = textBox2.Text; }));
                            this.BeginInvoke(new Action(() => { textBox2.Text = knjiga.k_naziv + " - " + top1.ToString(); }));
                        }
                        else if (suma > top2)
                        {
                            top2 = suma;
                            this.BeginInvoke(new Action(() => { textBox4.Text = textBox3.Text; }));
                            this.BeginInvoke(new Action(() => { textBox3.Text = knjiga.k_naziv + " - " + top2.ToString(); }));
                            
                            
                        }

                        else if (suma > top3)
                        {
                            top3 = suma;
                            this.BeginInvoke(new Action(() => { textBox4.Text = knjiga.k_naziv + " - " + top3.ToString(); }));
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Thread.Sleep(10000);
                }

            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //if clause, bez njega se promena na "null" primenjuje kao filter
            if (comboBox1.SelectedItem != null)
            {
                var rezultat = from knjiga in DS.Knjiga
                               join pripadnost in DS.Pripadnost on knjiga.id_knjiga equals pripadnost.id_knjiga
                               join zanr in DS.Zanr on pripadnost.id_zanr equals zanr.id_zanr
                               orderby knjiga.naziv
                               where zanr.id_zanr == int.Parse(comboBox1.SelectedValue.ToString())
                               select knjiga;

                DataTable filtrirano = DS.Knjiga.Copy();
                filtrirano.Clear();
                foreach (var red in rezultat)
                {
                    DataRow noviRed = filtrirano.NewRow();
                    for (int i = 0; i < DS.Knjiga.Columns.Count; i++)
                    {
                        noviRed[i] = red[i];
                    }
                    
                    filtrirano.Rows.Add(noviRed);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filtrirano;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;

            
            dataGridView1.DataSource = DS.Knjiga;
            dataGridView1.Sort(dataGridView1.Columns[2], direction);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajKnjigu DodajKnjiguForma = new DodajKnjigu();
            DodajKnjiguForma.ShowDialog();

            knjigaDA.Fill(DS.Knjiga);
            zanrDA.Fill(DS.Zanr);
            pripadnostDA.Fill(DS.Pripadnost);

            dataGridView1.DataSource = DS.Knjiga;
            dataGridView1.Sort(dataGridView1.Columns[2], direction);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VidiSveRacune VidiSveRacuneForma = new VidiSveRacune();
            VidiSveRacuneForma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            int id_knjige = (int)dataGridView1.Rows[selectedRow].Cells[0].Value;
            string naziv = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
            int cena = (int)dataGridView1.Rows[selectedRow].Cells[3].Value;
            int popust = (int)dataGridView1.Rows[selectedRow].Cells[4].Value;
            listView1.Items.Add(id_knjige + "~" + naziv + "~" + numericUpDown1.Value + "~" + cena + "~" + popust);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            racunanjeCene();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem stavka = listView1.SelectedItems[0];
            string[] stavke = stavka.Text.Split('~');
            if (Int32.Parse(stavke[2]) == 1)
                listView1.SelectedItems[0].Remove();
            else
            {
                stavke[2] = (Int32.Parse(stavke[2]) - 1).ToString();
                listView1.SelectedItems[0].Text = stavke[0] + "~" + stavke[1] + "~" + stavke[2] + "~" + stavke[3] + "~" + stavke[4];
            }

            racunanjeCene();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            listView1.SelectedItems[0].Remove();

            racunanjeCene();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listView1.Clear();

            textBox1.Text = "";
        }

        private void racunanjeCene()
        {
            int ukupna_cena = 0;
            foreach (ListViewItem stavka in listView1.Items)
            {
                string[] stavke = stavka.Text.Split('~');
                //MessageBox.Show(stavke[0] + "~" + stavke[1] + "~" + stavke[2] + "~" + stavke[3] + "~" + stavke[4] );
                ukupna_cena += (int)((float)Int32.Parse(stavke[3]) * (1f - (Int32.Parse(stavke[4]) / 100f)) * Int32.Parse(stavke[2]));
            }

            if(listView1.Items.Count == 0)
                textBox1.Text = "";
            textBox1.Text = ukupna_cena.ToString() + " RSD";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            racunDA.Fill(DS.Racun);
            stavka_racunaDA.Fill(DS.Stavka_racuna);

            racunDA.Insert(DateTime.Now, Int32.Parse(textBox1.Text.Split(' ')[0]));
            racunDA.Fill(DS.Racun);

            foreach (ListViewItem stavka in listView1.Items)
            {
                string[] stavke = stavka.Text.Split('~');
                stavka_racunaDA.Insert(DS.Racun.Last().id_racun, Int32.Parse(stavke[0]), Int32.Parse(stavke[3]), Int32.Parse(stavke[4]), Int32.Parse(stavke[2]));
            }
            stavka_racunaDA.Fill(DS.Stavka_racuna);

            listView1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PogledajSatistike pogledajSatistikeForm = new PogledajSatistike();
            pogledajSatistikeForm.ShowDialog();


        }
    }
}
