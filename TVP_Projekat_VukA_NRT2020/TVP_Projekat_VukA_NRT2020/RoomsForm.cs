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
    public partial class RoomsForm : Form
    {
        public static int editRoomId;
        public RoomsForm()
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
        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {

            populateList();


        }

        private void populateList()
        {
            lstViewRooms.Items.Clear();
            foreach (Room r in ModelLister.Rooms)
            {
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

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoomForm dodajSobu = new AddRoomForm();
            dodajSobu.ShowDialog();
            populateList();
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(lstViewRooms.SelectedItems[0].SubItems[0].Text);
                Room removedRoom = ModelLister.Rooms.Find(_room => _room.Id == id);
                if (removedRoom != null)
                {
                    //Ovde se moze dodati failsafe koji proverava da li postoje rezervacije za izabranu sobu, tako da se ne dozvoli brisanje sobe na koju se vode rezervacije
                    ModelLister.Rooms.Remove(removedRoom);
                    ModelLister.saveRooms();
                    populateList();
                }
            }
            catch
            {
                MessageBox.Show("Nije uspelo brisanje sobe");
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            try
            {
                editRoomId = Int32.Parse(lstViewRooms.SelectedItems[0].SubItems[0].Text);
                Room selectedRoom = ModelLister.Rooms.Find(_room => _room.Id == editRoomId);


                if (selectedRoom != null)
                {
                    EditRoomForm izmeniSobu = new EditRoomForm();
                    izmeniSobu.ShowDialog();
                    populateList();
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

        private void btnSaveRooms_Click(object sender, EventArgs e)
        {
            ModelLister.saveRooms();
            Close();
        }
    }
}
