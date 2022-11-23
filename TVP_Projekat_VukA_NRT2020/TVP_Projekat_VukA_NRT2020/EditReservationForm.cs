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
    public partial class EditReservationForm : Form
    {
        private Room chosenRoom;
        private Guest chosenGuest;
        private Reservation loadedReservation;
        private decimal price;
        public EditReservationForm()
        {
            InitializeComponent();


            lstViewRooms.View = View.Details;
            lstViewRooms.FullRowSelect = true;
            lstViewRooms.GridLines = true;
            lstViewRooms.Columns.Add("ID", 65);
            lstViewRooms.Columns.Add("Broj Sobe", 50);
            lstViewRooms.Columns.Add("Broj Kreveta", 50);
            lstViewRooms.Columns.Add("Tip Sobe", 100);
            lstViewRooms.Columns.Add("Cena (RSD)", 50);
            lstViewRooms.Columns.Add("Popust (%)", 50);
            lstViewRooms.Columns.Add("Min. Dana Rezervisano", 100);


            lstViewGuests.View = View.Details;
            lstViewGuests.FullRowSelect = true;
            lstViewGuests.GridLines = true;
            lstViewGuests.Columns.Add("ID", 65);
            lstViewGuests.Columns.Add("Ime", 100);
            lstViewGuests.Columns.Add("Prezime", 100);
            lstViewGuests.Columns.Add("Datum Rodjenja", 100);
            lstViewGuests.Columns.Add("Telefon", 100);

            chosenRoom = ModelLister.Rooms.Find(_room => _room.Id == ReservationsForm.editRoomId);
            chosenGuest = ModelLister.Guests.Find(_guest => _guest.Id == ReservationsForm.editGuestId);

            loadedReservation = ModelLister.Reservations.Find(_reservation => _reservation.Id == ReservationsForm.editReservationId);

            if (chosenRoom == null)
            {
                MessageBox.Show("Soba nije pronadjena!");
                Close();
            }

            if (chosenGuest == null)
            {
                MessageBox.Show("Gost nije pronadjena!");
                Close();
            }

            if (loadedReservation == null)
            {
                MessageBox.Show("Rezervacija nije pronadjena!");
                Close();
            }

            txtGuest.Text = chosenGuest.FirstName + " " + chosenGuest.LastName;
            txtRoom.Text = chosenRoom.RoomNumber.ToString();
            dateReservationFrom.Value = loadedReservation.DateFrom;
            dateReservationTo.Value = loadedReservation.DateTo;
            cbPension.Text = loadedReservation.Pension;

            updatePrice();
        }

        private void btnCreateReservation_Click(object sender, EventArgs e)
        {
            if (dateReservationFrom.Value > dateReservationTo.Value)
            {
                MessageBox.Show("Greska u datumu rezervacije");
                lblTotalPrice.Text = "";
                return;
            }

            if (chosenRoom == null)
            {
                MessageBox.Show("Molimo odaberite sobu");
                lblTotalPrice.Text = "";
                return;
            }

            if (chosenGuest == null)
            {
                MessageBox.Show("Molimo odaberite gosta");
                lblTotalPrice.Text = "";
                return;
            }


            if (price <= 0)
            {
                MessageBox.Show("Greska pri racunanju cene, proverite unos");
                lblTotalPrice.Text = "";
                return;
            }

            ModelLister.Rooms.Find(_room => _room.Id == chosenRoom.Id).Taken = true;
            ModelLister.saveRooms();

            loadedReservation.Guest = chosenGuest;
            loadedReservation.Room = chosenRoom;
            loadedReservation.Price = price;
            loadedReservation.Pension = cbPension.Text;
            loadedReservation.DateFrom = dateReservationFrom.Value;
            loadedReservation.DateTo = dateReservationTo.Value;


            ModelLister.saveReservations();

            Close();
        }

        private void EditReservationForm_Load(object sender, EventArgs e)
        {
            populateRoomList();
            populateGuestList();
        }

        private void populateRoomList()
        {
            lstViewRooms.Items.Clear();
            foreach (Room r in ModelLister.Rooms)
            {
                if (r.Taken) { continue; }
                ListViewItem redLista = new ListViewItem();
                redLista.Text = r.Id.ToString();
                redLista.SubItems.Add(r.RoomNumber.ToString());
                redLista.SubItems.Add(r.Beds.ToString());
                redLista.SubItems.Add(r.Type);
                redLista.SubItems.Add(r.Price.ToString());
                redLista.SubItems.Add(r.Discount.ToString());
                redLista.SubItems.Add(r.MinDays.ToString());
                lstViewRooms.Items.Add(redLista);
            }
        }

        private void populateGuestList()
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

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            try
            {
                chosenRoom.Taken = false;
                int roomId = Int32.Parse(lstViewRooms.SelectedItems[0].SubItems[0].Text);
                Room selectedRoom = ModelLister.Rooms.Find(_room => _room.Id == roomId);


                if (selectedRoom != null)
                {
                    chosenRoom = selectedRoom;
                    txtRoom.Text = chosenRoom.RoomNumber.ToString();
                }
                else
                {
                    MessageBox.Show("Izaberite sobu");
                }
            }
            catch
            {
                MessageBox.Show("Greska pri ucitavanju sobe");
            }
        }

        private void btnSelectGuest_Click(object sender, EventArgs e)
        {
            try
            {
                int guestId = Int32.Parse(lstViewGuests.SelectedItems[0].SubItems[0].Text);
                Guest selectedGuest = ModelLister.Guests.Find(_guest => _guest.Id == guestId);


                if (selectedGuest != null)
                {
                    chosenGuest = selectedGuest;
                    txtGuest.Text = selectedGuest.FirstName + " " + selectedGuest.LastName;
                }
                else
                {
                    MessageBox.Show("Izaberite gosta");
                }
            }
            catch (Exception exed)
            {
                MessageBox.Show(exed.ToString());
            }
        }
        private void updatePrice()
        {
            price = calculateTotalPrice();

            if (price > 0)
            {
                lblTotalPrice.Text = "Cena: " + price.ToString() + "RSD";
            }
            else
            {
                lblTotalPrice.Text = "";
            }


        }

        private decimal calculateTotalPrice()
        {

            // Formula:
            // (([cena_sobe]+[cena_pansiona])*[tip_sobe]*[broj_dana])*(1 - [discount/100])
            int pensionPrice;
            switch (cbPension.Text)
            {
                case "Pun pansion":
                    pensionPrice = 1500;
                    break;
                case "Polu pansion":
                    pensionPrice = 600;
                    break;
                case "Samo dorucak":
                    pensionPrice = 300;
                    break;
                default:
                    pensionPrice = 1000;
                    break;
            }

            int roomType = chosenRoom.Type.ToLower() == "lux" ? 2 : 1;

            int totalDays = (int)(dateReservationTo.Value - dateReservationFrom.Value).TotalDays;
            if (totalDays == 0) { totalDays = 1; }

            return ((chosenRoom.Price + pensionPrice) * roomType * totalDays) * (1 - chosenRoom.Discount / 100);
        }

        private void btnRoomFilter_Click(object sender, EventArgs e)
        {
            lstViewRooms.Items.Clear();
            foreach (Room r in ModelLister.Rooms)
            {
                if (r.Taken) { continue; }
                if (cbRoomType.ToString().ToLower() == r.Type.ToLower()) { continue; }
                if ((int)numRoomBeds.Value < r.RoomNumber) { continue; }


                ListViewItem redLista = new ListViewItem();
                redLista.Text = r.Id.ToString();
                redLista.SubItems.Add(r.RoomNumber.ToString());
                redLista.SubItems.Add(r.Beds.ToString());
                redLista.SubItems.Add(r.Type);
                redLista.SubItems.Add(r.Price.ToString());
                redLista.SubItems.Add(r.Discount.ToString());
                redLista.SubItems.Add(r.MinDays.ToString());
                lstViewRooms.Items.Add(redLista);
            }
        }

        private void btnRoomReset_Click(object sender, EventArgs e)
        {
            populateRoomList();
        }

        private void btnAddNewGuest_Click(object sender, EventArgs e)
        {
            AddGuestForm dodajGosta = new AddGuestForm();
            dodajGosta.ShowDialog();
            populateGuestList();
        }

        private void cbPension_SelectedIndexChanged(object sender, EventArgs e)
        { 
            updatePrice();
        }

        private void dateReservationFrom_ValueChanged(object sender, EventArgs e)
        { 
            updatePrice();
        }

        private void dateReservationTo_ValueChanged(object sender, EventArgs e)
        { 
            updatePrice();
        }
    }
}
