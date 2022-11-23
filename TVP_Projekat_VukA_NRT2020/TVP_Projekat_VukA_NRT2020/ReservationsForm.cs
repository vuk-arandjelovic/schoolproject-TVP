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
    public partial class ReservationsForm : Form
    {

        public static int editRoomId;
        public static int editGuestId;
        public static int editReservationId;
        public ReservationsForm()
        {
            InitializeComponent();
            lstViewReservations.View = View.Details;
            lstViewReservations.FullRowSelect = true;
            lstViewReservations.GridLines = true;
            lstViewReservations.Columns.Add("ID", 65);
            lstViewReservations.Columns.Add("Soba", 100);
            lstViewReservations.Columns.Add("Gost", 100);
            lstViewReservations.Columns.Add("Cena", 100);
            lstViewReservations.Columns.Add("Pansion", 100);
            lstViewReservations.Columns.Add("Od", 100);
            lstViewReservations.Columns.Add("Do", 100);
        }

        private void populateList()
        {
            lstViewReservations.Items.Clear();
            foreach (Reservation r in ModelLister.Reservations)
            {
                ListViewItem redLista = new ListViewItem();
                redLista.Text = r.Id.ToString();
                redLista.SubItems.Add(r.Room.RoomNumber.ToString());
                redLista.SubItems.Add(r.Guest.FirstName + " " + r.Guest.LastName);
                redLista.SubItems.Add(r.Price.ToString() + "RSD");
                redLista.SubItems.Add(r.Pension);
                redLista.SubItems.Add(r.DateFrom.ToString());
                redLista.SubItems.Add(r.DateTo.ToString());
                lstViewReservations.Items.Add(redLista);
            }
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            AddReservationForm dodajRezervaciju = new AddReservationForm();
            dodajRezervaciju.ShowDialog();
            populateList(); 
        }

        private void ReservationsForm_Load(object sender, EventArgs e)
        {
            populateList();
        }

        private void btnChangeReservation_Click(object sender, EventArgs e)
        {
            try
            {
                editReservationId = Int32.Parse(lstViewReservations.SelectedItems[0].SubItems[0].Text);
                Reservation selectedReservation = ModelLister.Reservations.Find(_reservation => _reservation.Id == editReservationId);


                if (selectedReservation != null)
                {
                    editRoomId = selectedReservation.Room.Id;
                    editGuestId = selectedReservation.Guest.Id;
                    EditReservationForm izmeniRezervaciju = new EditReservationForm();
                    izmeniRezervaciju.ShowDialog();
                    populateList();
                }
                else
                {
                    MessageBox.Show("Izaberite rezervaciju");
                }
            }
            catch
            {
                MessageBox.Show("Greska pri ucitavanju rezervacije");
            }
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(lstViewReservations.SelectedItems[0].SubItems[0].Text);
                Reservation removedReservation = ModelLister.Reservations.Find(_reservation => _reservation.Id == id);
                if (removedReservation != null)
                {
                    ModelLister.Rooms.Find(_room => _room.Id == removedReservation.Room.Id).Taken = false;
                    ModelLister.saveRooms();
                    ModelLister.Reservations.Remove(removedReservation);
                    ModelLister.saveReservations();
                    populateList();
                }
            }
            catch
            {
                MessageBox.Show("Nije uspelo brisanje rezervacije");
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            ModelLister.saveReservations();
            Close();
        }
    }
}
