using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_Projekat_VukA_NRT2020
{
    public partial class GuestsForm : Form
    {
        public static int editGuestId;
        public  GuestsForm()
        {
            InitializeComponent();

            lstViewGuests.View = View.Details;
            lstViewGuests.FullRowSelect = true;
            lstViewGuests.GridLines = true;
            lstViewGuests.Columns.Add("ID", 65);
            lstViewGuests.Columns.Add("Ime", 100);
            lstViewGuests.Columns.Add("Prezime", 100);
            lstViewGuests.Columns.Add("Datum Rodjenja", 100);
            lstViewGuests.Columns.Add("Telefon", 100);
        }

        private void GuestsForm_Load(object sender, EventArgs e)
        {

            populateList();


        }

        private void populateList()
        {
            lstViewGuests.Items.Clear();
            foreach (Guest g in ModelLister.Guests)
            {
                ListViewItem redLista = new ListViewItem();
                redLista.Text = g.Id.ToString();
                redLista.SubItems.Add(g.FirstName);
                redLista.SubItems.Add(g.LastName);
                redLista.SubItems.Add(g.Birthday.ToShortDateString());
                redLista.SubItems.Add(g.PhoneNumber);
                lstViewGuests.Items.Add(redLista);
            }
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            AddGuestForm dodajGosta = new AddGuestForm();
            dodajGosta.ShowDialog();
            populateList();
        }

        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(lstViewGuests.SelectedItems[0].SubItems[0].Text);
                Guest removedGuest = ModelLister.Guests.Find(_guest => _guest.Id == id);
                if (removedGuest != null)
                {
                    //Ovde se moze dodati failsafe koji proverava da li postoje rezervacije na izabranog gosta, tako da se ne dozvoli brisanje gosta koji poseduje rezervacijena njegovo ime
                    ModelLister.Guests.Remove(removedGuest);
                    ModelLister.saveGuests();
                    populateList();
                }
            }
            catch
            {
                MessageBox.Show("Nije uspelo brisanje gosta");
            }
        }

        private void btnUpdateGuest_Click(object sender, EventArgs e)
        {
            try
            {
                editGuestId = Int32.Parse(lstViewGuests.SelectedItems[0].SubItems[0].Text);
                Guest selectedGuest = ModelLister.Guests.Find(_guest => _guest.Id == editGuestId);


                if (selectedGuest != null)
                {
                    EditGuestForm izmeniGosta = new EditGuestForm();
                    izmeniGosta.ShowDialog();
                    populateList();
                }
                else
                {
                    MessageBox.Show("Izaberite gosta");
                }
            }
            catch
            {
                MessageBox.Show("Greska pri ucitavanju gosta");
            }
        }

        private void btnSaveGuests_Click(object sender, EventArgs e)
        {
            ModelLister.saveGuests();
            Close();
        }
    }
}
