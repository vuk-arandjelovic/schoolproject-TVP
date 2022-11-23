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
    public partial class VidiSveRacune : Form
    {
        KnjizaraDataSet DS;
        KnjizaraDataSetTableAdapters.RacunTableAdapter racunDA;
        public VidiSveRacune()
        {
            InitializeComponent();
            DS = new KnjizaraDataSet();
            racunDA = new KnjizaraDataSetTableAdapters.RacunTableAdapter();
        }

        private void VidiSveRacune_Load(object sender, EventArgs e)
        {
            racunDA.Fill(DS.Racun);
            dataGridView1.DataSource = DS.Racun;
            timer1.Interval = 10000; //za promenu trajanja menjati vrednost (vrednost oznacava milisekunde)
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(ZatvoriProzor);
        }
        private void ZatvoriProzor(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DS.Racun;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var rezultat = from racuni in DS.Racun
                           where Convert.ToDateTime(racuni.datum).Date  == dateTimePicker1.Value.Date
                           select racuni;

            DataTable filtrirano = DS.Racun.Copy();
            filtrirano.Clear();

            foreach (var red in rezultat)
            {
                DataRow noviRed = filtrirano.NewRow();
                for (int i = 0; i < DS.Racun.Columns.Count; i++)
                {
                    noviRed[i] = red[i];
                }

                filtrirano.Rows.Add(noviRed);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filtrirano;
        }
    }
}
