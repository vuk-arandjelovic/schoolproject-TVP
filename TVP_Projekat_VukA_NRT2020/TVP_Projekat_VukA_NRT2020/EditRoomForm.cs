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
    public partial class EditRoomForm : Form
    {
        private int roomId;
        private Room editRoom;
        public EditRoomForm()
        {
            InitializeComponent();
            roomId = RoomsForm.editRoomId;
            editRoom = ModelLister.Rooms.Find(_room => _room.Id == roomId);
            if (editRoom == null)
            {
                MessageBox.Show("Soba nije pronadjena!");
                Close();
            }
            numRoomNumber.Value = editRoom.RoomNumber;
            numRoomBeds.Value = editRoom.Beds;
            cbRoomType.Text = editRoom.Type;
            numPrice.Value = editRoom.Price;
            numRoomDiscount.Value = editRoom.Discount;
            numRoomDays.Value = editRoom.MinDays;
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            foreach (Room r in ModelLister.Rooms)
            {
                if (r.RoomNumber == numRoomNumber.Value)
                {
                    MessageBox.Show("Ova soba vec postoji.");
                    return;
                }
            }
            editRoom.RoomNumber = Int32.Parse(numRoomNumber.Value.ToString());
            editRoom.Beds = Int32.Parse(numRoomBeds.Value.ToString());
            editRoom.Type = cbRoomType.Text;
            editRoom.Price = Int32.Parse(numPrice.Value.ToString());
            editRoom.Discount = Int32.Parse(numRoomDiscount.Value.ToString());
            editRoom.MinDays = Int32.Parse(numRoomDays.Value.ToString());
            Close();
            
        }
    }
}
